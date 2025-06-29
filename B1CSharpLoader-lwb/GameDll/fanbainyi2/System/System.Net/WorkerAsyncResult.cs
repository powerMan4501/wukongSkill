namespace System.Net;

internal class WorkerAsyncResult : LazyAsyncResult
{
	public byte[] Buffer;

	public int Offset;

	public int End;

	public bool IsWrite;

	public WorkerAsyncResult ParentResult;

	public bool HeaderDone;

	public bool HandshakeDone;

	public WorkerAsyncResult(object asyncObject, object asyncState, AsyncCallback savedAsyncCallback, byte[] buffer, int offset, int end)
		: base(asyncObject, asyncState, savedAsyncCallback)
	{
		Buffer = buffer;
		Offset = offset;
		End = end;
	}
}
