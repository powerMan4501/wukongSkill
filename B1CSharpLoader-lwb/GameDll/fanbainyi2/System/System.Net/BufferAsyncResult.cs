namespace System.Net;

internal class BufferAsyncResult : LazyAsyncResult
{
	public byte[] Buffer;

	public BufferOffsetSize[] Buffers;

	public int Offset;

	public int Count;

	public bool IsWrite;

	public BufferAsyncResult(object asyncObject, BufferOffsetSize[] buffers, object asyncState, AsyncCallback asyncCallback)
		: base(asyncObject, asyncState, asyncCallback)
	{
		Buffers = buffers;
		IsWrite = true;
	}

	public BufferAsyncResult(object asyncObject, byte[] buffer, int offset, int count, object asyncState, AsyncCallback asyncCallback)
		: this(asyncObject, buffer, offset, count, isWrite: false, asyncState, asyncCallback)
	{
	}

	public BufferAsyncResult(object asyncObject, byte[] buffer, int offset, int count, bool isWrite, object asyncState, AsyncCallback asyncCallback)
		: base(asyncObject, asyncState, asyncCallback)
	{
		Buffer = buffer;
		Offset = offset;
		Count = count;
		IsWrite = isWrite;
	}
}
