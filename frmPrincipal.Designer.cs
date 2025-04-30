namespace Fase4NombreApellido
{
    partial class frmPrincipal
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.pnlPreorden = new System.Windows.Forms.Panel();
            this.pnlInorden = new System.Windows.Forms.Panel();
            this.pnlPostorden = new System.Windows.Forms.Panel();
            this.pnlArbol = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Chocolate;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(289, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 43);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Nodo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Chocolate;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(453, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 43);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Info;
            this.txtValor.Location = new System.Drawing.Point(127, 31);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 2;
            // 
            // pnlPreorden
            // 
            this.pnlPreorden.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pnlPreorden.Location = new System.Drawing.Point(438, 455);
            this.pnlPreorden.Name = "pnlPreorden";
            this.pnlPreorden.Size = new System.Drawing.Size(375, 38);
            this.pnlPreorden.TabIndex = 3;
            // 
            // pnlInorden
            // 
            this.pnlInorden.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlInorden.Location = new System.Drawing.Point(12, 455);
            this.pnlInorden.Name = "pnlInorden";
            this.pnlInorden.Size = new System.Drawing.Size(375, 38);
            this.pnlInorden.TabIndex = 4;
            // 
            // pnlPostorden
            // 
            this.pnlPostorden.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pnlPostorden.Location = new System.Drawing.Point(12, 546);
            this.pnlPostorden.Name = "pnlPostorden";
            this.pnlPostorden.Size = new System.Drawing.Size(375, 41);
            this.pnlPostorden.TabIndex = 4;
            // 
            // pnlArbol
            // 
            this.pnlArbol.BackColor = System.Drawing.Color.Beige;
            this.pnlArbol.Location = new System.Drawing.Point(31, 79);
            this.pnlArbol.Name = "pnlArbol";
            this.pnlArbol.Size = new System.Drawing.Size(831, 338);
            this.pnlArbol.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "pre-orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "In-orden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "post-orden";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalir.ForeColor = System.Drawing.Color.Brown;
            this.btnSalir.Location = new System.Drawing.Point(813, 561);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 41);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor numerico";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(910, 614);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlArbol);
            this.Controls.Add(this.pnlPostorden);
            this.Controls.Add(this.pnlInorden);
            this.Controls.Add(this.pnlPreorden);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Panel pnlPreorden;
        private System.Windows.Forms.Panel pnlInorden;
        private System.Windows.Forms.Panel pnlPostorden;
        private System.Windows.Forms.Panel pnlArbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
    }
}