using System.Security.Permissions;
using Internal.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class AesCng : Aes, ICngSymmetricAlgorithm
{
	private CngSymmetricAlgorithmCore _core;

	public override byte[] Key
	{
		get
		{
			return _core.GetKeyIfExportable();
		}
		set
		{
			_core.SetKey(value);
		}
	}

	public override int KeySize
	{
		get
		{
			return base.KeySize;
		}
		set
		{
			_core.SetKeySize(value, this);
		}
	}

	byte[] ICngSymmetricAlgorithm.BaseKey
	{
		get
		{
			return base.Key;
		}
		set
		{
			base.Key = value;
		}
	}

	int ICngSymmetricAlgorithm.BaseKeySize
	{
		get
		{
			return base.KeySize;
		}
		set
		{
			base.KeySize = value;
		}
	}

	public AesCng()
	{
		_core = new CngSymmetricAlgorithmCore(this);
	}

	public AesCng(string keyName)
		: this(keyName, CngProvider.MicrosoftSoftwareKeyStorageProvider)
	{
	}

	public AesCng(string keyName, CngProvider provider)
		: this(keyName, provider, CngKeyOpenOptions.None)
	{
	}

	public AesCng(string keyName, CngProvider provider, CngKeyOpenOptions openOptions)
	{
		_core = new CngSymmetricAlgorithmCore(this, keyName, provider, openOptions);
	}

	public override ICryptoTransform CreateDecryptor()
	{
		return _core.CreateDecryptor();
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return _core.CreateDecryptor(rgbKey, rgbIV);
	}

	public override ICryptoTransform CreateEncryptor()
	{
		return _core.CreateEncryptor();
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return _core.CreateEncryptor(rgbKey, rgbIV);
	}

	public override void GenerateKey()
	{
		_core.GenerateKey();
	}

	public override void GenerateIV()
	{
		_core.GenerateIV();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	bool ICngSymmetricAlgorithm.IsWeakKey(byte[] key)
	{
		return false;
	}

	[SecurityCritical]
	SafeBCryptAlgorithmHandle ICngSymmetricAlgorithm.GetEphemeralModeHandle()
	{
		return BCryptNative.AesBCryptModes.GetSharedHandle(Mode);
	}

	string ICngSymmetricAlgorithm.GetNCryptAlgorithmIdentifier()
	{
		return "AES";
	}
}
