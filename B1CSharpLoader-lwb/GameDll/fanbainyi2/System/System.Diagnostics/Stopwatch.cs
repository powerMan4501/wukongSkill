using Microsoft.Win32;

namespace System.Diagnostics;

[global::__DynamicallyInvokable]
public class Stopwatch
{
	private const long TicksPerMillisecond = 10000L;

	private const long TicksPerSecond = 10000000L;

	private long elapsed;

	private long startTimeStamp;

	private bool isRunning;

	[global::__DynamicallyInvokable]
	public static readonly long Frequency;

	[global::__DynamicallyInvokable]
	public static readonly bool IsHighResolution;

	private static readonly double tickFrequency;

	[global::__DynamicallyInvokable]
	public bool IsRunning
	{
		[global::__DynamicallyInvokable]
		get
		{
			return isRunning;
		}
	}

	[global::__DynamicallyInvokable]
	public TimeSpan Elapsed
	{
		[global::__DynamicallyInvokable]
		get
		{
			return new TimeSpan(GetElapsedDateTimeTicks());
		}
	}

	[global::__DynamicallyInvokable]
	public long ElapsedMilliseconds
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetElapsedDateTimeTicks() / 10000;
		}
	}

	[global::__DynamicallyInvokable]
	public long ElapsedTicks
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetRawElapsedTicks();
		}
	}

	static Stopwatch()
	{
		if (!Microsoft.Win32.SafeNativeMethods.QueryPerformanceFrequency(out Frequency))
		{
			IsHighResolution = false;
			Frequency = 10000000L;
			tickFrequency = 1.0;
		}
		else
		{
			IsHighResolution = true;
			tickFrequency = 10000000.0;
			tickFrequency /= Frequency;
		}
	}

	[global::__DynamicallyInvokable]
	public Stopwatch()
	{
		Reset();
	}

	[global::__DynamicallyInvokable]
	public void Start()
	{
		if (!isRunning)
		{
			startTimeStamp = GetTimestamp();
			isRunning = true;
		}
	}

	[global::__DynamicallyInvokable]
	public static Stopwatch StartNew()
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		return stopwatch;
	}

	[global::__DynamicallyInvokable]
	public void Stop()
	{
		if (isRunning)
		{
			long timestamp = GetTimestamp();
			long num = timestamp - startTimeStamp;
			elapsed += num;
			isRunning = false;
			if (elapsed < 0)
			{
				elapsed = 0L;
			}
		}
	}

	[global::__DynamicallyInvokable]
	public void Reset()
	{
		elapsed = 0L;
		isRunning = false;
		startTimeStamp = 0L;
	}

	[global::__DynamicallyInvokable]
	public void Restart()
	{
		elapsed = 0L;
		startTimeStamp = GetTimestamp();
		isRunning = true;
	}

	[global::__DynamicallyInvokable]
	public static long GetTimestamp()
	{
		if (IsHighResolution)
		{
			long value = 0L;
			Microsoft.Win32.SafeNativeMethods.QueryPerformanceCounter(out value);
			return value;
		}
		return DateTime.UtcNow.Ticks;
	}

	private long GetRawElapsedTicks()
	{
		long num = elapsed;
		if (isRunning)
		{
			long timestamp = GetTimestamp();
			long num2 = timestamp - startTimeStamp;
			num += num2;
		}
		return num;
	}

	private long GetElapsedDateTimeTicks()
	{
		long rawElapsedTicks = GetRawElapsedTicks();
		if (IsHighResolution)
		{
			double num = rawElapsedTicks;
			num *= tickFrequency;
			return (long)num;
		}
		return rawElapsedTicks;
	}
}
