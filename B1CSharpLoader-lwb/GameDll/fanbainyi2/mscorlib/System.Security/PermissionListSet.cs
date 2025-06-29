using System.Collections;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;

namespace System.Security;

[Serializable]
internal sealed class PermissionListSet
{
	private PermissionSetTriple m_firstPermSetTriple;

	private ArrayList m_permSetTriples;

	private ArrayList m_zoneList;

	private ArrayList m_originList;

	internal PermissionListSet()
	{
	}

	private void EnsureTriplesListCreated()
	{
		if (m_permSetTriples == null)
		{
			m_permSetTriples = new ArrayList();
			if (m_firstPermSetTriple != null)
			{
				m_permSetTriples.Add(m_firstPermSetTriple);
				m_firstPermSetTriple = null;
			}
		}
	}

	[SecurityCritical]
	internal void UpdateDomainPLS(PermissionListSet adPLS)
	{
		if (adPLS != null && adPLS.m_firstPermSetTriple != null)
		{
			UpdateDomainPLS(adPLS.m_firstPermSetTriple.GrantSet, adPLS.m_firstPermSetTriple.RefusedSet);
		}
	}

	[SecurityCritical]
	internal void UpdateDomainPLS(PermissionSet grantSet, PermissionSet deniedSet)
	{
		if (m_firstPermSetTriple == null)
		{
			m_firstPermSetTriple = new PermissionSetTriple();
		}
		m_firstPermSetTriple.UpdateGrant(grantSet);
		m_firstPermSetTriple.UpdateRefused(deniedSet);
	}

	private void Terminate(PermissionSetTriple currentTriple)
	{
		UpdateTripleListAndCreateNewTriple(currentTriple, null);
	}

	[SecurityCritical]
	private void Terminate(PermissionSetTriple currentTriple, PermissionListSet pls)
	{
		UpdateZoneAndOrigin(pls);
		UpdatePermissions(currentTriple, pls);
		UpdateTripleListAndCreateNewTriple(currentTriple, null);
	}

	[SecurityCritical]
	private bool Update(PermissionSetTriple currentTriple, PermissionListSet pls)
	{
		UpdateZoneAndOrigin(pls);
		return UpdatePermissions(currentTriple, pls);
	}

	[SecurityCritical]
	private bool Update(PermissionSetTriple currentTriple, FrameSecurityDescriptor fsd)
	{
		if (fsd is FrameSecurityDescriptorWithResolver fsdWithResolver)
		{
			return Update2(currentTriple, fsdWithResolver);
		}
		bool flag = Update2(currentTriple, fsd, fDeclarative: false);
		if (!flag)
		{
			flag = Update2(currentTriple, fsd, fDeclarative: true);
		}
		return flag;
	}

	[SecurityCritical]
	private bool Update2(PermissionSetTriple currentTriple, FrameSecurityDescriptorWithResolver fsdWithResolver)
	{
		DynamicResolver resolver = fsdWithResolver.Resolver;
		CompressedStack securityContext = resolver.GetSecurityContext();
		securityContext.CompleteConstruction(null);
		return Update(currentTriple, securityContext.PLS);
	}

	[SecurityCritical]
	private bool Update2(PermissionSetTriple currentTriple, FrameSecurityDescriptor fsd, bool fDeclarative)
	{
		PermissionSet denials = fsd.GetDenials(fDeclarative);
		if (denials != null)
		{
			currentTriple.UpdateRefused(denials);
		}
		PermissionSet permitOnly = fsd.GetPermitOnly(fDeclarative);
		if (permitOnly != null)
		{
			currentTriple.UpdateGrant(permitOnly);
		}
		if (fsd.GetAssertAllPossible())
		{
			if (currentTriple.GrantSet == null)
			{
				currentTriple.GrantSet = PermissionSet.s_fullTrust;
			}
			UpdateTripleListAndCreateNewTriple(currentTriple, m_permSetTriples);
			currentTriple.GrantSet = PermissionSet.s_fullTrust;
			currentTriple.UpdateAssert(fsd.GetAssertions(fDeclarative));
			return true;
		}
		PermissionSet assertions = fsd.GetAssertions(fDeclarative);
		if (assertions != null)
		{
			if (assertions.IsUnrestricted())
			{
				if (currentTriple.GrantSet == null)
				{
					currentTriple.GrantSet = PermissionSet.s_fullTrust;
				}
				UpdateTripleListAndCreateNewTriple(currentTriple, m_permSetTriples);
				currentTriple.GrantSet = PermissionSet.s_fullTrust;
				currentTriple.UpdateAssert(assertions);
				return true;
			}
			PermissionSetTriple permissionSetTriple = currentTriple.UpdateAssert(assertions);
			if (permissionSetTriple != null)
			{
				EnsureTriplesListCreated();
				m_permSetTriples.Add(permissionSetTriple);
			}
		}
		return false;
	}

