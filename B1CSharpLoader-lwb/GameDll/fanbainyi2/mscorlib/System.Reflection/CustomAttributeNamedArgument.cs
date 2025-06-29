using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct CustomAttributeNamedArgument
{
	private MemberInfo m_memberInfo;

	private CustomAttributeTypedArgument m_value;

	internal Type ArgumentType
	{
		get
		{
			if (!(m_memberInfo is FieldInfo))
			{
				return ((PropertyInfo)m_memberInfo).PropertyType;
			}
			return ((FieldInfo)m_memberInfo).FieldType;
		}
	}

	public MemberInfo MemberInfo => m_memberInfo;

	[__DynamicallyInvokable]
	public CustomAttributeTypedArgument TypedValue
	{
		[__DynamicallyInvokable]
		get
		{
			return m_value;
		}
	}

	[__DynamicallyInvokable]
	public string MemberName
	{
		[__DynamicallyInvokable]
		get
		{
			return MemberInfo.Name;
		}
	}

	[__DynamicallyInvokable]
	public bool IsField
	{
		[__DynamicallyInvokable]
		get
		{
			return MemberInfo is FieldInfo;
		}
	}

	public static bool operator ==(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
	{
		return !left.Equals(right);
	}

	public CustomAttributeNamedArgument(MemberInfo memberInfo, object value)
	{
		if (memberInfo == null)
		{
			throw new ArgumentNullException("memberInfo");
		}
		Type type = null;
		FieldInfo fieldInfo = memberInfo as FieldInfo;
		PropertyInfo propertyInfo = memberInfo as PropertyInfo;
		if (fieldInfo != null)
		{
			type = fieldInfo.FieldType;
		}
		else
		{
			if (!(propertyInfo != null))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidMemberForNamedArgument"));
			}
			type = propertyInfo.PropertyType;
		}
		m_memberInfo = memberInfo;
		m_value = new CustomAttributeTypedArgument(type, value);
	}

	public CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument)
	{
		if (memberInfo == null)
		{
			throw new ArgumentNullException("memberInfo");
		}
		m_memberInfo = memberInfo;
		m_value = typedArgument;
	}

	public override string ToString()
	{
		if (m_memberInfo == null)
		{
			return base.ToString();
		}
		return string.Format(CultureInfo.CurrentCulture, "{0} = {1}", MemberInfo.Name, TypedValue.ToString(ArgumentType != typeof(object)));
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		return obj == (object)this;
	}
}
