using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace XSLTtransformXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidarXSLT_Click(object sender, EventArgs e)
        {
            validarXSLT();
        }
        private Boolean validarXSLT()
        {
            String xml = rtboxXSLT.Text;
            Boolean resultado = false;

            using (XmlReader xr = XmlReader.Create(
              new StringReader(xml)))
            {
                try
                {
                    while (xr.Read()) { }
                    this.rtxtResultado.Text = ("Validacion de XSLT, Exito");
                    this.rtxtResultado.ForeColor = Color.Black;
                    resultado = true;
                }
                catch (Exception ex)
                {
                    this.rtxtResultado.Text = ("Validacion de XSLT, Fallo: " + ex.Message);
                    this.rtxtResultado.ForeColor = Color.Red;

                }
            }
            return resultado;

        }
        private void btnValidarXML_Click(object sender, EventArgs e)
        {
            validarXML();
        }

        private Boolean validarXML() {
            String xml = rtboxXML.Text;
            Boolean resultado = false;
            using (XmlReader xr = XmlReader.Create(new StringReader(xml)))
            {
                try
                {
                    while (xr.Read()) { }
                    this.rtxtResultado.Text = ("Validacion de XML, Exito");
                    this.rtxtResultado.ForeColor = Color.Black;
                    resultado = true;

                }
                catch (Exception ex)
                {
                    this.rtxtResultado.Text = ("Validacion de XML, Fallo: " + ex.Message);
                    this.rtxtResultado.ForeColor = Color.Red;

                }
            }

            return resultado;

        }
        private void btnTransformar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarXSLT() && validarXML()) {
            
            String inputXML = rtboxXML.Text;
             String transformXSL = rtboxXSLT.Text;

             XslCompiledTransform proc = new XslCompiledTransform();

            using (StringReader sr = new StringReader(transformXSL))
            {
                using (XmlReader xr = XmlReader.Create(sr))
                {
                    proc.Load(xr);
                }
            }

            String resultXML="";

            using (StringReader sr = new StringReader(inputXML))
            {
                using (XmlReader xr = XmlReader.Create(sr))
                {
                    using (StringWriter sw = new StringWriter())
                    {
                        proc.Transform(xr, null, sw);
                        resultXML = sw.ToString();
                    }
                }
            }
                    if (!String.IsNullOrEmpty(resultXML))
                    {
                        this.rtxtResultado.Text = (resultXML);
                        this.rtxtResultado.ForeColor = Color.Black;
                    }
                    else {
                        this.rtxtResultado.Text = ("Transformacion, no retorno ningun resultado ");
                        this.rtxtResultado.ForeColor = Color.Blue;
                    }
                }
            }
            catch (Exception ex)
            {
                this.rtxtResultado.Text = ("Transformacion, Fallo: " + ex.Message+" , "+ex.StackTrace);
                this.rtxtResultado.ForeColor = Color.Red;

            }
        }

        private void llblXMLEjemplo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><anagrafica><testata><nomemercato id=\"007\">Mercato di test</nomemercato><data>Giovedi 18 dicembre 2003 16.05.29</data></testata><record><codice_cliente>5</codice_cliente><rag_soc>Miami American Cafe</rag_soc><codice_fiscale>IT07654930130</codice_fiscale><indirizzo tipo=\"casa\">Viale Carlo Espinasse 5, Como</indirizzo><num_prodotti>13</num_prodotti></record></anagrafica>";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);
            tx.Formatting = Formatting.Indented;
            doc.WriteTo(tx);
        
            rtboxXML.Text = sw.ToString();

        }

        private void llblXSLTEjemplo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><xsl:stylesheet xmlns:xsl=\"http://www.w3.org/1999/XSL/Transform\" xmlns=\"http://www.w3.org/1999/xhtml\" version=\"1.0\"><xsl:output encoding=\"UTF-8\" indent=\"yes\" method=\"xml\" standalone=\"no\" omit-xml-declaration=\"no\"/><xsl:template match=\"anagrafica\"><html><body><h1><font color=\"red\"><xsl:value-of select=\"testata/nomemercato/@id\"/></font><xsl:value-of select=\"testata/nomemercato\"/></h1><h2><xsl:value-of select=\"testata/data\"/></h2><hr/><table bgcolor=\"yellow\" border=\"1\"><tbody><tr><th>Cod. Cliente</th><th>Ragione Sociale</th><th>Codice Fiscale/P.Iva</th><th>Indirizzo</th></tr><xsl:for-each select=\"record\"><tr><td><xsl:value-of select=\"codice_cliente\"/></td><td><xsl:value-of select=\"rag_soc\"/></td><td><xsl:value-of select=\"codice_fiscale\"/></td><td><xsl:value-of select=\"indirizzo\"/></td></tr></xsl:for-each></tbody></table></body></html></xsl:template></xsl:stylesheet>";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);
            tx.Formatting = Formatting.Indented;
            doc.WriteTo(tx);

            rtboxXSLT.Text = sw.ToString();
        }
    }
}
