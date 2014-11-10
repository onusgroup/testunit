using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public static class Productos
    {
        public class Producto
        {
            public int id { get; set; }
            public string grupo { get; set; }
            public string album { get; set; }
            public string genero { get; set; }
            public string formato { get; set; }
            public int stock { get; set; }
            public int idVentas { get; set; }
        }
       

        public static List<Producto> getListaProductos()
        {
            List<Producto> lista = new List<Producto>() 
            { 
                new Producto(){ id = 1, grupo = "Metallica", album = "Kill Em All", genero = "Trash Metal", formato="MP3", stock=200, idVentas=1},
                new Producto(){ id = 2, grupo = "Ac/dc", album = "Back in Black", genero = "Rock", formato="Bluray", stock=200, idVentas=3},
                new Producto(){ id = 3, grupo = "Megadeth", album = "Rust in Peace", genero = "Trash Metal", formato="DVD", stock=200, idVentas=2},
                new Producto(){ id = 4, grupo = "Metallica", album = "Master Of Puppets", genero = "Trash Metal", formato="Vinilo", stock=200, idVentas=1},
                new Producto(){ id = 5, grupo = "Los Prisioneros", album = "Pateando Piedras", genero = "Rock", formato="MP3", stock=200, idVentas=3}
            };
            return lista;
        }


    }

}
