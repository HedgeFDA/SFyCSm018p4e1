using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFyCSm018p4e1;

/// <summary>
/// Интерфейс обработки команд.
/// </summary>
interface IVideoCommand
{
    /// <summary>
    /// Команда получения информации о видео.
    /// </summary>
    Task GetInfo();

    /// <summary>
    /// Команда загрузки видео в файл.
    /// </summary>
    Task Download();
}