using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Util;
using System.Threading;

namespace System.Security;

[ComVisible(true)]
public static class SecurityManager
{
	private static volatile SecurityPermission executionSecurityPermission = null;

	private static PolicyManager polmgr = new PolicyManager();

	private static int[][] s_BuiltInPermissionIndexMap = new int[6][]
	{
		new int[2] { 0, 10 },
		new int[2] { 1, 11 },
		new int[2] { 2, 12 },
		new int[2] { 4, 13 },
		new int[2] { 6, 14 },
		new int[2] { 7, 9 }
	};

	private static CodeAccessPermission[] s_UnrestrictedSpecialPermissionMap = new CodeAccessPermission[6]
	{
		new EnvironmentPermission(PermissionState.Unrestricted),
		new FileDialogPermission(PermissionState.Unrestricted),
		new FileIOPermission(PermissionState.Unrestricted),
		new ReflectionPermission(PermissionState.Unrestricted),
		new SecurityPermission(PermissionState.Unrestricted),
		new UIPermission(PermissionState.Unrestricted)
	};

	internal static PolicyManager PolicyManager => polmgr;

	[Obsolete("Because execution permission checks can no longer be turned off, the CheckExecutionRights property no longer has any effect.")]
	public static bool CheckExecutionRights
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[Obsolete("Because security can no longer be turned off, the SecurityEnabled property no longer has any effect.")]
	public static bool SecurityEnabled
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("IsGranted is obsolete and will be removed in a future release of the .NET Framework.  Please use the PermissionSet property of either AppDomain or Assembly instead.")]
	public static bool IsGranted(IPermission perm)
	{
		if (perm == null)
		{
			return true;
		}
		PermissionSet o = null;
		PermissionSet o2 = null;
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		GetGrantedPermissions(JitHelpers.GetObjectHandleOnStack(ref o), JitHelpers.GetObjectHandleOnStack(ref o2), JitHelpers.GetStackCrawlMarkHandle(ref stackMark));
		if (o.Contains(perm))
		{
			if (o2 != null)
			{
				return !o2.Contains(perm);
			}
			return true;
		}
		return false;
	}

	public static PermissionSet GetStandardSandbox(Evidence evidence)
	{
		if (evidence == null)
		{
			throw new ArgumentNullException("evidence");
		}
		Zone hostEvidence = evidence.GetHostEvidence<Zone>();
		if (hostEvidence == null)
		{
			return new PermissionSet(PermissionState.None);
		}
		if (hostEvidence.SecurityZone == SecurityZone.MyComputer)
		{
			return new PermissionSet(PermissionState.Unrestricted);
		}
		if (hostEvidence.SecurityZone == SecurityZone.Intranet)
		{
			PermissionSet localIntranet = BuiltInPermissionSets.LocalIntranet;
			PolicyStatement policyStatement = new NetCodeGroup(new AllMembershipCondition()).Resolve(evidence);
			PolicyStatement policyStatement2 = new FileCodeGroup(new AllMembershipCondition(), FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery).Resolve(evidence);
			if (policyStatement != null)
			{
				localIntranet.InplaceUnion(policyStatement.PermissionSet);
			}
			if (policyStatement2 != null)
			{
				localIntranet.InplaceUnion(policyStatement2.PermissionSet);
			}
			return localIntranet;
		}
		if (hostEvidence.SecurityZone == SecurityZone.Internet || hostEvidence.SecurityZone == SecurityZone.Trusted)
		{
			PermissionSet internet = BuiltInPermissionSets.Internet;
			PolicyStatement policyStatement3 = new NetCodeGroup(new AllMembershipCondition()).Resolve(evidence);
			if (policyStatement3 != null)
			{
				internet.InplaceUnion(policyStatement3.PermissionSet);
			}
			return internet;
		}
		return new PermissionSet(PermissionState.None);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	public static void GetZoneAndOrigin(out ArrayList zone, out ArrayList origin)
	{
		StackCrawlMark mark = StackCrawlMark.LookForMyCaller;
		CodeAccessSecurityEngine.GetZoneAndOrigin(ref mark, out zone, out origin);
	}

	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPolicy)]
	public static PolicyLevel LoadPolicyLevelFromFile(string path, PolicyLevelType type)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (!AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyExplicit"));
		}
		if (!File.InternalExists(path))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_PolicyFileDoesNotExist"));
		}
		string fullPath = Path.GetFullPath(path);
		FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
		fileIOPermission.AddPathList(FileIOPermissionAccess.Read, fullPath);
		fileIOPermission.AddPathList(FileIOPermissionAccess.Write, fullPath);
		fileIOPermission.Demand();
		using FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
		using StreamReader streamReader = new StreamReader(stream);
		return LoadPolicyLevelFromStringHelper(streamReader.ReadToEnd(), path, type);
	}

	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPolicy)]
	public static PolicyLevel LoadPolicyLevelFromString(string str, PolicyLevelType type)
	{
		return LoadPolicyLevelFromStringHelper(str, null, type);
	}

	private static PolicyLevel LoadPolicyLevelFromStringHelper(string str, string path, PolicyLevelType type)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		PolicyLevel policyLevel = new PolicyLevel(type, path);
		Parser parser = new Parser(str);
		SecurityElement topElement = parser.GetTopElement();
		if (topElement == null)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Policy_BadXml"), "configuration"));
		}
		SecurityElement securityElement = topElement.SearchForChildByTag("mscorlib");
		if (securityElement == null)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Policy_BadXml"), "mscorlib"));
		}
		SecurityElement securityElement2 = securityElement.SearchForChildByTag("security");
		if (securityElement2 == null)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Policy_BadXml"), "security"));
		}
		SecurityElement securityElement3 = securityElement2.SearchForChildByTag("policy");
		if (securityElement3 == null)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Policy_BadXml"), "policy"));
		}
		SecurityElement securityElement4 = securityElement3.SearchForChildByTag("PolicyLevel");
		if (securityElement4 != null)
		{
			policyLevel.FromXml(securityElement4);
			return policyLevel;
		}
		throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Policy_BadXml"), "PolicyLevel"));
	}

	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPolicy)]
	public static void SavePolicyLevel(PolicyLevel level)
	{
		if (!AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyExplicit"));
		}
		PolicyManager.EncodeLevel(level);
	}

	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static PermissionSet ResolvePolicy(Evidence evidence, PermissionSet reqdPset, PermissionSet optPset, PermissionSet denyPset, out PermissionSet denied)
	{
		if (!AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyExplicit"));
		}
		return ResolvePolicy(evidence, reqdPset, optPset, denyPset, out denied, checkExecutionPermission: true);
	}

	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static PermissionSet ResolvePolicy(Evidence evidence)
	{
		if (!AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyExplicit"));
		}
		if (evidence == null)
		{
			evidence = new Evidence();
		}
		return polmgr.Resolve(evidence);
	}

	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static PermissionSet ResolvePolicy(Evidence[] evidences)
	{
		if (!AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyExplicit"));
		}
		if (evidences == null || evidences.Length == 0)
		{
			evidences = new Evidence[1];
		}
		PermissionSet permissionSet = ResolvePolicy(evidences[0]);
		if (permissionSet == null)
		{
			return null;
		}
		for (int i = 1; i < evidences.Length; i++)
		{
			permissionSet = permissionSet.Intersect(ResolvePolicy(evidences[i]));
			if (permissionSet == null || permissionSet.IsEmpty())
			{
				return permissionSet;
			}
		}
		return permissionSet;
	}

	[SecurityCritical]
	public static bool CurrentThreadRequiresSecurityContextCapture()
	{
		return !CodeAccessSecurityEngine.QuickCheckForAllDemands();
	}

	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static PermissionSet ResolveSystemPolicy(Evidence evidence)
	{
		if (!AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyExplicit"));
		}
		if (PolicyManager.IsGacAssembly(evidence))
		{
			return new PermissionSet(PermissionState.Unrestricted);
		}
		return polmgr.CodeGroupResolve(evidence, systemPolicy: true);
	}

	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static IEnumerator ResolvePolicyGroups(Evidence evidence)
	{
		if (!AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyExplicit"));
		}
		return polmgr.ResolveCodeGroups(evidence);
	}

	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static IEnumerator PolicyHierarchy()
	{
		if (!AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyExplicit"));
		}
		return polmgr.PolicyHierarchy();
	}

	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPolicy)]
	public static void SavePolicy()
	{
		if (!AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyExplicit"));
		}
		polmgr.Save();
	}

	[SecurityCritical]
	private static PermissionSet ResolveCasPolicy(Evidence evidence, PermissionSet reqdPset, PermissionSet optPset, PermissionSet denyPset, out PermissionSet denied, out int securitySpecialFlags, bool checkExecutionPermission)
	{
		CodeAccessPermission.Assert(allPossible: true);
		PermissionSet permissionSet = ResolvePolicy(evidence, reqdPset, optPset, denyPset, out denied, checkExecutionPermission);
		securitySpecialFlags = GetSpecialFlags(permissionSet, denied);
		return permissionSet;
	}

	[SecurityCritical]
	private static PermissionSet ResolvePolicy(Evidence evidence, PermissionSet reqdPset, PermissionSet optPset, PermissionSet denyPset, out PermissionSet denied, bool checkExecutionPermission)
	{
		if (executionSecurityPermission == null)
		{
			executionSecurityPermission = new SecurityPermission(SecurityPermissionFlag.Execution);
		}
		PermissionSet permissionSet = null;
		Exception exception = null;
		permissionSet = ((reqdPset != null) ? ((optPset == null) ? null : reqdPset.Union(optPset)) : optPset);
		if (permissionSet != null && !permissionSet.IsUnrestricted())
		{
			permissionSet.AddPermission(executionSecurityPermission);
		}
		if (evidence == null)
		{
			evidence = new Evidence();
		}
		PermissionSet permissionSet2 = polmgr.Resolve(evidence);
		if (permissionSet != null)
		{
			permissionSet2.InplaceIntersect(permissionSet);
		}
		if (checkExecutionPermission && (!permissionSet2.Contains(executionSecurityPermission) || (denyPset != null && denyPset.Contains(executionSecurityPermission))))
		{
			throw new PolicyException(Environment.GetResourceString("Policy_NoExecutionPermission"), -2146233320, exception);
		}
		if (reqdPset != null && !reqdPset.IsSubsetOf(permissionSet2))
		{
			throw new PolicyException(Environment.GetResourceString("Policy_NoRequiredPermission"), -2146233321, exception);
		}
		if (denyPset != null)
		{
			denied = denyPset.Copy();
			permissionSet2.MergeDeniedSet(denied);
			if (denied.IsEmpty())
			{
				denied = null;
			}
		}
		else
		{
			denied = null;
		}
		permissionSet2.IgnoreTypeLoadFailures = true;
		return permissionSet2;
	}

	internal static int GetSpecialFlags(PermissionSet grantSet, PermissionSet deniedSet)
	{
		if (grantSet != null && grantSet.IsUnrestricted() && (deniedSet == null || deniedSet.IsEmpty()))
		{
			return -1;
		}
		SecurityPermission securityPermission = null;
		SecurityPermissionFlag securityPermissionFlag = SecurityPermissionFlag.NoFlags;
		ReflectionPermission reflectionPermission = null;
		ReflectionPermissionFlag reflectionPermissionFlag = ReflectionPermissionFlag.NoFlags;
		CodeAccessPermission[] array = new CodeAccessPermission[6];
		if (grantSet != null)
		{
			if (grantSet.IsUnrestricted())
			{
				securityPermissionFlag = SecurityPermissionFlag.AllFlags;
				reflectionPermissionFlag = ReflectionPermissionFlag.AllFlags | ReflectionPermissionFlag.RestrictedMemberAccess;
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = s_UnrestrictedSpecialPermissionMap[i];
				}
			}
			else
			{
				if (grantSet.GetPermission(6) is SecurityPermission securityPermission2)
				{
					securityPermissionFlag = securityPermission2.Flags;
				}
				if (grantSet.GetPermission(4) is ReflectionPermission reflectionPermission2)
				{
					reflectionPermissionFlag = reflectionPermission2.Flags;
				}
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = grantSet.GetPermission(s_BuiltInPermissionIndexMap[j][0]) as CodeAccessPermission;
				}
			}
		}
		if (deniedSet != null)
		{
			if (deniedSet.IsUnrestricted())
			{
				securityPermissionFlag = SecurityPermissionFlag.NoFlags;
				reflectionPermissionFlag = ReflectionPermissionFlag.NoFlags;
				for (int k = 0; k < s_BuiltInPermissionIndexMap.Length; k++)
				{
					array[k] = null;
				}
			}
			else
			{
				if (deniedSet.GetPermission(6) is SecurityPermission securityPermission3)
				{
					securityPermissionFlag &= ~securityPermission3.Flags;
				}
				if (deniedSet.GetPermission(4) is ReflectionPermission reflectionPermission3)
				{
					reflectionPermissionFlag &= ~reflectionPermission3.Flags;
				}
				for (int l = 0; l < s_BuiltInPermissionIndexMap.Length; l++)
				{
					if (deniedSet.GetPermission(s_BuiltInPermissionIndexMap[l][0]) is CodeAccessPermission codeAccessPermission && !codeAccessPermission.IsSubsetOf(null))
					{
						array[l] = null;
					}
				}
			}
		}
		int num = MapToSpecialFlags(securityPermissionFlag, reflectionPermissionFlag);
		if (num != -1)
		{
			for (int m = 0; m < array.Length; m++)
			{
				if (array[m] != null && ((IUnrestrictedPermission)array[m]).IsUnrestricted())
				{
					num |= 1 << s_BuiltInPermissionIndexMap[m][1];
				}
			}
		}
		return num;
	}

	private static int MapToSpecialFlags(SecurityPermissionFlag securityPermissionFlags, ReflectionPermissionFlag reflectionPermissionFlags)
	{
		int num = 0;
		if ((securityPermissionFlags & SecurityPermissionFlag.UnmanagedCode) == SecurityPermissionFlag.UnmanagedCode)
		{
			num |= 1;
		}
		if ((securityPermissionFlags & SecurityPermissionFlag.SkipVerification) == SecurityPermissionFlag.SkipVerification)
		{
			num |= 2;
		}
		if ((securityPermissionFlags & SecurityPermissionFlag.Assertion) == SecurityPermissionFlag.Assertion)
		{
			num |= 8;
		}
		if ((securityPermissionFlags & SecurityPermissionFlag.SerializationFormatter) == SecurityPermissionFlag.SerializationFormatter)
		{
			num |= 0x20;
		}
		if ((securityPermissionFlags & SecurityPermissionFlag.BindingRedirects) == SecurityPermissionFlag.BindingRedirects)
		{
			num |= 0x100;
		}
		if ((securityPermissionFlags & SecurityPermissionFlag.ControlEvidence) == SecurityPermissionFlag.ControlEvidence)
		{
			num |= 0x10000;
		}
		if ((securityPermissionFlags & SecurityPermissionFlag.ControlPrincipal) == SecurityPermissionFlag.ControlPrincipal)
		{
			num |= 0x20000;
		}
		if ((reflectionPermissionFlags & ReflectionPermissionFlag.RestrictedMemberAccess) == ReflectionPermissionFlag.RestrictedMemberAccess)
		{
			num |= 0x40;
		}
		if ((reflectionPermissionFlags & ReflectionPermissionFlag.MemberAccess) == ReflectionPermissionFlag.MemberAccess)
		{
			num |= 0x10;
		}
		return num;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool IsSameType(string strLeft, string strRight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool _SetThreadSecurity(bool bThreadSecurity);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void GetGrantedPermissions(ObjectHandleOnStack retGranted, ObjectHandleOnStack retDenied, StackCrawlMarkHandle stackMark);
}
