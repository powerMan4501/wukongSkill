using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Reflection;

internal static class PseudoCustomAttribute
{
	private static Dictionary<RuntimeType, RuntimeType> s_pca;

	private static int s_pcasCount;

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void _GetSecurityAttributes(RuntimeModule module, int token, bool assembly, out object[] securityAttributes);

	[SecurityCritical]
	internal static void GetSecurityAttributes(RuntimeModule module, int token, bool assembly, out object[] securityAttributes)
	{
		_GetSecurityAttributes(module.GetNativeHandle(), token, assembly, out securityAttributes);
	}

	[SecurityCritical]
	static PseudoCustomAttribute()
	{
		RuntimeType[] array = new RuntimeType[11]
		{
			typeof(FieldOffsetAttribute) as RuntimeType,
			typeof(SerializableAttribute) as RuntimeType,
			typeof(MarshalAsAttribute) as RuntimeType,
			typeof(ComImportAttribute) as RuntimeType,
			typeof(NonSerializedAttribute) as RuntimeType,
			typeof(InAttribute) as RuntimeType,
			typeof(OutAttribute) as RuntimeType,
			typeof(OptionalAttribute) as RuntimeType,
			typeof(DllImportAttribute) as RuntimeType,
			typeof(PreserveSigAttribute) as RuntimeType,
			typeof(TypeForwardedToAttribute) as RuntimeType
		};
		s_pcasCount = array.Length;
		Dictionary<RuntimeType, RuntimeType> dictionary = new Dictionary<RuntimeType, RuntimeType>(s_pcasCount);
		for (int i = 0; i < s_pcasCount; i++)
		{
			dictionary[array[i]] = array[i];
		}
		s_pca = dictionary;
	}

	[SecurityCritical]
	[Conditional("_DEBUG")]
	private static void VerifyPseudoCustomAttribute(RuntimeType pca)
	{
		AttributeUsageAttribute attributeUsage = CustomAttribute.GetAttributeUsage(pca);
	}

	internal static bool IsSecurityAttribute(RuntimeType type)
	{
		if (!(type == (RuntimeType)typeof(SecurityAttribute)))
		{
			return type.IsSubclassOf(typeof(SecurityAttribute));
		}
		return true;
	}

