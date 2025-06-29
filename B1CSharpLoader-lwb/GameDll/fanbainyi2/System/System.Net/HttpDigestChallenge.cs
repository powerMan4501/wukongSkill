using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace System.Net;

internal class HttpDigestChallenge
{
	internal string HostName;

	internal string Realm;

	internal Uri ChallengedUri;

	internal string Uri;

	internal string Nonce;

	internal string Opaque;

	internal bool Stale;

	internal string Algorithm;

	internal string Method;

	internal string Domain;

	internal string QualityOfProtection;

	internal string ClientNonce;

	internal int NonceCount;

	internal string Charset;

	internal string ServiceName;

	internal string ChannelBinding;

	internal bool UTF8Charset;

	internal bool QopPresent;

	internal MD5CryptoServiceProvider MD5provider = new MD5CryptoServiceProvider();

	internal void SetFromRequest(HttpWebRequest httpWebRequest)
	{
		HostName = httpWebRequest.ChallengedUri.Host;
		Method = httpWebRequest.CurrentMethod.Name;
		if (httpWebRequest.CurrentMethod.ConnectRequest)
		{
			Uri = httpWebRequest.RequestUri.GetParts(UriComponents.HostAndPort, UriFormat.UriEscaped);
		}
		else
		{
			Uri = "/" + httpWebRequest.GetRemoteResourceUri().GetParts(UriComponents.Path, UriFormat.UriEscaped);
		}
		ChallengedUri = httpWebRequest.ChallengedUri;
	}

	internal HttpDigestChallenge CopyAndIncrementNonce()
	{
		HttpDigestChallenge httpDigestChallenge = null;
		lock (this)
		{
			httpDigestChallenge = MemberwiseClone() as HttpDigestChallenge;
			NonceCount++;
		}
		httpDigestChallenge.MD5provider = new MD5CryptoServiceProvider();
		return httpDigestChallenge;
	}

	public bool defineAttribute(string name, string value)
	{
		name = name.Trim().ToLower(CultureInfo.InvariantCulture);
		if (name.Equals("algorithm"))
		{
			Algorithm = value;
		}
		else if (name.Equals("cnonce"))
		{
			ClientNonce = value;
		}
		else if (name.Equals("nc"))
		{
			NonceCount = int.Parse(value, NumberFormatInfo.InvariantInfo);
		}
		else if (name.Equals("nonce"))
		{
			Nonce = value;
		}
		else if (name.Equals("opaque"))
		{
			Opaque = value;
		}
		else if (name.Equals("qop"))
		{
			QualityOfProtection = value;
			QopPresent = QualityOfProtection != null && QualityOfProtection.Length > 0;
		}
		else if (name.Equals("realm"))
		{
			Realm = value;
		}
		else if (name.Equals("domain"))
		{
			Domain = value;
		}
		else if (!name.Equals("response"))
		{
			if (name.Equals("stale"))
			{
				Stale = value.ToLower(CultureInfo.InvariantCulture).Equals("true");
			}
			else if (name.Equals("uri"))
			{
				Uri = value;
			}
			else if (name.Equals("charset"))
			{
				Charset = value;
			}
			else if (!name.Equals("cipher") && !name.Equals("username"))
			{
				return false;
			}
		}
		return true;
	}

	internal string ToBlob()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(HttpDigest.pair("realm", Realm, quote: true));
		if (Algorithm != null)
		{
			stringBuilder.Append(",");
			stringBuilder.Append(HttpDigest.pair("algorithm", Algorithm, quote: true));
		}
		if (Charset != null)
		{
			stringBuilder.Append(",");
			stringBuilder.Append(HttpDigest.pair("charset", Charset, quote: false));
		}
		if (Nonce != null)
		{
			stringBuilder.Append(",");
			stringBuilder.Append(HttpDigest.pair("nonce", Nonce, quote: true));
		}
		if (Uri != null)
		{
			stringBuilder.Append(",");
			stringBuilder.Append(HttpDigest.pair("uri", Uri, quote: true));
		}
		if (ClientNonce != null)
		{
			stringBuilder.Append(",");
			stringBuilder.Append(HttpDigest.pair("cnonce", ClientNonce, quote: true));
		}
		if (NonceCount > 0)
		{
			stringBuilder.Append(",");
			stringBuilder.Append(HttpDigest.pair("nc", NonceCount.ToString("x8", NumberFormatInfo.InvariantInfo), quote: true));
		}
		if (QualityOfProtection != null)
		{
			stringBuilder.Append(",");
			stringBuilder.Append(HttpDigest.pair("qop", QualityOfProtection, quote: true));
		}
		if (Opaque != null)
		{
			stringBuilder.Append(",");
			stringBuilder.Append(HttpDigest.pair("opaque", Opaque, quote: true));
		}
		if (Domain != null)
		{
			stringBuilder.Append(",");
			stringBuilder.Append(HttpDigest.pair("domain", Domain, quote: true));
		}
		if (Stale)
		{
			stringBuilder.Append(",");
			stringBuilder.Append(HttpDigest.pair("stale", "true", quote: true));
		}
		return stringBuilder.ToString();
	}
}
