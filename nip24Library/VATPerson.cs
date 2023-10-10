/**
 * Copyright 2015-2023 NETCAT (www.netcat.pl)
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
 * @copyright 2015-2023 NETCAT (www.netcat.pl)
 * @license http://www.apache.org/licenses/LICENSE-2.0
 */

using System.Runtime.InteropServices;

namespace NIP24
{
	#region interface

	/// <summary>
	/// Dane osoby z rejestru VAT
	/// </summary>
	[Guid("1795E15A-1724-424D-AC89-F65CCF6AF007")]
	[ComVisible(true)]
	public interface IVATPerson
    {
		/// <summary>
		/// Nazwa firmy
		/// </summary>
		[DispId(1)]
		string CompanyName { get; set; }

		/// <summary>
		/// Imię
		/// </summary>
		[DispId(2)]
		string FirstName { get; set; }

		/// <summary>
		/// Nazwisko
		/// </summary>
		[DispId(3)]
		string LastName { get; set; }

		/// <summary>
		/// Numer NIP
		/// </summary>
		[DispId(4)]
		string NIP { get; set; }

		[DispId(5)]
		string ToString();
    }

	#endregion

	#region implementation

	/// <summary>
	/// Dane osoby z rejestru VAT
	/// </summary>
	[Guid("766A6AD3-986E-403D-A2E8-4628C1B7AF2C")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class VATPerson : IVATPerson
	{
		/// <summary>
		/// Nazwa firmy
		/// </summary>
		public string CompanyName { get; set; }

		/// <summary>
		/// Imię
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// Nazwisko
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// Numer NIP
		/// </summary>
		public string NIP { get; set; }

		/// <summary>
		/// Tworzy nowy, pusty obiekt
		/// </summary>
		public VATPerson()
		{
		}

		public override string ToString()
		{
			return "VATPerson: [companyName = " + CompanyName
				+ ", firstName = " + FirstName
				+ ", lastName = " + LastName
				+ ", nip = " + NIP
				+ "]";
		}
	}

	#endregion
}
