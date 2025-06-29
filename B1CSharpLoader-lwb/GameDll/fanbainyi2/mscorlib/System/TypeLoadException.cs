using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class TypeLoadException : SystemException, ISerializable
{
	private string ClassName;

	private string AssemblyName;

	private string MessageArg;

	internal int ResourceId;

	[__DynamicallyInvokable]
	public override string Message
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			SetMessageField();
			return _message;
		}
	}

	[__DynamicallyInvokable]
	public string TypeName
	{
		[__DynamicallyInvokable]
		get
		{
			if (ClassName == null)
			{
				return string.Empty;
			}
			return ClassName;
		}
	}

	[__DynamicallyInvokable]
	public TypeLoadException()
		: base(Environment.GetResourceString("Arg_TypeLoadException"))
	{
		SetErrorCode(-2146233054);
	}

	[__DynamicallyInvokable]
	public TypeLoadException(string message)
		: base(message)
	{
		SetErrorCode(-2146233054);
	}

	[__DynamicallyInvokable]
	public TypeLoadException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233054);
	}

	[SecurityCritical]
	private void SetMessageField()
	{
		if (_message != null)
		{
			return;
		}
		if (ClassName == null && ResourceId == 0)
		{
			_message = Environment.GetResourceString("Arg_TypeLoadException");
			return;
		}
		if (AssemblyName == null)
		{
			AssemblyName = Environment.GetResourceString("IO_UnknownFileName");
		}
		if (ClassName == null)
		{
			ClassName = Environment.GetResourceString("IO_UnknownFileName");
		}
		string s = null;
		GetTypeLoadExceptionMessage(ResourceId, JitHelpers.GetStringHandleOnStack(ref s));
		_message = string.Format(CultureInfo.CurrentCulture, s, ClassName, AssemblyName, MessageArg);
	}

	[SecurityCritical]
	private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId)
		: base(null)
	{
		SetErrorCode(-2146233054);
		ClassName = className;
		AssemblyName = assemblyName;
		MessageArg = messageArg;
		ResourceId = resourceId;
		SetMessageField();
	}

	protected TypeLoadException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		ClassName = info.GetString("TypeLoadClassName");
		AssemblyName = info.GetString("TypeLoadAssemblyName");
		MessageArg = info.GetString("TypeLoadMessageArg");
		ResourceId = info.GetInt32("TypeLoadResourceID");
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetTypeLoadExceptionMessage(int resourceId, StringHandleOnStack retString);

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		base.GetObjectData(info, context);
		info.AddValue("TypeLoadClassName", ClassName, typeof(string));
		info.AddValue("TypeLoadAssemblyName", AssemblyName, typeof(string));
		info.AddValue("TypeLoadMessageArg", MessageArg, typeof(string));
		info.AddValue("TypeLoadResourceID", ResourceId);
	}
}
