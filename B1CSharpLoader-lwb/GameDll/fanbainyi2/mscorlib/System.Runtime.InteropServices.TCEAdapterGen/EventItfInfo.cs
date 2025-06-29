using System.Reflection;

namespace System.Runtime.InteropServices.TCEAdapterGen;

internal class EventItfInfo
{
	private string m_strEventItfName;

	private string m_strSrcItfName;

	private string m_strEventProviderName;

	private RuntimeAssembly m_asmImport;

	private RuntimeAssembly m_asmSrcItf;

	public EventItfInfo(string strEventItfName, string strSrcItfName, string strEventProviderName, RuntimeAssembly asmImport, RuntimeAssembly asmSrcItf)
	{
		m_strEventItfName = strEventItfName;
		m_strSrcItfName = strSrcItfName;
		m_strEventProviderName = strEventProviderName;
		m_asmImport = asmImport;
		m_asmSrcItf = asmSrcItf;
	}

	public Type GetEventItfType()
	{
		Type type = m_asmImport.GetType(m_strEventItfName, throwOnError: true, ignoreCase: false);
		if (type != null && !type.IsVisible)
		{
			type = null;
		}
		return type;
	}

	public Type GetSrcItfType()
	{
		Type type = m_asmSrcItf.GetType(m_strSrcItfName, throwOnError: true, ignoreCase: false);
		if (type != null && !type.IsVisible)
		{
			type = null;
		}
		return type;
	}

	public string GetEventProviderName()
	{
		return m_strEventProviderName;
	}
}
