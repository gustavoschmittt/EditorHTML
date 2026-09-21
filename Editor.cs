using System;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("--MODO EDITOR--");
            Console.WriteLine("---------------");
            Start();
        }

        public static void Start()
        {
              var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }while(Console.ReadKey().Key != ConsoleKey.Escape);
            Save(file);

        }
        public static void Save(StringBuilder file)
        {
            Console.WriteLine("-----------------------");
            Console.Write("  Deseja salvar o arquivo: ");
            string? opcao = Console.ReadLine()?.Trim().ToLower();

            if(opcao == "s" || opcao == "sim")
            {
                Console.Clear();
                Console.WriteLine("Qual o caminho para salvar o arquivo: ");
                var path = Console.ReadLine() ?? string.Empty;
                try 
                {
                     using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.Write(file.ToString());
                        Console.WriteLine("Arquivo salvo com sucesso!");
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Não foi possível salvar o arquivo");
                    Thread.Sleep(2000);
                    Menu.Show();
                    return;
                }
            } else if(opcao == "n" || opcao == "nao" || opcao == "não")
            {
                Console.Clear();
                Console.WriteLine("Arquivo não salvo, retornando ao menu");
                Thread.Sleep(2000);
                Menu.Show();
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção não válida");
                Thread.Sleep(2000);
                Menu.Show();
                return;
            }
        }
    }
}