using System;
using DataCommon.AuditExtension;
using DataCommon.IdentityExtension;

namespace BillingDomain.CartaPorte
{
    public class ComplementoCartaPorteMercancia : IdentityDomain, IAuditTable
    {
        public string ConceptoId { get; set; }
        public string ClaveEmbalaje { get; set; }
        public string ClaveMaterialPeligroso { get; set; }
        public string ClaveSTCC { get; set; }
        public string DescripcionEmbalaje { get; set; }
        public string Dimensiones { get; set; }
        public string FraccionArancelaria { get; set; }
        public bool MaterialPeligroso { get; set; }
        public string Moneda { get; set; }
        public double PesoEnKg { get; set; }
        public string UUIDComercioExt { get; set; }
        public string ValorMercancia { get; set; }
        public string NumeroPiezas { get; set; }
        public string PesoBruto { get; set; }
        public string PesoNeto { get; set; }
        public string PesoTara { get; set; }
        public string UnidadMedidaPeso { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
