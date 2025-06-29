using System.Globalization;
using System.Net.Mime;
using System.Text;

namespace System.Net.Mail;

public class MailAddress
{
	private static readonly char[] s_newLines = new char[2] { '\r', '\n' };

	private readonly Encoding displayNameEncoding;

	private readonly string displayName;

	private readonly string userName;

	private readonly string host;

	private static EncodedStreamFactory encoderFactory = new EncodedStreamFactory();

	public string DisplayName => displayName;

	public string User => userName;

	public string Host => host;

	public string Address => string.Format(CultureInfo.InvariantCulture, "{0}@{1}", new object[2] { userName, host });

	private string SmtpAddress => string.Format(CultureInfo.InvariantCulture, "<{0}>", new object[1] { Address });

	internal MailAddress(string displayName, string userName, string domain)
	{
		host = domain;
		this.userName = userName;
		this.displayName = displayName;
		displayNameEncoding = Encoding.GetEncoding("utf-8");
	}

	public MailAddress(string address)
		: this(address, (string)null, (Encoding)null)
	{
	}

	public MailAddress(string address, string displayName)
		: this(address, displayName, (Encoding)null)
	{
	}

	public MailAddress(string address, string displayName, Encoding displayNameEncoding)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		if (address == string.Empty)
		{
			throw new ArgumentException(SR.GetString("net_emptystringcall", "address"), "address");
		}
		this.displayNameEncoding = displayNameEncoding ?? Encoding.GetEncoding("utf-8");
		this.displayName = displayName ?? string.Empty;
		if (!string.IsNullOrEmpty(this.displayName))
		{
			this.displayName = MailAddressParser.NormalizeOrThrow(this.displayName);
			if (this.displayName.Length >= 2 && this.displayName[0] == '"' && this.displayName[this.displayName.Length - 1] == '"')
			{
				this.displayName = this.displayName.Substring(1, this.displayName.Length - 2);
			}
		}
		MailAddress mailAddress = MailAddressParser.ParseAddress(address);
		host = mailAddress.host;
		userName = mailAddress.userName;
		if (string.IsNullOrEmpty(this.displayName))
		{
			this.displayName = mailAddress.displayName;
		}
	}

	private string GetUser(bool allowUnicode)
	{
		if (!allowUnicode && !MimeBasePart.IsAscii(userName, permitCROrLF: true))
		{
			throw new SmtpException(SR.GetString("SmtpNonAsciiUserNotSupported", Address));
		}
		return userName;
	}

	private string GetHost(bool allowUnicode)
	{
		string ascii = host;
		if (!allowUnicode && !MimeBasePart.IsAscii(ascii, permitCROrLF: true))
		{
			IdnMapping idnMapping = new IdnMapping();
			try
			{
				ascii = idnMapping.GetAscii(ascii);
			}
			catch (ArgumentException innerException)
			{
				throw new SmtpException(SR.GetString("SmtpInvalidHostName", Address), innerException);
			}
		}
		if (!ServicePointManager.AllowFullDomainLiterals && ascii.IndexOfAny(s_newLines) >= 0)
		{
			throw new SmtpException("SmtpInvalidHostName", Address);
		}
		return ascii;
	}

	private string GetAddress(bool allowUnicode)
	{
		return string.Format(CultureInfo.InvariantCulture, "{0}@{1}", new object[2]
		{
			GetUser(allowUnicode),
			GetHost(allowUnicode)
		});
	}

	internal string GetSmtpAddress(bool allowUnicode)
	{
		return string.Format(CultureInfo.InvariantCulture, "<{0}>", new object[1] { GetAddress(allowUnicode) });
	}

	public override string ToString()
	{
		if (string.IsNullOrEmpty(DisplayName))
		{
			return Address;
		}
		return $"\"{DisplayName}\" {SmtpAddress}";
	}

	public override bool Equals(object value)
	{
		if (value == null)
		{
			return false;
		}
		return ToString().Equals(value.ToString(), StringComparison.InvariantCultureIgnoreCase);
	}

	public override int GetHashCode()
	{
		return ToString().GetHashCode();
	}

	internal string Encode(int charsConsumed, bool allowUnicode)
	{
		string empty = string.Empty;
		if (!string.IsNullOrEmpty(displayName))
		{
			if (MimeBasePart.IsAscii(displayName, permitCROrLF: false) || allowUnicode)
			{
				empty = string.Format(CultureInfo.InvariantCulture, "\"{0}\"", new object[1] { displayName });
			}
			else
			{
				IEncodableStream encoderForHeader = encoderFactory.GetEncoderForHeader(displayNameEncoding, useBase64Encoding: false, charsConsumed);
				byte[] bytes = displayNameEncoding.GetBytes(displayName);
				encoderForHeader.EncodeBytes(bytes, 0, bytes.Length);
				empty = encoderForHeader.GetEncodedString();
			}
			return empty + " " + GetSmtpAddress(allowUnicode);
		}
		return GetAddress(allowUnicode);
	}
}
