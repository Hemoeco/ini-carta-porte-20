using System;
using DataCommon.AuditExtension;
using DataCommon.IdentityExtension;

namespace BillingDomain.CartaPorte
{
    public class Domicilio : IdentityDomain, IAuditTable
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public string CodigoDomicilio { get; set; }
        public string CodigoPostal { get; set; }
        public string Colonia { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string NumeroExterior { get; set; }
        public object NumeroInterior { get; set; }
        public string Pais { get; set; }
        public string Referencia { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
