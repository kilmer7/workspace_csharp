using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Encapsulamento{
    class MyTextBox{

        private Color Cor; //Variável que receberar a cor do fundo atual...
        private bool numeric; //Variável utilizada para determinar se a caixa de texto 
                              //deve aceitar letras ou números.

       public bool Numeric {

            get {

                return numeric;

            }

            set {

                numeric = value;

            }

        }

        //Um Override do método OnKeyPress() responsável pelo tratamento das teclas pressionadas.

        protected override void OnKeyPress(KeyPressEventArgs e) {

            if (!numeric) {

                base.OnKeyPress(e);//Executa a operação padrão para o tratamento da tecla.
                return;//Encerra o método sem executar as instruções restantes.

            }

            if (char.IsNumber(e.KeyChar)) e.KeyChar.ToString() == "\b" {
                // "\b" = Backspace
                base.OnKeyPress(e);//Se for número executa a operação padrão 

            } else {

                e.Handled = true;//Se for letra impede a sua entrada através do manipulador (Handled)

            }

        }
        

        protected override void OnGotFocus(EventArgs e) {

            base.OnGotFocus(e);//Executa as operações padrão  
            Cor = this.BackColor;//Define a váriavel Cor com a atual cor de fundo (BackColor)
            this.BackColor = Color.AliceBlue;//muda a cor do fundo para azul-claro(AliceBlue)

        }


        protected override void ONLostFocus(EventArgs e) {

            base.OnLostFocus(e);//Executa as operações padrão
            this.BackColor = Cor;//Muda a cor do fundo de volta para a cor original

        }

    }
}
