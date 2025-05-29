using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace SFyCSm018p4e1;

/// <summary>
/// Receiver - класс реализующий обращения к YoutubeExplode
/// </summary>
class VideoRequest
{
    /// <summary>
    /// Ссылка на YouTube
    /// </summary>
    private string youtubeURL;

    /// <summary>
    /// Путь размещения загружаемого файла
    /// </summary>
    private string outputFile;

    /// <summary>
    /// Определение YoutubeExplode
    /// </summary>
    private YoutubeClient youtubeClient;

    /// <summary>
    /// Инициализирует новый экземпляр класса.
    /// </summary>
    public VideoRequest(string _url, string _outputFile)
    {
        youtubeURL      = _url;
        outputFile      = _outputFile;
        youtubeClient   = new YoutubeClient();
    }

    /// <summary>
    /// Получает информацию о видео по ссылке.
    /// </summary>
    public async Task GetInfo()
    {
        try
        {
            var video = await youtubeClient.Videos.GetAsync(youtubeURL);

            Console.WriteLine($"Видео: {video.Title}");
            Console.WriteLine($"Продолжительность: {video.Duration}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Не удалось получить информацию о видео: {ex.Message}");
        }
    }

    /// <summary>
    /// Загружает видео по ссылке в файл
    /// </summary>
    public async Task Download()
    {
        try
        {
            Console.WriteLine($"Загрузка в файл: {outputFile}");

            await youtubeClient.Videos.DownloadAsync(
                youtubeURL,
                outputFile,
                builder => builder.SetPreset(ConversionPreset.UltraFast)
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при загрузки видео: {ex.Message}");
        }
    }
}

