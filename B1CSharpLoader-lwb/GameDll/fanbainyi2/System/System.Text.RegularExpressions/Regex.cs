using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System.Text.RegularExpressions;

[Serializable]
[global::__DynamicallyInvokable]
public class Regex : ISerializable
{
	protected internal string pattern;

	protected internal RegexRunnerFactory factory;

	protected internal RegexOptions roptions;

	[NonSerialized]
	private static readonly TimeSpan MaximumMatchTimeout = TimeSpan.FromMilliseconds(2147483646.0);

	[NonSerialized]
	[global::__DynamicallyInvokable]
	public static readonly TimeSpan InfiniteMatchTimeout = Timeout.InfiniteTimeSpan;

	[OptionalField(VersionAdded = 2)]
	protected internal TimeSpan internalMatchTimeout;

	private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";

	[NonSerialized]
	internal static readonly TimeSpan FallbackDefaultMatchTimeout = InfiniteMatchTimeout;

	[NonSerialized]
	internal static readonly TimeSpan DefaultMatchTimeout = InitDefaultMatchTimeout();

	protected internal Hashtable caps;

	protected internal Hashtable capnames;

	protected internal string[] capslist;

	protected internal int capsize;

	internal ExclusiveReference runnerref;

	internal SharedReference replref;

	internal RegexCode code;

	internal bool refsInitialized;

	internal static LinkedList<CachedCodeEntry> livecode = new LinkedList<CachedCodeEntry>();

	internal static int cacheSize = 15;

	internal const int MaxOptionShift = 10;

	[CLSCompliant(false)]
	protected IDictionary Caps
	{
		get
		{
			return caps;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			caps = value as Hashtable;
			if (caps == null)
			{
				caps = new Hashtable(value);
			}
		}
	}

	[CLSCompliant(false)]
	protected IDictionary CapNames
	{
		get
		{
			return capnames;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			capnames = value as Hashtable;
			if (capnames == null)
			{
				capnames = new Hashtable(value);
			}
		}
	}

