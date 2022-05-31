using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace LeerYEscribirCPXml
{
    internal class Program
    {
        const string ARCHIVO_PRUEBA = "cfd-prueba.xml";

        static void Main(string[] args)
        {
            Console.WriteLine("Probar carta porte");

            // Prueba de lectura
            //
            // Este proceso tarda aprox. 15 minutos, salida:
            //
            // Probar carta porte
            // serializer... (10:12:33 a.m.)
            // leer archivo... (10:20:47 a.m.)
            // cargado... (10:24:54 a.m.)
            // cfdi v.3.3.
            // Complementos: 1
            // Complemento: cartaporte20: CartaPorte
            // Complemento: tfd: TimbreFiscalDigital
            //ProbarLectura();

            // Prueba de escritura
            //
            // Este proceso toma aprox. 10 min, salida:
            // Probar carta porte
            // ------ - escribir archivo------ -
            // serializer... (03:49:39 p.m.)
            // escribir... (03:55:46 p.m.)
            // terminado... (03:58:58 p.m.)
            //ProbarEscritura();

            // -------------------------------------------------------
            // Ambos procesos, lectura y escritura, toma 18 minutos
            // Probar carta porte
            // ------ - leer archivo------ -
            // serializer... (05:01:45 p.m.)
            // leer archivo... (05:12:21 p.m.)
            // cargado... (05:15:48 p.m.)
            // cfdi v.3.3.
            // Complementos: 1
            // Complemento: cartaporte20: CartaPorte
            // Complemento: tfd: TimbreFiscalDigital
            // ------ - escribir archivo------ -
            // serializer... (05:15:48 p.m.)
            // escribir... (05:15:48 p.m.)
            // terminado... (05:18:01 p.m.)
            //
            // Como conclusión podemos decir que es impractico utilizar 
            // estas clases, pues además de que la ejecución es lenta,
            // Al trabajar con VS el uso de memoria (16GB en mi maquina)
            // se eleva hasta el 98%
            // -------------------------------------------------------


            // validar con xsd
            //
            // Probar carta porte
            // ------ - validar archivo------ -
            // new XmlSchemaSet... (05:52:02 p.m.)
            // schemas.add... (05:52:02 p.m.)
            // XDocument.Load... (05:52:04 p.m.)
            // validate... (05:52:04 p.m.)
            // The 'Fecha' attribute is invalid - The value '2022-05-31T17:15:48.6463752-05:00' is invalid according to its datatype 'http://www.sat.gob.mx/sitio_internet/cfd/tipoDatos/tdCFDI:t_FechaH' - The Pattern constraint failed.
            // The required attribute 'Sello' is missing.
            // The required attribute 'NoCertificado' is missing.
            // The required attribute 'Certificado' is missing.
            // The element 'Comprobante' in namespace 'http://www.sat.gob.mx/cfd/3' has incomplete content.List of possible elements expected: 'Conceptos' in namespace 'http://www.sat.gob.mx/cfd/3'.
            // custOrdDoc did not validate... 05:52:04 p.m.
            ValidarConXsd();
        }

        static string Hora => String.Format("{0:T}", DateTime.Now);

        static void ProbarLectura()
        {
            Comprobante cfd = LeerArchivo("EjemploTimbrado.xml");

            Console.WriteLine($"cfdi v.{cfd.Version}."); 
            
            Console.WriteLine($"Complementos: {cfd.Complemento.Length}");
            foreach (ComprobanteComplemento c in cfd.Complemento)
            {
                foreach(XmlElement a in c.Any)
                {
                    Console.WriteLine($"Complemento: {a.Name}");
                }
            }

            // Aquí podemos ver algunos de sus propiedades:
            //Console.WriteLine($"Ubicaciones: {cp.Ubicaciones.Length}");
            //foreach (var u in cp.Ubicaciones)
            //{
            //    Console.WriteLine($"{u.TipoUbicacion} {u.Domicilio}");
            //}
        }

        static Comprobante LeerArchivo(string pathFName)
        {
            Console.WriteLine($"------- leer archivo -------");

            Console.WriteLine($"serializer... ({Hora})");
            XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));

            // Declare an object variable of the type to be deserialized.
            Comprobante cfd;

            Console.WriteLine($"leer archivo... ({Hora})");
            using (Stream reader = new FileStream(pathFName, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                cfd = serializer.Deserialize(reader) as Comprobante;
            }

            Console.WriteLine($"cargado... ({Hora})");
            return cfd;
        }


        static void ProbarEscritura()
        {
            Comprobante cfd = new Comprobante()
            {
                Emisor = new ComprobanteEmisor()
                {
                    Rfc = "HRE1401015C9",
                    Nombre = "Hemoeco Renta, S.A. de C.V.",
                    RegimenFiscal = c_RegimenFiscal.Item601
                },
                Receptor = new ComprobanteReceptor()
                {
                    Rfc="MIS160419E6A",
                    Nombre="Montajes e ingenieria Sultana",
                    UsoCFDI = c_UsoCFDI.S01
                },
                Fecha = DateTime.Now,
                SubTotal = 0,
                Total = 0,
                Moneda = c_Moneda.MXN,
                TipoDeComprobante = c_TipoDeComprobante.T,
                LugarExpedicion = c_CodigoPostal.Item44630
            };

            EscribirArchivo(ARCHIVO_PRUEBA, cfd);
        }

        static void EscribirArchivo(string pathFName, Comprobante cfd)
        {
            Console.WriteLine($"------- escribir archivo -------");

            using (FileStream f = new FileStream(pathFName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                Console.WriteLine($"serializer... ({Hora})");
                XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));

                Console.WriteLine($"escribir... ({Hora})");
                serializer.Serialize(f, cfd);

                Console.WriteLine($"terminado... ({Hora})");
            }
        }

        static void ValidarConXsd()
        {
            Console.WriteLine($"------- validar archivo -------");

            // Referencia: 
            // Example: Validate an XML document from a file against a schema from a file
            // https://docs.microsoft.com/en-us/dotnet/standard/linq/validate-xsd

            Console.WriteLine($"new XmlSchemaSet... ({Hora})");
            // validar
            bool errors = false;
            XmlSchemaSet schemas = new XmlSchemaSet();
            //schemas.Add("xmlns:catCartaPorte", "catCartaPorte.xsd");
            //schemas.Add("xmlns:catComExt", "catComExt.xsd");
            //schemas.Add("xmlns:cartaporte20", "cartaporte20.xsd");
            //schemas.Add("xmlns:tdCFDI", "tdCFDI.xsd");
            //schemas.Add("xmlns:catCFDI", "catCFDI.xsd");
            //schemas.Add("", "cfdv33.xsd");
            Console.WriteLine($"schemas.add... ({Hora})");
            schemas.Add(null, "SAT\\catCartaPorte.xsd");
            schemas.Add(null, "SAT\\catComExt.xsd");
            schemas.Add(null, "SAT\\cartaporte20.xsd");
            schemas.Add(null, "SAT\\tdCFDI.xsd");
            schemas.Add(null, "SAT\\catCFDI.xsd");
            schemas.Add(null, "SAT\\cfdv33.xsd");

            Console.WriteLine($"XDocument.Load... ({Hora})");
            XDocument cfdDoc = XDocument.Load(ARCHIVO_PRUEBA);

            Console.WriteLine($"validate... ({Hora})");
            cfdDoc.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });

            Console.WriteLine("custOrdDoc {0}... {1}", errors ? "did not validate" : "validated", Hora);
        }
    }
}
