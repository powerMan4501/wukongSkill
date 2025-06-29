using System.Security;

namespace System.Runtime.InteropServices;

[SecurityCritical]
internal class ComEventsInfo
{
	private ComEventsSink _sinks;

	private object _rcw;

	private ComEventsInfo(object rcw)
	{
		_rcw = rcw;
	}

	[SecuritySafeCritical]
	~ComEventsInfo()
	{
		_sinks = ComEventsSink.RemoveAll(_sinks);
	}

	[SecurityCritical]
	internal static ComEventsInfo Find(object rcw)
	{
		return (ComEventsInfo)Marshal.GetComObjectData(rcw, typeof(ComEventsInfo));
	}

	[SecurityCritical]
	internal static ComEventsInfo FromObject(object rcw)
	{
		ComEventsInfo comEventsInfo = Find(rcw);
		if (comEventsInfo == null)
		{
			comEventsInfo = new ComEventsInfo(rcw);
			Marshal.SetComObjectData(rcw, typeof(ComEventsInfo), comEventsInfo);
		}
		return comEventsInfo;
	}

	internal ComEventsSink FindSink(ref Guid iid)
	{
		return ComEventsSink.Find(_sinks, ref iid);
	}

	internal ComEventsSink AddSink(ref Guid iid)
	{
		ComEventsSink sink = new ComEventsSink(_rcw, iid);
		_sinks = ComEventsSink.Add(_sinks, sink);
		return _sinks;
	}

	[SecurityCritical]
	internal ComEventsSink RemoveSink(ComEventsSink sink)
	{
		_sinks = ComEventsSink.Remove(_sinks, sink);
		return _sinks;
	}
}
