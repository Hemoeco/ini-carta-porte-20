using System;
using DataCommon.AuditExtension;
using DataCommon.IdentityExtension;

namespace BillingDomain.CartaPorte
{
    public class CantidadesTransporta : IdentityDomain, IAuditTable
    {
        public double Cantidad { get; set; }
        public string CvesTransporte { get; set; }
        public string IDDestino { get; set; }
        public string IDOrigen { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
