using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Dibujar
{
    public class GestorJSON
    {

        public static void escribirJSON()
        {
            DBFiguras db = new DBFiguras();

            db.lista = new List<regFigura> { 
                new regFigura("CIRCULO", "Circular", "radio=5;"),
                new regFigura("CIRCULO", "Redondo", "radio=3;"),
                new regFigura("CIRCULO", "Curva", "radio=7;"),
                new regFigura("CIRCULO", "Cuadro", "base=3;altura=6;"),
                new regFigura("CIRCULO", "Recto", "base=5;altura=2;"),
                new regFigura("CIRCULO", "Caja", "base=3;altura=3;"),
                new regFigura("CIRCULO", "Dorito", "a=2;b=4;c=3;"),
                new regFigura("CIRCULO", "Igual Lado", "a=4;b=4;c=4;"),
                new regFigura("CIRCULO", "Con Punta", "a=6;b=3;c=6;")
            };

            string fileName = "../../../ListaFiguras.json";
            string jsonString = JsonSerializer.Serialize<DBFiguras>(db);
            File.WriteAllText(fileName, jsonString);
        }



    }
}
