using System.Runtime.Serialization;

namespace System.Configuration;

[Serializable]
public class SettingsPropertyIsReadOnlyException : Exception
{
	public SettingsPropertyIsReadOnlyException(string message)
		: base(message)
	{
	}

	public SettingsPropertyIsReadOnlyException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SettingsPropertyIsReadOnlyException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public SettingsPropertyIsReadOnlyException()
	{
	}
}
