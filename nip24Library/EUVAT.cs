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

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace NIP24
{
	#region interface

	/// <summary>
	/// Interfejs weryfikatora numeru EU VAT ID
	/// </summary>
	[Guid("155D7B28-4BA8-4F37-93D7-7AF0DAD2280A")]
	[ComVisible(true)]
	public interface IEUVAT
	{
		/// <summary>
		/// Konwertuje podany numer EU VAT do postaci znormalizowanej
		/// </summary>
		/// <param name="nip">numer EU VAT w dowolnym formacie</param>
		/// <returns>znormalizowany numer EU VAT</returns>
		[DispId(1)]
		string Normalize(string nip);

		/// <summary>
		/// Sprawdza poprawność numeru EU VAT
		/// </summary>
		/// <param name="nip">numer EU VAT</param>
		/// <returns>true jeżeli podany numer jest prawidłowy</returns>
		[DispId(2)]
		bool IsValid(string nip);
	}

	#endregion

	#region implementation

	/// <summary>
	/// Weryfikator numeru EU VAT ID
	/// </summary>
	[Guid("43749758-6453-47F1-AA33-5C923BA75462")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class EUVAT : IEUVAT
    {
		private static Dictionary<string, string> map = new Dictionary<string, string>();

		static EUVAT()
		{
			map.Add("AT", @"^ATU\d{8}$");
			map.Add("BE", @"^BE[0-1]{1}\d{9}$");
			map.Add("BG", @"^BG\d{9,10}$");
			map.Add("CY", @"^CY\d{8}[A-Z]{1}$");
			map.Add("CZ", @"^CZ\d{8,10}$");
			map.Add("DE", @"^DE\d{9}$");
			map.Add("DK", @"^DK\d{8}$");
			map.Add("EE", @"^EE\d{9}$");
			map.Add("EL", @"^EL\d{9}$");
			map.Add("ES", @"^ES[A-Z0-9]{1}\d{7}[A-Z0-9]{1}$");
			map.Add("FI", @"^FI\d{8}$");
			map.Add("FR", @"^FR[A-Z0-9]{2}\d{9}$");
			map.Add("HR", @"^HR\d{11}$");
			map.Add("HU", @"^HU\d{8}$");
			map.Add("IE", @"^IE[A-Z0-9+*]{8,9}$");
			map.Add("IT", @"^IT\d{11}$");
			map.Add("LT", @"^LT\d{9,12}$");
			map.Add("LU", @"^LU\d{8}$");
			map.Add("LV", @"^LV\d{11}$");
			map.Add("MT", @"^MT\d{8}$");
			map.Add("NL", @"^NL[A-Z0-9+*]{12}$");
			map.Add("PL", @"^PL\d{10}$");
			map.Add("PT", @"^PT\d{9}$");
			map.Add("RO", @"^RO\d{2,10}$");
			map.Add("SE", @"^SE\d{12}$");
			map.Add("SI", @"^SI\d{8}$");
			map.Add("SK", @"^SK\d{10}$");
			map.Add("XI", @"^XI[A-Z0-9]{5,12}$");
		}

		/// <summary>
		/// Konwertuje podany numer EU VAT do postaci znormalizowanej
		/// </summary>
		/// <param name="nip">numer EU VAT w dowolnym formacie</param>
		/// <returns>znormalizowany numer EU VAT</returns>
		[ComVisible(false)]
		public static string Normalize(string nip)
        {
            if (nip == null || nip.Length == 0)
            {
                return null;
            }

            nip = nip.Replace("-", "");
            nip = nip.Replace(" ", "");
            nip = nip.Trim().ToUpper();

			Regex re = new Regex(@"^[A-Z]{2}[A-Z0-9+*]{2,12}$");

			if (!re.IsMatch(nip))
			{
				return null;
			}

			return nip;
        }

		/// <summary>
		/// Konwertuje podany numer EU VAT do postaci znormalizowanej
		/// </summary>
		/// <param name="nip">numer EU VAT w dowolnym formacie</param>
		/// <returns>znormalizowany numer EU VAT</returns>
		string IEUVAT.Normalize(string nip)
		{
			return Normalize(nip);
		}

		/// <summary>
		/// Sprawdza poprawność numeru EU VAT
		/// </summary>
		/// <param name="nip">numer EU VAT</param>
		/// <returns>true jeżeli podany numer jest prawidłowy</returns>
		[ComVisible(false)]
		public static bool IsValid(string nip)
        {
            if ((nip = Normalize(nip)) == null)
            {
                return false;
            }

            string cc = nip.Substring(0, 2).ToUpper();
            string num = nip.Substring(2).ToUpper();

			if (!map.ContainsKey(cc))
			{
				return false;
			}

			Regex re = new Regex(map[cc]);

			if (!re.IsMatch(nip))
			{
				return false;
			}

			if (cc.Equals("PL"))
            {
                return NIP.IsValid(num);
            }

            return true;
		}

		/// <summary>
		/// Sprawdza poprawność numeru EU VAT
		/// </summary>
		/// <param name="nip">numer EU VAT</param>
		/// <returns>true jeżeli podany numer jest prawidłowy</returns>
		bool IEUVAT.IsValid(string nip)
		{
			return IsValid(nip);
		}
	}

	#endregion
}
