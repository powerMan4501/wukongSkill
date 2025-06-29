using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Versioning;
using System.Security;

namespace System;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDual)]
[ComVisible(true)]
[__DynamicallyInvokable]
public class Object
{
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[NonVersionable]
	[__DynamicallyInvokable]
	public Object()
	{
	}

	[__DynamicallyInvokable]
	public virtual string ToString()
	{
		return GetType().ToString();
	}

	[__DynamicallyInvokable]
	public virtual bool Equals(object obj)
	{
		return RuntimeHelpers.Equals(this, obj);
	}

	[__DynamicallyInvokable]
	public static bool Equals(object objA, object objB)
	{
		if (objA == objB)
		{
			return true;
		}
		if (objA == null || objB == null)
		{
			return false;
		}
		return objA.Equals(objB);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool ReferenceEquals(object objA, object objB)
	{
		return objA == objB;
	}

	[__DynamicallyInvokable]
	public virtual int GetHashCode()
	{
		return RuntimeHelpers.GetHashCode(this);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public extern Type GetType();

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[NonVersionable]
	[__DynamicallyInvokable]
	~Object()
	{
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	protected extern object MemberwiseClone();

	[SecurityCritical]
	private void FieldSetter(string typeName, string fieldName, object val)
	{
		FieldInfo fieldInfo = GetFieldInfo(typeName, fieldName);
		if (fieldInfo.IsInitOnly)
		{
			throw new FieldAccessException(Environment.GetResourceString("FieldAccess_InitOnly"));
		}
		Message.CoerceArg(val, fieldInfo.FieldType);
		fieldInfo.SetValue(this, val);
	}

	private void FieldGetter(string typeName, string fieldName, ref object val)
	{
		FieldInfo fieldInfo = GetFieldInfo(typeName, fieldName);
		val = fieldInfo.GetValue(this);
	}

	private FieldInfo GetFieldInfo(string typeName, string fieldName)
	{
		Type type = GetType();
		while (null != type && !type.FullName.Equals(typeName))
		{
			type = type.BaseType;
		}
		if (null == type)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_BadType"), typeName));
		}
		FieldInfo field = type.GetField(fieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
		if (null == field)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_BadField"), fieldName, typeName));
		}
		return field;
	}
}
