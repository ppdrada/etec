using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Console_Music
{
    class Program
    {
        const int
            SEMIBREVE = 1600,
            MINIMA = SEMIBREVE / 2,
            SEMINIMA = MINIMA / 2,
            COLCHEIA = SEMINIMA / 2,
            SEMICOLCHEIA = COLCHEIA / 2;

        //primeira oitava
        const int C1 = 262, Cs1 = 277, D1 = 294, Ds1 = 311, E1 = 330, F1 = 349, Fs1 = 370, G1 = 392, Gs1 = 415, A1 = 440, As1 = 466, B1 = 493;
        //segunda oitava
        const int C2 = 523, Cs2 = 554, D2 = 587, Ds2 = 622, E2 = 659, F2 = 698, Fs2 = 740, G2 = 784, Gs2 = 830, A2 = 880, As2 = 932, B2 = 987;
        //terceira oitava
        const int C3 = 1046, Cs3 = 1108, D3 = 1174, Ds3 = 1244, E3 = 1318, F3 = 1396, Fs3 = 1480, G3 = 1568, Gs3 = 1661, A3 = 1760, As3 = 1864, B3 = 1975;
        //quarta oitava
        const int C4 = 2093, Cs4 = 2217, D4 = 2349, Ds4 = 2489, E4 = 2637, F4 = 2793, Fs4 = 2960, G4 = 3136, Gs4 = 3322, A4 = 3520, As4 = 3729, B4 = 3951;
        //quinto oitava
        const int C5 = 4186, Cs5 = 4434, D5 = 4698, Ds5 = 4978, E5 = 5274, F5 = 5587, Fs5 = 5919, G5 = 6271, Gs5 = 6644, A5 = 7040, As5 = 7459, B5 = 7902;
        static SoundPlayer player;

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                opcao = Menu();
                Gerenciador(opcao);

            } while (opcao != 0);

        }

        static int Menu()
        {
            int opcao;

            Console.Clear();

            Console.WriteLine(" _________________________________");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|             C# Vevo             |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|  1.Editor de mÃºsicas            |");
            Console.WriteLine("|  2.Reprodutor de mÃºsicas        |");
            Console.WriteLine("|  3.Reprodutor de mÃºsicas(Beep)  |");
            Console.WriteLine("|  4.Tocar agora                  |");
            Console.WriteLine("|  0.Encerrar programa            |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|_________________________________|");

            Console.Write("\nSelecione a opÃ§Ã£o desejada: ");
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao > 4 || opcao < 0)
            {
                Console.Write("OpÃ§Ã£o invÃ¡lida, digite novamente: ");
            }

            return opcao;
        }

        static void Gerenciador(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Editor();
                    break;
                case 2:
                    Reprodutor();
                    break;
                case 3:
                    ReprodutorBeep();
                    break;
                case 4:
                    Tocar();
                    break;
            }
        }

        //Editor
        static void Editor()
        {
            string music;

            Console.Clear();
            Console.WriteLine(" _______________________________ ");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  1. Editor de mÃºsicas         |");
            Console.WriteLine("|_______________________________|");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  DÃ³ = C1 C2 C3 C4 C5          |");
            Console.WriteLine("|  DÃ³# = Cs1 Cs2 Cs3 Cs4 Cs5    |");
            Console.WriteLine("|  RÃ© = D1 D2 D3 D4 D5          |");
            Console.WriteLine("|  RÃ©# = Ds1 Ds2 Ds3 Ds4 Ds5    |");
            Console.WriteLine("|  MÃ­ = E1 E2 E3 E4 E5          |");
            Console.WriteLine("|  FÃ¡ = F1 F2 F3 F4 F5          |");
            Console.WriteLine("|  FÃ¡# = Fs1 Fs2 Fs3 Fs4 Fs5    |");
            Console.WriteLine("|  Sol = G1 G2 G3 G4 G5         |");
            Console.WriteLine("|  Sol# = Gs1 Gs2 Gs3 Gs4 Gs5   |");
            Console.WriteLine("|  LÃ¡ = A1 A2 A3 A4 A5          |");
            Console.WriteLine("|  LÃ¡# = As1 As2 As3 As4 As5    |");
            Console.WriteLine("|  SÃ­ = B1 B2 B3 B4 B5          |");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  Ex: C1,C5,D2,D3              |");
            Console.WriteLine("|_______________________________|");

            Console.WriteLine("Digite a mÃºsica conforme o padrÃ£o acima: \n");
            music = Console.ReadLine();
            PlayText(music);

            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void PlayText(String music)
        {
            string[] notes = music.Split(',');

            for (int i = 0; i < notes.Length; i++)
            {
                int note;

                switch (notes[i])
                {
                    case "C1":
                        note = C1;
                        break;
                    case "D1":
                        note = D1;
                        break;
                    case "E1":
                        note = E1;
                        break;
                    case "F1":
                        note = F1;
                        break;
                    case "G1":
                        note = G1;
                        break;
                    case "A1":
                        note = A1;
                        break;
                    case "B1":
                        note = B1;
                        break;
                    default:
                        note = C1;
                        break;
                }

                Console.Beep(note, SEMINIMA);
            }

        }

        //Reprodutor
        static void Reprodutor()
        {
            int opcao;

            do
            {
                opcao = MenuReprodutor();

                if (opcao != 0)
                {
                    GerenciadorReprodutor(opcao);
                }

            } while (opcao != 0);

            player.Stop();

        }

        static int MenuReprodutor()
        {
            int opcao;

            Console.Clear();
            Console.WriteLine(" _______________________________ ");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  2. Reprodutor de mÃºsicas     |");
            Console.WriteLine("|_______________________________|");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  MÃºsicas:                     |");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  1.Stickerbrush Symphony      |");
            Console.WriteLine("|  2.To be continued            |");
            Console.WriteLine("|  3.Vegetaaaa!!!               |");
            Console.WriteLine("|  4.El Condor Pasa             |");
            Console.WriteLine("|  5.Shake it bololo            |");
            Console.WriteLine("|  6.Quem descobriu o Brasil?   |");
            Console.WriteLine("|  0.Sair                       |");
            Console.WriteLine("|_______________________________|");

            Console.Write("\nSelecione a mÃºsica desejada: ");
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao > 6)
            {
                Console.Write("Digite uma opÃ§Ã£o vÃ¡lida: ");
            }

            return opcao;
        }

        static void GerenciadorReprodutor(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    StickerbrushSymphony();
                    break;
                case 2:
             .           ¶ÉŒ#M#M ÊŒ#MM!    ..          ¶ÉŒ#M#M ÊŒ#M     AA p p . c  ×o n f i g     ÿÿÿÿAPP~1   CON  ˆð~#M%M ñ~#MN!»   AE d i t o  mr . c s p r   o j EDITOR~1CSP  ‹ð~#M%M I‚#MO!  AF o r m 1  J. c s   ÿÿÿÿ  ÿÿÿÿFORM1   CS   ˆð~#M%M Ž%Mr!÷  Br . c s    #ÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿF o r m 1  #. D e s i g   n e FORM1D~1CS   Šð~#M%M ø‹%Mp!i  AF o r m 1  =. r e s x     ÿÿÿÿFORM1~1 RES  €	#M%M ø‹%MP!  AF r m E d  …i t o r . c   s   FRMEDI~1CS   Àr€#M%M ±Ž%MQ!…  åH2WDUQWNWU Àr€#M%M ±Ž%MQ!…  Bi g n e r  %. c s   ÿÿÿÿ  ÿÿÿÿF r m E d  %i t o r . D   e s FRMEDI~2CS   Âr€#M%M ˜Œ%Ml!Ã5  åRMEDI~1TMP" éŠ%M%M  êŠ%M      åRMEDI~1RES  Ý#M%M µŒ#MV!“  AP r o g r  =a m . c s     ÿÿÿÿPROGRAM CS   Šð~#M%M #MW!  BIN        Œð~#M#M ñ~#MX!    OBJ        Œð~#M#M ñ~#Mi!    AP r o p e  úr t i e s     ÿÿÿÿPROPER~1    …ð~#M#M ò~#My!    Bx   ÿÿÿÿÿÿ ôÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿF r m E d  ôi t o r . r   e s FRMEDI~1RES  Ý#M%M êŠ%MV!“  åR F 7 a 0  v4 0 8 . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP" $°Ž%M%M  ±Ž%M      åR F 7 a 0  v4 0 8 . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP  Àr€#M%M  ªŽ%MU!„  åF r m E d  vi t o r . D   e s åRMEDI~1TMP  Âr€#M%M  PŒ%MQ!Ä5  åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP" ¿–˜%M%M  —˜%M      åR F 1 6 6  vd 0 5 . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP  Àr€#M%M  ˜%Ml!  åF r m E d  …i t o r . c   s   åRMEDI~1CS   Àr€#M%M —˜%Mp!  å4NM4UUMG3S Àr€#M%M n™%Mq!‹  åR F 1 c 8  vd 5 1 . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP" ‹m™%M%M  n™%M      åR F 1 c 8  vd 5 1 . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP  Àr€#M%M  —˜%Mp!  åF r m E d  …i t o r . c   s   åRMEDI~1CS   Àr€#M%M n™%Mq!‹  å3CIO14RWKB Ý#M%M ˜™%Mp!“  åP   ÿÿÿÿÿÿ vÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåx ~ R F 1  vd c 0 8 1 .   T M åF r m E d  vi t o r . r   e s åRMEDI~1TMP" —™%M%M  ˜™%M      åP   ÿÿÿÿÿÿ vÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåx ~ R F 1  vd c 0 8 1 .   T M åF r m E d  vi t o r . r   e s åRMEDI~1TMP  Ý#M%M  µŒ#MV!“  åx   ÿÿÿÿÿÿ ôÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåF r m E d  ôi t o r . r   e s åRMEDI~1RES  Ý#M%M ˜™%Mp!“  å2GDHF450AD Âr€#M%M ™™%MV!‚4  åc 8 c a .  vT M P   ÿÿÿÿ  ÿÿÿÿåi g n e r  v. c s ~ R F   1 d åF r m E d  vi t o r . D   e s åRMEDI~1TMP" ˜™%M%M  ™™%M      åc 8 c a .  vT M P   ÿÿÿÿ  ÿÿÿÿåi g n e r  v. c s ~ R F   1 d åF r m E d  vi t o r . D   e s åRMEDI~1TMP  Âr€#M%M  µŒ#MT!‚4  åi g n e r  %. c s   ÿÿÿÿ  ÿÿÿÿåF r m E d  %i t o r . D   e s åRMEDI~2CS   Âr€#M%M ™™%MV!‚4  åYSRJ43QX2V Àr€#M%M ™™%MT!‹  åR F 1 d c  v9 2 8 . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP" ˜™%M%M  ™™%M      åR F 1 d c  v9 2 8 . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP  Àr€#M%M  n™%Mq!‹  åF r m E d  …i t o r . c   s   åRMEDI~1CS   Àr€#M%M ™™%MT!‹  åYZBMXNYBZE Ý#M%M ë™%Mm!“  åP   ÿÿÿÿÿÿ vÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåx ~ R F 2  v0 1 c a 4 .   T M åF r m E d  vi t o r . r   e s åRMEDI~1TMP" Eê™%M%M  ë™%M      åP   ÿÿÿÿÿÿ vÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåx ~ R F 2  v0 1 c a 4 .   T M åF r m E d  vi t o r . r   e s åRMEDI~1TMP  Ý#M%M  ˜™%Mp!“  åx   ÿÿÿÿÿÿ ôÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåF r m E d  ôi t o r . r   e s åRMEDI~1RES  Ý#M%M ë™%Mm!“  åG4Q2RMWXLX Âr€#M%M î™%Mp!‚4  å3 3 b d .  vT M P   ÿÿÿÿ  ÿÿÿÿåi g n e r  v. c s ~ R F   2 0 åF r m E d  vi t o r . D   e s åRMEDI~1TMP" =í™%M%M  î™%M      å3 3 b d .  vT M P   ÿÿÿÿ  ÿÿÿÿåi g n e r  v. c s ~ R F   2 0 åF r m E d  vi t o r . D   e s åRMEDI~1TMP  Âr€#M%M  ™™%MV!‚4  åi g n e r  %. c s   ÿÿÿÿ  ÿÿÿÿåF r m E d  %i t o r . D   e s åRMEDI~2CS   Âr€#M%M î™%Mp!‚4  å0OUT5QEEKA Àr€#M%M î™%MV!‹  åR F 2 0 3  v4 2 a . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP" Hí™%M%M  î™%M      åR F 2 0 3  v4 2 a . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP  Àr€#M%M  ™™%MT!‹  åF r m E d  …i t o r . c   s   åRMEDI~1CS   Àr€#M%M î™%MV!‹  åPCMR5P4ZCB Ý#M%M bš%MU!“  åP   ÿÿÿÿÿÿ vÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåx ~ R F 2  v3 8 4 1 d .   T M åF r m E d  vi t o r . r   e s åRMEDI~1TMP" ²aš%M%M  bš%M      åP   ÿÿÿÿÿÿ vÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåx ~ R F 2  v3 8 4 1 d .   T M åF r m E d  vi t o r . r   e s åRMEDI~1TMP  Ý#M%M  ë™%Mm!“  åx   ÿÿÿÿÿÿ ôÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåF r m E d  ôi t o r . r   e s åRMEDI~1RES  Ý#M%M bš%MU!“  åECUTBCMA54 Âr€#M%M eš%Mm!I4  å9 b 0 7 .  vT M P   ÿÿÿÿ  ÿÿÿÿåi g n e r  v. c s ~ R F   2 3 åF r m E d  vi t o r . D   e s åRMEDI~1TMP" ¦dš%M%M  eš%M      å9 b 0 7 .  vT M P   ÿÿÿÿ  ÿÿÿÿåi g n e r  v. c s ~ R F   2 3 åF r m E d  vi t o r . D   e s åRMEDI~1TMP  Âr€#M%M  î™%Mp!‚4  åi g n e r  %. c s   ÿÿÿÿ  ÿÿÿÿåF r m E d  %i t o r . D   e s åRMEDI~2CS   Âr€#M%M eš%Mm!I4  åFWQE0JRREX Àr€#M%M eš%Mp!‹  åR F 2 3 a  v3 1 2 . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP" ¬eš%M%M  fš%M      åR F 2 3 a  v3 1 2 . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP  Àr€#M%M  î™%MV!‹  åF r m E d  …i t o r . c   s   åRMEDI~1CS   Àr€#M%M eš%Mp!‹  åIS1ZKNF5KN Ý#M%M Nƒ%MV!“  åP   ÿÿÿÿÿÿ vÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåx ~ R F 2  va 4 6 f e .   T M åF r m E d  vi t o r . r   e s åRMEDI~1TMP" ?Mƒ%M%M  Nƒ%M      åP   ÿÿÿÿÿÿ vÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåx ~ R F 2  va 4 6 f e .   T M åF r m E d  vi t o r . r   e s åRMEDI~1TMP  Ý#M%M  bš%MU!“  åx   ÿÿÿÿÿÿ ôÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåF r m E d  ôi t o r . r   e s åRMEDI~1RES  Ý#M%M Nƒ%MV!“  åEXA513FYCX Âr€#M%M Oƒ%MU!ð4  å4 f 4 8 .  vT M P   ÿÿÿÿ  ÿÿÿÿåi g n e r  v. c s ~ R F   2 a åF r m E d  vi t o r . D   e s åRMEDI~1TMP" KNƒ%M%M  Oƒ%M      å4 f 4 8 .  vT M P   ÿÿÿÿ  ÿÿÿÿåi g n e r  v. c s ~ R F   2 a åF r m E d  vi t o r . D   e s åRMEDI~1TMP  Âr€#M%M  eš%Mm!I4  åi g n e r  %. c s   ÿÿÿÿ  ÿÿÿÿåF r m E d  %i t o r . D   e s åRMEDI~2CS   Âr€#M%M Oƒ%MU!ð4  å3ZZV4CRT0X Àr€#M%M Oƒ%Mm!‹  åR F 2 a 5  v7 6 3 . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP" ROƒ%M%M  Pƒ%M      åR F 2 a 5  v7 6 3 . T M   P   åF r m E d  vi t o r . c   s ~ åRMEDI~1TMP  Àr€#M%M  eš%Mp!‹  åF r m E d  …i t o r . c   s   åRMEDI~1CS   Àr€#M%M Oƒ%Mm!‹  åRAJYV2S2HF Ý#M%M Éƒ%Mp!“  åP   ÿÿÿÿÿÿ vÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåx ~ R F 2  vd c c 7 3 .   T M åF r m E d  vi t o r . r   e s åRMEDI~1TMP" Èƒ%M%M  Éƒ%M      åP   ÿÿÿÿÿÿ vÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåx ~ R F 2  vd c c 7 3 .   T M åF r m E d  vi t o r . r   e s åRMEDI~1TMP  Ý#M%M  Nƒ%MV!“  åx   ÿÿÿÿÿÿ ôÿÿÿÿÿÿÿÿÿÿÿÿ  ÿÿÿÿåF r m E d  ôi t o r . r   e s åRMEDI~1RES  Ý#M%M Éƒ%Mp!“  å1T2H3OLFAW Âr€#M%M Êƒ%MV!–5  åd 4 a d .  vT M P   ÿÿÿÿ  ÿÿÿÿåi g n e r  v. c s ~ R F   2 d åF r m E d  vi t o r . D   e s åRMEDI~1TMP" —Éƒ%M%M  Êƒ%M      åd 4 a d .  vT M P   ÿÿÿÿ  ÿÿÿÿåi g n e r  v. c s ~ R F   2 d åF r m E d  vi t o r . D   e s åRMEDI~1TMP  Âr€#M%M  Oƒ%MU!ð4  åi g n e r  %. c s   ÿÿÿÿ  ÿÿÿÿåF r m E d  %i t o r . D   e s åRMEDI~2CS   Âr€#M%M Êƒ%MV!–5  åAIULFX3RHZ Àr€#M%M Êƒ%MU!‹  åR F 2 d 