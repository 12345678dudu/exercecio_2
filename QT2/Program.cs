/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação em Batalha
• Contextualização: Em um jogo de RPG, o jogador ganha pontos após derrotar inimigos em uma
batalha. A pontuação máxima é de 100 pontos, e é determinada pela quantidade de inimigos
derrotados, a duração da batalha e se o jogador sofreu danos crítico.
• Comando: Crie um programa que calcule a pontuação final do jogador. O programa deve
receber o número de inimigos derrotados, a duração da batalha em minutos e se o jogador
sofreu danos crítico (sim ou não). A pontuação é calculada da seguinte forma:
• 10 pontos para cada inimigo derrotado;
• Subtraia 10 pontos se a batalha durar mais de 5 minutos;
• Subtraia 10 pontos se o jogador sofreu dano crítico;
classe, e raça do personagem e exiba esses dados no console.
@Lista: 02 - Condicionais
@Autor: Eduardo Gomes de Sena
@Data: 22/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    public static void Main(string[] args)
    {
        string?sofreu;
        double inimigos,duracao,pontos,p1=0,p2=0;
        Console.WriteLine ("Qual foi número de inimigos derrotados?");
          double.TryParse(Console.ReadLine(),out inimigos);
        Console.WriteLine ("Qual foi a duração da batalha?");
        double.TryParse(Console.ReadLine(),out duracao);
          Console.WriteLine ("O jogador sofreu danos críticos?Responda com sim ou não");
          sofreu=Console.ReadLine();
       pontos=inimigos*10;
        if(duracao>5)
        {
            p1=pontos-10;
        }
        else
        {
            p1=pontos-0;
        }
        if(sofreu=="sim")
        {
           p2=p1-10;
        }
        else
        {
            p2=p1-0;
        }
        if(p2>100)
        {
        Console.WriteLine("Pontos:100");
    }
    else
    {
        Console.WriteLine("Pontos:"+p2);
    }
    }
    }
