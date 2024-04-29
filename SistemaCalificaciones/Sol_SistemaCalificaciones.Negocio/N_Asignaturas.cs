using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_SistemaCalificaciones.Entidades;
using Sol_SistemaCalificaciones.Datos;

namespace Sol_SistemaCalificaciones.Negocio
{
    public class N_Asignaturas
    {
        public static DataTable Listado_Asignaturas(string asgTexto) 
        { 
            D_Asignaturas Datos = new D_Asignaturas();
            return Datos.Listado_Asignaturas(asgTexto);
        }

        public static string Guardar_Asignatura(int nOpcion, E_Asignaturas oAsg)
        {
            D_Asignaturas Datos = new D_Asignaturas();
            return Datos.Guardar_Asignatura(nOpcion, oAsg);
        }

        public static string Eliminar_Asignatura(int ID_Asignatura)
        {
            D_Asignaturas Datos = new D_Asignaturas();
            return Datos.Eliminar_Asignatura(ID_Asignatura);
        }
    }
}
