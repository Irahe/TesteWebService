namespace TesteWebService
{
    partial class Form2
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
            this.txtIdRef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrganismName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RtxtResult = new System.Windows.Forms.RichTextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtQntReg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdRef
            // 
            this.txtIdRef.Location = new System.Drawing.Point(13, 59);
            this.txtIdRef.Name = "txtIdRef";
            this.txtIdRef.Size = new System.Drawing.Size(194, 20);
            this.txtIdRef.TabIndex = 0;
            this.txtIdRef.Leave += new System.EventHandler(this.txtIdRef_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id de Referência";
            // 
            // txtOrganismName
            // 
            this.txtOrganismName.Enabled = false;
            this.txtOrganismName.Location = new System.Drawing.Point(298, 59);
            this.txtOrganismName.Name = "txtOrganismName";
            this.txtOrganismName.Size = new System.Drawing.Size(394, 20);
            this.txtOrganismName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Organism Name";
            // 
            // RtxtResult
            // 
            this.RtxtResult.Location = new System.Drawing.Point(12, 95);
            this.RtxtResult.Name = "RtxtResult";
            this.RtxtResult.Size = new System.Drawing.Size(775, 241);
            this.RtxtResult.TabIndex = 4;
            this.RtxtResult.Text = "";
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(698, 32);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(89, 47);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Baixar Registros";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtQntReg
            // 
            this.txtQntReg.Enabled = false;
            this.txtQntReg.Location = new System.Drawing.Point(590, 32);
            this.txtQntReg.Name = "txtQntReg";
            this.txtQntReg.Size = new System.Drawing.Size(100, 20);
            this.txtQntReg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Registros Encontrados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQntReg);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.RtxtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrganismName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdRef);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrganismName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RtxtResult;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtQntReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}