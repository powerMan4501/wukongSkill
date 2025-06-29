using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System;

[Serializable]
internal sealed class DelegateSerializationHolder : IObjectReference, ISerializable
{
	[Serializable]
	internal class DelegateEntry
	{
		internal string type;

		internal string assembly;

		internal object target;

		internal string targetTypeAssembly;

		internal string targetTypeName;

		internal string methodName;

		internal DelegateEntry delegateEntry;

		internal DelegateEntry Entry
		{
			get
			{
				return delegateEntry;
			}
			set
			{
				delegateEntry = value;
			}
		}

		internal DelegateEntry(string type, string assembly, object target, string targetTypeAssembly, string targetTypeName, string methodName)
		{
			this.type = type;
			this.assembly = assembly;
			this.target = target;
			this.targetTypeAssembly = targetTypeAssembly;
			this.targetTypeName = targetTypeName;
			this.methodName = methodName;
		}
	}

	private DelegateEntry m_delegateEntry;

	private MethodInfo[] m_methods;

	[SecurityCritical]
	internal static DelegateEntry GetDelegateSerializationInfo(SerializationInfo info, Type delegateType, object target, MethodInfo method, int targetIndex)
	{
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		if (!method.IsPublic || (method.DeclaringType != null && !method.DeclaringType.IsVisible))
		{
			new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
		}
		Type baseType = delegateType.BaseType;
		if (baseType == null || (baseType != typeof(Delegate) && baseType != typeof(MulticastDelegate)))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDelegate"), "type");
		}
		if (method.DeclaringType == null)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_GlobalMethodSerialization"));
		}
		DelegateEntry delegateEntry = new DelegateEntry(delegateType.FullName, delegateType.Module.Assembly.FullName, target, method.ReflectedType.Module.Assembly.FullName, method.ReflectedType.FullName, method.Name);
		if (info.MemberCount == 0)
		{
			info.SetType(typeof(DelegateSerializationHolder));
			info.AddValue("Delegate", delegateEntry, typeof(DelegateEntry));
		}
		if (target != null)
		{
			string text = "target" + targetIndex;
			info.AddValue(text, delegateEntry.target);
			delegateEntry.target = text;
		}
		string name = "method" + targetIndex;
		info.AddValue(name, method);
		return delegateEntry;
	}

	[SecurityCritical]
	private DelegateSerializationHolder(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		bool flag = true;
		try
		{
			m_delegateEntry = (DelegateEntry)info.GetValue("Delegate", typeof(DelegateEntry));
		}
		catch
		{
			m_delegateEntry = OldDelegateWireFormat(info, context);
			flag = false;
		}
		if (!flag)
		{
			return;
		}
		DelegateEntry delegateEntry = m_delegateEntry;
		int num = 0;
		while (delegateEntry != null)
		{
			if (delegateEntry.target != null && delegateEntry.target is string name)
			{
				delegateEntry.target = info.GetValue(name, typeof(object));
			}
			num++;
			delegateEntry = delegateEntry.delegateEntry;
		}
		MethodInfo[] array = new MethodInfo[num];
		int i;
		for (i = 0; i < num; i++)
		{
			string name2 = "method" + i;
			array[i] = (MethodInfo)info.GetValueNoThrow(name2, typeof(MethodInfo));
			if (array[i] == null)
			{
				break;
			}
		}
		if (i == num)
		{
			m_methods = array;
		}
	}

	private void ThrowInsufficientState(string field)
	{
		throw new SerializationException(Environment.GetResourceString("Serialization_InsufficientDeserializationState", field));
	}

	private DelegateEntry OldDelegateWireFormat(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		string type = info.GetString("DelegateType");
		string assembly = info.GetString("DelegateAssembly");
		object value = info.GetValue("Target", typeof(object));
		string targetTypeAssembly = info.GetString("TargetTypeAssembly");
		string targetTypeName = info.GetString("TargetTypeName");
		string methodName = info.GetString("MethodName");
		return new DelegateEntry(type, assembly, value, targetTypeAssembly, targetTypeName, methodName);
	}

	[SecurityCritical]
	private Delegate GetDelegate(DelegateEntry de, int index)
	{
		Delegate obj;
		try
		{
			if (de.methodName == null || de.methodName.Length == 0)
			{
				ThrowInsufficientState("MethodName");
			}
			if (de.assembly == null || de.assembly.Length == 0)
			{
				ThrowInsufficientState("DelegateAssembly");
			}
			if (de.targetTypeName == null || de.targetTypeName.Length == 0)
			{
				ThrowInsufficientState("TargetTypeName");
			}
			RuntimeType type = (RuntimeType)Assembly.GetType_Compat(de.assembly, de.type);
			RuntimeType runtimeType = (RuntimeType)Assembly.GetType_Compat(de.targetTypeAssembly, de.targetTypeName);
			if (m_methods == null)
			{
				obj = ((de.target == null) ? Delegate.CreateDelegate(type, runtimeType, de.methodName) : Delegate.CreateDelegate(type, RemotingServices.CheckCast(de.target, runtimeType), de.methodName));
			}
			else
			{
				object firstArgument = ((de.target != null) ? RemotingServices.CheckCast(de.target, runtimeType) : null);
				obj = Delegate.CreateDelegateNoSecurityCheck(type, firstArgument, m_methods[index]);
			}
			if ((obj.Method != null && !obj.Method.IsPublic) || (obj.Method.DeclaringType != null && !obj.Method.DeclaringType.IsVisible))
			{
				new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
			}
		}
		catch (Exception ex)
		{
			if (ex is SerializationException)
			{
				throw ex;
			}
			throw new SerializationException(ex.Message, ex);
		}
		return obj;
	}

	[SecurityCritical]
	public object GetRealObject(StreamingContext context)
	{
		int num = 0;
		for (DelegateEntry delegateEntry = m_delegateEntry; delegateEntry != null; delegateEntry = delegateEntry.Entry)
		{
			num++;
		}
		int num2 = num - 1;
		if (num == 1)
		{
			return GetDelegate(m_delegateEntry, 0);
		}
		object[] array = new object[num];
		for (DelegateEntry delegateEntry2 = m_delegateEntry; delegateEntry2 != null; delegateEntry2 = delegateEntry2.Entry)
		{
			num--;
			array[num] = GetDelegate(delegateEntry2, num2 - num);
		}
		return ((MulticastDelegate)array[0]).NewMulticastDelegate(array, array.Length);
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_DelegateSerHolderSerial"));
	}
}
