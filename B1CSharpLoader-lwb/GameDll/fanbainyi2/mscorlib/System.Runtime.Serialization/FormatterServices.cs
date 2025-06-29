using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters;
using System.Security;
using System.Text;

namespace System.Runtime.Serialization;

[ComVisible(true)]
public static class FormatterServices
{
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable;

	[SecurityCritical]
	private static bool unsafeTypeForwardersIsEnabled;

	[SecurityCritical]
	private static volatile bool unsafeTypeForwardersIsEnabledInitialized;

	private static readonly Type[] advancedTypes;

	private static Binder s_binder;

	[SecuritySafeCritical]
	static FormatterServices()
	{
		m_MemberInfoTable = new ConcurrentDictionary<MemberHolder, MemberInfo[]>();
		unsafeTypeForwardersIsEnabled = false;
		unsafeTypeForwardersIsEnabledInitialized = false;
		advancedTypes = new Type[4]
		{
			typeof(DelegateSerializationHolder),
			typeof(ObjRef),
			typeof(IEnvoyInfo),
			typeof(ISponsor)
		};
		s_binder = Type.DefaultBinder;
	}

	private static MemberInfo[] GetSerializableMembers(RuntimeType type)
	{
		FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		int num = 0;
		for (int i = 0; i < fields.Length; i++)
		{
			if ((fields[i].Attributes & FieldAttributes.NotSerialized) != FieldAttributes.NotSerialized)
			{
				num++;
			}
		}
		if (num != fields.Length)
		{
			FieldInfo[] array = new FieldInfo[num];
			num = 0;
			for (int j = 0; j < fields.Length; j++)
			{
				if ((fields[j].Attributes & FieldAttributes.NotSerialized) != FieldAttributes.NotSerialized)
				{
					array[num] = fields[j];
					num++;
				}
			}
			return array;
		}
		return fields;
	}

