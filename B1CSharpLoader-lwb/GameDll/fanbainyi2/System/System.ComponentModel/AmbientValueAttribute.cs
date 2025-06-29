namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class AmbientValueAttribute : Attribute
{
	private readonly object value;

	public object Value => value;

	public AmbientValueAttribute(Type type, string value)
	{
		try
		{
			this.value = TypeDescriptor.GetConverter(type).ConvertFromInvariantString(value);
		}
		catch
		{
		}
	}

	public AmbientValueAttribute(char value)
	{
		this.value = value;
	}

	public AmbientValueAttribute(byte value)
	{
		this.value = value;
	}

	public AmbientValueAttribute(short value)
	{
		this.value = value;
	}

	public AmbientValueAttribute(int value)
	{
		this.value = value;
	}

	public AmbientValueAttribute(long value)
	{
		this.value = value;
	}

	public AmbientValueAttribute(float value)
	{
		this.value = value;
	}

	public AmbientValueAttribute(double value)
	{
		this.value = value;
	}

	public AmbientValueAttribute(bool value)
	{
		this.value = value;
	}

	public AmbientValueAttribute(string value)
	{
		this.value = value;
	}

	public AmbientValueAttribute(object value)
	{
		this.value = value;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is AmbientValueAttribute ambientValueAttribute)
		{
			if (value != null)
			{
				return value.Equals(ambientValueAttribute.Value);
			}
			return ambientValueAttribute.Value == null;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}
