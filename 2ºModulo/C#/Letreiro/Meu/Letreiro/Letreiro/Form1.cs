using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Letreiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int anda = 0;

        //Metodo privado que nela tem todas Letras que estão cada uma indivialmente num vetor respectivamente na sua letra correspondente
        private byte[,] Vetores(char var)
        {

           byte[,] vValor = new byte[,] {
                    {0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0}
                 };

            if(var == 'a' || var == 'A')
            {
                vValor = new byte[,] {
                    {0,0,0,1,1,0,0},
                    {0,0,1,0,0,1,0},
                    {0,1,0,0,0,0,1},
                    {0,1,1,1,1,1,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1}
                };
                return vValor;
            }
            if (var == 'b' || var == 'B')
            {
                vValor = new byte[,] {
                    {0,1,1,1,1,1,0},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,1,1,1,1,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,1,1,1,1,0}
                };
                return vValor;
            }

            if (var == 'c' || var == 'C')
            {
                vValor = new byte[,] {
                    {0,0,1,1,1,1,1},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,0,1,1,1,1,1}
                };
                return vValor;
            }

            if (var == 'd' || var == 'D')
            {
                vValor = new byte[,] {
                    {0,1,1,1,1,0,0},
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,1,0}, 
                    {0,1,1,1,1,0,0} 
                };
                return vValor;
            }

            if (var == 'e' || var == 'E')
            {
                vValor = new byte[,] {
                    {0,1,1,1,1,1,1},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,1,1,1,1,0,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0}, 
                    {0,1,1,1,1,1,1} 
                };
                return vValor;
            }

            if (var == 'f' || var == 'F')
            {
                vValor = new byte[,] {
                    {0,1,1,1,1,1,1},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,1,1,1,1,1,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0}, 
                    {0,1,0,0,0,0,0} 
                };
                return vValor;
            }

            if (var == 'g' || var == 'G')
            {
                vValor = new byte[,] {
                    {0,0,1,1,1,1,1},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,1},
                    {0,1,0,1,1,1,1},
                    {0,1,0,0,0,0,1},
                    {0,0,1,1,1,1,1} 
                };
                return vValor;
            }

            if (var == 'h' || var == 'H')
            {
                vValor = new byte[,] {
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,1,1,1,1,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1}, 
                    {0,1,0,0,0,0,1} 
                };
                return vValor;
            }

            if (var == 'i' || var=='I')
            {
                vValor = new byte[,] {
                    {0,0,0,1,0,0,0},
                    {0,0,0,0,0,0,0},
                    {0,0,0,1,0,0,0},
                    {0,0,0,1,0,0,0},
                    {0,0,0,1,0,0,0},
                    {0,0,0,1,0,0,0}, 
                    {0,0,0,1,0,0,0} 
                };
                return vValor;
            }

            if (var == 'j' || var == 'J')
            {
                vValor = new byte[,] {
                    {0,1,1,1,1,1,1},
                    {0,0,0,0,1,0,0},
                    {0,0,0,0,1,0,0},
                    {0,0,0,0,1,0,0},
                    {0,1,0,0,1,0,0},
                    {0,0,1,1,0,0,0}, 
                    {0,0,0,0,0,0,0} 
                };
                return vValor;
            }
            if (var == 'k' || var == 'K')
            {
                vValor = new byte[,] {
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,1,0,0},
                    {0,1,0,1,0,0,0},
                    {0,1,1,0,0,0,0},
                    {0,1,0,1,0,0,0},
                    {0,1,0,0,1,0,0}, 
                    {0,1,0,0,0,1,0} 
                };
                return vValor;
            }

            if (var == 'l' || var == 'L')
            {
                vValor = new byte[,] {
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0}, 
                    {0,1,1,1,1,1,1}                   
                };
                return vValor;
            }

            if (var == 'm' || var == 'M')
            {
                vValor = new byte[,] {
                    {0,1,0,0,0,1,0},
                    {0,1,1,0,1,1,0},
                    {0,1,0,1,0,1,0},
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,1,0}, 
                    {0,1,0,0,0,1,0} 
                };
                return vValor;
            }

            if (var == 'n' || var == 'N')
            {
                vValor = new byte[,] {
                    {0,0,0,0,0,0,0},
                    {0,1,0,0,0,0,1},
                    {0,1,1,0,0,0,1},
                    {0,1,0,1,0,0,1},
                    {0,1,0,0,1,0,1},
                    {0,1,0,0,0,1,1},
                    {0,1,0,0,0,0,1},

                };
                return vValor;
            }

            if (var == 'o' || var == 'O')
            {
                vValor = new byte[,] {
                    {0,0,1,1,1,1,0},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,0,1,1,1,1,0},

                };
                return vValor;
            }

            if (var == 'p' || var == 'P')
            {
                vValor = new byte[,] {
                    {0,1,1,1,1,1,0},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,1,1,1,1,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                };
                return vValor;
            }

            if (var == 'q' || var == 'Q')
            {
                vValor = new byte[,] {
                    {0,0,1,1,1,1,0},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,1,0,1},
                    {0,1,0,0,0,1,0},
                    {0,0,1,1,1,0,1},
                };
                return vValor;
            }

            if (var == 'r' || var == 'R')
            {
                vValor = new byte[,] {
                    {0,0,1,1,1,1,0},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,1,1,1,1,0},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},

                };
                return vValor;
            }

            if (var == 's' || var == 'S')
            {
                vValor = new byte[,] {
                    {0,0,1,1,1,1,0},
                    {0,1,0,0,0,0,0},
                    {0,1,0,0,0,0,0},
                    {0,0,1,1,1,1,0},
                    {0,0,0,0,0,0,1},
                    {0,0,0,0,0,0,1},
                    {0,1,1,1,1,1,0},
                };
                return vValor;
            }

            if (var == 't' || var == 'T')
            {
                vValor = new byte[,] {
                    {0,1,1,1,1,1,0},
                    {0,0,0,1,0,0,0},
                    {0,0,0,1,0,0,0},
                    {0,0,0,1,0,0,0},
                    {0,0,0,1,0,0,0},
                    {0,0,0,1,0,0,0},
                    {0,0,0,1,0,0,0},

                };
                return vValor;
            }

            if (var == 'u' || var == 'U')
            {
                vValor = new byte[,] {
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,1,0,0,0,0,1},
                    {0,0,1,1,1,1,0},

                };
                return vValor;
            }

            if (var == 'v' || var == 'V')
            {
               vValor = new byte[,] {
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,1,0},
                    {0,0,1,0,1,0,0},
                    {0,0,0,1,0,0,0},

                };
                return vValor;
            }

            if (var == 'w' || var == 'W')
            {
                vValor = new byte[,] {
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,1,0},
                    {0,1,0,1,0,1,0},
                    {0,1,1,0,1,1,0},
                    {0,1,0,0,0,1,0},

                };
                return vValor;
            }
            if (var == 'x' || var == 'X')
            {
               vValor = new byte[,] {
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,1,0},
                    {0,0,1,0,1,0,0},
                    {0,0,0,1,0,0,0},
                    {0,0,1,0,1,0,0},
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,1,0},

                };
                return vValor;
            }

            if (var == 'y' || var == 'Y')
            {
                vValor = new byte[,] {
                    {0,1,0,0,0,1,0},
                    {0,1,0,0,0,1,0},
                    {0,0,1,0,1,0,0},
                    {0,0,0,1,0,0,0},
                    {0,0,0,1,0,0,0},
                    {0,0,0,1,0,0,0},
                    {0,0,0,1,0,0,0},

                };
                return vValor;
            }

            if (var == 'z' || var == 'Z')
            {
                vValor = new byte[,] {
                    {0,0,0,0,0,0,0},
                    {0,1,1,1,1,1,1},
                    {0,0,0,0,0,1,0},
                    {0,0,0,0,1,0,0},
                    {0,0,0,1,0,0,0},
                    {0,0,1,0,0,0,0},
                    {0,1,1,1,1,1,1},

                };
                return vValor;

            }
            
            return vValor;
        }

        private void pictureBox1_Click(object sender, EventArgs e, byte Vetor, char var)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void objTela_Click(object sender, EventArgs e)
        {
            
      
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string var = txtmostrar.Text;
        }
        private void objTempo_Tick(object sender, EventArgs e)
        {
            nasuabunda();
            anda++;

            if (txtmostrar.Text.Length == anda)
            {
                anda = 0;    
            }
        }
        
        public void nasuabunda()
        {

            Graphics oTela;
            int nPosLetra = anda;

            objTela.Image = new Bitmap(8000, 6000);
            oTela = Graphics.FromImage(objTela.Image);

            byte[,] letra = Vetores(txtmostrar.Text[nPosLetra]);
            while (nPosLetra < txtmostrar.Text.Length)
            {
                byte[,] Letra = Vetores(txtmostrar.Text[nPosLetra]);
                for (byte nLinha = 0; nLinha < 7; nLinha++)
                {
                    for (byte nColuna = 0; nColuna < 7; nColuna++)
                    {
                        oTela.FillEllipse(new SolidBrush(Letra[nLinha, nColuna] == 0 ? Color.Black : Color.BlueViolet), nColuna * 10 + (nPosLetra - anda) * 70, nLinha * 10, 10, 10);
                    }
                    objTela.Refresh();
                }
                nPosLetra++;
            }
        }

        private void enviar_Click_1(object sender, EventArgs e)
        {
            objTempo.Enabled = true;
        }
        //Ta uma merda falta uma muitas coisas Sorry, irá acrescentar essas coisas mas vai acabar o praso e tenho que mandar 
    }
}
