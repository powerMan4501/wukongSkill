using System.Security.Cryptography.X509Certificates;

namespace System.Net;

internal class DefaultCertPolicy : ICertificatePolicy
{
	public bool CheckValidationResult(ServicePoint sp, X509Certificate cert, WebRequest request, int problem)
	{
		return problem == 0;
	}
}
