using EditorHTML;

namespace EditorHTML
{
    public static class Menu
    {


        public static void Show()
        {
            Console.Clear();
            Console.Clear();
            DrawScren();
            WriteOptions();

            var sucesso = short.TryParse(Console.ReadLine(), out short option);
            HandleMenuOption(option);

        }


        public static void Columns()
        {
            Console.Write("+");
            for (int coluna = 0; coluna <= 30; coluna++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
        public static void Lines()
        {
            for (int linha = 0; linha <= 10; linha++)
            {
                Console.Write("|");
                for (int espaco = 0; espaco <= 30; espaco++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }
        public static void DrawScren()
        {
            Columns();
            Lines();
            Columns();
        }

        public static void WriteOptions() 
        {
            Console.SetCursorPosition(11, 0);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("-------------------------------");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Selecione uma opção abaixos:");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("1- Novo arquivo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("2- Abrir um arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0- Sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opçaõ: ");
            Console.SetCursorPosition(3, 10);
            Console.Write("");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}

