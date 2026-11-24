namespace Abstraction.Models;

abstract class MediaAsset
{
    public string Title { get; set; }

    public MediaAsset(string title)
    {
        Title = title;
    }

    public abstract void Play();

    public abstract string GetFormat();

    public void ShowTitle()
    {
        Console.WriteLine($"Media: {Title}");
    }

    public static void RunTest()
    {
        MediaAsset[] assets =
        {
            new AudioAsset("Podcast"),
            new VideoAsset("Videodars"),
            new PodcastAsset("C# yangiliklari")
        };

        foreach (MediaAsset asset in assets)
        {
            asset.ShowTitle();
            Console.WriteLine(asset.GetFormat());
            asset.Play();
            Console.WriteLine();
        }
    }
}

class AudioAsset : MediaAsset
{
    public AudioAsset(string title) : base(title)
    {
    }

    public override void Play()
    {
        Console.WriteLine($"Audio ijro etildi: {Title}");
    }

    public override string GetFormat()
    {
        return "Audio format: MP3";
    }
}

class VideoAsset : MediaAsset
{
    public VideoAsset(string title) : base(title)
    {
    }

    public override void Play()
    {
        Console.WriteLine($"Video ijro etildi: {Title}");
    }

    public override string GetFormat()
    {
        return "Video format: MP4";
    }
}

class PodcastAsset : MediaAsset
{
    public PodcastAsset(string title) : base(title)
    {
    }

    public override void Play()
    {
        Console.WriteLine($"Podkast tinglandi: {Title}");
    }

    public override string GetFormat()
    {
        return "Podcast format: MP3";
    }
}
