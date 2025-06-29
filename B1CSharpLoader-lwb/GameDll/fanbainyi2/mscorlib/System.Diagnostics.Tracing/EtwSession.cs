using System.Collections.Generic;

namespace System.Diagnostics.Tracing;

internal class EtwSession
{
	public readonly int m_etwSessionId;

	public ActivityFilter m_activityFilter;

	private static List<WeakReference<EtwSession>> s_etwSessions = new List<WeakReference<EtwSession>>();

	private const int s_thrSessionCount = 16;

	public static EtwSession GetEtwSession(int etwSessionId, bool bCreateIfNeeded = false)
	{
		if (etwSessionId < 0)
		{
			return null;
		}
		EtwSession target;
		foreach (WeakReference<EtwSession> s_etwSession in s_etwSessions)
		{
			if (s_etwSession.TryGetTarget(out target) && target.m_etwSessionId == etwSessionId)
			{
				return target;
			}
		}
		if (!bCreateIfNeeded)
		{
			return null;
		}
		if (s_etwSessions == null)
		{
			s_etwSessions = new List<WeakReference<EtwSession>>();
		}
		target = new EtwSession(etwSessionId);
		s_etwSessions.Add(new WeakReference<EtwSession>(target));
		if (s_etwSessions.Count > 16)
		{
			TrimGlobalList();
		}
		return target;
	}

	public static void RemoveEtwSession(EtwSession etwSession)
	{
		if (s_etwSessions != null && etwSession != null)
		{
			s_etwSessions.RemoveAll((WeakReference<EtwSession> wrEtwSession) => wrEtwSession.TryGetTarget(out var target) && target.m_etwSessionId == etwSession.m_etwSessionId);
			if (s_etwSessions.Count > 16)
			{
				TrimGlobalList();
			}
		}
	}

	private static void TrimGlobalList()
	{
		if (s_etwSessions != null)
		{
			s_etwSessions.RemoveAll((WeakReference<EtwSession> wrEtwSession) => !wrEtwSession.TryGetTarget(out var _));
		}
	}

	private EtwSession(int etwSessionId)
	{
		m_etwSessionId = etwSessionId;
	}
}
