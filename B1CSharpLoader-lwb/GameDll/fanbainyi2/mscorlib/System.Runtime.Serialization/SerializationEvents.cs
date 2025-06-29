using System.Collections.Generic;
using System.Reflection;
using System.Security;

namespace System.Runtime.Serialization;

internal class SerializationEvents
{
	private List<MethodInfo> m_OnSerializingMethods;

	private List<MethodInfo> m_OnSerializedMethods;

	private List<MethodInfo> m_OnDeserializingMethods;

	private List<MethodInfo> m_OnDeserializedMethods;

	internal bool HasOnSerializingEvents
	{
		get
		{
			if (m_OnSerializingMethods == null)
			{
				return m_OnSerializedMethods != null;
			}
			return true;
		}
	}

	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t)
	{
		List<MethodInfo> list = new List<MethodInfo>();
		Type type = t;
		while (type != null && type != typeof(object))
		{
			RuntimeType runtimeType = (RuntimeType)type;
			MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			MethodInfo[] array = methods;
			foreach (MethodInfo methodInfo in array)
			{
				if (methodInfo.IsDefined(attribute, inherit: false))
				{
					list.Add(methodInfo);
				}
			}
			type = type.BaseType;
		}
		list.Reverse();
		if (list.Count != 0)
		{
			return list;
		}
		return null;
	}

	internal SerializationEvents(Type t)
	{
		m_OnSerializingMethods = GetMethodsWithAttribute(typeof(OnSerializingAttribute), t);
		m_OnSerializedMethods = GetMethodsWithAttribute(typeof(OnSerializedAttribute), t);
		m_OnDeserializingMethods = GetMethodsWithAttribute(typeof(OnDeserializingAttribute), t);
		m_OnDeserializedMethods = GetMethodsWithAttribute(typeof(OnDeserializedAttribute), t);
	}

	[SecuritySafeCritical]
	internal void InvokeOnSerializing(object obj, StreamingContext context)
	{
		if (m_OnSerializingMethods == null)
		{
			return;
		}
		object[] array = new object[1] { context };
		SerializationEventHandler serializationEventHandler = null;
		foreach (MethodInfo onSerializingMethod in m_OnSerializingMethods)
		{
			SerializationEventHandler b = (SerializationEventHandler)Delegate.CreateDelegateNoSecurityCheck((RuntimeType)typeof(SerializationEventHandler), obj, onSerializingMethod);
			serializationEventHandler = (SerializationEventHandler)Delegate.Combine(serializationEventHandler, b);
		}
		serializationEventHandler(context);
	}

	[SecuritySafeCritical]
	internal void InvokeOnDeserializing(object obj, StreamingContext context)
	{
		if (m_OnDeserializingMethods == null)
		{
			return;
		}
		object[] array = new object[1] { context };
		SerializationEventHandler serializationEventHandler = null;
		foreach (MethodInfo onDeserializingMethod in m_OnDeserializingMethods)
		{
			SerializationEventHandler b = (SerializationEventHandler)Delegate.CreateDelegateNoSecurityCheck((RuntimeType)typeof(SerializationEventHandler), obj, onDeserializingMethod);
			serializationEventHandler = (SerializationEventHandler)Delegate.Combine(serializationEventHandler, b);
		}
		serializationEventHandler(context);
	}

	[SecuritySafeCritical]
	internal void InvokeOnDeserialized(object obj, StreamingContext context)
	{
		if (m_OnDeserializedMethods == null)
		{
			return;
		}
		object[] array = new object[1] { context };
		SerializationEventHandler serializationEventHandler = null;
		foreach (MethodInfo onDeserializedMethod in m_OnDeserializedMethods)
		{
			SerializationEventHandler b = (SerializationEventHandler)Delegate.CreateDelegateNoSecurityCheck((RuntimeType)typeof(SerializationEventHandler), obj, onDeserializedMethod);
			serializationEventHandler = (SerializationEventHandler)Delegate.Combine(serializationEventHandler, b);
		}
		serializationEventHandler(context);
	}

	[SecurityCritical]
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler)
	{
		if (m_OnSerializedMethods != null)
		{
			foreach (MethodInfo onSerializedMethod in m_OnSerializedMethods)
			{
				SerializationEventHandler b = (SerializationEventHandler)Delegate.CreateDelegateNoSecurityCheck((RuntimeType)typeof(SerializationEventHandler), obj, onSerializedMethod);
				handler = (SerializationEventHandler)Delegate.Combine(handler, b);
			}
		}
		return handler;
	}

	[SecurityCritical]
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler)
	{
		if (m_OnDeserializedMethods != null)
		{
			foreach (MethodInfo onDeserializedMethod in m_OnDeserializedMethods)
			{
				SerializationEventHandler b = (SerializationEventHandler)Delegate.CreateDelegateNoSecurityCheck((RuntimeType)typeof(SerializationEventHandler), obj, onDeserializedMethod);
				handler = (SerializationEventHandler)Delegate.Combine(handler, b);
			}
		}
		return handler;
	}
}
