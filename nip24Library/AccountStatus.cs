/**
 * Copyright 2015-2022 NETCAT (www.netcat.pl)
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
 * @copyright 2015-2022 NETCAT (www.netcat.pl)
 * @license http://www.apache.org/licenses/LICENSE-2.0
 */

using System;
using System.Runtime.InteropServices;

namespace NIP24
{
	#region interface

	/// <summary>
	/// Interfejs danych o koncie użytkownika
	/// </summary>
	[Guid("E239CE38-AD8D-445E-A770-1E8011FC474A")]
	[ComVisible(true)]
	public interface IAccountStatus
	{
		/// <summary>
		/// Unikalny identyfikator odpowiedzi
		/// </summary>
		[DispId(1)]
		string UID { get; set; }

		/// <summary>
		/// Typ konta
		/// </summary>
		[DispId(2)]
		string Type { get; set; }

		/// <summary>
		/// Data ważności konta pre-paid
		/// </summary>
		[DispId(3)]
		DateTime ValidTo { get; set; }

		/// <summary>
		/// Nazwa bieżącego planu taryfowego
		/// </summary>
		[DispId(4)]
		string BillingPlanName { get; set; }

		/// <summary>
		/// Cena netto abonamentu miesięcznego
		/// </summary>
		[DispId(5)]
		decimal SubscriptionPrice { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania poza planem w planie standardowym
		/// </summary>
		[DispId(6)]
		decimal ItemPrice { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania - VAT/VIES/Status działalności podmiotu w planie indywidualnym
		/// </summary>
		[DispId(7)]
		decimal ItemPriceStatus { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania - dane do faktury w planie indywidualnym
		/// </summary>
		[DispId(8)]
		decimal ItemPriceInvoice { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania - pełne dane podmiotu w planie indywidualnym
		/// </summary>
		[DispId(9)]
		decimal ItemPriceAll { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania - status rachunku bankowego
		/// </summary>
		[DispId(10)]
		decimal ItemPriceIBAN { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania - status podmiotu na białej liście podatników VAT
		/// </summary>
		[DispId(11)]
		decimal ItemPriceWhitelist { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania - wyszukiwanie danych w rejestrze VAT
		/// </summary>
		[DispId(12)]
		decimal ItemPriceSearchVAT { get; set; }

		/// <summary>
		/// Maksymalna liczba zapytań w planie
		/// </summary>
		[DispId(13)]
		int Limit { get; set; }

		/// <summary>
		/// Minimalny odstęp czasu między zapytaniami
		/// </summary>
		[DispId(14)]
		int RequestDelay { get; set; }

		/// <summary>
		/// Maksymalna ilość domen (kluczy API)
		/// </summary>
		[DispId(15)]
		int DomainLimit { get; set; }

		/// <summary>
		/// Możliwość przekroczenia maksymalnej liczby zapytań w planie
		/// </summary>
		[DispId(16)]
		bool OverPlanAllowed { get; set; }

		/// <summary>
		/// Dostęp do kodów TERYT
		/// </summary>
		[DispId(17)]
		bool TerytCodes { get; set; }

		/// <summary>
		/// Dostęp z wykorzystaniem dodatku MS Excel
		/// </summary>
		[DispId(18)]
		bool ExcelAddIn { get; set; }

		/// <summary>
		/// Dostęp z wykorzystaniem aplikacji JPK_VAT
		/// </summary>
		[DispId(19)]
		bool JPKVAT { get; set; }

		/// <summary>
		/// Dostęp z wykorzystaniem aplikacji CLI/CMD
		/// </summary>
		[DispId(20)]
		bool CLI { get; set; }

		/// <summary>
		/// Dostęp do statystyk wykonanych zapytań
		/// </summary>
		[DispId(21)]
		bool Stats { get; set; }

		/// <summary>
		/// Dostęp do monitorowania statusów podmiotów: VAT/VIES/Status działalności
		/// </summary>
		[DispId(22)]
		bool NIPMonitor { get; set; }

		/// <summary>
		/// Wyszukiwanie po numerze NIP
		/// </summary>
		[DispId(23)]
		bool SearchByNIP { get; set; }

		/// <summary>
		/// Wyszukiwanie po numerze REGON
		/// </summary>
		[DispId(24)]
		bool SearchByREGON { get; set; }

		/// <summary>
		/// Wyszukiwanie po numerze KRS
		/// </summary>
		[DispId(25)]
		bool SearchByKRS { get; set; }

		/// <summary>
		/// Dostęp do funkcji sprawdzających status działalności podmiotu
		/// </summary>
		[DispId(26)]
		bool FuncIsActive { get; set; }

		/// <summary>
		/// Dostęp do funkcji pobierających dane podmiotu do faktury
		/// </summary>
		[DispId(27)]
		bool FuncGetInvoiceData { get; set; }

		/// <summary>
		/// Dostęp do funkcji pobierających pełne dane podmiotu
		/// </summary>
		[DispId(28)]
		bool FuncGetAllData { get; set; }

		/// <summary>
		/// Dostęp do funkcji sprawdzających status podmiotu w systemie VIES
		/// </summary>
		[DispId(29)]
		bool FuncGetVIESData { get; set; }

		/// <summary>
		/// Dostęp do funkcji sprawdzających status podmiotu w rejestrze VAT
		/// </summary>
		[DispId(30)]
		bool FuncGetVATStatus { get; set; }

		/// <summary>
		/// Dostęp do funkcji sprawdzających status rachunku bankowego firmy
		/// </summary>
		[DispId(31)]
		bool FuncGetIBANStatus { get; set; }

		/// <summary>
		/// Dostęp do funkcji sprawdzających status podmiotu na białej liście podatników VAT
		/// </summary>
		[DispId(32)]
		bool FuncGetWhitelistStatus { get; set; }

		/// <summary>
		/// Dostęp do funkcji wyszukującej dane w rejestrze VAT
		/// </summary>
		[DispId(33)]
		bool FuncSearchVAT { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o dane podmiotu do faktury
		/// </summary>
		[DispId(34)]
		int InvoiceDataCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o pełne dane podmiotu
		/// </summary>
		[DispId(35)]
		int AllDataCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o status działalności podmiotu
		/// </summary>
		[DispId(36)]
		int FirmStatusCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o status podmiotu w rejestrze VAT
		/// </summary>
		[DispId(37)]
		int VATStatusCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o status podmiotu w systemie VIES
		/// </summary>
		[DispId(38)]
		int VIESStatusCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o status rachunku bankowego firmy
		/// </summary>
		[DispId(39)]
		int IBANStatusCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o status podmiotu na białej liście
		/// </summary>
		[DispId(40)]
		int WhitelistStatusCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań wyszukiwania danych w rejestrze VAT
		/// </summary>
		[DispId(41)]
		int SearchVATCount { get; set; }

		/// <summary>
		/// Całkowita ilość wykonanych zapytań w bieżącym miesiącu
		/// </summary>
		[DispId(42)]
		int TotalCount { get; set; }

		[DispId(43)]
		string ToString();
	}

	#endregion

	#region implementation

	/// <summary>
	/// Dane konta użytkownika
	/// </summary>
	[Guid("80163A0A-F6E8-43A3-8589-B8792E0C40D3")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class AccountStatus : IAccountStatus
	{
		/// <summary>
		/// Unikalny identyfikator odpowiedzi
		/// </summary>
		public string UID { get; set; }

		/// <summary>
		/// Typ konta
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// Data ważności konta pre-paid
		/// </summary>
		[ComVisible(false)]
		public DateTime? ValidTo { get; set; }

		/// <summary>
		/// Data ważności konta pre-paid
		/// </summary>
		DateTime IAccountStatus.ValidTo
		{
			get { return ValidTo ?? DateTime.MinValue; }
			set { ValidTo = value; }
		}

		/// <summary>
		/// Nazwa bieżącego planu taryfowego
		/// </summary>
		public string BillingPlanName { get; set; }

		/// <summary>
		/// Cena netto abonamentu miesięcznego
		/// </summary>
		public decimal SubscriptionPrice { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania poza planem w planie standardowym
		/// </summary>
		public decimal ItemPrice { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania - VAT/VIES/Status działalności podmiotu w planie indywidualnym
		/// </summary>
		public decimal ItemPriceStatus { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania - dane do faktury w planie indywidualnym
		/// </summary>
		public decimal ItemPriceInvoice { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania - pełne dane podmiotu w planie indywidualnym
		/// </summary>
		public decimal ItemPriceAll { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania - status rachunku bankowego firmy
		/// </summary>
		public decimal ItemPriceIBAN { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania - status podmiotu na białej liście podatników VAT
		/// </summary>
		public decimal ItemPriceWhitelist { get; set; }

		/// <summary>
		/// Koszt netto pojedynczego zapytania - wyszukiwanie danych w rejestrze VAT
		/// </summary>
		public decimal ItemPriceSearchVAT { get; set; }

		/// <summary>
		/// Maksymalna liczba zapytań w planie
		/// </summary>
		public int Limit { get; set; }

		/// <summary>
		/// Minimalny odstęp czasu między zapytaniami
		/// </summary>
		public int RequestDelay { get; set; }

		/// <summary>
		/// Maksymalna ilość domen (kluczy API)
		/// </summary>
		public int DomainLimit { get; set; }

		/// <summary>
		/// Możliwość przekroczenia maksymalnej liczby zapytań w planie
		/// </summary>
		public bool OverPlanAllowed { get; set; }

		/// <summary>
		/// Dostęp do kodów TERYT
		/// </summary>
		public bool TerytCodes { get; set; }

		/// <summary>
		/// Dostęp z wykorzystaniem dodatku MS Excel
		/// </summary>
		public bool ExcelAddIn { get; set; }

		/// <summary>
		/// Dostęp z wykorzystaniem aplikacji JPK_VAT
		/// </summary>
		public bool JPKVAT { get; set; }

		/// <summary>
		/// Dostęp z wykorzystaniem aplikacji CLI/CMD
		/// </summary>
		public bool CLI { get; set; }

		/// <summary>
		/// Dostęp do statystyk wykonanych zapytań
		/// </summary>
		public bool Stats { get; set; }

		/// <summary>
		/// Dostęp do monitorowania statusów podmiotów: VAT/VIES/Status działalności
		/// </summary>
		public bool NIPMonitor { get; set; }

		/// <summary>
		/// Wyszukiwanie po numerze NIP
		/// </summary>
		public bool SearchByNIP { get; set; }

		/// <summary>
		/// Wyszukiwanie po numerze REGON
		/// </summary>
		public bool SearchByREGON { get; set; }

		/// <summary>
		/// Wyszukiwanie po numerze KRS
		/// </summary>
		public bool SearchByKRS { get; set; }

		/// <summary>
		/// Dostęp do funkcji sprawdzających status działalności podmiotu
		/// </summary>
		public bool FuncIsActive { get; set; }

		/// <summary>
		/// Dostęp do funkcji pobierających dane podmiotu do faktury
		/// </summary>
		public bool FuncGetInvoiceData { get; set; }

		/// <summary>
		/// Dostęp do funkcji pobierających pełne dane podmiotu
		/// </summary>
		public bool FuncGetAllData { get; set; }

		/// <summary>
		/// Dostęp do funkcji sprawdzających status podmiotu w systemie VIES
		/// </summary>
		public bool FuncGetVIESData { get; set; }

		/// <summary>
		/// Dostęp do funkcji sprawdzających status podmiotu w rejestrze VAT
		/// </summary>
		public bool FuncGetVATStatus { get; set; }

		/// <summary>
		/// Dostęp do funkcji sprawdzających status rachunku bankowego firmy
		/// </summary>
		public bool FuncGetIBANStatus { get; set; }

		/// <summary>
		/// Dostęp do funkcji sprawdzających status podmiotu na białej liście podatników VAT
		/// </summary>
		public bool FuncGetWhitelistStatus { get; set; }

		/// <summary>
		/// Dostęp do funkcji wyszukującej dane w rejestrze VAT
		/// </summary>
		public bool FuncSearchVAT { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o dane podmiotu do faktury
		/// </summary>
		public int InvoiceDataCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o pełne dane podmiotu
		/// </summary>
		public int AllDataCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o status działalności podmiotu
		/// </summary>
		public int FirmStatusCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o status podmiotu w rejestrze VAT
		/// </summary>
		public int VATStatusCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o status podmiotu w systemie VIES
		/// </summary>
		public int VIESStatusCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o status rachunku bankowego firmy
		/// </summary>
		public int IBANStatusCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań o status podmiotu na białej liście
		/// </summary>
		public int WhitelistStatusCount { get; set; }

		/// <summary>
		/// Ilość wykonanych zapytań wyszukiwania danych w rejestrze VAT
		/// </summary>
		public int SearchVATCount { get; set; }

		/// <summary>
		/// Całkowita ilość wykonanych zapytań w bieżącym miesiącu
		/// </summary>
		public int TotalCount { get; set; }

		/// <summary>
		/// Tworzy nowy, pusty obiekt
		/// </summary>
		public AccountStatus()
		{
		}

		public override string ToString()
        {
            return "AccountStatus: [uid = " + UID
				+ ", type = " + Type
				+ ", validTo = " + ValidTo
				+ ", billingPlanName = " + BillingPlanName

				+ ", subscriptionPrice = " + SubscriptionPrice
				+ ", itemPrice = " + ItemPrice
				+ ", itemPriceStatus = " + ItemPriceStatus
				+ ", itemPriceInvoice = " + ItemPriceInvoice
				+ ", itemPriceAll = " + ItemPriceAll
				+ ", itemPriceIBAN = " + ItemPriceIBAN
				+ ", itemPriceWhitelist = " + ItemPriceWhitelist
				+ ", itemPriceSearchVAT = " + ItemPriceSearchVAT

				+ ", limit = " + Limit
				+ ", requestDelay = " + RequestDelay
				+ ", domainLimit = " + DomainLimit

				+ ", overPlanAllowed = " + OverPlanAllowed
				+ ", terytCodes = " + TerytCodes
				+ ", excelAddIn = " + ExcelAddIn
				+ ", JPK_VAT = " + JPKVAT
				+ ", CLI = " + CLI
				+ ", stats = " + Stats
				+ ", NIPMonitor = " + NIPMonitor
				
				+ ", searchByNIP = " + SearchByNIP
				+ ", searchByREGON = " + SearchByREGON
				+ ", searchByKRS = " + SearchByKRS
				
				+ ", funcIsActive = " + FuncIsActive
				+ ", funcGetInvoiceData = " + FuncGetInvoiceData
				+ ", funcGetAllData = " + FuncGetAllData
				+ ", funcGetVIESData = " + FuncGetVIESData
				+ ", funcGetVATStatus = " + FuncGetVATStatus
				+ ", funcGetIBANStatus = " + FuncGetIBANStatus
				+ ", funcGetWhitelistStatus = " + FuncGetWhitelistStatus
				+ ", funcSearchVAT = " + FuncSearchVAT

				+ ", invoiceDataCount = " + InvoiceDataCount
				+ ", allDataCount = " + AllDataCount
				+ ", firmStatusCount = " + FirmStatusCount
				+ ", VATStatusCount = " + VATStatusCount
				+ ", VIESStatusCount = " + VIESStatusCount
				+ ", IBANStatusCount = " + IBANStatusCount
				+ ", whitelistStatusCount = " + WhitelistStatusCount
				+ ", searchVATCount = " + SearchVATCount
				+ ", totalCount = " + TotalCount
				+ "]";
        }
    }

	#endregion
}