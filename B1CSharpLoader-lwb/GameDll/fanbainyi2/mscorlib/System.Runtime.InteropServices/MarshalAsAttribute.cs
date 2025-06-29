using System.Reflection;
using System.Security;

namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class MarshalAsAttribute : Attribute
{
	internal UnmanagedType _val;

	[__DynamicallyInvokable]
	public VarEnum SafeArraySubType;

	[__DynamicallyInvokable]
	public Type SafeArrayUserDefinedSubType;

	[__DynamicallyInvokable]
	public int IidParameterIndex;

	[__DynamicallyInvokable]
	public UnmanagedType ArraySubType;

	[__DynamicallyInvokable]
	public short SizeParamIndex;

	[__DynamicallyInvokable]
	public int SizeConst;

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public string MarshalType;

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public Type MarshalTypeRef;

	[__DynamicallyInvokable]
	public string MarshalCookie;

	[__DynamicallyInvokable]
	public UnmanagedType Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _val;
		}
	}

	[SecurityCritical]
	internal static Attribute GetCustomAttribute(RuntimeParameterInfo parameter)
	{
		return GetCustomAttribute(parameter.MetadataToken, parameter.GetRuntimeModule());
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeParameterInfo parameter)
	{
		return GetCustomAttribute(parameter) != null;
	}

	[SecurityCritical]
	internal static Attribute GetCustomAttribute(RuntimeFieldInfo field)
	{
		return GetCustomAttribute(field.MetadataToken, field.GetRuntimeModule());
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeFieldInfo field)
	{
		return GetCustomAttribute(field) != null;
	}

	[SecurityCritical]
	internal static Attribute GetCustomAttribute(int token, RuntimeModule scope)
	{
		int sizeParamIndex = 0;
		int sizeConst = 0;
		string marshalType = null;
		string marshalCookie = null;
		string safeArrayUserDefinedSubType = null;
		int iidParamIndex = 0;
		ConstArray fieldMarshal = ModuleHandle.GetMetadataImport(scope.GetNativeHandle()).GetFieldMarshal(token);
		if (fieldMarshal.Length == 0)
		{
			return null;
		}
		MetadataImport.GetMarshalAs(fieldMarshal, out var unmanagedType, out var safeArraySubType, out safeArrayUserDefinedSubType, out var arraySubType, out sizeParamIndex, out sizeConst, out marshalType, out marshalCookie, out iidParamIndex);
		RuntimeType safeArrayUserDefinedSubType2 = ((safeArrayUserDefinedSubType == null || safeArrayUserDefinedSubType.Length == 0) ? null : RuntimeTypeHandle.GetTypeByNameUsingCARules(safeArrayUserDefinedSubType, scope));
		RuntimeType marshalTypeRef = null;
		try
		{
			marshalTypeRef = ((marshalType == null) ? null : RuntimeTypeHandle.GetTypeByNameUsingCARules(marshalType, scope));
		}
		catch (TypeLoadException)
		{
		}
		return new MarshalAsAttribute(unmanagedType, safeArraySubType, safeArrayUserDefinedSubType2, arraySubType, (short)sizeParamIndex, sizeConst, marshalType, marshalTypeRef, marshalCookie, iidParamIndex);
	}

	internal MarshalAsAttribute(UnmanagedType val, VarEnum safeArraySubType, RuntimeType safeArrayUserDefinedSubType, UnmanagedType arraySubType, short sizeParamIndex, int sizeConst, string marshalType, RuntimeType marshalTypeRef, string marshalCookie, int iidParamIndex)
	{
		_val = val;
		SafeArraySubType = safeArraySubType;
		SafeArrayUserDefinedSubType = safeArrayUserDefinedSubType;
		IidParameterIndex = iidParamIndex;
		ArraySubType = arraySubType;
		SizeParamIndex = sizeParamIndex;
		SizeConst = sizeConst;
		MarshalType = marshalType;
		MarshalTypeRef = marshalTypeRef;
		MarshalCookie = marshalCookie;
	}

	[__DynamicallyInvokable]
	public MarshalAsAttribute(UnmanagedType unmanagedType)
	{
		_val = unmanagedType;
	}

	[__DynamicallyInvokable]
	public MarshalAsAttribute(short unmanagedType)
	{
		_val = (UnmanagedType)unmanagedType;
	}
}
