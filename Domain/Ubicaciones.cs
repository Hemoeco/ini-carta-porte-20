using System;
using DataCommon.AuditExtension;
using DataCommon.IdentityExtension;

namespace BillingDomain.CartaPorte
{
    public class Ubicaciones : IdentityDomain, IAuditTable
    {
        public double DistanciaRecorrida { get; set; }
        public DateTime FechaHoraSalidaLlegada { get; set; }
        public string IDUbicacion { get; set; }
        public string NavegacionTrafico { get; set; }
        public string NombreEstacion { get; set; }
        public string NombreRemitenteDestinatario { get; set; }
        public string NumeroEstacion { get; set; }
        public string NumeroIdentificacionFiscal { get; set; }
        public string ResidenciaFiscal { get; set; }
        public string RfcRemitenteDestinatario { get; set; }
        public string TipoEstacion { get; set; }
        public int TipoUbicacion { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
