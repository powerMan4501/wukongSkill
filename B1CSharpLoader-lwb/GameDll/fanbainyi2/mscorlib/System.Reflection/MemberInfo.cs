using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Reflection;

[Serializable]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_MemberInfo))]
[ComVisible(true)]
[__DynamicallyInvokable]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public abstract class MemberInfo : ICustomAttributeProvider, _MemberInfo
{
	public abstract MemberTypes MemberType { get; }

	[__DynamicallyInvokable]
	public abstract string Name
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract Type DeclaringType
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract Type ReflectedType
	{
		[__DynamicallyInvokable]
		get;
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

	public virtual int MetadataToken
	{
		get
		{
			throw new InvalidOperationException();
		}
	}

	[__DynamicallyInvokable]
	public virtual Module Module
	{
		[__DynamicallyInvokable]
		get
		{
			if (this is Type)
			{
				return ((Type)this).Module;
			}
			throw new NotImplementedException();
		}
	}

	internal virtual bool CacheEquals(object o)
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public abstract object[] GetCustomAttributes(bool inherit);

	[__DynamicallyInvokable]
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	[__DynamicallyInvokable]
	public abstract bool IsDefined(Type attributeType, bool inherit);

	public virtual IList<CustomAttributeData> GetCustomAttributesData()
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public static bool operator ==(MemberInfo left, MemberInfo right)
	{
		if ((object)left == right)
		{
			return true;
		}
		if ((object)left == null || (object)right == null)
		{
			return false;
		}
		Type type;
		Type type2;
		if ((type = left as Type) != null && (type2 = right as Type) != null)
		{
			return type == type2;
		}
		MethodBase methodBase;
		MethodBase methodBase2;
		if ((methodBase = left as MethodBase) != null && (methodBase2 = right as MethodBase) != null)
		{
			return methodBase == methodBase2;
		}
		FieldInfo fieldInfo;
		FieldInfo fieldInfo2;
		if ((fieldInfo = left as FieldInfo) != null && (fieldInfo2 = right as FieldInfo) != null)
		{
			return fieldInfo == fieldInfo2;
		}
		EventInfo eventInfo;
		EventInfo eventInfo2;
		if ((eventInfo = left as EventInfo) != null && (eventInfo2 = right as EventInfo) != null)
		{
			return eventInfo == eventInfo2;
		}
		PropertyInfo propertyInfo;
		PropertyInfo propertyInfo2;
		if ((propertyInfo = left as PropertyInfo) != null && (propertyInfo2 = right as PropertyInfo) != null)
		{
			return propertyInfo == propertyInfo2;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool operator !=(MemberInfo left, MemberInfo right)
	{
		return !(left == right);
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		return base.Equals(obj);
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	Type _MemberInfo.GetType()
	{
		return GetType();
	}

	void _MemberInfo.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _MemberInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _MemberInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _MemberInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
