using System.Diagnostics;
using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace NetReflectionPerformanceTests;

[SimpleJob(targetCount: 5)]
[MinColumn, MaxColumn, MeanColumn, MedianColumn]
//[MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
[MarkdownExporter]
public class PerformanceTests
{
	private readonly DemoClass demo = new();

	[Benchmark]
	public void DirectCall_VoidMethodVoid() => demo.VoidMethodVoid();

	[Benchmark]
	public void ReflectionCall_VoidMethodVoid()
	{
		var method = typeof(DemoClass).GetMethod("VoidMethodVoid");
		method!.Invoke(demo, Array.Empty<object>());
	}

	private MethodInfo? _cachedVoidMethodVoid;

	[Benchmark]
	public void ReflectionCachedCall_VoidMethodVoid()
	{
		_cachedVoidMethodVoid ??= typeof(DemoClass).GetMethod("VoidMethodVoid");
		_cachedVoidMethodVoid!.Invoke(demo, Array.Empty<object>());
	}


	[Benchmark]
	public void DirectCall_VoidMethodInt() => demo.VoidMethodInt(0);

	[Benchmark]
	public void ReflectionCall_VoidMethodInt()
	{
		var method = typeof(DemoClass).GetMethod("VoidMethodInt");
		method!.Invoke(demo, new object?[] { 0 });
	}

	private MethodInfo? _cachedVoidMethodInt;

	[Benchmark]
	public void ReflectionCachedCall_VoidMethodInt()
	{
		_cachedVoidMethodInt ??= typeof(DemoClass).GetMethod("VoidMethodInt");
		_cachedVoidMethodInt!.Invoke(demo, new object?[] { 0 });
	}

	[Benchmark]
	public void DirectCall_VoidMethodString() => demo.VoidMethodString("");

	[Benchmark]
	public void ReflectionCall_VoidMethodString()
	{
		var method = typeof(DemoClass).GetMethod("VoidMethodString");
		method!.Invoke(demo, new object?[] { "" });
	}

	private MethodInfo? _cachedVoidMethodString;

	[Benchmark]
	public void ReflectionCachedCall_VoidMethodString()
	{
		_cachedVoidMethodInt ??= typeof(DemoClass).GetMethod("VoidMethodString");
		_cachedVoidMethodInt!.Invoke(demo, new object?[] { "" });
	}


	[Benchmark]
	public void DirectCall_VoidMethodIntInt() => demo.VoidMethodIntInt(0, 0);

	[Benchmark]
	public void ReflectionCall_VoidMethodIntInt()
	{
		var method = typeof(DemoClass).GetMethod("VoidMethodIntInt");
		method!.Invoke(demo, new object?[] { 0, 0 });
	}

	private MethodInfo? _cachedVoidMethodIntInt;

	[Benchmark]
	public void ReflectionCachedCall_VoidMethodIntInt()
	{
		_cachedVoidMethodIntInt ??= typeof(DemoClass).GetMethod("VoidMethodIntInt");
		_cachedVoidMethodIntInt!.Invoke(demo, new object?[] { 0, 0 });
	}
}
