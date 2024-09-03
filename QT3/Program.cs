/*-------------------------------------------------------------------
Lista de Exercícios 2
3
Questão 3: Loja de Poções
• Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que
aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas,
Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há
um desconto aplicável.
• Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo
de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. Calcule o preço total
das poções, aplicando o desconto correspondente:
• Guerreiro recebe 10% de desconto na compra de poções de Vida.
• Mago recebe 15% de desconto na compra de poções de Mana.
• Paladino recebe 20% de desconto na compra de poções de Resistência.
• Exiba o preço total com e sem desconto.
@Lista: 02 - Condicionais
@Autor: Eduardo Gomes de Sena
@Data: 22/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    public static void Main(string[] args)
    {
        string? classe,pocao;
        int compra,preco;
         Console.WriteLine ("Qual seu tipo de poção?");
           pocao =Console.ReadLine();
        Console.WriteLine ("Qual a classe do seu personagem?");
        classe =Console.ReadLine();
        Console.WriteLine ("Quanto deseja comprar ");
        int.TryParse(Console.ReadLine(),out compra);
         if(pocao=="vida")
        { 
            if(classe=="guerreiro")
            { preco=(compra*10);
               double preco1=preco*0.10;
               double preco2=preco-preco1;
               Console.WriteLine("Preço com desconto:"+preco2);
            }
            else
            { preco=(compra*10);
            Console.WriteLine("preço com desconto:"+preco);
            }
            }
           if(pocao=="mana")
        { 
            if(classe=="mago")
            { preco=(compra*15);
               double preco1=preco*0.15;
               double preco2=preco-preco1;
               Console.WriteLine("Preço com desconto:"+preco2);
            }
            else
            { preco=(compra*15);
            Console.WriteLine("preço com desconto:"+preco);
            }
            }
            if(pocao=="resistencia")
        { 
            if(classe=="paladino")
            { preco=(compra*20);
               double preco1=preco*0.20;
               double preco2=preco-preco1;
               Console.WriteLine("Preço com desconto:"+preco2);
            }
            else
            { preco=(compra*20);
            Console.WriteLine("preço com desconto:"+preco);
            }
            }
}
    
}

