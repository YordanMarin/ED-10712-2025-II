using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABB3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    Arbol a = new Arbol();
    Nodo raiz;
    private void btnInsertar_Click(object sender, EventArgs e)
    {
      if (int.TryParse(textNumero.Text, out int num) && num > 0)
      {
        if (raiz == null) raiz = a.insertar(null, num);
        else a.insertar(raiz, num);

        treeView1.Nodes.Clear();
        a.mostrar(raiz,treeView1, null);
        treeView1.ExpandAll();
        textNumero.Clear();
      }
      else MessageBox.Show("Ingrese números validos positivos");
    }

    private void btnMinimo_Click(object sender, EventArgs e)
    {
      if (raiz != null) MessageBox.Show("Minimo: " + a.minimo(raiz));
      else MessageBox.Show("Árbol vacio.");
    }

    private void btnMaximo_Click(object sender, EventArgs e)
    {
      if (raiz != null) MessageBox.Show("Máximo: " + a.maximo(raiz));
      else MessageBox.Show("Árbol vacio.");
    }

    private void btnSumaHojas_Click(object sender, EventArgs e)
    {
      if (raiz != null) MessageBox.Show("Suma hojas: " + a.SumaHojas(raiz));
      else MessageBox.Show("Árbol vacio.");
    }

    private void btnBalanceo_Click(object sender, EventArgs e)
    {
      if (raiz != null)
      {
        if (a.balanceo(raiz) != -1)
          MessageBox.Show("El esta balanceado");
        else MessageBox.Show("El no esta balanceado");
      }
      else MessageBox.Show("Árbol vacio.");
    }
  }
}
