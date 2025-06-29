using System.IO;
using System.Threading;

namespace System.Net;

internal class ClosableStream : DelegatedStream
{
	private EventHandler onClose;

	private int closed;

	internal ClosableStream(Stream stream, EventHandler onClose)
		: base(stream)
	{
		this.onClose = onClose;
	}

	public override void Close()
	{
		if (Interlocked.Increment(ref closed) == 1 && onClose != null)
		{
			onClose(this, new EventArgs());
		}
	}
}
