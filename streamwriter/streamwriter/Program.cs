using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace streamwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Asatryan\Desktop";
            string fileName = $@"{path}\txt.txt";
            // Создаем файл в текущем каталоге.
            var stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // Записываем байты в файл.
            for (int i = 0; i < 256; i++)
            {
                stream.WriteByte((byte)i);
            }

            Console.WriteLine(stream.Position);
            // Переставляем внутренний указатель на начало.
            stream.Position = 0;

            // Считывам байты из файла.
            for (int i = 0; i < 256; i++)
            {
                int value = stream.ReadByte();
                Console.Write(" " + value);
            }

            // Закрываем FileStream. 
            stream.Close();

            // Delay.
            Console.ReadKey();
        }
    }
}
