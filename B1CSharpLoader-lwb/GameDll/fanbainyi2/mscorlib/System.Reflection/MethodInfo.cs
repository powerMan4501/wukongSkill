using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Reflection;

[Serializable]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_MethodInfo))]
[ComVisible(true)]
[__DynamicallyInvokable]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public abstract class MethodInfo : MethodBase, _MethodInfo
{
	public override MemberTypes MemberType => MemberTypes.Method;

	[__DynamicallyInvokable]
	public virtual Type ReturnType
	{
		[__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public virtual ParameterInfo ReturnParameter
	{
		[__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	public abstract ICustomAttributeProvider ReturnTypeCustomAttributes { get; }

	[__DynamicallyInvokable]
	public static bool operator ==(MethodInfo left, MethodInfo right)
	{
		if ((object)left == right)
		{
			return true;
		}
		if ((object)left == null || (object)right == null || left is RuntimeMethodInfo || right is RuntimeMethodInfo)
		{
			return false;
		}
		return left.Equals(right);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(MethodInfo left, MethodInfo right)
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
	public abstract MethodInfo GetBaseDefinition();

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public override Type[] GetGenericArguments()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public virtual MethodInfo GetGenericMethodDefinition()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	[__DynamicallyInvokable]
	public virtual MethodInfo MakeGenericMethod(params Type[] typeArguments)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	[__DynamicallyInvokable]
	public virtual Delegate CreateDelegate(Type delegateType)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	[__DynamicallyInvokable]
	public virtual Delegate CreateDelegate(Type delegateType, object target)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	Type _MethodInfo.GetType()
	{
		return GetType();
	}

	void _MethodInfo.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _MethodInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _MethodInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _MethodInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
