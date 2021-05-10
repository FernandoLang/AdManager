
namespace AdManager.Controlls
{
    partial class Relatory
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblMaxvisualization = new System.Windows.Forms.Label();
            this.lblVisualizationshared = new System.Windows.Forms.Label();
            this.maxClicks = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alcance Máximo de visualizações (sem compartilhamento) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade Máxima de Cliques :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor investido por dia :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alcance de visualizações com compartilhamento :";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(407, 28);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(41, 15);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "value1";
            // 
            // lblMaxvisualization
            // 
            this.lblMaxvisualization.AutoSize = true;
            this.lblMaxvisualization.Location = new System.Drawing.Point(407, 64);
            this.lblMaxvisualization.Name = "lblMaxvisualization";
            this.lblMaxvisualization.Size = new System.Drawing.Size(41, 15);
            this.lblMaxvisualization.TabIndex = 6;
            this.lblMaxvisualization.Text = "value2";
            // 
            // lblVisualizationshared
            // 
            this.lblVisualizationshared.AutoSize = true;
            this.lblVisualizationshared.Location = new System.Drawing.Point(407, 100);
            this.lblVisualizationshared.Name = "lblVisualizationshared";
            this.lblVisualizationshared.Size = new System.Drawing.Size(41, 15);
            this.lblVisualizationshared.TabIndex = 7;
            this.lblVisualizationshared.Text = "value3";
            // 
            // maxClicks
            // 
            this.maxClicks.AutoSize = true;
            this.maxClicks.Location = new System.Drawing.Point(407, 138);
            this.maxClicks.Name = "maxClicks";
            this.maxClicks.Size = new System.Drawing.Size(41, 15);
            this.maxClicks.TabIndex = 8;
            this.maxClicks.Text = "value4";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(506, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Relatory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 204);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maxClicks);
            this.Controls.Add(this.lblVisualizationshared);
            this.Controls.Add(this.lblMaxvisualization);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relatory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblMaxvisualization;
        private System.Windows.Forms.Label lblVisualizationshared;
        private System.Windows.Forms.Label maxClicks;
        private System.Windows.Forms.Button button1;
    }
}