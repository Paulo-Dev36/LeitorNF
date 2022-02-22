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


namespace LeitorNF
{
    public partial class LeitorXML : Form
    {
        public LeitorXML()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrir();
           // LerXmlNfe();
        }
        private void abrir()
        {

            this.openFileDialog1.Title = "Selecione o XML";
            openFileDialog1.InitialDirectory = @"C:";
            openFileDialog1.Filter = "(*.XML)|*.XML";
            openFileDialog1.Multiselect = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    var arquivo1 = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader xml_streamReader = new StreamReader(arquivo);
                    StreamReader xml_streamReader1 = new StreamReader(arquivo1);
                    
                    xml_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    xml_streamReader1.BaseStream.Seek(0, SeekOrigin.Begin);

                    using (XmlReader meuXml1 = XmlReader.Create(arquivo1))
                    {
                        while (meuXml1.Read())
                        {
                            if (meuXml1.NodeType == XmlNodeType.Element && meuXml1.Name == "CNPJ")
                                txtCnpj.Text = meuXml1.ReadElementContentAsString();
                            if (meuXml1.NodeType == XmlNodeType.Element && meuXml1.Name == "xNome")
                                lblEmp.Text = meuXml1.ReadElementContentAsString();
                            if (meuXml1.NodeType == XmlNodeType.Element && meuXml1.Name == "dest")
                                break;
                        }
                    }


                    using (XmlReader meuXml = XmlReader.Create(arquivo))
                    {

                        var fimItens = false;
                        var item = "";
                        var cProd = "";
                        var xProd = "";
                        var NCM = "";
                        var qCom = "";
                        var vUnCom = "";
                        var vProd = "";
                        var ncm = "";
                        var xMotivo = "";
                        var CFOP = "";
                       
                        while (meuXml.Read())
                        {

                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "natOp")
                                textNaturezaOperacao.Text = meuXml.ReadElementContentAsString();

                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "nNF")
                                lblNF.Text = meuXml.ReadElementContentAsString();

                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "dhEmi")
                                lblDataemissao.Text = meuXml.ReadElementContentAsString();

                            //itens da NF
                            if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "det")
                            {
                                //lendo atributo da tag <det>
                                item = meuXml.GetAttribute("nItem");

                                //variáveis para aguardar o conteúdo do item
                                cProd = "";
                                xProd = "";
                                NCM = "";
                                qCom = "";
                                vUnCom = "";
                                vProd = "";
                                CFOP = "";

                            }
                            else if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "total")
                            {
                                fimItens = true;
                            }

                            if (!fimItens)
                            {
                                if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cProd")
                                    cProd = meuXml.ReadElementContentAsString();

                                if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xProd")
                                    xProd = meuXml.ReadElementContentAsString();

                                if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xMotibo")
                                    xMotivo = meuXml.ReadElementContentAsString();

                                if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "NCM")
                                    NCM = meuXml.ReadElementContentAsString();

                                if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "CFOP")
                                    CFOP = meuXml.ReadElementContentAsString();

                                if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "qCom")
                                    qCom = meuXml.ReadElementContentAsString().Replace(".", ",");

                                if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vUnCom")
                                    vUnCom = meuXml.ReadElementContentAsString().Replace(".", ",");

                                if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vProd")

                                {
                                    vProd = meuXml.ReadElementContentAsString().Replace(".", ",");
                                    listView1.Items.Add(new ListViewItem(new[] { item, cProd, xProd, NCM, qCom, vUnCom.ToString(), vProd.ToString().Replace(".", ","), CFOP }));
                                }
                            }

                                //Rodape
                                if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vNF")
                                {
                                    lblValortotalnf.Text = "R$" + meuXml.ReadElementContentAsString().Replace(".", ",");
                                    lblValortotalnf.BackColor = Color.Yellow;
                                }

                                if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xMotivo")
                                {
                                    textMotivoNf.Text = meuXml.ReadElementContentAsString();
                                    if (textMotivoNf.Text == "Autorizado o uso da NF-e")
                                    {
                                        textMotivoNf.BackColor = Color.Green;
                                        textMotivoNf.ForeColor = Color.White;
                                    }
                                    else
                                    {
                                        textMotivoNf.BackColor = Color.Red;
                                    }

                                }
                            }
                        }
                    }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de leitura: " + ex.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void limpar()
        {
            if (textNaturezaOperacao.Text == string.Empty)
            {
                MessageBox.Show("Não há nada para ser limpo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblEmp.Clear();
                txtCnpj.Clear();
                lblNF.Clear();
                lblDataemissao.Clear();
                listView1.Items.Clear();
                lblValortotalnf.Clear();
                textMotivoNf.Clear();
                textNaturezaOperacao.Clear();
                textMotivoNf.BackColor = default;
                lblValortotalnf.BackColor = default;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
    }

