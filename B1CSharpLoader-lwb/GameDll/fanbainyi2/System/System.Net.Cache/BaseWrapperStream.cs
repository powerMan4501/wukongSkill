using System.IO;

namespace System.Net.Cache;

internal abstract class BaseWrapperStream : Stream, IRequestLifetimeTracker
{
	private Stream m_WrappedStream;

	protected Stream WrappedStream => m_WrappedStream;

	public BaseWrapperStream(Stream wrappedStream)
	{
		m_WrappedStream = wrappedStream;
	}

	public void TrackRequestLifetime(long requestStartTimestamp)
	{
		IRequestLifetimeTracker requestLifetimeTracker = m_WrappedStream as IRequestLifetimeTracker;
		requestLifetimeTracker.TrackRequestLifetime(requestStartTimestamp);
	}
}
