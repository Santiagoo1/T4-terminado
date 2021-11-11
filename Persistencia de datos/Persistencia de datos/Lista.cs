using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Persistencia_de_datos
{
    class Lista
    {
        public Lista()
        {
            DT.TableName = "inventario";
            DT.Columns.Add("Nombre");
            DT.Columns.Add("Codigo");
            DT.Columns.Add("Precio");
            leerarchivo();
        }
        public DataTable DT = new DataTable();
        public void leerarchivo()
        {
            if (System.IO.File.Exists("Datos1.xml"))
            {
                DT.Clear();
                DT.ReadXml("Datos1.xml");
            }
        }
        public void registrar(string nombre, int codigo, int precio)
        {
            Productos producto = new Productos();
            producto.Nombre = nombre;
            producto.Codigo = codigo;
            producto.Precio = precio;

            DT.Rows.Add();
            int numeroderegistronuevo = DT.Rows.Count - 1;
            DT.Rows[numeroderegistronuevo]["Nombre"] = producto.Nombre;
            DT.Rows[numeroderegistronuevo]["Codigo"] = producto.Codigo;
            DT.Rows[numeroderegistronuevo]["Precio"] = producto.Precio;
            DT.WriteXml("Datos1.xml");
        }


    }
}


