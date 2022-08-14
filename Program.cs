// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using NetReflectionPerformanceTests;

Console.WriteLine("Hello, World!");

//var results = BenchmarkRunner.Run<PerformanceTests>();


BenchmarkSwitcher.FromAssembly(typeof(PerformanceTests).Assembly).Run(args);
