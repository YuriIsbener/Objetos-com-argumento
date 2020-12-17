using System;
using System.Collections.Generic;

namespace Nova_pasta.classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }


        public void MostrarProdutos()
        {
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine($" R$ {p.Preco.ToString("n2")} - {p.Nome}");
                }
                MostrarProdutos();
            }
        }

        public void MostrarTotal()
        {
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"Total do Carrinho R$ {ValorTotal.ToString("n2")}");
            }else{
                Console.WriteLine($" Seu carrinho ainda está vazio! ");
            }
        }
        public void AlternarItem(int _codigo, Produto _novoProduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }

        internal void RemoverProduto()
        {
            throw new NotImplementedException();
        }
    }
}