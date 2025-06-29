using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace System.Diagnostics;

internal class CategorySample
{
	internal readonly long SystemFrequency;

	internal readonly long TimeStamp;

	internal readonly long TimeStamp100nSec;

	internal readonly long CounterFrequency;

	internal readonly long CounterTimeStamp;

	internal Hashtable CounterTable;

	internal Hashtable InstanceNameTable;

	internal bool IsMultiInstance;

	private CategoryEntry entry;

	private PerformanceCounterLib library;

	internal unsafe CategorySample(byte[] data, CategoryEntry entry, PerformanceCounterLib library)
	{
		this.entry = entry;
		this.library = library;
		int nameIndex = entry.NameIndex;
		Microsoft.Win32.NativeMethods.PERF_DATA_BLOCK pERF_DATA_BLOCK = new Microsoft.Win32.NativeMethods.PERF_DATA_BLOCK();
		fixed (byte* value = data)
		{
			IntPtr intPtr = new IntPtr(value);
			IntPtr intPtr2 = intPtr;
			Microsoft.Win32.NativeMethods.PERF_DATA_BLOCK.ValidateBeforeRead(intPtr, data.Length, intPtr2);
			Marshal.PtrToStructure(intPtr2, (object)pERF_DATA_BLOCK);
			pERF_DATA_BLOCK.Validate(data.Length - (int)((long)intPtr2 - (long)intPtr));
			SystemFrequency = pERF_DATA_BLOCK.PerfFreq;
			TimeStamp = pERF_DATA_BLOCK.PerfTime;
			TimeStamp100nSec = pERF_DATA_BLOCK.PerfTime100nSec;
			intPtr2 = (IntPtr)((long)intPtr2 + pERF_DATA_BLOCK.HeaderLength);
			int numObjectTypes = pERF_DATA_BLOCK.NumObjectTypes;
			if (numObjectTypes == 0)
			{
				CounterTable = new Hashtable();
				InstanceNameTable = new Hashtable(StringComparer.OrdinalIgnoreCase);
				return;
			}
			Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE pERF_OBJECT_TYPE = null;
			bool flag = false;
			for (int i = 0; i < numObjectTypes; i++)
			{
				Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE.ValidateBeforeRead(intPtr, data.Length, intPtr2);
				pERF_OBJECT_TYPE = new Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE();
				Marshal.PtrToStructure(intPtr2, (object)pERF_OBJECT_TYPE);
				pERF_OBJECT_TYPE.Validate(data.Length - (int)((long)intPtr2 - (long)intPtr));
				if (pERF_OBJECT_TYPE.ObjectNameTitleIndex == nameIndex)
				{
					flag = true;
					break;
				}
				intPtr2 = (IntPtr)((long)intPtr2 + pERF_OBJECT_TYPE.TotalByteLength);
			}
			if (!flag)
			{
				throw new InvalidOperationException(SR.GetString("CantReadCategoryIndex", nameIndex.ToString(CultureInfo.CurrentCulture)));
			}
			CounterFrequency = pERF_OBJECT_TYPE.PerfFreq;
			CounterTimeStamp = pERF_OBJECT_TYPE.PerfTime;
			int numCounters = pERF_OBJECT_TYPE.NumCounters;
			int numInstances = pERF_OBJECT_TYPE.NumInstances;
			if (numInstances == -1)
			{
				IsMultiInstance = false;
			}
			else
			{
				IsMultiInstance = true;
			}
			intPtr2 = (IntPtr)((long)intPtr2 + pERF_OBJECT_TYPE.HeaderLength);
			CounterDefinitionSample[] array = new CounterDefinitionSample[numCounters];
			CounterTable = new Hashtable(numCounters);
			for (int j = 0; j < array.Length; j++)
			{
				Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION.ValidateBeforeRead(intPtr, data.Length, intPtr2);
				Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION pERF_COUNTER_DEFINITION = new Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION();
				Marshal.PtrToStructure(intPtr2, (object)pERF_COUNTER_DEFINITION);
				pERF_COUNTER_DEFINITION.Validate(data.Length - (int)((long)intPtr2 - (long)intPtr));
				array[j] = new CounterDefinitionSample(pERF_COUNTER_DEFINITION, this, numInstances);
				intPtr2 = (IntPtr)((long)intPtr2 + pERF_COUNTER_DEFINITION.ByteLength);
				int counterType = array[j].CounterType;
				if (!PerformanceCounterLib.IsBaseCounter(counterType))
				{
					if (counterType != 1073742336)
					{
						CounterTable[array[j].NameIndex] = array[j];
					}
				}
				else if (j > 0)
				{
					array[j - 1].BaseCounterDefinitionSample = array[j];
				}
			}
			if (!IsMultiInstance)
			{
				InstanceNameTable = new Hashtable(1, StringComparer.OrdinalIgnoreCase);
				InstanceNameTable["systemdiagnosticsperfcounterlibsingleinstance"] = 0;
				for (int k = 0; k < array.Length; k++)
				{
					array[k].SetInstanceValue(0, intPtr2);
				}
				return;
			}
			string[] array2 = null;
			InstanceNameTable = new Hashtable(numInstances, StringComparer.OrdinalIgnoreCase);
			for (int l = 0; l < numInstances; l++)
			{
				Microsoft.Win32.NativeMethods.PERF_INSTANCE_DEFINITION.ValidateBeforeRead(intPtr, data.Length, intPtr2);
				Microsoft.Win32.NativeMethods.PERF_INSTANCE_DEFINITION pERF_INSTANCE_DEFINITION = new Microsoft.Win32.NativeMethods.PERF_INSTANCE_DEFINITION();
				Marshal.PtrToStructure(intPtr2, (object)pERF_INSTANCE_DEFINITION);
				pERF_INSTANCE_DEFINITION.Validate(data.Length - (int)((long)intPtr2 - (long)intPtr));
				if (pERF_INSTANCE_DEFINITION.ParentObjectTitleIndex > 0 && array2 == null)
				{
					array2 = GetInstanceNamesFromIndex(pERF_INSTANCE_DEFINITION.ParentObjectTitleIndex);
				}
				string text = ((array2 == null || pERF_INSTANCE_DEFINITION.ParentObjectInstance < 0 || pERF_INSTANCE_DEFINITION.ParentObjectInstance >= array2.Length - 1) ? Marshal.PtrToStringUni((IntPtr)((long)intPtr2 + pERF_INSTANCE_DEFINITION.NameOffset)) : (array2[pERF_INSTANCE_DEFINITION.ParentObjectInstance] + "/" + Marshal.PtrToStringUni((IntPtr)((long)intPtr2 + pERF_INSTANCE_DEFINITION.NameOffset))));
				string key = text;
				int num = 1;
				while (InstanceNameTable.ContainsKey(key))
				{
					key = text + "#" + num.ToString(CultureInfo.InvariantCulture);
					num++;
				}
				InstanceNameTable[key] = l;
				intPtr2 = (IntPtr)((long)intPtr2 + pERF_INSTANCE_DEFINITION.ByteLength);
				for (int m = 0; m < array.Length; m++)
				{
					array[m].SetInstanceValue(l, intPtr2);
				}
				Microsoft.Win32.NativeMethods.PERF_COUNTER_BLOCK.ValidateBeforeRead(intPtr, data.Length, intPtr2);
				Microsoft.Win32.NativeMethods.PERF_COUNTER_BLOCK pERF_COUNTER_BLOCK = new Microsoft.Win32.NativeMethods.PERF_COUNTER_BLOCK();
				Marshal.PtrToStructure(intPtr2, (object)pERF_COUNTER_BLOCK);
				pERF_COUNTER_BLOCK.Validate(data.Length - (int)((long)intPtr2 - (long)intPtr));
				intPtr2 = (IntPtr)((long)intPtr2 + pERF_COUNTER_BLOCK.ByteLength);
			}
		}
	}

