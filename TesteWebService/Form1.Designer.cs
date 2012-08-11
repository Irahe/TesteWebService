namespace TesteWebService
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGo2 = new System.Windows.Forms.Button();
            this.btnFasta = new System.Windows.Forms.Button();
            this.btnGenBank = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQerry = new System.Windows.Forms.TextBox();
            this.btnFastaQerry = new System.Windows.Forms.Button();
            this.btnGBQuerry = new System.Windows.Forms.Button();
            this.txtRegEncontrados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGoPost = new System.Windows.Forms.Button();
            this.btnGoPost2 = new System.Windows.Forms.Button();
            this.btnGetHIV = new System.Windows.Forms.Button();
            this.btnFomr2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 16);
            this.txtResult.MaxLength = 999999999;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(265, 315);
            this.txtResult.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(329, 87);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(108, 38);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 315);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGo2
            // 
            this.btnGo2.Location = new System.Drawing.Point(468, 87);
            this.btnGo2.Name = "btnGo2";
            this.btnGo2.Size = new System.Drawing.Size(108, 38);
            this.btnGo2.TabIndex = 3;
            this.btnGo2.Text = "Go2";
            this.btnGo2.UseVisualStyleBackColor = true;
            this.btnGo2.Click += new System.EventHandler(this.btnGo2_Click);
            // 
            // btnFasta
            // 
            this.btnFasta.Location = new System.Drawing.Point(468, 146);
            this.btnFasta.Name = "btnFasta";
            this.btnFasta.Size = new System.Drawing.Size(108, 37);
            this.btnFasta.TabIndex = 4;
            this.btnFasta.Text = "Pega FASTA do ID";
            this.btnFasta.UseVisualStyleBackColor = true;
            this.btnFasta.Click += new System.EventHandler(this.btnFasta_Click);
            // 
            // btnGenBank
            // 
            this.btnGenBank.Location = new System.Drawing.Point(468, 189);
            this.btnGenBank.Name = "btnGenBank";
            this.btnGenBank.Size = new System.Drawing.Size(108, 37);
            this.btnGenBank.TabIndex = 5;
            this.btnGenBank.Text = "Pega GenBank do ID";
            this.btnGenBank.UseVisualStyleBackColor = true;
            this.btnGenBank.Click += new System.EventHandler(this.btnGenBank_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(319, 174);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 20);
            this.txtId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID`s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Querry Text";
            // 
            // txtQerry
            // 
            this.txtQerry.Location = new System.Drawing.Point(598, 174);
            this.txtQerry.Name = "txtQerry";
            this.txtQerry.Size = new System.Drawing.Size(129, 20);
            this.txtQerry.TabIndex = 9;
            // 
            // btnFastaQerry
            // 
            this.btnFastaQerry.Location = new System.Drawing.Point(744, 144);
            this.btnFastaQerry.Name = "btnFastaQerry";
            this.btnFastaQerry.Size = new System.Drawing.Size(108, 37);
            this.btnFastaQerry.TabIndex = 10;
            this.btnFastaQerry.Text = "Pega FASTA da Querry";
            this.btnFastaQerry.UseVisualStyleBackColor = true;
            this.btnFastaQerry.Click += new System.EventHandler(this.btnFastaQerry_Click);
            // 
            // btnGBQuerry
            // 
            this.btnGBQuerry.Location = new System.Drawing.Point(744, 187);
            this.btnGBQuerry.Name = "btnGBQuerry";
            this.btnGBQuerry.Size = new System.Drawing.Size(108, 37);
            this.btnGBQuerry.TabIndex = 11;
            this.btnGBQuerry.Text = "Pega GebBank da Querry";
            this.btnGBQuerry.UseVisualStyleBackColor = true;
            // 
            // txtRegEncontrados
            // 
            this.txtRegEncontrados.Location = new System.Drawing.Point(110, 456);
            this.txtRegEncontrados.Name = "txtRegEncontrados";
            this.txtRegEncontrados.Size = new System.Drawing.Size(111, 20);
            this.txtRegEncontrados.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Registros Encontrados";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(415, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(300, 248);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(596, 298);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // btnGoPost
            // 
            this.btnGoPost.Location = new System.Drawing.Point(643, 34);
            this.btnGoPost.Name = "btnGoPost";
            this.btnGoPost.Size = new System.Drawing.Size(75, 23);
            this.btnGoPost.TabIndex = 16;
            this.btnGoPost.Text = "Go POST";
            this.btnGoPost.UseVisualStyleBackColor = true;
            this.btnGoPost.Click += new System.EventHandler(this.btnGoPost_Click);
            // 
            // btnGoPost2
            // 
            this.btnGoPost2.Location = new System.Drawing.Point(643, 73);
            this.btnGoPost2.Name = "btnGoPost2";
            this.btnGoPost2.Size = new System.Drawing.Size(75, 23);
            this.btnGoPost2.TabIndex = 17;
            this.btnGoPost2.Text = "Go POST 2!";
            this.btnGoPost2.UseVisualStyleBackColor = true;
            this.btnGoPost2.Click += new System.EventHandler(this.btnGoPost2_Click);
            // 
            // btnGetHIV
            // 
            this.btnGetHIV.Location = new System.Drawing.Point(744, 34);
            this.btnGetHIV.Name = "btnGetHIV";
            this.btnGetHIV.Size = new System.Drawing.Size(75, 23);
            this.btnGetHIV.TabIndex = 18;
            this.btnGetHIV.Text = "Get HIV";
            this.btnGetHIV.UseVisualStyleBackColor = true;
            this.btnGetHIV.Click += new System.EventHandler(this.btnGetHIV_Click);
            // 
            // btnFomr2
            // 
            this.btnFomr2.Location = new System.Drawing.Point(319, 33);
            this.btnFomr2.Name = "btnFomr2";
            this.btnFomr2.Size = new System.Drawing.Size(75, 23);
            this.btnFomr2.TabIndex = 19;
            this.btnFomr2.Text = "Form2";
            this.btnFomr2.UseVisualStyleBackColor = true;
            this.btnFomr2.Click += new System.EventHandler(this.btnFomr2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 558);
            this.Controls.Add(this.btnFomr2);
            this.Controls.Add(this.btnGetHIV);
            this.Controls.Add(this.btnGoPost2);
            this.Controls.Add(this.btnGoPost);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegEncontrados);
            this.Controls.Add(this.btnGBQuerry);
            this.Controls.Add(this.btnFastaQerry);
            this.Controls.Add(this.txtQerry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnGenBank);
            this.Controls.Add(this.btnFasta);
            this.Controls.Add(this.btnGo2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGo2;
        private System.Windows.Forms.Button btnFasta;
        private System.Windows.Forms.Button btnGenBank;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQerry;
        private System.Windows.Forms.Button btnFastaQerry;
        private System.Windows.Forms.Button btnGBQuerry;
        private System.Windows.Forms.TextBox txtRegEncontrados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnGoPost;
        private System.Windows.Forms.Button btnGoPost2;
        private System.Windows.Forms.Button btnGetHIV;
        private System.Windows.Forms.Button btnFomr2;
    }
}

