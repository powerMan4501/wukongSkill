namespace System.Diagnostics.Tracing;

internal struct SessionMask
{
	private uint m_mask;

	internal const int SHIFT_SESSION_TO_KEYWORD = 44;

	internal const uint MASK = 15u;

	internal const uint MAX = 4u;

	public static SessionMask All => new SessionMask(15u);

	public bool this[int perEventSourceSessionId]
	{
		get
		{
			return (m_mask & (1 << perEventSourceSessionId)) != 0;
		}
		set
		{
			if (value)
			{
				m_mask |= (uint)(1 << perEventSourceSessionId);
			}
			else
			{
				m_mask &= (uint)(~(1 << perEventSourceSessionId));
			}
		}
	}

	public SessionMask(SessionMask m)
	{
		m_mask = m.m_mask;
	}

	public SessionMask(uint mask = 0u)
	{
		m_mask = mask & 0xF;
	}

	public bool IsEqualOrSupersetOf(SessionMask m)
	{
		return (m_mask | m.m_mask) == m_mask;
	}

	public static SessionMask FromId(int perEventSourceSessionId)
	{
		return new SessionMask((uint)(1 << perEventSourceSessionId));
	}

	public ulong ToEventKeywords()
	{
		return (ulong)m_mask << 44;
	}

	public static SessionMask FromEventKeywords(ulong m)
	{
		return new SessionMask((uint)(m >> 44));
	}

	public static SessionMask operator |(SessionMask m1, SessionMask m2)
	{
		return new SessionMask(m1.m_mask | m2.m_mask);
	}

	public static SessionMask operator &(SessionMask m1, SessionMask m2)
	{
		return new SessionMask(m1.m_mask & m2.m_mask);
	}

	public static SessionMask operator ^(SessionMask m1, SessionMask m2)
	{
		return new SessionMask(m1.m_mask ^ m2.m_mask);
	}

	public static SessionMask operator ~(SessionMask m)
	{
		return new SessionMask(0xF & ~m.m_mask);
	}

	public static explicit operator ulong(SessionMask m)
	{
		return m.m_mask;
	}

	public static explicit operator uint(SessionMask m)
	{
		return m.m_mask;
	}
}
