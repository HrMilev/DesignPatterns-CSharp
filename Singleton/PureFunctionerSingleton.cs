using System;
using System.Linq;

namespace Singleton
{
    public sealed class PureFunctionerSingleton : IPureFunctionerSingleton
    {
        private static readonly Lazy<PureFunctionerSingleton> instance = new Lazy<PureFunctionerSingleton>(() => new PureFunctionerSingleton());

        private PureFunctionerSingleton()
        {
        }

        public static PureFunctionerSingleton Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public decimal[] VectorAddition(params decimal[][] v)
        {
            if (v.Any(x => x.Length != v[0].Length))
            {
                throw new ArgumentException($"{nameof(v)} must have equal dimensions");
            }

            return v
                .SelectMany(x => x.Select((vi, i) => new { Value = vi, Index = i }))
                .GroupBy(x => x.Index, x => x.Value, (g, s) => s.Sum()).ToArray();            
        }
    }
}
