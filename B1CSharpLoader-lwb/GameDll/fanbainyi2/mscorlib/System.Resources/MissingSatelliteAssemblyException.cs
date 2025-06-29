using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Resources;

[Serializable]
[ComVisible(true)]
public class MissingSatelliteAssemblyException : SystemException
{
	private string _cultureName;

	public string CultureName => _cultureName;

	public MissingSatelliteAssemblyException()
		: base(Environment.GetResourceString("MissingSatelliteAssembly_Default"))
	{
		SetErrorCode(-2146233034);
	}

	public MissingSatelliteAssemblyException(string message)
		: base(message)
	{
		SetErrorCode(-2146233034);
	}

	public MissingSatelliteAssemblyException(string message, string cultureName)
		: base(message)
	{
		SetErrorCode(-2146233034);
		_cultureName = cultureName;
	}

	public MissingSatelliteAssemblyException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233034);
	}

	protected MissingSatelliteAssemblyException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
