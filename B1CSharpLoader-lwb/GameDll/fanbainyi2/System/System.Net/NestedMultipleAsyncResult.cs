namespace System.Net;

internal class NestedMultipleAsyncResult : LazyAsyncResult
{
	internal BufferOffsetSize[] Buffers;

	internal int Size;

	internal NestedMultipleAsyncResult(object asyncObject, object asyncState, AsyncCallback asyncCallback, BufferOffsetSize[] buffers)
		: base(asyncObject, asyncState, asyncCallback)
	{
		Buffers = buffers;
		Size = 0;
		for (int i = 0; i < Buffers.Length; i++)
		{
			Size += Buffers[i].Size;
		}
	}
}
