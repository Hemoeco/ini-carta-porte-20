using System;
using DataCommon.AuditExtension;
using DataCommon.IdentityExtension;

namespace BillingDomain.CartaPorte
{
    public class Autotransporte : IdentityDomain, IAuditTable
    {
        public int AnioModeloVM { get; set; }
        public string ConfiguracionVehicular { get; set; }
        public string PlacaVM { get; set; }
        public string SeguroAseguraResponsabilidadCivil { get; set; }
        public string SeguroPolizaResponsabilidadCivil { get; set; }
        public string SeguroAseguraMedioAmbiente { get; set; }
        public string SeguroPolizaMedioAmbiente { get; set; }
        public string SeguroAseguraCarga { get; set; }
        public string SeguroPolizaCarga { get; set; }
        public string SeguroPrimaSeguro { get; set; }
        public string Remolque1Placa { get; set; }
        public string Remolque1SubTipoRemolque { get; set; }
        public string FederalRemolque2Placa { get; set; }
        public string FederalRemolque2SubTipoRemolque { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
