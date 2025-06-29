using System.Security.Permissions;

namespace System.Security;

[Serializable]
internal sealed class PermissionSetTriple
{
	private static volatile PermissionToken s_zoneToken;

	private static volatile PermissionToken s_urlToken;

	internal PermissionSet AssertSet;

	internal PermissionSet GrantSet;

	internal PermissionSet RefusedSet;

	private PermissionToken ZoneToken
	{
		[SecurityCritical]
		get
		{
			if (s_zoneToken == null)
			{
				s_zoneToken = PermissionToken.GetToken(typeof(ZoneIdentityPermission));
			}
			return s_zoneToken;
		}
	}

	private PermissionToken UrlToken
	{
		[SecurityCritical]
		get
		{
			if (s_urlToken == null)
			{
				s_urlToken = PermissionToken.GetToken(typeof(UrlIdentityPermission));
			}
			return s_urlToken;
		}
	}

	internal PermissionSetTriple()
	{
		Reset();
	}

	internal PermissionSetTriple(PermissionSetTriple triple)
	{
		AssertSet = triple.AssertSet;
		GrantSet = triple.GrantSet;
		RefusedSet = triple.RefusedSet;
	}

	internal void Reset()
	{
		AssertSet = null;
		GrantSet = null;
		RefusedSet = null;
	}

	internal bool IsEmpty()
	{
		if (AssertSet == null && GrantSet == null)
		{
			return RefusedSet == null;
		}
		return false;
	}

	[SecurityCritical]
	internal bool Update(PermissionSetTriple psTriple, out PermissionSetTriple retTriple)
	{
		retTriple = null;
		retTriple = UpdateAssert(psTriple.AssertSet);
		if (psTriple.AssertSet != null && psTriple.AssertSet.IsUnrestricted())
		{
			return true;
		}
		UpdateGrant(psTriple.GrantSet);
		UpdateRefused(psTriple.RefusedSet);
		return false;
	}

	[SecurityCritical]
	internal PermissionSetTriple UpdateAssert(PermissionSet in_a)
	{
		PermissionSetTriple permissionSetTriple = null;
		if (in_a != null)
		{
			if (in_a.IsSubsetOf(AssertSet))
			{
				return null;
			}
			PermissionSet permissionSet;
			if (GrantSet != null)
			{
				permissionSet = in_a.Intersect(GrantSet);
			}
			else
			{
				GrantSet = new PermissionSet(fUnrestricted: true);
				permissionSet = in_a.Copy();
			}
			bool bFailedToCompress = false;
			if (RefusedSet != null)
			{
				permissionSet = PermissionSet.RemoveRefusedPermissionSet(permissionSet, RefusedSet, out bFailedToCompress);
			}
			if (!bFailedToCompress)
			{
				bFailedToCompress = PermissionSet.IsIntersectingAssertedPermissions(permissionSet, AssertSet);
			}
			if (bFailedToCompress)
			{
				permissionSetTriple = new PermissionSetTriple(this);
				Reset();
				GrantSet = permissionSetTriple.GrantSet.Copy();
			}
			if (AssertSet == null)
			{
				AssertSet = permissionSet;
			}
			else
			{
				AssertSet.InplaceUnion(permissionSet);
			}
		}
		return permissionSetTriple;
	}

	[SecurityCritical]
	internal void UpdateGrant(PermissionSet in_g, out ZoneIdentityPermission z, out UrlIdentityPermission u)
	{
		z = null;
		u = null;
		if (in_g != null)
		{
			if (GrantSet == null)
			{
				GrantSet = in_g.Copy();
			}
			else
			{
				GrantSet.InplaceIntersect(in_g);
			}
			z = (ZoneIdentityPermission)in_g.GetPermission(ZoneToken);
			u = (UrlIdentityPermission)in_g.GetPermission(UrlToken);
		}
	}

	[SecurityCritical]
	internal void UpdateGrant(PermissionSet in_g)
	{
		if (in_g != null)
		{
			if (GrantSet == null)
			{
				GrantSet = in_g.Copy();
			}
			else
			{
				GrantSet.InplaceIntersect(in_g);
			}
		}
	}

	internal void UpdateRefused(PermissionSet in_r)
	{
		if (in_r != null)
		{
			if (RefusedSet == null)
			{
				RefusedSet = in_r.Copy();
			}
			else
			{
				RefusedSet.InplaceUnion(in_r);
			}
		}
	}

	[SecurityCritical]
	private static bool CheckAssert(PermissionSet pSet, CodeAccessPermission demand, PermissionToken permToken)
	{
		if (pSet != null)
		{
			pSet.CheckDecoded(demand, permToken);
			CodeAccessPermission asserted = (CodeAccessPermission)pSet.GetPermission(demand);
			try
			{
				if (pSet.IsUnrestricted() || demand.CheckAssert(asserted))
				{
					return false;
				}
			}
			catch (ArgumentException)
			{
			}
		}
		return true;
	}

	[SecurityCritical]
	private static bool CheckAssert(PermissionSet assertPset, PermissionSet demandSet, out PermissionSet newDemandSet)
	{
		newDemandSet = null;
		if (assertPset != null)
		{
			assertPset.CheckDecoded(demandSet);
			if (demandSet.CheckAssertion(assertPset))
			{
				return false;
			}
			PermissionSet.RemoveAssertedPermissionSet(demandSet, assertPset, out newDemandSet);
		}
		return true;
	}

	[SecurityCritical]
	internal bool CheckDemand(CodeAccessPermission demand, PermissionToken permToken, RuntimeMethodHandleInternal rmh)
	{
		if (!CheckAssert(AssertSet, demand, permToken))
		{
			return false;
		}
		CodeAccessSecurityEngine.CheckHelper(GrantSet, RefusedSet, demand, permToken, rmh, null, SecurityAction.Demand, throwException: true);
		return true;
	}

	[SecurityCritical]
	internal bool CheckSetDemand(PermissionSet demandSet, out PermissionSet alteredDemandset, RuntimeMethodHandleInternal rmh)
	{
		alteredDemandset = null;
		if (!CheckAssert(AssertSet, demandSet, out alteredDemandset))
		{
			return false;
		}
		if (alteredDemandset != null)
		{
			demandSet = alteredDemandset;
		}
		CodeAccessSecurityEngine.CheckSetHelper(GrantSet, RefusedSet, demandSet, rmh, null, SecurityAction.Demand, throwException: true);
		return true;
	}

	[SecurityCritical]
	internal bool CheckDemandNoThrow(CodeAccessPermission demand, PermissionToken permToken)
	{
		return CodeAccessSecurityEngine.CheckHelper(GrantSet, RefusedSet, demand, permToken, RuntimeMethodHandleInternal.EmptyHandle, null, SecurityAction.Demand, throwException: false);
	}

	[SecurityCritical]
	internal bool CheckSetDemandNoThrow(PermissionSet demandSet)
	{
		return CodeAccessSecurityEngine.CheckSetHelper(GrantSet, RefusedSet, demandSet, RuntimeMethodHandleInternal.EmptyHandle, null, SecurityAction.Demand, throwException: false);
	}

	[SecurityCritical]
	internal bool CheckFlags(ref int flags)
	{
		if (AssertSet != null)
		{
			int specialFlags = SecurityManager.GetSpecialFlags(AssertSet, null);
			if ((flags & specialFlags) != 0)
			{
				flags &= ~specialFlags;
			}
		}
		return (SecurityManager.GetSpecialFlags(GrantSet, RefusedSet) & flags) == flags;
	}
}
