namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array de arrays (Jagged Array)
            string[][] personaliza = new string [3][]; // Razgos de un personaje (solo cabeza)

            /* Cuando desconozco que valores hay dentor de cada array
            como en este caso, yo conozco los razgos puedo usar la segunda forma para inicializar
            directamente los arrays,*/

            /*personaliza[0] = new string[3]; // Cabello
            personaliza[1] = new string[4]; // Ojos
            personaliza[2] = new string[2]; // Nariz
            personaliza[3] = new string[4]; // Head shape*/

            // Forma 2:

            personaliza[0] = new string[] {"Verde", "Naranja", "Rosado"};
            
            personaliza[1] = new string[] {"Grande", "Pequeña"};
            personaliza[2] = new string[] {"Cuadrada", "Circular"};

            for (int i=0; i<3; i++)
            {
                for (int j=0; j<personaliza[i].Length; j++)
                {Console.Write(personaliza[i][j] + " ");}

                Console.WriteLine("");
            }
        }
    }
}