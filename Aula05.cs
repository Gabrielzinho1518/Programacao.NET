namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cachorro c = new Cachorro();
            c.nome = "Toby";
            Console.WriteLine("Cachorro: " + c.nome);
            c.EmitirSom();
            c.movimentar(); 

            Gato g = new Gato();
            g.nome = "Garfield";
            Console.WriteLine("Gato: " + g.nome);
            g.EmitirSom();
            g.movimentar();

            Peixe p = new Peixe();
            p.nome = "nemo";
            Console.WriteLine("Peixe: " +p.nome);
            p.movimentar();
            p.EmitirSom();
        }
    }
}