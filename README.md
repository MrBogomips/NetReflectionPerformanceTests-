# .Net Reflection Performance Tests

A simple suite of performance tests for .Net Reflection.

## How to run

Simply issue `dotnet run -c Release -- --filter '*'` to run all the suite.

Issue `dotnet run -c Release -- --help` for more options.

# Results
``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.5 (21G72) [Darwin 21.6.0]
Apple M1 Pro, 1 CPU, 10 logical and 10 physical cores
.NET SDK=6.0.400
  [Host]     : .NET 6.0.8 (6.0.822.36306), Arm64 RyuJIT
  Job-DLCDRR : .NET 6.0.8 (6.0.822.36306), Arm64 RyuJIT

IterationCount=5  

```
|                                Method |        Mean |     Error |    StdDev |         Min |         Max |      Median |
|-------------------------------------- |------------:|----------:|----------:|------------:|------------:|------------:|
|             DirectCall_VoidMethodVoid |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |   0.0000 ns |
|         ReflectionCall_VoidMethodVoid |  87.3727 ns | 0.3780 ns | 0.0585 ns |  87.3114 ns |  87.4385 ns |  87.3704 ns |
|   ReflectionCachedCall_VoidMethodVoid |  62.9642 ns | 1.3791 ns | 0.2134 ns |  62.6522 ns |  63.1188 ns |  63.0430 ns |
|              DirectCall_VoidMethodInt |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |   0.0000 ns |
|          ReflectionCall_VoidMethodInt | 153.5015 ns | 1.3144 ns | 0.3413 ns | 153.0527 ns | 153.9733 ns | 153.4577 ns |
|    ReflectionCachedCall_VoidMethodInt | 130.9965 ns | 0.8818 ns | 0.2290 ns | 130.8066 ns | 131.2853 ns | 130.8549 ns |
|           DirectCall_VoidMethodString |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |   0.0000 ns |
|       ReflectionCall_VoidMethodString | 138.9164 ns | 0.5599 ns | 0.1454 ns | 138.6669 ns | 139.0418 ns | 138.9424 ns |
| ReflectionCachedCall_VoidMethodString | 117.1838 ns | 1.0072 ns | 0.2616 ns | 116.8931 ns | 117.5255 ns | 117.1514 ns |
|           DirectCall_VoidMethodIntInt |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |   0.0000 ns |
|       ReflectionCall_VoidMethodIntInt | 193.2280 ns | 0.7931 ns | 0.2060 ns | 193.0498 ns | 193.5516 ns | 193.1345 ns |
| ReflectionCachedCall_VoidMethodIntInt | 171.5295 ns | 1.8301 ns | 0.4753 ns | 171.1152 ns | 172.2805 ns | 171.3790 ns |
