using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates;

public class X509ChainElement
{
	private X509Certificate2 m_certificate;

	private X509ChainStatus[] m_chainStatus;

	private string m_description;

	public X509Certificate2 Certificate => m_certificate;

	public X509ChainStatus[] ChainElementStatus => m_chainStatus;

	public string Information => m_description;

	private X509ChainElement()
	{
	}

	internal unsafe X509ChainElement(IntPtr pChainElement)
	{
		CAPIBase.CERT_CHAIN_ELEMENT cERT_CHAIN_ELEMENT = new CAPIBase.CERT_CHAIN_ELEMENT(Marshal.SizeOf(typeof(CAPIBase.CERT_CHAIN_ELEMENT)));
		uint num = (uint)Marshal.ReadInt32(pChainElement);
		if (num > Marshal.SizeOf((object)cERT_CHAIN_ELEMENT))
		{
			num = (uint)Marshal.SizeOf((object)cERT_CHAIN_ELEMENT);
		}
		X509Utils.memcpy(pChainElement, new IntPtr(&cERT_CHAIN_ELEMENT), num);
		m_certificate = new X509Certificate2(cERT_CHAIN_ELEMENT.pCertContext);
		if (cERT_CHAIN_ELEMENT.pwszExtendedErrorInfo == IntPtr.Zero)
		{
			m_description = string.Empty;
		}
		else
		{
			m_description = Marshal.PtrToStringUni(cERT_CHAIN_ELEMENT.pwszExtendedErrorInfo);
		}
		if (cERT_CHAIN_ELEMENT.dwErrorStatus == 0)
		{
			m_chainStatus = new X509ChainStatus[0];
		}
		else
		{
			m_chainStatus = X509Chain.GetChainStatusInformation(cERT_CHAIN_ELEMENT.dwErrorStatus);
		}
	}
}
