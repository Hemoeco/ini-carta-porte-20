using System;
using DataCommon.AuditExtension;
using DataCommon.IdentityExtension;

namespace BillingDomain.CartaPorte
{
    public class Impuesto : IdentityDomain, IAuditTable
    {
        public int LineaImpuesto { get; set; }
        public string CodigoImpuesto { get; set; }
        public double ImporteBase { get; set; }
        public double ImporteImpuesto { get; set; }
        public double TasaOCuota { get; set; }
        public int TipoFactor { get; set; }
        public int TipoImpuesto { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
