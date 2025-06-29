using System.IO;

namespace System.Net.Security;

public abstract class AuthenticatedStream : Stream
{
	private Stream _InnerStream;

	private bool _LeaveStreamOpen;

	public bool LeaveInnerStreamOpen => _LeaveStreamOpen;

	protected Stream InnerStream => _InnerStream;

	public abstract bool IsAuthenticated { get; }

	public abstract bool IsMutuallyAuthenticated { get; }

	public abstract bool IsEncrypted { get; }

	public abstract bool IsSigned { get; }

	public abstract bool IsServer { get; }

	protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen)
	{
		if (innerStream == null || innerStream == Stream.Null)
		{
			throw new ArgumentNullException("innerStream");
		}
		if (!innerStream.CanRead || !innerStream.CanWrite)
		{
			throw new ArgumentException(SR.GetString("net_io_must_be_rw_stream"), "innerStream");
		}
		_InnerStream = innerStream;
		_LeaveStreamOpen = leaveInnerStreamOpen;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				if (_LeaveStreamOpen)
				{
					_InnerStream.Flush();
				}
				else
				{
					_InnerStream.Close();
				}
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}
}
