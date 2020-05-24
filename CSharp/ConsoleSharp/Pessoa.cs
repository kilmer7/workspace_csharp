using System;

namespace ConsoleSharp{
      // QUINTA PARTE
    class Pessoa{
        //encapsulamento
       private string nome;
       //método get - ele vai retornar o valor referente ao contéudo dessa variável.
       //método set - ele vai atribuir o valor a essa propriedade.
       //sempre é criada com o mesmo nome da variável a qual representa, mas, com o início em maiúsculo.
       public string Nome {
            get { return nome; }
            set { nome = value; }
            //value é a palavra reservada no C#, para se atribuir valores a uma variável privada.
        }

        public string Sobrenome{

            get {

                return sobrenome;

            }

            set{

                sobrenome = value;

            }
        }

        public int Idade{

            get{

                return idade;

            }

            set{
                if(value >= 0)
                    idade = value;

            }
        }

        public char Sexo{

            get{

                return sexo;

            }

            set{

                sexo = value;

            }
        }

        private string sobrenome;
       private int idade;
       // as variáveis do tipo char, eles devem ser identificadas por aspas simples ( '' ).
       private char sexo;

        //Construtor da classe que criei :)
        public Pessoa(){

            //eu posso definir valor as variáveis aqui, sendo que sempre q eu alterar no principal
            //elas mudam, mas apartir do momento que eu crio uma nova chamada ao objeto
            //elas voltam a valer para ele

            nome = "kilmer";
            Sobrenome = "Sousa";
            Idade = 20;
            Sexo = 'M';

        
        }

        //classes do meu Objeto, eu posso ter mais de ma classe com o mesmo nome, contanto que
        //tenham paramêtros diferentes.
        public void Falar(string msg){

            Console.WriteLine(msg);

        }

        public void Falar(int num){

            Console.WriteLine(num);

        }

    }
}
