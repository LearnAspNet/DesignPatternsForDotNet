using DesignPatterns.Strategy.Abstraction;

namespace DesignPatterns.Strategy.ConcreteService;

/// <summary>
/// Конкретные стратегии реализуют различные вариации алгоритма.
/// </summary>
public class ZipCompression : ICompression
{
    public void CompressionFolder(string path)
    {
        Console.WriteLine($"Folder is compressed using Rar approach: ' {path}.zip' file is created");
    }
}

