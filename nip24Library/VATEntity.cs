/**
 * Copyright 2015-2025 NETCAT (www.netcat.pl)
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
 * @copyright 2015-2025 NETCAT (www.netcat.pl)
 * @license http://www.apache.org/licenses/LICENSE-2.0
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NIP24
{
	#region interface

	/// <summary>
	/// Dane podmiotu z rejestru VAT
	/// </summary>
	[Guid("14A54D2F-64BA-4682-92D9-2432639971F4")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
	public interface IVATEntity
    {
		/// <summary>
		/// Firma (nazwa) lub imię i nazwisko
		/// </summary>
		[DispId(1)]
		string Name { get; set; }

		/// <summary>
		/// Numer NIP
		/// </summary>
		[DispId(2)]
		string NIP { get; set; }

		/// <summary>
		/// Numer REGON
		/// </summary>
		[DispId(3)]
		string REGON { get; set; }

		/// <summary>
		/// Numer KRS
		/// </summary>
		[DispId(4)]
		string KRS { get; set; }

		/// <summary>
		/// Adres siedziby
		/// </summary>
		[DispId(5)]
		string ResidenceAddress { get; set; }

		/// <summary>
		/// Adres stałego miejsca prowadzenia działalności lub adres miejsca zamieszkania w przypadku braku adresu stałego miejsca prowadzenia działalności
		/// </summary>
		[DispId(6)]
		string WorkingAddress { get; set; }

		/// <summary>
		/// Status jako jedna z wartości: NOT_REGISTERED, ACTIVE, EXEMPTED
		/// </summary>
		[DispId(7)]
		int VATStatus { get; set; }

		/// <summary>
		/// Tekstowy opis statusu
		/// </summary>
		[DispId(8)]
		string VATResult { get; set; }

		/// <summary>
		/// Imiona i nazwiska osób wchodzących w skład organu uprawnionego do reprezentowania podmiotu oraz ich numery NIP
		/// </summary>
		[DispId(9)]
		VATPerson[] Representatives { get; set; }

		/// <summary>
		/// Imiona i nazwiska prokurentów oraz ich numery NIP
		/// </summary>
		[DispId(10)]
		VATPerson[] AuthorizedClerks { get; set; }

		/// <summary>
		/// Imiona i nazwiska lub firma (nazwa) wspólnika oraz jego numer NIP
		/// </summary>
		[DispId(11)]
		VATPerson[] Partners { get; set; }

		/// <summary>
		/// Numery IBAN rachunków bankowych
		/// </summary>
		[DispId(12)]
		string[] IBANs { get; set; }

		/// <summary>
		/// Czy podmiot posiada maski kont wirtualnych
		/// </summary>
		[DispId(13)]
		bool HasVirtualAccounts { get; set; }

		/// <summary>
		/// Data rejestracji jako podatnika VAT
		/// </summary>
		[DispId(14)]
		DateTime RegistrationLegalDate { get; set; }

		/// <summary>
		/// Data odmowy rejestracji jako podatnika VAT
		/// </summary>
		[DispId(15)]
		DateTime RegistrationDenialDate { get; set; }

		/// <summary>
		/// Podstawa prawna odmowy rejestracji
		/// </summary>
		[DispId(16)]
		string RegistrationDenialBasis { get; set; }

		/// <summary>
		/// Data przywrócenia jako podatnika VAT
		/// </summary>
		[DispId(17)]
		DateTime RestorationDate { get; set; }

		/// <summary>
		/// Podstawa prawna przywrócenia jako podatnika VAT
		/// </summary>
		[DispId(18)]
		string RestorationBasis { get; set; }

		/// <summary>
		/// Data wykreślenia odmowy rejestracji jako podatnika VAT
		/// </summary>
		[DispId(19)]
		DateTime RemovalDate { get; set; }

		/// <summary>
		/// Podstawa prawna wykreślenia odmowy rejestracji jako podatnika VAT
		/// </summary>
		[DispId(20)]
		string RemovalBasis { get; set; }

		[DispId(21)]
		string ToString();
    }

	#endregion

	#region implementation

	/// <summary>
	/// Status firmy w rejestrze VAT
	/// </summary>
	[Guid("84E51149-B610-4788-901F-284149461447")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class VATEntity : IVATEntity
	{
		public const int NOT_REGISTERED = 1;
		public const int ACTIVE = 2;
		public const int EXEMPTED = 3;

		/// <summary>
		/// Firma (nazwa) lub imię i nazwisko
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Numer NIP
		/// </summary>
		public string NIP { get; set; }

		/// <summary>
		/// Numer REGON
		/// </summary>
		public string REGON { get; set; }

		/// <summary>
		/// Numer KRS
		/// </summary>
		public string KRS { get; set; }

		/// <summary>
		/// Adres siedziby
		/// </summary>
		public string ResidenceAddress { get; set; }

		/// <summary>
		/// Adres stałego miejsca prowadzenia działalności lub adres miejsca zamieszkania w przypadku braku adresu stałego miejsca prowadzenia działalności
		/// </summary>
		public string WorkingAddress { get; set; }

		/// <summary>
		/// Status jako jedna z wartości: NOT_REGISTERED, ACTIVE, EXEMPTED
		/// </summary>
		public int VATStatus { get; set; }

		/// <summary>
		/// Tekstowy opis statusu
		/// </summary>
		public string VATResult { get; set; }

		/// <summary>
		/// Imiona i nazwiska osób wchodzących w skład organu uprawnionego do reprezentowania podmiotu oraz ich numery NIP
		/// </summary>
		[ComVisible(false)]
		public List<VATPerson> Representatives { get; set; }

		/// <summary>
		/// Imiona i nazwiska osób wchodzących w skład organu uprawnionego do reprezentowania podmiotu oraz ich numery NIP
		/// </summary>
		VATPerson[] IVATEntity.Representatives
		{
			get { return Representatives.ToArray(); }
			set { Representatives = new List<VATPerson>(value); }
		}

		/// <summary>
		/// Imiona i nazwiska prokurentów oraz ich numery NIP
		/// </summary>
		[ComVisible(false)] 
		public List<VATPerson> AuthorizedClerks { get; set; }

		/// <summary>
		/// Imiona i nazwiska prokurentów oraz ich numery NIP
		/// </summary>
		VATPerson[] IVATEntity.AuthorizedClerks
		{
			get { return AuthorizedClerks.ToArray(); }
			set { AuthorizedClerks = new List<VATPerson>(value); }
		}

		/// <summary>
		/// Imiona i nazwiska lub firma (nazwa) wspólnika oraz jego numer NIP
		/// </summary>
		[ComVisible(false)]
		public List<VATPerson> Partners { get; set; }

		/// <summary>
		/// Imiona i nazwiska lub firma (nazwa) wspólnika oraz jego numer NIP
		/// </summary>
		VATPerson[] IVATEntity.Partners
		{
			get { return Partners.ToArray(); }
			set { Partners = new List<VATPerson>(value); }
		}

		/// <summary>
		/// Numery IBAN rachunków bankowych
		/// </summary>
		[ComVisible(false)]
		public List<string> IBANs { get; set; }

		/// <summary>
		/// Numery IBAN rachunków bankowych
		/// </summary>
		string[] IVATEntity.IBANs
		{
			get { return IBANs.ToArray(); }
			set { IBANs = new List<string>(value); }
		}

		/// <summary>
		/// Czy podmiot posiada maski kont wirtualnych
		/// </summary>
		public bool HasVirtualAccounts { get; set; }

		/// <summary>
		/// Data rejestracji jako podatnika VAT
		/// </summary>
		[ComVisible(false)]
		public DateTime? RegistrationLegalDate { get; set; }

		/// <summary>
		/// Data rejestracji jako podatnika VAT
		/// </summary>
		DateTime IVATEntity.RegistrationLegalDate
		{
			get { return RegistrationLegalDate ?? DateTime.MinValue; }
			set { RegistrationLegalDate = value; }
		}

		/// <summary>
		/// Data odmowy rejestracji jako podatnika VAT
		/// </summary>
		[ComVisible(false)]
		public DateTime? RegistrationDenialDate { get; set; }

		/// <summary>
		/// Data odmowy rejestracji jako podatnika VAT
		/// </summary>
		DateTime IVATEntity.RegistrationDenialDate
		{
			get { return RegistrationDenialDate ?? DateTime.MinValue; }
			set { RegistrationDenialDate = value; }
		}

		/// <summary>
		/// Podstawa prawna odmowy rejestracji
		/// </summary>
		public string RegistrationDenialBasis { get; set; }

		/// <summary>
		/// Data przywrócenia jako podatnika VAT
		/// </summary>
		[ComVisible(false)]
		public DateTime? RestorationDate { get; set; }

		/// <summary>
		/// Data przywrócenia jako podatnika VAT
		/// </summary>
		DateTime IVATEntity.RestorationDate
		{
			get { return RestorationDate ?? DateTime.MinValue; }
			set { RestorationDate = value; }
		}

		/// <summary>
		/// Podstawa prawna przywrócenia jako podatnika VAT
		/// </summary>
		public string RestorationBasis { get; set; }

		/// <summary>
		/// Data wykreślenia odmowy rejestracji jako podatnika VAT
		/// </summary>
		[ComVisible(false)]
		public DateTime? RemovalDate { get; set; }

		/// <summary>
		/// Data wykreślenia odmowy rejestracji jako podatnika VAT
		/// </summary>
		DateTime IVATEntity.RemovalDate
		{
			get { return RemovalDate ?? DateTime.MinValue; }
			set { RemovalDate = value; }
		}

		/// <summary>
		/// Podstawa prawna wykreślenia odmowy rejestracji jako podatnika VAT
		/// </summary>
		public string RemovalBasis { get; set; }

		/// <summary>
		/// Tworzy nowy, pusty obiekt
		/// </summary>
		public VATEntity()
		{
			Representatives = new List<VATPerson>();
			AuthorizedClerks = new List<VATPerson>();
			Partners = new List<VATPerson>();

			IBANs = new List<string>();
		}

		public override string ToString()
		{
			return "VATEntity: [name = " + Name
				+ ", nip = " + NIP
				+ ", regon = " + REGON
				+ ", krs = " + KRS
				+ ", residenceAddress = " + ResidenceAddress
				+ ", workingAddress = " + WorkingAddress
				+ ", vatStatus = " + VATStatus
				+ ", vatResult = " + VATResult
				+ ", representatives = [" + string.Join(", ", Representatives.ConvertAll(e => Convert.ToString(e)).ToArray()) + "]"
				+ ", authorizedClerks = [" + string.Join(", ", AuthorizedClerks.ConvertAll(e => Convert.ToString(e)).ToArray()) + "]"
				+ ", partners = [" + string.Join(", ", Partners.ConvertAll(e => Convert.ToString(e)).ToArray()) + "]"
				+ ", ibans = [" + string.Join(", ", IBANs.ConvertAll(e => Convert.ToString(e)).ToArray()) + "]"
				+ ", hasVirtualAccounts = " + HasVirtualAccounts
				+ ", registrationLegalDate = " + RegistrationLegalDate
				+ ", registrationDenialDate = " + RegistrationDenialDate
				+ ", registrationDenialBasis = " + RegistrationDenialBasis
				+ ", restorationDate = " + RestorationDate
				+ ", restorationBasis = " + RestorationBasis
				+ ", removalDate = " + RemovalDate
				+ ", removalBasis = " + RemovalBasis
				+ "]";
		}
	}

	#endregion
}
