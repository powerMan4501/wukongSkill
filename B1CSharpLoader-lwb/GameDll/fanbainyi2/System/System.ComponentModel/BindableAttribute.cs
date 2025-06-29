namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class BindableAttribute : Attribute
{
	public static readonly BindableAttribute Yes = new BindableAttribute(bindable: true);

	public static readonly BindableAttribute No = new BindableAttribute(bindable: false);

	public static readonly BindableAttribute Default = No;

	private bool bindable;

	private bool isDefault;

	private BindingDirection direction;

	public bool Bindable => bindable;

	public BindingDirection Direction => direction;

	public BindableAttribute(bool bindable)
		: this(bindable, BindingDirection.OneWay)
	{
	}

	public BindableAttribute(bool bindable, BindingDirection direction)
	{
		this.bindable = bindable;
		this.direction = direction;
	}

	public BindableAttribute(BindableSupport flags)
		: this(flags, BindingDirection.OneWay)
	{
	}

	public BindableAttribute(BindableSupport flags, BindingDirection direction)
	{
		bindable = flags != BindableSupport.No;
		isDefault = flags == BindableSupport.Default;
		this.direction = direction;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj != null && obj is BindableAttribute)
		{
			return ((BindableAttribute)obj).Bindable == bindable;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return bindable.GetHashCode();
	}

	public override bool IsDefaultAttribute()
	{
		if (!Equals(Default))
		{
			return isDefault;
		}
		return true;
	}
}