	[SecurityCritical]
	internal static Attribute[] GetCustomAttributes(RuntimeType type, RuntimeType caType, bool includeSecCa, out int count)
	{
		count = 0;
		bool flag = caType == (RuntimeType)typeof(object) || caType == (RuntimeType)typeof(Attribute);
		if (!flag && s_pca.GetValueOrDefault(caType) == null && !IsSecurityAttribute(caType))
		{
			return new Attribute[0];
		}
		List<Attribute> list = new List<Attribute>();
		Attribute attribute = null;
		if (flag || caType == (RuntimeType)typeof(SerializableAttribute))
		{
			attribute = SerializableAttribute.GetCustomAttribute(type);
			if (attribute != null)
			{
				list.Add(attribute);
			}
		}
		if (flag || caType == (RuntimeType)typeof(ComImportAttribute))
		{
			attribute = ComImportAttribute.GetCustomAttribute(type);
			if (attribute != null)
			{
				list.Add(attribute);
			}
		}
		if (includeSecCa && (flag || IsSecurityAttribute(caType)) && !type.IsGenericParameter && type.GetElementType() == null)
		{
			if (type.IsGenericType)
			{
				type = (RuntimeType)type.GetGenericTypeDefinition();
			}
			GetSecurityAttributes(type.Module.ModuleHandle.GetRuntimeModule(), type.MetadataToken, assembly: false, out var securityAttributes);
			if (securityAttributes != null)
			{
				object[] array = securityAttributes;
				foreach (object obj in array)
				{
					if (caType == obj.GetType() || obj.GetType().IsSubclassOf(caType))
					{
						list.Add((Attribute)obj);
					}
				}
			}
		}
		count = list.Count;
		return list.ToArray();
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeType type, RuntimeType caType)
	{
		bool flag = caType == (RuntimeType)typeof(object) || caType == (RuntimeType)typeof(Attribute);
		if (!flag && s_pca.GetValueOrDefault(caType) == null && !IsSecurityAttribute(caType))
		{
			return false;
		}
		if ((flag || caType == (RuntimeType)typeof(SerializableAttribute)) && SerializableAttribute.IsDefined(type))
		{
			return true;
		}
		if ((flag || caType == (RuntimeType)typeof(ComImportAttribute)) && ComImportAttribute.IsDefined(type))
		{
			return true;
		}
		if ((flag || IsSecurityAttribute(caType)) && GetCustomAttributes(type, caType, includeSecCa: true, out var _).Length != 0)
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	internal static Attribute[] GetCustomAttributes(RuntimeMethodInfo method, RuntimeType caType, bool includeSecCa, out int count)
	{
		count = 0;
		bool flag = caType == (RuntimeType)typeof(object) || caType == (RuntimeType)typeof(Attribute);
		if (!flag && s_pca.GetValueOrDefault(caType) == null && !IsSecurityAttribute(caType))
		{
			return new Attribute[0];
		}
		List<Attribute> list = new List<Attribute>();
		Attribute attribute = null;
		if (flag || caType == (RuntimeType)typeof(DllImportAttribute))
		{
			attribute = DllImportAttribute.GetCustomAttribute(method);
			if (attribute != null)
			{
				list.Add(attribute);
			}
		}
		if (flag || caType == (RuntimeType)typeof(PreserveSigAttribute))
		{
			attribute = PreserveSigAttribute.GetCustomAttribute(method);
			if (attribute != null)
			{
				list.Add(attribute);
			}
		}
		if (includeSecCa && (flag || IsSecurityAttribute(caType)))
		{
			GetSecurityAttributes(method.Module.ModuleHandle.GetRuntimeModule(), method.MetadataToken, assembly: false, out var securityAttributes);
			if (securityAttributes != null)
			{
				object[] array = securityAttributes;
				foreach (object obj in array)
				{
					if (caType == obj.GetType() || obj.GetType().IsSubclassOf(caType))
					{
						list.Add((Attribute)obj);
					}
				}
			}
		}
		count = list.Count;
		return list.ToArray();
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeMethodInfo method, RuntimeType caType)
	{
		bool flag = caType == (RuntimeType)typeof(object) || caType == (RuntimeType)typeof(Attribute);
		if (!flag && s_pca.GetValueOrDefault(caType) == null)
		{
			return false;
		}
		if ((flag || caType == (RuntimeType)typeof(DllImportAttribute)) && DllImportAttribute.IsDefined(method))
		{
			return true;
		}
		if ((flag || caType == (RuntimeType)typeof(PreserveSigAttribute)) && PreserveSigAttribute.IsDefined(method))
		{
			return true;
		}
		if ((flag || IsSecurityAttribute(caType)) && GetCustomAttributes(method, caType, includeSecCa: true, out var _).Length != 0)
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	internal static Attribute[] GetCustomAttributes(RuntimeParameterInfo parameter, RuntimeType caType, out int count)
	{
		count = 0;
		bool flag = caType == (RuntimeType)typeof(object) || caType == (RuntimeType)typeof(Attribute);
		if (!flag && s_pca.GetValueOrDefault(caType) == null)
		{
			return null;
		}
		Attribute[] array = new Attribute[s_pcasCount];
		Attribute attribute = null;
		if (flag || caType == (RuntimeType)typeof(InAttribute))
		{
			attribute = InAttribute.GetCustomAttribute(parameter);
			if (attribute != null)
			{
				array[count++] = attribute;
			}
		}
		if (flag || caType == (RuntimeType)typeof(OutAttribute))
		{
			attribute = OutAttribute.GetCustomAttribute(parameter);
			if (attribute != null)
			{
				array[count++] = attribute;
			}
		}
		if (flag || caType == (RuntimeType)typeof(OptionalAttribute))
		{
			attribute = OptionalAttribute.GetCustomAttribute(parameter);
			if (attribute != null)
			{
				array[count++] = attribute;
			}
		}
		if (flag || caType == (RuntimeType)typeof(MarshalAsAttribute))
		{
			attribute = MarshalAsAttribute.GetCustomAttribute(parameter);
			if (attribute != null)
			{
				array[count++] = attribute;
			}
		}
		return array;
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeParameterInfo parameter, RuntimeType caType)
	{
		bool flag = caType == (RuntimeType)typeof(object) || caType == (RuntimeType)typeof(Attribute);
		if (!flag && s_pca.GetValueOrDefault(caType) == null)
		{
			return false;
		}
		if ((flag || caType == (RuntimeType)typeof(InAttribute)) && InAttribute.IsDefined(parameter))
		{
			return true;
		}
		if ((flag || caType == (RuntimeType)typeof(OutAttribute)) && OutAttribute.IsDefined(parameter))
		{
			return true;
		}
		if ((flag || caType == (RuntimeType)typeof(OptionalAttribute)) && OptionalAttribute.IsDefined(parameter))
		{
			return true;
		}
		if ((flag || caType == (RuntimeType)typeof(MarshalAsAttribute)) && MarshalAsAttribute.IsDefined(parameter))
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	internal static Attribute[] GetCustomAttributes(RuntimeAssembly assembly, RuntimeType caType, bool includeSecCa, out int count)
	{
		count = 0;
		bool flag = caType == (RuntimeType)typeof(object) || caType == (RuntimeType)typeof(Attribute);
		if (!flag && s_pca.GetValueOrDefault(caType) == null && !IsSecurityAttribute(caType))
		{
			return new Attribute[0];
		}
		List<Attribute> list = new List<Attribute>();
		if (includeSecCa && (flag || IsSecurityAttribute(caType)))
		{
			GetSecurityAttributes(assembly.ManifestModule.ModuleHandle.GetRuntimeModule(), RuntimeAssembly.GetToken(assembly.GetNativeHandle()), assembly: true, out var securityAttributes);
			if (securityAttributes != null)
			{
				object[] array = securityAttributes;
				foreach (object obj in array)
				{
					if (caType == obj.GetType() || obj.GetType().IsSubclassOf(caType))
					{
						list.Add((Attribute)obj);
					}
				}
			}
		}
		count = list.Count;
		return list.ToArray();
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeAssembly assembly, RuntimeType caType)
	{
		int count;
		return GetCustomAttributes(assembly, caType, includeSecCa: true, out count).Length != 0;
	}

	internal static Attribute[] GetCustomAttributes(RuntimeModule module, RuntimeType caType, out int count)
	{
		count = 0;
		return null;
	}

	internal static bool IsDefined(RuntimeModule module, RuntimeType caType)
	{
		return false;
	}

	[SecurityCritical]
	internal static Attribute[] GetCustomAttributes(RuntimeFieldInfo field, RuntimeType caType, out int count)
	{
		count = 0;
		bool flag = caType == (RuntimeType)typeof(object) || caType == (RuntimeType)typeof(Attribute);
		if (!flag && s_pca.GetValueOrDefault(caType) == null)
		{
			return null;
		}
		Attribute[] array = new Attribute[s_pcasCount];
		Attribute attribute = null;
		if (flag || caType == (RuntimeType)typeof(MarshalAsAttribute))
		{
			attribute = MarshalAsAttribute.GetCustomAttribute(field);
			if (attribute != null)
			{
				array[count++] = attribute;
			}
		}
		if (flag || caType == (RuntimeType)typeof(FieldOffsetAttribute))
		{
			attribute = FieldOffsetAttribute.GetCustomAttribute(field);
			if (attribute != null)
			{
				array[count++] = attribute;
			}
		}
		if (flag || caType == (RuntimeType)typeof(NonSerializedAttribute))
		{
			attribute = NonSerializedAttribute.GetCustomAttribute(field);
			if (attribute != null)
			{
				array[count++] = attribute;
			}
		}
		return array;
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeFieldInfo field, RuntimeType caType)
	{
		bool flag = caType == (RuntimeType)typeof(object) || caType == (RuntimeType)typeof(Attribute);
		if (!flag && s_pca.GetValueOrDefault(caType) == null)
		{
			return false;
		}
		if ((flag || caType == (RuntimeType)typeof(MarshalAsAttribute)) && MarshalAsAttribute.IsDefined(field))
		{
			return true;
		}
		if ((flag || caType == (RuntimeType)typeof(FieldOffsetAttribute)) && FieldOffsetAttribute.IsDefined(field))
		{
			return true;
		}
		if ((flag || caType == (RuntimeType)typeof(NonSerializedAttribute)) && NonSerializedAttribute.IsDefined(field))
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	internal static Attribute[] GetCustomAttributes(RuntimeConstructorInfo ctor, RuntimeType caType, bool includeSecCa, out int count)
	{
		count = 0;
		bool flag = caType == (RuntimeType)typeof(object) || caType == (RuntimeType)typeof(Attribute);
		if (!flag && s_pca.GetValueOrDefault(caType) == null && !IsSecurityAttribute(caType))
		{
			return new Attribute[0];
		}
		List<Attribute> list = new List<Attribute>();
		if (includeSecCa && (flag || IsSecurityAttribute(caType)))
		{
			GetSecurityAttributes(ctor.Module.ModuleHandle.GetRuntimeModule(), ctor.MetadataToken, assembly: false, out var securityAttributes);
			if (securityAttributes != null)
			{
				object[] array = securityAttributes;
				foreach (object obj in array)
				{
					if (caType == obj.GetType() || obj.GetType().IsSubclassOf(caType))
					{
						list.Add((Attribute)obj);
					}
				}
			}
		}
		count = list.Count;
		return list.ToArray();
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeConstructorInfo ctor, RuntimeType caType)
	{
		bool flag = caType == (RuntimeType)typeof(object) || caType == (RuntimeType)typeof(Attribute);
		if (!flag && s_pca.GetValueOrDefault(caType) == null)
		{
			return false;
		}
		if ((flag || IsSecurityAttribute(caType)) && GetCustomAttributes(ctor, caType, includeSecCa: true, out var _).Length != 0)
		{
			return true;
		}
		return false;
	}

	internal static Attribute[] GetCustomAttributes(RuntimePropertyInfo property, RuntimeType caType, out int count)
	{
		count = 0;
		return null;
	}

	internal static bool IsDefined(RuntimePropertyInfo property, RuntimeType caType)
	{
		return false;
	}

	internal static Attribute[] GetCustomAttributes(RuntimeEventInfo e, RuntimeType caType, out int count)
	{
		count = 0;
		return null;
	}

	internal static bool IsDefined(RuntimeEventInfo e, RuntimeType caType)
	{
		return false;
	}
}