	private static bool CheckSerializable(RuntimeType type)
	{
		if (type.IsSerializable)
		{
			return true;
		}
		return false;
	}

	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type)
	{
		List<SerializationFieldInfo> list = null;
		if (type.IsInterface)
		{
			return new MemberInfo[0];
		}
		if (!CheckSerializable(type))
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_NonSerType", type.FullName, type.Module.Assembly.FullName));
		}
		MemberInfo[] array = GetSerializableMembers(type);
		RuntimeType runtimeType = (RuntimeType)type.BaseType;
		if (runtimeType != null && runtimeType != (RuntimeType)typeof(object))
		{
			RuntimeType[] parentTypes = null;
			int parentTypeCount = 0;
			bool parentTypes2 = GetParentTypes(runtimeType, out parentTypes, out parentTypeCount);
			if (parentTypeCount > 0)
			{
				list = new List<SerializationFieldInfo>();
				for (int i = 0; i < parentTypeCount; i++)
				{
					runtimeType = parentTypes[i];
					if (!CheckSerializable(runtimeType))
					{
						throw new SerializationException(Environment.GetResourceString("Serialization_NonSerType", runtimeType.FullName, runtimeType.Module.Assembly.FullName));
					}
					FieldInfo[] fields = runtimeType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
					string namePrefix = (parentTypes2 ? runtimeType.Name : runtimeType.FullName);
					FieldInfo[] array2 = fields;
					foreach (FieldInfo fieldInfo in array2)
					{
						if (!fieldInfo.IsNotSerialized)
						{
							list.Add(new SerializationFieldInfo((RuntimeFieldInfo)fieldInfo, namePrefix));
						}
					}
				}
				if (list != null && list.Count > 0)
				{
					MemberInfo[] array3 = new MemberInfo[list.Count + array.Length];
					Array.Copy(array, array3, array.Length);
					((ICollection)list).CopyTo((Array)array3, array.Length);
					array = array3;
				}
			}
		}
		return array;
	}

	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount)
	{
		parentTypes = null;
		parentTypeCount = 0;
		bool flag = true;
		RuntimeType runtimeType = (RuntimeType)typeof(object);
		RuntimeType runtimeType2 = parentType;
		while (runtimeType2 != runtimeType)
		{
			if (!runtimeType2.IsInterface)
			{
				string name = runtimeType2.Name;
				int num = 0;
				while (flag && num < parentTypeCount)
				{
					string name2 = parentTypes[num].Name;
					if (name2.Length == name.Length && name2[0] == name[0] && name == name2)
					{
						flag = false;
						break;
					}
					num++;
				}
				if (parentTypes == null || parentTypeCount == parentTypes.Length)
				{
					RuntimeType[] array = new RuntimeType[Math.Max(parentTypeCount * 2, 12)];
					if (parentTypes != null)
					{
						Array.Copy(parentTypes, 0, array, 0, parentTypeCount);
					}
					parentTypes = array;
				}
				parentTypes[parentTypeCount++] = runtimeType2;
			}
			runtimeType2 = (RuntimeType)runtimeType2.BaseType;
		}
		return flag;
	}

	[SecurityCritical]
	public static MemberInfo[] GetSerializableMembers(Type type)
	{
		return GetSerializableMembers(type, new StreamingContext(StreamingContextStates.All));
	}

	[SecurityCritical]
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context)
	{
		if ((object)type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (!(type is RuntimeType))
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InvalidType", type.ToString()));
		}
		MemberHolder key = new MemberHolder(type, context);
		return m_MemberInfoTable.GetOrAdd(key, (MemberHolder _) => InternalGetSerializableMembers((RuntimeType)type));
	}

	public static void CheckTypeSecurity(Type t, TypeFilterLevel securityLevel)
	{
		if (securityLevel != TypeFilterLevel.Low)
		{
			return;
		}
		for (int i = 0; i < advancedTypes.Length; i++)
		{
			if (advancedTypes[i].IsAssignableFrom(t))
			{
				throw new SecurityException(Environment.GetResourceString("Serialization_TypeSecurity", advancedTypes[i].FullName, t.FullName));
			}
		}
	}

	[SecurityCritical]
	public static object GetUninitializedObject(Type type)
	{
		if ((object)type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (!(type is RuntimeType))
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InvalidType", type.ToString()));
		}
		return nativeGetUninitializedObject((RuntimeType)type);
	}

	[SecurityCritical]
	public static object GetSafeUninitializedObject(Type type)
	{
		if ((object)type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (!(type is RuntimeType))
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InvalidType", type.ToString()));
		}
		if ((object)type == typeof(ConstructionCall) || (object)type == typeof(LogicalCallContext) || (object)type == typeof(SynchronizationAttribute))
		{
			return nativeGetUninitializedObject((RuntimeType)type);
		}
		try
		{
			return nativeGetSafeUninitializedObject((RuntimeType)type);
		}
		catch (SecurityException innerException)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_Security", type.FullName), innerException);
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern object nativeGetSafeUninitializedObject(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern object nativeGetUninitializedObject(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool GetEnableUnsafeTypeForwarders();

	[SecuritySafeCritical]
	internal static bool UnsafeTypeForwardersIsEnabled()
	{
		if (!unsafeTypeForwardersIsEnabledInitialized)
		{
			unsafeTypeForwardersIsEnabled = GetEnableUnsafeTypeForwarders();
			unsafeTypeForwardersIsEnabledInitialized = true;
		}
		return unsafeTypeForwardersIsEnabled;
	}

	[SecurityCritical]
	internal static void SerializationSetValue(MemberInfo fi, object target, object value)
	{
		RtFieldInfo rtFieldInfo = fi as RtFieldInfo;
		if (rtFieldInfo != null)
		{
			rtFieldInfo.CheckConsistency(target);
			rtFieldInfo.UnsafeSetValue(target, value, BindingFlags.Default, s_binder, null);
			return;
		}
		SerializationFieldInfo serializationFieldInfo = fi as SerializationFieldInfo;
		if (serializationFieldInfo != null)
		{
			serializationFieldInfo.InternalSetValue(target, value, BindingFlags.Default, s_binder, null);
			return;
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFieldInfo"));
	}

	[SecurityCritical]
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (members == null)
		{
			throw new ArgumentNullException("members");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (members.Length != data.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_DataLengthDifferent"));
		}
		for (int i = 0; i < members.Length; i++)
		{
			MemberInfo memberInfo = members[i];
			if (memberInfo == null)
			{
				throw new ArgumentNullException("members", Environment.GetResourceString("ArgumentNull_NullMember", i));
			}
			if (data[i] != null)
			{
				if (memberInfo.MemberType != MemberTypes.Field)
				{
					throw new SerializationException(Environment.GetResourceString("Serialization_UnknownMemberInfo"));
				}
				SerializationSetValue(memberInfo, obj, data[i]);
			}
		}
		return obj;
	}

	[SecurityCritical]
	public static object[] GetObjectData(object obj, MemberInfo[] members)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (members == null)
		{
			throw new ArgumentNullException("members");
		}
		int num = members.Length;
		object[] array = new object[num];
		for (int i = 0; i < num; i++)
		{
			MemberInfo memberInfo = members[i];
			if (memberInfo == null)
			{
				throw new ArgumentNullException("members", Environment.GetResourceString("ArgumentNull_NullMember", i));
			}
			if (memberInfo.MemberType == MemberTypes.Field)
			{
				RtFieldInfo rtFieldInfo = memberInfo as RtFieldInfo;
				if (rtFieldInfo != null)
				{
					rtFieldInfo.CheckConsistency(obj);
					array[i] = rtFieldInfo.UnsafeGetValue(obj);
				}
				else
				{
					array[i] = ((SerializationFieldInfo)memberInfo).InternalGetValue(obj);
				}
				continue;
			}
			throw new SerializationException(Environment.GetResourceString("Serialization_UnknownMemberInfo"));
		}
		return array;
	}

	[SecurityCritical]
	[ComVisible(false)]
	public static ISerializationSurrogate GetSurrogateForCyclicalReference(ISerializationSurrogate innerSurrogate)
	{
		if (innerSurrogate == null)
		{
			throw new ArgumentNullException("innerSurrogate");
		}
		return new SurrogateForCyclicalReference(innerSurrogate);
	}

	[SecurityCritical]
	public static Type GetTypeFromAssembly(Assembly assem, string name)
	{
		if (assem == null)
		{
			throw new ArgumentNullException("assem");
		}
		return assem.GetType(name, throwOnError: false, ignoreCase: false);
	}

	internal static Assembly LoadAssemblyFromString(string assemblyName)
	{
		return Assembly.Load(assemblyName);
	}

	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName)
	{
		try
		{
			return LoadAssemblyFromString(assemblyName);
		}
		catch (Exception)
		{
		}
		return null;
	}

	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom)
	{
		if ((object)type == null)
		{
			throw new ArgumentNullException("type");
		}
		object[] customAttributes = type.GetCustomAttributes(typeof(TypeForwardedFromAttribute), inherit: false);
		if (customAttributes != null && customAttributes.Length != 0)
		{
			hasTypeForwardedFrom = true;
			TypeForwardedFromAttribute typeForwardedFromAttribute = (TypeForwardedFromAttribute)customAttributes[0];
			return typeForwardedFromAttribute.AssemblyFullName;
		}
		hasTypeForwardedFrom = false;
		return type.Assembly.FullName;
	}

	internal static string GetClrTypeFullName(Type type)
	{
		if (type.IsArray)
		{
			return GetClrTypeFullNameForArray(type);
		}
		return GetClrTypeFullNameForNonArrayTypes(type);
	}

	private static string GetClrTypeFullNameForArray(Type type)
	{
		int arrayRank = type.GetArrayRank();
		if (arrayRank == 1)
		{
			return string.Format(CultureInfo.InvariantCulture, "{0}{1}", GetClrTypeFullName(type.GetElementType()), "[]");
		}
		StringBuilder stringBuilder = new StringBuilder(GetClrTypeFullName(type.GetElementType())).Append("[");
		for (int i = 1; i < arrayRank; i++)
		{
			stringBuilder.Append(",");
		}
		stringBuilder.Append("]");
		return stringBuilder.ToString();
	}

	private static string GetClrTypeFullNameForNonArrayTypes(Type type)
	{
		if (!type.IsGenericType)
		{
			return type.FullName;
		}
		Type[] genericArguments = type.GetGenericArguments();
		StringBuilder stringBuilder = new StringBuilder(type.GetGenericTypeDefinition().FullName).Append("[");
		Type[] array = genericArguments;
		foreach (Type type2 in array)
		{
			stringBuilder.Append("[").Append(GetClrTypeFullName(type2)).Append(", ");
			stringBuilder.Append(GetClrAssemblyName(type2, out var _)).Append("],");
		}
		return stringBuilder.Remove(stringBuilder.Length - 1, 1).Append("]").ToString();
	}
}
