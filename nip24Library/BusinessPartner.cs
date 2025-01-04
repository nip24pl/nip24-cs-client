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

using System.Runtime.InteropServices;

namespace NIP24
{
    #region interface

    /// <summary>
    /// Interfejs elementu listy wspólników s.c.
    /// </summary>
    [Guid("4C20999B-27DF-44BF-9535-25B11EB9F570")]
    [ComVisible(true)]
    public interface IBusinessPartner
    {
        /// <summary>
        /// Numer REGON
        /// </summary>
        [DispId(1)]
        string REGON { get; set; }

        /// <summary>
        /// Nazwa firmy
        /// </summary>
        [DispId(2)]
        string FirmName { get; set; }

        /// <summary>
        /// Imię pierwsze
        /// </summary>
        [DispId(3)]
        string FirstName { get; set; }

        /// <summary>
        /// Imię drugie
        /// </summary>
        [DispId(4)]
        string SecondName { get; set; }

        /// <summary>
        /// Nazwisko
        /// </summary>
        [DispId(5)]
        string LastName { get; set; }

        [DispId(6)]
        string ToString();
    }

    #endregion

    #region implementation

    /// <summary>
    /// Element listy wspólników s.c.
    /// </summary>
    [Guid("C29DEC29-AB37-4A0C-93B5-8335D1A222FE")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class BusinessPartner : IBusinessPartner
    {
        /// <summary>
        /// Numer REGON
        /// </summary>
        public string REGON { get; set; }

        /// <summary>
        /// Nazwa firmy
        /// </summary>
        public string FirmName { get; set; }

        /// <summary>
        /// Imię pierwsze
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Imię drugie
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Nazwisko
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Tworzy nowy, pusty obiekt
        /// </summary>
        public BusinessPartner()
        {
        }

        public override string ToString()
        {
            return "BusinessPartner: [regon = " + REGON
                + ", firmName = " + FirmName
                + ", firstName = " + FirstName
                + ", secondName = " + SecondName
                + ", lastName = " + LastName
                + "]";
        }
    }

    #endregion
}
