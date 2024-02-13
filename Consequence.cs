using System.Collections.Generic;

namespace Mothly_Models
{
    public interface IConsequencesCollection : ICollection<Consequence>
    {
    }

    public enum ConsequenceLevel
    {
        Mild = 2,
        Moderate = 4,
        Severe = 6,
    }

    public interface IConsequence
    {
        ConsequenceLevel Level { get; }
        string Name { get; }
    }

    public class ConsequenceCollection : List<Consequence>, IConsequencesCollection { }

    public class Consequence : IConsequence
    {
        public ConsequenceLevel Level { get; }
        public string Name { get; }
    }
}