	[SecurityCritical]
	private void Update(PermissionSetTriple currentTriple, PermissionSet in_g, PermissionSet in_r)
	{
		currentTriple.UpdateGrant(in_g, out var z, out var u);
		currentTriple.UpdateRefused(in_r);
		AppendZoneOrigin(z, u);
	}

	[SecurityCritical]
	private void Update(PermissionSet in_g)
	{
		if (m_firstPermSetTriple == null)
		{
			m_firstPermSetTriple = new PermissionSetTriple();
		}
		Update(m_firstPermSetTriple, in_g, null);
	}

	private void UpdateZoneAndOrigin(PermissionListSet pls)
	{
		if (pls != null)
		{
			if (m_zoneList == null && pls.m_zoneList != null && pls.m_zoneList.Count > 0)
			{
				m_zoneList = new ArrayList();
			}
			UpdateArrayList(m_zoneList, pls.m_zoneList);
			if (m_originList == null && pls.m_originList != null && pls.m_originList.Count > 0)
			{
				m_originList = new ArrayList();
			}
			UpdateArrayList(m_originList, pls.m_originList);
		}
	}

	[SecurityCritical]
	private bool UpdatePermissions(PermissionSetTriple currentTriple, PermissionListSet pls)
	{
		if (pls != null)
		{
			if (pls.m_permSetTriples != null)
			{
				UpdateTripleListAndCreateNewTriple(currentTriple, pls.m_permSetTriples);
			}
			else
			{
				PermissionSetTriple firstPermSetTriple = pls.m_firstPermSetTriple;
				if (currentTriple.Update(firstPermSetTriple, out var retTriple))
				{
					return true;
				}
				if (retTriple != null)
				{
					EnsureTriplesListCreated();
					m_permSetTriples.Add(retTriple);
				}
			}
		}
		else
		{
			UpdateTripleListAndCreateNewTriple(currentTriple, null);
		}
		return false;
	}

	private void UpdateTripleListAndCreateNewTriple(PermissionSetTriple currentTriple, ArrayList tripleList)
	{
		if (!currentTriple.IsEmpty())
		{
			if (m_firstPermSetTriple == null && m_permSetTriples == null)
			{
				m_firstPermSetTriple = new PermissionSetTriple(currentTriple);
			}
			else
			{
				EnsureTriplesListCreated();
				m_permSetTriples.Add(new PermissionSetTriple(currentTriple));
			}
			currentTriple.Reset();
		}
		if (tripleList != null)
		{
			EnsureTriplesListCreated();
			m_permSetTriples.AddRange(tripleList);
		}
	}

	private static void UpdateArrayList(ArrayList current, ArrayList newList)
	{
		if (newList == null)
		{
			return;
		}
		for (int i = 0; i < newList.Count; i++)
		{
			if (!current.Contains(newList[i]))
			{
				current.Add(newList[i]);
			}
		}
	}

	private void AppendZoneOrigin(ZoneIdentityPermission z, UrlIdentityPermission u)
	{
		if (z != null)
		{
			if (m_zoneList == null)
			{
				m_zoneList = new ArrayList();
			}
			z.AppendZones(m_zoneList);
		}
		if (u != null)
		{
			if (m_originList == null)
			{
				m_originList = new ArrayList();
			}
			u.AppendOrigin(m_originList);
		}
	}

