using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFyCSm018p4e1;

/// <summary>
/// Command - реализация интерфейса обработки команд
/// </summary>
class DownloadCommand : IVideoCommand
{
    /// <summary>
    /// Обработчик команд
    /// </summary>
    private VideoRequest videoRequest;

    /// <summary>
    /// Инициализирует новый экземпляр класса.
    /// </summary>
    public DownloadCommand(VideoRequest _videoRequest)
    {
        this.videoRequest = _videoRequest;
    }

    /// <summary>
    /// Получает информацию о видео по ссылке.
    /// </summary>
    public async Task GetInfo()
    {
        await videoRequest.GetInfo();
    }

    /// <summary>
    /// Загружает видео по ссылке в файл
    /// </summary>
    public async Task Download()
    {
        await videoRequest.Download();
    }
}
