using System;

namespace BucketsWithApplesLib
{
    public class BucketWithApples
    {
        int _apples;

        public int Apples
        {
            get => _apples;
            set => _apples = value;
        }

        public void AddApples(int apples) => _apples += apples;

        public void RemoveApples(int apples) => _apples -= apples;
    }
}
