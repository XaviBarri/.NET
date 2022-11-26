// See https://aka.ms/new-console-template for more information

namespace AppConsola
{
    class Program
    {
        public static int AddElements(int[] a) {
            int sum = 0;
            for (int i = 0; i < a.Length; i++) {
                sum += a[i];
            }
            return sum;
        }

        public static int AddElementsParams(params int[] a) {
            int sum = 0;
            for (int i = 0; i < a.Length; i++) {
                sum += a[i];
            }
            return sum;
        }

        static void Intercambiar(ref string str1, ref string str2) {
            string copia = str1;
            str1 = str2;
            str2 = copia;
        }

        static double Potencia(int mod, int exp) {
            int result = mod;
            if (exp == 0) {
                return 1;
            } else {
                return (mod * Potencia(mod, exp - 1));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Module 4 Exercices");
            int[] a = {1, 2, 3};
            Console.WriteLine("array de ints: " + a.ToString());
            int sum = AddElements(a);
            Console.WriteLine("Suma de los elementos: " + sum.ToString());
            int sum2 = AddElementsParams(10, 11, 12);
            Console.WriteLine("Suma de los elementos: " + sum2);
            // Ejercicio 3. Intercambiar
            string s1 = "Hola";
            string s2 = "Adios";
            Console.WriteLine("s1 = " + s1);
            Console.WriteLine("s2 = " + s2);

            Intercambiar(ref s1, ref s2);

            Console.WriteLine("s1 = " + s1); //Esto imprime "Adios"
            Console.WriteLine("s2 = " + s2); //Esto imprime "Hola"

            // Ejercicio 4. Potencia
            Console.WriteLine("2 exp 8 = " + Potencia(2, 8));
        }

    }
}