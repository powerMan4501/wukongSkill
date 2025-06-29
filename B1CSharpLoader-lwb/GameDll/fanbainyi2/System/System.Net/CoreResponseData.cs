using System.IO;

namespace System.Net;

internal class CoreResponseData
{
	public HttpStatusCode m_StatusCode;

	public string m_StatusDescription;

	public bool m_IsVersionHttp11;

	public long m_ContentLength;

	public WebHeaderCollection m_ResponseHeaders;

	public Stream m_ConnectStream;

	internal CoreResponseData Clone()
	{
		CoreResponseData coreResponseData = new CoreResponseData();
		coreResponseData.m_StatusCode = m_StatusCode;
		coreResponseData.m_StatusDescription = m_StatusDescription;
		coreResponseData.m_IsVersionHttp11 = m_IsVersionHttp11;
		coreResponseData.m_ContentLength = m_ContentLength;
		coreResponseData.m_ResponseHeaders = m_ResponseHeaders;
		coreResponseData.m_ConnectStream = m_ConnectStream;
		return coreResponseData;
	}
}
