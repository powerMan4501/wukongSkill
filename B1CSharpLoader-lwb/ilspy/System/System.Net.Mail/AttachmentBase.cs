using System.IO;
using System.Net.Mime;
using System.Text;

namespace System.Net.Mail;

public abstract class AttachmentBase : IDisposable
{
	internal bool disposed;

	private MimePart part = new MimePart();

	public Stream ContentStream
	{
		get
		{
			if (disposed)
			{
				throw new ObjectDisposedException(GetType().FullName);
			}
			return part.Stream;
		}
	}

	public string ContentId
	{
		get
		{
			string contentID = part.ContentID;
			if (string.IsNullOrEmpty(contentID))
			{
				return ContentId = Guid.NewGuid().ToString();
			}
			if (contentID.Length >= 2 && contentID[0] == '<' && contentID[contentID.Length - 1] == '>')
			{
				return contentID.Substring(1, contentID.Length - 2);
			}
			return contentID;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				part.ContentID = null;
				return;
			}
			if (value.IndexOfAny(new char[2] { '<', '>' }) != -1)
			{
				throw new ArgumentException(SR.GetString("MailHeaderInvalidCID"), "value");
			}
			part.ContentID = "<" + value + ">";
		}
	}

	public ContentType ContentType
	{
		get
		{
			return part.ContentType;
		}
		set
		{
			part.ContentType = value;
		}
	}

	public TransferEncoding TransferEncoding
	{
		get
		{
			return part.TransferEncoding;
		}
		set
		{
			part.TransferEncoding = value;
		}
	}

	internal Uri ContentLocation
	{
		get
		{
			if (!Uri.TryCreate(part.ContentLocation, UriKind.RelativeOrAbsolute, out var result))
			{
				return null;
			}
			return result;
		}
		set
		{
			part.ContentLocation = ((value == null) ? null : (value.IsAbsoluteUri ? value.AbsoluteUri : value.OriginalString));
		}
	}

	internal MimePart MimePart => part;

	internal AttachmentBase()
	{
	}

	protected AttachmentBase(string fileName)
	{
		SetContentFromFile(fileName, string.Empty);
	}

	protected AttachmentBase(string fileName, string mediaType)
	{
		SetContentFromFile(fileName, mediaType);
	}

	protected AttachmentBase(string fileName, ContentType contentType)
	{
		SetContentFromFile(fileName, contentType);
	}

	protected AttachmentBase(Stream contentStream)
	{
		part.SetContent(contentStream);
	}

	protected AttachmentBase(Stream contentStream, string mediaType)
	{
		part.SetContent(contentStream, null, mediaType);
	}

	internal AttachmentBase(Stream contentStream, string name, string mediaType)
	{
		part.SetContent(contentStream, name, mediaType);
	}

	protected AttachmentBase(Stream contentStream, ContentType contentType)
	{
		part.SetContent(contentStream, contentType);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && !disposed)
		{
			disposed = true;
			part.Dispose();
		}
	}

	internal static string ShortNameFromFile(string fileName)
	{
		int num = fileName.LastIndexOfAny(new char[2] { '\\', ':' }, fileName.Length - 1, fileName.Length);
		if (num > 0)
		{
			return fileName.Substring(num + 1, fileName.Length - num - 1);
		}
		return fileName;
	}

	internal void SetContentFromFile(string fileName, ContentType contentType)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName == string.Empty)
		{
			throw new ArgumentException(SR.GetString("net_emptystringcall", "fileName"), "fileName");
		}
		Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		part.SetContent(stream, contentType);
	}

	internal void SetContentFromFile(string fileName, string mediaType)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName == string.Empty)
		{
			throw new ArgumentException(SR.GetString("net_emptystringcall", "fileName"), "fileName");
		}
		Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		part.SetContent(stream, null, mediaType);
	}

	internal void SetContentFromString(string contentString, ContentType contentType)
	{
		if (contentString == null)
		{
			throw new ArgumentNullException("content");
		}
		if (part.Stream != null)
		{
			part.Stream.Close();
		}
		Encoding encoding = ((contentType != null && contentType.CharSet != null) ? Encoding.GetEncoding(contentType.CharSet) : ((!MimeBasePart.IsAscii(contentString, permitCROrLF: false)) ? Encoding.GetEncoding("utf-8") : Encoding.ASCII));
		byte[] bytes = encoding.GetBytes(contentString);
		part.SetContent(new MemoryStream(bytes), contentType);
		if (MimeBasePart.ShouldUseBase64Encoding(encoding))
		{
			part.TransferEncoding = TransferEncoding.Base64;
		}
		else
		{
			part.TransferEncoding = TransferEncoding.QuotedPrintable;
		}
	}

	internal void SetContentFromString(string contentString, Encoding encoding, string mediaType)
	{
		if (contentString == null)
		{
			throw new ArgumentNullException("content");
		}
		if (part.Stream != null)
		{
			part.Stream.Close();
		}
		if (mediaType == null || mediaType == string.Empty)
		{
			mediaType = "text/plain";
		}
		int offset = 0;
		try
		{
			string text = MailBnfHelper.ReadToken(mediaType, ref offset, null);
			if (text.Length == 0 || offset >= mediaType.Length || mediaType[offset++] != '/')
			{
				throw new ArgumentException(SR.GetString("MediaTypeInvalid"), "mediaType");
			}
			text = MailBnfHelper.ReadToken(mediaType, ref offset, null);
			if (text.Length == 0 || offset < mediaType.Length)
			{
				throw new ArgumentException(SR.GetString("MediaTypeInvalid"), "mediaType");
			}
		}
		catch (FormatException)
		{
			throw new ArgumentException(SR.GetString("MediaTypeInvalid"), "mediaType");
		}
		ContentType contentType = new ContentType(mediaType);
		if (encoding == null)
		{
			encoding = ((!MimeBasePart.IsAscii(contentString, permitCROrLF: false)) ? Encoding.GetEncoding("utf-8") : Encoding.ASCII);
		}
		contentType.CharSet = encoding.BodyName;
		byte[] bytes = encoding.GetBytes(contentString);
		part.SetContent(new MemoryStream(bytes), contentType);
		if (MimeBasePart.ShouldUseBase64Encoding(encoding))
		{
			part.TransferEncoding = TransferEncoding.Base64;
		}
		else
		{
			part.TransferEncoding = TransferEncoding.QuotedPrintable;
		}
	}

	internal virtual void PrepareForSending(bool allowUnicode)
	{
		part.ResetStream();
	}
}
