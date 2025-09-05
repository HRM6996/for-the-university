using System;
using System.IO;
using System.Drawing; // nuget пакет "System.Drawing.Common"
using System.Text;
using NAudio.Wave; //nuget пакет "NAudio"


class Bad_apple
{
    static void Main()
    {
        int width = 230;
        int height = 70;
        Console.WindowHeight = height;
        Console.WindowWidth = width;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("select color");
        Console.WriteLine("1 - white");
        Console.WriteLine("2 - yelow");
        Console.WriteLine("3 - green");
        Console.WriteLine("4 - dark green");
        Console.WriteLine("5 - red");


        string input = Console.ReadLine();
        Console.WriteLine("\u001b[2J");
        switch (input)
        {
            case "2":
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case "3":
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case "4":
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
            case "5":
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
        using (var audioFile = new AudioFileReader(@"Директория\Touhou — Bad Apple .mp3"))
        using (var outputDevice = new WaveOutEvent())

        {
            outputDevice.Init(audioFile);
            outputDevice.Play();


            string folder = @"Директория ";

            string[] frames = Directory.GetFiles(folder, "*.txt");

            frames = frames.OrderBy(f => f).ToArray();

            int frame_Delay = 1000 / 34;
            foreach (string frame in frames)
            {
                Console.SetCursorPosition(0, 0);
                string ascii = File.ReadAllText(frame);
                Console.Write(ascii);

                Thread.Sleep(frame_Delay);
            }
        }
    }
}
/* код для преобразования фоток в ASCII (написан через нейронку)
 * видео разбито на кадры с помощью ffmpeg -i "путь к видео" -vf fps=30 "папка сохранения_%04d.png"



        string inputFolder = "E:\\c#\\bad apple\\bad";
        string outputFolder = "E:\\c#\\bad apple\\bad ASCII";
        Directory.CreateDirectory(outputFolder);
        string[] files = Directory.GetFiles(inputFolder, "*.png");
        foreach (string path in files)
        {
            Console.WriteLine($"Обработка: {Path.GetFileName(path)}");

            Bitmap bmp = new Bitmap(path);

            // уменьшаем картинку (иначе будет слишком огромная)
            int newWidth = 230;
            int newHeight = 65;
            Bitmap resized = new Bitmap(bmp, new Size(newWidth, newHeight));

            string chars = "@#S%?*+;:,. ";
            StringBuilder sb = new StringBuilder();

            for (int y = 0; y < resized.Height; y++)
            {
                for (int x = 0; x < resized.Width; x++)
                {
                    Color pixel = resized.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    int index = (gray * (chars.Length - 1)) / 255;
                    sb.Append(chars[index]);
                }
                sb.AppendLine();
            }

            string outPath = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(path) + ".txt");
            File.WriteAllText(outPath, sb.ToString());

            Console.WriteLine($"Сохранено: {outPath}");
        }

        Console.WriteLine("\n✅ Все файлы конвертированы!"); 
        
            }
}
*/
