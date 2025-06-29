using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO.IsolatedStorage;

[Serializable]
[ComVisible(true)]
public class IsolatedStorageException : Exception
{
	public IsolatedStorageException()
		: base(Environment.GetResourceString("IsolatedStorage_Exception"))
	{
		SetErrorCode(-2146233264);
	}

	public IsolatedStorageException(string message)
		: base(message)
	{
		SetErrorCode(-2146233264);
	}

	public IsolatedStorageException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233264);
	}

	protected IsolatedStorageException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
