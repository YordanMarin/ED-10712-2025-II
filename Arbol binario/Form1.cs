using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_binario
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      radioIzquierda.Checked = true;
    }
    Nodo raiz;
    Nodo sele;
    arbol a = new arbol();
    private void btnInsertarRaiz_Click(object sender, EventArgs e)
    {
      treeView1.Nodes.Clear();
      raiz = a.insertar(null, int.Parse(textNumero.Text));
      a.mostrar(raiz, treeView1, null);
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      sele = (Nodo)e.Node.Tag;
    }

    private void btnInsertarRama_Click(object sender, EventArgs e)
    {
      if (sele != null)
      {
        if (radioIzquierda.Checked == true)
          sele.izquierda = a.insertar(sele.izquierda, int.Parse(textNumero.Text));
        if (radioDerecha.Checked == true)
          sele.derecha = a.insertar(sele.derecha, int.Parse(textNumero.Text));

        treeView1.Nodes.Clear();
        a.mostrar(raiz, treeView1, null);
        treeView1.ExpandAll();
        textNumero.Clear();
      }
      else MessageBox.Show("Seleccione un nodo.");
      
    }

    private void btnAltura_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Altura: " + a.altura(raiz));
    }
  }
}
