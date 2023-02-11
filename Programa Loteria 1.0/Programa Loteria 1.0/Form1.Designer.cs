namespace Programa_Loteria_1._0
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
            this.btnJuega = new System.Windows.Forms.Button();
            this.txtPrimera = new System.Windows.Forms.TextBox();
            this.txtSegunda = new System.Windows.Forms.TextBox();
            this.txtTercera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJuega
            // 
            this.btnJuega.BackColor = System.Drawing.Color.Lime;
            this.btnJuega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuega.Location = new System.Drawing.Point(303, 188);
            this.btnJuega.Name = "btnJuega";
            this.btnJuega.Size = new System.Drawing.Size(157, 66);
            this.btnJuega.TabIndex = 0;
            this.btnJuega.Text = "JUEGA";
            this.btnJuega.UseVisualStyleBackColor = false;
            this.btnJuega.Click += new System.EventHandler(this.btnJuega_Click);
            // 
            // txtPrimera
            // 
            this.txtPrimera.BackColor = System.Drawing.Color.MistyRose;
            this.txtPrimera.Location = new System.Drawing.Point(142, 113);
            this.txtPrimera.Multiline = true;
            this.txtPrimera.Name = "txtPrimera";
            this.txtPrimera.Size = new System.Drawing.Size(100, 40);
            this.txtPrimera.TabIndex = 1;
            // 
            // txtSegunda
            // 
            this.txtSegunda.BackColor = System.Drawing.Color.MediumOrchid;
            this.txtSegunda.Location = new System.Drawing.Point(335, 112);
            this.txtSegunda.Multiline = true;
            this.txtSegunda.Name = "txtSegunda";
            this.txtSegunda.Size = new System.Drawing.Size(103, 39);
            this.txtSegunda.TabIndex = 2;
            // 
            // txtTercera
            // 
            this.txtTercera.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtTercera.Location = new System.Drawing.Point(525, 112);
            this.txtTercera.Multiline = true;
            this.txtTercera.Name = "txtTercera";
            this.txtTercera.Size = new System.Drawing.Size(105, 41);
            this.txtTercera.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRIMERA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "SEGUNDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(511, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "TERCERA";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.Silver;
            this.txtNumero.Location = new System.Drawing.Point(340, 24);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 26);
            this.txtNumero.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Location = new System.Drawing.Point(177, 287);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(407, 61);
            this.lblResultado.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTercera);
            this.Controls.Add(this.txtSegunda);
            this.Controls.Add(this.txtPrimera);
            this.Controls.Add(this.btnJuega);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJuega;
        private System.Windows.Forms.TextBox txtPrimera;
        private System.Windows.Forms.TextBox txtSegunda;
        private System.Windows.Forms.TextBox txtTercera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblResultado;
    }
}

