using System.Collections;
using System.Collections.Generic;

namespace Mothly_Models
{
    public interface IStressTrackCollection : ICollection
    {
    }

    /// <summary>
    /// Represents one level of a stress track.
    /// Key is the numerical level, Value is the number of boxes
    /// </summary>
    public interface IStressTrackLevels : IDictionary<uint, uint> { }

    public interface IStressTrack
    {
        string Name { get; }
        IStressTrackLevels Levels { get; }
        IStressTrackLevels CheckedLevels { get; }
    }

    public class StressTrackCollection : List<IStressTrack>, IStressTrackCollection
    { 
    }

    public class StressTrackLevel : Dictionary<uint, uint>, IStressTrackLevels { }

    public class StressTrack : IStressTrack
    {
        public string Name { get; set; }

        public IStressTrackLevels Levels { get; set; }

        public IStressTrackLevels CheckedLevels { get; set; }
    }
}