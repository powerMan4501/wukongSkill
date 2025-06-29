using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public class EntryPointNotFoundException : TypeLoadException
{
	public EntryPointNotFoundException()
		: base(Environment.GetResourceString("Arg_EntryPointNotFoundException"))
	{
		SetErrorCode(-2146233053);
	}

	public EntryPointNotFoundException(string message)
		: base(message)
	{
		SetErrorCode(-2146233053);
	}

	public EntryPointNotFoundException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233053);
	}

	protected EntryPointNotFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
