using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{
    public class Categoria
    {
        //Usa la convencion EF para indicar que en SQL Server la columna Id sea la clave principal y autonumerica
        //Id o Categoria
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
