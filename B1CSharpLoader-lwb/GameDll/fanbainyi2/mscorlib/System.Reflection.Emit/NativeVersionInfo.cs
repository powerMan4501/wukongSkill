namespace System.Reflection.Emit;

internal class NativeVersionInfo
{
	internal string m_strDescription;

	internal string m_strCompany;

	internal string m_strTitle;

	internal string m_strCopyright;

	internal string m_strTrademark;

	internal string m_strProduct;

	internal string m_strProductVersion;

	internal string m_strFileVersion;

	internal int m_lcid;

	internal NativeVersionInfo()
	{
		m_strDescription = null;
		m_strCompany = null;
		m_strTitle = null;
		m_strCopyright = null;
		m_strTrademark = null;
		m_strProduct = null;
		m_strProductVersion = null;
		m_strFileVersion = null;
		m_lcid = -1;
	}
}
