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
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NIP24
{
	#region interface

	/// <summary>
	/// Wynik wyszukiwania danych
	/// </summary>
	[Guid("2CF3B248-A621-4689-BA5F-E2426393D182")]
	[ComVisible(true)]
	public interface ISearchResult
    {
		/// <summary>
		/// Unikalny identyfikator odpowiedzi
		/// </summary>
		[DispId(1)]
		string UID { get; set; }

		/// <summary>
		/// Wyszukane dane
		/// </summary>
		[DispId(2)]
		object[] Results { get; set; }

		/// <summary>
		/// Identyfikator odpowiedzi z rejestru referencyjnego
		/// </summary>
		[DispId(3)]
		string ID { get; set; }

		/// <summary>
		/// Data sprawdzenia
		/// </summary>
		[DispId(4)]
		DateTime Date { get; set; }

		/// <summary>
		/// Źródło informacji
		/// </summary>
		[DispId(5)]
		string Source { get; set; }

		[DispId(6)]
		string ToString();
    }

	#endregion

	#region implementation

	/// <summary>
	/// Status firmy w rejestrze VAT
	/// </summary>
	[Guid("678D658D-60BC-46CD-8D50-6341310F771A")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class SearchResult : ISearchResult
	{
		/// <summary>
		/// Unikalny identyfikator odpowiedzi
		/// </summary>
		public string UID { get; set; }

		/// <summary>
		/// Wyszukane dane
		/// </summary>
		[ComVisible(false)]
		public List<object> Results { get; set; }

		/// <summary>
		/// Wyszukane dane
		/// </summary>
		object[] ISearchResult.Results
		{
			get { return Results.ToArray(); }
			set { Results = new List<object>(value); }
		}

		/// <summary>
		/// Identyfikator odpowiedzi z rejestru referencyjnego
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
		DateTime ISearchResult.Date
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
		public SearchResult()
		{
			Results = new List<object>();
		}

		public override string ToString()
		{
			return "SearchResult: [uid = " + UID
				+ ", results = [" + string.Join(", ", Results.ConvertAll(e => Convert.ToString(e)).ToArray()) + "]"
				+ ", id = " + ID
				+ ", date = " + Date
				+ ", source = " + Source
				+ "]";
		}
	}

	#endregion
}
