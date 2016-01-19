using System.Collections.Generic;
using System.ComponentModel;

namespace Framework.Interfaces.App.@class
{
    public interface IKZBindingList<T> : IBindingList, IEnumerable<T>
    {
        T this[int index] { get; set; }

        void GenerateNo();
    }
}