using System;
using Nova_pasta.classes;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p1 = new Produto(1, "Playstation 5", 4000f);
            Produto p2 = new Produto(2, "Par de Meias", 10,00f);
            Produto p3 = new Produto(3, "XBox One", 4000f);
            Produto p4 = new Produto(4, "Camisa Social", 25.00f);
            Produto p5 = new Produto();
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            
            while(1==1)
            {
                Console.WriteLine("--------------------------");
            Console.WriteLine("[1] - Cadastrar um produto");
            Console.WriteLine("[2] - Listar produtos     ");
            Console.WriteLine("[3] - Deletar um produto  ");
            Console.WriteLine("[4] - Alterar um produto  ");
            Console.WriteLine("--------------------------");
            
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                Console.Write("Código do produto: ");
                int codigo = int.Parse(Console.ReadLine());
                p5.Codigo = codigo;
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();
                p5.Nome = nome;
                Console.Write("Preço do produto: ");
                int preco = int.Parse(Console.ReadLine());
                p5.Preco = preco;
                carrinho.AdicionarProduto(p5);
                    break;
                case 2:
                carrinho.MostrarProdutos();
                    break;
                case 3:
                carrinho.RemoverProduto();
                    break;
                default:
                    break;
            }
            }
        }
    }
}
