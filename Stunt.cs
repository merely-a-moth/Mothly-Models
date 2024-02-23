using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Xml.Linq;

namespace Mothly_Models
{
    public interface IStuntCollection : ICollection<IStunt>
    {
    }

    [TypeConverter(typeof(StuntTypeConverter))]
    public interface IStunt
    {
        string Name { get; }
        string Description { get; }
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
        public string Name { get; set; }
        public string Description {  get
            {
                return $"+2 to {Skill.Name} when {Situation}";
            } 
        }

        public ISkill Skill { get; set; }
        public TSituation Situation { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

    public class ActivatedStunt<TPeriod, TSituation, TOutcome> : IActivatedStunt<TPeriod, TSituation, TOutcome>
    {
        public string Name { get; set; }
        public string Description
        {
            get
            {
                return $"Every {Period} when {Situation}, {Outcome}";
            }
        }

        public TPeriod Period { get; set; }

        public TSituation Situation { get; set; }

        public TOutcome Outcome { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

    public class StringBonusStunt : BonusStunt<string> { }
    public class StringActivatedStunt : ActivatedStunt<string, string, string> { }

    public class StuntTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var casted = value as string;
            if (casted == null) { base.ConvertFrom(context, culture, value); return null; }
            if (casted.Contains("Every"))
            {
                var parsedString = casted;
                return new StringActivatedStunt() { Name = parsedString, Outcome = "", Period="", Situation="" };
            }
            else
            {
                var parsedString = casted;
                return new StringBonusStunt() { Name = parsedString, Situation = "", Skill = new Skill() { Name = "TODO" } };
            }
        }
    }
}