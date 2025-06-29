using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace System.Net;

internal class CertPolicyValidationCallback
{
	private class CallbackContext
	{
		internal readonly PolicyWrapper policyWrapper;

		internal readonly string hostName;

		internal readonly X509Certificate certificate;

		internal readonly X509Chain chain;

		internal readonly SslPolicyErrors sslPolicyErrors;

		internal bool result;

		internal CallbackContext(PolicyWrapper policyWrapper, string hostName, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			this.policyWrapper = policyWrapper;
			this.hostName = hostName;
			this.certificate = certificate;
			this.chain = chain;
			this.sslPolicyErrors = sslPolicyErrors;
		}
	}

	private readonly ICertificatePolicy m_CertificatePolicy;

	private readonly ExecutionContext m_Context;

	internal ICertificatePolicy CertificatePolicy => m_CertificatePolicy;

	internal bool UsesDefault => m_Context == null;

	internal CertPolicyValidationCallback()
	{
		m_CertificatePolicy = new DefaultCertPolicy();
		m_Context = null;
	}

	internal CertPolicyValidationCallback(ICertificatePolicy certificatePolicy)
	{
		m_CertificatePolicy = certificatePolicy;
		m_Context = ExecutionContext.Capture();
	}

	internal void Callback(object state)
	{
		CallbackContext callbackContext = (CallbackContext)state;
		callbackContext.result = callbackContext.policyWrapper.CheckErrors(callbackContext.hostName, callbackContext.certificate, callbackContext.chain, callbackContext.sslPolicyErrors);
	}

	internal bool Invoke(string hostName, ServicePoint servicePoint, X509Certificate certificate, WebRequest request, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		PolicyWrapper policyWrapper = new PolicyWrapper(m_CertificatePolicy, servicePoint, request);
		if (m_Context == null)
		{
			return policyWrapper.CheckErrors(hostName, certificate, chain, sslPolicyErrors);
		}
		ExecutionContext executionContext = m_Context.CreateCopy();
		CallbackContext callbackContext = new CallbackContext(policyWrapper, hostName, certificate, chain, sslPolicyErrors);
		ExecutionContext.Run(executionContext, Callback, callbackContext);
		return callbackContext.result;
	}
}
