using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Reflection;

[Serializable]
internal sealed class RuntimeParameterInfo : ParameterInfo, ISerializable
{
	private static readonly Type s_DecimalConstantAttributeType = typeof(DecimalConstantAttribute);

	private static readonly Type s_CustomConstantAttributeType = typeof(CustomConstantAttribute);

	[NonSerialized]
	private int m_tkParamDef;

	[NonSerialized]
	private MetadataImport m_scope;

	[NonSerialized]
	private Signature m_signature;

	[NonSerialized]
	private volatile bool m_nameIsCached;

	[NonSerialized]
	private readonly bool m_noMetadata;

	[NonSerialized]
	private bool m_noDefaultValue;

	[NonSerialized]
	private MethodBase m_originalMember;

	private RemotingParameterCachedData m_cachedData;

	internal MethodBase DefiningMethod => (m_originalMember != null) ? m_originalMember : (MemberImpl as MethodBase);

	public override Type ParameterType
	{
		get
		{
			if (ClassImpl == null)
			{
				RuntimeType classImpl = ((PositionImpl != -1) ? m_signature.Arguments[PositionImpl] : m_signature.ReturnType);
				ClassImpl = classImpl;
			}
			return ClassImpl;
		}
	}

	public override string Name
	{
		[SecuritySafeCritical]
		get
		{
			if (!m_nameIsCached)
			{
				if (!System.Reflection.MetadataToken.IsNullToken(m_tkParamDef))
				{
					string nameImpl = m_scope.GetName(m_tkParamDef).ToString();
					NameImpl = nameImpl;
				}
				m_nameIsCached = true;
			}
			return NameImpl;
		}
	}

	public override bool HasDefaultValue
	{
		get
		{
			if (m_noMetadata || m_noDefaultValue)
			{
				return false;
			}
			object defaultValueInternal = GetDefaultValueInternal(raw: false);
			return defaultValueInternal != DBNull.Value;
		}
	}

	public override object DefaultValue => GetDefaultValue(raw: false);

	public override object RawDefaultValue => GetDefaultValue(raw: true);

	public override int MetadataToken => m_tkParamDef;

	internal RemotingParameterCachedData RemotingCache
	{
		get
		{
			RemotingParameterCachedData remotingParameterCachedData = m_cachedData;
			if (remotingParameterCachedData == null)
			{
				remotingParameterCachedData = new RemotingParameterCachedData(this);
				RemotingParameterCachedData remotingParameterCachedData2 = Interlocked.CompareExchange(ref m_cachedData, remotingParameterCachedData, null);
				if (remotingParameterCachedData2 != null)
				{
					remotingParameterCachedData = remotingParameterCachedData2;
				}
			}
			return remotingParameterCachedData;
		}
	}

	[SecurityCritical]
	internal static ParameterInfo[] GetParameters(IRuntimeMethodInfo method, MemberInfo member, Signature sig)
	{
		ParameterInfo returnParameter;
		return GetParameters(method, member, sig, out returnParameter, fetchReturnParameter: false);
	}

	[SecurityCritical]
	internal static ParameterInfo GetReturnParameter(IRuntimeMethodInfo method, MemberInfo member, Signature sig)
	{
		GetParameters(method, member, sig, out var returnParameter, fetchReturnParameter: true);
		return returnParameter;
	}

