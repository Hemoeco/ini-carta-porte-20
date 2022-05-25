using System;
using System.Collections.Generic;
using DataCommon.AuditExtension;
using DataCommon.IdentityExtension;

namespace BillingDomain.CartaPorte
{
    public class ComplementoCartaPorte : IdentityDomain, IAuditTable
    {
        public string EntradaSalidaMercancia { get; set; }
        public string PaisOrigenDestino { get; set; }
        public double TotalDistanciaRecorrida { get; set; }
        public string TransporteInternacional { get; set; }
        public string ViaEntradaSalida { get; set; }
        public double MercanciasCargoPorTasacion { get; set; }
        public int MercanciasNumeroTotalMercancias { get; set; }
        public double MercanciasPesoBrutoTotal { get; set; }
        public double MercanciasPesoNetoTotal { get; set; }
        public string MercanciasUnidadPeso { get; set; }
        public string NumeroPermisoSCT { get; set; }
        public string TipoPermisoSCT { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
