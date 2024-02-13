namespace Mothly_Models
{
    public interface IAspect
    {
        string Name { get; }
        AspectType Type { get; }
    }

    public enum AspectType
    {
        Other = 0,
        Internal, // Generic term for a Character Aspect, since the fractal may represent other things
        Situational,
        Environmental
    }

    public class Aspect : IAspect
    {
        public string Name { get; set; }
        public AspectType Type { get; set; }
    }
}