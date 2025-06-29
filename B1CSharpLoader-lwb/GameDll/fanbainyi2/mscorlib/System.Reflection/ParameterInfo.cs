using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Reflection;

[Serializable]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_ParameterInfo))]
[ComVisible(true)]
[__DynamicallyInvokable]
public class ParameterInfo : _ParameterInfo, ICustomAttributeProvider, IObjectReference
{
	protected string NameImpl;

	protected Type ClassImpl;

	protected int PositionImpl;

	protected ParameterAttributes AttrsImpl;

	protected object DefaultValueImpl;

	protected MemberInfo MemberImpl;

	[OptionalField]
	private IntPtr _importer;

	[OptionalField]
	private int _token;

	[OptionalField]
	private bool bExtraConstChecked;

	[__DynamicallyInvokable]
	public virtual Type ParameterType
	{
		[__DynamicallyInvokable]
		get
		{
			return ClassImpl;
		}
	}

	[__DynamicallyInvokable]
	public virtual string Name
	{
		[__DynamicallyInvokable]
		get
		{
			return NameImpl;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool HasDefaultValue
	{
		[__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public virtual object DefaultValue
	{
		[__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	public virtual object RawDefaultValue
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public virtual int Position
	{
		[__DynamicallyInvokable]
		get
		{
			return PositionImpl;
		}
	}

	[__DynamicallyInvokable]
	public virtual ParameterAttributes Attributes
	{
		[__DynamicallyInvokable]
		get
		{
			return AttrsImpl;
		}
	}

	[__DynamicallyInvokable]
	public virtual MemberInfo Member
	{
		[__DynamicallyInvokable]
		get
		{
			return MemberImpl;
		}
	}

	[__DynamicallyInvokable]
	public bool IsIn
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & ParameterAttributes.In) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsOut
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & ParameterAttributes.Out) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsLcid
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & ParameterAttributes.Lcid) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsRetval
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & ParameterAttributes.Retval) != 0;
		}
	}

	[__DynamicallyInvokable]
	public bool IsOptional
	{
		[__DynamicallyInvokable]
		get
		{
			return (Attributes & ParameterAttributes.Optional) != 0;
		}
	}

	public virtual int MetadataToken
	{
		get
		{
			if (this is RuntimeParameterInfo runtimeParameterInfo)
			{
				return runtimeParameterInfo.MetadataToken;
			}
			return 134217728;
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<CustomAttributeData> CustomAttributes
	{
		[__DynamicallyInvokable]
		get
		{
			return GetCustomAttributesData();
		}
	}

	protected ParameterInfo()
	{
	}

	internal void SetName(string name)
	{
		NameImpl = name;
	}

	internal void SetAttributes(ParameterAttributes attributes)
	{
		AttrsImpl = attributes;
	}

	public virtual Type[] GetRequiredCustomModifiers()
	{
		return EmptyArray<Type>.Value;
	}

	public virtual Type[] GetOptionalCustomModifiers()
	{
		return EmptyArray<Type>.Value;
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return ParameterType.FormatTypeName() + " " + Name;
	}

	[__DynamicallyInvokable]
	public virtual object[] GetCustomAttributes(bool inherit)
	{
		return EmptyArray<object>.Value;
	}

	[__DynamicallyInvokable]
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		return EmptyArray<object>.Value;
	}

	[__DynamicallyInvokable]
	public virtual bool IsDefined(Type attributeType, bool inherit)
	{
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		return false;
	}

	public virtual IList<CustomAttributeData> GetCustomAttributesData()
	{
		throw new NotImplementedException();
	}

	void _ParameterInfo.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _ParameterInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _ParameterInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _ParameterInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}

	[SecurityCritical]
	public object GetRealObject(StreamingContext context)
	{
		if (MemberImpl == null)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InsufficientState"));
		}
		ParameterInfo[] array = null;
		switch (MemberImpl.MemberType)
		{
		case MemberTypes.Constructor:
		case MemberTypes.Method:
			if (PositionImpl == -1)
			{
				if (MemberImpl.MemberType == MemberTypes.Method)
				{
					return ((MethodInfo)MemberImpl).ReturnParameter;
				}
				throw new SerializationException(Environment.GetResourceString("Serialization_BadParameterInfo"));
			}
			array = ((MethodBase)MemberImpl).GetParametersNoCopy();
			if (array != null && PositionImpl < array.Length)
			{
				return array[PositionImpl];
			}
			throw new SerializationException(Environment.GetResourceString("Serialization_BadParameterInfo"));
		case MemberTypes.Property:
			array = ((RuntimePropertyInfo)MemberImpl).GetIndexParametersNoCopy();
			if (array != null && PositionImpl > -1 && PositionImpl < array.Length)
			{
				return array[PositionImpl];
			}
			throw new SerializationException(Environment.GetResourceString("Serialization_BadParameterInfo"));
		default:
			throw new SerializationException(Environment.GetResourceString("Serialization_NoParameterInfo"));
		}
	}
}
