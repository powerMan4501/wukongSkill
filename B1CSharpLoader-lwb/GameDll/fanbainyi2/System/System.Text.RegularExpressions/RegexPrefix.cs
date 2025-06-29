namespace System.Text.RegularExpressions;

internal sealed class RegexPrefix
{
	internal string _prefix;

	internal bool _caseInsensitive;

	internal static RegexPrefix _empty = new RegexPrefix(string.Empty, ci: false);

	internal string Prefix => _prefix;

	internal bool CaseInsensitive => _caseInsensitive;

	internal static RegexPrefix Empty => _empty;

	internal RegexPrefix(string prefix, bool ci)
	{
		_prefix = prefix;
		_caseInsensitive = ci;
	}
}
