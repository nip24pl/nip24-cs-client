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
	/// Status rachunku bankowego IBAN
	/// </summary>
	[Guid("BEFDF1CE-BE0C-48DA-8A96-150DCA015E1E")]
	[ComVisible(true)]
	public interface IIBANStatus
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
		/// Numer REGON
		/// </summary>
		[DispId(3)]
		string REGON { get; set; }

		/// <summary>
		/// Numer rachunku bankowego
		/// </summary>
		[DispId(4)]
		string IBAN { get; set; }

		/// <summary>
		/// Status rachunku (true - rachunek powiązany z podatnikiem, false - nie powiązany)
		/// </summary>
		[DispId(5)]
		bool Valid { get; set; }

		/// <summary>
		/// Identyfikator sprawdzenia w systemie MF
		/// </summary>
		[DispId(6)]
		string ID { get; set; }

		/// <summary>
		/// Data sprawdzenia
		/// </summary>
		[DispId(7)]
		DateTime Date { get; set; }

		/// <summary>
		/// Źródło informacji o statusie
		/// </summary>
		[DispId(8)]
		string Source { get; set; }

		[DispId(9)]
		string ToString();
    }

	#endregion

	#region implementation

	/// <summary>
	/// Status firmy w rejestrze VAT
	/// </summary>
	[Guid("E84A913A-7612-4719-B446-D1DD97E76B38")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class IBANStatus : IIBANStatus
	{
		/// <summary>
		/// Unikalny identyfikator odpowiedzi
		/// </summary>
		public string UID { get; set; }

		/// <summary>
		/// Numer NIP
		/// </summary>
		public string NIP { get; set; }

		/// <summary>
		/// Numer REGON
		/// </summary>
		public string REGON { get; set; }

		/// <summary>
		/// Numer rachunku bankowego
		/// </summary>
		public string IBAN { get; set; }

		/// <summary>
		/// Status rachunku (true - rachunek powiązany z podatnikiem, false - nie powiązany)
		/// </summary>
		public bool Valid { get; set; }

		/// <summary>
		/// Identyfikator sprawdzenia w systemie MF
		/// </summary>
		public string ID { get; set; }

		/// <summary>
		/// Data sprawdzenia
		/// </summary>
		[ComVisible(false)]
		public DateTime? Date { get; set; }

		/// <summary>
		/// Data sprawdzenia
		/// </summary>
		DateTime IIBANStatus.Date
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
		public IBANStatus()
		{
		}

		public override string ToString()
		{
			return "IBANStatus: [uid = " + UID
				+ ", nip = " + NIP
				+ ", regon = " + REGON
				+ ", iban = " + IBAN
				+ ", valid = " + Valid
				+ ", id = " + ID
				+ ", date = " + Date
				+ ", source = " + Source
				+ "]";
		}
	}

	#endregion
}
