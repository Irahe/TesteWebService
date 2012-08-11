using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace TesteWebService
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
          
        private void txtIdRef_Leave(object sender, EventArgs e)
        {
            if (txtIdRef.Text != "")
            {
                String url = "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/efetch.fcgi?db=nuccore&id=";
                url = url + txtIdRef.Text;
                url = url + "&rettype=gb&retmode=xml";
                String resultado = "";
                WebClient wc = new WebClient();
                resultado = wc.DownloadString(url);

                
                if (resultado != "")
                {
                    String[] aux = Regex.Split(resultado, "<GBSeq_organism>");
                    String[] aux2 = Regex.Split(aux[1], "</GBSeq_organism>");
                    String organism = aux2[0];
                    txtOrganismName.Text = organism;
                    String url2 = "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/esearch.fcgi?db=nuccore&term=";
                    url2 = url2 += organism.Replace(" ", "+");
                    url2 = url2 += "&rettype=count";
                    WebClient wc2 = new WebClient();
                    String resultado2 = wc.DownloadString(url2);
                    String[] aux3 = Regex.Split(resultado2, "<Count>");
                    String[] aux4 = Regex.Split(aux3[1], "</Count>");
                    String qnt = aux4[0];
                    txtQntReg.Text = qnt;
                    btnDownload.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Nenhum Registro encontrado!");
                    this.clear();
                }
                
            }
        }

        public void clear()
        {
            txtIdRef.Text = "";
            txtOrganismName.Text = "";
            txtQntReg.Text = "";
            btnDownload.Enabled = false;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            String termo = txtOrganismName.Text;

        }
    }
}
