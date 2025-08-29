namespace Lista_enlazada_simple
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textNumero = new System.Windows.Forms.TextBox();
      this.btnInsertar = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.btnOrdenarA = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(51, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(389, 33);
      this.label1.TabIndex = 0;
      this.label1.Text = "LISTA ENLAZADA SIMPLE";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(35, 75);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(125, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Ingrese número:";
      // 
      // textNumero
      // 
      this.textNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textNumero.Location = new System.Drawing.Point(179, 78);
      this.textNumero.Name = "textNumero";
      this.textNumero.Size = new System.Drawing.Size(246, 26);
      this.textNumero.TabIndex = 2;
      // 
      // btnInsertar
      // 
      this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsertar.Location = new System.Drawing.Point(48, 134);
      this.btnInsertar.Name = "btnInsertar";
      this.btnInsertar.Size = new System.Drawing.Size(112, 34);
      this.btnInsertar.TabIndex = 3;
      this.btnInsertar.Text = "Insertar";
      this.btnInsertar.UseVisualStyleBackColor = true;
      this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
      // 
      // btnEliminar
      // 
      this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminar.Location = new System.Drawing.Point(48, 174);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(112, 34);
      this.btnEliminar.TabIndex = 4;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(192, 135);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(233, 284);
      this.listBox1.TabIndex = 5;
      // 
      // btnBuscar
      // 
      this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBuscar.Location = new System.Drawing.Point(48, 214);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(112, 34);
      this.btnBuscar.TabIndex = 6;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // btnOrdenarA
      // 
      this.btnOrdenarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOrdenarA.Location = new System.Drawing.Point(48, 254);
      this.btnOrdenarA.Name = "btnOrdenarA";
      this.btnOrdenarA.Size = new System.Drawing.Size(112, 34);
      this.btnOrdenarA.TabIndex = 7;
      this.btnOrdenarA.Text = "Ordenar A";
      this.btnOrdenarA.UseVisualStyleBackColor = true;
      this.btnOrdenarA.Click += new System.EventHandler(this.btnOrdenarA_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(502, 450);
      this.Controls.Add(this.btnOrdenarA);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnInsertar);
      this.Controls.Add(this.textNumero);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.Button btnOrdenarA;
  }
}

