using System.Collections;
using System.Collections.Generic;

namespace Mothly_Models
{
    public interface IStressTrackCollection : ICollection<IStressTrack>
    {
    }

    /// <summary>
    /// Represents one level of a stress track.
    /// Key is the numerical level, Value is the number of boxes
    /// </summary>
    public interface IStressTrackLevels : IDictionary<uint, bool> { }

    public interface IStressTrack
    {
        string Name { get; }
        IStressTrackLevels Levels { get; }
    }

    public class StressTrackCollection : List<IStressTrack>, IStressTrackCollection
    { 
    }

    public class StressTrackLevels : Dictionary<uint, bool>, IStressTrackLevels { }

    public class StressTrack : IStressTrack
    {
        public string Name { get; set; }

        public IStressTrackLevels Levels { get; set; }

    }
}