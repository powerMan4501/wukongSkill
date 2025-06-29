using System.Collections;

namespace System.Net.Security;

internal static class SslSessionsCache
{
	private struct SslCredKey
	{
		private static readonly byte[] s_EmptyArray = new byte[0];

		private byte[] _CertThumbPrint;

		private SchProtocols _AllowedProtocols;

		private EncryptionPolicy _EncryptionPolicy;

		private int _HashCode;

		internal SslCredKey(byte[] thumbPrint, SchProtocols allowedProtocols, EncryptionPolicy encryptionPolicy)
		{
			_CertThumbPrint = ((thumbPrint == null) ? s_EmptyArray : thumbPrint);
			_HashCode = 0;
			if (thumbPrint != null)
			{
				_HashCode ^= _CertThumbPrint[0];
				if (1 < _CertThumbPrint.Length)
				{
					_HashCode ^= _CertThumbPrint[1] << 8;
				}
				if (2 < _CertThumbPrint.Length)
				{
					_HashCode ^= _CertThumbPrint[2] << 16;
				}
				if (3 < _CertThumbPrint.Length)
				{
					_HashCode ^= _CertThumbPrint[3] << 24;
				}
			}
			_HashCode ^= (int)allowedProtocols;
			_HashCode ^= (int)encryptionPolicy;
			_AllowedProtocols = allowedProtocols;
			_EncryptionPolicy = encryptionPolicy;
		}

		public override int GetHashCode()
		{
			return _HashCode;
		}

		public static bool operator ==(SslCredKey sslCredKey1, SslCredKey sslCredKey2)
		{
			if ((object)sslCredKey1 == (object)sslCredKey2)
			{
				return true;
			}
			if ((object)sslCredKey1 == null || (object)sslCredKey2 == null)
			{
				return false;
			}
			return sslCredKey1.Equals(sslCredKey2);
		}

		public static bool operator !=(SslCredKey sslCredKey1, SslCredKey sslCredKey2)
		{
			if ((object)sslCredKey1 == (object)sslCredKey2)
			{
				return false;
			}
			if ((object)sslCredKey1 == null || (object)sslCredKey2 == null)
			{
				return true;
			}
			return !sslCredKey1.Equals(sslCredKey2);
		}

		public override bool Equals(object y)
		{
			SslCredKey sslCredKey = (SslCredKey)y;
			if (_CertThumbPrint.Length != sslCredKey._CertThumbPrint.Length)
			{
				return false;
			}
			if (_HashCode != sslCredKey._HashCode)
			{
				return false;
			}
			if (_EncryptionPolicy != sslCredKey._EncryptionPolicy)
			{
				return false;
			}
			if (_AllowedProtocols != sslCredKey._AllowedProtocols)
			{
				return false;
			}
			for (int i = 0; i < _CertThumbPrint.Length; i++)
			{
				if (_CertThumbPrint[i] != sslCredKey._CertThumbPrint[i])
				{
					return false;
				}
			}
			return true;
		}
	}

	private const int c_CheckExpiredModulo = 32;

	private static Hashtable s_CachedCreds = new Hashtable(32);

	internal static SafeFreeCredentials TryCachedCredential(byte[] thumbPrint, SchProtocols allowedProtocols, EncryptionPolicy encryptionPolicy)
	{
		if (s_CachedCreds.Count == 0)
		{
			return null;
		}
		object key = new SslCredKey(thumbPrint, allowedProtocols, encryptionPolicy);
		if (!(s_CachedCreds[key] is SafeCredentialReference { IsClosed: false } safeCredentialReference) || safeCredentialReference._Target.IsInvalid)
		{
			return null;
		}
		return safeCredentialReference._Target;
	}

	internal static void CacheCredential(SafeFreeCredentials creds, byte[] thumbPrint, SchProtocols allowedProtocols, EncryptionPolicy encryptionPolicy)
	{
		if (creds.IsInvalid)
		{
			return;
		}
		object key = new SslCredKey(thumbPrint, allowedProtocols, encryptionPolicy);
		if (s_CachedCreds[key] is SafeCredentialReference { IsClosed: false } safeCredentialReference && !safeCredentialReference._Target.IsInvalid)
		{
			return;
		}
		lock (s_CachedCreds)
		{
			if (s_CachedCreds[key] is SafeCredentialReference { IsClosed: false })
			{
				return;
			}
			SafeCredentialReference safeCredentialReference3 = SafeCredentialReference.CreateReference(creds);
			if (safeCredentialReference3 == null)
			{
				return;
			}
			s_CachedCreds[key] = safeCredentialReference3;
			if (s_CachedCreds.Count % 32 != 0)
			{
				return;
			}
			DictionaryEntry[] array = new DictionaryEntry[s_CachedCreds.Count];
			s_CachedCreds.CopyTo(array, 0);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Value is SafeCredentialReference safeCredentialReference4)
				{
					creds = safeCredentialReference4._Target;
					safeCredentialReference4.Close();
					if (!creds.IsClosed && !creds.IsInvalid && (safeCredentialReference3 = SafeCredentialReference.CreateReference(creds)) != null)
					{
						s_CachedCreds[array[i].Key] = safeCredentialReference3;
					}
					else
					{
						s_CachedCreds.Remove(array[i].Key);
					}
				}
			}
		}
	}
}
