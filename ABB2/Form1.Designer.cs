namespace ABB2
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
      this.btnInsertar = new System.Windows.Forms.Button();
      this.textNumero = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.textPost = new System.Windows.Forms.TextBox();
      this.btnPostorden = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnInsertar
      // 
      this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsertar.Location = new System.Drawing.Point(327, 85);
      this.btnInsertar.Name = "btnInsertar";
      this.btnInsertar.Size = new System.Drawing.Size(112, 34);
      this.btnInsertar.TabIndex = 15;
      this.btnInsertar.Text = "Insertar";
      this.btnInsertar.UseVisualStyleBackColor = true;
      this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
      // 
      // textNumero
      // 
      this.textNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textNumero.Location = new System.Drawing.Point(198, 87);
      this.textNumero.Name = "textNumero";
      this.textNumero.Size = new System.Drawing.Size(111, 26);
      this.textNumero.TabIndex = 14;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(54, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(125, 20);
      this.label2.TabIndex = 13;
      this.label2.Text = "Ingrese número:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(28, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(483, 33);
      this.label1.TabIndex = 12;
      this.label1.Text = "ÁRBOL BINARIO DE BUSQUEDA";
      // 
      // btnBuscar
      // 
      this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBuscar.Location = new System.Drawing.Point(58, 157);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(112, 34);
      this.btnBuscar.TabIndex = 16;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // btnEliminar
      // 
      this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminar.Location = new System.Drawing.Point(58, 214);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(112, 34);
      this.btnEliminar.TabIndex = 17;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      // 
      // treeView1
      // 
      this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.treeView1.Location = new System.Drawing.Point(198, 141);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(241, 270);
      this.treeView1.TabIndex = 18;
      // 
      // textPost
      // 
      this.textPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textPost.Location = new System.Drawing.Point(176, 435);
      this.textPost.Name = "textPost";
      this.textPost.Size = new System.Drawing.Size(263, 26);
      this.textPost.TabIndex = 19;
      // 
      // btnPostorden
      // 
      this.btnPostorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPostorden.Location = new System.Drawing.Point(46, 431);
      this.btnPostorden.Name = "btnPostorden";
      this.btnPostorden.Size = new System.Drawing.Size(112, 34);
      this.btnPostorden.TabIndex = 20;
      this.btnPostorden.Text = "Postorden";
      this.btnPostorden.UseVisualStyleBackColor = true;
      this.btnPostorden.Click += new System.EventHandler(this.btnPostorden_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(562, 500);
      this.Controls.Add(this.btnPostorden);
      this.Controls.Add(this.textPost);
      this.Controls.Add(this.treeView1);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnBuscar);
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

    private System.Windows.Forms.Button btnInsertar;
    private System.Windows.Forms.TextBox textNumero;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.TextBox textPost;
    private System.Windows.Forms.Button btnPostorden;
  }
}

