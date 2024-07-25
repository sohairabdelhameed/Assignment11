using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    //Create a generic class named Range<T> where T represents the type of values.
    internal class Range<T> where T : IComparable<T>
    {
     
        //Implement a constructor that takes the minimum and maximum
        //values to define the range.
        
        #region Properties
        public T Minimum { get; }
        public T Maximum { get; }

        #endregion

        #region Constructor
        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
                throw new ArgumentException("Minimum value cannot be greater than maximum value.");

            Minimum = minimum;
            Maximum = maximum;
        }

        #endregion

        #region Methods
        //Implement a method IsInRange(T value) that returns true if the given
        //value is within the range, otherwise false.
        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
        }

        //Implement a method Length() that returns the length of the range
        //(the difference between the maximum and minimum values).

        public T Length()
        {
            //dynamic is a keyword that is used to bypass compile-time type checking.
            //When you declare a variable as dynamic, it tells the compiler to defer 
            //the type checking until runtime.This can be useful in situations where
            //the type of an object is not known until the program is running.
            
            dynamic min = Minimum;
            dynamic max = Maximum; 
            return max - min;
        }

        #endregion

    }
}
