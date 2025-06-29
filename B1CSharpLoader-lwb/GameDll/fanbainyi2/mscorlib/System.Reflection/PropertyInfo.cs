using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Reflection;

[Serializable]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_PropertyInfo))]
[ComVisible(true)]
[__DynamicallyInvokable]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public abstract class PropertyInfo : MemberInfo, _PropertyInfo
{
	public override MemberTypes MemberType => MemberTypes.Property;

	[__DynamicallyInvokable]
	public abstract Type PropertyType
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract PropertyAttributes Attributes
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract bool CanRead
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract bool CanWrite
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public virtual MethodInfo GetMethod
	{
		[__DynamicallyInvokable]
		get
		{
			return GetGetMethod(nonPublic: true);
		}
	}

	[__DynamicallyInvokable]
	public virtual MethodInfo SetMethod
	{
		[__DynamicallyInvokable]
		get
		{
			return GetSetMethod(nonPublic: true);
		}
	}

	[__DynamicallyInvokable]
	public bool IsSpecialName
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & PropertyAttributes.SpecialName) != 0;
		}
	}

	[__DynamicallyInvokable]
	public static bool operator ==(PropertyInfo left, PropertyInfo right)
	{
		if ((object)left == right)
		{
			return true;
		}
		if ((object)left == null || (object)right == null || left is RuntimePropertyInfo || right is RuntimePropertyInfo)
		{
			return false;
		}
		return left.Equals(right);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(PropertyInfo left, PropertyInfo right)
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

	[__DynamicallyInvokable]
	public virtual object GetConstantValue()
	{
		throw new NotImplementedException();
	}

	public virtual object GetRawConstantValue()
	{
		throw new NotImplementedException();
	}

	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[__DynamicallyInvokable]
	public abstract MethodInfo[] GetAccessors(bool nonPublic);

	[__DynamicallyInvokable]
	public abstract MethodInfo GetGetMethod(bool nonPublic);

	[__DynamicallyInvokable]
	public abstract MethodInfo GetSetMethod(bool nonPublic);

	[__DynamicallyInvokable]
	public abstract ParameterInfo[] GetIndexParameters();

	[DebuggerStepThrough]
	[DebuggerHidden]
	[__DynamicallyInvokable]
	public object GetValue(object obj)
	{
		return GetValue(obj, null);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[__DynamicallyInvokable]
	public virtual object GetValue(object obj, object[] index)
	{
		return GetValue(obj, BindingFlags.Default, null, index, null);
	}

	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[DebuggerStepThrough]
	[DebuggerHidden]
	[__DynamicallyInvokable]
	public void SetValue(object obj, object value)
	{
		SetValue(obj, value, null);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[__DynamicallyInvokable]
	public virtual void SetValue(object obj, object value, object[] index)
	{
		SetValue(obj, value, BindingFlags.Default, null, index, null);
	}

	public virtual Type[] GetRequiredCustomModifiers()
	{
		return EmptyArray<Type>.Value;
	}

	public virtual Type[] GetOptionalCustomModifiers()
	{
		return EmptyArray<Type>.Value;
	}

	[__DynamicallyInvokable]
	public MethodInfo[] GetAccessors()
	{
		return GetAccessors(nonPublic: false);
	}

	[__DynamicallyInvokable]
	public MethodInfo GetGetMethod()
	{
		return GetGetMethod(nonPublic: false);
	}

	[__DynamicallyInvokable]
	public MethodInfo GetSetMethod()
	{
		return GetSetMethod(nonPublic: false);
	}

	Type _PropertyInfo.GetType()
	{
		return GetType();
	}

	void _PropertyInfo.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _PropertyInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _PropertyInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _PropertyInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
