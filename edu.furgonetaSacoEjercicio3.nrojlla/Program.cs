namespace edu.furgonetaSacoEjercicio3.nrojlla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el peso de un saco en kg: ");
            int pesoSaco = Convert.ToInt32(Console.ReadLine());

            int capacidadFurgoneta = 4000;
            int contadorSacos = 0;
            

           while (capacidadFurgoneta >= pesoSaco)
           {
                capacidadFurgoneta -= pesoSaco;
                contadorSacos++;
                
           }

           if (pesoSaco > 4000)
           {
                Console.WriteLine("El peso del saco es superior a la capacidad de la furgoneta.");
           }
           else
           {
                Console.WriteLine("Puedes cargar " + contadorSacos + " sacos en la furgoneta.");
                Console.WriteLine("La capacidad restante de la furgoneta es de " + capacidadFurgoneta+ " kg.");
           }

            
        }
    }
}
