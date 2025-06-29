using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class ReflectionTypeLoadException : SystemException, ISerializable
{
	private Type[] _classes;

	private Exception[] _exceptions;

	[__DynamicallyInvokable]
	public Type[] Types
	{
		[__DynamicallyInvokable]
		get
		{
			return _classes;
		}
	}

	[__DynamicallyInvokable]
	public Exception[] LoaderExceptions
	{
		[__DynamicallyInvokable]
		get
		{
			return _exceptions;
		}
	}

	private ReflectionTypeLoadException()
		: base(Environment.GetResourceString("ReflectionTypeLoad_LoadFailed"))
	{
		SetErrorCode(-2146232830);
	}

	private ReflectionTypeLoadException(string message)
		: base(message)
	{
		SetErrorCode(-2146232830);
	}

	[__DynamicallyInvokable]
	public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions)
		: base(null)
	{
		_classes = classes;
		_exceptions = exceptions;
		SetErrorCode(-2146232830);
	}

	[__DynamicallyInvokable]
	public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions, string message)
		: base(message)
	{
		_classes = classes;
		_exceptions = exceptions;
		SetErrorCode(-2146232830);
	}

	internal ReflectionTypeLoadException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		_classes = (Type[])info.GetValue("Types", typeof(Type[]));
		_exceptions = (Exception[])info.GetValue("Exceptions", typeof(Exception[]));
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		base.GetObjectData(info, context);
		info.AddValue("Types", _classes, typeof(Type[]));
		info.AddValue("Exceptions", _exceptions, typeof(Exception[]));
	}
}
