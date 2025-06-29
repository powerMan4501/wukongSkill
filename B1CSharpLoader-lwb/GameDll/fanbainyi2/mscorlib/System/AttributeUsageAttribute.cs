using System.Runtime.InteropServices;

namespace System;

[Serializable]
[AttributeUsage(AttributeTargets.Class, Inherited = true)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AttributeUsageAttribute : Attribute
{
	internal AttributeTargets m_attributeTarget = AttributeTargets.All;

	internal bool m_allowMultiple;

	internal bool m_inherited = true;

	internal static AttributeUsageAttribute Default = new AttributeUsageAttribute(AttributeTargets.All);

	[__DynamicallyInvokable]
	public AttributeTargets ValidOn
	{
		[__DynamicallyInvokable]
		get
		{
			return m_attributeTarget;
		}
	}

	[__DynamicallyInvokable]
	public bool AllowMultiple
	{
		[__DynamicallyInvokable]
		get
		{
			return m_allowMultiple;
		}
		[__DynamicallyInvokable]
		set
		{
			m_allowMultiple = value;
		}
	}

	[__DynamicallyInvokable]
	public bool Inherited
	{
		[__DynamicallyInvokable]
		get
		{
			return m_inherited;
		}
		[__DynamicallyInvokable]
		set
		{
			m_inherited = value;
		}
	}

	[__DynamicallyInvokable]
	public AttributeUsageAttribute(AttributeTargets validOn)
	{
		m_attributeTarget = validOn;
	}

	internal AttributeUsageAttribute(AttributeTargets validOn, bool allowMultiple, bool inherited)
	{
		m_attributeTarget = validOn;
		m_allowMultiple = allowMultiple;
		m_inherited = inherited;
	}
}
