using System;
using DataCommon.AuditExtension;
using DataCommon.IdentityExtension;

namespace BillingDomain.CartaPorte
{
    public class Concepto : IdentityDomain, IAuditTable
    {
        public string ConceptoId { get; set; }
        public double Cantidad { get; set; }
        public string ComentariosConcepto { get; set; }
        public string Complemento { get; set; }
        public string Descripcion { get; set; }
        public double DescuentoConcepto { get; set; }
        public string ErpIdConcepto { get; set; }
        public string GrupoImpuestos { get; set; }
        public double Importe { get; set; }
        public string NoIdentificacion { get; set; }
        public string ObjetoDeImpuestos { get; set; }
        public double PrecioBase { get; set; }
        public string ProductoServicioId { get; set; }
        public string UnidadMedida { get; set; }
        public string UnidadMedidaClave { get; set; }
        public double ValorUnitario { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
