using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mothly_Models
{
    public interface ICharacter
    {
        string Name { get; }
        string Description { get; }

        IRefreshTrack Refresh { get; }
        ICollection<IAspect> Aspects { get; }
        ISkillCollection Skills { get; }
        IStuntCollection Stunts { get; }
        IExtrasCollection Extras { get; }
        IStressTrackCollection StressTracks { get; }
        IConsequencesCollection Consequences { get; }
    }

    public class Character : ICharacter
    {
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public IRefreshTrack Refresh { get; set; } = new RefreshTrack();

        public ICollection<IAspect> Aspects { get; set; } = new List<IAspect>();

        public ISkillCollection Skills { get; set; } = new PyramidSkillCollection();

        public IStuntCollection Stunts { get; set; } = new StuntCollection();

        public IExtrasCollection Extras { get; set; } = new ExtrasCollection();

        public IStressTrackCollection StressTracks { get; set; } = new StressTrackCollection();

        public IConsequencesCollection Consequences { get; set; } = new ConsequenceCollection();

        public Character()
        {
            
        }
    }
}
