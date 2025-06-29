namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class PasswordPropertyTextAttribute : Attribute
{
	public static readonly PasswordPropertyTextAttribute Yes = new PasswordPropertyTextAttribute(password: true);

	public static readonly PasswordPropertyTextAttribute No = new PasswordPropertyTextAttribute(password: false);

	public static readonly PasswordPropertyTextAttribute Default = No;

	private bool _password;

	public bool Password => _password;

	public PasswordPropertyTextAttribute()
		: this(password: false)
	{
	}

	public PasswordPropertyTextAttribute(bool password)
	{
		_password = password;
	}

	public override bool Equals(object o)
	{
		if (o is PasswordPropertyTextAttribute)
		{
			return ((PasswordPropertyTextAttribute)o).Password == _password;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override bool IsDefaultAttribute()
	{
		return Equals(Default);
	}
}
