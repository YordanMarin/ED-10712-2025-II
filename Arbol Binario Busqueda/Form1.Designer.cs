﻿namespace Arbol_Binario_Busqueda
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
      this.button1 = new System.Windows.Forms.Button();
      this.textPre = new System.Windows.Forms.TextBox();
      this.textIn = new System.Windows.Forms.TextBox();
      this.textPost = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnInsertar
      // 
      this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsertar.Location = new System.Drawing.Point(301, 69);
      this.btnInsertar.Name = "btnInsertar";
      this.btnInsertar.Size = new System.Drawing.Size(112, 34);
      this.btnInsertar.TabIndex = 11;
      this.btnInsertar.Text = "Insertar";
      this.btnInsertar.UseVisualStyleBackColor = true;
      this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
      // 
      // textNumero
      // 
      this.textNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textNumero.Location = new System.Drawing.Point(172, 71);
      this.textNumero.Name = "textNumero";
      this.textNumero.Size = new System.Drawing.Size(111, 26);
      this.textNumero.TabIndex = 10;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(28, 74);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(125, 20);
      this.label2.TabIndex = 9;
      this.label2.Text = "Ingrese número:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(26, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(483, 33);
      this.label1.TabIndex = 8;
      this.label1.Text = "ÁRBOL BINARIO DE BUSQUEDA";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(32, 154);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(112, 34);
      this.button1.TabIndex = 12;
      this.button1.Text = "Recorrido";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // textPre
      // 
      this.textPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textPre.Location = new System.Drawing.Point(150, 202);
      this.textPre.Name = "textPre";
      this.textPre.Size = new System.Drawing.Size(263, 26);
      this.textPre.TabIndex = 13;
      // 
      // textIn
      // 
      this.textIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textIn.Location = new System.Drawing.Point(150, 234);
      this.textIn.Name = "textIn";
      this.textIn.Size = new System.Drawing.Size(263, 26);
      this.textIn.TabIndex = 14;
      // 
      // textPost
      // 
      this.textPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textPost.Location = new System.Drawing.Point(150, 266);
      this.textPost.Name = "textPost";
      this.textPost.Size = new System.Drawing.Size(263, 26);
      this.textPost.TabIndex = 15;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(50, 202);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(78, 20);
      this.label3.TabIndex = 16;
      this.label3.Text = "Preorden:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(50, 237);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(68, 20);
      this.label4.TabIndex = 17;
      this.label4.Text = "Inorden:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(50, 269);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(86, 20);
      this.label5.TabIndex = 18;
      this.label5.Text = "Postorden:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(566, 321);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textPost);
      this.Controls.Add(this.textIn);
      this.Controls.Add(this.textPre);
      this.Controls.Add(this.button1);
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
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textPre;
    private System.Windows.Forms.TextBox textIn;
    private System.Windows.Forms.TextBox textPost;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
  }
}

