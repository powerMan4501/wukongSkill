using System.Collections;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace System.Net;

internal class PolicyWrapper
{
	private const uint IgnoreUnmatchedCN = 4096u;

	private ICertificatePolicy fwdPolicy;

	private ServicePoint srvPoint;

	private WebRequest request;

	internal PolicyWrapper(ICertificatePolicy policy, ServicePoint sp, WebRequest wr)
	{
		fwdPolicy = policy;
		srvPoint = sp;
		request = wr;
	}

	public bool Accept(X509Certificate Certificate, int CertificateProblem)
	{
		return fwdPolicy.CheckValidationResult(srvPoint, Certificate, request, CertificateProblem);
	}

	internal static uint VerifyChainPolicy(SafeFreeCertChain chainContext, ref ChainPolicyParameter cpp)
	{
		ChainPolicyStatus ps = new ChainPolicyStatus
		{
			cbSize = ChainPolicyStatus.StructSize
		};
		int num = UnsafeNclNativeMethods.NativePKI.CertVerifyCertificateChainPolicy((IntPtr)4, chainContext, ref cpp, ref ps);
		return ps.dwError;
	}

	private static IgnoreCertProblem MapErrorCode(uint errorCode)
	{
		switch ((CertificateProblem)errorCode)
		{
		case CertificateProblem.CertCN_NO_MATCH:
		case CertificateProblem.CertINVALIDNAME:
			return IgnoreCertProblem.invalid_name;
		case CertificateProblem.CertPURPOSE:
		case CertificateProblem.CertINVALIDPOLICY:
			return IgnoreCertProblem.invalid_policy;
		case CertificateProblem.CertEXPIRED:
			return (IgnoreCertProblem)3;
		case CertificateProblem.CertVALIDITYPERIODNESTING:
			return IgnoreCertProblem.not_time_nested;
		case CertificateProblem.CertUNTRUSTEDROOT:
		case CertificateProblem.CertCHAINING:
		case CertificateProblem.CertUNTRUSTEDCA:
			return IgnoreCertProblem.allow_unknown_ca;
		case CertificateProblem.CryptNOREVOCATIONCHECK:
		case CertificateProblem.CryptREVOCATIONOFFLINE:
		case CertificateProblem.CertREVOKED:
		case CertificateProblem.CertREVOCATION_FAILURE:
			return IgnoreCertProblem.all_rev_unknown;
		case CertificateProblem.TrustBASICCONSTRAINTS:
		case CertificateProblem.CertROLE:
			return IgnoreCertProblem.invalid_basic_constraints;
		case CertificateProblem.CertWRONG_USAGE:
			return IgnoreCertProblem.wrong_usage;
		default:
			return (IgnoreCertProblem)0;
		}
	}

	private unsafe uint[] GetChainErrors(string hostName, X509Chain chain, ref bool fatalError)
	{
		fatalError = false;
		SafeFreeCertChain chainContext = new SafeFreeCertChain(chain.ChainContext);
		ArrayList arrayList = new ArrayList();
		uint num = 0u;
		ChainPolicyParameter cpp = new ChainPolicyParameter
		{
			cbSize = ChainPolicyParameter.StructSize,
			dwFlags = 0u
		};
		SSL_EXTRA_CERT_CHAIN_POLICY_PARA sSL_EXTRA_CERT_CHAIN_POLICY_PARA = new SSL_EXTRA_CERT_CHAIN_POLICY_PARA(amIServer: false);
		cpp.pvExtraPolicyPara = &sSL_EXTRA_CERT_CHAIN_POLICY_PARA;
		fixed (char* pwszServerName = hostName)
		{
			if (ServicePointManager.CheckCertificateName)
			{
				sSL_EXTRA_CERT_CHAIN_POLICY_PARA.pwszServerName = pwszServerName;
			}
			while (true)
			{
				num = VerifyChainPolicy(chainContext, ref cpp);
				uint num2 = (uint)MapErrorCode(num);
				arrayList.Add(num);
				if (num == 0)
				{
					break;
				}
				if (num2 == 0)
				{
					fatalError = true;
					break;
				}
				cpp.dwFlags |= num2;
				if (num == 2148204815u && ServicePointManager.CheckCertificateName)
				{
					sSL_EXTRA_CERT_CHAIN_POLICY_PARA.fdwChecks = 4096u;
				}
			}
		}
		return (uint[])arrayList.ToArray(typeof(uint));
	}

	internal bool CheckErrors(string hostName, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		if (sslPolicyErrors == SslPolicyErrors.None)
		{
			return Accept(certificate, 0);
		}
		if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateNotAvailable) != SslPolicyErrors.None)
		{
			return Accept(certificate, -2146762491);
		}
		if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateChainErrors) != SslPolicyErrors.None || (sslPolicyErrors & SslPolicyErrors.RemoteCertificateNameMismatch) != SslPolicyErrors.None)
		{
			bool fatalError = false;
			uint[] chainErrors = GetChainErrors(hostName, chain, ref fatalError);
			if (fatalError)
			{
				Accept(certificate, -2146893052);
				return false;
			}
			if (chainErrors.Length == 0)
			{
				return Accept(certificate, 0);
			}
			uint[] array = chainErrors;
			foreach (uint certificateProblem in array)
			{
				if (!Accept(certificate, (int)certificateProblem))
				{
					return false;
				}
			}
		}
		return true;
	}
}
