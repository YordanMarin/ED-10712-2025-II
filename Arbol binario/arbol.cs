using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_binario
{
  internal class arbol
  {
    public Nodo insertar(Nodo actual, int n)
    {
      Nodo nuevo = new Nodo(n);

      if (actual == null) return nuevo;
      if ((actual.izquierda != null || actual.derecha == null) &&
        (actual.izquierda == null || actual.derecha != null))
      {
        MessageBox.Show("Nodo ocupado");
      }
      else if (actual.izquierda == null)
        actual.izquierda = nuevo;
      else actual.derecha = nuevo;

      return actual;
    }

    public void mostrar(Nodo actual, TreeView tree, TreeNode tallo)
    {
      TreeNode raiz = new TreeNode(actual.numero.ToString()); //raiz
      raiz.Tag = actual; //almacenando referencia de memoria

      if(tallo == null) tree.Nodes.Add(raiz); //tallo
      else tallo.Nodes.Add(raiz); //hojas

      if(actual.izquierda != null) mostrar(actual.izquierda, tree, raiz);
      if (actual.derecha != null) mostrar(actual.derecha, tree, raiz);
    }

    public int altura(Nodo actual)
    {
      if(actual != null)
      {
        int altIzq = altura(actual.izquierda);
        int altDer = altura(actual.derecha);

        return Math.Max(altIzq, altDer)+1;
      }
      return 0;
    }
  }
}
