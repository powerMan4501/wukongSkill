using System.Reflection;
using System.Security;

namespace System.Runtime.InteropServices;

[SecuritySafeCritical]
[global::__DynamicallyInvokable]
public class ComAwareEventInfo : EventInfo
{
	private EventInfo _innerEventInfo;

	[global::__DynamicallyInvokable]
	public override EventAttributes Attributes
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _innerEventInfo.Attributes;
		}
	}

	[global::__DynamicallyInvokable]
	public override Type DeclaringType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _innerEventInfo.DeclaringType;
		}
	}

	[global::__DynamicallyInvokable]
	public override string Name
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _innerEventInfo.Name;
		}
	}

	[global::__DynamicallyInvokable]
	public override Type ReflectedType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _innerEventInfo.ReflectedType;
		}
	}

	[global::__DynamicallyInvokable]
	public ComAwareEventInfo(Type type, string eventName)
	{
		_innerEventInfo = type.GetEvent(eventName);
	}

	[global::__DynamicallyInvokable]
	public override void AddEventHandler(object target, Delegate handler)
	{
		if (Marshal.IsComObject(target))
		{
			GetDataForComInvocation(_innerEventInfo, out var sourceIid, out var dispid);
			ComEventsHelper.Combine(target, sourceIid, dispid, handler);
		}
		else
		{
			_innerEventInfo.AddEventHandler(target, handler);
		}
	}

	[global::__DynamicallyInvokable]
	public override void RemoveEventHandler(object target, Delegate handler)
	{
		if (Marshal.IsComObject(target))
		{
			GetDataForComInvocation(_innerEventInfo, out var sourceIid, out var dispid);
			ComEventsHelper.Remove(target, sourceIid, dispid, handler);
		}
		else
		{
			_innerEventInfo.RemoveEventHandler(target, handler);
		}
	}

	[global::__DynamicallyInvokable]
	public override MethodInfo GetAddMethod(bool nonPublic)
	{
		return _innerEventInfo.GetAddMethod(nonPublic);
	}

	[global::__DynamicallyInvokable]
	public override MethodInfo GetRaiseMethod(bool nonPublic)
	{
		return _innerEventInfo.GetRaiseMethod(nonPublic);
	}

	[global::__DynamicallyInvokable]
	public override MethodInfo GetRemoveMethod(bool nonPublic)
	{
		return _innerEventInfo.GetRemoveMethod(nonPublic);
	}

	[global::__DynamicallyInvokable]
	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return _innerEventInfo.GetCustomAttributes(attributeType, inherit);
	}

	[global::__DynamicallyInvokable]
	public override object[] GetCustomAttributes(bool inherit)
	{
		return _innerEventInfo.GetCustomAttributes(inherit);
	}

	[global::__DynamicallyInvokable]
	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return _innerEventInfo.IsDefined(attributeType, inherit);
	}

	private static void GetDataForComInvocation(EventInfo eventInfo, out Guid sourceIid, out int dispid)
	{
		object[] customAttributes = eventInfo.DeclaringType.GetCustomAttributes(typeof(ComEventInterfaceAttribute), inherit: false);
		if (customAttributes == null || customAttributes.Length == 0)
		{
			throw new InvalidOperationException("event invocation for COM objects requires interface to be attributed with ComSourceInterfaceGuidAttribute");
		}
		if (customAttributes.Length > 1)
		{
			throw new AmbiguousMatchException("more than one ComSourceInterfaceGuidAttribute found");
		}
		Type sourceInterface = ((ComEventInterfaceAttribute)customAttributes[0]).SourceInterface;
		Guid gUID = sourceInterface.GUID;
		MethodInfo method = sourceInterface.GetMethod(eventInfo.Name);
		Attribute customAttribute = Attribute.GetCustomAttribute(method, typeof(DispIdAttribute));
		if (customAttribute == null)
		{
			throw new InvalidOperationException("event invocation for COM objects requires event to be attributed with DispIdAttribute");
		}
		sourceIid = gUID;
		dispid = ((DispIdAttribute)customAttribute).Value;
	}
}
