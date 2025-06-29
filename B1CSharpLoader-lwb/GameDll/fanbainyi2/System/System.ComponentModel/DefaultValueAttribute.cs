namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
[global::__DynamicallyInvokable]
public class DefaultValueAttribute : Attribute
{
	private object value;

	[global::__DynamicallyInvokable]
	public virtual object Value
	{
		[global::__DynamicallyInvokable]
		get
		{
			return value;
		}
	}

	[global::__DynamicallyInvokable]
	public DefaultValueAttribute(Type type, string value)
	{
		try
		{
			this.value = TypeDescriptor.GetConverter(type).ConvertFromInvariantString(value);
		}
		catch
		{
		}
	}

	[global::__DynamicallyInvokable]
	public DefaultValueAttribute(char value)
	{
		this.value = value;
	}

	[global::__DynamicallyInvokable]
	public DefaultValueAttribute(byte value)
	{
		this.value = value;
	}

	[global::__DynamicallyInvokable]
	public DefaultValueAttribute(short value)
	{
		this.value = value;
	}

	[global::__DynamicallyInvokable]
	public DefaultValueAttribute(int value)
	{
		this.value = value;
	}

	[global::__DynamicallyInvokable]
	public DefaultValueAttribute(long value)
	{
		this.value = value;
	}

	[global::__DynamicallyInvokable]
	public DefaultValueAttribute(float value)
	{
		this.value = value;
	}

	[global::__DynamicallyInvokable]
	public DefaultValueAttribute(double value)
	{
		this.value = value;
	}

	[global::__DynamicallyInvokable]
	public DefaultValueAttribute(bool value)
	{
		this.value = value;
	}

	[global::__DynamicallyInvokable]
	public DefaultValueAttribute(string value)
	{
		this.value = value;
	}

	[global::__DynamicallyInvokable]
	public DefaultValueAttribute(object value)
	{
		this.value = value;
	}

	[global::__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is DefaultValueAttribute defaultValueAttribute)
		{
			if (Value != null)
			{
				return Value.Equals(defaultValueAttribute.Value);
			}
			return defaultValueAttribute.Value == null;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	protected void SetValue(object value)
	{
		this.value = value;
	}
}
