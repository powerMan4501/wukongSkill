using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class CustomAttributeData
{
	private ConstructorInfo m_ctor;

	private RuntimeModule m_scope;

	private MemberInfo[] m_members;

	private CustomAttributeCtorParameter[] m_ctorParams;

	private CustomAttributeNamedParameter[] m_namedParams;

	private IList<CustomAttributeTypedArgument> m_typedCtorArgs;

	private IList<CustomAttributeNamedArgument> m_namedArgs;

	[__DynamicallyInvokable]
	public Type AttributeType
	{
		[__DynamicallyInvokable]
		get
		{
			return Constructor.DeclaringType;
		}
	}

	[ComVisible(true)]
	public virtual ConstructorInfo Constructor => m_ctor;

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments
	{
		[__DynamicallyInvokable]
		get
		{
			if (m_typedCtorArgs == null)
			{
				CustomAttributeTypedArgument[] array = new CustomAttributeTypedArgument[m_ctorParams.Length];
				for (int i = 0; i < array.Length; i++)
				{
					CustomAttributeEncodedArgument customAttributeEncodedArgument = m_ctorParams[i].CustomAttributeEncodedArgument;
					array[i] = new CustomAttributeTypedArgument(m_scope, m_ctorParams[i].CustomAttributeEncodedArgument);
				}
				m_typedCtorArgs = Array.AsReadOnly(array);
			}
			return m_typedCtorArgs;
		}
	}

	[__DynamicallyInvokable]
	public virtual IList<CustomAttributeNamedArgument> NamedArguments
	{
		[__DynamicallyInvokable]
		get
		{
			if (m_namedArgs == null)
			{
				if (m_namedParams == null)
				{
					return null;
				}
				int num = 0;
				for (int i = 0; i < m_namedParams.Length; i++)
				{
					if (m_namedParams[i].EncodedArgument.CustomAttributeType.EncodedType != CustomAttributeEncoding.Undefined)
					{
						num++;
					}
				}
				CustomAttributeNamedArgument[] array = new CustomAttributeNamedArgument[num];
				int j = 0;
				int num2 = 0;
				for (; j < m_namedParams.Length; j++)
				{
					if (m_namedParams[j].EncodedArgument.CustomAttributeType.EncodedType != CustomAttributeEncoding.Undefined)
					{
						array[num2++] = new CustomAttributeNamedArgument(m_members[j], new CustomAttributeTypedArgument(m_scope, m_namedParams[j].EncodedArgument));
					}
				}
				m_namedArgs = Array.AsReadOnly(array);
			}
			return m_namedArgs;
		}
	}

	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		return target.GetCustomAttributesData();
	}

	public static IList<CustomAttributeData> GetCustomAttributes(Module target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		return target.GetCustomAttributesData();
	}

	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		return target.GetCustomAttributesData();
	}

	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		return target.GetCustomAttributesData();
	}

	[SecuritySafeCritical]
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target)
	{
		IList<CustomAttributeData> customAttributes = GetCustomAttributes(target.GetRuntimeModule(), target.MetadataToken);
		int count = 0;
		Attribute[] customAttributes2 = PseudoCustomAttribute.GetCustomAttributes(target, typeof(object) as RuntimeType, includeSecCa: true, out count);
		if (count == 0)
		{
			return customAttributes;
		}
		CustomAttributeData[] array = new CustomAttributeData[customAttributes.Count + count];
		customAttributes.CopyTo(array, count);
		for (int i = 0; i < count; i++)
		{
			array[i] = new CustomAttributeData(customAttributes2[i]);
		}
		return Array.AsReadOnly(array);
	}

	[SecuritySafeCritical]
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeFieldInfo target)
	{
		IList<CustomAttributeData> customAttributes = GetCustomAttributes(target.GetRuntimeModule(), target.MetadataToken);
		int count = 0;
		Attribute[] customAttributes2 = PseudoCustomAttribute.GetCustomAttributes(target, typeof(object) as RuntimeType, out count);
		if (count == 0)
		{
			return customAttributes;
		}
		CustomAttributeData[] array = new CustomAttributeData[customAttributes.Count + count];
		customAttributes.CopyTo(array, count);
		for (int i = 0; i < count; i++)
		{
			array[i] = new CustomAttributeData(customAttributes2[i]);
		}
		return Array.AsReadOnly(array);
	}

	[SecuritySafeCritical]
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeMethodInfo target)
	{
		IList<CustomAttributeData> customAttributes = GetCustomAttributes(target.GetRuntimeModule(), target.MetadataToken);
		int count = 0;
		Attribute[] customAttributes2 = PseudoCustomAttribute.GetCustomAttributes(target, typeof(object) as RuntimeType, includeSecCa: true, out count);
		if (count == 0)
		{
			return customAttributes;
		}
		CustomAttributeData[] array = new CustomAttributeData[customAttributes.Count + count];
		customAttributes.CopyTo(array, count);
		for (int i = 0; i < count; i++)
		{
			array[i] = new CustomAttributeData(customAttributes2[i]);
		}
		return Array.AsReadOnly(array);
	}

	[SecuritySafeCritical]
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeConstructorInfo target)
	{
		return GetCustomAttributes(target.GetRuntimeModule(), target.MetadataToken);
	}

	[SecuritySafeCritical]
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeEventInfo target)
	{
		return GetCustomAttributes(target.GetRuntimeModule(), target.MetadataToken);
	}

	[SecuritySafeCritical]
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimePropertyInfo target)
	{
		return GetCustomAttributes(target.GetRuntimeModule(), target.MetadataToken);
	}

	[SecuritySafeCritical]
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeModule target)
	{
		if (target.IsResource())
		{
			return new List<CustomAttributeData>();
		}
		return GetCustomAttributes(target, target.MetadataToken);
	}

	[SecuritySafeCritical]
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeAssembly target)
	{
		IList<CustomAttributeData> customAttributes = GetCustomAttributes((RuntimeModule)target.ManifestModule, RuntimeAssembly.GetToken(target.GetNativeHandle()));
		int count = 0;
		Attribute[] customAttributes2 = PseudoCustomAttribute.GetCustomAttributes(target, typeof(object) as RuntimeType, includeSecCa: false, out count);
		if (count == 0)
		{
			return customAttributes;
		}
		CustomAttributeData[] array = new CustomAttributeData[customAttributes.Count + count];
		customAttributes.CopyTo(array, count);
		for (int i = 0; i < count; i++)
		{
			array[i] = new CustomAttributeData(customAttributes2[i]);
		}
		return Array.AsReadOnly(array);
	}

	[SecuritySafeCritical]
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeParameterInfo target)
	{
		IList<CustomAttributeData> customAttributes = GetCustomAttributes(target.GetRuntimeModule(), target.MetadataToken);
		int count = 0;
		Attribute[] customAttributes2 = PseudoCustomAttribute.GetCustomAttributes(target, typeof(object) as RuntimeType, out count);
		if (count == 0)
		{
			return customAttributes;
		}
		CustomAttributeData[] array = new CustomAttributeData[customAttributes.Count + count];
		customAttributes.CopyTo(array, count);
		for (int i = 0; i < count; i++)
		{
			array[i] = new CustomAttributeData(customAttributes2[i]);
		}
		return Array.AsReadOnly(array);
	}

	private static CustomAttributeEncoding TypeToCustomAttributeEncoding(RuntimeType type)
	{
		if (type == (RuntimeType)typeof(int))
		{
			return CustomAttributeEncoding.Int32;
		}
		if (type.IsEnum)
		{
			return CustomAttributeEncoding.Enum;
		}
		if (type == (RuntimeType)typeof(string))
		{
			return CustomAttributeEncoding.String;
		}
		if (type == (RuntimeType)typeof(Type))
		{
			return CustomAttributeEncoding.Type;
		}
		if (type == (RuntimeType)typeof(object))
		{
			return CustomAttributeEncoding.Object;
		}
		if (type.IsArray)
		{
			return CustomAttributeEncoding.Array;
		}
		if (type == (RuntimeType)typeof(char))
		{
			return CustomAttributeEncoding.Char;
		}
		if (type == (RuntimeType)typeof(bool))
		{
			return CustomAttributeEncoding.Boolean;
		}
		if (type == (RuntimeType)typeof(byte))
		{
			return CustomAttributeEncoding.Byte;
		}
		if (type == (RuntimeType)typeof(sbyte))
		{
			return CustomAttributeEncoding.SByte;
		}
		if (type == (RuntimeType)typeof(short))
		{
			return CustomAttributeEncoding.Int16;
		}
		if (type == (RuntimeType)typeof(ushort))
		{
			return CustomAttributeEncoding.UInt16;
		}
		if (type == (RuntimeType)typeof(uint))
		{
			return CustomAttributeEncoding.UInt32;
		}
		if (type == (RuntimeType)typeof(long))
		{
			return CustomAttributeEncoding.Int64;
		}
		if (type == (RuntimeType)typeof(ulong))
		{
			return CustomAttributeEncoding.UInt64;
		}
		if (type == (RuntimeType)typeof(float))
		{
			return CustomAttributeEncoding.Float;
		}
		if (type == (RuntimeType)typeof(double))
		{
			return CustomAttributeEncoding.Double;
		}
		if (type == (RuntimeType)typeof(Enum))
		{
			return CustomAttributeEncoding.Object;
		}
		if (type.IsClass)
		{
			return CustomAttributeEncoding.Object;
		}
		if (type.IsInterface)
		{
			return CustomAttributeEncoding.Object;
		}
		if (type.IsValueType)
		{
			return CustomAttributeEncoding.Undefined;
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_InvalidKindOfTypeForCA"), "type");
	}

	private static CustomAttributeType InitCustomAttributeType(RuntimeType parameterType)
	{
		CustomAttributeEncoding customAttributeEncoding = TypeToCustomAttributeEncoding(parameterType);
		CustomAttributeEncoding customAttributeEncoding2 = CustomAttributeEncoding.Undefined;
		CustomAttributeEncoding encodedEnumType = CustomAttributeEncoding.Undefined;
		string enumName = null;
		if (customAttributeEncoding == CustomAttributeEncoding.Array)
		{
			parameterType = (RuntimeType)parameterType.GetElementType();
			customAttributeEncoding2 = TypeToCustomAttributeEncoding(parameterType);
		}
		if (customAttributeEncoding == CustomAttributeEncoding.Enum || customAttributeEncoding2 == CustomAttributeEncoding.Enum)
		{
			encodedEnumType = TypeToCustomAttributeEncoding((RuntimeType)Enum.GetUnderlyingType(parameterType));
			enumName = parameterType.AssemblyQualifiedName;
		}
		return new CustomAttributeType(customAttributeEncoding, customAttributeEncoding2, encodedEnumType, enumName);
	}

	[SecurityCritical]
	private static IList<CustomAttributeData> GetCustomAttributes(RuntimeModule module, int tkTarget)
	{
		CustomAttributeRecord[] customAttributeRecords = GetCustomAttributeRecords(module, tkTarget);
		CustomAttributeData[] array = new CustomAttributeData[customAttributeRecords.Length];
		for (int i = 0; i < customAttributeRecords.Length; i++)
		{
			array[i] = new CustomAttributeData(module, customAttributeRecords[i]);
		}
		return Array.AsReadOnly(array);
	}

	[SecurityCritical]
	internal static CustomAttributeRecord[] GetCustomAttributeRecords(RuntimeModule module, int targetToken)
	{
		MetadataImport metadataImport = module.MetadataImport;
		metadataImport.EnumCustomAttributes(targetToken, out var result);
		CustomAttributeRecord[] array = new CustomAttributeRecord[result.Length];
		for (int i = 0; i < array.Length; i++)
		{
			metadataImport.GetCustomAttributeProps(result[i], out array[i].tkCtor.Value, out array[i].blob);
		}
		return array;
	}

	internal static CustomAttributeTypedArgument Filter(IList<CustomAttributeData> attrs, Type caType, int parameter)
	{
		for (int i = 0; i < attrs.Count; i++)
		{
			if (attrs[i].Constructor.DeclaringType == caType)
			{
				return attrs[i].ConstructorArguments[parameter];
			}
		}
		return default(CustomAttributeTypedArgument);
	}

	protected CustomAttributeData()
	{
	}

	[SecuritySafeCritical]
	private CustomAttributeData(RuntimeModule scope, CustomAttributeRecord caRecord)
	{
		m_scope = scope;
		m_ctor = (RuntimeConstructorInfo)RuntimeType.GetMethodBase(scope, caRecord.tkCtor);
		ParameterInfo[] parametersNoCopy = m_ctor.GetParametersNoCopy();
		m_ctorParams = new CustomAttributeCtorParameter[parametersNoCopy.Length];
		for (int i = 0; i < parametersNoCopy.Length; i++)
		{
			m_ctorParams[i] = new CustomAttributeCtorParameter(InitCustomAttributeType((RuntimeType)parametersNoCopy[i].ParameterType));
		}
		FieldInfo[] fields = m_ctor.DeclaringType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		PropertyInfo[] properties = m_ctor.DeclaringType.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		m_namedParams = new CustomAttributeNamedParameter[properties.Length + fields.Length];
		for (int j = 0; j < fields.Length; j++)
		{
			m_namedParams[j] = new CustomAttributeNamedParameter(fields[j].Name, CustomAttributeEncoding.Field, InitCustomAttributeType((RuntimeType)fields[j].FieldType));
		}
		for (int k = 0; k < properties.Length; k++)
		{
			m_namedParams[k + fields.Length] = new CustomAttributeNamedParameter(properties[k].Name, CustomAttributeEncoding.Property, InitCustomAttributeType((RuntimeType)properties[k].PropertyType));
		}
		m_members = new MemberInfo[fields.Length + properties.Length];
		fields.CopyTo(m_members, 0);
		properties.CopyTo(m_members, fields.Length);
		CustomAttributeEncodedArgument.ParseAttributeArguments(caRecord.blob, ref m_ctorParams, ref m_namedParams, m_scope);
	}

	internal CustomAttributeData(Attribute attribute)
	{
		if (attribute is DllImportAttribute)
		{
			Init((DllImportAttribute)attribute);
		}
		else if (attribute is FieldOffsetAttribute)
		{
			Init((FieldOffsetAttribute)attribute);
		}
		else if (attribute is MarshalAsAttribute)
		{
			Init((MarshalAsAttribute)attribute);
		}
		else if (attribute is TypeForwardedToAttribute)
		{
			Init((TypeForwardedToAttribute)attribute);
		}
		else
		{
			Init(attribute);
		}
	}

	private void Init(DllImportAttribute dllImport)
	{
		Type typeFromHandle = typeof(DllImportAttribute);
		m_ctor = typeFromHandle.GetConstructors(BindingFlags.Instance | BindingFlags.Public)[0];
		m_typedCtorArgs = Array.AsReadOnly(new CustomAttributeTypedArgument[1]
		{
			new CustomAttributeTypedArgument(dllImport.Value)
		});
		m_namedArgs = Array.AsReadOnly(new CustomAttributeNamedArgument[8]
		{
			new CustomAttributeNamedArgument(typeFromHandle.GetField("EntryPoint"), dllImport.EntryPoint),
			new CustomAttributeNamedArgument(typeFromHandle.GetField("CharSet"), dllImport.CharSet),
			new CustomAttributeNamedArgument(typeFromHandle.GetField("ExactSpelling"), dllImport.ExactSpelling),
			new CustomAttributeNamedArgument(typeFromHandle.GetField("SetLastError"), dllImport.SetLastError),
			new CustomAttributeNamedArgument(typeFromHandle.GetField("PreserveSig"), dllImport.PreserveSig),
			new CustomAttributeNamedArgument(typeFromHandle.GetField("CallingConvention"), dllImport.CallingConvention),
			new CustomAttributeNamedArgument(typeFromHandle.GetField("BestFitMapping"), dllImport.BestFitMapping),
			new CustomAttributeNamedArgument(typeFromHandle.GetField("ThrowOnUnmappableChar"), dllImport.ThrowOnUnmappableChar)
		});
	}

	private void Init(FieldOffsetAttribute fieldOffset)
	{
		m_ctor = typeof(FieldOffsetAttribute).GetConstructors(BindingFlags.Instance | BindingFlags.Public)[0];
		m_typedCtorArgs = Array.AsReadOnly(new CustomAttributeTypedArgument[1]
		{
			new CustomAttributeTypedArgument(fieldOffset.Value)
		});
		m_namedArgs = Array.AsReadOnly(new CustomAttributeNamedArgument[0]);
	}

	private void Init(MarshalAsAttribute marshalAs)
	{
		Type typeFromHandle = typeof(MarshalAsAttribute);
		m_ctor = typeFromHandle.GetConstructors(BindingFlags.Instance | BindingFlags.Public)[0];
		m_typedCtorArgs = Array.AsReadOnly(new CustomAttributeTypedArgument[1]
		{
			new CustomAttributeTypedArgument(marshalAs.Value)
		});
		int num = 3;
		if (marshalAs.MarshalType != null)
		{
			num++;
		}
		if (marshalAs.MarshalTypeRef != null)
		{
			num++;
		}
		if (marshalAs.MarshalCookie != null)
		{
			num++;
		}
		num++;
		num++;
		if (marshalAs.SafeArrayUserDefinedSubType != null)
		{
			num++;
		}
		CustomAttributeNamedArgument[] array = new CustomAttributeNamedArgument[num];
		num = 0;
		array[num++] = new CustomAttributeNamedArgument(typeFromHandle.GetField("ArraySubType"), marshalAs.ArraySubType);
		array[num++] = new CustomAttributeNamedArgument(typeFromHandle.GetField("SizeParamIndex"), marshalAs.SizeParamIndex);
		array[num++] = new CustomAttributeNamedArgument(typeFromHandle.GetField("SizeConst"), marshalAs.SizeConst);
		array[num++] = new CustomAttributeNamedArgument(typeFromHandle.GetField("IidParameterIndex"), marshalAs.IidParameterIndex);
		array[num++] = new CustomAttributeNamedArgument(typeFromHandle.GetField("SafeArraySubType"), marshalAs.SafeArraySubType);
		if (marshalAs.MarshalType != null)
		{
			array[num++] = new CustomAttributeNamedArgument(typeFromHandle.GetField("MarshalType"), marshalAs.MarshalType);
		}
		if (marshalAs.MarshalTypeRef != null)
		{
			array[num++] = new CustomAttributeNamedArgument(typeFromHandle.GetField("MarshalTypeRef"), marshalAs.MarshalTypeRef);
		}
		if (marshalAs.MarshalCookie != null)
		{
			array[num++] = new CustomAttributeNamedArgument(typeFromHandle.GetField("MarshalCookie"), marshalAs.MarshalCookie);
		}
		if (marshalAs.SafeArrayUserDefinedSubType != null)
		{
			array[num++] = new CustomAttributeNamedArgument(typeFromHandle.GetField("SafeArrayUserDefinedSubType"), marshalAs.SafeArrayUserDefinedSubType);
		}
		m_namedArgs = Array.AsReadOnly(array);
	}

	private void Init(TypeForwardedToAttribute forwardedTo)
	{
		Type typeFromHandle = typeof(TypeForwardedToAttribute);
		Type[] types = new Type[1] { typeof(Type) };
		m_ctor = typeFromHandle.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, types, null);
		m_typedCtorArgs = Array.AsReadOnly(new CustomAttributeTypedArgument[1]
		{
			new CustomAttributeTypedArgument(typeof(Type), forwardedTo.Destination)
		});
		CustomAttributeNamedArgument[] array = new CustomAttributeNamedArgument[0];
		m_namedArgs = Array.AsReadOnly(array);
	}

	private void Init(object pca)
	{
		m_ctor = pca.GetType().GetConstructors(BindingFlags.Instance | BindingFlags.Public)[0];
		m_typedCtorArgs = Array.AsReadOnly(new CustomAttributeTypedArgument[0]);
		m_namedArgs = Array.AsReadOnly(new CustomAttributeNamedArgument[0]);
	}

	public override string ToString()
	{
		string text = "";
		for (int i = 0; i < ConstructorArguments.Count; i++)
		{
			text += string.Format(CultureInfo.CurrentCulture, (i == 0) ? "{0}" : ", {0}", ConstructorArguments[i]);
		}
		string text2 = "";
		for (int j = 0; j < NamedArguments.Count; j++)
		{
			text2 += string.Format(CultureInfo.CurrentCulture, (j == 0 && text.Length == 0) ? "{0}" : ", {0}", NamedArguments[j]);
		}
		return string.Format(CultureInfo.CurrentCulture, "[{0}({1}{2})]", Constructor.DeclaringType.FullName, text, text2);
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		return obj == this;
	}
}
