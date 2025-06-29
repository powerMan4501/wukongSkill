using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Security;
using System.Text;

namespace System.Reflection;

[Serializable]
internal sealed class RuntimePropertyInfo : PropertyInfo, ISerializable
{
	private int m_token;

	private string m_name;

	[SecurityCritical]
	private unsafe void* m_utf8name;

	private PropertyAttributes m_flags;

	private RuntimeType.RuntimeTypeCache m_reflectedTypeCache;

	private RuntimeMethodInfo m_getterMethod;

	private RuntimeMethodInfo m_setterMethod;

	private MethodInfo[] m_otherMethod;

	private RuntimeType m_declaringType;

	private BindingFlags m_bindingFlags;

	private Signature m_signature;

	private ParameterInfo[] m_parameters;

	internal unsafe Signature Signature
	{
		[SecuritySafeCritical]
		get
		{
			if (m_signature == null)
			{
				GetRuntimeModule().MetadataImport.GetPropertyProps(m_token, out var _, out var _, out var signature);
				m_signature = new Signature(signature.Signature.ToPointer(), signature.Length, m_declaringType);
			}
			return m_signature;
		}
	}

	internal BindingFlags BindingFlags => m_bindingFlags;

	public override MemberTypes MemberType => MemberTypes.Property;

	public unsafe override string Name
	{
		[SecuritySafeCritical]
		get
		{
			if (m_name == null)
			{
				m_name = new Utf8String(m_utf8name).ToString();
			}
			return m_name;
		}
	}

	public override Type DeclaringType => m_declaringType;

	public override Type ReflectedType => ReflectedTypeInternal;

	private RuntimeType ReflectedTypeInternal => m_reflectedTypeCache.GetRuntimeType();

	public override int MetadataToken => m_token;

	public override Module Module => GetRuntimeModule();

	public override Type PropertyType => Signature.ReturnType;

	public override PropertyAttributes Attributes => m_flags;

	public override bool CanRead => m_getterMethod != null;

	public override bool CanWrite => m_setterMethod != null;

