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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // O utilitário eInfo retorna uma lista dos bancos de dados disponíveis
            try
            {
                eUtils.eUtilsServiceSoapClient serv = new eUtils.eUtilsServiceSoapClient();
                // chama o NCBI EInfo utility
                eUtils.eInfoResult res = serv.run_eInfo(new eUtils.eInfoRequest());
                // results output
                this.txtResult.Text = "";
                for (int i = 0; i < res.DbList.Items.Length; i++)
                {
                    txtResult.Text += res.DbList.Items[i] + "\r\n";
                }
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.ToString();
            }
        }

        private void btnGo2_Click(object sender, EventArgs e)
        {
            // example retrieves links from Nuccore for to Protein GI 48819,7140345
            try
            {
                eUtils.eUtilsServiceSoapClient serv = new eUtils.eUtilsServiceSoapClient();
                string[] id = { "48819,7140345" };
                // call NCBI ELink utility
                eUtils.eLinkRequest req = new eUtils.eLinkRequest();
                req.db = "protein";
                req.id = id;
                req.dbfrom = "nuccore";
                eUtils.eLinkResult res = serv.run_eLink(req);
                // results output
                textBox1.Text = "";
                for (int i = 0; i < res.LinkSet.Length; i++)
                {
                    textBox1.Text += "Links from " + res.LinkSet[i].DbFrom +
                                     " to " + res.LinkSet[i].LinkSetDb[0].DbTo + "\r\n";
                    textBox1.Text += "  " + res.LinkSet[i].DbFrom + " id(s): ";
                    for (int k = 0; k < res.LinkSet[i].IdList.Length; k++)
                    {
                        textBox1.Text += res.LinkSet[i].IdList[k].Value + " ";
                    }
                    textBox1.Text += "\r\n";
                    textBox1.Text += "  " + res.LinkSet[i].LinkSetDb[0].DbTo + " id(s): ";
                    for (int k = 0; k < res.LinkSet[i].LinkSetDb[0].Link.Length; k++)
                    {
                        textBox1.Text += res.LinkSet[i].LinkSetDb[0].Link[k].Id.Value + " ";
                    }
                    textBox1.Text += "\r\n----------------------\r\n";
                }
            }
            catch (Exception eee)
            {
                textBox1.Text = eee.ToString();
            }   
        }

        private void btnFasta_Click(object sender, EventArgs e)
        {
            // STEP #3: fetch records from nuccore
            //
            try
            {
                eFetchSeq.eUtilsServiceSoapClient serv = new eFetchSeq.eUtilsServiceSoapClient();
                // call NCBI ESpell utility
                eFetchSeq.eFetchRequest req = new eFetchSeq.eFetchRequest();
                req.db = "nuccore";
                req.id = this.txtId.Text;
                eFetchSeq.eFetchResult res = serv.run_eFetch(req);
                
                // results output
                List<string> fasta = gBankToFasta(res.GBSet.GBSeq);

                for (int i = 0; i < fasta.Count; i++)
                {
                    textBox1.Text += fasta[i];
                    textBox1.Text += "----------------------\r\n\r\n";
                }
                
             /*   for (int i = 0; i < res.GBSet.GBSeq.Length; i++)
                {
                    
                    textBox1.Text += "Organism: " + res.GBSet.GBSeq[i].GBSeq_organism + "\r\n";
                    textBox1.Text += "Locus: " + res.GBSet.GBSeq[i].GBSeq_locus + "\r\n";
                    textBox1.Text += "Definition: " + res.GBSet.GBSeq[i].GBSeq_definition + "\r\n";
                    textBox1.Text += "Sequence: " + res.GBSet.GBSeq[i].GBSeq_sequence + " \r\n"; 
                    textBox1.Text += "----------------------\r\n\r\n";
                }
                */ 
               
              
            }
            catch (Exception eee)
            {
                textBox1.Text += eee.ToString();
            }
        }

        public List<string> gBankToFasta(eFetchSeq.GBSeq[] GBsequence){

            List<string> fasta = new List<string>();
            for (int i = 0; i < GBsequence.Length; i++)
                {
                    fasta.Add ( ">" + GBsequence[i].GBSeq_otherseqids.GBSeqid[1] + "|" + GBsequence[i].GBSeq_otherseqids.GBSeqid[0] + 
                        GBsequence[i].GBSeq_definition + "\r\n" + GBsequence[i].GBSeq_sequence + "|<");

                  
                    
                }
            return fasta;
             
        
        }

        private void btnGenBank_Click(object sender, EventArgs e)
        {
            // STEP #3: fetch records from nuccore
            //
            try
            {
                eFetchSeq.eUtilsServiceSoapClient serv = new eFetchSeq.eUtilsServiceSoapClient();
                // call NCBI ESpell utility
                eFetchSeq.eFetchRequest req = new eFetchSeq.eFetchRequest();
                req.db = "nuccore";
                req.id = this.txtId.Text;

                eFetchSeq.eFetchResult res = serv.run_eFetch(req);

                // results output
               
               

                   for (int i = 0; i < res.GBSet.GBSeq.Length; i++)
                   {
                    
                       textBox1.Text += "Organism: " + res.GBSet.GBSeq[i].GBSeq_organism + "\r\n";
                       textBox1.Text += "Locus: " + res.GBSet.GBSeq[i].GBSeq_locus + "\r\n";
                       textBox1.Text += "Definition: " + res.GBSet.GBSeq[i].GBSeq_definition + "\r\n";
                       textBox1.Text += "Sequence: " + res.GBSet.GBSeq[i].GBSeq_sequence + " \r\n"; 
                       textBox1.Text += "----------------------\r\n\r\n";
                   }
                   


            }
            catch (Exception eee)
            {
                textBox1.Text = eee.ToString();
                
            }
        }
        public String buscaSequencia(String ids)
        {
            String dados = "";
            try
            {
                eFetchSeq.eUtilsServiceSoapClient serv = new eFetchSeq.eUtilsServiceSoapClient();
                // call NCBI ESpell utility
                eFetchSeq.eFetchRequest req = new eFetchSeq.eFetchRequest();
                req.db = "nuccore";
                req.id = ids;
                eFetchSeq.eFetchResult res = serv.run_eFetch(req);
               MessageBox.Show(Convert.ToString(res.GBSet.GBSeq.Length) + " Sequencias encontradas");
                // results output
                List<string> fasta = gBankToFasta(res.GBSet.GBSeq);
                StringBuilder builder2 = new StringBuilder();
                

                for (int i = 0; i < fasta.Count; i++)
                {
                    builder2.Append(fasta[i]);
                    builder2.Append("----------------------\r\n\r\n");
                }
                dados = builder2.ToString();
                return dados;

                /*   for (int i = 0; i < res.GBSet.GBSeq.Length; i++)
                   {
                    
                       textBox1.Text += "Organism: " + res.GBSet.GBSeq[i].GBSeq_organism + "\r\n";
                       textBox1.Text += "Locus: " + res.GBSet.GBSeq[i].GBSeq_locus + "\r\n";
                       textBox1.Text += "Definition: " + res.GBSet.GBSeq[i].GBSeq_definition + "\r\n";
                       textBox1.Text += "Sequence: " + res.GBSet.GBSeq[i].GBSeq_sequence + " \r\n"; 
                       textBox1.Text += "----------------------\r\n\r\n";
                   }
                   */


            }
            catch (Exception eee)
            {
                
                dados = eee.ToString();
                return dados;
            }
        }

        private void btnFastaQerry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string result = bustaTextual(txtQerry.Text);
            richTextBox1.Text = result;
           
    
        }

        public string bustaTextual(String termo)
        {
            StringBuilder builder = new StringBuilder();
            StringBuilder builderFinal = new StringBuilder();
            string retorno = "";
            try
            {
                eUtils.eUtilsServiceSoapClient serv = new eUtils.eUtilsServiceSoapClient();
                // call NCBI ESearch utility
                // NOTE: search term should be URL encoded
                String inicio = "0";
                Boolean teste = true;
                int qnt = 0;
                int qntfound = 0;
                
                
                do{
                     eUtils.eSearchRequest req = new eUtils.eSearchRequest();
                     req.db = "nuccore";
                     req.term = termo.Replace(" " ,"+");
                     req.RetStart = inicio;
                     req.RetMax = "100000";
                     eUtils.eSearchResult res = serv.run_eSearch(req);
                     qntfound = Convert.ToInt32(res.Count);
                     qnt = qnt + res.IdList.Length;
                     if (qnt == qntfound)
                     {
                         builder.Clear();
                         int cont = 0;
                         for (int x = 0; x < res.IdList.Length; x++)
                         {
                             if (cont == 500)
                             {
                                 
                                 builderFinal.Append(getStringPost(createURL(builder.ToString(), "nuccore")));
                                 richTextBox1.Text += builderFinal.ToString();
                                 
                                 builderFinal.Clear();
                                 builder.Clear();
                                 cont = 0;
                             }
                             else
                             {
                                 builder.Append(res.IdList[x] + ",");
                                 cont++;
                             }
                                 
                         }
                         
                         
                         teste = false;
                     }
                     else
                     {
                         builder.Clear();
                         int cont = 0;
                         for (int x = 0; x < res.IdList.Length; x++)
                         {
                             
                             if (cont == 500)
                             {
                                 
                                     builderFinal.Append(getStringPost(createURL(builder.ToString(), "nuccore")));
                                     richTextBox1.Text += builderFinal.ToString();
                                   
                                 
                                 builderFinal.Clear();
                                 builder.Clear();
                                 cont = 0;
                             }
                             else
                             {
                                 builder.Append(res.IdList[x] + ",");
                                 cont++;
                             }
                                 
                         }
                             
                            
                         }
                    
                         inicio = Convert.ToString(Convert.ToInt32(inicio) + 100000);
                     
                     
                }while(teste);

                MessageBox.Show(Convert.ToString(qntfound) + " Id`s Encontrados e armazanados em Buffer... \n Clique em OK para MOstrar as sequências");
                

                
                    
                 retorno = builderFinal.ToString();
                 return retorno;
            }
            catch (Exception eee)
            {
                textBox1.Text = eee.ToString();
                return retorno;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtRegEncontrados.Text = "";
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGoPost_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = HttpPost("http://eutils.ncbi.nlm.nih.gov/entrez/eutils/efetch.fcgi?db=nuccore&id=399226659,399226655,351721800,399788585,399226657,394953907,354681989,341572594,334884738,334884734,334884730,334884726,334884722,334884718,334884714,334884710,334884706,334884702,334884698,334884694,334884690,334884686,334884682,334884678,334884674,334884670,334884666,334884662,334884658,334884654,334884650,334884646,334884642,334884638,334884634,334884630,334884626,334884622,334884618,334884614,334884610,334884606,334884602,334884598,334884594,334884590,334884586,334884582,334884578,334884574,334884570,334884566,334884562,334884558,334884554,334884550,324505056,324504987,324504209,324500834,317155728,297206762,215272318,157426897,334884736,334884732,334884728,334884724,334884720,334884716,334884712,334884708,334884704,334884700,334884696,334884692,334884688,334884684,334884680,334884676,334884672,334884668,334884664,334884660,334884656,334884652,334884648,334884644,334884640,334884636,334884632,334884628,334884624,334884620,334884616,334884612,334884608,334884604,334884600,334884596,334884592,334884588,334884584,334884580,334884576,334884572,334884568,334884564,334884560,334884556,334884552,334884548,324715044,315075318,289063392,283046695,241666390,222418644,215272320,215272316,215272314,161760677,151101190,134142827,90704850,62952497,56788375,53759152,117968550,47132584,31083295,24430148,353523784,332025764,353523786,353523782,353411949,198444071,198444067,198444063,198444059,198444055,198444051,198444047,198444043,198444039,198444035,198444031,198444027,198444023,198444019,198444015,198444011,198444007,198444003,198443999,198443995,198443991,198443987,198443983,198443979,198443975,198443971,198443967,198443963,198443959,198443955,198443951,198443947,289577106,198444069,198444065,198444061,198444057,198444053,198444049,198444045,198444041,198444037,198444033,198444029,198444025,198444021,198444017,198444013,198444009,198444005,198444001,198443997,198443993,198443989,198443985,198443981,198443977,198443973,198443969,198443965,198443961,198443957,198443953,198443949,59624978,21617520,59624980,47132511,21630179,19110788,15216618,15216590,15192521,14573524,14573508,12831750,11493768,7532826,6907001,6856100,6856042,6855986,6855974,6855962,6855948,6739788,6694575,6694505,6693885,6691038,6690982,6690958,6690826,6318494,6274307,6273957,5932488,5929973,5734159,5730412,5669484,5669356,5639855,5532744,5532658,5524564,5524554,5524550,5478736,5478703,5478689,5478390,5360055,5360047,5360023,5225271,5225255,5138903,5106491,4868310,4754218,4754206,4754190,4580312,4580128,4580037,4530388,4337455,4205610,4205606,4205600,4205368,4205258,4205226,4205202,4204670,4204666,4204662,4204658,4204628,4204624,4204620,4204616,4204612,4204608,4204438,4165829,4165779,4154482,4101950,4101904,4101762,4091942,4049945,4049930,4020059,4019979,4019963,4019913,4019898,4019893,4019608,4019457,3930130,3930120,3925189,3925175,3925015,3924981,3916687,3916681,3916377,3916355,3916287,3901395,3892432,3892426,3892422,3892350,3832523,3832496,3832452,3832278,3832192,3832152,3832086,3832032,3832020,3832016,3832000,3831892,3831872,3659777,3642812,3599285,3599120,3599008,3598927,3598911,3598907,3549539,3549517,3549481,3549427,3549372,3549344,3513588,3462623,3462386,3452453,3452238,3406300,3406246,3406242,3406120,3406108,3406096,3327523,3211957,3211866,3211850,3152778,3152766,3091128,3091092,3091086,3091044,3090976,3065478,3065344,3065310,3065286,3065282,3065278,3065274,3065190,3065182,3065160,3065152,3065132,3065052,3065040,3065036,3065032,3065027,3064850,3064812,3064541,3025425,2992583,2970730,2970716,2967867,2895207,2853475,2853465,2738300,2641492,2641440,2641428,2641394,2588148,2585719,2585697,2585521,2585467,2585365,2585135,2584961,2584899,2522153,2415433,2415429,2407129,2407007,2406901,2406873,2406829,2406745,2393835,2338653,2258399,2251231,2190914,2190892,2190794,2190770,2190751,2190735,2145261,2109045,2109019,2109007,2109003,2108991,2108985,2108969,2108963,2108957,2108949,2108945,2108939,2108935,2108931,2108927,2108881,2108877,2108827,2108689,2108673,2105020,1946915,1946867,1935668,1935564,1935560,1935556,1935550,1935544,1935538,1935454,1935178,1935088,1845666,1750038,1749980,1749870,1747662,1747598,1747568,1667409,1177207,18418721,15216602,15192534,15128163,14585778,13898735,13898731,12659225,8117807,7595328,7108968,6959551,6907023,6855988,6855984,6855980,6855968,6739761,6694581,6694449,6694125,6694113,6693987,6693871,6691032,6690882,6690812,6636274,6469530,6318444,6274357,&rettype=fasta&retmode=text");
        }

        public string HttpPost(string uri)
        { 
          
           WebRequest webRequest = WebRequest.Create (uri);
       
        webRequest.ContentType = "application/x-www-form-urlencoded";
        webRequest.Method = WebRequestMethods.Http.Post;
        StringBuilder urlEncoded = new StringBuilder();
        byte[] bytes = Encoding.ASCII.GetBytes ("");
        Stream os = null;
   try
   { // send the Post
      webRequest.ContentLength = bytes.Length;   //Count bytes to send
      os = webRequest.GetRequestStream();
      os.Write (bytes, 0, bytes.Length);         //Send it
   }
   catch (WebException ex)
   {
      MessageBox.Show( ex.Message, "HttpPost: Request error", 
         MessageBoxButtons.OK, MessageBoxIcon.Error );
   }
   finally
   {
      if (os != null)
      {
         os.Close();
      }
   }
 
   try
   { // get the response
      WebResponse webResponse = webRequest.GetResponse();
      if (webResponse == null) 
         { return null; }
       
    StreamReader sr = new StreamReader (webResponse.GetResponseStream());
     
    // Byte[] bdata = ReadToEndByte(webResponse.GetResponseStream());
     String dados = sr.ReadToEnd();
    return dados;
   }
   catch (WebException ex)
   {
      MessageBox.Show( ex.Message, "HttpPost: Response error", 
         MessageBoxButtons.OK, MessageBoxIcon.Error );
   }
   return null;
} // end HttpPost 
        public static byte[] ReadToEndByte(System.IO.Stream stream)
        {
            long originalPosition = 0;

            if (stream.CanSeek)
            {
                originalPosition = stream.Position;
                stream.Position = 0;
            }

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length * 2];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = originalPosition;
                }
            }
        }
       public string createURL(String ids, String db)
       {
           StringBuilder builder = new StringBuilder();
           builder.Append("http://eutils.ncbi.nlm.nih.gov/entrez/eutils/efetch.fcgi?db=");
           builder.Append(db);
           builder.Append("&id=");
           builder.Append(ids);
           builder.Append("&rettype=fasta&retmode=text");
           return builder.ToString();
       }

       private void btnGoPost2_Click(object sender, EventArgs e)
       {
           WebClient wc = new WebClient();
           String aux = wc.DownloadString("http://eutils.ncbi.nlm.nih.gov/entrez/eutils/esearch.fcgi?db=nuccore&term=HIV&retmax=1&usehistory=y");
           textBox1.Text = aux;
           String[] webenv = Regex.Split(aux, "<WebEnv>");
           String[] webenv2 = Regex.Split(webenv[1], "</WebEnv>");
           String result = webenv2[0];
           String[] qk = Regex.Split(aux, "<QueryKey>");
           String[] qk2 = Regex.Split(qk[1], "</QueryKey>");
           string result2 = qk2[0];
           String link = "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/efetch.fcgi?db=nuccore&query_key=";
                 link = link += result2;
                 link = link += "&WebEnv=";
              link = link += result;
               link = link += "&rettype=fasta&retmode=text";
               link = link.Trim();
           richTextBox1.Text = wc.DownloadString(link);
            
       }

       public string getStringPost(String url)
       {
           WebClient wc = new WebClient();
           System.Uri andress = new Uri(url);
           return wc.DownloadString(andress);
           
       }

       private void btnGetHIV_Click(object sender, EventArgs e)
       {
           WebClient wc = new WebClient();

           richTextBox1.Text = wc.DownloadString("http://eutils.ncbi.nlm.nih.gov/entrez/eutils/esearch.fcgi?db=nuccore&term=HIV&retmax=10&usehistory=y");
       }

       private void btnFomr2_Click(object sender, EventArgs e)
       {
           Form2 form = new Form2();
           form.Show();
       }




    }
}
