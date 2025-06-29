namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class ListBindableAttribute : Attribute
{
	public static readonly ListBindableAttribute Yes = new ListBindableAttribute(listBindable: true);

	public static readonly ListBindableAttribute No = new ListBindableAttribute(listBindable: false);

	public static readonly ListBindableAttribute Default = Yes;

	private bool listBindable;

	private bool isDefault;

	public bool ListBindable => listBindable;

	public ListBindableAttribute(bool listBindable)
	{
		this.listBindable = listBindable;
	}

	public ListBindableAttribute(BindableSupport flags)
	{
		listBindable = flags != BindableSupport.No;
		isDefault = flags == BindableSupport.Default;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is ListBindableAttribute listBindableAttribute)
		{
			return listBindableAttribute.ListBindable == listBindable;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
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
