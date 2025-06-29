using Microsoft.Win32;

namespace System.Diagnostics;

internal class CategoryEntry
{
	internal int NameIndex;

	internal int HelpIndex;

	internal int[] CounterIndexes;

	internal int[] HelpIndexes;

	internal CategoryEntry(NativeMethods.PERF_OBJECT_TYPE perfObject)
	{
		NameIndex = perfObject.ObjectNameTitleIndex;
		HelpIndex = perfObject.ObjectHelpTitleIndex;
		CounterIndexes = new int[perfObject.NumCounters];
		HelpIndexes = new int[perfObject.NumCounters];
	}
}
