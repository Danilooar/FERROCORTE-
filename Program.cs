using System;

class Program
{
    static void Main()
    {
    
        Console.WriteLine("Digite o Ponto de Pedido (PP): ");
        int PP = 0;
        while (!int.TryParse(Console.ReadLine(), out PP))  
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro para o Ponto de Pedido (PP): ");
        }

       
        Console.WriteLine("Digite o Estoque Máximo: ");
        int EstoqueMaximo = 0;
        while (!int.TryParse(Console.ReadLine(), out EstoqueMaximo)) 
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro para o Estoque Máximo: ");
        }

        Console.WriteLine("Digite o Estoque atual da Matriz: ");
        int EMatriz = 0;
        while (!int.TryParse(Console.ReadLine(), out EMatriz)) 
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro para o Estoque atual da Matriz: ");
        }

   
        Console.WriteLine("Digite o Estoque atual da Filial: ");
        int EFilial = 0;
        while (!int.TryParse(Console.ReadLine(), out EFilial))  
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro para o Estoque atual da Filial: ");
        }

     
        string acaoMatriz = "";
        int quantidadeMatriz = 0;
        string acaoFilial = "";
        int quantidadeFilial = 0;

  
        if (EMatriz < PP)
        {
            acaoMatriz = "COMPRAR";
            quantidadeMatriz = PP - EMatriz; 
        }
        else if (EMatriz > EstoqueMaximo)
        {
            acaoMatriz = "NÃO COMPRAR";
            quantidadeMatriz = EMatriz - EstoqueMaximo; 
        }
        else
        {
            acaoMatriz = "NÃO COMPRAR";
            quantidadeMatriz = 0;  
        }

    
        if (EFilial < PP)
        {
            acaoFilial = "COMPRAR";
            quantidadeFilial = PP - EFilial;  
        }
        else if (EFilial > EstoqueMaximo)
        {
            acaoFilial = "TRANSFERIR";
            quantidadeFilial = EFilial - EstoqueMaximo; 
        }
        else
        {
            acaoFilial = "NÃO COMPRAR";
            quantidadeFilial = 0; 
        }

  
        Console.WriteLine($"Matriz - Ação: {acaoMatriz}, Quantidade: {quantidadeMatriz}");
        Console.WriteLine($"Filial - Ação: {acaoFilial}, Quantidade: {quantidadeFilial}");
    }
}

