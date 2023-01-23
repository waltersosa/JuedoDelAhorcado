using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_del_Ahorcado__Alberto_
{
    internal class Words
    {
        static Dictionary<string, string[]> words =
        new Dictionary<string, string[]> {
            {"Comidas", new string[]{
            "Pan francés", "Sopa", "Sopa de tomate", "Carne en su jugo", "Enchiladas",
            "Enfrijoladas", "Sopa de tortilla", "Tortilla", "Quesadilla", "Pozole",
            "Ensalada", "Pollo rostizado", "Milanesa", "Pizza", "Sushi",
            "Hamburguesa", "Hot dog", "Carne asada", "Aguachile", "Cereal"}},
            {"Frutas", new string[]{ 
            "Fresa", "Durian", "Mandarina", "Uva", "Uva pasa",
            "Ciruela", "Nanche", "Guanabana", "Durazno", "Piña",
            "Naranja", "Sandía", "Melón", "Sandía", "Limón",
            "Aguacate", "Cacahuate", "Nuez", "Naranja agría", "Mango"}},
            {"Nombres femeninos", new string[]{
            "Valeria", "Mónica", "Montserrat", "Daniela", "Ivette",
            "Mariana", "Miroslava", "Alondra", "Janette", "Karina",
            "Sarahí", "María", "Esmeralda", "Dalia", "Adriana", "Carmen",
            "Ximena", "Renata", "Olga", "Berenice", "Alma", "Denisse"}},
            {"Nombres masculinos", new string[]{
            "Daniel", "Joel", "Pedro", "Alberto", "Julian",
            "Antonio", "Ezequiel", "Obbeth", "Javid", "Gamaliel",
            "José", "Roberto", "Mauricio", "Rodrigo", "Esteban",
            "Martín", "Genaro", "Jaime", "Bruno", "Carlos"}},
            {"Ciudades", new string[]{
            "Ciudad de México", "Guadalajara", "Irapuato", "Toluca", "Pachuca",
            "Tokyo", "Nagoya", "Osaka", "Nagasaki", "Hiroshima",
            "Toronto", "Los Angeles", "Nueva York", "Seúl", "Busán",
            "Santiago", "Buenos Aires", "Montevideo", "Rio do Janerio", "Brasilia"}},
            {"Países", new string[]{ 
            "México", "España", "Italia", "Portugal", "Romanía",
            "Macedonia", "Bosnia", "Croacia", "Albania", "Yugoslavia",
            "Francia", "Alemania", "Belgica", "Países bajos", "Lituania",
            "Argentina", "Uruguay", "Chile", "Paraguay", "Perú", "Bolivia"}},
            {"Cosas", new string[]{
            "Cigarro", "Encendedor", "Mesa", "Silla", "Pulsera",
            "Collar", "Zapato", "Bota", "Tenis", "Bombilla",
            "Camisa", "Pantalón", "Cable", "Extensión", "Pin",
            "Navaja", "Pistola", "Desarmador", "Cuchillo", "Soga"}},
            {"Acciones", new string[]{ 
            "Llorar", "Enojar", "Cargar", "Conectar", "Contemplar",
            "Admirar", "Acompañar", "Prometer", "Mentir", "Reír",
            "Gritar", "Temblar", "Combulsionar", "Esperar", "Amar",
            "Sufrir", "Morir", "Decaer", "Comprar", "Gastar"}},
            {"Animales", new string[]{
            "Ardilla", "Perro", "Gato", "Pulpo", "Pez",
            "Ballena", "Ocelote", "Salamandra", "Oso hormiguero", "Rata",
            "Rana", "Sapo", "Murcielago", "Delfín", "Orca",
            "Rinoceronte", "Elefante", "Mariposa", "Gusano", "Mosca"}},
            {"Cantantes", new string[]{ 
            "Lana del Rey", "Placebo", "José Madero", "Gorillaz",
            "BTS", "Stray Kidz", "Twice", "Black pink", "Ace of Angles",
            "Rammstein", "Pixies", "Marina and the Diamonds", "Melanie Martinez",
            "Tove Lo", "Rage against the machine", "RHCP", "Radiohead", "José José"}},
        };
        public string getByCategory(string cat)
        {
            Random rnd = new Random();
            int random_index = rnd.Next(0, 20);
            if (words.ContainsKey(cat))
            {
                return words[cat][random_index];
            }
            else
            {
                return null;
            }
        }
        public string[] getCategories()
        {
            int i_aux = 0;
            Dictionary<string, string[]>.KeyCollection keys = words.Keys;
            string[] aux = new string[words.Count];
            foreach(string key in keys)
            {
                aux[i_aux] = key;
                i_aux++;
            }
            return aux;
        }
        public int getSize()
        {
            return words.Count;
        }
    }
}
