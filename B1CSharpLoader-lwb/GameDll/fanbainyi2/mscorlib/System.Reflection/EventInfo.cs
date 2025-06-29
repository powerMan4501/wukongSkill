using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;

namespace System.Reflection;

[Serializable]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_EventInfo))]
[ComVisible(true)]
[__DynamicallyInvokable]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public abstract class EventInfo : MemberInfo, _EventInfo
{
	public override MemberTypes MemberType => MemberTypes.Event;

	[__DynamicallyInvokable]
	public abstract EventAttributes Attributes
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public virtual MethodInfo AddMethod
	{
		[__DynamicallyInvokable]
		get
		{
			return GetAddMethod(nonPublic: true);
		}
	}

	[__DynamicallyInvokable]
	public virtual MethodInfo RemoveMethod
	{
		[__DynamicallyInvokable]
		get
		{
			return GetRemoveMethod(nonPublic: true);
		}
	}

	[__DynamicallyInvokable]
	public virtual MethodInfo RaiseMethod
	{
		[__DynamicallyInvokable]
		get
		{
			return GetRaiseMethod(nonPublic: true);
		}
	}

	[__DynamicallyInvokable]
	public virtual Type EventHandlerType
	{
		[__DynamicallyInvokable]
		get
		{
			MethodInfo addMethod = GetAddMethod(nonPublic: true);
			ParameterInfo[] parametersNoCopy = addMethod.GetParametersNoCopy();
			Type typeFromHandle = typeof(Delegate);
			for (int i = 0; i < parametersNoCopy.Length; i++)
			{
				Type parameterType = parametersNoCopy[i].ParameterType;
				if (parameterType.IsSubclassOf(typeFromHandle))
				{
					return parameterType;
				}
			}
			return null;
		}
	}

	[__DynamicallyInvokable]
	public bool IsSpecialName
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & EventAttributes.SpecialName) != 0;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsMulticast
	{
		[__DynamicallyInvokable]
		get
		{
			Type eventHandlerType = EventHandlerType;
			Type typeFromHandle = typeof(MulticastDelegate);
			return typeFromHandle.IsAssignableFrom(eventHandlerType);
		}
	}

	[__DynamicallyInvokable]
	public static bool operator ==(EventInfo left, EventInfo right)
	{
		if ((object)left == right)
		{
			return true;
		}
		if ((object)left == null || (object)right == null || left is RuntimeEventInfo || right is RuntimeEventInfo)
		{
			return false;
		}
		return left.Equals(right);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(EventInfo left, EventInfo right)
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

	public virtual MethodInfo[] GetOtherMethods(bool nonPublic)
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public abstract MethodInfo GetAddMethod(bool nonPublic);

	[__DynamicallyInvokable]
	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	[__DynamicallyInvokable]
	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	public MethodInfo[] GetOtherMethods()
	{
		return GetOtherMethods(nonPublic: false);
	}

	[__DynamicallyInvokable]
	public MethodInfo GetAddMethod()
	{
		return GetAddMethod(nonPublic: false);
	}

	[__DynamicallyInvokable]
	public MethodInfo GetRemoveMethod()
	{
		return GetRemoveMethod(nonPublic: false);
	}

	[__DynamicallyInvokable]
	public MethodInfo GetRaiseMethod()
	{
		return GetRaiseMethod(nonPublic: false);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[__DynamicallyInvokable]
	public virtual void AddEventHandler(object target, Delegate handler)
	{
		MethodInfo addMethod = GetAddMethod();
		if (addMethod == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NoPublicAddMethod"));
		}
		if (addMethod.ReturnType == typeof(EventRegistrationToken))
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotSupportedOnWinRTEvent"));
		}
		addMethod.Invoke(target, new object[1] { handler });
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[__DynamicallyInvokable]
	public virtual void RemoveEventHandler(object target, Delegate handler)
	{
		MethodInfo removeMethod = GetRemoveMethod();
		if (removeMethod == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NoPublicRemoveMethod"));
		}
		ParameterInfo[] parametersNoCopy = removeMethod.GetParametersNoCopy();
		if (parametersNoCopy[0].ParameterType == typeof(EventRegistrationToken))
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotSupportedOnWinRTEvent"));
		}
		removeMethod.Invoke(target, new object[1] { handler });
	}

	Type _EventInfo.GetType()
	{
		return GetType();
	}

	void _EventInfo.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _EventInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _EventInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _EventInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
