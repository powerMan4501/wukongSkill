using System.Security;

namespace System.Runtime.Remoting;

[Serializable]
internal class TypeInfo : IRemotingTypeInfo
{
	private string serverType;

	private string[] serverHierarchy;

	private string[] interfacesImplemented;

	public virtual string TypeName
	{
		[SecurityCritical]
		get
		{
			return serverType;
		}
		[SecurityCritical]
		set
		{
			serverType = value;
		}
	}

	internal string ServerType
	{
		get
		{
			return serverType;
		}
		set
		{
			serverType = value;
		}
	}

	private string[] ServerHierarchy
	{
		get
		{
			return serverHierarchy;
		}
		set
		{
			serverHierarchy = value;
		}
	}

	private string[] InterfacesImplemented
	{
		get
		{
			return interfacesImplemented;
		}
		set
		{
			interfacesImplemented = value;
		}
	}

	[SecurityCritical]
	public virtual bool CanCastTo(Type castType, object o)
	{
		if (null != castType)
		{
			if (castType == typeof(MarshalByRefObject) || castType == typeof(object))
			{
				return true;
			}
			if (castType.IsInterface)
			{
				if (interfacesImplemented != null)
				{
					return CanCastTo(castType, InterfacesImplemented);
				}
				return false;
			}
			if (castType.IsMarshalByRef)
			{
				if (CompareTypes(castType, serverType))
				{
					return true;
				}
				if (serverHierarchy != null && CanCastTo(castType, ServerHierarchy))
				{
					return true;
				}
			}
		}
		return false;
	}

	[SecurityCritical]
	internal static string GetQualifiedTypeName(RuntimeType type)
	{
		if (type == null)
		{
			return null;
		}
		return RemotingServices.GetDefaultQualifiedTypeName(type);
	}

	internal static bool ParseTypeAndAssembly(string typeAndAssembly, out string typeName, out string assemName)
	{
		if (typeAndAssembly == null)
		{
			typeName = null;
			assemName = null;
			return false;
		}
		int num = typeAndAssembly.IndexOf(',');
		if (num == -1)
		{
			typeName = typeAndAssembly;
			assemName = null;
			return true;
		}
		typeName = typeAndAssembly.Substring(0, num);
		assemName = typeAndAssembly.Substring(num + 1).Trim();
		return true;
	}

	[SecurityCritical]
	internal TypeInfo(RuntimeType typeOfObj)
	{
		ServerType = GetQualifiedTypeName(typeOfObj);
		RuntimeType runtimeType = (RuntimeType)typeOfObj.BaseType;
		int num = 0;
		while (runtimeType != typeof(MarshalByRefObject) && runtimeType != null)
		{
			runtimeType = (RuntimeType)runtimeType.BaseType;
			num++;
		}
		string[] array = null;
		if (num > 0)
		{
			array = new string[num];
			runtimeType = (RuntimeType)typeOfObj.BaseType;
			for (int i = 0; i < num; i++)
			{
				array[i] = GetQualifiedTypeName(runtimeType);
				runtimeType = (RuntimeType)runtimeType.BaseType;
			}
		}
		ServerHierarchy = array;
		Type[] interfaces = typeOfObj.GetInterfaces();
		string[] array2 = null;
		bool isInterface = typeOfObj.IsInterface;
		if (interfaces.Length != 0 || isInterface)
		{
			array2 = new string[interfaces.Length + (isInterface ? 1 : 0)];
			for (int j = 0; j < interfaces.Length; j++)
			{
				array2[j] = GetQualifiedTypeName((RuntimeType)interfaces[j]);
			}
			if (isInterface)
			{
				array2[array2.Length - 1] = GetQualifiedTypeName(typeOfObj);
			}
		}
		InterfacesImplemented = array2;
	}

	[SecurityCritical]
	private bool CompareTypes(Type type1, string type2)
	{
		Type type3 = RemotingServices.InternalGetTypeFromQualifiedTypeName(type2);
		return type1 == type3;
	}

	[SecurityCritical]
	private bool CanCastTo(Type castType, string[] types)
	{
		bool result = false;
		if (null != castType)
		{
			for (int i = 0; i < types.Length; i++)
			{
				if (CompareTypes(castType, types[i]))
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}
}
