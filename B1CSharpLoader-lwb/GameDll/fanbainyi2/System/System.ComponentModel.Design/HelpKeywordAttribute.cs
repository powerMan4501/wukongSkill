namespace System.ComponentModel.Design;

[Serializable]
[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
public sealed class HelpKeywordAttribute : Attribute
{
	public static readonly HelpKeywordAttribute Default = new HelpKeywordAttribute();

	private string contextKeyword;

	public string HelpKeyword => contextKeyword;

	public HelpKeywordAttribute()
	{
	}

	public HelpKeywordAttribute(string keyword)
	{
		if (keyword == null)
		{
			throw new ArgumentNullException("keyword");
		}
		contextKeyword = keyword;
	}

	public HelpKeywordAttribute(Type t)
	{
		if (t == null)
		{
			throw new ArgumentNullException("t");
		}
		contextKeyword = t.FullName;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj != null && obj is HelpKeywordAttribute)
		{
			return ((HelpKeywordAttribute)obj).HelpKeyword == HelpKeyword;
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
