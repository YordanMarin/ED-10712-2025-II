﻿namespace Lista_enlazada_doble
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
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnInsertar = new System.Windows.Forms.Button();
      this.textNumero = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(189, 131);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(233, 284);
      this.listBox1.TabIndex = 17;
      // 
      // btnEliminar
      // 
      this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminar.Location = new System.Drawing.Point(45, 170);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(112, 34);
      this.btnEliminar.TabIndex = 16;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      // 
      // btnInsertar
      // 
      this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsertar.Location = new System.Drawing.Point(45, 130);
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
      this.textNumero.Location = new System.Drawing.Point(176, 74);
      this.textNumero.Name = "textNumero";
      this.textNumero.Size = new System.Drawing.Size(246, 26);
      this.textNumero.TabIndex = 14;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(32, 71);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(125, 20);
      this.label2.TabIndex = 13;
      this.label2.Text = "Ingrese número:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(61, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(381, 33);
      this.label1.TabIndex = 12;
      this.label1.Text = "LISTA ENLAZADA DOBLE";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(503, 475);
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

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnInsertar;
    private System.Windows.Forms.TextBox textNumero;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}

