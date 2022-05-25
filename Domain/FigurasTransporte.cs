using System;
using DataCommon.AuditExtension;
using DataCommon.IdentityExtension;

namespace BillingDomain.CartaPorte
{
    public class FigurasTransporte : IdentityDomain, IAuditTable
    {
        public string Nombre { get; set; }
        public string NumeroLicencia { get; set; }
        public string NumeroRegistroIdentificacionFiscal { get; set; }
        public string ResidenciaFiscal { get; set; }
        public string Rfc { get; set; }
        public int TipoFiguraTransporte { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
