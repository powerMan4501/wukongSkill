using System.Runtime.InteropServices;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
public class DaylightTime
{
	internal DateTime m_start;

	internal DateTime m_end;

	internal TimeSpan m_delta;

	public DateTime Start => m_start;

	public DateTime End => m_end;

	public TimeSpan Delta => m_delta;

	private DaylightTime()
	{
	}

	public DaylightTime(DateTime start, DateTime end, TimeSpan delta)
	{
		m_start = start;
		m_end = end;
		m_delta = delta;
	}
}