	[global::__DynamicallyInvokable]
	public static int CacheSize
	{
		[global::__DynamicallyInvokable]
		get
		{
			return cacheSize;
		}
		[global::__DynamicallyInvokable]
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			cacheSize = value;
			if (livecode.Count <= cacheSize)
			{
				return;
			}
			lock (livecode)
			{
				while (livecode.Count > cacheSize)
				{
					livecode.RemoveLast();
				}
			}
		}
	}

	[global::__DynamicallyInvokable]
	public RegexOptions Options
	{
		[global::__DynamicallyInvokable]
		get
		{
			return roptions;
		}
	}

	[global::__DynamicallyInvokable]
	public TimeSpan MatchTimeout
	{
		[global::__DynamicallyInvokable]
		get
		{
			return internalMatchTimeout;
		}
	}

	[global::__DynamicallyInvokable]
	public bool RightToLeft
	{
		[global::__DynamicallyInvokable]
		get
		{
			return UseOptionR();
		}
	}

	[global::__DynamicallyInvokable]
	protected Regex()
	{
		internalMatchTimeout = DefaultMatchTimeout;
	}

	[global::__DynamicallyInvokable]
	public Regex(string pattern)
		: this(pattern, RegexOptions.None, DefaultMatchTimeout, useCache: false)
	{
	}

	[global::__DynamicallyInvokable]
	public Regex(string pattern, RegexOptions options)
		: this(pattern, options, DefaultMatchTimeout, useCache: false)
	{
	}

	[global::__DynamicallyInvokable]
	public Regex(string pattern, RegexOptions options, TimeSpan matchTimeout)
		: this(pattern, options, matchTimeout, useCache: false)
	{
	}

	private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache)
	{
		CachedCodeEntry cachedCodeEntry = null;
		string text = null;
		if (pattern == null)
		{
			throw new ArgumentNullException("pattern");
		}
		if (options < RegexOptions.None || (int)options >> 10 != 0)
		{
			throw new ArgumentOutOfRangeException("options");
		}
		if ((options & RegexOptions.ECMAScript) != RegexOptions.None && (options & ~(RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled | RegexOptions.ECMAScript | RegexOptions.CultureInvariant)) != RegexOptions.None)
		{
			throw new ArgumentOutOfRangeException("options");
		}
		ValidateMatchTimeout(matchTimeout);
		text = (((options & RegexOptions.CultureInvariant) == 0) ? CultureInfo.CurrentCulture.ToString() : CultureInfo.InvariantCulture.ToString());
		string[] array = new string[5];
		int num = (int)options;
		array[0] = num.ToString(NumberFormatInfo.InvariantInfo);
		array[1] = ":";
		array[2] = text;
		array[3] = ":";
		array[4] = pattern;
		string key = string.Concat(array);
		cachedCodeEntry = LookupCachedAndUpdate(key);
		this.pattern = pattern;
		roptions = options;
		internalMatchTimeout = matchTimeout;
		if (cachedCodeEntry == null)
		{
			RegexTree regexTree = RegexParser.Parse(pattern, roptions);
			capnames = regexTree._capnames;
			capslist = regexTree._capslist;
			code = RegexWriter.Write(regexTree);
			caps = code._caps;
			capsize = code._capsize;
			InitializeReferences();
			regexTree = null;
			if (useCache)
			{
				cachedCodeEntry = CacheCode(key);
			}
		}
		else
		{
			caps = cachedCodeEntry._caps;
			capnames = cachedCodeEntry._capnames;
			capslist = cachedCodeEntry._capslist;
			capsize = cachedCodeEntry._capsize;
			code = cachedCodeEntry._code;
			factory = cachedCodeEntry._factory;
			runnerref = cachedCodeEntry._runnerref;
			replref = cachedCodeEntry._replref;
			refsInitialized = true;
		}
		if (UseOptionC() && factory == null)
		{
			factory = Compile(code, roptions);
			if (useCache)
			{
				cachedCodeEntry?.AddCompiled(factory);
			}
			code = null;
		}
	}

	protected Regex(SerializationInfo info, StreamingContext context)
		: this(info.GetString("pattern"), (RegexOptions)info.GetInt32("options"))
	{
		try
		{
			long @int = info.GetInt64("matchTimeout");
			TimeSpan matchTimeout = new TimeSpan(@int);
			ValidateMatchTimeout(matchTimeout);
			internalMatchTimeout = matchTimeout;
		}
		catch (SerializationException)
		{
		}
	}

	void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
	{
		si.AddValue("pattern", ToString());
		si.AddValue("options", Options);
		si.AddValue("matchTimeout", MatchTimeout.Ticks);
	}

	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout)
	{
		if (InfiniteMatchTimeout == matchTimeout || (TimeSpan.Zero < matchTimeout && matchTimeout <= MaximumMatchTimeout))
		{
			return;
		}
		throw new ArgumentOutOfRangeException("matchTimeout");
	}

	private static TimeSpan InitDefaultMatchTimeout()
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		object data = currentDomain.GetData("REGEX_DEFAULT_MATCH_TIMEOUT");
		if (data == null)
		{
			return FallbackDefaultMatchTimeout;
		}
		if (!(data is TimeSpan timeSpan))
		{
			throw new InvalidCastException(SR.GetString("IllegalDefaultRegexMatchTimeoutInAppDomain", "REGEX_DEFAULT_MATCH_TIMEOUT"));
		}
		try
		{
			ValidateMatchTimeout(timeSpan);
			return timeSpan;
		}
		catch (ArgumentOutOfRangeException)
		{
			throw new ArgumentOutOfRangeException(SR.GetString("IllegalDefaultRegexMatchTimeoutInAppDomain", "REGEX_DEFAULT_MATCH_TIMEOUT"));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	internal RegexRunnerFactory Compile(RegexCode code, RegexOptions roptions)
	{
		return RegexCompiler.Compile(code, roptions);
	}

	[global::__DynamicallyInvokable]
	public static string Escape(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return RegexParser.Escape(str);
	}

	[global::__DynamicallyInvokable]
	public static string Unescape(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return RegexParser.Unescape(str);
	}

	[global::__DynamicallyInvokable]
	public override string ToString()
	{
		return pattern;
	}

	[global::__DynamicallyInvokable]
	public string[] GetGroupNames()
	{
		string[] array;
		if (capslist == null)
		{
			int num = capsize;
			array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = Convert.ToString(i, CultureInfo.InvariantCulture);
			}
		}
		else
		{
			array = new string[capslist.Length];
			Array.Copy(capslist, 0, array, 0, capslist.Length);
		}
		return array;
	}

	[global::__DynamicallyInvokable]
	public int[] GetGroupNumbers()
	{
		int[] array;
		if (caps == null)
		{
			int num = capsize;
			array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = i;
			}
		}
		else
		{
			array = new int[caps.Count];
			IDictionaryEnumerator enumerator = caps.GetEnumerator();
			while (enumerator.MoveNext())
			{
				array[(int)enumerator.Value] = (int)enumerator.Key;
			}
		}
		return array;
	}

	[global::__DynamicallyInvokable]
	public string GroupNameFromNumber(int i)
	{
		if (capslist == null)
		{
			if (i >= 0 && i < capsize)
			{
				return i.ToString(CultureInfo.InvariantCulture);
			}
			return string.Empty;
		}
		if (caps != null)
		{
			object obj = caps[i];
			if (obj == null)
			{
				return string.Empty;
			}
			i = (int)obj;
		}
		if (i >= 0 && i < capslist.Length)
		{
			return capslist[i];
		}
		return string.Empty;
	}

	[global::__DynamicallyInvokable]
	public int GroupNumberFromName(string name)
	{
		int num = -1;
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (capnames != null)
		{
			object obj = capnames[name];
			if (obj == null)
			{
				return -1;
			}
			return (int)obj;
		}
		num = 0;
		foreach (char c in name)
		{
			if (c > '9' || c < '0')
			{
				return -1;
			}
			num *= 10;
			num += c - 48;
		}
		if (num >= 0 && num < capsize)
		{
			return num;
		}
		return -1;
	}

	[global::__DynamicallyInvokable]
	public static bool IsMatch(string input, string pattern)
	{
		return IsMatch(input, pattern, RegexOptions.None, DefaultMatchTimeout);
	}

	[global::__DynamicallyInvokable]
	public static bool IsMatch(string input, string pattern, RegexOptions options)
	{
		return IsMatch(input, pattern, options, DefaultMatchTimeout);
	}

	[global::__DynamicallyInvokable]
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
	{
		return new Regex(pattern, options, matchTimeout, useCache: true).IsMatch(input);
	}

	[global::__DynamicallyInvokable]
	public bool IsMatch(string input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return IsMatch(input, UseOptionR() ? input.Length : 0);
	}

	[global::__DynamicallyInvokable]
	public bool IsMatch(string input, int startat)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return Run(quick: true, -1, input, 0, input.Length, startat) == null;
	}

	[global::__DynamicallyInvokable]
	public static Match Match(string input, string pattern)
	{
		return Match(input, pattern, RegexOptions.None, DefaultMatchTimeout);
	}

	[global::__DynamicallyInvokable]
	public static Match Match(string input, string pattern, RegexOptions options)
	{
		return Match(input, pattern, options, DefaultMatchTimeout);
	}

	[global::__DynamicallyInvokable]
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
	{
		return new Regex(pattern, options, matchTimeout, useCache: true).Match(input);
	}

	[global::__DynamicallyInvokable]
	public Match Match(string input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return Match(input, UseOptionR() ? input.Length : 0);
	}

	[global::__DynamicallyInvokable]
	public Match Match(string input, int startat)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return Run(quick: false, -1, input, 0, input.Length, startat);
	}

	[global::__DynamicallyInvokable]
	public Match Match(string input, int beginning, int length)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return Run(quick: false, -1, input, beginning, length, UseOptionR() ? (beginning + length) : beginning);
	}

	[global::__DynamicallyInvokable]
	public static MatchCollection Matches(string input, string pattern)
	{
		return Matches(input, pattern, RegexOptions.None, DefaultMatchTimeout);
	}

	[global::__DynamicallyInvokable]
	public static MatchCollection Matches(string input, string pattern, RegexOptions options)
	{
		return Matches(input, pattern, options, DefaultMatchTimeout);
	}

	[global::__DynamicallyInvokable]
	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
	{
		return new Regex(pattern, options, matchTimeout, useCache: true).Matches(input);
	}

	[global::__DynamicallyInvokable]
	public MatchCollection Matches(string input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return Matches(input, UseOptionR() ? input.Length : 0);
	}

	[global::__DynamicallyInvokable]
	public MatchCollection Matches(string input, int startat)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return new MatchCollection(this, input, 0, input.Length, startat);
	}

	[global::__DynamicallyInvokable]
	public static string Replace(string input, string pattern, string replacement)
	{
		return Replace(input, pattern, replacement, RegexOptions.None, DefaultMatchTimeout);
	}

	[global::__DynamicallyInvokable]
	public static string Replace(string input, string pattern, string replacement, RegexOptions options)
	{
		return Replace(input, pattern, replacement, options, DefaultMatchTimeout);
	}

	[global::__DynamicallyInvokable]
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout)
	{
		return new Regex(pattern, options, matchTimeout, useCache: true).Replace(input, replacement);
	}

	[global::__DynamicallyInvokable]
	public string Replace(string input, string replacement)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return Replace(input, replacement, -1, UseOptionR() ? input.Length : 0);
	}

	[global::__DynamicallyInvokable]
	public string Replace(string input, string replacement, int count)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return Replace(input, replacement, count, UseOptionR() ? input.Length : 0);
	}

	[global::__DynamicallyInvokable]
	public string Replace(string input, string replacement, int count, int startat)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (replacement == null)
		{
			throw new ArgumentNullException("replacement");
		}
		RegexReplacement regexReplacement = (RegexReplacement)replref.Get();
		if (regexReplacement == null || !regexReplacement.Pattern.Equals(replacement))
		{
			regexReplacement = RegexParser.ParseReplacement(replacement, caps, capsize, capnames, roptions);
			replref.Cache(regexReplacement);
		}
		return regexReplacement.Replace(this, input, count, startat);
	}

	[global::__DynamicallyInvokable]
	public static string Replace(string input, string pattern, MatchEvaluator evaluator)
	{
		return Replace(input, pattern, evaluator, RegexOptions.None, DefaultMatchTimeout);
	}

	[global::__DynamicallyInvokable]
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options)
	{
		return Replace(input, pattern, evaluator, options, DefaultMatchTimeout);
	}

	[global::__DynamicallyInvokable]
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout)
	{
		return new Regex(pattern, options, matchTimeout, useCache: true).Replace(input, evaluator);
	}

	[global::__DynamicallyInvokable]
	public string Replace(string input, MatchEvaluator evaluator)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return Replace(input, evaluator, -1, UseOptionR() ? input.Length : 0);
	}

	[global::__DynamicallyInvokable]
	public string Replace(string input, MatchEvaluator evaluator, int count)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return Replace(input, evaluator, count, UseOptionR() ? input.Length : 0);
	}

	[global::__DynamicallyInvokable]
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return RegexReplacement.Replace(evaluator, this, input, count, startat);
	}

	[global::__DynamicallyInvokable]
	public static string[] Split(string input, string pattern)
	{
		return Split(input, pattern, RegexOptions.None, DefaultMatchTimeout);
	}

	[global::__DynamicallyInvokable]
	public static string[] Split(string input, string pattern, RegexOptions options)
	{
		return Split(input, pattern, options, DefaultMatchTimeout);
	}

	[global::__DynamicallyInvokable]
	public static string[] Split(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
	{
		return new Regex(pattern, options, matchTimeout, useCache: true).Split(input);
	}

	[global::__DynamicallyInvokable]
	public string[] Split(string input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return Split(input, 0, UseOptionR() ? input.Length : 0);
	}

	[global::__DynamicallyInvokable]
	public string[] Split(string input, int count)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return RegexReplacement.Split(this, input, count, UseOptionR() ? input.Length : 0);
	}

	[global::__DynamicallyInvokable]
	public string[] Split(string input, int count, int startat)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return RegexReplacement.Split(this, input, count, startat);
	}

	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname)
	{
		CompileToAssemblyInternal(regexinfos, assemblyname, null, null);
	}

	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname, CustomAttributeBuilder[] attributes)
	{
		CompileToAssemblyInternal(regexinfos, assemblyname, attributes, null);
	}

	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname, CustomAttributeBuilder[] attributes, string resourceFile)
	{
		CompileToAssemblyInternal(regexinfos, assemblyname, attributes, resourceFile);
	}

	private static void CompileToAssemblyInternal(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname, CustomAttributeBuilder[] attributes, string resourceFile)
	{
		if (assemblyname == null)
		{
			throw new ArgumentNullException("assemblyname");
		}
		if (regexinfos == null)
		{
			throw new ArgumentNullException("regexinfos");
		}
		RegexCompiler.CompileToAssembly(regexinfos, assemblyname, attributes, resourceFile);
	}

	protected void InitializeReferences()
	{
		if (refsInitialized)
		{
			throw new NotSupportedException(SR.GetString("OnlyAllowedOnce"));
		}
		refsInitialized = true;
		runnerref = new ExclusiveReference();
		replref = new SharedReference();
	}

	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat)
	{
		RegexRunner regexRunner = null;
		if (startat < 0 || startat > input.Length)
		{
			throw new ArgumentOutOfRangeException("start", SR.GetString("BeginIndexNotNegative"));
		}
		if (length < 0 || length > input.Length)
		{
			throw new ArgumentOutOfRangeException("length", SR.GetString("LengthNotNegative"));
		}
		regexRunner = (RegexRunner)runnerref.Get();
		if (regexRunner == null)
		{
			regexRunner = ((factory == null) ? new RegexInterpreter(code, UseOptionInvariant() ? CultureInfo.InvariantCulture : CultureInfo.CurrentCulture) : factory.CreateInstance());
		}
		try
		{
			return regexRunner.Scan(this, input, beginning, beginning + length, startat, prevlen, quick, internalMatchTimeout);
		}
		finally
		{
			runnerref.Release(regexRunner);
		}
	}

	private static CachedCodeEntry LookupCachedAndUpdate(string key)
	{
		lock (livecode)
		{
			for (LinkedListNode<CachedCodeEntry> linkedListNode = livecode.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
			{
				if (linkedListNode.Value._key == key)
				{
					livecode.Remove(linkedListNode);
					livecode.AddFirst(linkedListNode);
					return linkedListNode.Value;
				}
			}
		}
		return null;
	}

	private CachedCodeEntry CacheCode(string key)
	{
		CachedCodeEntry cachedCodeEntry = null;
		lock (livecode)
		{
			for (LinkedListNode<CachedCodeEntry> linkedListNode = livecode.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
			{
				if (linkedListNode.Value._key == key)
				{
					livecode.Remove(linkedListNode);
					livecode.AddFirst(linkedListNode);
					return linkedListNode.Value;
				}
			}
			if (cacheSize != 0)
			{
				cachedCodeEntry = new CachedCodeEntry(key, capnames, capslist, code, caps, capsize, runnerref, replref);
				livecode.AddFirst(cachedCodeEntry);
				if (livecode.Count > cacheSize)
				{
					livecode.RemoveLast();
				}
			}
		}
		return cachedCodeEntry;
	}

	protected bool UseOptionC()
	{
		return (roptions & RegexOptions.Compiled) != 0;
	}

	protected bool UseOptionR()
	{
		return (roptions & RegexOptions.RightToLeft) != 0;
	}

	internal bool UseOptionInvariant()
	{
		return (roptions & RegexOptions.CultureInvariant) != 0;
	}
}
