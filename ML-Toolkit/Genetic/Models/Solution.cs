using System;
using System.Collections;

namespace ML_Toolkit.Genetic.Models
{
    public class Solution
    {
        public BitArray Value { get; set; }
        public double Fitness { get; set; }

        public override bool Equals(Object obj)
        {
            bool rtnValue = true;
            Solution comparingObject = (Solution)obj;

            if (comparingObject.Value.Length != this.Value.Length)
            {
                rtnValue = false;
            }

            if (rtnValue)
            {
                for(int i = 0; i < this.Value.Length && rtnValue; i++)
                {
                    rtnValue = (this.Value[i] == comparingObject.Value[i]);
                }
            }

            return rtnValue;
        }

    }
}