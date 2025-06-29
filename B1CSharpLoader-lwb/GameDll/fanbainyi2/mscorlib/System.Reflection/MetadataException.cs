using System.Globalization;

namespace System.Reflection;

internal class MetadataException : Exception
{
	private int m_hr;

	internal MetadataException(int hr)
	{
		m_hr = hr;
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "MetadataException HResult = {0:x}.", m_hr);
	}
}
