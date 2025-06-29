using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class CultureNotFoundException : ArgumentException, ISerializable
{
	private string m_invalidCultureName;

	private int? m_invalidCultureId;

	public virtual int? InvalidCultureId => m_invalidCultureId;

	[__DynamicallyInvokable]
	public virtual string InvalidCultureName
	{
		[__DynamicallyInvokable]
		get
		{
			return m_invalidCultureName;
		}
	}

	private static string DefaultMessage => Environment.GetResourceString("Argument_CultureNotSupported");

	private string FormatedInvalidCultureId
	{
		get
		{
			if (InvalidCultureId.HasValue)
			{
				return string.Format(CultureInfo.InvariantCulture, "{0} (0x{0:x4})", InvalidCultureId.Value);
			}
			return InvalidCultureName;
		}
	}

	[__DynamicallyInvokable]
	public override string Message
	{
		[__DynamicallyInvokable]
		get
		{
			string message = base.Message;
			if (m_invalidCultureId.HasValue || m_invalidCultureName != null)
			{
				string resourceString = Environment.GetResourceString("Argument_CultureInvalidIdentifier", FormatedInvalidCultureId);
				if (message == null)
				{
					return resourceString;
				}
				return message + Environment.NewLine + resourceString;
			}
			return message;
		}
	}

	[__DynamicallyInvokable]
	public CultureNotFoundException()
		: base(DefaultMessage)
	{
	}

	[__DynamicallyInvokable]
	public CultureNotFoundException(string message)
		: base(message)
	{
	}

	[__DynamicallyInvokable]
	public CultureNotFoundException(string paramName, string message)
		: base(message, paramName)
	{
	}

	[__DynamicallyInvokable]
	public CultureNotFoundException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public CultureNotFoundException(string paramName, int invalidCultureId, string message)
		: base(message, paramName)
	{
		m_invalidCultureId = invalidCultureId;
	}

	public CultureNotFoundException(string message, int invalidCultureId, Exception innerException)
		: base(message, innerException)
	{
		m_invalidCultureId = invalidCultureId;
	}

	[__DynamicallyInvokable]
	public CultureNotFoundException(string paramName, string invalidCultureName, string message)
		: base(message, paramName)
	{
		m_invalidCultureName = invalidCultureName;
	}

	[__DynamicallyInvokable]
	public CultureNotFoundException(string message, string invalidCultureName, Exception innerException)
		: base(message, innerException)
	{
		m_invalidCultureName = invalidCultureName;
	}

	protected CultureNotFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		m_invalidCultureId = (int?)info.GetValue("InvalidCultureId", typeof(int?));
		m_invalidCultureName = (string)info.GetValue("InvalidCultureName", typeof(string));
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		base.GetObjectData(info, context);
		int? num = null;
		num = m_invalidCultureId;
		info.AddValue("InvalidCultureId", num, typeof(int?));
		info.AddValue("InvalidCultureName", m_invalidCultureName, typeof(string));
	}
}
