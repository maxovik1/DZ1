using System;
using System.IO;
using NAudio.Wave;
using NAudio.Lame;

namespace Mp4ToMp3Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Конвертер MP4 → MP3 (NAudio) ===");
            Console.WriteLine("Убедитесь, что файл существует и имеет поддерживаемый формат.\n");

            string inputFile, outputFile;

            if (args.Length >= 2)
            {
                inputFile = args[0];
                outputFile = args[1];
            }
            else
            {
                Console.Write("Введите полный путь к исходному видеофайлу: ");
                inputFile = Console.ReadLine();
                Console.Write("Введите полный путь для сохранения MP3: ");
                outputFile = Console.ReadLine();
            }

            if (!File.Exists(inputFile))
            {
                Console.WriteLine($"Ошибка: файл '{inputFile}' не найден.");
                return;
            }

            try
            {
                ExtractAudioFromVideo(inputFile, outputFile);
                Console.WriteLine($"\n✅ Аудио успешно извлечено в '{outputFile}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ Ошибка: {ex.Message}");
                Console.WriteLine("Убедитесь, что установлены кодеки для данного формата.");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }


        public static void ExtractAudioFromVideo(string videoFilePath, string outputMp3Path)
        {
            using (var reader = new MediaFoundationReader(videoFilePath))
            {
                using (var writer = new LameMP3FileWriter(
                    outputMp3Path,
                    reader.WaveFormat,
                    LAMEPreset.ABR_128))
                {
                    byte[] buffer = new byte[8192];
                    int bytesRead;
                    while ((bytesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        writer.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}