	[SecurityCritical]
	internal unsafe RuntimePropertyInfo(int tkProperty, RuntimeType declaredType, RuntimeType.RuntimeTypeCache reflectedTypeCache, out bool isPrivate)
	{
		MetadataImport metadataImport = declaredType.GetRuntimeModule().MetadataImport;
		m_token = tkProperty;
		m_reflectedTypeCache = reflectedTypeCache;
		m_declaringType = declaredType;
		metadataImport.GetPropertyProps(tkProperty, out m_utf8name, out m_flags, out var _);
		Associates.AssignAssociates(metadataImport, tkProperty, declaredType, reflectedTypeCache.GetRuntimeType(), out var addOn, out addOn, out addOn, out m_getterMethod, out m_setterMethod, out m_otherMethod, out isPrivate, out m_bindingFlags);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal override bool CacheEquals(object o)
	{
		if (!(o is RuntimePropertyInfo runtimePropertyInfo))
		{
			return false;
		}
		if (runtimePropertyInfo.m_token == m_token)
		{
			return RuntimeTypeHandle.GetModule(m_declaringType).Equals(RuntimeTypeHandle.GetModule(runtimePropertyInfo.m_declaringType));
		}
		return false;
	}

	internal bool EqualsSig(RuntimePropertyInfo target)
	{
		return Signature.CompareSig(Signature, target.Signature);
	}

	public override string ToString()
	{
		return FormatNameAndSig(serialization: false);
	}

	private string FormatNameAndSig(bool serialization)
	{
		StringBuilder stringBuilder = new StringBuilder(PropertyType.FormatTypeName(serialization));
		stringBuilder.Append(" ");
		stringBuilder.Append(Name);
		RuntimeType[] arguments = Signature.Arguments;
		if (arguments.Length != 0)
		{
			stringBuilder.Append(" [");
			Type[] parameterTypes = arguments;
			stringBuilder.Append(MethodBase.ConstructParameters(parameterTypes, Signature.CallingConvention, serialization));
			stringBuilder.Append("]");
		}
		return stringBuilder.ToString();
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return CustomAttribute.GetCustomAttributes(this, typeof(object) as RuntimeType);
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "attributeType");
		}
		return CustomAttribute.GetCustomAttributes(this, runtimeType);
	}

	[SecuritySafeCritical]
	public override bool IsDefined(Type attributeType, bool inherit)
	{
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "attributeType");
		}
		return CustomAttribute.IsDefined(this, runtimeType);
	}

	public override IList<CustomAttributeData> GetCustomAttributesData()
	{
		return CustomAttributeData.GetCustomAttributesInternal(this);
	}

	internal RuntimeModule GetRuntimeModule()
	{
		return m_declaringType.GetRuntimeModule();
	}

	public override Type[] GetRequiredCustomModifiers()
	{
		return Signature.GetCustomModifiers(0, required: true);
	}

	public override Type[] GetOptionalCustomModifiers()
	{
		return Signature.GetCustomModifiers(0, required: false);
	}

	[SecuritySafeCritical]
	internal object GetConstantValue(bool raw)
	{
		object value = MdConstant.GetValue(GetRuntimeModule().MetadataImport, m_token, PropertyType.GetTypeHandleInternal(), raw);
		if (value == DBNull.Value)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_EnumLitValueNotFound"));
		}
		return value;
	}

	public override object GetConstantValue()
	{
		return GetConstantValue(raw: false);
	}

	public override object GetRawConstantValue()
	{
		return GetConstantValue(raw: true);
	}

	public override MethodInfo[] GetAccessors(bool nonPublic)
	{
		List<MethodInfo> list = new List<MethodInfo>();
		if (Associates.IncludeAccessor(m_getterMethod, nonPublic))
		{
			list.Add(m_getterMethod);
		}
		if (Associates.IncludeAccessor(m_setterMethod, nonPublic))
		{
			list.Add(m_setterMethod);
		}
		if (m_otherMethod != null)
		{
			for (int i = 0; i < m_otherMethod.Length; i++)
			{
				if (Associates.IncludeAccessor(m_otherMethod[i], nonPublic))
				{
					list.Add(m_otherMethod[i]);
				}
			}
		}
		return list.ToArray();
	}

	public override MethodInfo GetGetMethod(bool nonPublic)
	{
		if (!Associates.IncludeAccessor(m_getterMethod, nonPublic))
		{
			return null;
		}
		return m_getterMethod;
	}

	public override MethodInfo GetSetMethod(bool nonPublic)
	{
		if (!Associates.IncludeAccessor(m_setterMethod, nonPublic))
		{
			return null;
		}
		return m_setterMethod;
	}

	public override ParameterInfo[] GetIndexParameters()
	{
		ParameterInfo[] indexParametersNoCopy = GetIndexParametersNoCopy();
		int num = indexParametersNoCopy.Length;
		if (num == 0)
		{
			return indexParametersNoCopy;
		}
		ParameterInfo[] array = new ParameterInfo[num];
		Array.Copy(indexParametersNoCopy, array, num);
		return array;
	}

	internal ParameterInfo[] GetIndexParametersNoCopy()
	{
		if (m_parameters == null)
		{
			int num = 0;
			ParameterInfo[] array = null;
			MethodInfo getMethod = GetGetMethod(nonPublic: true);
			if (getMethod != null)
			{
				array = getMethod.GetParametersNoCopy();
				num = array.Length;
			}
			else
			{
				getMethod = GetSetMethod(nonPublic: true);
				if (getMethod != null)
				{
					array = getMethod.GetParametersNoCopy();
					num = array.Length - 1;
				}
			}
			ParameterInfo[] array2 = new ParameterInfo[num];
			for (int i = 0; i < num; i++)
			{
				array2[i] = new RuntimeParameterInfo((RuntimeParameterInfo)array[i], this);
			}
			m_parameters = array2;
		}
		return m_parameters;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public override object GetValue(object obj, object[] index)
	{
		return GetValue(obj, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, index, null);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
	{
		MethodInfo getMethod = GetGetMethod(nonPublic: true);
		if (getMethod == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_GetMethNotFnd"));
		}
		return getMethod.Invoke(obj, invokeAttr, binder, index, null);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public override void SetValue(object obj, object value, object[] index)
	{
		SetValue(obj, value, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, index, null);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
	{
		MethodInfo setMethod = GetSetMethod(nonPublic: true);
		if (setMethod == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_SetMethNotFnd"));
		}
		object[] array = null;
		if (index == null)
		{
			array = new object[1] { value };
		}
		else
		{
			array = new object[index.Length + 1];
			for (int i = 0; i < index.Length; i++)
			{
				array[i] = index[i];
			}
			array[index.Length] = value;
		}
		setMethod.Invoke(obj, invokeAttr, binder, array, culture);
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		MemberInfoSerializationHolder.GetSerializationInfo(info, Name, ReflectedTypeInternal, ToString(), SerializationToString(), MemberTypes.Property, null);
	}

	internal string SerializationToString()
	{
		return FormatNameAndSig(serialization: true);
	}
}
