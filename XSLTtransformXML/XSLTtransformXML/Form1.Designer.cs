namespace XSLTtransformXML
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
            this.rtboxXSLT = new System.Windows.Forms.RichTextBox();
            this.rtboxXML = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidarXSLT = new System.Windows.Forms.Button();
            this.rtxtResultado = new System.Windows.Forms.RichTextBox();
            this.btnValidarXML = new System.Windows.Forms.Button();
            this.btnTransformar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.llblXMLEjemplo = new System.Windows.Forms.LinkLabel();
            this.llblXSLTEjemplo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // rtboxXSLT
            // 
            this.rtboxXSLT.Location = new System.Drawing.Point(12, 211);
            this.rtboxXSLT.Name = "rtboxXSLT";
            this.rtboxXSLT.Size = new System.Drawing.Size(850, 163);
            this.rtboxXSLT.TabIndex = 0;
            this.rtboxXSLT.Text = "";
            // 
            // rtboxXML
            // 
            this.rtboxXML.Location = new System.Drawing.Point(12, 21);
            this.rtboxXML.Name = "rtboxXML";
            this.rtboxXML.Size = new System.Drawing.Size(850, 171);
            this.rtboxXML.TabIndex = 1;
            this.rtboxXML.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "XML";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "XSLT";
            // 
            // btnValidarXSLT
            // 
            this.btnValidarXSLT.Location = new System.Drawing.Point(624, 385);
            this.btnValidarXSLT.Name = "btnValidarXSLT";
            this.btnValidarXSLT.Size = new System.Drawing.Size(108, 23);
            this.btnValidarXSLT.TabIndex = 4;
            this.btnValidarXSLT.Text = "Validar XSLT";
            this.btnValidarXSLT.UseVisualStyleBackColor = true;
            this.btnValidarXSLT.Click += new System.EventHandler(this.btnValidarXSLT_Click);
            // 
            // rtxtResultado
            // 
            this.rtxtResultado.Location = new System.Drawing.Point(15, 423);
            this.rtxtResultado.Name = "rtxtResultado";
            this.rtxtResultado.Size = new System.Drawing.Size(850, 216);
            this.rtxtResultado.TabIndex = 5;
            this.rtxtResultado.Text = "";
            // 
            // btnValidarXML
            // 
            this.btnValidarXML.Location = new System.Drawing.Point(183, 385);
            this.btnValidarXML.Name = "btnValidarXML";
            this.btnValidarXML.Size = new System.Drawing.Size(116, 24);
            this.btnValidarXML.TabIndex = 6;
            this.btnValidarXML.Text = "Validar XML";
            this.btnValidarXML.UseVisualStyleBackColor = true;
            this.btnValidarXML.Click += new System.EventHandler(this.btnValidarXML_Click);
            // 
            // btnTransformar
            // 
            this.btnTransformar.Location = new System.Drawing.Point(406, 380);
            this.btnTransformar.Name = "btnTransformar";
            this.btnTransformar.Size = new System.Drawing.Size(122, 33);
            this.btnTransformar.TabIndex = 7;
            this.btnTransformar.Text = "Transformar";
            this.btnTransformar.UseVisualStyleBackColor = true;
            this.btnTransformar.Click += new System.EventHandler(this.btnTransformar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Version 0.0.1";
            // 
            // llblXMLEjemplo
            // 
            this.llblXMLEjemplo.AutoSize = true;
            this.llblXMLEjemplo.Location = new System.Drawing.Point(793, 5);
            this.llblXMLEjemplo.Name = "llblXMLEjemplo";
            this.llblXMLEjemplo.Size = new System.Drawing.Size(69, 13);
            this.llblXMLEjemplo.TabIndex = 9;
            this.llblXMLEjemplo.TabStop = true;
            this.llblXMLEjemplo.Text = "XML Ejemplo";
            this.llblXMLEjemplo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblXMLEjemplo_LinkClicked);
            // 
            // llblXSLTEjemplo
            // 
            this.llblXSLTEjemplo.AutoSize = true;
            this.llblXSLTEjemplo.Location = new System.Drawing.Point(788, 195);
            this.llblXSLTEjemplo.Name = "llblXSLTEjemplo";
            this.llblXSLTEjemplo.Size = new System.Drawing.Size(74, 13);
            this.llblXSLTEjemplo.TabIndex = 10;
            this.llblXSLTEjemplo.TabStop = true;
            this.llblXSLTEjemplo.Text = "XSLT Ejemplo";
            this.llblXSLTEjemplo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblXSLTEjemplo_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 651);
            this.Controls.Add(this.llblXSLTEjemplo);
            this.Controls.Add(this.llblXMLEjemplo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTransformar);
            this.Controls.Add(this.btnValidarXML);
            this.Controls.Add(this.rtxtResultado);
            this.Controls.Add(this.btnValidarXSLT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtboxXML);
            this.Controls.Add(this.rtboxXSLT);
            this.Name = "Form1";
            this.Text = "Transformar XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtboxXSLT;
        private System.Windows.Forms.RichTextBox rtboxXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValidarXSLT;
        private System.Windows.Forms.RichTextBox rtxtResultado;
        private System.Windows.Forms.Button btnValidarXML;
        private System.Windows.Forms.Button btnTransformar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llblXMLEjemplo;
        private System.Windows.Forms.LinkLabel llblXSLTEjemplo;
    }
}

