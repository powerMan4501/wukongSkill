using System.Collections.Specialized;
using System.IO;
using System.Text;

namespace System.Net.Mime;

internal class MimeWriter : BaseWriter
{
	private static byte[] DASHDASH = new byte[2] { 45, 45 };

	private byte[] boundaryBytes;

	private bool writeBoundary = true;

	internal MimeWriter(Stream stream, string boundary)
		: base(stream, shouldEncodeLeadingDots: false)
	{
		if (boundary == null)
		{
			throw new ArgumentNullException("boundary");
		}
		boundaryBytes = Encoding.ASCII.GetBytes(boundary);
	}

	internal override void WriteHeaders(NameValueCollection headers, bool allowUnicode)
	{
		if (headers == null)
		{
			throw new ArgumentNullException("headers");
		}
		foreach (string header in headers)
		{
			WriteHeader(header, headers[header], allowUnicode);
		}
	}

	internal IAsyncResult BeginClose(AsyncCallback callback, object state)
	{
		MultiAsyncResult multiAsyncResult = new MultiAsyncResult(this, callback, state);
		Close(multiAsyncResult);
		multiAsyncResult.CompleteSequence();
		return multiAsyncResult;
	}

	internal void EndClose(IAsyncResult result)
	{
		MultiAsyncResult.End(result);
		stream.Close();
	}

	internal override void Close()
	{
		Close(null);
		stream.Close();
	}

	private void Close(MultiAsyncResult multiResult)
	{
		bufferBuilder.Append(BaseWriter.CRLF);
		bufferBuilder.Append(DASHDASH);
		bufferBuilder.Append(boundaryBytes);
		bufferBuilder.Append(DASHDASH);
		bufferBuilder.Append(BaseWriter.CRLF);
		Flush(multiResult);
	}

	protected override void OnClose(object sender, EventArgs args)
	{
		if (contentStream == sender)
		{
			contentStream.Flush();
			contentStream = null;
			writeBoundary = true;
			isInContent = false;
		}
	}

	protected override void CheckBoundary()
	{
		if (writeBoundary)
		{
			bufferBuilder.Append(BaseWriter.CRLF);
			bufferBuilder.Append(DASHDASH);
			bufferBuilder.Append(boundaryBytes);
			bufferBuilder.Append(BaseWriter.CRLF);
			writeBoundary = false;
		}
	}
}
