﻿namespace FractalKoch
{
    partial class FractalKoch
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonAumentar = new System.Windows.Forms.Button();
            this.botonDisminuir = new System.Windows.Forms.Button();
            this.numeroLados = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeroLados)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAumentar
            // 
            this.botonAumentar.Location = new System.Drawing.Point(12, 12);
            this.botonAumentar.Name = "botonAumentar";
            this.botonAumentar.Size = new System.Drawing.Size(143, 36);
            this.botonAumentar.TabIndex = 0;
            this.botonAumentar.Text = "Nivel ++";
            this.botonAumentar.UseVisualStyleBackColor = true;
            this.botonAumentar.Click += new System.EventHandler(this.botonAumentar_Click);
            // 
            // botonDisminuir
            // 
            this.botonDisminuir.Location = new System.Drawing.Point(161, 12);
            this.botonDisminuir.Name = "botonDisminuir";
            this.botonDisminuir.Size = new System.Drawing.Size(143, 36);
            this.botonDisminuir.TabIndex = 1;
            this.botonDisminuir.Text = "Nivel --";
            this.botonDisminuir.UseVisualStyleBackColor = true;
            this.botonDisminuir.Click += new System.EventHandler(this.botonDisminuir_Click);
            // 
            // numeroLados
            // 
            this.numeroLados.Location = new System.Drawing.Point(418, 22);
            this.numeroLados.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numeroLados.Name = "numeroLados";
            this.numeroLados.Size = new System.Drawing.Size(39, 20);
            this.numeroLados.TabIndex = 2;
            this.numeroLados.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numeroLados.ValueChanged += new System.EventHandler(this.numeroLados_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lados";
            // 
            // FractalKoch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeroLados);
            this.Controls.Add(this.botonDisminuir);
            this.Controls.Add(this.botonAumentar);
            this.Name = "FractalKoch";
            this.Text = "Fractal Koch";
            ((System.ComponentModel.ISupportInitialize)(this.numeroLados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAumentar;
        private System.Windows.Forms.Button botonDisminuir;
        private System.Windows.Forms.NumericUpDown numeroLados;
        private System.Windows.Forms.Label label1;
    }
}

