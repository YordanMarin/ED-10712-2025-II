namespace ABB3
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
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.btnMinimo = new System.Windows.Forms.Button();
      this.btnInsertar = new System.Windows.Forms.Button();
      this.textNumero = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnMaximo = new System.Windows.Forms.Button();
      this.btnSumaHojas = new System.Windows.Forms.Button();
      this.btnBalanceo = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // treeView1
      // 
      this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.treeView1.Location = new System.Drawing.Point(201, 135);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(241, 270);
      this.treeView1.TabIndex = 24;
      // 
      // btnMinimo
      // 
      this.btnMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMinimo.Location = new System.Drawing.Point(61, 151);
      this.btnMinimo.Name = "btnMinimo";
      this.btnMinimo.Size = new System.Drawing.Size(112, 34);
      this.btnMinimo.TabIndex = 23;
      this.btnMinimo.Text = "Mínimo";
      this.btnMinimo.UseVisualStyleBackColor = true;
      this.btnMinimo.Click += new System.EventHandler(this.btnMinimo_Click);
      // 
      // btnInsertar
      // 
      this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsertar.Location = new System.Drawing.Point(330, 79);
      this.btnInsertar.Name = "btnInsertar";
      this.btnInsertar.Size = new System.Drawing.Size(112, 34);
      this.btnInsertar.TabIndex = 22;
      this.btnInsertar.Text = "Insertar";
      this.btnInsertar.UseVisualStyleBackColor = true;
      this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
      // 
      // textNumero
      // 
      this.textNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textNumero.Location = new System.Drawing.Point(201, 81);
      this.textNumero.Name = "textNumero";
      this.textNumero.Size = new System.Drawing.Size(111, 26);
      this.textNumero.TabIndex = 21;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(57, 84);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(125, 20);
      this.label2.TabIndex = 20;
      this.label2.Text = "Ingrese número:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(31, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(483, 33);
      this.label1.TabIndex = 19;
      this.label1.Text = "ÁRBOL BINARIO DE BUSQUEDA";
      // 
      // btnMaximo
      // 
      this.btnMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMaximo.Location = new System.Drawing.Point(61, 200);
      this.btnMaximo.Name = "btnMaximo";
      this.btnMaximo.Size = new System.Drawing.Size(112, 34);
      this.btnMaximo.TabIndex = 25;
      this.btnMaximo.Text = "Máximo";
      this.btnMaximo.UseVisualStyleBackColor = true;
      this.btnMaximo.Click += new System.EventHandler(this.btnMaximo_Click);
      // 
      // btnSumaHojas
      // 
      this.btnSumaHojas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSumaHojas.Location = new System.Drawing.Point(61, 253);
      this.btnSumaHojas.Name = "btnSumaHojas";
      this.btnSumaHojas.Size = new System.Drawing.Size(112, 34);
      this.btnSumaHojas.TabIndex = 26;
      this.btnSumaHojas.Text = "Suma hojas";
      this.btnSumaHojas.UseVisualStyleBackColor = true;
      this.btnSumaHojas.Click += new System.EventHandler(this.btnSumaHojas_Click);
      // 
      // btnBalanceo
      // 
      this.btnBalanceo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBalanceo.Location = new System.Drawing.Point(61, 309);
      this.btnBalanceo.Name = "btnBalanceo";
      this.btnBalanceo.Size = new System.Drawing.Size(112, 34);
      this.btnBalanceo.TabIndex = 27;
      this.btnBalanceo.Text = "Balanceo";
      this.btnBalanceo.UseVisualStyleBackColor = true;
      this.btnBalanceo.Click += new System.EventHandler(this.btnBalanceo_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(540, 450);
      this.Controls.Add(this.btnBalanceo);
      this.Controls.Add(this.btnSumaHojas);
      this.Controls.Add(this.btnMaximo);
      this.Controls.Add(this.treeView1);
      this.Controls.Add(this.btnMinimo);
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

    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.Button btnMinimo;
    private System.Windows.Forms.Button btnInsertar;
    private System.Windows.Forms.TextBox textNumero;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnMaximo;
    private System.Windows.Forms.Button btnSumaHojas;
    private System.Windows.Forms.Button btnBalanceo;
  }
}

