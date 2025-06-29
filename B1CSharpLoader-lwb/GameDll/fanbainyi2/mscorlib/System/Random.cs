using System.Runtime.InteropServices;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class Random
{
	private const int MBIG = int.MaxValue;

	private const int MSEED = 161803398;

	private const int MZ = 0;

	private int inext;

	private int inextp;

	private int[] SeedArray = new int[56];

	[__DynamicallyInvokable]
	public Random()
		: this(Environment.TickCount)
	{
	}

	[__DynamicallyInvokable]
	public Random(int Seed)
	{
		int num = 161803398 - ((Seed == int.MinValue) ? int.MaxValue : Math.Abs(Seed));
		SeedArray[55] = num;
		int num2 = 1;
		for (int i = 1; i < 55; i++)
		{
			int num3 = 21 * i % 55;
			SeedArray[num3] = num2;
			num2 = num - num2;
			if (num2 < 0)
			{
				num2 += int.MaxValue;
			}
			num = SeedArray[num3];
		}
		for (int j = 1; j < 5; j++)
		{
			for (int k = 1; k < 56; k++)
			{
				SeedArray[k] -= SeedArray[1 + (k + 30) % 55];
				if (SeedArray[k] < 0)
				{
					SeedArray[k] += int.MaxValue;
				}
			}
		}
		inext = 0;
		inextp = 21;
		Seed = 1;
	}

	[__DynamicallyInvokable]
	protected virtual double Sample()
	{
		return (double)InternalSample() * 4.656612875245797E-10;
	}

	private int InternalSample()
	{
		int num = inext;
		int num2 = inextp;
		if (++num >= 56)
		{
			num = 1;
		}
		if (++num2 >= 56)
		{
			num2 = 1;
		}
		int num3 = SeedArray[num] - SeedArray[num2];
		if (num3 == int.MaxValue)
		{
			num3--;
		}
		if (num3 < 0)
		{
			num3 += int.MaxValue;
		}
		SeedArray[num] = num3;
		inext = num;
		inextp = num2;
		return num3;
	}

	[__DynamicallyInvokable]
	public virtual int Next()
	{
		return InternalSample();
	}

	private double GetSampleForLargeRange()
	{
		int num = InternalSample();
		if (InternalSample() % 2 == 0)
		{
			num = -num;
		}
		double num2 = num;
		num2 += 2147483646.0;
		return num2 / 4294967293.0;
	}

	[__DynamicallyInvokable]
	public virtual int Next(int minValue, int maxValue)
	{
		if (minValue > maxValue)
		{
			throw new ArgumentOutOfRangeException("minValue", Environment.GetResourceString("Argument_MinMaxValue", "minValue", "maxValue"));
		}
		long num = (long)maxValue - (long)minValue;
		if (num <= int.MaxValue)
		{
			return (int)(Sample() * (double)num) + minValue;
		}
		return (int)((long)(GetSampleForLargeRange() * (double)num) + minValue);
	}

	[__DynamicallyInvokable]
	public virtual int Next(int maxValue)
	{
		if (maxValue < 0)
		{
			throw new ArgumentOutOfRangeException("maxValue", Environment.GetResourceString("ArgumentOutOfRange_MustBePositive", "maxValue"));
		}
		return (int)(Sample() * (double)maxValue);
	}

	[__DynamicallyInvokable]
	public virtual double NextDouble()
	{
		return Sample();
	}

	[__DynamicallyInvokable]
	public virtual void NextBytes(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		for (int i = 0; i < buffer.Length; i++)
		{
			buffer[i] = (byte)(InternalSample() % 256);
		}
	}
}
