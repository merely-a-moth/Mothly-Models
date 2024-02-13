using System.Collections;
using System.Collections.Generic;

namespace Mothly_Models
{
    public interface IExtrasCollection : ICollection { }

    /// <summary>
    /// Since extras may be a lot of different things, we provide the interface we need,
    /// implementors provide the rest.
    /// </summary>
    public interface  IExtra
    {
        
    }

    public class ExtrasCollection<T> : List<T>, IExtrasCollection { }
}