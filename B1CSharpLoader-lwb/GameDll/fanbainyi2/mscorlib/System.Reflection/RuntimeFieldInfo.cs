using System.Collections.Generic;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Reflection;

[Serializable]
internal abstract class RuntimeFieldInfo : FieldInfo, ISerializable
{
	private BindingFlags m_bindingFlags;

	protected RuntimeType.RuntimeTypeCache m_reflectedTypeCache;

	protected RuntimeType m_declaringType;

	private RemotingFieldCachedData m_cachedData;

	internal RemotingFieldCachedData RemotingCache
	{
		get
		{
			RemotingFieldCachedData remotingFieldCachedData = m_cachedData;
			if (remotingFieldCachedData == null)
			{
				remotingFieldCachedData = new RemotingFieldCachedData(this);
				RemotingFieldCachedData remotingFieldCachedData2 = Interlocked.CompareExchange(ref m_cachedData, remotingFieldCachedData, null);
				if (remotingFieldCachedData2 != null)
				{
					remotingFieldCachedData = remotingFieldCachedData2;
				}
			}
			return remotingFieldCachedData;
		}
	}

	internal BindingFlags BindingFlags => m_bindingFlags;

	private RuntimeType ReflectedTypeInternal => m_reflectedTypeCache.GetRuntimeType();

	public override MemberTypes MemberType => MemberTypes.Field;

	public override Type ReflectedType
	{
		get
		{
			if (!m_reflectedTypeCache.IsGlobal)
			{
				return ReflectedTypeInternal;
			}
			return null;
		}
	}

	public override Type DeclaringType
	{
		get
		{
			if (!m_reflectedTypeCache.IsGlobal)
			{
				return m_declaringType;
			}
			return null;
		}
	}

	public override Module Module => GetRuntimeModule();

	protected RuntimeFieldInfo()
	{
	}

	protected RuntimeFieldInfo(RuntimeType.RuntimeTypeCache reflectedTypeCache, RuntimeType declaringType, BindingFlags bindingFlags)
	{
		m_bindingFlags = bindingFlags;
		m_declaringType = declaringType;
		m_reflectedTypeCache = reflectedTypeCache;
	}

	internal RuntimeType GetDeclaringTypeInternal()
	{
		return m_declaringType;
	}

	internal RuntimeType GetRuntimeType()
	{
		return m_declaringType;
	}

	internal abstract RuntimeModule GetRuntimeModule();

	public override string ToString()
	{
		if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			return FieldType.ToString() + " " + Name;
		}
		return FieldType.FormatTypeName() + " " + Name;
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

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		MemberInfoSerializationHolder.GetSerializationInfo(info, Name, ReflectedTypeInternal, ToString(), MemberTypes.Field);
	}
}
