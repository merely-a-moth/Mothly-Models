using System.Collections;
using System.Collections.Generic;

namespace Mothly_Models
{
    public interface IExtrasCollection : ICollection<IExtra> { }

    /// <summary>
    /// Since extras may be a lot of different things, we provide the interface we need,
    /// implementors provide the rest.
    /// </summary>
    public interface  IExtra
    {
        
    }

    public class ExtrasCollection : List<IExtra>, IExtrasCollection { }

    public class StringExtra : IExtra
    {
        public override string ToString()
        {
            return "Extras not yet supported";
        }
    }
}