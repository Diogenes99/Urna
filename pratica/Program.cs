using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using static System.Net.Mime.MediaTypeNames;

namespace pratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //olá mundo:
            //Console.WriteLine("Olá, Mundo!");

            //data types:

            //int y = 10;
            //int x = 20;
            //int z = 30;
            //melhor método:
            //int y = 10,
            //    x = 20,
            //    z = 30;

            //int idade = 24;
            //Console.WriteLine(idade);
            //string txtNumeroGrande = "9999999999";
            //long numeroGrande = Convert.ToInt64(txtNumeroGrande);
            //Console.WriteLine(numeroGrande);
            //Console.WriteLine(long.MaxValue);
            //Console.WriteLine(long.MinValue);

            //string txtNegativo = "-55.2";
            //double negativo = Convert.ToDouble(txtNegativo);
            //Console.WriteLine(negativo);
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(double.MinValue);

            //string txtPrecisao = " 5.000001";
            //float precisao = Convert.ToSingle(txtPrecisao);
            //Console.WriteLine(precisao);
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(float.MinValue);

            //string txtDinheiro = "14.99";
            //decimal dinheiro = Convert.ToDecimal(txtDinheiro);
            //Console.WriteLine(dinheiro);
            //Console.WriteLine(decimal.MaxValue);
            //Console.WriteLine(decimal.MinValue);

            //string nome = "teste";
            //char letra = 'a';

            //Console.Write("Seu nome é ");
            //Console.Write(nome);
            //Console.WriteLine(letra);

            //string txtIdade = "-24";
            //int idade = Convert.ToInt32(txtIdade);
            //Console.WriteLine(idade);

            // valores booleanos:
            //bool isMale = false;
            //Console.WriteLine(isMale);
            //isMale = true;
            //Console.WriteLine(isMale);

            // operadores matemáticos:
            //int age = 24;

            // mesma operação, diferentes métodos:
            //age++;
            //age = age + 1;
            //age += 1;
            //Console.WriteLine(age);

            // quando for dividir algum número decimal, sempre use double:
            //double numero = 23;
            //numero /= 10;// no int = 2.3 -> 2
            // pois ints vão sempre arrendondar o valor final da operação
            //Console.WriteLine(numero);

            // operadores também podem juntar strings:
            //string nome = "Diogenes";
            //nome += " quer ser programador!";
            //Console.WriteLine(nome);

            //int i = 0;
            //i++;
            //Console.WriteLine(++i);// o programa ira fazer a operação primeiro e imprimir o valor depois.
            //Console.WriteLine(i++);// o operação só sera feita depois do valor ter sido imprimido.

            //int firstNum = 10;
            //int secondNum = 3;
            //Console.WriteLine(firstNum / secondNum); //sombra 1
            // 10 / 3 = 3r1
            // 3 x 3 = 9, faltando 1 para chegar em 10
            // para pegar a sobra usamos o %
            //Console.WriteLine(firstNum % secondNum);

            // 10 % 2 = 0
            // 11 % 2 = 1
            // 12 % 2 = 0
            // 13 % 2 = 1

            // o "var" sempre se define atraves do valor que você o atribui
            // se for definido como um valor de 64 bits, irá se comportar como tal
            // não é recomendavel usa-lo para tudo, pois pode comprometer a compreesão do código.
            //var idade = 23;
            //Console.WriteLine(idade);

            //var bigNumber = 9000000L;
            //Console.WriteLine(bigNumber);

            // usando constantes para resolver problemas:
            //const int vat = 20;
            //const double percentVAT = vat / 100D;

            //int balance = 1000;
            //Console.WriteLine(balance * (vat / 100D));
            //Console.WriteLine(balance * percentVAT);

            //string nome = "Diogenes";
            /*int numero = 0123456789;*/ // não irá guardar o número 0 ao imprimir no console
                                         //string numero = "0123456789";
                                         //int idade = 24;

            //Console.WriteLine(nome);
            //Console.WriteLine(numero);
            //Console.WriteLine(idade);


            //int num1 = 10;
            //int num2 = 2;

            //int remainder = num1 % num2;
            //Console.WriteLine(remainder);

            //num1 = 11;
            //remainder = num1 % num2;
            //Console.WriteLine(remainder);

            //console input:
            //Console.Write("Escreva seu nome: ");
            //string nome = Console.ReadLine();
            //Console.WriteLine(nome);

            //Console.Write("Escreva sua idade: ");
            //int idade = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(idade);

            //Console.Write("Seu nome é ");
            //Console.Write(nome);
            //Console.Write("e sua idade é ");
            //Console.Write(idade);
            // mesma operação, melhor método:

            //Console.WriteLine();

            //Console.WriteLine("Seu nome é " + nome + " e sua idade é " + idade);
            /*
            //if statements:
            Console.Write("Escreva seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Escreva sua idade: ");
            string idadeInput = Console.ReadLine();
            int idade = Convert.ToInt32(idadeInput);

            Console.WriteLine("Seu nome é " + nome + " e sua idade é " + idade);
            
            
           

            if(idade < 0 || idade > 120)
            {
                Console.WriteLine("idade inválida");
            }
            else
            {
                if (idade >= 18 && idade <= 25)
                {
                    Console.WriteLine("você tem entre 18 e 25");
                }
                else if (idade >= 26)
                {
                    Console.WriteLine("você tem 26");
                }
            }
             

            Console.WriteLine("primeiro numero: ");
            int numeroA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("segundo numero: ");
            int numeroB = Convert.ToInt32(Console.ReadLine());

            int resposta = numeroA * numeroB;

            Console.WriteLine("o valor do número " + numeroA + "x" + numeroB + ": ");
            string respostaInput = Console.ReadLine();
            int respostaOriginal = Convert.ToInt32(respostaInput);

            if(resposta == respostaOriginal)
            {
                Console.WriteLine("parabéns");
            }
            else
            {
                Console.WriteLine("errado");
            }
            

            //switch:
            Console.WriteLine("o dia da semana: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1: Console.WriteLine("segunda");
                    break;
                case 2: Console.WriteLine("terça");
                    break;
                case 3: Console.WriteLine("quarta");
                    break;
                case 4: Console.WriteLine("quinta");
                    break;
                case 5: Console.WriteLine("sexta");
                    break;
                case 6: Console.WriteLine("sabado");
                    break;
                case 7: Console.WriteLine("domingo");
                    break;
                default: Console.WriteLine("inválido");
                    break;
            }
            */

            //loops:
            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i");
            }
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            

            Console.Write("o que você quer dizer? ");
            string menssagem = Console.ReadLine();
            Console.Write("quantas vezes repetir: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());
            

            if (loopCounter <= 0)
            {
                Console.WriteLine("inválido");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(menssagem);
                }
            }
            
            //while loops:

            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine("olá");
            }
            */
            /*
            Console.WriteLine("primeiro numero: ");
            int numeroA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("segundo numero: ");
            int numeroB = Convert.ToInt32(Console.ReadLine());

            int resposta = numeroA * numeroB;
            int respostaOriginal = 0;

            Console.WriteLine("o valor do número " + numeroA + "x" + numeroB + ": ");

            /*
            while (resposta != respostaOriginal)
            {
                Console.Write("sua resposta? ");
                string respostaInput = Console.ReadLine();
                respostaOriginal = Convert.ToInt32(respostaInput);
                if (resposta != respostaOriginal)
                {
                    Console.WriteLine("errado");
                }
            }
            Console.WriteLine("parabéns");
            */

            //do while loops:
            /*
            do
            {
                Console.Write("sua resposta? ");
                string respostaInput = Console.ReadLine();
                respostaOriginal = Convert.ToInt32(respostaInput);

                if (resposta != respostaOriginal)
                {
                    Console.WriteLine("errado");
                }
            }
            while (resposta != respostaOriginal);
            Console.WriteLine("parabéns");
            */

            /*
            //operador condicinal:
                //sem OC:
            int age = -1;

            if (age >= 0)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }

            // com OC:

            string result = age >= 0 ? "valid" : "invalid";
            Console.WriteLine(result);
            */

            // Formatação numérica:
            /*
            double value = 1000D / 12.34D;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.#}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));

            double money = -10D / 3D; //3.333333

            Console.WriteLine(money);
            //errado:
            Console.WriteLine(string.Format("-$10 / $3 = ${0:0.00}", money));
            //correto:
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", 
                            CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", 
                            CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(money.ToString("C",
                            CultureInfo.CreateSpecificCulture("en-US")));
            */

            // TryParse function:
            /*
            bool success = true;
            while (success)
            {
                Console.Write("coloque um número: ");
                String numInput = Console.ReadLine();

                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("coloque um número válido");
                }
            }
            */
            // exercicio tabela de multiplicação:
            /*
            Console.Write("coloque um número: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",i, number, i * number);
            } 
            */

            // exercicio fizz buzz game:
            /*
            bool threeDiv = false;
            bool fiveDiv = false;
            for (int i = 1; i <= 15; i++) // (i = 0; i < 15: 0-14), (i = 1; i <= 15: 1-15)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;
                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("fizz buzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            */

            


            Console.ReadLine();
        }
    }
}
