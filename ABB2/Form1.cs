using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABB2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    Nodo raiz;
    arbol a = new arbol();
    private void btnInsertar_Click(object sender, EventArgs e)
    {
      if (textNumero.Text.Contains("."))
      {
        if (double.TryParse(textNumero.Text, out double num))
        {
          if(raiz == null) raiz = a.insertar(null, num);
          else a.insertar(raiz, num);

          treeView1.Nodes.Clear();
          a.mostrar(raiz, treeView1, null);
          treeView1.ExpandAll();
          textNumero.Clear();
        }
        else MessageBox.Show("Ingrese un número valido porfavor");
      }
      else MessageBox.Show("Tiene que ser decimal");
      
    }

    private void btnPostorden_Click(object sender, EventArgs e)
    {
      if (a.contar() >= 6)
      {
        textPost.Clear();
        a.post(raiz, textPost);
      }
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      Nodo buscar = a.buscar(raiz, double.Parse(textNumero.Text));
      if (buscar != null)
      {
        if (raiz.numero == buscar.numero)
          MessageBox.Show("Es la raiz");
        else
          MessageBox.Show("Existe");
      }
      else MessageBox.Show("No existe");
    }
  }
}
