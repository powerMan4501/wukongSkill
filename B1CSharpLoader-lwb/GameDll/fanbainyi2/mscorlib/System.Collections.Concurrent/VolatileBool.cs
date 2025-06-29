namespace System.Collections.Concurrent;

internal struct VolatileBool
{
	public volatile bool m_value;

	public VolatileBool(bool value)
	{
		m_value = value;
	}
}
