using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Text.RegularExpressions;

[Serializable]
[global::__DynamicallyInvokable]
public class Group : Capture
{
	internal static Group _emptygroup = new Group(string.Empty, new int[0], 0, string.Empty);

	internal int[] _caps;

	internal int _capcount;

	internal CaptureCollection _capcoll;

	[OptionalField]
	internal string _name;

	[global::__DynamicallyInvokable]
	public bool Success
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _capcount != 0;
		}
	}

	public string Name => _name;

	[global::__DynamicallyInvokable]
	public CaptureCollection Captures
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_capcoll == null)
			{
				_capcoll = new CaptureCollection(this);
			}
			return _capcoll;
		}
	}

	internal Group(string text, int[] caps, int capcount, string name)
		: base(text, (capcount != 0) ? caps[(capcount - 1) * 2] : 0, (capcount != 0) ? caps[capcount * 2 - 1] : 0)
	{
		_caps = caps;
		_capcount = capcount;
		_name = name;
	}

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	public static Group Synchronized(Group inner)
	{
		if (inner == null)
		{
			throw new ArgumentNullException("inner");
		}
		CaptureCollection captures = inner.Captures;
		if (inner._capcount > 0)
		{
			Capture capture = captures[0];
		}
		return inner;
	}
}
