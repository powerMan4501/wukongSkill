using System.Collections.Specialized;
using System.IO;
using System.Net.Mime;

namespace System.Net.Mail;

internal class MailWriter : BaseWriter
{
	internal MailWriter(Stream stream)
		: base(stream, shouldEncodeLeadingDots: true)
	{
	}

	internal override void WriteHeaders(NameValueCollection headers, bool allowUnicode)
	{
		if (headers == null)
		{
			throw new ArgumentNullException("headers");
		}
		foreach (string header in headers)
		{
			string[] values = headers.GetValues(header);
			string[] array = values;
			foreach (string value in array)
			{
				WriteHeader(header, value, allowUnicode);
			}
		}
	}

	internal override void Close()
	{
		bufferBuilder.Append(BaseWriter.CRLF);
		Flush(null);
		stream.Close();
	}

	protected override void OnClose(object sender, EventArgs args)
	{
		contentStream.Flush();
		contentStream = null;
	}
}
