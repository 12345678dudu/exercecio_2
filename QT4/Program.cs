/*-------------------------------------------------------------------
Lista de Exercícios 2
3
Questão 4: Decisão de Ataque Especial
• Contextualização: Durante uma batalha em um jogo de RPG, o jogador pode realizar um ataque
especial se tiver mana suficiente, se a vida do inimigo estiver baixa e se o nível do jogador for
alto o bastante.
• Comando: Crie um programa que determine se o jogador deve realizar um ataque especial. O
programa deve receber a quantidade de mana do jogador, a vida atual do inimigo em
porcentagem e o nível do jogador. As condições para realizar o ataque especial são:
• Mana maior que 30.
• Vida do inimigo menor que 50%.
• Nível do jogador maior que 5
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

        int mana, nivel, vida;
        Console.WriteLine("Qual sua quantidade de mana?");
        int.TryParse(Console.ReadLine(), out mana);
        Console.WriteLine("Qual o nivel do seu personagem?");
        int.TryParse(Console.ReadLine(), out nivel);
        Console.WriteLine("Qual a porcentagem de vida do seu inimigo?");
        int.TryParse(Console.ReadLine(), out vida);
        
            if (mana < 30)
            {
                Console.WriteLine("Ainda falta mana");
            }
            else if (vida > 50)
            {

                Console.WriteLine("Ainda falta diminuir a vida do inimigo!");
            }


            else if (nivel < 5)
            {
                Console.WriteLine("Falta subir de nível");
            }
        
        else
        {
            Console.WriteLine("Hora do ataque especial");
        }
    }
}
