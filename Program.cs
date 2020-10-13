using SP_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_EF
{
    class Program
    {
        // Para ejecutar SP desde entorno de desarrollo
        static void Main(string[] args)
        {
            using(SP_EFEntities DB = new SP_EFEntities()) // Instancia objeto de tipo contexto
            {
                DB.SP_INSERTAR_ALUMNO("500", "A5_NOMBRE", "A5_APELLIDO", "A5_CORREO@CORREO.COM", 67, "12345"); // DB.SP y parametros
            }

            /*
             * Sólo si cambia la estructura del SP en la DB, es necesario eliminar (de IMPORTACIONES DE FUNCIONES y FUNCIONES/PROCEDIMIENTOS ALMACENADOS) y actualizar en el Model Browser - de la opcion View de la cinta de opciones
             * RECORDAR GUARDAR!!!
             */
        }
    }
}
