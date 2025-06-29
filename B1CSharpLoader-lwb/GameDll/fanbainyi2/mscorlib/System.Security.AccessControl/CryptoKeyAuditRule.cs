using System.Security.Principal;

namespace System.Security.AccessControl;

public sealed class CryptoKeyAuditRule : AuditRule
{
	public CryptoKeyRights CryptoKeyRights => RightsFromAccessMask(base.AccessMask);

	public CryptoKeyAuditRule(IdentityReference identity, CryptoKeyRights cryptoKeyRights, AuditFlags flags)
		: this(identity, AccessMaskFromRights(cryptoKeyRights), isInherited: false, InheritanceFlags.None, PropagationFlags.None, flags)
	{
	}

	public CryptoKeyAuditRule(string identity, CryptoKeyRights cryptoKeyRights, AuditFlags flags)
		: this(new NTAccount(identity), AccessMaskFromRights(cryptoKeyRights), isInherited: false, InheritanceFlags.None, PropagationFlags.None, flags)
	{
	}

	private CryptoKeyAuditRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		: base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, flags)
	{
	}

	private static int AccessMaskFromRights(CryptoKeyRights cryptoKeyRights)
	{
		return (int)cryptoKeyRights;
	}

	internal static CryptoKeyRights RightsFromAccessMask(int accessMask)
	{
		return (CryptoKeyRights)accessMask;
	}
}
