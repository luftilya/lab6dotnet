using System;

namespace buckets_with_apples
{
    public class BucketWithApples
    {
        int apples;

        public int GetApplesCount() => apples;

        public void AddApples(int apples) => this.apples += apples;

        public void RemoveApples(int apples) => this.apples -= apples;
    }
}
