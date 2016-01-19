/***************************************************************************
 * BTRMGroup Copyright 2011                                                * 
 * SortableBindingList<T>                                                  *
 * Version 1.0, 1.1                                                        *
 * Author: vmeng1,sorng1                                                   *
 ***************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Framework.Interfaces.App.@class;

namespace Framework.Base.App.@class
{
    [DebuggerStepThrough]
    [Serializable]
    public class KZBindingList<T> : BindingList<T>, IKZBindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor _sortProperty;

        public KZBindingList(IList<T> list) : base(list)
        {
        }

        public KZBindingList(IEnumerable<T> list)
            : base(list.ToList())
        {
        }

        public KZBindingList()
        {
        }


        /// <summary>
        ///     Gets a newRecieve indicating whether the list supports sorting.
        /// </summary>
        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets a newRecieve indicating whether the list is sorted.
        /// </summary>
        protected override bool IsSortedCore
        {
            get { return _isSorted; }
        }

        /// <summary>
        ///     Gets the direction the list is sorted.
        /// </summary>
        protected override ListSortDirection SortDirectionCore
        {
            get { return _sortDirection; }
        }

        /// <summary>
        ///     Gets the property descriptor that is used for sorting the list if sorting is implemented in a derived class;
        ///     otherwise, returns null
        /// </summary>
        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _sortProperty; }
        }


        public void GenerateNo()
        {
            if (this.Count() == 0) return;
            try
            {
                var i = 1;
                foreach (object obj in this)
                {
                    var prop = obj.GetType().GetProperty("No");
                    if (prop != null)
                    {
                        prop.SetValue(obj, i, null);
                        i += 1;
                    }
                }
            }
            catch
            {
            }
        }

        public static IKZBindingList<T> CreateBindingList(IList<T> list)
        {
            return new KZBindingList<T>(list);
        }

        public static IKZBindingList<T> CreateBindingList(IEnumerable<T> list)
        {
            return new KZBindingList<T>(list);
        }

        public static IKZBindingList<T> CreateBindingList()
        {
            return new KZBindingList<T>();
        }

        /// <summary>
        ///     Removes any sort applied with ApplySortCore if sorting is implemented
        /// </summary>
        protected override void RemoveSortCore()
        {
            _sortDirection = ListSortDirection.Ascending;
            _sortProperty = null;
        }

        /// <summary>
        ///     Sorts the items if overridden in a derived class
        /// </summary>
        /// <param name="prop"></param>
        /// <param name="direction"></param>
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            _sortProperty = prop;
            _sortDirection = direction;

            var list = Items as List<T>;
            if (list == null) return;

            list.Sort(Compare);

            _isSorted = true;
            //fire an event that the list has been changed.
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }


        private int Compare(T lhs, T rhs)
        {
            var result = OnComparison(lhs, rhs);
            //invert if descending
            if (_sortDirection == ListSortDirection.Descending)
                result = -result;
            return result;
        }

        private int OnComparison(T lhs, T rhs)
        {
            var lhsValue = lhs == null ? null : _sortProperty.GetValue(lhs);
            var rhsValue = rhs == null ? null : _sortProperty.GetValue(rhs);
            if (lhsValue == null)
            {
                return rhsValue == null ? 0 : -1; //nulls are equal
            }
            if (rhsValue == null)
            {
                return 1; //first has newRecieve, second doesn't
            }
            if (lhsValue is IComparable)
            {
                return ((IComparable) lhsValue).CompareTo(rhsValue);
            }
            if (lhsValue.Equals(rhsValue))
            {
                return 0; //both are the same
            }
            //not comparable, compare ToString
            return lhsValue.ToString().CompareTo(rhsValue.ToString());
        }
    }
}