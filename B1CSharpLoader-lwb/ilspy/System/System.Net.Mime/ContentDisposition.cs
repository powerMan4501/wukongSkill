using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Net.Mail;
using System.Text;

namespace System.Net.Mime;

public class ContentDisposition
{
	private string dispositionType;

	private TrackingValidationObjectDictionary parameters;

	private bool isChanged;

	private bool isPersisted;

	private string disposition;

	private const string creationDate = "creation-date";

	private const string readDate = "read-date";

	private const string modificationDate = "modification-date";

	private const string size = "size";

	private const string fileName = "filename";

	private static readonly TrackingValidationObjectDictionary.ValidateAndParseValue dateParser;

	private static readonly TrackingValidationObjectDictionary.ValidateAndParseValue longParser;

	private static readonly IDictionary<string, TrackingValidationObjectDictionary.ValidateAndParseValue> validators;

	public string DispositionType
	{
		get
		{
			return dispositionType;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value == string.Empty)
			{
				throw new ArgumentException(SR.GetString("net_emptystringset"), "value");
			}
			isChanged = true;
			dispositionType = value;
		}
	}

	public StringDictionary Parameters
	{
		get
		{
			if (parameters == null)
			{
				parameters = new TrackingValidationObjectDictionary(validators);
			}
			return parameters;
		}
	}

	public string FileName
	{
		get
		{
			return Parameters["filename"];
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				Parameters.Remove("filename");
			}
			else
			{
				Parameters["filename"] = value;
			}
		}
	}

	public DateTime CreationDate
	{
		get
		{
			return GetDateParameter("creation-date");
		}
		set
		{
			SmtpDateTime value2 = new SmtpDateTime(value);
			((TrackingValidationObjectDictionary)Parameters).InternalSet("creation-date", value2);
		}
	}

	public DateTime ModificationDate
	{
		get
		{
			return GetDateParameter("modification-date");
		}
		set
		{
			SmtpDateTime value2 = new SmtpDateTime(value);
			((TrackingValidationObjectDictionary)Parameters).InternalSet("modification-date", value2);
		}
	}

	public bool Inline
	{
		get
		{
			return dispositionType == "inline";
		}
		set
		{
			isChanged = true;
			if (value)
			{
				dispositionType = "inline";
			}
			else
			{
				dispositionType = "attachment";
			}
		}
	}

	public DateTime ReadDate
	{
		get
		{
			return GetDateParameter("read-date");
		}
		set
		{
			SmtpDateTime value2 = new SmtpDateTime(value);
			((TrackingValidationObjectDictionary)Parameters).InternalSet("read-date", value2);
		}
	}

	public long Size
	{
		get
		{
			object obj = ((TrackingValidationObjectDictionary)Parameters).InternalGet("size");
			if (obj == null)
			{
				return -1L;
			}
			return (long)obj;
		}
		set
		{
			((TrackingValidationObjectDictionary)Parameters).InternalSet("size", value);
		}
	}

	internal bool IsChanged
	{
		get
		{
			if (!isChanged)
			{
				if (parameters != null)
				{
					return parameters.IsChanged;
				}
				return false;
			}
			return true;
		}
	}

	static ContentDisposition()
	{
		dateParser = (object value) => new SmtpDateTime(value.ToString());
		longParser = delegate(object value)
		{
			if (!long.TryParse(value.ToString(), NumberStyles.None, CultureInfo.InvariantCulture, out var result))
			{
				throw new FormatException(SR.GetString("ContentDispositionInvalid"));
			}
			return result;
		};
		validators = new Dictionary<string, TrackingValidationObjectDictionary.ValidateAndParseValue>();
		validators.Add("creation-date", dateParser);
		validators.Add("modification-date", dateParser);
		validators.Add("read-date", dateParser);
		validators.Add("size", longParser);
	}

	public ContentDisposition()
	{
		isChanged = true;
		dispositionType = "attachment";
		disposition = dispositionType;
	}

	public ContentDisposition(string disposition)
	{
		if (disposition == null)
		{
			throw new ArgumentNullException("disposition");
		}
		isChanged = true;
		this.disposition = disposition;
		ParseValue();
	}

	internal DateTime GetDateParameter(string parameterName)
	{
		if (!(((TrackingValidationObjectDictionary)Parameters).InternalGet(parameterName) is SmtpDateTime smtpDateTime))
		{
			return DateTime.MinValue;
		}
		return smtpDateTime.Date;
	}

	internal void Set(string contentDisposition, HeaderCollection headers)
	{
		disposition = contentDisposition;
		ParseValue();
		headers.InternalSet(MailHeaderInfo.GetString(MailHeaderID.ContentDisposition), ToString());
		isPersisted = true;
	}

	internal void PersistIfNeeded(HeaderCollection headers, bool forcePersist)
	{
		if (IsChanged || !isPersisted || forcePersist)
		{
			headers.InternalSet(MailHeaderInfo.GetString(MailHeaderID.ContentDisposition), ToString());
			isPersisted = true;
		}
	}

	public override string ToString()
	{
		if (disposition == null || isChanged || (parameters != null && parameters.IsChanged))
		{
			disposition = Encode(allowUnicode: false);
			isChanged = false;
			parameters.IsChanged = false;
			isPersisted = false;
		}
		return disposition;
	}

	internal string Encode(bool allowUnicode)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(dispositionType);
		foreach (string key in Parameters.Keys)
		{
			stringBuilder.Append("; ");
			EncodeToBuffer(key, stringBuilder, allowUnicode);
			stringBuilder.Append('=');
			EncodeToBuffer(parameters[key], stringBuilder, allowUnicode);
		}
		return stringBuilder.ToString();
	}

	private static void EncodeToBuffer(string value, StringBuilder builder, bool allowUnicode)
	{
		Encoding encoding = MimeBasePart.DecodeEncoding(value);
		if (encoding != null)
		{
			builder.Append("\"" + value + "\"");
			return;
		}
		if ((allowUnicode && !MailBnfHelper.HasCROrLF(value)) || MimeBasePart.IsAscii(value, permitCROrLF: false))
		{
			MailBnfHelper.GetTokenOrQuotedString(value, builder, allowUnicode);
			return;
		}
		encoding = Encoding.GetEncoding("utf-8");
		builder.Append("\"" + MimeBasePart.EncodeHeaderValue(value, encoding, MimeBasePart.ShouldUseBase64Encoding(encoding)) + "\"");
	}

	public override bool Equals(object rparam)
	{
		if (rparam == null)
		{
			return false;
		}
		return string.Compare(ToString(), rparam.ToString(), StringComparison.OrdinalIgnoreCase) == 0;
	}

	public override int GetHashCode()
	{
		return ToString().ToLowerInvariant().GetHashCode();
	}

	private void ParseValue()
	{
		int offset = 0;
		try
		{
			dispositionType = MailBnfHelper.ReadToken(disposition, ref offset, null);
			if (string.IsNullOrEmpty(dispositionType))
			{
				throw new FormatException(SR.GetString("MailHeaderFieldMalformedHeader"));
			}
			if (parameters == null)
			{
				parameters = new TrackingValidationObjectDictionary(validators);
			}
			else
			{
				parameters.Clear();
			}
			while (MailBnfHelper.SkipCFWS(disposition, ref offset))
			{
				if (disposition[offset++] != ';')
				{
					throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter", disposition[offset - 1]));
				}
				if (MailBnfHelper.SkipCFWS(disposition, ref offset))
				{
					string text = MailBnfHelper.ReadParameterAttribute(disposition, ref offset, null);
					if (disposition[offset++] != '=')
					{
						throw new FormatException(SR.GetString("MailHeaderFieldMalformedHeader"));
					}
					if (!MailBnfHelper.SkipCFWS(disposition, ref offset))
					{
						throw new FormatException(SR.GetString("ContentDispositionInvalid"));
					}
					string value = ((disposition[offset] != '"') ? MailBnfHelper.ReadToken(disposition, ref offset, null) : MailBnfHelper.ReadQuotedString(disposition, ref offset, null));
					if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(value))
					{
						throw new FormatException(SR.GetString("ContentDispositionInvalid"));
					}
					Parameters.Add(text, value);
					continue;
				}
				break;
			}
		}
		catch (FormatException innerException)
		{
			throw new FormatException(SR.GetString("ContentDispositionInvalid"), innerException);
		}
		parameters.IsChanged = false;
	}
}