	internal unsafe string[] GetInstanceNamesFromIndex(int categoryIndex)
	{
		byte[] performanceData = library.GetPerformanceData(categoryIndex.ToString(CultureInfo.InvariantCulture));
		fixed (byte* value = performanceData)
		{
			IntPtr intPtr = new IntPtr(value);
			IntPtr intPtr2 = intPtr;
			Microsoft.Win32.NativeMethods.PERF_DATA_BLOCK.ValidateBeforeRead(intPtr, performanceData.Length, intPtr2);
			Microsoft.Win32.NativeMethods.PERF_DATA_BLOCK pERF_DATA_BLOCK = new Microsoft.Win32.NativeMethods.PERF_DATA_BLOCK();
			Marshal.PtrToStructure(intPtr2, (object)pERF_DATA_BLOCK);
			pERF_DATA_BLOCK.Validate(performanceData.Length - (int)((long)intPtr2 - (long)intPtr));
			intPtr2 = (IntPtr)((long)intPtr2 + pERF_DATA_BLOCK.HeaderLength);
			int numObjectTypes = pERF_DATA_BLOCK.NumObjectTypes;
			Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE pERF_OBJECT_TYPE = null;
			bool flag = false;
			for (int i = 0; i < numObjectTypes; i++)
			{
				Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE.ValidateBeforeRead(intPtr, performanceData.Length, intPtr2);
				pERF_OBJECT_TYPE = new Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE();
				Marshal.PtrToStructure(intPtr2, (object)pERF_OBJECT_TYPE);
				pERF_OBJECT_TYPE.Validate(performanceData.Length - (int)((long)intPtr2 - (long)intPtr));
				if (pERF_OBJECT_TYPE.ObjectNameTitleIndex == categoryIndex)
				{
					flag = true;
					break;
				}
				intPtr2 = (IntPtr)((long)intPtr2 + pERF_OBJECT_TYPE.TotalByteLength);
			}
			if (!flag)
			{
				return new string[0];
			}
			int numCounters = pERF_OBJECT_TYPE.NumCounters;
			int numInstances = pERF_OBJECT_TYPE.NumInstances;
			intPtr2 = (IntPtr)((long)intPtr2 + pERF_OBJECT_TYPE.HeaderLength);
			if (numInstances == -1)
			{
				return new string[0];
			}
			CounterDefinitionSample[] array = new CounterDefinitionSample[numCounters];
			for (int j = 0; j < array.Length; j++)
			{
				Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION.ValidateBeforeRead(intPtr, performanceData.Length, intPtr2);
				Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION pERF_COUNTER_DEFINITION = new Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION();
				Marshal.PtrToStructure(intPtr2, (object)pERF_COUNTER_DEFINITION);
				pERF_COUNTER_DEFINITION.Validate(performanceData.Length - (int)((long)intPtr2 - (long)intPtr));
				intPtr2 = (IntPtr)((long)intPtr2 + pERF_COUNTER_DEFINITION.ByteLength);
			}
			string[] array2 = new string[numInstances];
			for (int k = 0; k < numInstances; k++)
			{
				Microsoft.Win32.NativeMethods.PERF_INSTANCE_DEFINITION.ValidateBeforeRead(intPtr, performanceData.Length, intPtr2);
				Microsoft.Win32.NativeMethods.PERF_INSTANCE_DEFINITION pERF_INSTANCE_DEFINITION = new Microsoft.Win32.NativeMethods.PERF_INSTANCE_DEFINITION();
				Marshal.PtrToStructure(intPtr2, (object)pERF_INSTANCE_DEFINITION);
				pERF_INSTANCE_DEFINITION.Validate(performanceData.Length - (int)((long)intPtr2 - (long)intPtr));
				array2[k] = Marshal.PtrToStringUni((IntPtr)((long)intPtr2 + pERF_INSTANCE_DEFINITION.NameOffset));
				intPtr2 = (IntPtr)((long)intPtr2 + pERF_INSTANCE_DEFINITION.ByteLength);
				Microsoft.Win32.NativeMethods.PERF_COUNTER_BLOCK.ValidateBeforeRead(intPtr, performanceData.Length, intPtr2);
				Microsoft.Win32.NativeMethods.PERF_COUNTER_BLOCK pERF_COUNTER_BLOCK = new Microsoft.Win32.NativeMethods.PERF_COUNTER_BLOCK();
				Marshal.PtrToStructure(intPtr2, (object)pERF_COUNTER_BLOCK);
				pERF_COUNTER_BLOCK.Validate(performanceData.Length - (int)((long)intPtr2 - (long)intPtr));
				intPtr2 = (IntPtr)((long)intPtr2 + pERF_COUNTER_BLOCK.ByteLength);
			}
			return array2;
		}
	}

