using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
[ComVisible(true)]
public class DriveNotFoundException : IOException
{
	public DriveNotFoundException()
		: base(Environment.GetResourceString("Arg_DriveNotFoundException"))
	{
		SetErrorCode(-2147024893);
	}

	public DriveNotFoundException(string message)
		: base(message)
	{
		SetErrorCode(-2147024893);
	}

	public DriveNotFoundException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147024893);
	}

	protected DriveNotFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
