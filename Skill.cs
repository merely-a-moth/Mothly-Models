using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mothly_Models
{
    /// <summary>
    /// FATE skills are generally structured into either pyramids or towers.
    /// Collection interface allows supporting both.
    /// </summary>
    public interface ISkillCollection : ICollection<ISkill>
    {
        ISkillCollectionStructure Structure { get; }
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

    public class PyramidSkillCollection : List<ISkill>, ISkillCollection
    {
        public ISkillCollectionStructure Structure { get; } = new PyramidSkillCollectionStructure();
    }

    public class PillarSkillCollection : List<ISkill>, ISkillCollection
    {
        public ISkillCollectionStructure Structure { get; } = new PyramidSkillCollectionStructure();
    }

    public class PyramidSkillCollectionStructure : List<ISkill>, ISkillCollectionStructure
    {
        public bool IsBalanced { get; set; } = false;
    }

    public class PillarSkillCollectionStructure : List<ISkill>, ISkillCollectionStructure
    {
        public bool IsBalanced { get; set; } = false;
    }

    public class Skill : ISkill
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Value { get; set; } = 0;
    }
}