	internal CounterDefinitionSample GetCounterDefinitionSample(string counter)
	{
		for (int i = 0; i < entry.CounterIndexes.Length; i++)
		{
			int num = entry.CounterIndexes[i];
			string text = (string)library.NameTable[num];
			if (text == null || string.Compare(text, counter, StringComparison.OrdinalIgnoreCase) != 0)
			{
				continue;
			}
			CounterDefinitionSample counterDefinitionSample = (CounterDefinitionSample)CounterTable[num];
			if (counterDefinitionSample == null)
			{
				foreach (CounterDefinitionSample value in CounterTable.Values)
				{
					if (value.BaseCounterDefinitionSample != null && value.BaseCounterDefinitionSample.NameIndex == num)
					{
						return value.BaseCounterDefinitionSample;
					}
				}
				throw new InvalidOperationException(SR.GetString("CounterLayout"));
			}
			return counterDefinitionSample;
		}
		throw new InvalidOperationException(SR.GetString("CantReadCounter", counter));
	}

	internal InstanceDataCollectionCollection ReadCategory()
	{
		InstanceDataCollectionCollection instanceDataCollectionCollection = new InstanceDataCollectionCollection();
		for (int i = 0; i < entry.CounterIndexes.Length; i++)
		{
			int num = entry.CounterIndexes[i];
			string text = (string)library.NameTable[num];
			if (text != null && text != string.Empty)
			{
				CounterDefinitionSample counterDefinitionSample = (CounterDefinitionSample)CounterTable[num];
				if (counterDefinitionSample != null)
				{
					instanceDataCollectionCollection.Add(text, counterDefinitionSample.ReadInstanceData(text));
				}
			}
		}
		return instanceDataCollectionCollection;
	}
}
