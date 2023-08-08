using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coratcoret
{
    public class Benchmark
    {
        private static readonly Random Rng = new(80085);
        public int Size { get; set; } = 100;

        private List<int> _items;

        [GlobalSetup]
        public void Setup()
        {
            _items = Enumerable.Range(1, Size).Select(x => Rng.Next()).ToList();
        }

        [Benchmark]
        public void For()
        {
            for (int i = 0; i < _items.Count(); i++)
            {
                var item = _items[i];
            }
        }

        [Benchmark]
        public void Foreach()
        {
            foreach (var item in _items)
            {

            }
        }
    }
}
