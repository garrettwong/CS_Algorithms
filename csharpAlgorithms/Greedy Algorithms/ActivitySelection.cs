
using System.Collections.Generic;

namespace csharpAlgorithms
{
    public class ActivitySelection
    {
        public List<int> GetMaxActivities(int[] s, int[] f, int n)
        {
            var list = new List<int>();

            int i = 0, j;
            list.Add(i);

            for (j = 1; j < n; j++)
            {
                if (s[j] >= f[i])
                {
                    list.Add(j);

                    i = j;
                }
            }

            return list;
        }

    }
}
