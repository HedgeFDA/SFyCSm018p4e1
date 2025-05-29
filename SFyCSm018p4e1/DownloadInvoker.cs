using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFyCSm018p4e1;

/// <summary>
/// Invoker — инициатор вызова команд
/// </summary>
class DownloadInvoker
{
    /// <summary>
    /// Интерфейс обработки команд
    /// </summary>
    private IVideoCommand? videoCommand;

    /// <summary>
    /// Устанавливает исполнителя команд.
    /// </summary>
    public void SetVideoCommand(IVideoCommand _videoCommand)
    {
        videoCommand = _videoCommand;
    }

    /// <summary>
    /// Выполняет команду получения информации о видео.
    /// </summary>
    public async Task GetInfo()
    {
        if (videoCommand == null)
            throw new InvalidOperationException("Команда не установлена.");

        await videoCommand.GetInfo();
    }

    /// <summary>
    /// Выполняет команду загрузки видео в файл.
    /// </summary>
    public async Task Download()
    {
        if (videoCommand == null)
            throw new InvalidOperationException("Команда не установлена.");

        await videoCommand.Download();
    }
}
