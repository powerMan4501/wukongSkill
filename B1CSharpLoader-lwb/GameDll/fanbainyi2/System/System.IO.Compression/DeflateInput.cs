namespace System.IO.Compression;

internal class DeflateInput
{
	internal struct InputState
	{
		internal int count;

		internal int startIndex;
	}

	private byte[] buffer;

	private int count;

	private int startIndex;

	internal byte[] Buffer
	{
		get
		{
			return buffer;
		}
		set
		{
			buffer = value;
		}
	}

	internal int Count
	{
		get
		{
			return count;
		}
		set
		{
			count = value;
		}
	}

	internal int StartIndex
	{
		get
		{
			return startIndex;
		}
		set
		{
			startIndex = value;
		}
	}

	internal void ConsumeBytes(int n)
	{
		startIndex += n;
		count -= n;
	}

	internal InputState DumpState()
	{
		InputState result = default(InputState);
		result.count = count;
		result.startIndex = startIndex;
		return result;
	}

	internal void RestoreState(InputState state)
	{
		count = state.count;
		startIndex = state.startIndex;
	}
}
