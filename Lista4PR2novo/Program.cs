using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lista4PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float menu;

            Console.WriteLine("====MENU====");
            Console.WriteLine("1- exercicio 1");
            Console.WriteLine("2- exercicio 2");
            Console.WriteLine("3- exercicio 3");
            Console.WriteLine("4- exercicio 4");
            Console.WriteLine("5- exercicio 5");
            Console.WriteLine("6- exercicio 6");
            Console.WriteLine("7- exercicio 7");
            Console.WriteLine("8- exercicio 8");
            menu = float.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("a afirmaçao é falsa É possivel atribuir uma variavel tipo int em uma variavel float, mas uma variavel float nao é possivel atiribuir em uma variavel tipo int. ");
                    Console.WriteLine("veja os exemplos:");

                    // int n1, n2=1;
                    //float n3;

                    //n3 = n2;
                    //n2 = n3;
                    Console.WriteLine("nao é possivel converter um tipo float em int");


                    break;

                case 2:
                    Console.WriteLine("Console.ReadLine()  vai ler uma linha inteira ate o local em que ela acabar, ja o Console.Read() vai ler apenas o primeiro caracter da linha");


                    break;

                case 3:
                    Console.WriteLine("Precisamos usar parse (ex: variavel=int.Parce(ReadLine()); que é necessario para quando o ususario digitar uma coisa que nao seja compativel com a variavel ele vai parar o programa");

                    break;

                case 4:
                    Console.WriteLine(" o objetivo do programa é verificar se o numero é par e maior que 10.");
                    Console.WriteLine("8 a resposta sera mensagem 2");
                    Console.WriteLine("27 a resposta sera mensagem 2");
                    Console.WriteLine("28 a resposta sera mensagem 1");

                    break;

                case 5:
                    float tempo, distancia, mru;
                    Console.WriteLine("====Equação do Movimento Retilíneo Uniforme====");

                    Console.WriteLine("Digite a distancia:");
                    distancia = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a velocidade:");
                    tempo = float.Parse(Console.ReadLine());

                    mru = distancia / tempo;

                    Console.WriteLine("o resultado é :" + mru);
                    break;

                case 6:
                    float div3, div5, div10, naleatorio;

                    Random random = new Random();
                    naleatorio = random.Next(0, 100);
                    Console.WriteLine("O valor gerado foi: " + naleatorio);

                    div3 = naleatorio % 3;
                    div5 = naleatorio % 5;
                    div10 = naleatorio % 10;

                    if (div3 == 0 && div5 == 0 && div10 == 0)
                        Console.WriteLine("esse numero é divisivel por 3, 5 e 10");

                    else if (div3 == 0 && div5 == 0)
                        Console.WriteLine("Esse numero é divisivel por 3 e 5");


                    else if (div3 == 0)
                        Console.WriteLine("esse numero é divisivel apenas por 3");

                    else
                        Console.WriteLine("esse numero é divisivel apenass por 5");



                    break;

                case 7:
                    int posicaodacasa;
                    Console.WriteLine("Digite a posição em km da sua casa em relação à escola que fica no km 100:");
                   posicaodacasa = int.Parse(Console.ReadLine());

                   

                    if (posicaodacasa < 12)
                    {
                        Console.WriteLine("o tempo necessario para chegar sera: 14 minutos");
                    }
                    else if (posicaodacasa < 29)
                    {
                        Console.WriteLine("o tempo necessario para chegar sera: 17 minutos");
                        
                    }
                    else if (posicaodacasa < 55)
                    {
                        Console.WriteLine("o tempo necessario para chegar sera: 13 minutos");
                       
                    }
                    else if (posicaodacasa < 82)
                    {
                        Console.WriteLine("o tempo necessario para chegar sera: 15 minutos");
                        
                    }
                    else
                    {
                        Console.WriteLine("o tempo necessario para chegar sera: 12 minutos");
                        
                    }

                    

                    break;

                case 8:
                    float preco,res1,res2,res3, custo, imposto, unidade;

                    Console.WriteLine("escolha a raçao conforme o menu a baixo:");
                    Console.WriteLine("1- Royal");
                    Console.WriteLine("2- Hiskas");
                    Console.WriteLine("3- golden");
                    Console.WriteLine("4- Nutrien");
                    Console.WriteLine("5- SPECIALCA");
                    Console.WriteLine("6- MARBA");
                    Console.WriteLine("7- GATUS");

                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Digite a unidade que voce vai querer:");
                            unidade = int.Parse(Console.ReadLine());

                            preco = 129.50f;
                            custo = 77.5f;
                            imposto = 33f;
                            res1 = unidade * preco;
                            res2 = res1 - custo;
                            res3 = res2 - imposto;

                            Console.WriteLine("valor total: " + res1);
                            Console.WriteLine("o valor Liquido é de :" + res3);
                            break;
                        case 2:
                            Console.WriteLine("Digite a unidade que voce vai querer:");
                            unidade = int.Parse(Console.ReadLine());

                            preco = 182.78f;
                            custo = 89.7f;
                            imposto = 22.5f;
                            res1 = unidade * preco;
                            res2 = res1 - custo;
                            res3 = res2 - imposto;

                            Console.WriteLine("valor total: " + res1);
                            Console.WriteLine("o valor Liquido é de :" + res3);
                            break;
                        case 3:
                            Console.WriteLine("Digite a unidade que voce vai querer:");
                            unidade = int.Parse(Console.ReadLine());

                            preco = 159.46f;
                            custo = 71.7f;
                            imposto = 22.5f;
                            res1 = unidade * preco;
                            res2 = res1 - custo;
                            res3 = res2 - imposto;

                            Console.WriteLine("valor total: " + res1);
                            Console.WriteLine("o valor Liquido é de :" + res3);
                            break;
                        case 4:
                            Console.WriteLine("Digite a unidade que voce vai querer:");
                            unidade = int.Parse(Console.ReadLine());

                            preco = 144.80f;
                            custo = 88.9f;
                            imposto = 25f;
                            res1 = unidade * preco;
                            res2 = res1 - custo;
                            res3 = res2 - imposto;

                            Console.WriteLine("valor total: " + res1);
                            Console.WriteLine("o valor Liquido é de :" + res3);
                            break;
                        case 5:
                            Console.WriteLine("Digite a unidade que voce vai querer:");
                            unidade = int.Parse(Console.ReadLine());

                            preco =205.40f;
                            custo = 83.24f;
                            imposto = 22f;
                            res1 = unidade * preco;
                            res2 = res1 - custo;
                            res3 = res2 - imposto;

                            Console.WriteLine("valor total: " + res1);
                            Console.WriteLine("o valor Liquido é de :" + res3);
                            break;
                        case 6:
                            Console.WriteLine("Digite a unidade que voce vai querer:");
                            unidade = int.Parse(Console.ReadLine());

                            preco = 125.10f;
                            custo = 90.4f;
                            imposto = 17.9f;
                            res1 = unidade * preco;
                            res2 = res1 - custo;
                            res3 = res2 - imposto;

                            Console.WriteLine("valor total: " + res1);
                            Console.WriteLine("o valor Liquido é de :" + res3);
                            break;
                        case 7:
                            Console.WriteLine("Digite a unidade que voce vai querer:");
                            unidade = int.Parse(Console.ReadLine());

                            preco = 133.99f;
                            custo = 94.6f;
                            imposto = 20f;
                            res1 = unidade * preco;
                            res2 = res1 - custo;
                            res3 = res2 - imposto;

                            Console.WriteLine("valor total: " + res1);
                            Console.WriteLine("o valor Liquido é de :" + res3);
                            break;

                        default:
                            Console.WriteLine("opção invalida");
                            break;

                    }
                        


                    break;

                default:
                    Console.WriteLine("opção invalida");
                    break;
            }



            Console.ReadKey();
        }
    }
}