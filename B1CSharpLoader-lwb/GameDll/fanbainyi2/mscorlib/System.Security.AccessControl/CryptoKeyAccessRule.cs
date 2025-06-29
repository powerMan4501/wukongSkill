using System.Security.Principal;

namespace System.Security.AccessControl;

public sealed class CryptoKeyAccessRule : AccessRule
{
	public CryptoKeyRights CryptoKeyRights => RightsFromAccessMask(base.AccessMask);

	public CryptoKeyAccessRule(IdentityReference identity, CryptoKeyRights cryptoKeyRights, AccessControlType type)
		: this(identity, AccessMaskFromRights(cryptoKeyRights, type), isInherited: false, InheritanceFlags.None, PropagationFlags.None, type)
	{
	}

	public CryptoKeyAccessRule(string identity, CryptoKeyRights cryptoKeyRights, AccessControlType type)
		: this(new NTAccount(identity), AccessMaskFromRights(cryptoKeyRights, type), isInherited: false, InheritanceFlags.None, PropagationFlags.None, type)
	{
	}

	private CryptoKeyAccessRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		: base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, type)
	{
	}

	private static int AccessMaskFromRights(CryptoKeyRights cryptoKeyRights, AccessControlType controlType)
	{
		switch (controlType)
		{
		case AccessControlType.Allow:
			cryptoKeyRights |= CryptoKeyRights.Synchronize;
			break;
		case AccessControlType.Deny:
			if (cryptoKeyRights != CryptoKeyRights.FullControl)
			{
				cryptoKeyRights &= ~CryptoKeyRights.Synchronize;
			}
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidEnumValue", controlType, "controlType"), "controlType");
		}
		return (int)cryptoKeyRights;
	}

	internal static CryptoKeyRights RightsFromAccessMask(int accessMask)
	{
		return (CryptoKeyRights)accessMask;
	}
}
