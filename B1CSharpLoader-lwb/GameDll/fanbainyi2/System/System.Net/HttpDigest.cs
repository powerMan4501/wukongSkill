using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;

namespace System.Net;

internal static class HttpDigest
{
	private enum Charset
	{
		ASCII,
		ANSI,
		UTF8
	}

	internal const string DA_algorithm = "algorithm";

	internal const string DA_cnonce = "cnonce";

	internal const string DA_domain = "domain";

	internal const string DA_nc = "nc";

	internal const string DA_nonce = "nonce";

	internal const string DA_opaque = "opaque";

	internal const string DA_qop = "qop";

	internal const string DA_realm = "realm";

	internal const string DA_response = "response";

	internal const string DA_stale = "stale";

	internal const string DA_uri = "uri";

	internal const string DA_username = "username";

	internal const string DA_charset = "charset";

	internal const string DA_cipher = "cipher";

	internal const string DA_hasheddirs = "hashed-dirs";

	internal const string DA_servicename = "service-name";

	internal const string DA_channelbinding = "channel-binding";

	internal const string SupportedQuality = "auth";

	internal const string ValidSeparator = ", \"'\t\r\n";

	internal const string HashedDirs = "service-name,channel-binding";

	internal const string Upgraded = "+Upgraded+";

	internal const string UpgradedV1 = "+Upgraded+v1";

	internal const string ZeroChannelBindingHash = "00000000000000000000000000000000";

	private const string suppressExtendedProtectionKey = "System\\CurrentControlSet\\Control\\Lsa";

	private const string suppressExtendedProtectionKeyPath = "HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Lsa";

	private const string suppressExtendedProtectionValueName = "SuppressExtendedProtection";

	private static volatile bool suppressExtendedProtection;

	private static readonly RNGCryptoServiceProvider RandomGenerator;

	private static int InitiatorTypeOffset;

	private static int InitiatorLengthOffset;

	private static int InitiatorOffsetOffset;

	private static int AcceptorTypeOffset;

	private static int AcceptorLengthOffset;

	private static int AcceptorOffsetOffset;

	private static int ApplicationDataLengthOffset;

	private static int ApplicationDataOffsetOffset;

	private static int SizeOfInt;

	private static int MinimumFormattedBindingLength;

	static HttpDigest()
	{
		RandomGenerator = new RNGCryptoServiceProvider();
		InitiatorTypeOffset = (int)Marshal.OffsetOf(typeof(SecChannelBindings), "dwInitiatorAddrType");
		InitiatorLengthOffset = (int)Marshal.OffsetOf(typeof(SecChannelBindings), "cbInitiatorLength");
		InitiatorOffsetOffset = (int)Marshal.OffsetOf(typeof(SecChannelBindings), "dwInitiatorOffset");
		AcceptorTypeOffset = (int)Marshal.OffsetOf(typeof(SecChannelBindings), "dwAcceptorAddrType");
		AcceptorLengthOffset = (int)Marshal.OffsetOf(typeof(SecChannelBindings), "cbAcceptorLength");
		AcceptorOffsetOffset = (int)Marshal.OffsetOf(typeof(SecChannelBindings), "dwAcceptorOffset");
		ApplicationDataLengthOffset = (int)Marshal.OffsetOf(typeof(SecChannelBindings), "cbApplicationDataLength");
		ApplicationDataOffsetOffset = (int)Marshal.OffsetOf(typeof(SecChannelBindings), "dwApplicationDataOffset");
		SizeOfInt = Marshal.SizeOf(typeof(int));
		MinimumFormattedBindingLength = 5 * SizeOfInt;
		ReadSuppressExtendedProtectionRegistryValue();
	}

