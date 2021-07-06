using System;
using System.Collections;
using System.Collections.Generic;
using Vehicles;

namespace GarageProject
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    
    {

        public int Capacity { get;}
        private T[] vechicles;

        public Garage(int capacity)
        {
            Console.WriteLine("Garge has been made");

            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException("Parameter cannot be 0 or less than 0", nameof(capacity));
            }
            Capacity = capacity;
            vechicles = new T[capacity];

        }



        public bool Park(T vehicle)
        {
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in vechicles) // Can only be T by class definition.
            {
                yield return item; // Return as T incase code change?
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
    }
}