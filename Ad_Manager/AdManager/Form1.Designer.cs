
namespace AdManager
{
    partial class Form1
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
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tabControll = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearFilters = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.datafinal = new System.Windows.Forms.DateTimePicker();
            this.apartir = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.CboxClients = new System.Windows.Forms.ComboBox();
            this.adsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ClickCof = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfigRestore = new System.Windows.Forms.Button();
            this.ShareCof = new System.Windows.Forms.NumericUpDown();
            this.RangeCof = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControll.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClickCof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShareCof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeCof)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(173, 169);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(260, 23);
            this.dateEnd.TabIndex = 0;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(173, 116);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(260, 23);
            this.dateStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Título do anúncio :";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(173, 65);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(260, 23);
            this.txtClient.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(358, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(173, 18);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(260, 23);
            this.txtTitle.TabIndex = 7;
            // 
            // tabControll
            // 
            this.tabControll.Controls.Add(this.tabPage1);
            this.tabControll.Controls.Add(this.tabPage2);
            this.tabControll.Controls.Add(this.tabPage3);
            this.tabControll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControll.Location = new System.Drawing.Point(0, 0);
            this.tabControll.Name = "tabControll";
            this.tabControll.SelectedIndex = 0;
            this.tabControll.Size = new System.Drawing.Size(467, 355);
            this.tabControll.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.tabPage1.Controls.Add(this.txtValue);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtTitle);
            this.tabPage1.Controls.Add(this.dateEnd);
            this.tabPage1.Controls.Add(this.dateStart);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtClient);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(239)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar Anuncio";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(307, 220);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(126, 23);
            this.txtValue.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Investimento por dia :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data de Termino :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(52, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data de início :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(98, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.tabPage2.Controls.Add(this.clearFilters);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.datafinal);
            this.tabPage2.Controls.Add(this.apartir);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.CboxClients);
            this.tabPage2.Controls.Add(this.adsPanel);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(239)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Anuncios";
            // 
            // clearFilters
            // 
            this.clearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFilters.Location = new System.Drawing.Point(376, 302);
            this.clearFilters.Name = "clearFilters";
            this.clearFilters.Size = new System.Drawing.Size(75, 23);
            this.clearFilters.TabIndex = 6;
            this.clearFilters.Text = "Limpar Filtros";
            this.clearFilters.UseVisualStyleBackColor = true;
            this.clearFilters.Click += new System.EventHandler(this.clearFilters_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(104, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "até";
            // 
            // datafinal
            // 
            this.datafinal.Location = new System.Drawing.Point(133, 5);
            this.datafinal.Name = "datafinal";
            this.datafinal.Size = new System.Drawing.Size(89, 23);
            this.datafinal.TabIndex = 4;
            this.datafinal.ValueChanged += new System.EventHandler(this.datafinal_ValueChanged);
            // 
            // apartir
            // 
            this.apartir.Location = new System.Drawing.Point(8, 5);
            this.apartir.Name = "apartir";
            this.apartir.Size = new System.Drawing.Size(90, 23);
            this.apartir.TabIndex = 3;
            this.apartir.ValueChanged += new System.EventHandler(this.apartir_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cliente :";
            // 
            // CboxClients
            // 
            this.CboxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxClients.FormattingEnabled = true;
            this.CboxClients.Location = new System.Drawing.Point(291, 5);
            this.CboxClients.Name = "CboxClients";
            this.CboxClients.Size = new System.Drawing.Size(130, 23);
            this.CboxClients.TabIndex = 1;
            this.CboxClients.SelectedIndexChanged += new System.EventHandler(this.CboxClients_SelectedIndexChanged);
            // 
            // adsPanel
            // 
            this.adsPanel.AutoScroll = true;
            this.adsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.adsPanel.Location = new System.Drawing.Point(3, 32);
            this.adsPanel.Name = "adsPanel";
            this.adsPanel.Size = new System.Drawing.Size(448, 269);
            this.adsPanel.TabIndex = 0;
            this.adsPanel.WrapContents = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.ClickCof);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnConfigRestore);
            this.tabPage3.Controls.Add(this.ShareCof);
            this.tabPage3.Controls.Add(this.RangeCof);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(239)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(459, 327);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Configurações";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = " 1 Clique a cada ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Pessoas";
            // 
            // ClickCof
            // 
            this.ClickCof.Location = new System.Drawing.Point(215, 218);
            this.ClickCof.Name = "ClickCof";
            this.ClickCof.Size = new System.Drawing.Size(45, 23);
            this.ClickCof.TabIndex = 9;
            this.ClickCof.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Coeficiente de cliques por Quantidade de pessoa ";
            // 
            // btnConfigRestore
            // 
            this.btnConfigRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigRestore.Location = new System.Drawing.Point(337, 296);
            this.btnConfigRestore.Name = "btnConfigRestore";
            this.btnConfigRestore.Size = new System.Drawing.Size(114, 23);
            this.btnConfigRestore.TabIndex = 7;
            this.btnConfigRestore.Text = "Restaurar Padrões";
            this.btnConfigRestore.UseVisualStyleBackColor = true;
            this.btnConfigRestore.Click += new System.EventHandler(this.btnConfigRestore_Click);
            // 
            // ShareCof
            // 
            this.ShareCof.Location = new System.Drawing.Point(216, 139);
            this.ShareCof.Name = "ShareCof";
            this.ShareCof.Size = new System.Drawing.Size(45, 23);
            this.ShareCof.TabIndex = 5;
            this.ShareCof.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // RangeCof
            // 
            this.RangeCof.Location = new System.Drawing.Point(216, 56);
            this.RangeCof.Name = "RangeCof";
            this.RangeCof.Size = new System.Drawing.Size(45, 23);
            this.RangeCof.TabIndex = 4;
            this.RangeCof.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Coeficiente de compartilhamento máximo em sequência";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Coeficiente pessoas ( alcance de pessoas por 1 R$ investido)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(467, 355);
            this.Controls.Add(this.tabControll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControll.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClickCof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShareCof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeCof)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TabControl tabControll;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.FlowLayoutPanel adsPanel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnConfigRestore;
        private System.Windows.Forms.NumericUpDown ShareCof;
        private System.Windows.Forms.NumericUpDown RangeCof;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown ClickCof;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datafinal;
        private System.Windows.Forms.DateTimePicker apartir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CboxClients;
        private System.Windows.Forms.Button clearFilters;
    }
}

