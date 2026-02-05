using System;
using System.Collections.Generic;
using System.Text;
using Haukcode.ArtNetIdentity.Lookup;

namespace Haukcode.ArtNetIdentity
{
    public class Manufacturer
    {
        public string? OrganizationName { get; set; }

        public string CompanyName { get; set; } = null!;

        public Manufacturer()
        {
        }

        internal Manufacturer(string companyName)
        {
            CompanyName = companyName;
        }

        internal Manufacturer(string? organizationName, string companyName)
        {
            OrganizationName = organizationName;
            CompanyName = companyName;
        }

        /// <summary>
        /// Returns the name of the manufacturer for the given ESTA code.
        /// Imported from the official list at https://tsp.esta.org/tsp/working_groups/CP/mfctrIDs.php
        /// </summary>
        /// <param name="estaCode">Manufacturer ID</param>
        /// <returns>The name that corresponds to the manufacturer, or null if one isn't assigned/unknown</returns>
        public static Manufacturer? FromEstaCode(int estaCode)
        {
            return EstaManufacturer.GetEstaName(estaCode);
        }
    }
}