	[SecurityCritical]
	[ComVisible(true)]
	internal static PermissionListSet CreateCompressedState(CompressedStack cs, CompressedStack innerCS)
	{
		bool flag = false;
		if (cs.CompressedStackHandle == null)
		{
			return null;
		}
		PermissionListSet permissionListSet = new PermissionListSet();
		PermissionSetTriple currentTriple = new PermissionSetTriple();
		int dCSCount = CompressedStack.GetDCSCount(cs.CompressedStackHandle);
		int num = dCSCount - 1;
		while (num >= 0 && !flag)
		{
			DomainCompressedStack domainCompressedStack = CompressedStack.GetDomainCompressedStack(cs.CompressedStackHandle, num);
			if (domainCompressedStack != null)
			{
				if (domainCompressedStack.PLS == null)
				{
					throw new SecurityException(string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("Security_Generic")));
				}
				permissionListSet.UpdateZoneAndOrigin(domainCompressedStack.PLS);
				permissionListSet.Update(currentTriple, domainCompressedStack.PLS);
				flag = domainCompressedStack.ConstructionHalted;
			}
			num--;
		}
		if (!flag)
		{
			PermissionListSet pls = null;
			if (innerCS != null)
			{
				innerCS.CompleteConstruction(null);
				pls = innerCS.PLS;
			}
			permissionListSet.Terminate(currentTriple, pls);
		}
		else
		{
			permissionListSet.Terminate(currentTriple);
		}
		return permissionListSet;
	}

	[SecurityCritical]
	internal static PermissionListSet CreateCompressedState(IntPtr unmanagedDCS, out bool bHaltConstruction)
	{
		PermissionListSet permissionListSet = new PermissionListSet();
		PermissionSetTriple currentTriple = new PermissionSetTriple();
		int descCount = DomainCompressedStack.GetDescCount(unmanagedDCS);
		bHaltConstruction = false;
		PermissionSet granted;
		PermissionSet refused;
		for (int i = 0; i < descCount; i++)
		{
			if (bHaltConstruction)
			{
				break;
			}
			if (DomainCompressedStack.GetDescriptorInfo(unmanagedDCS, i, out granted, out refused, out var _, out var fsd))
			{
				bHaltConstruction = permissionListSet.Update(currentTriple, fsd);
			}
			else
			{
				permissionListSet.Update(currentTriple, granted, refused);
			}
		}
		if (!bHaltConstruction && !DomainCompressedStack.IgnoreDomain(unmanagedDCS))
		{
			DomainCompressedStack.GetDomainPermissionSets(unmanagedDCS, out granted, out refused);
			permissionListSet.Update(currentTriple, granted, refused);
		}
		permissionListSet.Terminate(currentTriple);
		return permissionListSet;
	}

	[SecurityCritical]
	internal static PermissionListSet CreateCompressedState_HG()
	{
		PermissionListSet permissionListSet = new PermissionListSet();
		CompressedStack.GetHomogeneousPLS(permissionListSet);
		return permissionListSet;
	}

	[SecurityCritical]
	internal bool CheckDemandNoThrow(CodeAccessPermission demand)
	{
		PermissionToken permToken = null;
		if (demand != null)
		{
			permToken = PermissionToken.GetToken(demand);
		}
		return m_firstPermSetTriple.CheckDemandNoThrow(demand, permToken);
	}

	[SecurityCritical]
	internal bool CheckSetDemandNoThrow(PermissionSet pSet)
	{
		return m_firstPermSetTriple.CheckSetDemandNoThrow(pSet);
	}

	[SecurityCritical]
	internal bool CheckDemand(CodeAccessPermission demand, PermissionToken permToken, RuntimeMethodHandleInternal rmh)
	{
		bool flag = true;
		if (m_permSetTriples != null)
		{
			for (int i = 0; i < m_permSetTriples.Count; i++)
			{
				if (!flag)
				{
					break;
				}
				PermissionSetTriple permissionSetTriple = (PermissionSetTriple)m_permSetTriples[i];
				flag = permissionSetTriple.CheckDemand(demand, permToken, rmh);
			}
		}
		else if (m_firstPermSetTriple != null)
		{
			flag = m_firstPermSetTriple.CheckDemand(demand, permToken, rmh);
		}
		return flag;
	}

	[SecurityCritical]
	internal bool CheckSetDemand(PermissionSet pset, RuntimeMethodHandleInternal rmh)
	{
		CheckSetDemandWithModification(pset, out var _, rmh);
		return false;
	}

	[SecurityCritical]
	internal bool CheckSetDemandWithModification(PermissionSet pset, out PermissionSet alteredDemandSet, RuntimeMethodHandleInternal rmh)
	{
		bool flag = true;
		PermissionSet demandSet = pset;
		alteredDemandSet = null;
		if (m_permSetTriples != null)
		{
			for (int i = 0; i < m_permSetTriples.Count; i++)
			{
				if (!flag)
				{
					break;
				}
				PermissionSetTriple permissionSetTriple = (PermissionSetTriple)m_permSetTriples[i];
				flag = permissionSetTriple.CheckSetDemand(demandSet, out alteredDemandSet, rmh);
				if (alteredDemandSet != null)
				{
					demandSet = alteredDemandSet;
				}
			}
		}
		else if (m_firstPermSetTriple != null)
		{
			flag = m_firstPermSetTriple.CheckSetDemand(demandSet, out alteredDemandSet, rmh);
		}
		return flag;
	}

	[SecurityCritical]
	private bool CheckFlags(int flags)
	{
		bool flag = true;
		if (m_permSetTriples != null)
		{
			for (int i = 0; i < m_permSetTriples.Count && flag; i++)
			{
				if (flags == 0)
				{
					break;
				}
				flag &= ((PermissionSetTriple)m_permSetTriples[i]).CheckFlags(ref flags);
			}
		}
		else if (m_firstPermSetTriple != null)
		{
			flag = m_firstPermSetTriple.CheckFlags(ref flags);
		}
		return flag;
	}

	[SecurityCritical]
	internal void DemandFlagsOrGrantSet(int flags, PermissionSet grantSet)
	{
		if (!CheckFlags(flags))
		{
			CheckSetDemand(grantSet, RuntimeMethodHandleInternal.EmptyHandle);
		}
	}

	internal void GetZoneAndOrigin(ArrayList zoneList, ArrayList originList, PermissionToken zoneToken, PermissionToken originToken)
	{
		if (m_zoneList != null)
		{
			zoneList.AddRange(m_zoneList);
		}
		if (m_originList != null)
		{
			originList.AddRange(m_originList);
		}
	}
}
