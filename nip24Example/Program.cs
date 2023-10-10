/**
 * Copyright 2015-2023 NETCAT (www.netcat.pl)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * limitations under the License.
 *
 * @author NETCAT <firma@netcat.pl>
 * @copyright 2015-2023 NETCAT (www.netcat.pl)
 * @license http://www.apache.org/licenses/LICENSE-2.0
 */

using NIP24.Model;
using System;

namespace NIP24
{
	/// <summary>
	/// Przykładowy program testowy
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				// id – ciąg znaków reprezentujący identyfikator klucza API
				// key – ciąg znaków reprezentujący klucz API
				// NIP24Client nip24 = new NIP24Client("id", "key");

				NIP24Client nip24 = new NIP24Client();

				string nip = "7171642051";
                string nip_eu = "PL" + nip;
				string account_number = "49154000046458439719826658";
				string krs_number = "0000030897";

				AccountStatus account = nip24.GetAccountStatus();

				if (account != null)
				{
					Console.WriteLine(account);
				}
				else
				{
					Console.WriteLine("Błąd: " + nip24.LastError + " (kod: " + nip24.LastErrorCode + ")");
				}

				// Sprawdzenie statusu fimy
				bool active = nip24.IsActive(Number.NIP, nip);

				if (active)
				{
					Console.WriteLine("Firma prowadzi aktywną działalność");
				}
				else
				{
					if (String.IsNullOrEmpty(nip24.LastError))
					{
						Console.WriteLine("Firma zawiesiła lub zakończyła działalność");
					}
					else
					{
						Console.WriteLine("Błąd: " + nip24.LastError + " (kod: " + nip24.LastErrorCode + ")");
					}
				}

				VATStatus vat = nip24.GetVATStatus(Number.NIP, nip);

				if (vat != null)
				{
					Console.WriteLine(vat);
				}
				else
				{
					Console.WriteLine("Błąd: " + nip24.LastError + " (kod: " + nip24.LastErrorCode + ")");
				}

				// Wywołanie metody zwracającej dane do faktury
				InvoiceData invoice = nip24.GetInvoiceData(Number.NIP, nip);

				if (invoice != null)
				{
                    Console.WriteLine(invoice);
                }
                else
				{
					Console.WriteLine("Błąd: " + nip24.LastError + " (kod: " + nip24.LastErrorCode + ")");
				}

				// Wywołanie metody zwracającej szczegółowe dane firmy
				AllData all = nip24.GetAllData(Number.NIP, nip);

				if (all != null)
				{
					Console.WriteLine(all);
				}
				else
				{
					Console.WriteLine("Błąd: " + nip24.LastError + " (kod: " + nip24.LastErrorCode + ")");
				}

				// Wywołanie metody zwracającej dane z systemu VIES
				VIESData vies = nip24.GetVIESData(nip_eu);

                if (vies != null)
                {
                    Console.WriteLine(vies);
                }
                else
                {
					Console.WriteLine("Błąd: " + nip24.LastError + " (kod: " + nip24.LastErrorCode + ")");
				}

				// Wywołanie metody zwracającej informacje o rachunku bankowym
				IBANStatus iban = nip24.GetIBANStatus(Number.NIP, nip, account_number);

				if (iban != null)
				{
					Console.WriteLine(iban);
				}
				else
				{
					Console.WriteLine("Błąd: " + nip24.LastError + " (kod: " + nip24.LastErrorCode + ")");
				}

				// Wywołanie metody sprawdzającej status podmiotu na białej liście podatników VAT 
				WLStatus whitelist = nip24.GetWhitelistStatus(Number.NIP, nip, account_number);

				if (whitelist != null)
				{
					Console.WriteLine(whitelist);
				}
				else
				{
					Console.WriteLine("Błąd: " + nip24.LastError + " (kod: " + nip24.LastErrorCode + ")");
				}

				SearchResult result = nip24.SearchVATRegistry(Number.NIP, nip);

				if (result != null)
				{
					Console.WriteLine(result);
				}
				else
				{
					Console.WriteLine("Błąd: " + nip24.LastError + " (kod: " + nip24.LastErrorCode + ")");
				}

                // Wywołanie metody pobierającej pełne dane z KRS
                KRSData krs = nip24.GetKRSData(Number.KRS, krs_number);

                if (krs != null)
                {
                    Console.WriteLine(krs);
                }
                else
                {
                    Console.WriteLine("Błąd: " + nip24.LastError + " (kod: " + nip24.LastErrorCode + ")");
                }

                // Wywołanie metody pobierającej dane z KRS (np. tylko dział 1)
                krs = nip24.GetKRSSection(Number.KRS, krs_number, 1);

                if (krs != null)
                {
                    Console.WriteLine(krs);
                }
                else
                {
                    Console.WriteLine("Błąd: " + nip24.LastError + " (kod: " + nip24.LastErrorCode + ")");
                }
            }
            catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine(e.StackTrace);
			}
		}
	}
}
