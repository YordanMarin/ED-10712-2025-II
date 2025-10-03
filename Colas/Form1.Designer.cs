namespace Colas
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
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.btnLimpiar = new System.Windows.Forms.Button();
      this.btnCantidad = new System.Windows.Forms.Button();
      this.btnViztaso = new System.Windows.Forms.Button();
      this.btnDesencolar = new System.Windows.Forms.Button();
      this.btnEncolar = new System.Windows.Forms.Button();
      this.textNombre = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(183, 144);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(204, 244);
      this.listBox1.TabIndex = 29;
      // 
      // btnLimpiar
      // 
      this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLimpiar.Location = new System.Drawing.Point(44, 347);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new System.Drawing.Size(112, 34);
      this.btnLimpiar.TabIndex = 28;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
      // 
      // btnCantidad
      // 
      this.btnCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCantidad.Location = new System.Drawing.Point(44, 301);
      this.btnCantidad.Name = "btnCantidad";
      this.btnCantidad.Size = new System.Drawing.Size(112, 34);
      this.btnCantidad.TabIndex = 27;
      this.btnCantidad.Text = "Cantidad";
      this.btnCantidad.UseVisualStyleBackColor = true;
      this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
      // 
      // btnViztaso
      // 
      this.btnViztaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnViztaso.Location = new System.Drawing.Point(44, 252);
      this.btnViztaso.Name = "btnViztaso";
      this.btnViztaso.Size = new System.Drawing.Size(112, 34);
      this.btnViztaso.TabIndex = 26;
      this.btnViztaso.Text = "Vistazo";
      this.btnViztaso.UseVisualStyleBackColor = true;
      this.btnViztaso.Click += new System.EventHandler(this.btnViztaso_Click);
      // 
      // btnDesencolar
      // 
      this.btnDesencolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDesencolar.Location = new System.Drawing.Point(44, 205);
      this.btnDesencolar.Name = "btnDesencolar";
      this.btnDesencolar.Size = new System.Drawing.Size(112, 34);
      this.btnDesencolar.TabIndex = 25;
      this.btnDesencolar.Text = "Desencolar";
      this.btnDesencolar.UseVisualStyleBackColor = true;
      this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
      // 
      // btnEncolar
      // 
      this.btnEncolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEncolar.Location = new System.Drawing.Point(44, 158);
      this.btnEncolar.Name = "btnEncolar";
      this.btnEncolar.Size = new System.Drawing.Size(112, 34);
      this.btnEncolar.TabIndex = 24;
      this.btnEncolar.Text = "Encolar";
      this.btnEncolar.UseVisualStyleBackColor = true;
      this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
      // 
      // textNombre
      // 
      this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textNombre.Location = new System.Drawing.Point(106, 93);
      this.textNombre.Name = "textNombre";
      this.textNombre.Size = new System.Drawing.Size(281, 26);
      this.textNombre.TabIndex = 23;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(31, 99);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 20);
      this.label2.TabIndex = 22;
      this.label2.Text = "Nombre:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(67, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(337, 33);
      this.label1.TabIndex = 21;
      this.label1.Text = "COLA - QUEUE (FIFO)";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(439, 443);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.btnCantidad);
      this.Controls.Add(this.btnViztaso);
      this.Controls.Add(this.btnDesencolar);
      this.Controls.Add(this.btnEncolar);
      this.Controls.Add(this.textNombre);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.Button btnCantidad;
    private System.Windows.Forms.Button btnViztaso;
    private System.Windows.Forms.Button btnDesencolar;
    private System.Windows.Forms.Button btnEncolar;
    private System.Windows.Forms.TextBox textNombre;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}

