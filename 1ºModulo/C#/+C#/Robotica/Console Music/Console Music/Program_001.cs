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
            Console.WriteLine("|  1.Editor de músicas            |");
            Console.WriteLine("|  2.Reprodutor de músicas        |");
            Console.WriteLine("|  3.Reprodutor de músicas(Beep)  |");
            Console.WriteLine("|  4.Tocar agora                  |");
            Console.WriteLine("|  0.Encerrar programa            |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|_________________________________|");

            Console.Write("\nSelecione a opção desejada: ");
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao > 4 || opcao < 0)
            {
                Console.Write("Opção inválida, digite novamente: ");
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
            Console.WriteLine("|  1. Editor de músicas         |");
            Console.WriteLine("|_______________________________|");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  Dó = C1 C2 C3 C4 C5          |");
            Console.WriteLine("|  Dó# = Cs1 Cs2 Cs3 Cs4 Cs5    |");
            Console.WriteLine("|  Ré = D1 D2 D3 D4 D5          |");
            Console.WriteLine("|  Ré# = Ds1 Ds2 Ds3 Ds4 Ds5    |");
            Console.WriteLine("|  Mí = E1 E2 E3 E4 E5          |");
            Console.WriteLine("|  Fá = F1 F2 F3 F4 F5          |");
            Console.WriteLine("|  Fá# = Fs1 Fs2 Fs3 Fs4 Fs5    |");
            Console.WriteLine("|  Sol = G1 G2 G3 G4 G5         |");
            Console.WriteLine("|  Sol# = Gs1 Gs2 Gs3 Gs4 Gs5   |");
            Console.WriteLine("|  Lá = A1 A2 A3 A4 A5          |");
            Console.WriteLine("|  Lá# = As1 As2 As3 As4 As5    |");
            Console.WriteLine("|  Sí = B1 B2 B3 B4 B5          |");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  Ex: C1,C5,D2,D3              |");
            Console.WriteLine("|_______________________________|");

            Console.WriteLine("Digite a música conforme o padrão acima: \n");
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
            Console.WriteLine("|  2. Reprodutor de músicas     |");
            Console.WriteLine("|_______________________________|");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  Músicas:                     |");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  1.Stickerbrush Symphony      |");
            Console.WriteLine("|  2.To be continued            |");
            Console.WriteLine("|  3.Vegetaaaa!!!               |");
            Console.WriteLine("|  4.El Condor Pasa             |");
            Console.WriteLine("|  5.Shake it bololo            |");
            Console.WriteLine("|  6.Quem descobriu o Brasil?   |");
            Console.WriteLine("|  0.Sair                       |");
            Console.WriteLine("|_______________________________|");

            Console.Write("\nSelecione a música desejada: ");
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao > 6)
            {
                Console.Write("Digite uma opção válida: ");
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
                    ToBeContinued();
                    break;
                case 3:
                    Vegetaaaa();
                    break;
                case 4:
                    ElCondorPasa();
                    break;
                case 5:
                    ShakeItBololo();
                    break;
                case 6:
                    QuemDescobriuBrasil();
                    break;
            }
        }

        //Reprodutor beep
        static void ReprodutorBeep()
        {
            int opcao;

            do
            {
                opcao = MenuReprodutorBeep();

                if (opcao != 0)
                {
                    Console.Write("Reproduzindo...");
                    GerenciadorReprodutorBeep(opcao);
                }

            } while (opcao != 0);

        }

        static int MenuReprodutorBeep()
        {
            int opcao;

            Console.Clear();
            Console.WriteLine(" _________________________________ ");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|  3. Reprodutor de músicas(Beep) |");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|  Músicas:                       |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|  1.Beethoven                    |");
            Console.WriteLine("|  2.Song of time                 |");
            Console.WriteLine("|  3.Ballad of Windfish           |");
            Console.WriteLine("|  0.Sair                         |");
            Console.WriteLine("|_________________________________|");

            Console.Write("\nSelecione a música desejada: ");
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao > 3)
            {
                Console.Write("Digite uma opção válida: ");
            }

            return opcao;
        }

        static void GerenciadorReprodutorBeep(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    beethoven9();
                    break;
                case 2:
                    songOfTime();
                    break;
                case 3:
                    balladOfWindfish();
                    break;
            }
        }

        static void play(int time, params int[] notas)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Beep(notas[i], time);
            }
        }

        //Músicas
        static void StickerbrushSymphony()
        {
            SoundPlayer player = new SoundPlayer(@"Music\stickerbrushSysmphony.wav");
            player.Play();
        }

        static void ToBeContinued()
        {
            player = new SoundPlayer(@"Music\ToBeContinued.wav");
            player.Play();
        }

        static void Vegetaaaa()
        {
            player = new SoundPlayer(@"Music\Vegetaaaa.wav");
            player.Play();
        }

        static void ElCondorPasa()
        {
            player = new SoundPlayer(@"Music\El Condor Pasa.wav");
            player.Play();
        }

        static void ShakeItBololo()
        {
            player = new SoundPlayer(@"Music\Shake It Bololo.wav");
            player.Play();
        }

        static void QuemDescobriuBrasil()
        {
            player = new SoundPlayer(@"Music\Quem descobriu o Brasil.wav");
            player.Play();
        }

        //Músicas Beep
        static void beethoven9()
        {

            play(SEMINIMA, E1, E1, F1, G1, G1, F1, E1, D1, C1, C1, D1, E1);
            play(MINIMA, E1);
            play(COLCHEIA, D1);
            play(MINIMA, D1);

            play(SEMINIMA, E1, E1, F1, G1, G1, F1, E1, D1, C1, C1, D1, E1);
            play(MINIMA, D1);
            play(COLCHEIA, C1);

            play(SEMIBREVE, C1);

            play(SEMINIMA, E2, E2, F2, G2, G2, F2, E2, D2, C2, C2, D2, E2);
            play(MINIMA, E2);
            play(COLCHEIA, D2);
            play(MINIMA, D2);

            play(SEMINIMA, E2, E2, F2, G2, G2, F2, E2, D2, C2, C2, D2, E2);
            play(MINIMA, D2);
            play(COLCHEIA, C2);

            play(SEMIBREVE, C2);

        }

        static void songOfTime()
        {

            play(SEMINIMA, A1);
            play(MINIMA, D1);
            play(SEMINIMA, F1, A1);
            play(MINIMA, D1);
            play(MINIMA, F1);
            play(SEMINIMA, A1, C2);
            play(MINIMA, B1, G1);
            play(SEMINIMA, F1, G1);
            play(MINIMA, A1, D1);
            play(SEMINIMA, C1, E1);
            play(MINIMA, D1);

        }

        static void balladOfWindfish()
        {
            play(COLCHEIA, B2, Cs3);
            play(MINIMA + COLCHEIA, D3);
            play(COLCHEIA, B2, Cs3);
            play(MINIMA + COLCHEIA, D3);
            play(COLCHEIA, D3, A2, F2);
            play(SEMINIMA + COLCHEIA, A2);
            play(MINIMA + COLCHEIA + MINIMA, B2);
            play(COLCHEIA, B2, Cs3);
            play(COLCHEIA + MINIMA + COLCHEIA, D3);
            play(COLCHEIA, B2, D3);
            play(COLCHEIA + MINIMA + COLCHEIA, G3);
            play(COLCHEIA, G3, E3);
            play(COLCHEIA + SEMIBREVE, Fs3);
            play(SEMINIMA, 37);
            play(SEMINIMA, Cs4, B3, Fs3);
            play(SEMINIMA + COLCHEIA, Fs3);
            play(COLCHEIA + MINIMA + SEMINIMA + COLCHEIA, G3);
            play(COLCHEIA, E4, D4, Cs4, B3, Fs3, E3, Fs3, B3);
            play(COLCHEIA + SEMINIMA, G3);
            play(COLCHEIA, G3);
            play(COLCHEIA + MINIMA, A3);
            play(COLCHEIA, C3, E3, A3);
            play(COLCHEIA + MINIMA, Fs3);
            play(SEMINIMA, 37);
            play(COLCHEIA, D3);
            play(COLCHEIA + MINIMA + SEMINIMA, B3);
            play(SEMINIMA, 37);
            play(SEMINIMA + COLCHEIA, B3);
            play(SEMINIMA + COLCHEIA, G4);
            play(SEMIBREVE, Fs4);

        }

        //Tocar
        static void Tocar()
        {
            Console.Clear();

            Console.WriteLine("Em desenvolvimento");
            Console.ReadKey();

        }

    }
}
