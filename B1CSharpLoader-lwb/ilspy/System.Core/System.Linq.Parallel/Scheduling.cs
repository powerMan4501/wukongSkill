using System.Runtime.InteropServices;

namespace System.Linq.Parallel;

internal static class Scheduling
{
	internal const bool DefaultPreserveOrder = false;

	internal static int DefaultDegreeOfParallelism = Math.Min(Environment.ProcessorCount, 512);

	internal const int DEFAULT_BOUNDED_BUFFER_CAPACITY = 512;

	internal const int DEFAULT_BYTES_PER_CHUNK = 512;

	internal const int ZOMBIED_PRODUCER_TIMEOUT = -1;

	internal const int MAX_SUPPORTED_DOP = 512;

	internal static int GetDefaultDegreeOfParallelism()
	{
		return DefaultDegreeOfParallelism;
	}

	internal static int GetDefaultChunkSize<T>()
	{
		if (typeof(T).IsValueType)
		{
			if (typeof(T).StructLayoutAttribute.Value == LayoutKind.Explicit)
			{
				return Math.Max(1, 512 / Marshal.SizeOf(typeof(T)));
			}
			return 128;
		}
		return 512 / IntPtr.Size;
	}
}
