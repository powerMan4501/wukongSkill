namespace UnrealEngine.Runtime;

public struct csbool
{
	private int val;

	public bool Value
	{
		get
		{
			return val != 0;
		}
		set
		{
			val = (value ? 1 : 0);
		}
	}

	public csbool(int value)
	{
		val = ((value != 0) ? 1 : 0);
	}

	public csbool(bool value)
	{
		val = (value ? 1 : 0);
	}

	public static implicit operator csbool(bool value)
	{
		return new csbool(value);
	}

	public static implicit operator bool(csbool value)
	{
		return value.Value;
	}

	public override string ToString()
	{
		return Value.ToString();
	}
}
