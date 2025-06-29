using System.Security;

namespace System.Diagnostics.Tracing;

[SecuritySafeCritical]
internal class TraceLoggingDataCollector
{
	internal static readonly TraceLoggingDataCollector Instance = new TraceLoggingDataCollector();

	private TraceLoggingDataCollector()
	{
	}

	public int BeginBufferedArray()
	{
		return DataCollector.ThreadInstance.BeginBufferedArray();
	}

	public void EndBufferedArray(int bookmark, int count)
	{
		DataCollector.ThreadInstance.EndBufferedArray(bookmark, count);
	}

	public TraceLoggingDataCollector AddGroup()
	{
		return this;
	}

	public unsafe void AddScalar(bool value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 1);
	}

	public unsafe void AddScalar(sbyte value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 1);
	}

	public unsafe void AddScalar(byte value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 1);
	}

	public unsafe void AddScalar(short value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 2);
	}

	public unsafe void AddScalar(ushort value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 2);
	}

	public unsafe void AddScalar(int value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 4);
	}

	public unsafe void AddScalar(uint value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 4);
	}

	public unsafe void AddScalar(long value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 8);
	}

	public unsafe void AddScalar(ulong value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 8);
	}

	public unsafe void AddScalar(IntPtr value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, IntPtr.Size);
	}

	public unsafe void AddScalar(UIntPtr value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, UIntPtr.Size);
	}

	public unsafe void AddScalar(float value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 4);
	}

	public unsafe void AddScalar(double value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 8);
	}

	public unsafe void AddScalar(char value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 2);
	}

	public unsafe void AddScalar(Guid value)
	{
		DataCollector.ThreadInstance.AddScalar(&value, 16);
	}

	public void AddBinary(string value)
	{
		DataCollector.ThreadInstance.AddBinary(value, (value != null) ? (value.Length * 2) : 0);
	}

	public void AddBinary(byte[] value)
	{
		DataCollector.ThreadInstance.AddBinary(value, (value != null) ? value.Length : 0);
	}

	public void AddArray(bool[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 1);
	}

	public void AddArray(sbyte[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 1);
	}

	public void AddArray(short[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 2);
	}

	public void AddArray(ushort[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 2);
	}

	public void AddArray(int[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 4);
	}

	public void AddArray(uint[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 4);
	}

	public void AddArray(long[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 8);
	}

	public void AddArray(ulong[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 8);
	}

	public void AddArray(IntPtr[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, IntPtr.Size);
	}

	public void AddArray(UIntPtr[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, UIntPtr.Size);
	}

	public void AddArray(float[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 4);
	}

	public void AddArray(double[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 8);
	}

	public void AddArray(char[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 2);
	}

	public void AddArray(Guid[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 16);
	}

	public void AddCustom(byte[] value)
	{
		DataCollector.ThreadInstance.AddArray(value, (value != null) ? value.Length : 0, 1);
	}
}
