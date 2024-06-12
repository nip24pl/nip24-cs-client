/**
 * Copyright 2015-2024 NETCAT (www.netcat.pl)
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
 * @copyright 2015-2024 NETCAT (www.netcat.pl)
 * @license http://www.apache.org/licenses/LICENSE-2.0
 */

using System;
using System.Runtime.InteropServices;

namespace NIP24
{
	#region interface

	/// <summary>
	/// Status podmiotu na białej liście
	/// </summary>
	[Guid("D1518ADC-DB35-4503-964A-1F3C2F5CA20D")]
	[ComVisible(true)]
	public interface IWLStatus
    {
		/// <summary>
		/// Unikalny identyfikator odpowiedzi
		/// </summary>
		[DispId(1)]
		string UID { get; set; }

		/// <summary>
		/// Numer NIP
		/// </summary>
		[DispId(2)]
		string NIP { get; set; }

		/// <summary>
		/// Numer rachunku bankowego
		/// </summary>
		[DispId(3)]
		string IBAN { get; set; }

		/// <summary>
		/// Status rachunku (true - rachunek powiązany z podatnikiem, false - nie powiązany)
		/// </summary>
		[DispId(4)]
		bool Valid { get; set; }

		/// <summary>
		/// Rachunek wirtualny (true - rachunek wirtualny, false - standardowy)
		/// </summary>
		[DispId(5)]
		bool Virtual { get; set; }

		/// <summary>
		/// Status VAT jako jedna z wartości: NOT_REGISTERED, ACTIVE, EXEMPTED
		/// </summary>
		[DispId(6)]
		int Status { get; set; }

		/// <summary>
		/// Tekstowy opis statusu VAT
		/// </summary>
		[DispId(7)]
		string Result { get; set; }

		/// <summary>
		/// Indeks znalezionego hash'a w pliku białej listy
		/// </summary>
		[DispId(8)]
		int HashIndex { get; set; }

		/// <summary>
		/// Indeks znalezionej maski w pliku białej listy (tylko dla rachunków wirtualnych)
		/// </summary>
		[DispId(9)]
		int MaskIndex { get; set; }

		/// <summary>
		/// Data sprawdzenia
		/// </summary>
		[DispId(10)]
		DateTime Date { get; set; }

		/// <summary>
		/// Źródło informacji o statusie
		/// </summary>
		[DispId(11)]
		string Source { get; set; }

		[DispId(12)]
		string ToString();
    }

	#endregion

	#region implementation

	/// <summary>
	/// Status podmiotu na białej liście
	/// </summary>
	[Guid("7D5368D6-2752-4760-97B3-A78B2F0C8B91")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class WLStatus : IWLStatus
	{
		public const int NOT_REGISTERED = 1;
		public const int ACTIVE = 2;
		public const int EXEMPTED = 3;

		/// <summary>
		/// Unikalny identyfikator odpowiedzi
		/// </summary>
		public string UID { get; set; }

		/// <summary>
		/// Numer NIP
		/// </summary>
		public string NIP { get; set; }

		/// <summary>
		/// Numer rachunku bankowego
		/// </summary>
		public string IBAN { get; set; }

		/// <summary>
		/// Status rachunku (true - rachunek powiązany z podatnikiem, false - nie powiązany)
		/// </summary>
		public bool Valid { get; set; }

		/// <summary>
		/// Rachunek wirtualny (true - rachunek wirtualny, false - standardowy)
		/// </summary>
		public bool Virtual { get; set; }

		/// <summary>
		/// Status VAT jako jedna z wartości: NOT_REGISTERED, ACTIVE, EXEMPTED
		/// </summary>
		public int Status { get; set; }

		/// <summary>
		/// Tekstowy opis statusu VAT
		/// </summary>
		public string Result { get; set; }

		/// <summary>
		/// Indeks znalezionego hash'a w pliku białej listy
		/// </summary>
		public int HashIndex { get; set; }

		/// <summary>
		/// Indeks znalezionej maski w pliku białej listy (tylko dla rachunków wirtualnych)
		/// </summary>
		public int MaskIndex { get; set; }

		/// <summary>
		/// Data sprawdzenia
		/// </summary>
		[ComVisible(false)]
		public DateTime? Date { get; set; }

		/// <summary>
		/// Data sprawdzenia
		/// </summary>
		DateTime IWLStatus.Date
		{
			get { return Date ?? DateTime.MinValue; }
			set { Date = value; }
		}

		/// <summary>
		/// Źródło informacji o statusie
		/// </summary>
		public string Source { get; set; }

		/// <summary>
		/// Tworzy nowy, pusty obiekt
		/// </summary>
		public WLStatus()
		{
		}

		public override string ToString()
		{
			return "WLStatus: [uid = " + UID
				+ ", nip = " + NIP
				+ ", iban = " + IBAN
				+ ", valid = " + Valid
				+ ", virtual = " + Virtual
				+ ", status = " + Status
				+ ", result = " + Result
				+ ", hashIndex = " + HashIndex
				+ ", maskIndex = " + MaskIndex
				+ ", date = " + Date
				+ ", source = " + Source
				+ "]";
		}
	}

	#endregion
}
