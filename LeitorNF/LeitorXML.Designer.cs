
namespace LeitorNF
{
    partial class LeitorXML
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDataemissao = new System.Windows.Forms.TextBox();
            this.textNaturezaOperacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Item = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.descricao = new System.Windows.Forms.ColumnHeader();
            this.Ncm = new System.Windows.Forms.ColumnHeader();
            this.qtde = new System.Windows.Forms.ColumnHeader();
            this.unitario = new System.Windows.Forms.ColumnHeader();
            this.valor = new System.Windows.Forms.ColumnHeader();
            this.cfopHeader = new System.Windows.Forms.ColumnHeader();
            this.btnLerXml = new System.Windows.Forms.Button();
            this.lblValortotalnf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textMotivoNf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1248, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leitor de XML da NFe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº da NFe:";
            // 
            // lblNF
            // 
            this.lblNF.BackColor = System.Drawing.SystemColors.Control;
            this.lblNF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNF.Location = new System.Drawing.Point(98, 191);
            this.lblNF.Name = "lblNF";
            this.lblNF.Size = new System.Drawing.Size(80, 27);
            this.lblNF.TabIndex = 2;
            this.lblNF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(813, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data da emissão:";
            // 
            // lblDataemissao
            // 
            this.lblDataemissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataemissao.BackColor = System.Drawing.SystemColors.Control;
            this.lblDataemissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDataemissao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataemissao.Location = new System.Drawing.Point(953, 124);
            this.lblDataemissao.Name = "lblDataemissao";
            this.lblDataemissao.ReadOnly = true;
            this.lblDataemissao.Size = new System.Drawing.Size(273, 27);
            this.lblDataemissao.TabIndex = 4;
            this.lblDataemissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNaturezaOperacao
            // 
            this.textNaturezaOperacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNaturezaOperacao.BackColor = System.Drawing.SystemColors.Control;
            this.textNaturezaOperacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNaturezaOperacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textNaturezaOperacao.Location = new System.Drawing.Point(391, 191);
            this.textNaturezaOperacao.Name = "textNaturezaOperacao";
            this.textNaturezaOperacao.ReadOnly = true;
            this.textNaturezaOperacao.Size = new System.Drawing.Size(602, 27);
            this.textNaturezaOperacao.TabIndex = 6;
            this.textNaturezaOperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(195, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Natureza da operação:";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.id,
            this.descricao,
            this.Ncm,
            this.qtde,
            this.unitario,
            this.valor,
            this.cfopHeader});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 235);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1214, 322);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // descricao
            // 
            this.descricao.Text = "Descrição do produto";
            this.descricao.Width = 339;
            // 
            // Ncm
            // 
            this.Ncm.Text = "NCM";
            this.Ncm.Width = 150;
            // 
            // qtde
            // 
            this.qtde.Text = "Quantidade";
            this.qtde.Width = 150;
            // 
            // unitario
            // 
            this.unitario.Text = "Unitário";
            this.unitario.Width = 150;
            // 
            // valor
            // 
            this.valor.Text = "Valor";
            this.valor.Width = 150;
            // 
            // cfopHeader
            // 
            this.cfopHeader.Text = "CFOP";
            this.cfopHeader.Width = 135;
            // 
            // btnLerXml
            // 
            this.btnLerXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLerXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLerXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLerXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLerXml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLerXml.Location = new System.Drawing.Point(1059, 178);
            this.btnLerXml.Name = "btnLerXml";
            this.btnLerXml.Size = new System.Drawing.Size(167, 50);
            this.btnLerXml.TabIndex = 8;
            this.btnLerXml.Text = "LerXML";
            this.btnLerXml.UseVisualStyleBackColor = false;
            this.btnLerXml.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblValortotalnf
            // 
            this.lblValortotalnf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValortotalnf.BackColor = System.Drawing.SystemColors.Control;
            this.lblValortotalnf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValortotalnf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValortotalnf.ForeColor = System.Drawing.Color.Red;
            this.lblValortotalnf.Location = new System.Drawing.Point(1088, 573);
            this.lblValortotalnf.Name = "lblValortotalnf";
            this.lblValortotalnf.Size = new System.Drawing.Size(138, 27);
            this.lblValortotalnf.TabIndex = 10;
            this.lblValortotalnf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(953, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor total NFe:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblEmp
            // 
            this.lblEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmp.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmp.Location = new System.Drawing.Point(91, 123);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.ReadOnly = true;
            this.lblEmp.Size = new System.Drawing.Size(441, 27);
            this.lblEmp.TabIndex = 12;
            this.lblEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a.Location = new System.Drawing.Point(12, 126);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(73, 20);
            this.a.TabIndex = 11;
            this.a.Text = "Empresa:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1059, 637);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Paulo Vinícius Rodrigues";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(546, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "CNPJ:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCnpj.BackColor = System.Drawing.SystemColors.Control;
            this.txtCnpj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCnpj.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtCnpj.Location = new System.Drawing.Point(596, 123);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.ReadOnly = true;
            this.txtCnpj.Size = new System.Drawing.Size(202, 27);
            this.txtCnpj.TabIndex = 16;
            this.txtCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMotivoNf
            // 
            this.textMotivoNf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textMotivoNf.BackColor = System.Drawing.SystemColors.Control;
            this.textMotivoNf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMotivoNf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textMotivoNf.ForeColor = System.Drawing.Color.Red;
            this.textMotivoNf.Location = new System.Drawing.Point(742, 574);
            this.textMotivoNf.Name = "textMotivoNf";
            this.textMotivoNf.Size = new System.Drawing.Size(205, 27);
            this.textMotivoNf.TabIndex = 18;
            this.textMotivoNf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(657, 574);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Situação:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(11, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Limpar Leitura";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(12, 637);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(167, 20);
            this.lblHora.TabIndex = 20;
            this.lblHora.Text = "Paulo Vinícius Rodrigues";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LeitorXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 666);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textMotivoNf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.a);
            this.Controls.Add(this.lblValortotalnf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLerXml);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textNaturezaOperacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDataemissao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LeitorXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeitorXML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblNF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblDataemissao;
        private System.Windows.Forms.TextBox textNaturezaOperacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader qtde;
        private System.Windows.Forms.ColumnHeader unitario;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.Button btnLerXml;
        private System.Windows.Forms.TextBox lblValortotalnf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Ncm;
        private System.Windows.Forms.TextBox lblEmp;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader cfopHeader;
        private System.Windows.Forms.TextBox textMotivoNf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}

