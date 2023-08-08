``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19043.2130/21H1/May2021Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]     : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2  [AttachedDebugger]
  DefaultJob : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2


```
|  Method |      Mean |    Error |   StdDev |
|-------- |----------:|---------:|---------:|
|     For | 356.13 ns | 6.846 ns | 7.884 ns |
| Foreach |  69.95 ns | 1.244 ns | 1.481 ns |
