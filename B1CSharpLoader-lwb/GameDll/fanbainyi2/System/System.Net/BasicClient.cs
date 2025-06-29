using System.Globalization;
using System.Text;

namespace System.Net;

internal class BasicClient : IAuthenticationModule
{
	internal const string AuthType = "Basic";

	internal static string Signature = "Basic".ToLower(CultureInfo.InvariantCulture);

	internal static int SignatureSize = Signature.Length;

	public bool CanPreAuthenticate => true;

	public string AuthenticationType => "Basic";

	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
	{
		if (credentials == null || credentials is SystemNetworkCredential)
		{
			return null;
		}
		if (!(webRequest is HttpWebRequest httpWebRequest) || httpWebRequest.ChallengedUri == null)
		{
			return null;
		}
		int num = AuthenticationManager.FindSubstringNotInQuotes(challenge, Signature);
		if (num < 0)
		{
			return null;
		}
		return Lookup(httpWebRequest, credentials);
	}

	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
	{
		if (credentials == null || credentials is SystemNetworkCredential)
		{
			return null;
		}
		if (!(webRequest is HttpWebRequest httpWebRequest))
		{
			return null;
		}
		return Lookup(httpWebRequest, credentials);
	}

	private Authorization Lookup(HttpWebRequest httpWebRequest, ICredentials credentials)
	{
		NetworkCredential credential = credentials.GetCredential(httpWebRequest.ChallengedUri, Signature);
		if (credential == null)
		{
			return null;
		}
		ICredentialPolicy credentialPolicy = AuthenticationManager.CredentialPolicy;
		if (credentialPolicy != null && !credentialPolicy.ShouldSendCredential(httpWebRequest.ChallengedUri, httpWebRequest, credential, this))
		{
			return null;
		}
		string text = credential.InternalGetUserName();
		string text2 = credential.InternalGetDomain();
		if (ValidationHelper.IsBlankString(text))
		{
			return null;
		}
		string rawString = ((!ValidationHelper.IsBlankString(text2)) ? (text2 + "\\") : "") + text + ":" + credential.InternalGetPassword();
		byte[] inArray = EncodingRightGetBytes(rawString);
		string token = "Basic " + Convert.ToBase64String(inArray);
		return new Authorization(token, finished: true);
	}

	internal static byte[] EncodingRightGetBytes(string rawString)
	{
		byte[] bytes = Encoding.Default.GetBytes(rawString);
		string strB = Encoding.Default.GetString(bytes);
		if (string.Compare(rawString, strB, StringComparison.Ordinal) != 0)
		{
			throw ExceptionHelper.MethodNotSupportedException;
		}
		return bytes;
	}
}
