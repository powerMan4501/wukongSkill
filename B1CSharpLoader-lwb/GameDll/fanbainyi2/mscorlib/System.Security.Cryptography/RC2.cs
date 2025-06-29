using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public abstract class RC2 : SymmetricAlgorithm
{
	protected int EffectiveKeySizeValue;

	private static KeySizes[] s_legalBlockSizes = new KeySizes[1]
	{
		new KeySizes(64, 64, 0)
	};

	private static KeySizes[] s_legalKeySizes = new KeySizes[1]
	{
		new KeySizes(40, 1024, 8)
	};

	public virtual int EffectiveKeySize
	{
		get
		{
			if (EffectiveKeySizeValue == 0)
			{
				return KeySizeValue;
			}
			return EffectiveKeySizeValue;
		}
		set
		{
			if (value > KeySizeValue)
			{
				throw new CryptographicException(Environment.GetResourceString("Cryptography_RC2_EKSKS"));
			}
			if (value == 0)
			{
				EffectiveKeySizeValue = value;
				return;
			}
			if (value < 40)
			{
				throw new CryptographicException(Environment.GetResourceString("Cryptography_RC2_EKS40"));
			}
			if (ValidKeySize(value))
			{
				EffectiveKeySizeValue = value;
				return;
			}
			throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidKeySize"));
		}
	}

	public override int KeySize
	{
		get
		{
			return KeySizeValue;
		}
		set
		{
			if (value < EffectiveKeySizeValue)
			{
				throw new CryptographicException(Environment.GetResourceString("Cryptography_RC2_EKSKS"));
			}
			base.KeySize = value;
		}
	}

	protected RC2()
	{
		KeySizeValue = 128;
		BlockSizeValue = 64;
		FeedbackSizeValue = BlockSizeValue;
		LegalBlockSizesValue = s_legalBlockSizes;
		LegalKeySizesValue = s_legalKeySizes;
	}

	public new static RC2 Create()
	{
		return Create("System.Security.Cryptography.RC2");
	}

	public new static RC2 Create(string AlgName)
	{
		return (RC2)CryptoConfig.CreateFromName(AlgName);
	}
}