	[SecurityCritical]
	internal static ParameterInfo[] GetParameters(IRuntimeMethodInfo methodHandle, MemberInfo member, Signature sig, out ParameterInfo returnParameter, bool fetchReturnParameter)
	{
		returnParameter = null;
		int num = sig.Arguments.Length;
		ParameterInfo[] array = (fetchReturnParameter ? null : new ParameterInfo[num]);
		int methodDef = RuntimeMethodHandle.GetMethodDef(methodHandle);
		int num2 = 0;
		if (!System.Reflection.MetadataToken.IsNullToken(methodDef))
		{
			MetadataImport metadataImport = RuntimeTypeHandle.GetMetadataImport(RuntimeMethodHandle.GetDeclaringType(methodHandle));
			metadataImport.EnumParams(methodDef, out var result);
			num2 = result.Length;
			if (num2 > num + 1)
			{
				throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ParameterSignatureMismatch"));
			}
			for (int i = 0; i < num2; i++)
			{
				int num3 = result[i];
				metadataImport.GetParamDefProps(num3, out var sequence, out var attributes);
				sequence--;
				if (fetchReturnParameter && sequence == -1)
				{
					if (returnParameter != null)
					{
						throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ParameterSignatureMismatch"));
					}
					returnParameter = new RuntimeParameterInfo(sig, metadataImport, num3, sequence, attributes, member);
				}
				else if (!fetchReturnParameter && sequence >= 0)
				{
					if (sequence >= num)
					{
						throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ParameterSignatureMismatch"));
					}
					array[sequence] = new RuntimeParameterInfo(sig, metadataImport, num3, sequence, attributes, member);
				}
			}
		}
		if (fetchReturnParameter)
		{
			if (returnParameter == null)
			{
				returnParameter = new RuntimeParameterInfo(sig, MetadataImport.EmptyImport, 0, -1, ParameterAttributes.None, member);
			}
		}
		else if (num2 < array.Length + 1)
		{
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j] == null)
				{
					array[j] = new RuntimeParameterInfo(sig, MetadataImport.EmptyImport, 0, j, ParameterAttributes.None, member);
				}
			}
		}
		return array;
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.SetType(typeof(ParameterInfo));
		info.AddValue("AttrsImpl", Attributes);
		info.AddValue("ClassImpl", ParameterType);
		info.AddValue("DefaultValueImpl", DefaultValue);
		info.AddValue("MemberImpl", Member);
		info.AddValue("NameImpl", Name);
		info.AddValue("PositionImpl", Position);
		info.AddValue("_token", m_tkParamDef);
	}

	internal RuntimeParameterInfo(RuntimeParameterInfo accessor, RuntimePropertyInfo property)
		: this(accessor, (MemberInfo)property)
	{
		m_signature = property.Signature;
	}

	private RuntimeParameterInfo(RuntimeParameterInfo accessor, MemberInfo member)
	{
		MemberImpl = member;
		m_originalMember = accessor.MemberImpl as MethodBase;
		NameImpl = accessor.Name;
		m_nameIsCached = true;
		ClassImpl = accessor.ParameterType;
		PositionImpl = accessor.Position;
		AttrsImpl = accessor.Attributes;
		m_tkParamDef = (System.Reflection.MetadataToken.IsNullToken(accessor.MetadataToken) ? 134217728 : accessor.MetadataToken);
		m_scope = accessor.m_scope;
	}

	private RuntimeParameterInfo(Signature signature, MetadataImport scope, int tkParamDef, int position, ParameterAttributes attributes, MemberInfo member)
	{
		PositionImpl = position;
		MemberImpl = member;
		m_signature = signature;
		m_tkParamDef = (System.Reflection.MetadataToken.IsNullToken(tkParamDef) ? 134217728 : tkParamDef);
		m_scope = scope;
		AttrsImpl = attributes;
		ClassImpl = null;
		NameImpl = null;
	}

	internal RuntimeParameterInfo(MethodInfo owner, string name, Type parameterType, int position)
	{
		MemberImpl = owner;
		NameImpl = name;
		m_nameIsCached = true;
		m_noMetadata = true;
		ClassImpl = parameterType;
		PositionImpl = position;
		AttrsImpl = ParameterAttributes.None;
		m_tkParamDef = 134217728;
		m_scope = MetadataImport.EmptyImport;
	}

	private object GetDefaultValue(bool raw)
	{
		if (m_noMetadata)
		{
			return null;
		}
		object obj = GetDefaultValueInternal(raw);
		if (obj == DBNull.Value && base.IsOptional)
		{
			obj = Type.Missing;
		}
		return obj;
	}

	[SecuritySafeCritical]
	private object GetDefaultValueInternal(bool raw)
	{
		if (m_noDefaultValue)
		{
			return DBNull.Value;
		}
		object obj = null;
		if (ParameterType == typeof(DateTime))
		{
			if (raw)
			{
				CustomAttributeTypedArgument customAttributeTypedArgument = CustomAttributeData.Filter(CustomAttributeData.GetCustomAttributes(this), typeof(DateTimeConstantAttribute), 0);
				if (customAttributeTypedArgument.ArgumentType != null)
				{
					return new DateTime((long)customAttributeTypedArgument.Value);
				}
			}
			else
			{
				object[] customAttributes = GetCustomAttributes(typeof(DateTimeConstantAttribute), inherit: false);
				if (customAttributes != null && customAttributes.Length != 0)
				{
					return ((DateTimeConstantAttribute)customAttributes[0]).Value;
				}
			}
		}
		if (!System.Reflection.MetadataToken.IsNullToken(m_tkParamDef))
		{
			obj = MdConstant.GetValue(m_scope, m_tkParamDef, ParameterType.GetTypeHandleInternal(), raw);
		}
		if (obj == DBNull.Value)
		{
			if (raw)
			{
				foreach (CustomAttributeData customAttribute in CustomAttributeData.GetCustomAttributes(this))
				{
					Type declaringType = customAttribute.Constructor.DeclaringType;
					if (declaringType == typeof(DateTimeConstantAttribute))
					{
						obj = DateTimeConstantAttribute.GetRawDateTimeConstant(customAttribute);
					}
					else if (declaringType == typeof(DecimalConstantAttribute))
					{
						obj = DecimalConstantAttribute.GetRawDecimalConstant(customAttribute);
					}
					else if (declaringType.IsSubclassOf(s_CustomConstantAttributeType))
					{
						obj = CustomConstantAttribute.GetRawConstant(customAttribute);
					}
				}
			}
			else
			{
				object[] customAttributes2 = GetCustomAttributes(s_CustomConstantAttributeType, inherit: false);
				if (customAttributes2.Length != 0)
				{
					obj = ((CustomConstantAttribute)customAttributes2[0]).Value;
				}
				else
				{
					customAttributes2 = GetCustomAttributes(s_DecimalConstantAttributeType, inherit: false);
					if (customAttributes2.Length != 0)
					{
						obj = ((DecimalConstantAttribute)customAttributes2[0]).Value;
					}
				}
			}
		}
		if (obj == DBNull.Value)
		{
			m_noDefaultValue = true;
		}
		return obj;
	}

	internal RuntimeModule GetRuntimeModule()
	{
		RuntimeMethodInfo runtimeMethodInfo = Member as RuntimeMethodInfo;
		RuntimeConstructorInfo runtimeConstructorInfo = Member as RuntimeConstructorInfo;
		RuntimePropertyInfo runtimePropertyInfo = Member as RuntimePropertyInfo;
		if (runtimeMethodInfo != null)
		{
			return runtimeMethodInfo.GetRuntimeModule();
		}
		if (runtimeConstructorInfo != null)
		{
			return runtimeConstructorInfo.GetRuntimeModule();
		}
		if (runtimePropertyInfo != null)
		{
			return runtimePropertyInfo.GetRuntimeModule();
		}
		return null;
	}

	public override Type[] GetRequiredCustomModifiers()
	{
		return m_signature.GetCustomModifiers(PositionImpl + 1, required: true);
	}

	public override Type[] GetOptionalCustomModifiers()
	{
		return m_signature.GetCustomModifiers(PositionImpl + 1, required: false);
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		if (System.Reflection.MetadataToken.IsNullToken(m_tkParamDef))
		{
			return EmptyArray<object>.Value;
		}
		return CustomAttribute.GetCustomAttributes(this, typeof(object) as RuntimeType);
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		if (System.Reflection.MetadataToken.IsNullToken(m_tkParamDef))
		{
			return EmptyArray<object>.Value;
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
		if (System.Reflection.MetadataToken.IsNullToken(m_tkParamDef))
		{
			return false;
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
}
