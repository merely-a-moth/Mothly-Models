using System;
using System.Collections.Generic;

namespace Mothly_Models
{
    /// <summary>
    /// FATE skills are generally structured into either pyramids or towers.
    /// Collection interface allows supporting both.
    /// </summary>
    public interface ISkillCollection
    {
        ISkillCollectionStructure Structure { get; }
        ICollection<Skill> Skills { get; }
    }

    public interface ISkillCollectionStructure
    {
        bool IsBalanced { get; }
    }

    public interface ISkill
    {
        string Name { get; }
        string Description { get; }
        int Value { get; }
    }

    public class PyramidSkillCollectionStructure : ISkillCollectionStructure
    {
        public bool IsBalanced { get; set; } = false;

        public PyramidSkillCollectionStructure()
        {
            throw new NotImplementedException(); // TODO
        }
    }

    public class PillarSkillCollectionStructure : ISkillCollectionStructure
    {
        public bool IsBalanced { get; set; } = false;

        public PillarSkillCollectionStructure()
        {
            throw new NotImplementedException(); // TODO
        }
    }

    public class Skill : ISkill
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
    }
}