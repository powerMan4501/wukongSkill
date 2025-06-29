using System.IO;
using System.IO.Compression;

namespace System.Net;

internal class DeflateWrapperStream : DeflateStream, ICloseEx, IRequestLifetimeTracker
{
	public DeflateWrapperStream(Stream stream, CompressionMode mode)
		: base(stream, mode, leaveOpen: false)
	{
	}

	void ICloseEx.CloseEx(CloseExState closeState)
	{
		if (base.BaseStream is ICloseEx closeEx)
		{
			closeEx.CloseEx(closeState);
		}
		else
		{
			Close();
		}
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		try
		{
			return base.BeginRead(buffer, offset, size, callback, state);
		}
		catch (Exception ex)
		{
			try
			{
				if (NclUtilities.IsFatal(ex))
				{
					throw;
				}
				if (ex is InvalidDataException || ex is InvalidOperationException || ex is IndexOutOfRangeException)
				{
					Close();
				}
			}
			catch
			{
			}
			throw ex;
		}
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		try
		{
			return base.EndRead(asyncResult);
		}
		catch (Exception ex)
		{
			try
			{
				if (NclUtilities.IsFatal(ex))
				{
					throw;
				}
				if (ex is InvalidDataException || ex is InvalidOperationException || ex is IndexOutOfRangeException)
				{
					Close();
				}
			}
			catch
			{
			}
			throw ex;
		}
	}

	public override int Read(byte[] buffer, int offset, int size)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		try
		{
			return base.Read(buffer, offset, size);
		}
		catch (Exception ex)
		{
			try
			{
				if (NclUtilities.IsFatal(ex))
				{
					throw;
				}
				if (ex is InvalidDataException || ex is InvalidOperationException || ex is IndexOutOfRangeException)
				{
					Close();
				}
			}
			catch
			{
			}
			throw ex;
		}
	}

	void IRequestLifetimeTracker.TrackRequestLifetime(long requestStartTimestamp)
	{
		IRequestLifetimeTracker requestLifetimeTracker = base.BaseStream as IRequestLifetimeTracker;
		requestLifetimeTracker.TrackRequestLifetime(requestStartTimestamp);
	}
}
