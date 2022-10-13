using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Strategy.Abstraction;

namespace DesignPatterns.Strategy;

/// <summary>
/// Контекст хранит ссылку на объект конкретной стратегии, работая с ним через общий интерфейс стратегий.
/// Во время выполнения программы контекст получает вызовы от клиента и делегирует их объекту конкретной стратегии.
/// </summary>
public class CompressionContext
{
    private ICompression Compression;

    public CompressionContext(ICompression compression)
    {
        Compression = compression;
    }

    public void SetStrategy(ICompression compression)
    {
        Compression = compression;
    }
    public void CreateArchive(string compressedArchiveFileName)
    {
        Compression.CompressionFolder(compressedArchiveFileName);
    }
}