	[RegistryPermission(SecurityAction.Assert, Read = "HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Lsa")]
	private static void ReadSuppressExtendedProtectionRegistryValue()
	{
		suppressExtendedProtection = !ComNetOS.IsWin7orLater;
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Lsa");
			try
			{
				if (registryKey.GetValueKind("SuppressExtendedProtection") == RegistryValueKind.DWord)
				{
					suppressExtendedProtection = (int)registryKey.GetValue("SuppressExtendedProtection") == 1;
				}
			}
			catch (UnauthorizedAccessException ex)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.Web, typeof(HttpDigest), "ReadSuppressExtendedProtectionRegistryValue", ex.Message);
				}
			}
			catch (IOException ex2)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.Web, typeof(HttpDigest), "ReadSuppressExtendedProtectionRegistryValue", ex2.Message);
				}
			}
		}
		catch (SecurityException ex3)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, typeof(HttpDigest), "ReadSuppressExtendedProtectionRegistryValue", ex3.Message);
			}
		}
		catch (ObjectDisposedException ex4)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, typeof(HttpDigest), "ReadSuppressExtendedProtectionRegistryValue", ex4.Message);
			}
		}
	}

	internal static HttpDigestChallenge Interpret(string challenge, int startingPoint, HttpWebRequest httpWebRequest)
	{
		HttpDigestChallenge httpDigestChallenge = new HttpDigestChallenge();
		httpDigestChallenge.SetFromRequest(httpWebRequest);
		startingPoint = ((startingPoint != -1) ? (startingPoint + DigestClient.SignatureSize) : 0);
		int num = startingPoint;
		while (true)
		{
			int offset = num;
			int num2 = AuthenticationManager.SplitNoQuotes(challenge, ref offset);
			if (offset < 0)
			{
				break;
			}
			string strA = challenge.Substring(num, offset - num);
			if (string.Compare(strA, "charset", StringComparison.OrdinalIgnoreCase) == 0)
			{
				string strA2 = ((num2 >= 0) ? unquote(challenge.Substring(offset + 1, num2 - offset - 1)) : unquote(challenge.Substring(offset + 1)));
				if (string.Compare(strA2, "utf-8", StringComparison.OrdinalIgnoreCase) == 0)
				{
					httpDigestChallenge.UTF8Charset = true;
					break;
				}
			}
			if (num2 < 0)
			{
				break;
			}
			num = ++num2;
		}
		num = startingPoint;
		while (true)
		{
			int offset = num;
			int num2 = AuthenticationManager.SplitNoQuotes(challenge, ref offset);
			if (offset < 0)
			{
				break;
			}
			string strA = challenge.Substring(num, offset - num);
			string strA2 = ((num2 >= 0) ? unquote(challenge.Substring(offset + 1, num2 - offset - 1)) : unquote(challenge.Substring(offset + 1)));
			if (httpDigestChallenge.UTF8Charset)
			{
				bool flag = true;
				for (int i = 0; i < strA2.Length; i++)
				{
					if (strA2[i] > '\u007f')
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					byte[] array = new byte[strA2.Length];
					for (int j = 0; j < strA2.Length; j++)
					{
						array[j] = (byte)strA2[j];
					}
					strA2 = Encoding.UTF8.GetString(array);
				}
			}
			bool flag2 = httpDigestChallenge.defineAttribute(strA, strA2);
			if (num2 < 0 || !flag2)
			{
				break;
			}
			num = ++num2;
		}
		if (httpDigestChallenge.Nonce == null)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, SR.GetString("net_log_digest_requires_nonce"));
			}
			return null;
		}
		return httpDigestChallenge;
	}

	private static string CharsetEncode(string rawString, Charset charset)
	{
		if (charset == Charset.UTF8 || charset == Charset.ANSI)
		{
			byte[] array = ((charset == Charset.UTF8) ? Encoding.UTF8.GetBytes(rawString) : Encoding.Default.GetBytes(rawString));
			char[] array2 = new char[array.Length];
			array.CopyTo(array2, 0);
			rawString = new string(array2);
		}
		return rawString;
	}

	private static Charset DetectCharset(string rawString)
	{
		Charset result = Charset.ASCII;
		for (int i = 0; i < rawString.Length; i++)
		{
			if (rawString[i] > '\u007f')
			{
				byte[] bytes = Encoding.Default.GetBytes(rawString);
				string strB = Encoding.Default.GetString(bytes);
				result = ((string.Compare(rawString, strB, StringComparison.Ordinal) == 0) ? Charset.ANSI : Charset.UTF8);
				break;
			}
		}
		return result;
	}

	internal static Authorization Authenticate(HttpDigestChallenge digestChallenge, NetworkCredential NC, string spn, ChannelBinding binding)
	{
		string text = NC.InternalGetUserName();
		if (ValidationHelper.IsBlankString(text))
		{
			return null;
		}
		string rawString = NC.InternalGetPassword();
		bool flag = IsUpgraded(digestChallenge.Nonce, binding);
		if (flag)
		{
			digestChallenge.ServiceName = spn;
			digestChallenge.ChannelBinding = hashChannelBinding(binding, digestChallenge.MD5provider);
		}
		if (digestChallenge.QopPresent)
		{
			if (digestChallenge.ClientNonce == null || digestChallenge.Stale)
			{
				if (flag)
				{
					digestChallenge.ClientNonce = createUpgradedNonce(digestChallenge);
				}
				else
				{
					digestChallenge.ClientNonce = createNonce(32);
				}
				digestChallenge.NonceCount = 1;
			}
			else
			{
				digestChallenge.NonceCount++;
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		Charset charset = DetectCharset(text);
		if (!digestChallenge.UTF8Charset && charset == Charset.UTF8)
		{
			return null;
		}
		Charset charset2 = DetectCharset(rawString);
		if (!digestChallenge.UTF8Charset && charset2 == Charset.UTF8)
		{
			return null;
		}
		if (digestChallenge.UTF8Charset)
		{
			stringBuilder.Append(pair("charset", "utf-8", quote: false));
			stringBuilder.Append(",");
			if (charset == Charset.UTF8)
			{
				text = CharsetEncode(text, Charset.UTF8);
				stringBuilder.Append(pair("username", text, quote: true));
				stringBuilder.Append(",");
			}
			else
			{
				stringBuilder.Append(pair("username", CharsetEncode(text, Charset.UTF8), quote: true));
				stringBuilder.Append(",");
				text = CharsetEncode(text, charset);
			}
		}
		else
		{
			text = CharsetEncode(text, charset);
			stringBuilder.Append(pair("username", text, quote: true));
			stringBuilder.Append(",");
		}
		rawString = CharsetEncode(rawString, charset2);
		stringBuilder.Append(pair("realm", digestChallenge.Realm, quote: true));
		stringBuilder.Append(",");
		stringBuilder.Append(pair("nonce", digestChallenge.Nonce, quote: true));
		stringBuilder.Append(",");
		stringBuilder.Append(pair("uri", digestChallenge.Uri, quote: true));
		if (digestChallenge.QopPresent)
		{
			if (digestChallenge.Algorithm != null)
			{
				stringBuilder.Append(",");
				stringBuilder.Append(pair("algorithm", digestChallenge.Algorithm, quote: true));
			}
			stringBuilder.Append(",");
			stringBuilder.Append(pair("cnonce", digestChallenge.ClientNonce, quote: true));
			stringBuilder.Append(",");
			stringBuilder.Append(pair("nc", digestChallenge.NonceCount.ToString("x8", NumberFormatInfo.InvariantInfo), quote: false));
			stringBuilder.Append(",");
			stringBuilder.Append(pair("qop", "auth", quote: true));
			if (flag)
			{
				stringBuilder.Append(",");
				stringBuilder.Append(pair("hashed-dirs", "service-name,channel-binding", quote: true));
				stringBuilder.Append(",");
				stringBuilder.Append(pair("service-name", digestChallenge.ServiceName, quote: true));
				stringBuilder.Append(",");
				stringBuilder.Append(pair("channel-binding", digestChallenge.ChannelBinding, quote: true));
			}
		}
		string text2 = responseValue(digestChallenge, text, rawString);
		if (text2 == null)
		{
			return null;
		}
		stringBuilder.Append(",");
		stringBuilder.Append(pair("response", text2, quote: true));
		if (digestChallenge.Opaque != null)
		{
			stringBuilder.Append(",");
			stringBuilder.Append(pair("opaque", digestChallenge.Opaque, quote: true));
		}
		return new Authorization("Digest " + stringBuilder.ToString(), finished: false);
	}

	private static bool IsUpgraded(string nonce, ChannelBinding binding)
	{
		if (binding == null && suppressExtendedProtection)
		{
			return false;
		}
		if (AuthenticationManager.SspSupportsExtendedProtection)
		{
			return nonce.StartsWith("+Upgraded+", StringComparison.Ordinal);
		}
		return false;
	}

	internal static string unquote(string quotedString)
	{
		return quotedString.Trim().Trim("\"".ToCharArray());
	}

	internal static string pair(string name, string value, bool quote)
	{
		if (quote)
		{
			return name + "=\"" + value + "\"";
		}
		return name + "=" + value;
	}

	private static string responseValue(HttpDigestChallenge challenge, string username, string password)
	{
		string text = computeSecret(challenge, username, password);
		if (text == null)
		{
			return null;
		}
		string text2 = challenge.Method + ":" + challenge.Uri;
		if (text2 == null)
		{
			return null;
		}
		string text3 = hashString(text, challenge.MD5provider);
		string text4 = hashString(text2, challenge.MD5provider);
		string text5 = challenge.Nonce + ":" + (challenge.QopPresent ? (challenge.NonceCount.ToString("x8", NumberFormatInfo.InvariantInfo) + ":" + challenge.ClientNonce + ":auth:" + text4) : text4);
		return hashString(text3 + ":" + text5, challenge.MD5provider);
	}

	private static string computeSecret(HttpDigestChallenge challenge, string username, string password)
	{
		if (challenge.Algorithm == null || string.Compare(challenge.Algorithm, "md5", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return username + ":" + challenge.Realm + ":" + password;
		}
		if (string.Compare(challenge.Algorithm, "md5-sess", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return hashString(username + ":" + challenge.Realm + ":" + password, challenge.MD5provider) + ":" + challenge.Nonce + ":" + challenge.ClientNonce;
		}
		if (Logging.On)
		{
			Logging.PrintError(Logging.Web, SR.GetString("net_log_digest_hash_algorithm_not_supported", challenge.Algorithm));
		}
		return null;
	}

	private static byte[] formatChannelBindingForHash(ChannelBinding binding)
	{
		int value = Marshal.ReadInt32(binding.DangerousGetHandle(), InitiatorTypeOffset);
		int num = Marshal.ReadInt32(binding.DangerousGetHandle(), InitiatorLengthOffset);
		int value2 = Marshal.ReadInt32(binding.DangerousGetHandle(), AcceptorTypeOffset);
		int num2 = Marshal.ReadInt32(binding.DangerousGetHandle(), AcceptorLengthOffset);
		int num3 = Marshal.ReadInt32(binding.DangerousGetHandle(), ApplicationDataLengthOffset);
		byte[] array = new byte[MinimumFormattedBindingLength + num + num2 + num3];
		BitConverter.GetBytes(value).CopyTo(array, 0);
		BitConverter.GetBytes(num).CopyTo(array, SizeOfInt);
		int num4 = 2 * SizeOfInt;
		if (num > 0)
		{
			int b = Marshal.ReadInt32(binding.DangerousGetHandle(), InitiatorOffsetOffset);
			Marshal.Copy(IntPtrHelper.Add(binding.DangerousGetHandle(), b), array, num4, num);
			num4 += num;
		}
		BitConverter.GetBytes(value2).CopyTo(array, num4);
		BitConverter.GetBytes(num2).CopyTo(array, num4 + SizeOfInt);
		num4 += 2 * SizeOfInt;
		if (num2 > 0)
		{
			int b2 = Marshal.ReadInt32(binding.DangerousGetHandle(), AcceptorOffsetOffset);
			Marshal.Copy(IntPtrHelper.Add(binding.DangerousGetHandle(), b2), array, num4, num2);
			num4 += num2;
		}
		BitConverter.GetBytes(num3).CopyTo(array, num4);
		num4 += SizeOfInt;
		if (num3 > 0)
		{
			int b3 = Marshal.ReadInt32(binding.DangerousGetHandle(), ApplicationDataOffsetOffset);
			Marshal.Copy(IntPtrHelper.Add(binding.DangerousGetHandle(), b3), array, num4, num3);
		}
		return array;
	}

	private static string hashChannelBinding(ChannelBinding binding, MD5CryptoServiceProvider MD5provider)
	{
		if (binding == null)
		{
			return "00000000000000000000000000000000";
		}
		byte[] buffer = formatChannelBindingForHash(binding);
		byte[] rawbytes = MD5provider.ComputeHash(buffer);
		return hexEncode(rawbytes);
	}

	private static string hashString(string myString, MD5CryptoServiceProvider MD5provider)
	{
		byte[] array = new byte[myString.Length];
		for (int i = 0; i < myString.Length; i++)
		{
			array[i] = (byte)myString[i];
		}
		byte[] rawbytes = MD5provider.ComputeHash(array);
		return hexEncode(rawbytes);
	}

	private static string hexEncode(byte[] rawbytes)
	{
		int num = rawbytes.Length;
		char[] array = new char[2 * num];
		int i = 0;
		int num2 = 0;
		for (; i < num; i++)
		{
			array[num2++] = Uri.HexLowerChars[rawbytes[i] >> 4];
			array[num2++] = Uri.HexLowerChars[rawbytes[i] & 0xF];
		}
		return new string(array);
	}

	private static string createNonce(int length)
	{
		byte[] array = new byte[length];
		char[] array2 = new char[length];
		RandomGenerator.GetBytes(array);
		for (int i = 0; i < length; i++)
		{
			array2[i] = Uri.HexLowerChars[array[i] & 0xF];
		}
		return new string(array2);
	}

	private static string createUpgradedNonce(HttpDigestChallenge digestChallenge)
	{
		string s = digestChallenge.ServiceName + ":" + digestChallenge.ChannelBinding;
		byte[] rawbytes = digestChallenge.MD5provider.ComputeHash(Encoding.ASCII.GetBytes(s));
		return "+Upgraded+v1" + hexEncode(rawbytes) + createNonce(32);
	}
}
