using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class TypeInfo : Type, IReflectableType
{
	[__DynamicallyInvokable]
	public virtual Type[] GenericTypeParameters
	{
		[__DynamicallyInvokable]
		get
		{
			if (IsGenericTypeDefinition)
			{
				return GetGenericArguments();
			}
			return Type.EmptyTypes;
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<ConstructorInfo> DeclaredConstructors
	{
		[__DynamicallyInvokable]
		get
		{
			return GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<EventInfo> DeclaredEvents
	{
		[__DynamicallyInvokable]
		get
		{
			return GetEvents(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<FieldInfo> DeclaredFields
	{
		[__DynamicallyInvokable]
		get
		{
			return GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<MemberInfo> DeclaredMembers
	{
		[__DynamicallyInvokable]
		get
		{
			return GetMembers(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<MethodInfo> DeclaredMethods
	{
		[__DynamicallyInvokable]
		get
		{
			return GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<TypeInfo> DeclaredNestedTypes
	{
		[__DynamicallyInvokable]
		get
		{
			Type[] nestedTypes = GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (Type type in nestedTypes)
			{
				yield return type.GetTypeInfo();
			}
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<PropertyInfo> DeclaredProperties
	{
		[__DynamicallyInvokable]
		get
		{
			return GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<Type> ImplementedInterfaces
	{
		[__DynamicallyInvokable]
		get
		{
			return GetInterfaces();
		}
	}

	[FriendAccessAllowed]
	internal TypeInfo()
	{
	}

	[__DynamicallyInvokable]
	TypeInfo IReflectableType.GetTypeInfo()
	{
		return this;
	}

	[__DynamicallyInvokable]
	public virtual Type AsType()
	{
		return this;
	}

	[__DynamicallyInvokable]
	public virtual bool IsAssignableFrom(TypeInfo typeInfo)
	{
		if (typeInfo == null)
		{
			return false;
		}
		if (this == typeInfo)
		{
			return true;
		}
		if (typeInfo.IsSubclassOf(this))
		{
			return true;
		}
		if (base.IsInterface)
		{
			return typeInfo.ImplementInterface(this);
		}
		if (IsGenericParameter)
		{
			Type[] genericParameterConstraints = GetGenericParameterConstraints();
			for (int i = 0; i < genericParameterConstraints.Length; i++)
			{
				if (!genericParameterConstraints[i].IsAssignableFrom(typeInfo))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public virtual EventInfo GetDeclaredEvent(string name)
	{
		return GetEvent(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	[__DynamicallyInvokable]
	public virtual FieldInfo GetDeclaredField(string name)
	{
		return GetField(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	[__DynamicallyInvokable]
	public virtual MethodInfo GetDeclaredMethod(string name)
	{
		return GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<MethodInfo> GetDeclaredMethods(string name)
	{
		MethodInfo[] methods = GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if (methodInfo.Name == name)
			{
				yield return methodInfo;
			}
		}
	}

	[__DynamicallyInvokable]
	public virtual TypeInfo GetDeclaredNestedType(string name)
	{
		Type nestedType = GetNestedType(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		if (nestedType == null)
		{
			return null;
		}
		return nestedType.GetTypeInfo();
	}

	[__DynamicallyInvokable]
	public virtual PropertyInfo GetDeclaredProperty(string name)
	{
		return GetProperty(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}
}
