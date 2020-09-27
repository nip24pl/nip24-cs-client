/**
 * Copyright 2015-2020 NETCAT (www.netcat.pl)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * @author NETCAT <firma@netcat.pl>
 * @copyright 2015-2020 NETCAT (www.netcat.pl)
 * @license http://www.apache.org/licenses/LICENSE-2.0
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace NIP24
{
	#region interface

	/// <summary>
	/// Interfejs klienta serwisu NIP24
	/// </summary>
	[Guid("80D40219-9D08-45C7-A255-44FC7A701578")]
	[ComVisible(true)]
	public interface INIP24Client
	{
		/// <summary>
		/// Ostatni kod błędu
		/// </summary>
		[DispId(1)]
		int LastErrorCode { get; set; }

		/// <summary>
		/// Ostatni komunikat błędu
		/// </summary>
		[DispId(2)]
		string LastError { get; set; }

		/// <summary>
		/// Adres URL serwisu
		/// </summary>
		[DispId(3)]
		string URL { get; set; }

		/// <summary>
		/// Identyfikator klucza klienta serwisu
		/// </summary>
		[DispId(4)]
		string Id { get; set; }

		/// <summary>
		/// Klucz klienta serwisu
		/// </summary>
		[DispId(5)]
		string Key { get; set; }

		/// <summary>
		/// Nazwa i wersja aplikacji korzystającej z klienta API
		/// </summary>
		[DispId(6)]
		string Application { get; set; }

		/// <summary>
		/// Proxy HTTP
		/// </summary>
		[DispId(7)]
		IWebProxy Proxy { get; set; }

		/// <summary>
		/// Flaga określająca wykorzystanie starych protokołów SSL/TLS przez biblitoekę
		/// </summary>
		[DispId(8)]
		bool LegacyProtocolsEnabled { get; set; }

		/// Sprawdzenie czy firma prowadzi aktywną działalność
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <returns>true jeżeli firma prowadzi aktywną działalność, false jeżeli firma zakończyła działalność</returns>
		[DispId(9)]
		bool IsActive(Number type, string number);

		/// <summary>
		/// Sprawdzenie czy firma prowadzi aktywną działalność
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <returns>true jeżeli firma prowadzi aktywną działalność, false jeżeli firma zakończyła działalność</returns>
		[DispId(10)]
		bool IsActive(string nip);

		/// <summary>
		/// Pobranie podstawowych danych firmy do faktury
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="force">parametr ignorowany, zostawiony dla zachowania kompatybilności wstecznej</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[DispId(11)]
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Proszę używać GetInvoiceData(Number, string)", true)]
		InvoiceData GetInvoiceData(Number type, string number, bool force = true);

		/// <summary>
		/// Pobranie podstawowych danych firmy do faktury
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[DispId(12)]
		InvoiceData GetInvoiceData(Number type, string number);

		/// <summary>
		/// Pobranie podstawowych danych firmy do faktury
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <param name="force">parametr ignorowany, zostawiony dla zachowania kompatybilności wstecznej</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[DispId(13)]
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Proszę używać GetInvoiceData(string)", true)]
		InvoiceData GetInvoiceData(string nip, bool force = true);

		/// <summary>
		/// Pobranie podstawowych danych firmy do faktury
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[DispId(14)]
		InvoiceData GetInvoiceData(string nip);

		/// <summary>
		/// Pobranie szczegółowych danych firmy
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="force">parametr ignorowany, zostawiony dla zachowania kompatybilności wstecznej</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[DispId(15)]
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Proszę używać GetAllData(Number, string)", true)]
		AllData GetAllData(Number type, string number, bool force = true);

		/// <summary>
		/// Pobranie szczegółowych danych firmy
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[DispId(16)]
		AllData GetAllData(Number type, string number);

		/// <summary>
		/// Pobranie szczegółowych danych firmy
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <param name="force">parametr ignorowany, zostawiony dla zachowania kompatybilności wstecznej</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[DispId(17)]
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Proszę używać GetAllData(string)", true)]
		AllData GetAllData(string nip, bool force = false);

		/// <summary>
		/// Pobranie szczegółowych danych firmy
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[DispId(18)]
		AllData GetAllData(string nip);

		/// <summary>
		/// Pobranie danych firmy z systemu VIES
		/// </summary>
		/// <param name="euvat">numer EU VAT ID</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[DispId(19)]
		VIESData GetVIESData(string euvat);

		/// <summary>
		/// Sprawdzenie statusu firmy w rejestrze VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="direct">parametr ignorowany, zostawiony dla zachowania kompatybilności wstecznej</param>
		/// <returns>status firmy lub null w przypadku błędu</returns>
		[DispId(20)]
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Proszę używać GetVATStatus(Number, string)", true)]
		VATStatus GetVATStatus(Number type, string number, bool direct = true);

		/// <summary>
		/// Sprawdzenie statusu firmy w rejestrze VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <returns>status firmy lub null w przypadku błędu</returns>
		[DispId(21)]
		VATStatus GetVATStatus(Number type, string number);

		/// <summary>
		/// Sprawdzenie statusu firmy w rejestrze VAT
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <param name="direct">parametr ignorowany, zostawiony dla zachowania kompatybilności wstecznej</param>
		/// <returns>status firmy lub null w przypadku błędu</returns>
		[DispId(22)]
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Proszę używać GetVATStatus(string)", true)]
		VATStatus GetVATStatus(string nip, bool direct = true);

		/// <summary>
		/// Sprawdzenie statusu firmy w rejestrze VAT
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <returns>status firmy lub null w przypadku błędu</returns>
		[DispId(23)]
		VATStatus GetVATStatus(string nip);

		/// <summary>
		/// Sprawdzenie statusu rachunku bankowego firmy
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <param name="date">dzień, którego ma dotyczyć sprawdzenie statusu w formacie 'yyyy-mm-dd' (null - bieżący dzień)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		[DispId(24)]
		IBANStatus GetIBANStatus(Number type, string number, string iban, string date);

		/// <summary>
		/// Sprawdzenie statusu rachunku bankowego firmy dla bieżącego dnia
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		[DispId(25)]
		IBANStatus GetIBANStatus(Number type, string number, string iban);

		/// <summary>
		/// Sprawdzenie statusu rachunku bankowego firmy dla bieżącego dnia
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		[DispId(26)]
		IBANStatus GetIBANStatus(string nip, string iban);

		/// <summary>
		/// Sprawdzenie statusu firmy na podstawie pliku białej listy podatników VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <param name="date">dzień, którego ma dotyczyć sprawdzenie statusu w formacie 'yyyy-mm-dd' (null - bieżący dzień)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		[DispId(27)]
		WLStatus GetWhitelistStatus(Number type, string number, string iban, string date);

		/// <summary>
		/// Sprawdzenie statusu firmy na podstawie pliku białej listy podatników VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		[DispId(28)]
		WLStatus GetWhitelistStatus(Number type, string number, string iban);

		/// <summary>
		/// Sprawdzenie statusu firmy na podstawie pliku białej listy podatników VAT
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		[DispId(29)]
		WLStatus GetWhitelistStatus(string nip, string iban);

		/// <summary>
		/// Wyszukiwanie danych w rejestrze VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="date">dzień, którego ma dotyczyć sprawdzenie statusu w formacie 'yyyy-mm-dd' (null - bieżący dzień)</param>
		/// <returns>wyszukane dane lub null w przypadku błędu</returns>
		[DispId(30)]
		SearchResult SearchVATRegistry(Number type, string number, string date);

		/// <summary>
		/// Wyszukiwanie danych w rejestrze VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <returns>wyszukane dane lub null w przypadku błędu</returns>
		[DispId(31)]
		SearchResult SearchVATRegistry(Number type, string number);

		/// <summary>
		/// Wyszukiwanie danych w rejestrze VAT
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <returns>wyszukane dane lub null w przypadku błędu</returns>
		[DispId(32)]
		SearchResult SearchVATRegistry(string nip);

		/// <summary>
		/// Sprawdzenie bieżącego stanu konta użytkownika
		/// </summary>
		/// <returns>status konta lub null w przypadku błędu</returns>
		[DispId(33)]
        AccountStatus GetAccountStatus();
    }

	#endregion

	#region implementation

	/// <summary>
	/// Klient serwisu NIP24
	/// </summary>
	[Guid("44016EE2-134C-4CEF-9CF8-719A0B5B417C")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NIP24Client : INIP24Client
	{
		public const string VERSION = "1.4.3";

		public const string PRODUCTION_URL = "https://www.nip24.pl/api";
		public const string TEST_URL = "https://www.nip24.pl/api-test";

		public const string TEST_ID = "test_id";
		public const string TEST_KEY = "test_key";

		/// <summary>
		/// Ostatni kod błędu
		/// </summary>
		public int LastErrorCode { get; set; }

		/// <summary>
		/// Ostatni komunikat błędu
		/// </summary>
		public string LastError { get; set; }

		/// <summary>
		/// Adres URL serwisu
		/// </summary>
		public string URL { get; set; }

		/// <summary>
		/// Identyfikator klucza klienta serwisu
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Klucz klienta serwisu
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// Nazwa i wersja aplikacji korzystającej z klienta API
		/// </summary>
		public string Application { get; set; }

		/// <summary>
		/// Proxy HTTP
		/// </summary>
		public IWebProxy Proxy { get; set; }

		/// <summary>
		/// Flaga określająca wykorzystanie starych protokołów SSL/TLS przez bibliotekę. W przypadku problemów
		/// z połączeniem do naszego serwisu ze starszych systemów Windows, proszę ustawić LegacyProtocolsEnabled = true
		/// </summary>
		public bool LegacyProtocolsEnabled { get; set; }

		private RandomNumberGenerator rng;

		/// <summary>
		/// Tworzy nowy obiekt klienta
		/// </summary>
		/// <param name="url">adres URL serwisu NIP24</param>
		/// <param name="id">identyfikator klucza klienta serwisu</param>
		/// <param name="key">klucz klienta serwisu</param>
		public NIP24Client(string url, string id, string key)
		{
			URL = url;
			Id = id;
			Key = key;

			Proxy = WebRequest.GetSystemWebProxy();
			
			Clear();

#if NIP24_COM
			LegacyProtocolsEnabled = true;
#else
			LegacyProtocolsEnabled = false;
#endif

			rng = new RNGCryptoServiceProvider();
		}

		/// <summary>
		/// Tworzy nowy obiekt klienta
		/// </summary>
		/// <param name="url">adres URL serwisu NIP24</param>
		/// <param name="id">identyfikator klucza klienta serwisu</param>
		/// <param name="key">klucz klienta serwisu</param>
		public NIP24Client(Uri url, string id, string key) : this(url.ToString(), id, key)
		{
		}

		/// <summary>
		/// Tworzy nowy obiekt klienta serwisu produkcyjnego
		/// </summary>
		/// <param name="id">identyfikator klucza klienta serwisu</param>
		/// <param name="key">klucz klienta serwisu</param>
		public NIP24Client(string id, string key) : this(PRODUCTION_URL, id, key)
		{
		}

		/// <summary>
		/// Tworzy nowy obiekt klienta serwisu testowego
		/// </summary>
		public NIP24Client() : this(TEST_URL, TEST_ID, TEST_KEY)
		{
		}

		/// <summary>
		/// Ustawia alternatywny adres API serwisu
		/// </summary>
		/// <param name="url">adres URL serwisu NIP24</param>
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Zamiast niej proszę użyć property URL", true)]
		public void setURL(Uri url)
		{
			URL = (url != null ? url.ToString() : null);
		}

		/// <summary>
		/// Ustawia alternatywny adres API serwisu
		/// </summary>
		/// <param name="url">adres URL serwisu NIP24</param>
		/// dep
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Zamiast niej proszę użyć property URL", true)]
		public void setURL(string url)
		{
			URL = url;
		}

		/// <summary>
		/// Sprawdzenie czy firma prowadzi aktywną działalność
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <returns>true jeżeli firma prowadzi aktywną działalność, false jeżeli firma zakończyła działalność</returns>
		public bool IsActive(Number type, string number)
		{
			try
			{
				// clear error
				Clear();

				// validate number and construct path
				string suffix = null;

				if ((suffix = GetPathSuffix(type, number)) == null)
				{
					return false;
				}

				// prepare url
				Uri url = new Uri(URL + "/check/firm/" + suffix);

				// prepare request
				XPathDocument doc = Get(url);

				if (doc == null)
				{
					Set(Error.CLI_CONNECT);
					return false;
				}

				// parse response
				string code = GetString(doc, "/result/error/code", null);

				if (code != null)
				{
					if (code.Equals("9"))
					{
						// not active
						Clear();
						return false;
					}
					else
					{
						Set(int.Parse(code), GetString(doc, "/result/error/description", null));
						return false;
					}
				}

				// active
				return true;
			}
			catch (Exception e)
			{
				Set(Error.CLI_EXCEPTION, e.Message);
			}

			return false;
		}

		/// <summary>
		/// Sprawdzenie czy firma prowadzi aktywną działalność
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <returns>true jeżeli firma prowadzi aktywną działalność, false jeżeli firma zakończyła działalność</returns>
		public bool IsActive(string nip)
		{
			return IsActive(Number.NIP, nip);
		}

		/// <summary>
		/// Pobranie podstawowych danych firmy do faktury
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="force">parametr ignorowany, zostawiony dla zachowania kompatybilności wstecznej</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Proszę używać GetInvoiceData(Number, string)", true)]
		public InvoiceData GetInvoiceData(Number type, string number, bool force = true)
		{
			return GetInvoiceData(type, number);
		}

		/// <summary>
		/// Pobranie podstawowych danych firmy do faktury
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		public InvoiceData GetInvoiceData(Number type, string number)
		{
			try
			{
				// clear error
				Clear();

				// validate number and construct path
				string suffix = null;

				if ((suffix = GetPathSuffix(type, number)) == null)
				{
					return null;
				}

				// prepare url
				Uri url = new Uri(URL + "/get/invoice/" + suffix);

				// prepare request
				XPathDocument doc = Get(url);

				if (doc == null)
				{
					Set(Error.CLI_CONNECT);
					return null;
				}

				// parse response
				string code = GetString(doc, "/result/error/code", null);

				if (code != null)
				{
					Set(int.Parse(code), GetString(doc, "/result/error/description", null));
					return null;
				}

				InvoiceData id = new InvoiceData();

				id.UID = GetString(doc, "/result/firm/uid", null);

				id.NIP = GetString(doc, "/result/firm/nip", null);

				id.Name = GetString(doc, "/result/firm/name", null);
				id.FirstName = GetString(doc, "/result/firm/firstname", null);
				id.LastName = GetString(doc, "/result/firm/lastname", null);

				id.Street = GetString(doc, "/result/firm/street", null);
				id.StreetNumber = GetString(doc, "/result/firm/streetNumber", null);
				id.HouseNumber = GetString(doc, "/result/firm/houseNumber", null);
				id.City = GetString(doc, "/result/firm/city", null);
				id.PostCode = GetString(doc, "/result/firm/postCode", null);
				id.PostCity = GetString(doc, "/result/firm/postCity", null);

				id.Phone = GetString(doc, "/result/firm/phone", null);
				id.Email = GetString(doc, "/result/firm/email", null);
				id.WWW = GetString(doc, "/result/firm/www", null);

				return id;
			}
			catch (Exception e)
			{
				Set(Error.CLI_EXCEPTION, e.Message);
			}

			return null;
		}

		/// <summary>
		/// Pobranie podstawowych danych firmy do faktury
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <param name="force">parametr ignorowany, zostawiony dla zachowania kompatybilności wstecznej</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Proszę używać GetInvoiceData(string)", true)]
		public InvoiceData GetInvoiceData(string nip, bool force = true)
		{
			return GetInvoiceData(Number.NIP, nip);
		}

		/// <summary>
		/// Pobranie podstawowych danych firmy do faktury
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		public InvoiceData GetInvoiceData(string nip)
		{
			return GetInvoiceData(Number.NIP, nip);
		}

		/// <summary>
		/// Pobranie szczegółowych danych firmy
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="force">parametr ignorowany, zostawiony dla zachowania kompatybilności wstecznej</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Proszę używać GetAllData(Number, string)", true)]
		public AllData GetAllData(Number type, string number, bool force = true)
		{
			return GetAllData(type, number);
		}

		/// <summary>
		/// Pobranie szczegółowych danych firmy
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		public AllData GetAllData(Number type, string number)
		{
			try
			{
				// clear error
				Clear();

				// validate number and construct path
				string suffix = null;

				if ((suffix = GetPathSuffix(type, number)) == null)
				{
					return null;
				}

				// prepare url
				Uri url = new Uri(URL + "/get/all/" + suffix);

				// prepare request
				XPathDocument doc = Get(url);

				if (doc == null)
				{
					Set(Error.CLI_CONNECT);
					return null;
				}

				// parse response
				string code = GetString(doc, "/result/error/code", null);

				if (code != null)
				{
					Set(int.Parse(code), GetString(doc, "/result/error/description", null));
					return null;
				}

				AllData ad = new AllData();

				ad.UID = GetString(doc, "/result/firm/uid", null);

				ad.Type = GetString(doc, "/result/firm/type", null);
				ad.NIP = GetString(doc, "/result/firm/nip", null);
				ad.REGON = GetString(doc, "/result/firm/regon", null);

				ad.Name = GetString(doc, "/result/firm/name", null);
				ad.ShortName = GetString(doc, "/result/firm/shortname", null);
				ad.FirstName = GetString(doc, "/result/firm/firstname", null);
				ad.SecondName = GetString(doc, "/result/firm/secondname", null);
				ad.LastName = GetString(doc, "/result/firm/lastname", null);

				ad.Street = GetString(doc, "/result/firm/street", null);
				ad.StreetCode = GetString(doc, "/result/firm/streetCode", null);
				ad.StreetNumber = GetString(doc, "/result/firm/streetNumber", null);
				ad.HouseNumber = GetString(doc, "/result/firm/houseNumber", null);
				ad.City = GetString(doc, "/result/firm/city", null);
				ad.CityCode = GetString(doc, "/result/firm/cityCode", null);
				ad.Community = GetString(doc, "/result/firm/community", null);
				ad.CommunityCode = GetString(doc, "/result/firm/communityCode", null);
				ad.County = GetString(doc, "/result/firm/county", null);
				ad.CountyCode = GetString(doc, "/result/firm/countyCode", null);
				ad.State = GetString(doc, "/result/firm/state", null);
				ad.StateCode = GetString(doc, "/result/firm/stateCode", null);
				ad.PostCode = GetString(doc, "/result/firm/postCode", null);
				ad.PostCity = GetString(doc, "/result/firm/postCity", null);

				ad.Phone = GetString(doc, "/result/firm/phone", null);
				ad.Email = GetString(doc, "/result/firm/email", null);
				ad.WWW = GetString(doc, "/result/firm/www", null);

				ad.CreationDate = GetDateTime(doc, "/result/firm/creationDate");
				ad.StartDate = GetDateTime(doc, "/result/firm/startDate");
				ad.RegistrationDate = GetDateTime(doc, "/result/firm/registrationDate");
				ad.HoldDate = GetDateTime(doc, "/result/firm/holdDate");
				ad.RenevalDate = GetDateTime(doc, "/result/firm/renevalDate");
				ad.LastUpdateDate = GetDateTime(doc, "/result/firm/lastUpdateDate");
				ad.EndDate = GetDateTime(doc, "/result/firm/endDate");

				ad.RegistryEntityCode = GetString(doc, "/result/firm/registryEntity/code", null);
				ad.RegistryEntityName = GetString(doc, "/result/firm/registryEntity/name", null);

				ad.RegistryCode = GetString(doc, "/result/firm/registry/code", null);
				ad.RegistryName = GetString(doc, "/result/firm/registry/name", null);

				ad.RecordCreationDate = GetDateTime(doc, "/result/firm/record/created");
				ad.RecordNumber = GetString(doc, "/result/firm/record/number", null);

				ad.BasicLegalFormCode = GetString(doc, "/result/firm/basicLegalForm/code", null);
				ad.BasicLegalFormName = GetString(doc, "/result/firm/basicLegalForm/name", null);

				ad.SpecificLegalFormCode = GetString(doc, "/result/firm/specificLegalForm/code", null);
				ad.SpecificLegalFormName = GetString(doc, "/result/firm/specificLegalForm/name", null);

				ad.OwnershipFormCode = GetString(doc, "/result/firm/ownershipForm/code", null);
				ad.OwnershipFormName = GetString(doc, "/result/firm/ownershipForm/name", null);

				for (int i = 1; ; i++)
				{
					string pkdcode = GetString(doc, "/result/firm/PKDs/PKD[" + i + "]/code", null);

					if (pkdcode == null)
					{
						break;
					}

					string descr = GetString(doc, "/result/firm/PKDs/PKD[" + i + "]/description", null);
					string pri = GetString(doc, "/result/firm/PKDs/PKD[" + i + "]/primary", "false");

					PKD pkd = new PKD();

					pkd.Code = pkdcode;
					pkd.Description = descr;
					pkd.Primary = pri.Equals("true");

					ad.PKD.Add(pkd);
				}

				return ad;
			}
			catch (Exception e)
			{
				Set(Error.CLI_EXCEPTION, e.Message);
			}

			return null;
		}

		/// <summary>
		/// Pobranie szczegółowych danych firmy
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <param name="force">parametr ignorowany, zostawiony dla zachowania kompatybilności wstecznej</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Proszę używać GetAllData(string)", true)]
		public AllData GetAllData(string nip, bool force = true)
		{
			return GetAllData(Number.NIP, nip);
		}

		/// <summary>
		/// Pobranie szczegółowych danych firmy
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		public AllData GetAllData(string nip)
		{
			return GetAllData(Number.NIP, nip);
		}

		/// <summary>
		/// Pobranie danych firmy z systemu VIES
		/// </summary>
		/// <param name="euvat">numer EU VAT ID</param>
		/// <returns>dane firmy lub null w przypadku błędu</returns>
		public VIESData GetVIESData(string euvat)
		{
			try
			{
				// clear error
				Clear();

				// validate number and construct path
				string suffix = null;

				if ((suffix = GetPathSuffix(Number.EUVAT, euvat)) == null)
				{
					return null;
				}

				// prepare url
				Uri url = new Uri(URL + "/get/vies/" + suffix);

				// prepare request
				XPathDocument doc = Get(url);

				if (doc == null)
				{
					Set(Error.CLI_CONNECT);
					return null;
				}

				// parse response
				string code = GetString(doc, "/result/error/code", null);

				if (code != null)
				{
					Set(int.Parse(code), GetString(doc, "/result/error/description", null));
					return null;
				}

				VIESData vies = new VIESData();

				vies.UID = GetString(doc, "/result/vies/uid", null);

				vies.CountryCode = GetString(doc, "/result/vies/countryCode", null);
				vies.VATNumber = GetString(doc, "/result/vies/vatNumber", null);

				vies.Valid = GetString(doc, "/result/vies/valid", "false").Equals("true");

				vies.TraderName = GetString(doc, "/result/vies/traderName", null);
				vies.TraderCompanyType = GetString(doc, "/result/vies/traderCompanyType", null);
				vies.TraderAddress = GetString(doc, "/result/vies/traderAddress", null);

				vies.ID = GetString(doc, "/result/vies/id", null);
				vies.Date = GetDateTime(doc, "/result/vies/date");
				vies.Source = GetString(doc, "/result/vies/source", null);

				return vies;
			}
			catch (Exception e)
			{
				Set(Error.CLI_EXCEPTION, e.Message);
			}

			return null;
		}

		/// <summary>
		/// Sprawdzenie statusu firmy w rejestrze VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="direct">parametr ignorowany, zostawiony dla zachowania kompatybilności wstecznej</param>
		/// <returns>status firmy lub null w przypadku błędu</returns>
		[Obsolete("Ta metoda będzie usunięta w kolejnej wersji API. Proszę używać GetVATStatus(Number, string)", true)]
		public VATStatus GetVATStatus(Number type, string number, bool direct = true)
		{
			return GetVATStatus(type, number);
		}

		/// <summary>
		/// Sprawdzenie statusu firmy w rejestrze VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <returns>status firmy lub null w przypadku błędu</returns>
		public VATStatus GetVATStatus(Number type, string number)
		{
			try
			{
				// clear error
				Clear();

				// validate number and construct path
				string suffix = null;

				if ((suffix = GetPathSuffix(type, number)) == null)
				{
					return null;
				}

				// prepare url
				Uri url = new Uri(URL + "/check/vat/direct/" + suffix);

				// prepare request
				XPathDocument doc = Get(url);

				if (doc == null)
				{
					Set(Error.CLI_CONNECT);
					return null;
				}

				// parse response
				string code = GetString(doc, "/result/error/code", null);

				if (code != null)
				{
					Set(int.Parse(code), GetString(doc, "/result/error/description", null));
					return null;
				}

				VATStatus vat = new VATStatus();

				vat.UID = GetString(doc, "/result/vat/uid", null);

				vat.NIP = GetString(doc, "/result/vat/nip", null);
				vat.REGON = GetString(doc, "/result/vat/regon", null);
				vat.Name = GetString(doc, "/result/vat/name", null);

				vat.Status = int.Parse(GetString(doc, "/result/vat/status", "0"));
				vat.Result = GetString(doc, "/result/vat/result", null);

				vat.Date = GetDateTime(doc, "/result/vat/date");
				vat.Source = GetString(doc, "/result/vat/source", null);

				return vat;
			}
			catch (Exception e)
			{
				Set(Error.CLI_EXCEPTION, e.Message);
			}

			return null;
		}

		/// <summary>
		/// Sprawdzenie statusu firmy w rejestrze VAT
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <param name="direct">parametr ignorowany, zostawiony dla zachowania kompatybilności wstecznej</param>
		/// <returns>status firmy lub null w przypadku błędu</returns>
		[Obsolete("Funkcja zostanie usunięta w kolejnych wersjach, proszę używać GetVATStatus(string)", true)]
		public VATStatus GetVATStatus(string nip, bool direct = true)
		{
			return GetVATStatus(Number.NIP, nip);
		}

		/// <summary>
		/// Sprawdzenie statusu firmy w rejestrze VAT
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <returns>status firmy lub null w przypadku błędu</returns>
		public VATStatus GetVATStatus(string nip)
		{
			return GetVATStatus(Number.NIP, nip);
		}

		/// <summary>
		/// Sprawdzenie statusu rachunku bankowego firmy
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <param name="date">dzień, którego ma dotyczyć sprawdzenie statusu (null - bieżący dzień)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		[ComVisible(false)]
		public IBANStatus GetIBANStatus(Number type, string number, string iban, DateTime? date)
		{
			try
			{
				// clear error
				Clear();

				// validate number and construct path
				string suffix = null;

				if ((suffix = GetPathSuffix(type, number)) == null)
				{
					return null;
				}

				if (!IBAN.IsValid(iban))
				{
					iban = "PL" + iban;

					if (!IBAN.IsValid(iban))
					{
						Set(Error.CLI_IBAN);
						return null;
					}
				}

				if (!date.HasValue)
				{
					date = DateTime.Now;
				}

				// prepare url
				Uri url = new Uri(URL + "/check/iban/" + suffix + "/" + IBAN.Normalize(iban) + "/" + date.Value.ToString("yyyy-MM-dd"));

				// prepare request
				XPathDocument doc = Get(url);

				if (doc == null)
				{
					Set(Error.CLI_CONNECT);
					return null;
				}

				// parse response
				string code = GetString(doc, "/result/error/code", null);

				if (code != null)
				{
					Set(int.Parse(code), GetString(doc, "/result/error/description", null));
					return null;
				}

				IBANStatus ibs = new IBANStatus();

				ibs.UID = GetString(doc, "/result/iban/uid", null);

				ibs.NIP = GetString(doc, "/result/iban/nip", null);
				ibs.REGON = GetString(doc, "/result/iban/regon", null);
				ibs.IBAN = GetString(doc, "/result/iban/iban", null);

				ibs.Valid = GetString(doc, "/result/iban/valid", "false").Equals("true");

				ibs.ID = GetString(doc, "/result/iban/id", null);
				ibs.Date = GetDateTime(doc, "/result/iban/date");
				ibs.Source = GetString(doc, "/result/iban/source", null);

				return ibs;
			}
			catch (Exception e)
			{
				Set(Error.CLI_EXCEPTION, e.Message);
			}

			return null;
		}

		/// <summary>
		/// Sprawdzenie statusu rachunku bankowego firmy
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <param name="date">dzień, którego ma dotyczyć sprawdzenie statusu w formacie 'yyyy-mm-dd' (null - bieżący dzień)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		public IBANStatus GetIBANStatus(Number type, string number, string iban, string date)
		{
			DateTime? dt = null;

			if (!string.IsNullOrEmpty(date))
			{
				try
				{
					dt = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
				}
				catch (Exception)
				{
					Set(Error.CLI_DATEFORMAT);
					return null;
				}
			}

			return GetIBANStatus(type, number, iban, dt);
		}

		/// <summary>
		/// Sprawdzenie statusu rachunku bankowego firmy dla bieżącego dnia
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		public IBANStatus GetIBANStatus(Number type, string number, string iban)
		{
			return GetIBANStatus(type, number, iban, (string)null);
		}

		/// <summary>
		/// Sprawdzenie statusu rachunku bankowego firmy dla bieżącego dnia
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		public IBANStatus GetIBANStatus(string nip, string iban)
		{
			return GetIBANStatus(Number.NIP, nip, iban, (string)null);
		}

		/// <summary>
		/// Sprawdzenie statusu firmy na podstawie pliku białej listy podatników VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <param name="date">dzień, którego ma dotyczyć sprawdzenie statusu (null - bieżący dzień)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		[ComVisible(false)]
		public WLStatus GetWhitelistStatus(Number type, string number, string iban, DateTime? date)
		{
			try
			{
				// clear error
				Clear();

				// validate number and construct path
				string suffix = null;

				if ((suffix = GetPathSuffix(type, number)) == null)
				{
					return null;
				}

				if (!IBAN.IsValid(iban))
				{
					iban = "PL" + iban;

					if (!IBAN.IsValid(iban))
					{
						Set(Error.CLI_IBAN);
						return null;
					}
				}

				if (!date.HasValue)
				{
					date = DateTime.Now;
				}

				// prepare url
				Uri url = new Uri(URL + "/check/whitelist/" + suffix + "/" + IBAN.Normalize(iban) + "/" + date.Value.ToString("yyyy-MM-dd"));

				// prepare request
				XPathDocument doc = Get(url);

				if (doc == null)
				{
					Set(Error.CLI_CONNECT);
					return null;
				}

				// parse response
				string code = GetString(doc, "/result/error/code", null);

				if (code != null)
				{
					Set(int.Parse(code), GetString(doc, "/result/error/description", null));
					return null;
				}

				WLStatus wls = new WLStatus();

				wls.UID = GetString(doc, "/result/whitelist/uid", null);

				wls.NIP = GetString(doc, "/result/whitelist/nip", null);
				wls.IBAN = GetString(doc, "/result/whitelist/iban", null);

				wls.Valid = GetString(doc, "/result/whitelist/valid", "false").Equals("true");
				wls.Virtual = GetString(doc, "/result/whitelist/virtual", "false").Equals("true");

				wls.Status = int.Parse(GetString(doc, "/result/whitelist/vatStatus", "0"));
				wls.Result = GetString(doc, "/result/whitelist/vatResult", null);

				wls.HashIndex = int.Parse(GetString(doc, "/result/whitelist/hashIndex", "-1"));
				wls.MaskIndex = int.Parse(GetString(doc, "/result/whitelist/maskIndex", "-1"));
				wls.Date = GetDateTime(doc, "/result/whitelist/date");
				wls.Source = GetString(doc, "/result/whitelist/source", null);

				return wls;
			}
			catch (Exception e)
			{
				Set(Error.CLI_EXCEPTION, e.Message);
			}

			return null;
		}

		/// <summary>
		/// Sprawdzenie statusu firmy na podstawie pliku białej listy podatników VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <param name="date">dzień, którego ma dotyczyć sprawdzenie statusu w formacie 'yyyy-mm-dd' (null - bieżący dzień)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		public WLStatus GetWhitelistStatus(Number type, string number, string iban, string date)
		{
			DateTime? dt = null;

			if (!string.IsNullOrEmpty(date))
			{
				try
				{
					dt = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
				}
				catch (Exception)
				{
					Set(Error.CLI_DATEFORMAT);
					return null;
				}
			}

			return GetWhitelistStatus(type, number, iban, dt);
		}

		/// <summary>
		/// Sprawdzenie statusu firmy na podstawie pliku białej listy podatników VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		public WLStatus GetWhitelistStatus(Number type, string number, string iban)
		{
			return GetWhitelistStatus(type, number, iban, (string)null);
		}

		/// <summary>
		/// Sprawdzenie statusu firmy na podstawie pliku białej listy podatników VAT
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <param name="iban">numer IBAN rachunku do sprawdzenia (polskie rachunki mogą być bez prefiksu PL)</param>
		/// <returns>bieżący status rachunku bankowego lub null w przypadku błędu</returns>
		public WLStatus GetWhitelistStatus(string nip, string iban)
		{
			return GetWhitelistStatus(Number.NIP, nip, iban, (string)null);
		}

		/// <summary>
		/// Wyszukiwanie danych w rejestrze VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="date">dzień, którego ma dotyczyć sprawdzenie statusu (null - bieżący dzień)</param>
		/// <returns>wyszukane dane lub null w przypadku błędu</returns>
		[ComVisible(false)]
		public SearchResult SearchVATRegistry(Number type, string number, DateTime? date)
		{
			try
			{
				// clear error
				Clear();

				// validate number and construct path
				string suffix = null;

				if ((suffix = GetPathSuffix(type, number)) == null)
				{
					return null;
				}

				if (!date.HasValue)
				{
					date = DateTime.Now;
				}

				// prepare url
				Uri url = new Uri(URL + "/search/vat/" + suffix + "/" + date.Value.ToString("yyyy-MM-dd"));

				// prepare request
				XPathDocument doc = Get(url);

				if (doc == null)
				{
					Set(Error.CLI_CONNECT);
					return null;
				}

				// parse response
				string code = GetString(doc, "/result/error/code", null);

				if (code != null)
				{
					Set(int.Parse(code), GetString(doc, "/result/error/description", null));
					return null;
				}

				SearchResult sr = new SearchResult();

				sr.UID = GetString(doc, "/result/search/uid", null);

				for (int i = 1; ; i++)
				{
					string nip = GetString(doc, "/result/search/entities/entity[" + i + "]/nip", null);

					if (nip == null)
					{
						break;
					}

					VATEntity ve = new VATEntity();

					ve.Name = GetString(doc, "/result/search/entities/entity[" + i + "]/name", null);
					ve.NIP = NIP.Normalize(nip);
					ve.REGON = REGON.Normalize(GetString(doc, "/result/search/entities/entity[" + i + "]/regon", null));
					ve.KRS = KRS.Normalize(GetString(doc, "/result/search/entities/entity[" + i + "]/krs", null));
					ve.ResidenceAddress = GetString(doc, "/result/search/entities/entity[" + i + "]/residenceAddress", null);
					ve.WorkingAddress = GetString(doc, "/result/search/entities/entity[" + i + "]/workingAddress", null);
					ve.VATStatus = int.Parse(GetString(doc, "/result/search/entities/entity[" + i + "]/vat/status", "0"));
					ve.VATResult = GetString(doc, "/result/search/entities/entity[" + i + "]/vat/result", null);

					GetVATPerson(doc, "/result/search/entities/entity[" + i + "]/representatives", ve.Representatives);
					GetVATPerson(doc, "/result/search/entities/entity[" + i + "]/authorizedClerks", ve.AuthorizedClerks);
					GetVATPerson(doc, "/result/search/entities/entity[" + i + "]/partners", ve.Partners);

					for (int k = 1; ; k++)
					{
						string iban = GetString(doc, "/result/search/entities/entity[" + i + "]/ibans/iban[" + k + "]", null);

						if (iban == null) {
							break;
						}

						ve.IBANs.Add(iban);
					}

					ve.HasVirtualAccounts = GetString(doc, "/result/search/entities/entity[" + i + "]/hasVirtualAccounts", "false").Equals("true");
					ve.RegistrationLegalDate = GetDateTime(doc, "/result/search/entities/entity[" + i + "]/registrationLegalDate");
					ve.RegistrationDenialDate = GetDateTime(doc, "/result/search/entities/entity[" + i + "]/registrationDenialDate");
					ve.RegistrationDenialBasis = GetString(doc, "/result/search/entities/entity[" + i + "]/registrationDenialBasis", null);
					ve.RestorationDate = GetDateTime(doc, "/result/search/entities/entity[" + i + "]/restorationDate");
					ve.RestorationBasis = GetString(doc, "/result/search/entities/entity[" + i + "]/restorationBasis", null);
					ve.RemovalDate = GetDateTime(doc, "/result/search/entities/entity[" + i + "]/removalDate");
					ve.RemovalBasis = GetString(doc, "/result/search/entities/entity[" + i + "]/removalBasis", null);

					sr.Results.Add(ve);
				}

				sr.ID = GetString(doc, "/result/search/id", null);
				sr.Date = GetDateTime(doc, "/result/search/date");
				sr.Source = GetString(doc, "/result/search/source", null);

				return sr;
			}
			catch (Exception e)
			{
				Set(Error.CLI_EXCEPTION, e.Message);
			}

			return null;
		}

		/// <summary>
		/// Wyszukiwanie danych w rejestrze VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <param name="date">dzień, którego ma dotyczyć sprawdzenie statusu w formacie 'yyyy-mm-dd' (null - bieżący dzień)</param>
		/// <returns>wyszukane dane lub null w przypadku błędu</returns>
		public SearchResult SearchVATRegistry(Number type, string number, string date)
		{
			DateTime? dt = null;

			if (!string.IsNullOrEmpty(date))
			{
				try
				{
					dt = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
				}
				catch (Exception)
				{
					Set(Error.CLI_DATEFORMAT);
					return null;
				}
			}

			return SearchVATRegistry(type, number, dt);
		}

		/// <summary>
		/// Wyszukiwanie danych w rejestrze VAT
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <returns>wyszukane dane lub null w przypadku błędu</returns>
		public SearchResult SearchVATRegistry(Number type, string number)
		{
			return SearchVATRegistry(type, number, (string)null);
		}

		/// <summary>
		/// Wyszukiwanie danych w rejestrze VAT
		/// </summary>
		/// <param name="nip">numer NIP</param>
		/// <returns>wyszukane dane lub null w przypadku błędu</returns>
		public SearchResult SearchVATRegistry(string nip)
		{
			return SearchVATRegistry(Number.NIP, nip, (string)null);
		}

		/// <summary>
		/// Sprawdzenie bieżącego stanu konta użytkownika
		/// </summary>
		/// <returns>status konta lub null w przypadku błędu</returns>
		public AccountStatus GetAccountStatus()
		{
			try
			{
				// clear error
				Clear();

				// prepare url
				Uri url = new Uri(URL + "/check/account/status");

				// prepare request
				XPathDocument doc = Get(url);

				if (doc == null)
				{
					Set(Error.CLI_CONNECT);
					return null;
				}

				// parse response
				string code = GetString(doc, "/result/error/code", null);

				if (code != null)
				{
					Set(int.Parse(code), GetString(doc, "/result/error/description", null));
					return null;
				}

				AccountStatus status = new AccountStatus();

				status.UID = GetString(doc, "/result/account/uid", null);
				status.Type = GetString(doc, "/result/account/type", null);
				status.ValidTo = GetDateTime(doc, "/result/account/validTo");
				status.BillingPlanName = GetString(doc, "/result/account/billingPlan/name", null);

				status.SubscriptionPrice = decimal.Parse(GetString(doc, "/result/account/billingPlan/subscriptionPrice", "0"), CultureInfo.InvariantCulture);
				status.ItemPrice = decimal.Parse(GetString(doc, "/result/account/billingPlan/itemPrice", "0"), CultureInfo.InvariantCulture);
				status.ItemPriceStatus = decimal.Parse(GetString(doc, "/result/account/billingPlan/itemPriceCheckStatus", "0"), CultureInfo.InvariantCulture);
				status.ItemPriceInvoice = decimal.Parse(GetString(doc, "/result/account/billingPlan/itemPriceInvoiceData", "0"), CultureInfo.InvariantCulture);
				status.ItemPriceAll = decimal.Parse(GetString(doc, "/result/account/billingPlan/itemPriceAllData", "0"), CultureInfo.InvariantCulture);
				status.ItemPriceIBAN = decimal.Parse(GetString(doc, "/result/account/billingPlan/itemPriceIBANStatus", "0"), CultureInfo.InvariantCulture);
				status.ItemPriceWhitelist = decimal.Parse(GetString(doc, "/result/account/billingPlan/itemPriceWLStatus", "0"), CultureInfo.InvariantCulture);
				status.ItemPriceSearchVAT = decimal.Parse(GetString(doc, "/result/account/billingPlan/itemPriceSearchVAT", "0"), CultureInfo.InvariantCulture);

				status.Limit = int.Parse(GetString(doc, "/result/account/billingPlan/limit", "0"));
				status.RequestDelay = int.Parse(GetString(doc, "/result/account/billingPlan/requestDelay", "0"));
				status.DomainLimit = int.Parse(GetString(doc, "/result/account/billingPlan/domainLimit", "0"));

				status.OverPlanAllowed = GetString(doc, "/result/account/billingPlan/overplanAllowed", "false").Equals("true");
				status.TerytCodes = GetString(doc, "/result/account/billingPlan/terytCodes", "false").Equals("true");
				status.ExcelAddIn = GetString(doc, "/result/account/billingPlan/excelAddin", "false").Equals("true");
				status.JPKVAT = GetString(doc, "/result/account/billingPlan/jpkVat", "false").Equals("true");
				status.CLI = GetString(doc, "/result/account/billingPlan/cli", "false").Equals("true");
				status.Stats = GetString(doc, "/result/account/billingPlan/stats", "false").Equals("true");
				status.NIPMonitor = GetString(doc, "/result/account/billingPlan/nipMonitor", "false").Equals("true");

				status.SearchByNIP = GetString(doc, "/result/account/billingPlan/searchByNip", "false").Equals("true");
				status.SearchByREGON = GetString(doc, "/result/account/billingPlan/searchByRegon", "false").Equals("true");
				status.SearchByKRS = GetString(doc, "/result/account/billingPlan/searchByKrs", "false").Equals("true");

				status.FuncIsActive = GetString(doc, "/result/account/billingPlan/funcIsActive", "false").Equals("true");
				status.FuncGetInvoiceData = GetString(doc, "/result/account/billingPlan/funcGetInvoiceData", "false").Equals("true");
				status.FuncGetAllData = GetString(doc, "/result/account/billingPlan/funcGetAllData", "false").Equals("true");
				status.FuncGetVIESData = GetString(doc, "/result/account/billingPlan/funcGetVIESData", "false").Equals("true");
				status.FuncGetVATStatus = GetString(doc, "/result/account/billingPlan/funcGetVATStatus", "false").Equals("true");
				status.FuncGetIBANStatus = GetString(doc, "/result/account/billingPlan/funcGetIBANStatus", "false").Equals("true");
				status.FuncGetWhitelistStatus = GetString(doc, "/result/account/billingPlan/funcGetWLStatus", "false").Equals("true");
				status.FuncSearchVAT = GetString(doc, "/result/account/billingPlan/funcSearchVAT", "false").Equals("true");

				status.InvoiceDataCount = int.Parse(GetString(doc, "/result/account/requests/invoiceData", "0"));
				status.AllDataCount = int.Parse(GetString(doc, "/result/account/requests/allData", "0"));
				status.FirmStatusCount = int.Parse(GetString(doc, "/result/account/requests/firmStatus", "0"));
				status.VATStatusCount = int.Parse(GetString(doc, "/result/account/requests/vatStatus", "0"));
				status.VIESStatusCount = int.Parse(GetString(doc, "/result/account/requests/viesStatus", "0"));
				status.IBANStatusCount = int.Parse(GetString(doc, "/result/account/requests/ibanStatus", "0"));
				status.WhitelistStatusCount = int.Parse(GetString(doc, "/result/account/requests/wlStatus", "0"));
				status.SearchVATCount = int.Parse(GetString(doc, "/result/account/requests/searchVAT", "0"));
				status.TotalCount = int.Parse(GetString(doc, "/result/account/requests/total", "0"));

				return status;
			}
			catch (Exception e)
			{
				Set(Error.CLI_EXCEPTION, e.Message);
			}

			return null;
		}

		/// <summary>
		/// Wyzerowanie informacji o błędzie
		/// </summary>
		private void Clear()
		{
			LastErrorCode = 0;
			LastError = string.Empty;
		}

		/// <summary>
		/// Ustawienie kodu błędu
		/// </summary>
		/// <param name="code">kod błędu</param>
		/// <param name="err">komunikat</param>
		private void Set(int code, string err = null)
		{
			LastErrorCode = code;
			LastError = (string.IsNullOrEmpty(err) ? Error.Message(code) : err);
		}

		/// <summary>
		/// Metoda HTTP GET
		/// </summary>
		/// <param name="url">adres URL</param>
		/// <returns>pobrana odpowiedź lub null</returns>
		private XPathDocument Get(Uri url)
		{
			XPathDocument doc = null;

			try
			{
				if (!LegacyProtocolsEnabled)
				{
					// SecurityProtocolType:
					// Tls		192
					// Tls11	768
					// Tls12	3072
					// Tls13	12288
					try
					{
						ServicePointManager.SecurityProtocol = (SecurityProtocolType)768 | (SecurityProtocolType)3072 | (SecurityProtocolType)12288;
					}
					catch (Exception e1)
					{
						// no tls13
						try
						{
							ServicePointManager.SecurityProtocol = (SecurityProtocolType)768 | (SecurityProtocolType)3072;
						}
						catch (Exception e2)
						{
							// no tls12
							try
							{
								ServicePointManager.SecurityProtocol = (SecurityProtocolType)768;
							}
							catch (Exception e3)
							{
								// no tls11
							}
						}
					}
				}

				using (WebClient wc = new WebClient())
				{
					wc.Proxy = Proxy;

					wc.Headers.Set("Authorization", GetAuthHeader("GET", url));
					wc.Headers.Set("User-Agent", GetAgentHeader());

					byte[] b = wc.DownloadData(url);

					doc = new XPathDocument(new MemoryStream(b));
				}
			}
			catch (Exception e)
			{
				Set(Error.CLI_EXCEPTION, e.Message);
			}

			return doc;
		}

		/// <summary>
		/// Przygotowanie nagłówka z danymi o kliencie
		/// </summary>
		/// <returns>dane o kliencie</returns>
		private string GetAgentHeader()
		{
			return (string.IsNullOrEmpty(Application) ? "" : Application + " ") + "NIP24Client/" + VERSION + " .NET/" + Environment.Version;
		}

		/// <summary>
		/// Przygotowanie nagłówka z danymi do autoryzacji zapytania
		/// </summary>
		/// <param name="method">metoda HTTP</param>
		/// <param name="uri">docelowy adres URL</param>
		/// <returns>treść nagłówka HTTP Authorization</returns>
		private string GetAuthHeader(string method, Uri uri)
		{
			TimeSpan ts = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc));

			string nonce = GetRandom(8);

			string str = string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n\n",
				Convert.ToInt32(ts.TotalSeconds),
				nonce,
				method,
				uri.PathAndQuery,
				uri.Host,
				uri.Port);

			string mac = GetMac(str);

			return string.Format("MAC id=\"{0}\", ts=\"{1}\", nonce=\"{2}\", mac=\"{3}\"", Id, Convert.ToInt32(ts.TotalSeconds), nonce, mac);
		}

		/// <summary>
		/// Zwraca losowy ciąg w postaci heksadecymalnej
		/// </summary>
		/// <param name="length">długość ciągu</param>
		/// <returns>losowy ciąg</returns>
		private string GetRandom(int length)
		{
			byte[] b = new byte[length / 2];

			rng.GetBytes(b);

			return BitConverter.ToString(b).Replace("-", "").ToLower();
		}

		/// <summary>
		/// Oblicza HMAC z podanego ciągu
		/// </summary>
		/// <param name="str">ciąg wejściowy</param>
		/// <returns>obliczony HMAC jako ciąg Base64 lub null</returns>
		private string GetMac(string str)
		{
			HashAlgorithm ha = new HMACSHA256(Encoding.ASCII.GetBytes(Key));

			return Convert.ToBase64String(ha.ComputeHash(Encoding.ASCII.GetBytes(str)));
		}

		/// <summary>
		/// Zwraca wartość węzła XML jako ciąg tekstowy
		/// </summary>
		/// <param name="doc">dokument XML</param>
		/// <param name="path">wyrażenie XPath wybierające wartość</param>
		/// <param name="def">wartość domyślna zwracana w przypadku braku wartości w XML</param>
		/// <returns>ciąg tekstowy</returns>
		private string GetString(XPathDocument doc, string path, string def)
		{
			try
			{
				XPathNavigator xpn = doc.CreateNavigator();

				string val = xpn.SelectSingleNode(path).Value;

				if (val != null)
				{
					return val;
				}
			}
			catch (Exception)
			{
			}

			return def;
		}

		/// <summary>
		/// Zwraca wartość węzła XML jako obiekt daty i czasu lokalnego
		/// </summary>
		/// <param name="doc">dokument XML</param>
		/// <param name="path">wyrażenie XPath wybierające wartość</param>
		/// <returns>data i czas lokalny lub null</returns>
		private DateTime? GetDateTime(XPathDocument doc, string path)
		{
			try
			{
				string val = GetString(doc, path, null);

				if (val != null)
				{
					return XmlConvert.ToDateTime(val, XmlDateTimeSerializationMode.Local);
				}
			}
			catch (Exception)
			{
			}

			return null;
		}

		/// <summary>
		/// Dodaj wartość węzła XML jako obiekt VATPerson do podanej listy
		/// </summary>
		/// <param name="doc">dokument XML</param>
		/// <param name="path">wyrażenie XPath wybierające wartość</param>
		/// <param name="list">lista osób</param>
		private void GetVATPerson(XPathDocument doc, string path, List<VATPerson> list)
		{
			try
			{
				for (int i = 1; ; i++)
				{
					string nip = GetString(doc, path +  "/person[" + i + "]/nip", null);

					if (nip == null) {
						break;
					}

					VATPerson vp = new VATPerson();

					vp.NIP = NIP.Normalize(nip);
					vp.CompanyName = GetString(doc, path + "/person[" + i + "]/companyName", null);
					vp.FirstName = GetString(doc, path + "/person[" + i + "]/firstName", null);
					vp.LastName = GetString(doc, path + "/person[" + i + "]/lastName", null);

					list.Add(vp);
				}
			}
			catch (Exception)
			{
			}
		}

		/// <summary>
		/// Pobranie sufiksu ścieżki
		/// </summary>
		/// <param name="type">typ numeru identyfikującego firmę</param>
		/// <param name="number">numer określonego typu</param>
		/// <returns>fragment ścieżki lub null</returns>
		private string GetPathSuffix(Number type, string number)
        {
            string path = "";

            if (type.Equals(Number.NIP))
            {
                if (!NIP.IsValid(number))
                {
					Set(Error.CLI_NIP);
                    return null;
                }

                path = "nip/" + NIP.Normalize(number);
            }
            else if (type.Equals(Number.REGON))
            {
                if (!REGON.IsValid(number))
                {
					Set(Error.CLI_REGON);
					return null;
                }

                path = "regon/" + REGON.Normalize(number);
            }
            else if (type.Equals(Number.KRS))
            {
                if (!KRS.IsValid(number))
                {
					Set(Error.CLI_KRS);
					return null;
                }

                path = "krs/" + KRS.Normalize(number);
            }
            else if (type.Equals(Number.EUVAT))
            {
                if (!EUVAT.IsValid(number))
                {
					Set(Error.CLI_EUVAT);
					return null;
                }

                path = "euvat/" + EUVAT.Normalize(number);
            }
			else if (type.Equals(Number.IBAN))
			{
				if (!IBAN.IsValid(number))
				{
					number = "PL" + number;

					if (!IBAN.IsValid(number))
					{
						Set(Error.CLI_IBAN);
						return null;
					}
				}

				path = "iban/" + IBAN.Normalize(number);
			}
            else
            {
				Set(Error.CLI_NUMBER);
				return null;
            }

            return path;
        }
    }

	#endregion
}