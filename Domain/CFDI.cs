using System;
using DataCommon.AuditExtension;
using DataCommon.IdentityExtension;

namespace BillingDomain.CartaPorte
{
    public class CFDI : IdentityDomain, IAuditTable
    {
        public string EmpresaId { get; set; }
        public string ErpId { get; set; }
        public string ReferenciaErp { get; set; }
        public string ClienteId { get; set; }
        public string Comentarios { get; set; }
        public string Complemento { get; set; }
        public string CondicionesDePago { get; set; }
        public double Descuento { get; set; }
        public string DireccionEnvioId { get; set; }
        public string EmisorFacAtrAdquiriente { get; set; }
        public string EmisorRazonSocial { get; set; }
        public string EmisorRegimenFiscalId { get; set; }
        public string EmisorRfc { get; set; }
        public string ErpTipoDocumento { get; set; }
        public string Exportacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Folio { get; set; }
        public string FormaDePago { get; set; }
        public string InformacionGlobalAnio { get; set; }
        public string InformacionGlobalMeses { get; set; }
        public string InformacionGlobalPeriodicidad { get; set; }
        public string LugarExpedicion { get; set; }
        public string MetodoDePago { get; set; }
        public string ModuloErp { get; set; }
        public string MonedaId { get; set; }
        public string MotivoDescuento { get; set; }
        public string NombreReporte { get; set; }
        public string OrdenCompra { get; set; }
        public string PacRfc { get; set; }
        public string PedidoId { get; set; }
        public string ReceptorEmail { get; set; }
        public string ReceptorRazonSocial { get; set; }
        public string ReceptorRegimenFiscalId { get; set; }
        public string ReceptorRfc { get; set; }
        public string ReceptorCalle { get; set; }
        public string ReceptorCiudadId { get; set; }
        public string ReceptorCodigoPostalId { get; set; }
        public string ReceptorColonia { get; set; }
        public string ReceptorCurp { get; set; }
        public bool ReceptorEnviarEmailAutomaticamente { get; set; }
        public string ReceptorEstadoId { get; set; }
        public bool ReceptorMostrarDomicilioFiscal { get; set; }
        public string ReceptorMunicipioId { get; set; }
        public string ReceptorNombreComercial { get; set; }
        public string ReceptorNumeroExterior { get; set; }
        public string ReceptorNumeroInterior { get; set; }
        public string ReceptorPaisId { get; set; }
        public string ReceptorRegistroIdentificacionFiscal { get; set; }
        public string ReceptorUsoCfdi { get; set; }
        public double Saldo { get; set; }
        public string Serie { get; set; }
        public string SerieAtributo { get; set; }
        public double SubTotal { get; set; }
        public string SucursalAtributo { get; set; }
        public string SucursalId { get; set; }
        public bool TimbrarComprobanteAutomaticamente { get; set; }
        public double TipoCambio { get; set; }
        public string TipoDocumentoId { get; set; }
        public string TipoRelacionComprobantes { get; set; }
        public double Total { get; set; }
        public double TotalImpuestosLocalesRetenidos { get; set; }
        public double TotalImpuestosLocalesTrasladados { get; set; }
        public double TotalImpuestosRetenidos { get; set; }
        public double TotalImpuestosTrasladados { get; set; }
        public bool ValidarInformacionWebApp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
