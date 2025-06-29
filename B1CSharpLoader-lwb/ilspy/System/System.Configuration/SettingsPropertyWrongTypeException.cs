using System.Runtime.Serialization;

namespace System.Configuration;

[Serializable]
public class SettingsPropertyWrongTypeException : Exception
{
	public SettingsPropertyWrongTypeException(string message)
		: base(message)
	{
	}

	public SettingsPropertyWrongTypeException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SettingsPropertyWrongTypeException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public SettingsPropertyWrongTypeException()
	{
	}
}
