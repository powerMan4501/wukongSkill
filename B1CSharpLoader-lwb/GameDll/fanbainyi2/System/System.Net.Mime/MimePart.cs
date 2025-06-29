using System.IO;
using System.Net.Mail;

namespace System.Net.Mime;

internal class MimePart : MimeBasePart, IDisposable
{
	internal class MimePartContext
	{
		internal Stream outputStream;

		internal LazyAsyncResult result;

		internal int bytesLeft;

		internal BaseWriter writer;

		internal byte[] buffer;

		internal bool completed;

		internal bool completedSynchronously = true;

		internal MimePartContext(BaseWriter writer, LazyAsyncResult result)
		{
			this.writer = writer;
			this.result = result;
			buffer = new byte[17408];
		}
	}

	private Stream stream;

	private bool streamSet;

	private bool streamUsedOnce;

	private AsyncCallback readCallback;

	private AsyncCallback writeCallback;

	private const int maxBufferSize = 17408;

	internal Stream Stream => stream;

	internal ContentDisposition ContentDisposition
	{
		get
		{
			return contentDisposition;
		}
		set
		{
			contentDisposition = value;
			if (value == null)
			{
				((HeaderCollection)base.Headers).InternalRemove(MailHeaderInfo.GetString(MailHeaderID.ContentDisposition));
			}
			else
			{
				contentDisposition.PersistIfNeeded((HeaderCollection)base.Headers, forcePersist: true);
			}
		}
	}

	internal TransferEncoding TransferEncoding
	{
		get
		{
			string text = base.Headers[MailHeaderInfo.GetString(MailHeaderID.ContentTransferEncoding)];
			if (text.Equals("base64", StringComparison.OrdinalIgnoreCase))
			{
				return TransferEncoding.Base64;
			}
			if (text.Equals("quoted-printable", StringComparison.OrdinalIgnoreCase))
			{
				return TransferEncoding.QuotedPrintable;
			}
			if (text.Equals("7bit", StringComparison.OrdinalIgnoreCase))
			{
				return TransferEncoding.SevenBit;
			}
			if (text.Equals("8bit", StringComparison.OrdinalIgnoreCase))
			{
				return TransferEncoding.EightBit;
			}
			return TransferEncoding.Unknown;
		}
		set
		{
			switch (value)
			{
			case TransferEncoding.Base64:
				base.Headers[MailHeaderInfo.GetString(MailHeaderID.ContentTransferEncoding)] = "base64";
				break;
			case TransferEncoding.QuotedPrintable:
				base.Headers[MailHeaderInfo.GetString(MailHeaderID.ContentTransferEncoding)] = "quoted-printable";
				break;
			case TransferEncoding.SevenBit:
				base.Headers[MailHeaderInfo.GetString(MailHeaderID.ContentTransferEncoding)] = "7bit";
				break;
			case TransferEncoding.EightBit:
				base.Headers[MailHeaderInfo.GetString(MailHeaderID.ContentTransferEncoding)] = "8bit";
				break;
			default:
				throw new NotSupportedException(SR.GetString("MimeTransferEncodingNotSupported", value));
			}
		}
	}

	internal MimePart()
	{
	}

	public void Dispose()
	{
		if (stream != null)
		{
			stream.Close();
		}
	}

	internal void SetContent(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (streamSet)
		{
			this.stream.Close();
			this.stream = null;
			streamSet = false;
		}
		this.stream = stream;
		streamSet = true;
		streamUsedOnce = false;
		TransferEncoding = TransferEncoding.Base64;
	}

