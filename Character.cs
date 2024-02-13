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
}
