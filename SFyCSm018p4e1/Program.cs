using System;
using System.Threading.Tasks;

namespace SFyCSm018p4e1;

internal class Program
{
    /// <summary>
    /// Процедура реализующая основной алгоритм работы программы.
    /// </summary>
    static async Task PerformMain(string youtubeURL, string outputFile)
    {
        DownloadInvoker downloadInvoker = new DownloadInvoker();
        DownloadCommand downloadCommand = new DownloadCommand(new VideoRequest(youtubeURL, outputFile));

        downloadInvoker.SetVideoCommand(downloadCommand);

        try
        {
            await downloadInvoker.GetInfo();
            await downloadInvoker.Download();

            Console.WriteLine("Загрузка завершена.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }

    /// <summary>
    /// Главная точка входа приложения
    /// </summary>
    /// <param name="args">Аргументы командной строки при запуске приложения.</param>
    static async Task Main(string[] args)
    {
        string youtubeURL = "";
        string outputFile = "";

        if (args.Length == 2)
        {
            youtubeURL = args[0];
            outputFile = args[1];
        }
        else
        {
            youtubeURL = "https://www.youtube.com/watch?v=sjgPfzsfMRI";
            outputFile = "C:\\Users\\boiko_i\\Desktop\\video.mpg";
        }

        await PerformMain(youtubeURL, outputFile);
    }
}