	internal void SetContent(Stream stream, string name, string mimeType)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (mimeType != null && mimeType != string.Empty)
		{
			contentType = new ContentType(mimeType);
		}
		if (name != null && name != string.Empty)
		{
			base.ContentType.Name = name;
		}
		SetContent(stream);
	}

	internal void SetContent(Stream stream, ContentType contentType)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		base.contentType = contentType;
		SetContent(stream);
	}

	internal void Complete(IAsyncResult result, Exception e)
	{
		MimePartContext mimePartContext = (MimePartContext)result.AsyncState;
		if (mimePartContext.completed)
		{
			throw e;
		}
		try
		{
			if (mimePartContext.outputStream != null)
			{
				mimePartContext.outputStream.Close();
			}
		}
		catch (Exception ex)
		{
			if (e == null)
			{
				e = ex;
			}
		}
		mimePartContext.completed = true;
		mimePartContext.result.InvokeCallback(e);
	}

	internal void ReadCallback(IAsyncResult result)
	{
		if (result.CompletedSynchronously)
		{
			return;
		}
		((MimePartContext)result.AsyncState).completedSynchronously = false;
		try
		{
			ReadCallbackHandler(result);
		}
		catch (Exception e)
		{
			Complete(result, e);
		}
	}

	internal void ReadCallbackHandler(IAsyncResult result)
	{
		MimePartContext mimePartContext = (MimePartContext)result.AsyncState;
		mimePartContext.bytesLeft = Stream.EndRead(result);
		if (mimePartContext.bytesLeft > 0)
		{
			IAsyncResult asyncResult = mimePartContext.outputStream.BeginWrite(mimePartContext.buffer, 0, mimePartContext.bytesLeft, writeCallback, mimePartContext);
			if (asyncResult.CompletedSynchronously)
			{
				WriteCallbackHandler(asyncResult);
			}
		}
		else
		{
			Complete(result, null);
		}
	}

	internal void WriteCallback(IAsyncResult result)
	{
		if (result.CompletedSynchronously)
		{
			return;
		}
		((MimePartContext)result.AsyncState).completedSynchronously = false;
		try
		{
			WriteCallbackHandler(result);
		}
		catch (Exception e)
		{
			Complete(result, e);
		}
	}

	internal void WriteCallbackHandler(IAsyncResult result)
	{
		MimePartContext mimePartContext = (MimePartContext)result.AsyncState;
		mimePartContext.outputStream.EndWrite(result);
		IAsyncResult asyncResult = Stream.BeginRead(mimePartContext.buffer, 0, mimePartContext.buffer.Length, readCallback, mimePartContext);
		if (asyncResult.CompletedSynchronously)
		{
			ReadCallbackHandler(asyncResult);
		}
	}

	internal Stream GetEncodedStream(Stream stream)
	{
		Stream result = stream;
		if (TransferEncoding == TransferEncoding.Base64)
		{
			result = new Base64Stream(result, new Base64WriteStateInfo());
		}
		else if (TransferEncoding == TransferEncoding.QuotedPrintable)
		{
			result = new QuotedPrintableStream(result, encodeCRLF: true);
		}
		else if (TransferEncoding == TransferEncoding.SevenBit || TransferEncoding == TransferEncoding.EightBit)
		{
			result = new EightBitStream(result);
		}
		return result;
	}

	internal void ContentStreamCallbackHandler(IAsyncResult result)
	{
		MimePartContext mimePartContext = (MimePartContext)result.AsyncState;
		Stream stream = mimePartContext.writer.EndGetContentStream(result);
		mimePartContext.outputStream = GetEncodedStream(stream);
		readCallback = ReadCallback;
		writeCallback = WriteCallback;
		IAsyncResult asyncResult = Stream.BeginRead(mimePartContext.buffer, 0, mimePartContext.buffer.Length, readCallback, mimePartContext);
		if (asyncResult.CompletedSynchronously)
		{
			ReadCallbackHandler(asyncResult);
		}
	}

	internal void ContentStreamCallback(IAsyncResult result)
	{
		if (result.CompletedSynchronously)
		{
			return;
		}
		((MimePartContext)result.AsyncState).completedSynchronously = false;
		try
		{
			ContentStreamCallbackHandler(result);
		}
		catch (Exception e)
		{
			Complete(result, e);
		}
	}

	internal override IAsyncResult BeginSend(BaseWriter writer, AsyncCallback callback, bool allowUnicode, object state)
	{
		PrepareHeaders(allowUnicode);
		writer.WriteHeaders(base.Headers, allowUnicode);
		MimePartAsyncResult result = new MimePartAsyncResult(this, state, callback);
		MimePartContext state2 = new MimePartContext(writer, result);
		ResetStream();
		streamUsedOnce = true;
		IAsyncResult asyncResult = writer.BeginGetContentStream(ContentStreamCallback, state2);
		if (asyncResult.CompletedSynchronously)
		{
			ContentStreamCallbackHandler(asyncResult);
		}
		return result;
	}

	internal override void Send(BaseWriter writer, bool allowUnicode)
	{
		if (Stream != null)
		{
			byte[] buffer = new byte[17408];
			PrepareHeaders(allowUnicode);
			writer.WriteHeaders(base.Headers, allowUnicode);
			Stream contentStream = writer.GetContentStream();
			contentStream = GetEncodedStream(contentStream);
			ResetStream();
			streamUsedOnce = true;
			int count;
			while ((count = Stream.Read(buffer, 0, 17408)) > 0)
			{
				contentStream.Write(buffer, 0, count);
			}
			contentStream.Close();
		}
	}

	internal void ResetStream()
	{
		if (streamUsedOnce)
		{
			if (!Stream.CanSeek)
			{
				throw new InvalidOperationException(SR.GetString("MimePartCantResetStream"));
			}
			Stream.Seek(0L, SeekOrigin.Begin);
			streamUsedOnce = false;
		}
	}
}
