using System;

namespace ConsoleSharp{

    class ConsoleSharp{

        //SEGUNDA PARTE

        //public static void ExibirMensagem(){

        //    Console.WriteLine("Isso é chamar um método sem retorno, você só deve chamar o nome do método ou");
        //    Console.WriteLine("Função e depois abrir Paranteses, pois é uma função :v ");

        //}

        //public static string RetornarString() {

        //    string texto = "E é assim que se chama uma função ou método com Retorno, voçê deve dá um retorno" + "\t" + "com o mesmo tipo do tipo do metódo que criou.";

        //    return texto;
        //}


        //TERCEIRA PARTE
        //static void ImprimirValor(decimal valor, string msg) {
        //    // numa Função paramentada, tudo se resolve e é executado dentro dela
        //    //ou seja, há ela é dada os valores das suas variáveis pelo método principal e nela é feito
        //    //todo o trabalho.
        //    //Console.WriteLine(valor);
        //    //Console.WriteLine(msg);
        //    Console.WriteLine(msg + valor);

        //}

        //static void SomarDez(int valor) {

        //    valor += 20;
        //    Console.WriteLine(valor);

        //}

        static void Main(){

            //QUARTA PARTE
            //Criado modificando os originais do Objeto.
            Pessoa guy = new Pessoa();

            guy.Nome = "Matheus";
            guy.Sobrenome = "Carneiro";
            guy.Idade = 18;
            guy.Sexo = 'M';

            //guy.Falar("Olá eu sou o " + guy.nome + " " + guy.sobrenome);
            //guy.Falar("Tenho " + guy.idade);

            //deve ser feito assim, q fica melhor e mais ELEGANTE KKK 

            guy.Idade = -14;

            guy.Falar(String.Format("Olá eu sou o {0} {1}, tenho {2} anos", guy.Nome, guy.Sobrenome, guy.Idade));

            ////Chamando os Originais do Objeto.
            //guy = new Pessoa();

            //guy.Falar(String.Format("Olá eu sou o {0} {1}, tenho {2} anos", guy.Nome, guy.sobrenome, guy.idade));

            //Console.ReadLine();

            ////TERCEIRA PARTE 
            ////a chamada da função SomarDez, executa a soma na própria função e não altera a váriavel
            ////mas por causa que foi feito por PASSAGEM DE PARAMETRO POR VALOR.
            ////ou seja, ele só copia o que tem na variável e utiliza-se dessa para fazer suas mudanças.
            ////Se Caso eu qra mudar a variável que estava no Main, então eu devo utilizar a palavra reservada
            ////"ref" tanto no parametro da função como no local do código onde voçê vai mexer.
            //int valorInicial = 20;
            //SomarDez(valorInicial);

            //Console.WriteLine(valorInicial);


            //SEGUNDA PARTE

            //decimal num = 101.03m;

            //ImprimirValor(num, "Olhae o número : ");

            //ExibirMensagem();

            //string retornada = RetornarString();

            //Console.WriteLine(retornada);



            //PRIMEIRA PARTE

            //int matricula = 777;
            //string nome = "J.A.R.V.I.S.";
            //string sobrenome = "Stark";
            ////variavel q serve para medir tempo, tem uma infinidade de formas de se utilizar
            //DateTime aniversario = DateTime.Now;
            ////variavel q serve para mostrar numeros quebrados, é como um float. mas ainda não sei a diferença
            //decimal salario = 1100.50m;
            //bool feriasVencidas = true;
            //char sexo = 'M';

            //Console.WriteLine("Hello, young!");
            //Console.WriteLine("My name is :", nome );
            ////forma elegante de se escrever contatenar mais de uma string
            ////poderia ter sido feita só /Console.WriteLine("My name is " + name + " " + sobrenome);
            //Console.WriteLine(string.Format("{0} {1}", nome, sobrenome));

            // o operador de incremento ++, adiciona de 1 em 1, 
            //já o +=, incrementa de acordo com o valor ali escrito.

            //int a = 15;
            //int b = 2;

            //a += 5;
            //Console.WriteLine(a);


            //ma utilização da estrutura de decisão IF , sempre lembrar q se somente houver um
            //comando para ser executado pode ser ecrita sem a necessidade de chaves
            //porém, contudo, se houver mais de um comando deve-se obrigatoriamente usar chaves.

            //na utilização do mecanismo de decisão, ou estrutura de decisão Switch
            //quando se utiliza um caso dentro de outro, ou seja em sequência, ele irá executar 
            //o caso final descrito para todos.

            //int idade = 10;

            //switch (idade){

            //    case 7:
            //    case 8:
            //    case 9:
            //    case 10: Console.WriteLine("Tá vivo!!");
            //        break;
            //    case 20: Console.WriteLine("Tá namorando!!!");
            //        break;
            //    default: Console.WriteLine("Tá procurando alguém");
            //        break;
            //}

        }
    }

}