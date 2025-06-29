namespace System.Diagnostics;

public struct CounterSample
{
	private long rawValue;

	private long baseValue;

	private long timeStamp;

	private long counterFrequency;

	private PerformanceCounterType counterType;

	private long timeStamp100nSec;

	private long systemFrequency;

	private long counterTimeStamp;

	public static CounterSample Empty = new CounterSample(0L, 0L, 0L, 0L, 0L, 0L, PerformanceCounterType.NumberOfItems32);

	public long RawValue => rawValue;

	internal ulong UnsignedRawValue => (ulong)rawValue;

	public long BaseValue => baseValue;

	public long SystemFrequency => systemFrequency;

	public long CounterFrequency => counterFrequency;

	public long CounterTimeStamp => counterTimeStamp;

	public long TimeStamp => timeStamp;

	public long TimeStamp100nSec => timeStamp100nSec;

	public PerformanceCounterType CounterType => counterType;

	public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType)
	{
		this.rawValue = rawValue;
		this.baseValue = baseValue;
		this.timeStamp = timeStamp;
		this.counterFrequency = counterFrequency;
		this.counterType = counterType;
		this.timeStamp100nSec = timeStamp100nSec;
		this.systemFrequency = systemFrequency;
		counterTimeStamp = 0L;
	}

	public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType, long counterTimeStamp)
	{
		this.rawValue = rawValue;
		this.baseValue = baseValue;
		this.timeStamp = timeStamp;
		this.counterFrequency = counterFrequency;
		this.counterType = counterType;
		this.timeStamp100nSec = timeStamp100nSec;
		this.systemFrequency = systemFrequency;
		this.counterTimeStamp = counterTimeStamp;
	}

	public static float Calculate(CounterSample counterSample)
	{
		return CounterSampleCalculator.ComputeCounterValue(counterSample);
	}

	public static float Calculate(CounterSample counterSample, CounterSample nextCounterSample)
	{
		return CounterSampleCalculator.ComputeCounterValue(counterSample, nextCounterSample);
	}

	public override bool Equals(object o)
	{
		if (o is CounterSample)
		{
			return Equals((CounterSample)o);
		}
		return false;
	}

	public bool Equals(CounterSample sample)
	{
		if (rawValue == sample.rawValue && baseValue == sample.baseValue && timeStamp == sample.timeStamp && counterFrequency == sample.counterFrequency && counterType == sample.counterType && timeStamp100nSec == sample.timeStamp100nSec && systemFrequency == sample.systemFrequency)
		{
			return counterTimeStamp == sample.counterTimeStamp;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return rawValue.GetHashCode();
	}

	public static bool operator ==(CounterSample a, CounterSample b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(CounterSample a, CounterSample b)
	{
		return !a.Equals(b);
	}
}
