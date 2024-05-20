namespace CALCULADORA2
{
    partial class Form1
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
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.numero_1 = new System.Windows.Forms.TextBox();
            this.numero_2 = new System.Windows.Forms.TextBox();
            this.label_respuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(259, 28);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(130, 79);
            this.sumar.TabIndex = 0;
            this.sumar.Text = "Sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // restar
            // 
            this.restar.Location = new System.Drawing.Point(259, 113);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(130, 79);
            this.restar.TabIndex = 1;
            this.restar.Text = "Restar";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(259, 198);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(130, 79);
            this.multiplicar.TabIndex = 2;
            this.multiplicar.Text = "Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(259, 283);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(130, 79);
            this.dividir.TabIndex = 3;
            this.dividir.Text = "Dividir";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // numero_1
            // 
            this.numero_1.Location = new System.Drawing.Point(52, 56);
            this.numero_1.Name = "numero_1";
            this.numero_1.Size = new System.Drawing.Size(100, 22);
            this.numero_1.TabIndex = 4;
            // 
            // numero_2
            // 
            this.numero_2.Location = new System.Drawing.Point(52, 141);
            this.numero_2.Name = "numero_2";
            this.numero_2.Size = new System.Drawing.Size(100, 22);
            this.numero_2.TabIndex = 5;
            // 
            // label_respuesta
            // 
            this.label_respuesta.AutoSize = true;
            this.label_respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_respuesta.Location = new System.Drawing.Point(42, 280);
            this.label_respuesta.Name = "label_respuesta";
            this.label_respuesta.Padding = new System.Windows.Forms.Padding(5);
            this.label_respuesta.Size = new System.Drawing.Size(64, 68);
            this.label_respuesta.TabIndex = 6;
            this.label_respuesta.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 473);
            this.Controls.Add(this.label_respuesta);
            this.Controls.Add(this.numero_2);
            this.Controls.Add(this.numero_1);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.TextBox numero_1;
        private System.Windows.Forms.TextBox numero_2;
        private System.Windows.Forms.Label label_respuesta;
    }
}

