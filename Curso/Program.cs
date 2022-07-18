using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Program
    {
        // Váriavel com escopo Global:
        static string NomeCompleto = "Eduardo Moises Viana Rezende";  //Static será explicada em P.O.O;
            
        //Enum: Enumerador,  Cria novos tipos de dados limitados dentro da programação;
        //Exemplo a variavel cor possui 4 dados de cores e com o Enum você consegue carregar todos estes dados limitados no código;

        enum cor { Azul = 1, Verde, Vermelho, Amarelo }
        enum opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }

        static void Main(string[] args)
        {
            // váriaveis são caixas que armazenam valor/dado;

            //int - -156 tanto 12345
            //float - -32.6 tanto 123.899
            //bool - true or false
            //string - "eduardo Moises Viana Rezende"
            //char - 'L'

            // O que não deve conter em váriaveis 
            // Deve conter letras de A-Z
            // N° de 0=9 
            // @=$
            // _
            // Class - Usuing

            // = Isso significa atribuir um valor para o outro;

            /* int Anonasc = 2005;
             string favoriteColor = "Blue";
             float velCarro = 150.45f;
             bool verAno = true;


             Console.WriteLine(Anonasc);
             Console.WriteLine(favoriteColor);
             Console.WriteLine(velCarro);
             Console.WriteLine(verAno);

             velCarro = 348.38f;
             favoriteColor = "Red";

             Console.WriteLine(velCarro);
             Console.WriteLine(favoriteColor);
             */

            /*var favoriteClor = "Blue";
            var velCarro = 1234.45f;
            var Anonasc = 2005;*/

            //const é um valor que nunca muda e de extrema importância no projeto caso aja um valor fixo dependendo do sistema  por exemplo o PI.    
            //const string Brazil = "Pertence a America do Sul";

            //Aqui está um pequenino programa onde armazena o nome do usuário na variavel nome;
            //string nome = ""; outro método para declarar string neste caso;
            /*Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);*/

            /*int nInteiro = 20 + 20 - 80;
            int nMult = 10 * 5;
            float nDiv = 5 / 2f; 
            float nDivv = 3f / 2;
            int teste = (2 + 2) * 10;*/



            //int teste = 2 + 2 * 10;
            // O c# segue as regras matemáticas ou seja vai seguir a ordem dando priopirade a divisão e multiplicação, está errado

            //int nDivv = 5 / 2f; da erro pois só puxara o float;
            /* 5/2 é um float pois ele é quebrado então um int não consegue armazenar um dado tipo float;
            int nDiv = 5/2; */

            // 6/2 => 3 /int
            // 5/2 => 2.5 // decimal//float

            /* Console.WriteLine(nInteiro);
             Console.WriteLine(nMult);
             Console.WriteLine(nDiv);
             Console.WriteLine(nDivv);
             Console.WriteLine(teste);*/


            // Para adicionar mais condições &&(E ou AND) e Pipe == ||(OU/OR);

            // Entrar em uma festa(TRUE) ex: &&
            // SERMULHER && IDADE >=25 => Entra na festa de graça.

            // TRUE  && TRUE => true               Este é o &&
            // FALSE && FALSE => false
            // TRUE  && FALSE => false

            // COND1(T) || COND2(F) => true        Este é o ||
            // TRUE || TRUE => true
            // TRUE || FALSE => true
            // FALSE || FALSE => true
            // FALSE || FALSE => false


            // Entrar no jogo gratuitamente(TRUE) ex: ||
            //  LEVARALIMENTO(V) || LEVARBRINQUEDO(F) => Entra no jogo.

            // Estruturas condicionais If, Else e Elseif;
            /*int e = 40;
            int l = 50;
            int r = 20;

            // <, > == != <=, >= operadores lógicos.

            if (e > r || l < r)  //SE
            {
                Console.WriteLine("It's True");
            }
            else if (l < r) // SE NÃO SE sempre antes do else, quantos elseif vc quiser podem ser adicionados;
            {
                Console.WriteLine("Oi, eu sou o ElseIF");
            }
            else // SE NÃO
            {
                Console.WriteLine("It's False");
            }*/

            //Parse é usado para inverter string em int ou vice versa;]

            /* Console.WriteLine("Qual a sua idade atual ?");
             int idade = int.Parse(Console.ReadLine());

             if (idade >= 0 && idade <= 11 )
             {
                 Console.WriteLine("Você é uma criança!");
             }
             else if (idade >=12 && idade <=18)
             {
                 Console.WriteLine("Você é um adolescente!");
             }
             else if (idade >=19 && idade <=60)
             {
                 Console.WriteLine("Você é um adulto!");
             }
             else
             {
                 Console.WriteLine("Você é um idoso.");
             }*/

            // Console.BackgroundColor = ConsoleColor.White; cor estranha

            //Treinamento com o if e elseif; Precisa de Melhorias !

            /*Console.WriteLine("Clique sempre em enter para prosseguir ! ");
            Console.ReadLine();
            Console.WriteLine("Podemos descobrir mais sobre você ? ");
            Console.ReadLine();
            Console.WriteLine("Se aceita digite: 1, Se não aceita digite: 2 ");
           
            int concorda = int.Parse(Console.ReadLine());
            if (concorda == 1 )
            {
                Console.WriteLine("Obrigado, podemos seguir !");
                Console.ReadLine();
            }
            else if (concorda == 2)
            {
                Console.WriteLine("Ok");
                // Pensando em alguma forma de fechar o console...
            }
           
            Console.WriteLine("Você gosta de utilizar mais lógica em sua aprendiazagem ? ");
            Console.ReadLine();
            Console.WriteLine("Você gosta de saber como chegamos até aqui e como se deu ? ");
            Console.ReadLine();
            Console.WriteLine("Você gosta de ler e de saber como se utilizam as escritas corretas ? ");
            Console.ReadLine();
            Console.WriteLine("Prefere qual dessas opções, 1°, 2° ou 3° ? ");
            // Console.ReadLine(); tinha errado aqui. erro de espaço entre as leituras;

            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                Console.WriteLine("Você tem mais afinidade com matemática, parabéns !");
                Console.Read();
                
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Você tem mais afinidade com história , parabéns !");
                Console.ReadLine();
            }
            else if (escolha == 3)
            {
                Console.WriteLine("Você tem mais afinidade com português, Parabéns");
                Console.ReadLine();
            }

            Console.WriteLine("Obrigado pelo sua colaboração !");
            Console.ReadLine(); */


            // Console.WriteLine("Muito obrigado pela sua colaboração !");
             //Console.ReadLine();


            //Trabalhando com o Switch: Mais legivel e mais limpo para o código, ideal para casos com mais condições;
            // Só realiza operações de igualdade -> ==, apenas valores para comparar com  a variavel que está definida no Switch;

            /*string cor = "Yellow";
            switch (cor)
            {
                case "Green":
                    Console.WriteLine("Sua cor é Verde !");
                    break;
                case "Red ":
                    Console.WriteLine("Sua cor é Vermelho !");
                    break;
                case "Blue":
                        Console.WriteLine("Sua cor é Azul");
                    break;
                default:
                    Console.WriteLine("Color indefined");
                    break;
            }

            Console.ReadLine();/

            // Aqui puxei a funçaõ e junto os parametros concatenados;

            /*Loja(50, "Advil");
            Loja(40, "Sabonete");
            Loja(500, "Corrente de prata");
            Loja(300, "Celular Nokia"); */

            /* Calc(40);
             Calc(50);
             Calc(400);
             Calc(-21);
             Calc(-90);*/

            //exemplos de retorno:

            //string val = Console.ReadLine();
            //Console.WriteLine(val);
            //Console.ReadLine();

            //Console.WriteLine(Math.Abs(-70));
            //Console.ReadLine();

            /* treininho

            Console.WriteLine("Digite um Número: " );
            var num = Console.ReadLine();
            Console.WriteLine("Seu número é: " );
            Console.WriteLine(num);
            Console.ReadLine();*/

            //retornando um calculo em soma, podia ser outro exemplo;

            /*int soma1 = somar(1, 2, 3);
            int soma2 = somar(1, 6, 5);
            int soma3 = somar(8, 10, 9);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);*/

            // Arphia. 

            /*Console.WriteLine("Arphia é o nome de minha criação. ");
            Console.ReadLine();

            Console.WriteLine("Qual a sua opinião ?");
            var opiniao = Console.ReadLine();*/

            //Array ou Matriz, o array armazena vários valores/dados pré definidos ou seja invés de armazenar um unico valor como são feitas nas váriáveis, o array armazena mais;
            // Criei um Array abaixo:
            // A ordem dos dados sempre começa no 0 ou seja 0 = "oi";

            /* string[] recebimentos = new string[5] //Forma correta, mais demorada;
             {
             "oi", //0
             "ola", //1
             "roi", //2
             "seja bem vindo", //3
             "muito prazer" //4 
             };

             recebimentos[3] = "seja bem vindo amigos"; // assim que se muda dados de Arrays;

             Console.WriteLine(recebimentos[3]); // Indice é o nome da numeração dos elementos;

             int[] numeros = { 1, 2, 3, 4, 5, 6 }; //Forma mais rápida, funciona para armazenar números.

             numeros[1] = 7; // assim que se muda dados de Arrays;
             Console.WriteLine(numeros[1]);

             int[] num = { 10, 20, 30, 40, 50 };  //Forma mais rápida, funciona para armazenar números.

             num[3] = 60; num[4] = 70;
             Console.WriteLine(num[3]);
             Console.WriteLine(num[4]); */

            //Cast é converter um tipo para o outro;
            // Puxando dados do enum:

            /*cor CorFavorita = cor.Azul;
            cor CorFeia = cor.Vermelho;

            Console.WriteLine((cor)4);               // Mudando tipo de int para string;
            Console.WriteLine((int)cor.Vermelho);   // Mudando  de string para int;*/

            //Utilizando o Enum e o Switch case !!! 
            //Sistema de opções:

            /*Console.WriteLine("Selecione as opções abaixo");
            Console.WriteLine("1- Criar\n2- Deletar\n3- Editar\n4- Listar\n5- Atualizar");
            int index = int.Parse(Console.ReadLine());
            opcao opcaoSelecionada = (opcao)index;

            switch (opcaoSelecionada)
            {
                case opcao.Criar:
                    Console.WriteLine("Você quer criar algo !");
                    break;
                case opcao.Deletar:
                    Console.WriteLine("Você quer deletar algo !");
                    break;
                case opcao.Editar:
                    Console.WriteLine("Você quer editar algo ! ");
                    break;
                case opcao.Listar:
                    Console.WriteLine("Você quer listar algo !");
                    break;
                case opcao.Atualizar:
                    Console.WriteLine("Você quer atualizar algo 1");
                    break;
                default:
                    Console.WriteLine("Opção indisponível");
                    break; 
            }*/

            // Estrutura de Repetição While !;

            //While siginifica enquanto, enquanto uma condição for verdadeira executa o código e se parece com o IF;
            // Se a condição for verdadeira roda infinitamente;0

            /* int Contador = 0;
             while (Contador < 20)
             {
                 Console.WriteLine(Contador + 1);
                 Console.WriteLine("While sendo Executado !");

                 //Contador = Contador + 1;   Forma de somar váriavel +1
                 //Contador += 1;             Forma mais rápida para somar váriavel +1
                 Contador++;
             }*/

            // Console.WriteLine("Fim !");

            // Usando forma de Subtração no While;

            /* int contando = 10;
             while (contando > 5)
             {
                 Console.WriteLine(contando -6);
                 Console.WriteLine("Digitando Contando");
                 contando--; 
             }

             // Do While
             // praticamente igual ao While com uma única diferença, o Do while roda pelo menos uma vez uma condição falsa;

             int contando2 = 0;
             do
             {
                 Console.WriteLine(contando2 + 1);
                 Console.WriteLine("Do While Rodando");          // Mesma coisa do While no Do While;
                 contando2++;
             } while (contando2 < 10);
             */

            // Estrutura de repetição Foreach, o Foreach serve para percorrer Arrays;
            // Foreach: Util quando se trabalha com Arrays;

            /*  string[] nomes = { "Eduardo", "Lívia", "Raquel", "Rodrigo" };

              foreach (string nome in nomes) // Para cada item no Array nomes, repita o boloco de código; 
              {
                 // Console.WriteLine("Foreach Rodando !");
                  Console.WriteLine(nome);
              }

              int[] numeros = { 1, 2, 3, 4, 5 };

              foreach (int num in numeros)
              {
                  Console.WriteLine("Foreach ativo");
                  //Console.WriteLine(num);
              } */

            //Outra estrutura de repetição;
            // For é a forma mais simples de codificar o que o While, Do While e o Foreach também faz;
            // Prático para trabalhar com Arrays, pelo fato de poder trabalhar com Arrays na ordem decrescente também;

            /*string[] paises = { "BRASIL", "ARGENTINA", "FRANÇA", "ALEMANHA", "ESPANHA" };

            for (int contador = 0; contador <paises.Length; contador++) // Length diz o tamamnho de todo Array;
            {
                Console.WriteLine(contador);
                Console.WriteLine(paises[contador]); 
                //Console.WriteLine("Rodando For !");
            }

            Console.WriteLine("==========================="); // Para dar Espaço entre as operações;

            for (int contador2 = paises.Length-1; contador2 >= 0; contador2--) // Poderia ser -1 ou >=0, ambos decrementam a ordem dos Arrays;
            {
                Console.WriteLine(contador2);
                Console.WriteLine(paises[contador2]);
            }*/

            //Recapitulando Funções novamente;
            //A função exibe todas as mensagens dispostas já dentro dela no Console;
            // ExibirMsg();

            //Escopo: Criação de váriaveis dentro de uma Funções e suas ligações;
            //Escopo Local: quando você cria uma váriavel dentro de uma função e está váriavel pertence apenas a essa função;
            //Escopo Global: Class Program, neste contexto é o Escopo Global e toda váriavel que crio dentro de Class Program pode ser usada denttro de qualquer função do Programa;

            //string Meunome = "Eduardo Rezende"; // Váriavel com Escopo Local;
            //Console.WriteLine(Meunome);

            //Console.WriteLine(NomeCompleto); // ---> Váriavel com escopo Global; 
            //Console.WriteLine("Hello World !");

            //ExibirMsg();

            Console.ReadLine();
        }

        // Funções servem para armezar um trecho de código que você quer reutilizar várias vezes em seu projeto !;

        // Escopo Local: quando você cria uma váriavel dentro de uma função e esta váriavel pertence apenas aquela função;
       
        // Void é um tipo de retorno de uma função que NÃO possui retorno;

        // retorno em função é um valor que ira retornar ao fim da função;

        //Criando uma Função:;

          static void ExibirMsg()
          {
            Console.WriteLine(NomeCompleto);
            Console.WriteLine("Esse sistema é maneiro!;");
            Console.WriteLine("I'm using functions");
            Console.WriteLine("Bem vindos!;");
            Console.WriteLine("Eu odeio o Insert");
            Console.WriteLine("Irei me tornar um Dev");
          }

          // Parametro é um tipo de variavel, possui diferença que só pode ser usado dentro da função que você criou; parametros são separados por vírgulas;
          static void Loja(int preco, string nome)
          {
              Console.WriteLine("Nome do produto é: " + nome);
              Console.WriteLine("Preço é: " + preco);

          }

        //Calc é uma pequena formula (um exemplo), de um calculo que uma empresa faz para descobrir o valor final de seus produtos;

        // Abs = Modulo que é uma função que extrai um valor positivo de um número, assim impedindo um suposto preço negativo;
        static void Calc(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Exiba o valor final ! " + valorFinal);

        }

        //Return só pode ser feito dentro de funções;
        // Mudei de Void para Int para possuir Retorno e caso defino meu retorno como int = inteiro, não posso atribuir um valor de string, texto por exemplo;
        // todo código abaixo de return é nulo;

        static int somar(int a, int b, int c)
        {
            int resultadofin = a + b + c;
            return resultadofin;
        }
    }
}
