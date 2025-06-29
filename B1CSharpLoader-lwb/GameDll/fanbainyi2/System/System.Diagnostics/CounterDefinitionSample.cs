using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace System.Diagnostics;

internal class CounterDefinitionSample
{
	internal readonly int NameIndex;

	internal readonly int CounterType;

	internal CounterDefinitionSample BaseCounterDefinitionSample;

	private readonly int size;

	private readonly int offset;

	private long[] instanceValues;

	private CategorySample categorySample;

	internal CounterDefinitionSample(Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION perfCounter, CategorySample categorySample, int instanceNumber)
	{
		NameIndex = perfCounter.CounterNameTitleIndex;
		CounterType = perfCounter.CounterType;
		offset = perfCounter.CounterOffset;
		size = perfCounter.CounterSize;
		if (instanceNumber == -1)
		{
			instanceValues = new long[1];
		}
		else
		{
			instanceValues = new long[instanceNumber];
		}
		this.categorySample = categorySample;
	}

	private long ReadValue(IntPtr pointer)
	{
		if (size == 4)
		{
			return (uint)Marshal.ReadInt32((IntPtr)((long)pointer + offset));
		}
		if (size == 8)
		{
			return Marshal.ReadInt64((IntPtr)((long)pointer + offset));
		}
		return -1L;
	}

	internal CounterSample GetInstanceValue(string instanceName)
	{
		if (!this.categorySample.InstanceNameTable.ContainsKey(instanceName))
		{
			if (instanceName.Length > 127)
			{
				instanceName = instanceName.Substring(0, 127);
			}
			if (!this.categorySample.InstanceNameTable.ContainsKey(instanceName))
			{
				throw new InvalidOperationException(SR.GetString("CantReadInstance", instanceName));
			}
		}
		int num = (int)this.categorySample.InstanceNameTable[instanceName];
		long rawValue = instanceValues[num];
		long baseValue = 0L;
		if (BaseCounterDefinitionSample != null)
		{
			CategorySample categorySample = BaseCounterDefinitionSample.categorySample;
			int num2 = (int)categorySample.InstanceNameTable[instanceName];
			baseValue = BaseCounterDefinitionSample.instanceValues[num2];
		}
		return new CounterSample(rawValue, baseValue, this.categorySample.CounterFrequency, this.categorySample.SystemFrequency, this.categorySample.TimeStamp, this.categorySample.TimeStamp100nSec, (PerformanceCounterType)CounterType, this.categorySample.CounterTimeStamp);
	}

	internal InstanceDataCollection ReadInstanceData(string counterName)
	{
		InstanceDataCollection instanceDataCollection = new InstanceDataCollection(counterName);
		string[] array = new string[this.categorySample.InstanceNameTable.Count];
		this.categorySample.InstanceNameTable.Keys.CopyTo(array, 0);
		int[] array2 = new int[this.categorySample.InstanceNameTable.Count];
		this.categorySample.InstanceNameTable.Values.CopyTo(array2, 0);
		for (int i = 0; i < array.Length; i++)
		{
			long baseValue = 0L;
			if (BaseCounterDefinitionSample != null)
			{
				CategorySample categorySample = BaseCounterDefinitionSample.categorySample;
				int num = (int)categorySample.InstanceNameTable[array[i]];
				baseValue = BaseCounterDefinitionSample.instanceValues[num];
			}
			CounterSample sample = new CounterSample(instanceValues[array2[i]], baseValue, this.categorySample.CounterFrequency, this.categorySample.SystemFrequency, this.categorySample.TimeStamp, this.categorySample.TimeStamp100nSec, (PerformanceCounterType)CounterType, this.categorySample.CounterTimeStamp);
			instanceDataCollection.Add(array[i], new InstanceData(array[i], sample));
		}
		return instanceDataCollection;
	}

	internal CounterSample GetSingleValue()
	{
		long rawValue = instanceValues[0];
		long baseValue = 0L;
		if (BaseCounterDefinitionSample != null)
		{
			baseValue = BaseCounterDefinitionSample.instanceValues[0];
		}
		return new CounterSample(rawValue, baseValue, categorySample.CounterFrequency, categorySample.SystemFrequency, categorySample.TimeStamp, categorySample.TimeStamp100nSec, (PerformanceCounterType)CounterType, categorySample.CounterTimeStamp);
	}

	internal void SetInstanceValue(int index, IntPtr dataRef)
	{
		long num = ReadValue(dataRef);
		instanceValues[index] = num;
	}
}
