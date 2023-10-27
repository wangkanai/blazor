// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using System.Text;

namespace BlazorAuthClean.Benchmark;

public class DomainBenchmark
{
	[Benchmark]
	public void Builder()
	{
		var domain = new StringBuilder("https://www.wangkanai.dev");
	}
}