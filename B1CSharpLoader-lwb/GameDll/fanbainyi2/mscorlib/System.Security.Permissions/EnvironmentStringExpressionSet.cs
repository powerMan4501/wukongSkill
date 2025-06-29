using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
internal class EnvironmentStringExpressionSet : StringExpressionSet
{
	public EnvironmentStringExpressionSet()
		: base(ignoreCase: true, null, throwOnRelative: false)
	{
	}

	public EnvironmentStringExpressionSet(string str)
		: base(ignoreCase: true, str, throwOnRelative: false)
	{
	}

	protected override StringExpressionSet CreateNewEmpty()
	{
		return new EnvironmentStringExpressionSet();
	}

	protected override bool StringSubsetString(string left, string right, bool ignoreCase)
	{
		if (!ignoreCase)
		{
			return string.Compare(left, right, StringComparison.Ordinal) == 0;
		}
		return string.Compare(left, right, StringComparison.OrdinalIgnoreCase) == 0;
	}

	protected override string ProcessWholeString(string str)
	{
		return str;
	}

	protected override string ProcessSingleString(string str)
	{
		return str;
	}

	[SecuritySafeCritical]
	public override string ToString()
	{
		return UnsafeToString();
	}
}
