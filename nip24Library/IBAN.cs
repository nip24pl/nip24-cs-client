/**
 * Copyright 2015-2019 NETCAT (www.netcat.pl)
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
 * @copyright 2015-2019 NETCAT (www.netcat.pl)
 * @license http://www.apache.org/licenses/LICENSE-2.0
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace NIP24
{
	#region interface

	/// <summary>
	/// Weryfikator numeru rachunku bankowego IBAN
	/// </summary>
	[Guid("C76ABFD5-38EC-457D-9723-97F63A76AF4C")]
	[ComVisible(true)]
	public interface IIBAN
    {
		/// <summary>
		/// Konwertuje podany numer IBAN do postaci znormalizowanej
		/// </summary>
		/// <param name="iban">numer IBAN w dowolnym formacie</param>
		/// <returns>znormalizowany numer IBAN</returns>
		[DispId(1)]
		string Normalize(string iban);

		/// <summary>
		/// Sprawdza poprawność numeru IBAN
		/// </summary>
		/// <param name="iban">numer IBAN</param>
		/// <returns>true jeżeli podany numer jest prawidłowy</returns>
		[DispId(2)]
		bool IsValid(string iban);
    }

	#endregion

	#region implementation

	/// <summary>
	/// Weryfikator numeru rachunku bankowego
	/// </summary>
	[Guid("903C2D3C-1FB0-4749-9377-350D129D1369")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class IBAN : IIBAN
	{
		private static Dictionary<string,string> map = new Dictionary<string, string>();

		static IBAN()
		{
			map.Add("AD", @"^AD\d{10}[A-Z0-9]{12}$");
			map.Add("AE", @"^AE\d{21}$");
			map.Add("AL", @"^AL\d{10}[A-Z0-9]{16}$");
			map.Add("AT", @"^AT\d{18}$");
			map.Add("AZ", @"^AZ\d{2}[A-Z]{4}[A-Z0-9]{20}$");
			map.Add("BA", @"^BA\d{18}$");
			map.Add("BE", @"^BE\d{14}$");
			map.Add("BG", @"^BG\d{2}[A-Z]{4}\d{6}[A-Z0-9]{8}$");
			map.Add("BH", @"^BH\d{2}[A-Z]{4}[A-Z0-9]{14}$");
			map.Add("BR", @"^BR\d{25}[A-Z]{1}[A-Z0-9]{1}$");
			map.Add("BY", @"^BY\d{2}[A-Z0-9]{4}\d{4}[A-Z0-9]{16}$");
			map.Add("CH", @"^CH\d{7}[A-Z0-9]{12}$");
			map.Add("CR", @"^CR\d{20}$");
			map.Add("CY", @"^CY\d{10}[A-Z0-9]{16}$");
			map.Add("CZ", @"^CZ\d{22}$");
			map.Add("DE", @"^DE\d{20}$");
			map.Add("DK", @"^DK\d{16}$");
			map.Add("DO", @"^DO\d{2}[A-Z0-9]{4}\d{20}$");
			map.Add("EE", @"^EE\d{18}$");
			map.Add("ES", @"^ES\d{22}$");
			map.Add("FI", @"^FI\d{16}$");
			map.Add("FO", @"^FO\d{16}$");
			map.Add("FR", @"^FR\d{12}[A-Z0-9]{11}\d{2}$");
			map.Add("GB", @"^GB\d{2}[A-Z]{4}\d{14}$");
			map.Add("GE", @"^GE\d{2}[A-Z]{2}\d{16}$");
			map.Add("GI", @"^GI\d{2}[A-Z]{4}[A-Z0-9]{15}$");
			map.Add("GL", @"^GL\d{16}$");
			map.Add("GR", @"^GR\d{9}[A-Z0-9]{16}$");
			map.Add("GT", @"^GT\d{2}[A-Z0-9]{24}$");
			map.Add("HR", @"^HR\d{19}$");
			map.Add("HU", @"^HU\d{26}$");
			map.Add("IE", @"^IE\d{2}[A-Z]{4}\d{14}$");
			map.Add("IL", @"^IL\d{21}$");
			map.Add("IQ", @"^IQ\d{2}[A-Z]{4}\d{15}$");
			map.Add("IS", @"^IS\d{24}$");
			map.Add("IT", @"^IT\d{2}[A-Z]{1}\d{10}[A-Z0-9]{12}$");
			map.Add("JO", @"^JO\d{2}[A-Z]{4}\d{4}[A-Z0-9]{18}$");
			map.Add("KW", @"^KW\d{2}[A-Z]{4}[A-Z0-9]{22}$");
			map.Add("KZ", @"^KZ\d{5}[A-Z0-9]{13}$");
			map.Add("LB", @"^LB\d{6}[A-Z0-9]{20}$");
			map.Add("LC", @"^LC\d{2}[A-Z]{4}[A-Z0-9]{24}$");
			map.Add("LI", @"^LI\d{7}[A-Z0-9]{12}$");
			map.Add("LT", @"^LT\d{18}$");
			map.Add("LU", @"^LU\d{5}[A-Z0-9]{13}$");
			map.Add("LV", @"^LV\d{2}[A-Z]{4}[A-Z0-9]{13}$");
			map.Add("MC", @"^MC\d{12}[A-Z0-9]{11}\d{2}$");
			map.Add("MD", @"^MD\d{2}[A-Z0-9]{20}$");
			map.Add("ME", @"^ME\d{20}$");
			map.Add("MK", @"^MK\d{5}[A-Z0-9]{10}\d{2}$");
			map.Add("MR", @"^MR\d{25}$");
			map.Add("MT", @"^MT\d{2}[A-Z]{4}\d{5}[A-Z0-9]{18}$");
			map.Add("MU", @"^MU\d{2}[A-Z]{4}\d{19}[A-Z]{3}$");
			map.Add("NL", @"^NL\d{2}[A-Z]{4}\d{10}$");
			map.Add("NO", @"^NO\d{13}$");
			map.Add("PK", @"^PK\d{2}[A-Z]{4}[A-Z0-9]{16}$");
			map.Add("PL", @"^PL\d{26}$");
			map.Add("PS", @"^PS\d{2}[A-Z]{4}[A-Z0-9]{21}$");
			map.Add("PT", @"^PT\d{23}$");
			map.Add("QA", @"^QA\d{2}[A-Z]{4}[A-Z0-9]{21}$");
			map.Add("RO", @"^RO\d{2}[A-Z]{4}[A-Z0-9]{16}$");
			map.Add("RS", @"^RS\d{20}$");
			map.Add("SA", @"^SA\d{4}[A-Z0-9]{18}$");
			map.Add("SC", @"^SC\d{2}[A-Z]{4}\d{20}[A-Z]{3}$");
			map.Add("SE", @"^SE\d{22}$");
			map.Add("SI", @"^SI\d{17}$");
			map.Add("SK", @"^SK\d{22}$");
			map.Add("SM", @"^SM\d{2}[A-Z]{1}\d{10}[A-Z0-9]{12}$");
			map.Add("ST", @"^ST\d{23}$");
			map.Add("SV", @"^SV\d{2}[A-Z]{4}\d{20}$");
			map.Add("TL", @"^TL\d{21}$");
			map.Add("TN", @"^TN\d{22}$");
			map.Add("TR", @"^TR\d{8}[A-Z0-9]{16}$");
			map.Add("UA", @"^UA\d{8}[A-Z0-9]{19}$");
			map.Add("VG", @"^VG\d{2}[A-Z]{4}\d{16}$");
			map.Add("XK", @"^XK\d{18}$");
		}

		/// <summary>
		/// Konwertuje podany numer IBAN do postaci znormalizowanej
		/// </summary>
		/// <param name="iban">numer IBAN w dowolnym formacie</param>
		/// <returns>znormalizowany numer IBAN</returns>
		[ComVisible(false)]
		public static string Normalize(string iban)
		{
			if (iban == null || iban.Length == 0)
			{
				return null;
			}

			iban = iban.Replace(" ", "");
			iban = iban.Trim().ToUpper();

			Regex re = new Regex(@"^[A-Z]{2}[0-9A-Z]{13,30}$");

			if (!re.IsMatch(iban))
			{
				return null;
			}

			return iban;
		}

		/// <summary>
		/// Konwertuje podany numer IBAN do postaci znormalizowanej
		/// </summary>
		/// <param name="iban">numer IBAN w dowolnym formacie</param>
		/// <returns>znormalizowany numer IBAN</returns>
		string IIBAN.Normalize(string iban)
		{
			return Normalize(iban);
		}

		/// <summary>
		/// Sprawdza poprawność numeru IBAN
		/// </summary>
		/// <param name="iban">numer IBAN</param>
		/// <returns>true jeżeli podany numer jest prawidłowy</returns>
		[ComVisible(false)]
		public static bool IsValid(string iban)
		{
			if ((iban = Normalize(iban)) == null)
			{
				return false;
			}

			string cc = iban.Substring(0, 2);

			if (!map.ContainsKey(cc))
			{
				return false;
			}

			Regex re = new Regex(map[cc]);

			if (!re.IsMatch(iban))
			{
				return false;
			}

			StringBuilder sb = new StringBuilder();
			iban = iban.Substring(4, iban.Length - 4) + iban.Substring(0, 4);

			foreach (char ch in iban)
			{
				int n;

				if (char.IsLetter(ch))
				{
					n = ch - 55;
				}
				else
				{
					n = int.Parse(ch.ToString());
				}
					
				sb.Append(n);
			}

			string str = sb.ToString();
			var chk = int.Parse(str.Substring(0, 1));

			for (var i = 1; i < str.Length; i++)
			{
				chk *= 10;
				chk += int.Parse(str.Substring(i, 1));
				chk %= 97;
			}

			return (chk == 1);
		}

		/// <summary>
		/// Sprawdza poprawność numeru IBAN
		/// </summary>
		/// <param name="iban">numer IBAN</param>
		/// <returns>true jeżeli podany numer jest prawidłowy</returns>
		bool IIBAN.IsValid(string iban)
		{
			return IsValid(iban);
		}
	}

	#endregion
}
