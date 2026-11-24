namespace Abstraction.Models;

interface IStorage
{
    void Upload(string fileName);

    void Download(string fileName);

    long GetAvailableSpace();
}

abstract class StorageInfo
{
    public abstract long GetAvailableSpace();

    public static void RunTest()
    {
        IStorage[] storages =
        {
            new CloudStorage(),
            new UsbStorage(),
            new MemoryCardStorage()
        };

        foreach (IStorage storage in storages)
        {
            Console.WriteLine($"Tekshiruv: {storage.GetType().Name}");
            storage.Upload("course.zip");
            storage.Download("course.zip");
            Console.WriteLine($"Bo'sh joy: {storage.GetAvailableSpace()} bayt");
            Console.WriteLine();
        }
    }
}

class CloudStorage : StorageInfo, IStorage
{
    public void Upload(string fileName)
    {
        Console.WriteLine($"Cloudga {fileName} yuklandi");
    }

    public void Download(string fileName)
    {
        Console.WriteLine($"Clouddan {fileName} olindi");
    }

    public override long GetAvailableSpace()
    {
        return 100L * 1024 * 1024 * 1024;
    }
}

class UsbStorage : StorageInfo, IStorage
{
    public void Upload(string fileName)
    {
        Console.WriteLine($"USBga {fileName} yuklandi");
    }

    public void Download(string fileName)
    {
        Console.WriteLine($"USBdan {fileName} olindi");
    }

    public override long GetAvailableSpace()
    {
        return 32L * 1024 * 1024 * 1024;
    }
}

class MemoryCardStorage : StorageInfo, IStorage
{
    public void Upload(string fileName)
    {
        Console.WriteLine($"Xotira kartasiga {fileName} yuklandi");
    }

    public void Download(string fileName)
    {
        Console.WriteLine($"Xotira kartasidan {fileName} olindi");
    }

    public override long GetAvailableSpace()
    {
        return 64L * 1024 * 1024 * 1024;
    }
}
