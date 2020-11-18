namespace LoggingKata
{
    public interface ITrackable
    {//interfaces specify behavior  
        string Name { get; set; }
        Point Location { get; set; }
    }
}