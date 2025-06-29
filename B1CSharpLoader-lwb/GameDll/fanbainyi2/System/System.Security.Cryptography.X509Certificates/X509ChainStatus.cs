namespace System.Security.Cryptography.X509Certificates;

public struct X509ChainStatus
{
	private X509ChainStatusFlags m_status;

	private string m_statusInformation;

	public X509ChainStatusFlags Status
	{
		get
		{
			return m_status;
		}
		set
		{
			m_status = value;
		}
	}

	public string StatusInformation
	{
		get
		{
			if (m_statusInformation == null)
			{
				return string.Empty;
			}
			return m_statusInformation;
		}
		set
		{
			m_statusInformation = value;
		}
	}
}
