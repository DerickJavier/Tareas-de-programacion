namespace Ejercicio_14._1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ltsFrutas = new System.Windows.Forms.ListBox();
            this.textFruta = new System.Windows.Forms.TextBox();
            this.btnAdiccionar = new System.Windows.Forms.Button();
            this.lblFruta = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ltsFrutas
            // 
            this.ltsFrutas.FormattingEnabled = true;
            this.ltsFrutas.ItemHeight = 20;
            this.ltsFrutas.Items.AddRange(new object[] {
            "Manzana ",
            "Aguacate",
            "Pera"});
            this.ltsFrutas.Location = new System.Drawing.Point(213, 191);
            this.ltsFrutas.Name = "ltsFrutas";
            this.ltsFrutas.Size = new System.Drawing.Size(232, 124);
            this.ltsFrutas.TabIndex = 1;
            this.ltsFrutas.SelectedIndexChanged += new System.EventHandler(this.ltsFrutas_SelectedIndexChanged);
            // 
            // textFruta
            // 
            this.textFruta.Location = new System.Drawing.Point(213, 27);
            this.textFruta.Multiline = true;
            this.textFruta.Name = "textFruta";
            this.textFruta.Size = new System.Drawing.Size(124, 36);
            this.textFruta.TabIndex = 2;
            // 
            // btnAdiccionar
            // 
            this.btnAdiccionar.Location = new System.Drawing.Point(383, 27);
            this.btnAdiccionar.Name = "btnAdiccionar";
            this.btnAdiccionar.Size = new System.Drawing.Size(105, 46);
            this.btnAdiccionar.TabIndex = 3;
            this.btnAdiccionar.Text = "Adiccionar";
            this.btnAdiccionar.UseVisualStyleBackColor = true;
            this.btnAdiccionar.Click += new System.EventHandler(this.btnAdiccionar_Click);
            // 
            // lblFruta
            // 
            this.lblFruta.AutoSize = true;
            this.lblFruta.Location = new System.Drawing.Point(209, 122);
            this.lblFruta.Name = "lblFruta";
            this.lblFruta.Size = new System.Drawing.Size(51, 20);
            this.lblFruta.TabIndex = 4;
            this.lblFruta.Text = "label1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(383, 102);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 40);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblFruta);
            this.Controls.Add(this.btnAdiccionar);
            this.Controls.Add(this.textFruta);
            this.Controls.Add(this.ltsFrutas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox ltsFrutas;
        private System.Windows.Forms.TextBox textFruta;
        private System.Windows.Forms.Button btnAdiccionar;
        private System.Windows.Forms.Label lblFruta;
        private System.Windows.Forms.Button btnEliminar;
    }
}

