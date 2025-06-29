using System.Collections.Specialized;
using System.IO;
using System.Net.Mail;

namespace System.Net.Mime;

internal abstract class BaseWriter
{
	private static int DefaultLineLength = 76;

	private static AsyncCallback onWrite = OnWrite;

	protected static byte[] CRLF = new byte[2] { 13, 10 };

	protected BufferBuilder bufferBuilder;

	protected Stream contentStream;

	protected bool isInContent;

	protected Stream stream;

	private int lineLength;

	private EventHandler onCloseHandler;

	private bool shouldEncodeLeadingDots;

	protected BaseWriter(Stream stream, bool shouldEncodeLeadingDots)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		this.stream = stream;
		this.shouldEncodeLeadingDots = shouldEncodeLeadingDots;
		onCloseHandler = OnClose;
		bufferBuilder = new BufferBuilder();
		lineLength = DefaultLineLength;
	}

	internal abstract void WriteHeaders(NameValueCollection headers, bool allowUnicode);

	internal void WriteHeader(string name, string value, bool allowUnicode)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (isInContent)
		{
			throw new InvalidOperationException(SR.GetString("MailWriterIsInContent"));
		}
		CheckBoundary();
		bufferBuilder.Append(name);
		bufferBuilder.Append(": ");
		WriteAndFold(value, name.Length + 2, allowUnicode);
		bufferBuilder.Append(CRLF);
	}

	private void WriteAndFold(string value, int charsAlreadyOnLine, bool allowUnicode)
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < value.Length; i++)
		{
			if (MailBnfHelper.IsFWSAt(value, i))
			{
				i += 2;
				bufferBuilder.Append(value, num2, i - num2, allowUnicode);
				num2 = i;
				num = i;
				charsAlreadyOnLine = 0;
			}
			else if (i - num2 > lineLength - charsAlreadyOnLine && num != num2)
			{
				bufferBuilder.Append(value, num2, num - num2, allowUnicode);
				bufferBuilder.Append(CRLF);
				num2 = num;
				charsAlreadyOnLine = 0;
			}
			else if (value[i] == MailBnfHelper.Space || value[i] == MailBnfHelper.Tab)
			{
				num = i;
			}
		}
		if (value.Length - num2 > 0)
		{
			bufferBuilder.Append(value, num2, value.Length - num2, allowUnicode);
		}
	}

	internal Stream GetContentStream()
	{
		return GetContentStream(null);
	}

	private Stream GetContentStream(MultiAsyncResult multiResult)
	{
		if (isInContent)
		{
			throw new InvalidOperationException(SR.GetString("MailWriterIsInContent"));
		}
		isInContent = true;
		CheckBoundary();
		bufferBuilder.Append(CRLF);
		Flush(multiResult);
		Stream stream = new EightBitStream(this.stream, shouldEncodeLeadingDots);
		return contentStream = new ClosableStream(stream, onCloseHandler);
	}

	internal IAsyncResult BeginGetContentStream(AsyncCallback callback, object state)
	{
		MultiAsyncResult multiAsyncResult = new MultiAsyncResult(this, callback, state);
		Stream result = GetContentStream(multiAsyncResult);
		if (!(multiAsyncResult.Result is Exception))
		{
			multiAsyncResult.Result = result;
		}
		multiAsyncResult.CompleteSequence();
		return multiAsyncResult;
	}

	internal Stream EndGetContentStream(IAsyncResult result)
	{
		object obj = MultiAsyncResult.End(result);
		if (obj is Exception)
		{
			throw (Exception)obj;
		}
		return (Stream)obj;
	}

	protected void Flush(MultiAsyncResult multiResult)
	{
		if (bufferBuilder.Length <= 0)
		{
			return;
		}
		if (multiResult != null)
		{
			multiResult.Enter();
			IAsyncResult asyncResult = stream.BeginWrite(bufferBuilder.GetBuffer(), 0, bufferBuilder.Length, onWrite, multiResult);
			if (asyncResult.CompletedSynchronously)
			{
				stream.EndWrite(asyncResult);
				multiResult.Leave();
			}
		}
		else
		{
			stream.Write(bufferBuilder.GetBuffer(), 0, bufferBuilder.Length);
		}
		bufferBuilder.Reset();
	}

	protected static void OnWrite(IAsyncResult result)
	{
		if (!result.CompletedSynchronously)
		{
			MultiAsyncResult multiAsyncResult = (MultiAsyncResult)result.AsyncState;
			BaseWriter baseWriter = (BaseWriter)multiAsyncResult.Context;
			try
			{
				baseWriter.stream.EndWrite(result);
				multiAsyncResult.Leave();
			}
			catch (Exception result2)
			{
				multiAsyncResult.Leave(result2);
			}
		}
	}

	internal abstract void Close();

	protected abstract void OnClose(object sender, EventArgs args);

	protected virtual void CheckBoundary()
	{
	}
}
