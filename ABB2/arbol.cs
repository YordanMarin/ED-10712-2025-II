using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABB2
{
  internal class arbol
  {
    int cant = 0;
    public Nodo insertar(Nodo actual, double num)
    {
      Nodo nuevo = new Nodo(num);
      if (actual == null)
      {
        cant++;
        return nuevo;
      }
      if (num < actual.numero)
        actual.izquierda = insertar(actual.izquierda, num);
      else if (num > actual.numero)
        actual.derecha = insertar(actual.derecha, num);
      else MessageBox.Show("No duplicados");
      return actual;
    }

    public int contar()
    {
      return cant;
    }

    public void mostrar(Nodo actual , TreeView t, TreeNode tallo)
    {
      if(actual != null)
      {
        TreeNode raiz = new TreeNode(actual.numero.ToString()+" ");
        if(tallo == null) t.Nodes.Add(raiz);
        else tallo.Nodes.Add(raiz);

        mostrar(actual.izquierda , t, raiz);
        mostrar(actual.derecha , t, raiz);
      }
    }

    public void post(Nodo actual, TextBox t)
    {
      if (actual != null)
      {
        post(actual.izquierda, t);
        post(actual.derecha, t);
        t.Text += actual.numero.ToString() + " ";
      }
    }

    public Nodo buscar(Nodo actual, double num)
    {
      if (actual != null)
      {
        if (num == actual.numero)
        {
          return actual;
        }
        else if (num > actual.numero)
        {
          return buscar(actual.derecha, num);
        }
        else
        {
          return buscar(actual.izquierda, num);
        }
      }
      return null;
    }
  }
}
