using System.Collections;

namespace System.Text.RegularExpressions;

internal sealed class CachedCodeEntry
{
	internal string _key;

	internal RegexCode _code;

	internal Hashtable _caps;

	internal Hashtable _capnames;

	internal string[] _capslist;

	internal int _capsize;

	internal RegexRunnerFactory _factory;

	internal ExclusiveReference _runnerref;

	internal SharedReference _replref;

	internal CachedCodeEntry(string key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, SharedReference repl)
	{
		_key = key;
		_capnames = capnames;
		_capslist = capslist;
		_code = code;
		_caps = caps;
		_capsize = capsize;
		_runnerref = runner;
		_replref = repl;
	}

	internal void AddCompiled(RegexRunnerFactory factory)
	{
		_factory = factory;
		_code = null;
	}
}
