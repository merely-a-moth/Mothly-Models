using System.Collections;
using System.Collections.Generic;

namespace Mothly_Models
{
    public interface IStuntCollection : ICollection
    {
    }

    public interface IStunt
    {
    }

    /// <summary>
    /// "+2 to <Skill> when <Situation>"
    /// </summary>
    /// <typeparam name="TSituation">Type for the stunt's situation</typeparam>
    public interface IBonusStunt<TSituation> : IStunt
    {
        ISkill Skill { get; }
        TSituation Situation { get; }

    }

    /// <summary>
    /// "Once per <period> when <Situation>, you can <Outcome>"
    /// </summary>
    /// <typeparam name="TPeriod">Type of the period for the situation</typeparam>
    /// <typeparam name="TSituation">Type of the stunt's situation</typeparam>
    /// <typeparam name="TOutcome">Type of the outcome of the situation</typeparam>
    public interface IActivatedStunt<TPeriod, TSituation, TOutcome> : IStunt
    {
        TPeriod Period { get; }
        TSituation Situation { get; }
        TOutcome Outcome { get; }
    }

    public enum StuntType
    {
        Other = 0,
        Bonus = 1,      // "+2 to <Skill> when <Situation>"
        Activated = 2,  // "Once per <period> when <Situation>, you can <Outcome>"
    }

    public class StuntCollection : List<IStunt>, IStuntCollection { }

    public class BonusStunt<TSituation> : IBonusStunt<TSituation>
    {
        public ISkill Skill { get; set; }
        public TSituation Situation { get; set; }
    }

    public class ActivatedStunt<TPeriod, TSituation, TOutcome> : IActivatedStunt<TPeriod, TSituation, TOutcome>
    {
        public TPeriod Period { get; set; }

        public TSituation Situation { get; set; }

        public TOutcome Outcome { get; set; }
    }

    public class StringBonusStunt : BonusStunt<string> { }
    public class StringActivatedStunt : ActivatedStunt<string, string, string> { }
}