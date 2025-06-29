using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Reflection;

[Serializable]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_FieldInfo))]
[ComVisible(true)]
[__DynamicallyInvokable]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public abstract class FieldInfo : MemberInfo, _FieldInfo
{
	public override MemberTypes MemberType => MemberTypes.Field;

	[__DynamicallyInvokable]
	public abstract RuntimeFieldHandle FieldHandle
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract Type FieldType
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract FieldAttributes Attributes
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public bool IsPublic
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Public;
		}
	}

	[__DynamicallyInvokable]
	public bool IsPrivate
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Private;
		}
	}

	[__DynamicallyInvokable]
	public bool IsFamily
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Family;
		}
	}

	[__DynamicallyInvokable]
	public bool IsAssembly
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Assembly;
		}
	}

	[__DynamicallyInvokable]
	public bool IsFamilyAndAssembly
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.FamANDAssem;
		}
	}

	[__DynamicallyInvokable]
	public bool IsFamilyOrAssembly
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.FamORAssem;
		}
	}

	[__DynamicallyInvokable]
	public bool IsStatic
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & FieldAttributes.Static) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsInitOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & FieldAttributes.InitOnly) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsLiteral
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & FieldAttributes.Literal) != 0;
		}
	}

	public bool IsNotSerialized => (Attributes & FieldAttributes.NotSerialized) != 0;

	[__DynamicallyInvokable]
	public bool IsSpecialName
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & FieldAttributes.SpecialName) != 0;
		}
	}

	public bool IsPinvokeImpl => (Attributes & FieldAttributes.PinvokeImpl) != 0;

	public virtual bool IsSecurityCritical => FieldHandle.IsSecurityCritical();

	public virtual bool IsSecuritySafeCritical => FieldHandle.IsSecuritySafeCritical();

	public virtual bool IsSecurityTransparent => FieldHandle.IsSecurityTransparent();

	[__DynamicallyInvokable]
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle)
	{
		if (handle.IsNullHandle())
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidHandle"));
		}
		FieldInfo fieldInfo = RuntimeType.GetFieldInfo(handle.GetRuntimeFieldInfo());
		Type declaringType = fieldInfo.DeclaringType;
		if (declaringType != null && declaringType.IsGenericType)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_FieldDeclaringTypeGeneric"), fieldInfo.Name, declaringType.GetGenericTypeDefinition()));
		}
		return fieldInfo;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType)
	{
		if (handle.IsNullHandle())
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidHandle"));
		}
		return RuntimeType.GetFieldInfo(declaringType.GetRuntimeType(), handle.GetRuntimeFieldInfo());
	}

	[__DynamicallyInvokable]
	public static bool operator ==(FieldInfo left, FieldInfo right)
	{
		if ((object)left == right)
		{
			return true;
		}
		if ((object)left == null || (object)right == null || left is RuntimeFieldInfo || right is RuntimeFieldInfo)
		{
			return false;
		}
		return left.Equals(right);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(FieldInfo left, FieldInfo right)
	{
		return !(left == right);
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		return base.Equals(obj);
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public virtual Type[] GetRequiredCustomModifiers()
	{
		throw new NotImplementedException();
	}

	public virtual Type[] GetOptionalCustomModifiers()
	{
		throw new NotImplementedException();
	}

	[CLSCompliant(false)]
	public virtual void SetValueDirect(TypedReference obj, object value)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_AbstractNonCLS"));
	}

	[CLSCompliant(false)]
	public virtual object GetValueDirect(TypedReference obj)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_AbstractNonCLS"));
	}

	[__DynamicallyInvokable]
	public abstract object GetValue(object obj);

	public virtual object GetRawConstantValue()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_AbstractNonCLS"));
	}

	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[DebuggerStepThrough]
	[DebuggerHidden]
	[__DynamicallyInvokable]
	public void SetValue(object obj, object value)
	{
		SetValue(obj, value, BindingFlags.Default, Type.DefaultBinder, null);
	}

	Type _FieldInfo.GetType()
	{
		return GetType();
	}

	void _FieldInfo.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _FieldInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _FieldInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _FieldInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
