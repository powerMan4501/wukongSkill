using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class Rfc2898DeriveBytes : DeriveBytes
{
	private byte[] m_buffer;

	private byte[] m_salt;

	private HMAC m_hmac;

	private byte[] m_password;

	private CspParameters m_cspParams = new CspParameters();

	private uint m_iterations;

	private uint m_block;

	private int m_startIndex;

	private int m_endIndex;

	private int m_blockSize;

	[SecurityCritical]
	private SafeProvHandle _safeProvHandle;

	public int IterationCount
	{
		get
		{
			return (int)m_iterations;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
			}
			m_iterations = (uint)value;
			Initialize();
		}
	}

	public byte[] Salt
	{
		get
		{
			return (byte[])m_salt.Clone();
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length < 8)
			{
				throw new ArgumentException(Environment.GetResourceString("Cryptography_PasswordDerivedBytes_FewBytesSalt"));
			}
			m_salt = (byte[])value.Clone();
			Initialize();
		}
	}

	private SafeProvHandle ProvHandle
	{
		[SecurityCritical]
		get
		{
			if (_safeProvHandle == null)
			{
				lock (this)
				{
					if (_safeProvHandle == null)
					{
						SafeProvHandle safeProvHandle = Utils.AcquireProvHandle(m_cspParams);
						Thread.MemoryBarrier();
						_safeProvHandle = safeProvHandle;
					}
				}
			}
			return _safeProvHandle;
		}
	}

	public Rfc2898DeriveBytes(string password, int saltSize)
		: this(password, saltSize, 1000)
	{
	}

	public Rfc2898DeriveBytes(string password, int saltSize, int iterations)
		: this(password, saltSize, iterations, HashAlgorithmName.SHA1)
	{
	}

	[SecuritySafeCritical]
	public Rfc2898DeriveBytes(string password, int saltSize, int iterations, HashAlgorithmName hashAlgorithm)
	{
		if (saltSize < 0)
		{
			throw new ArgumentOutOfRangeException("saltSize", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw new ArgumentException(Environment.GetResourceString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
		}
		HMAC hMAC = HMAC.Create("HMAC" + hashAlgorithm.Name);
		if (hMAC == null)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_UnknownHashAlgorithm", hashAlgorithm.Name));
		}
		byte[] array = new byte[saltSize];
		Utils.StaticRandomNumberGenerator.GetBytes(array);
		Salt = array;
		IterationCount = iterations;
		m_password = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false).GetBytes(password);
		hMAC.Key = m_password;
		m_hmac = hMAC;
		m_blockSize = hMAC.HashSize >> 3;
		Initialize();
	}

	public Rfc2898DeriveBytes(string password, byte[] salt)
		: this(password, salt, 1000)
	{
	}

	public Rfc2898DeriveBytes(string password, byte[] salt, int iterations)
		: this(password, salt, iterations, HashAlgorithmName.SHA1)
	{
	}

	public Rfc2898DeriveBytes(string password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
		: this(new UTF8Encoding(encoderShouldEmitUTF8Identifier: false).GetBytes(password), salt, iterations, hashAlgorithm)
	{
	}

	public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations)
		: this(password, salt, iterations, HashAlgorithmName.SHA1)
	{
	}

	[SecuritySafeCritical]
	public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
	{
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw new ArgumentException(Environment.GetResourceString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
		}
		HMAC hMAC = HMAC.Create("HMAC" + hashAlgorithm.Name);
		if (hMAC == null)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_UnknownHashAlgorithm", hashAlgorithm.Name));
		}
		Salt = salt;
		IterationCount = iterations;
		m_password = password;
		hMAC.Key = password;
		m_hmac = hMAC;
		m_blockSize = hMAC.HashSize >> 3;
		Initialize();
	}

	public override byte[] GetBytes(int cb)
	{
		if (cb <= 0)
		{
			throw new ArgumentOutOfRangeException("cb", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		byte[] array = new byte[cb];
		int i = 0;
		int num = m_endIndex - m_startIndex;
		if (num > 0)
		{
			if (cb < num)
			{
				Buffer.InternalBlockCopy(m_buffer, m_startIndex, array, 0, cb);
				m_startIndex += cb;
				return array;
			}
			Buffer.InternalBlockCopy(m_buffer, m_startIndex, array, 0, num);
			m_startIndex = (m_endIndex = 0);
			i += num;
		}
		for (; i < cb; i += m_blockSize)
		{
			byte[] src = Func();
			int num2 = cb - i;
			if (num2 > m_blockSize)
			{
				Buffer.InternalBlockCopy(src, 0, array, i, m_blockSize);
				continue;
			}
			Buffer.InternalBlockCopy(src, 0, array, i, num2);
			i += num2;
			Buffer.InternalBlockCopy(src, num2, m_buffer, m_startIndex, m_blockSize - num2);
			m_endIndex += m_blockSize - num2;
			return array;
		}
		return array;
	}

	public override void Reset()
	{
		Initialize();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing)
		{
			if (m_hmac != null)
			{
				((IDisposable)m_hmac).Dispose();
			}
			if (m_buffer != null)
			{
				Array.Clear(m_buffer, 0, m_buffer.Length);
			}
			if (m_salt != null)
			{
				Array.Clear(m_salt, 0, m_salt.Length);
			}
		}
	}

	private void Initialize()
	{
		if (m_buffer != null)
		{
			Array.Clear(m_buffer, 0, m_buffer.Length);
		}
		m_buffer = new byte[m_blockSize];
		m_block = 1u;
		m_startIndex = (m_endIndex = 0);
	}

	private byte[] Func()
	{
		byte[] array = Utils.Int(m_block);
		m_hmac.TransformBlock(m_salt, 0, m_salt.Length, null, 0);
		m_hmac.TransformBlock(array, 0, array.Length, null, 0);
		m_hmac.TransformFinalBlock(EmptyArray<byte>.Value, 0, 0);
		byte[] hashValue = m_hmac.HashValue;
		m_hmac.Initialize();
		byte[] array2 = hashValue;
		for (int i = 2; i <= m_iterations; i++)
		{
			m_hmac.TransformBlock(hashValue, 0, hashValue.Length, null, 0);
			m_hmac.TransformFinalBlock(EmptyArray<byte>.Value, 0, 0);
			hashValue = m_hmac.HashValue;
			for (int j = 0; j < m_blockSize; j++)
			{
				array2[j] ^= hashValue[j];
			}
			m_hmac.Initialize();
		}
		m_block++;
		return array2;
	}

	[SecuritySafeCritical]
	public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
	{
		if (keySize < 0)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidKeySize"));
		}
		int num = X509Utils.NameOrOidToAlgId(alghashname, OidGroup.HashAlgorithm);
		if (num == 0)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_PasswordDerivedBytes_InvalidAlgorithm"));
		}
		int num2 = X509Utils.NameOrOidToAlgId(algname, OidGroup.AllGroups);
		if (num2 == 0)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_PasswordDerivedBytes_InvalidAlgorithm"));
		}
		if (rgbIV == null)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_PasswordDerivedBytes_InvalidIV"));
		}
		byte[] o = null;
		DeriveKey(ProvHandle, num2, num, m_password, m_password.Length, keySize << 16, rgbIV, rgbIV.Length, JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void DeriveKey(SafeProvHandle hProv, int algid, int algidHash, byte[] password, int cbPassword, int dwFlags, byte[] IV, int cbIV, ObjectHandleOnStack retKey);
}
