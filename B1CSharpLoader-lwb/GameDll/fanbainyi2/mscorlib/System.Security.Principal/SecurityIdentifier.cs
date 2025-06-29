using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Principal;

[ComVisible(false)]
public sealed class SecurityIdentifier : IdentityReference, IComparable<SecurityIdentifier>
{
	internal static readonly long MaxIdentifierAuthority = 281474976710655L;

	internal static readonly byte MaxSubAuthorities = 15;

	public static readonly int MinBinaryLength = 8;

	public static readonly int MaxBinaryLength = 8 + MaxSubAuthorities * 4;

	private IdentifierAuthority _IdentifierAuthority;

	private int[] _SubAuthorities;

	private byte[] _BinaryForm;

	private SecurityIdentifier _AccountDomainSid;

	private bool _AccountDomainSidInitialized;

	private string _SddlForm;

	internal static byte Revision => 1;

	internal byte[] BinaryForm => _BinaryForm;

	internal IdentifierAuthority IdentifierAuthority => _IdentifierAuthority;

	internal int SubAuthorityCount => _SubAuthorities.Length;

	public int BinaryLength => _BinaryForm.Length;

	public SecurityIdentifier AccountDomainSid
	{
		[SecuritySafeCritical]
		get
		{
			if (!_AccountDomainSidInitialized)
			{
				_AccountDomainSid = GetAccountDomainSid();
				_AccountDomainSidInitialized = true;
			}
			return _AccountDomainSid;
		}
	}

	public override string Value => ToString().ToUpper(CultureInfo.InvariantCulture);

	private void CreateFromParts(IdentifierAuthority identifierAuthority, int[] subAuthorities)
	{
		if (subAuthorities == null)
		{
			throw new ArgumentNullException("subAuthorities");
		}
		if (subAuthorities.Length > MaxSubAuthorities)
		{
			throw new ArgumentOutOfRangeException("subAuthorities.Length", subAuthorities.Length, Environment.GetResourceString("IdentityReference_InvalidNumberOfSubauthorities", MaxSubAuthorities));
		}
		if (identifierAuthority < IdentifierAuthority.NullAuthority || (long)identifierAuthority > MaxIdentifierAuthority)
		{
			throw new ArgumentOutOfRangeException("identifierAuthority", identifierAuthority, Environment.GetResourceString("IdentityReference_IdentifierAuthorityTooLarge"));
		}
		_IdentifierAuthority = identifierAuthority;
		_SubAuthorities = new int[subAuthorities.Length];
		subAuthorities.CopyTo(_SubAuthorities, 0);
		_BinaryForm = new byte[8 + 4 * SubAuthorityCount];
		_BinaryForm[0] = Revision;
		_BinaryForm[1] = (byte)SubAuthorityCount;
		for (byte b = 0; b < 6; b++)
		{
			_BinaryForm[2 + b] = (byte)(((ulong)_IdentifierAuthority >> (5 - b) * 8) & 0xFF);
		}
		for (byte b = 0; b < SubAuthorityCount; b++)
		{
			for (byte b2 = 0; b2 < 4; b2++)
			{
				_BinaryForm[8 + 4 * b + b2] = (byte)((ulong)_SubAuthorities[b] >> b2 * 8);
			}
		}
	}

	private void CreateFromBinaryForm(byte[] binaryForm, int offset)
	{
		if (binaryForm == null)
		{
			throw new ArgumentNullException("binaryForm");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", offset, Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (binaryForm.Length - offset < MinBinaryLength)
		{
			throw new ArgumentOutOfRangeException("binaryForm", Environment.GetResourceString("ArgumentOutOfRange_ArrayTooSmall"));
		}
		if (binaryForm[offset] != Revision)
		{
			throw new ArgumentException(Environment.GetResourceString("IdentityReference_InvalidSidRevision"), "binaryForm");
		}
		if (binaryForm[offset + 1] > MaxSubAuthorities)
		{
			throw new ArgumentException(Environment.GetResourceString("IdentityReference_InvalidNumberOfSubauthorities", MaxSubAuthorities), "binaryForm");
		}
		int num = 8 + 4 * binaryForm[offset + 1];
		if (binaryForm.Length - offset < num)
		{
			throw new ArgumentException(Environment.GetResourceString("ArgumentOutOfRange_ArrayTooSmall"), "binaryForm");
		}
		IdentifierAuthority identifierAuthority = (IdentifierAuthority)(((ulong)binaryForm[offset + 2] << 40) + ((ulong)binaryForm[offset + 3] << 32) + ((ulong)binaryForm[offset + 4] << 24) + ((ulong)binaryForm[offset + 5] << 16) + ((ulong)binaryForm[offset + 6] << 8) + binaryForm[offset + 7]);
		int[] array = new int[binaryForm[offset + 1]];
		for (byte b = 0; b < binaryForm[offset + 1]; b++)
		{
			array[b] = binaryForm[offset + 8 + 4 * b] + (binaryForm[offset + 8 + 4 * b + 1] << 8) + (binaryForm[offset + 8 + 4 * b + 2] << 16) + (binaryForm[offset + 8 + 4 * b + 3] << 24);
		}
		CreateFromParts(identifierAuthority, array);
	}

	[SecuritySafeCritical]
	public SecurityIdentifier(string sddlForm)
	{
		if (sddlForm == null)
		{
			throw new ArgumentNullException("sddlForm");
		}
		byte[] resultSid;
		int num = Win32.CreateSidFromString(sddlForm, out resultSid);
		switch (num)
		{
		case 1337:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidValue"), "sddlForm");
		case 8:
			throw new OutOfMemoryException();
		default:
			throw new SystemException(Win32Native.GetMessage(num));
		case 0:
			CreateFromBinaryForm(resultSid, 0);
			break;
		}
	}

	public SecurityIdentifier(byte[] binaryForm, int offset)
	{
		CreateFromBinaryForm(binaryForm, offset);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public SecurityIdentifier(IntPtr binaryForm)
		: this(binaryForm, noDemand: true)
	{
	}

	[SecurityCritical]
	internal SecurityIdentifier(IntPtr binaryForm, bool noDemand)
		: this(Win32.ConvertIntPtrSidToByteArraySid(binaryForm), 0)
	{
	}

	[SecuritySafeCritical]
	public SecurityIdentifier(WellKnownSidType sidType, SecurityIdentifier domainSid)
	{
		if (sidType == WellKnownSidType.LogonIdsSid)
		{
			throw new ArgumentException(Environment.GetResourceString("IdentityReference_CannotCreateLogonIdsSid"), "sidType");
		}
		if (!Win32.WellKnownSidApisSupported)
		{
			throw new PlatformNotSupportedException(Environment.GetResourceString("PlatformNotSupported_RequiresW2kSP3"));
		}
		switch (sidType)
		{
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidValue"), "sidType");
		case WellKnownSidType.AccountAdministratorSid:
		case WellKnownSidType.AccountGuestSid:
		case WellKnownSidType.AccountKrbtgtSid:
		case WellKnownSidType.AccountDomainAdminsSid:
		case WellKnownSidType.AccountDomainUsersSid:
		case WellKnownSidType.AccountDomainGuestsSid:
		case WellKnownSidType.AccountComputersSid:
		case WellKnownSidType.AccountControllersSid:
		case WellKnownSidType.AccountCertAdminsSid:
		case WellKnownSidType.AccountSchemaAdminsSid:
		case WellKnownSidType.AccountEnterpriseAdminsSid:
		case WellKnownSidType.AccountPolicyAdminsSid:
		case WellKnownSidType.AccountRasAndIasServersSid:
		{
			if (domainSid == null)
			{
				throw new ArgumentNullException("domainSid", Environment.GetResourceString("IdentityReference_DomainSidRequired", sidType));
			}
			SecurityIdentifier resultSid;
			int windowsAccountDomainSid = Win32.GetWindowsAccountDomainSid(domainSid, out resultSid);
			switch (windowsAccountDomainSid)
			{
			case 122:
				throw new OutOfMemoryException();
			case 1257:
				throw new ArgumentException(Environment.GetResourceString("IdentityReference_NotAWindowsDomain"), "domainSid");
			default:
				throw new SystemException(Win32Native.GetMessage(windowsAccountDomainSid));
			case 0:
				break;
			}
			if (resultSid != domainSid)
			{
				throw new ArgumentException(Environment.GetResourceString("IdentityReference_NotAWindowsDomain"), "domainSid");
			}
			break;
		}
		case WellKnownSidType.NullSid:
		case WellKnownSidType.WorldSid:
		case WellKnownSidType.LocalSid:
		case WellKnownSidType.CreatorOwnerSid:
		case WellKnownSidType.CreatorGroupSid:
		case WellKnownSidType.CreatorOwnerServerSid:
		case WellKnownSidType.CreatorGroupServerSid:
		case WellKnownSidType.NTAuthoritySid:
		case WellKnownSidType.DialupSid:
		case WellKnownSidType.NetworkSid:
		case WellKnownSidType.BatchSid:
		case WellKnownSidType.InteractiveSid:
		case WellKnownSidType.ServiceSid:
		case WellKnownSidType.AnonymousSid:
		case WellKnownSidType.ProxySid:
		case WellKnownSidType.EnterpriseControllersSid:
		case WellKnownSidType.SelfSid:
		case WellKnownSidType.AuthenticatedUserSid:
		case WellKnownSidType.RestrictedCodeSid:
		case WellKnownSidType.TerminalServerSid:
		case WellKnownSidType.RemoteLogonIdSid:
		case WellKnownSidType.LogonIdsSid:
		case WellKnownSidType.LocalSystemSid:
		case WellKnownSidType.LocalServiceSid:
		case WellKnownSidType.NetworkServiceSid:
		case WellKnownSidType.BuiltinDomainSid:
		case WellKnownSidType.BuiltinAdministratorsSid:
		case WellKnownSidType.BuiltinUsersSid:
		case WellKnownSidType.BuiltinGuestsSid:
		case WellKnownSidType.BuiltinPowerUsersSid:
		case WellKnownSidType.BuiltinAccountOperatorsSid:
		case WellKnownSidType.BuiltinSystemOperatorsSid:
		case WellKnownSidType.BuiltinPrintOperatorsSid:
		case WellKnownSidType.BuiltinBackupOperatorsSid:
		case WellKnownSidType.BuiltinReplicatorSid:
		case WellKnownSidType.BuiltinPreWindows2000CompatibleAccessSid:
		case WellKnownSidType.BuiltinRemoteDesktopUsersSid:
		case WellKnownSidType.BuiltinNetworkConfigurationOperatorsSid:
		case WellKnownSidType.NtlmAuthenticationSid:
		case WellKnownSidType.DigestAuthenticationSid:
		case WellKnownSidType.SChannelAuthenticationSid:
		case WellKnownSidType.ThisOrganizationSid:
		case WellKnownSidType.OtherOrganizationSid:
		case WellKnownSidType.BuiltinIncomingForestTrustBuildersSid:
		case WellKnownSidType.BuiltinPerformanceMonitoringUsersSid:
		case WellKnownSidType.BuiltinPerformanceLoggingUsersSid:
		case WellKnownSidType.BuiltinAuthorizationAccessSid:
		case WellKnownSidType.WinBuiltinTerminalServerLicenseServersSid:
			break;
		}
		byte[] resultSid2;
		int num = Win32.CreateWellKnownSid(sidType, domainSid, out resultSid2);
		switch (num)
		{
		case 87:
			throw new ArgumentException(Win32Native.GetMessage(num), "sidType/domainSid");
		default:
			throw new SystemException(Win32Native.GetMessage(num));
		case 0:
			CreateFromBinaryForm(resultSid2, 0);
			break;
		}
	}

	internal SecurityIdentifier(SecurityIdentifier domainSid, uint rid)
	{
		int[] array = new int[domainSid.SubAuthorityCount + 1];
		int i;
		for (i = 0; i < domainSid.SubAuthorityCount; i++)
		{
			array[i] = domainSid.GetSubAuthority(i);
		}
		array[i] = (int)rid;
		CreateFromParts(domainSid.IdentifierAuthority, array);
	}

	internal SecurityIdentifier(IdentifierAuthority identifierAuthority, int[] subAuthorities)
	{
		CreateFromParts(identifierAuthority, subAuthorities);
	}

	public override bool Equals(object o)
	{
		if (o == null)
		{
			return false;
		}
		SecurityIdentifier securityIdentifier = o as SecurityIdentifier;
		if (securityIdentifier == null)
		{
			return false;
		}
		return this == securityIdentifier;
	}

	public bool Equals(SecurityIdentifier sid)
	{
		if (sid == null)
		{
			return false;
		}
		return this == sid;
	}

	public override int GetHashCode()
	{
		int num = ((long)IdentifierAuthority).GetHashCode();
		for (int i = 0; i < SubAuthorityCount; i++)
		{
			num ^= GetSubAuthority(i);
		}
		return num;
	}

	public override string ToString()
	{
		if (_SddlForm == null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("S-1-{0}", (long)_IdentifierAuthority);
			for (int i = 0; i < SubAuthorityCount; i++)
			{
				stringBuilder.AppendFormat("-{0}", (uint)_SubAuthorities[i]);
			}
			_SddlForm = stringBuilder.ToString();
		}
		return _SddlForm;
	}

	internal static bool IsValidTargetTypeStatic(Type targetType)
	{
		if (targetType == typeof(NTAccount))
		{
			return true;
		}
		if (targetType == typeof(SecurityIdentifier))
		{
			return true;
		}
		return false;
	}

	public override bool IsValidTargetType(Type targetType)
	{
		return IsValidTargetTypeStatic(targetType);
	}

	[SecurityCritical]
	internal SecurityIdentifier GetAccountDomainSid()
	{
		SecurityIdentifier resultSid;
		int windowsAccountDomainSid = Win32.GetWindowsAccountDomainSid(this, out resultSid);
		return windowsAccountDomainSid switch
		{
			122 => throw new OutOfMemoryException(), 
			1257 => null, 
			0 => resultSid, 
			_ => throw new SystemException(Win32Native.GetMessage(windowsAccountDomainSid)), 
		};
	}

	[SecuritySafeCritical]
	public bool IsAccountSid()
	{
		if (!_AccountDomainSidInitialized)
		{
			_AccountDomainSid = GetAccountDomainSid();
			_AccountDomainSidInitialized = true;
		}
		if (_AccountDomainSid == null)
		{
			return false;
		}
		return true;
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
	public override IdentityReference Translate(Type targetType)
	{
		if (targetType == null)
		{
			throw new ArgumentNullException("targetType");
		}
		if (targetType == typeof(SecurityIdentifier))
		{
			return this;
		}
		if (targetType == typeof(NTAccount))
		{
			IdentityReferenceCollection identityReferenceCollection = new IdentityReferenceCollection(1);
			identityReferenceCollection.Add(this);
			IdentityReferenceCollection identityReferenceCollection2 = Translate(identityReferenceCollection, targetType, forceSuccess: true);
			return identityReferenceCollection2[0];
		}
		throw new ArgumentException(Environment.GetResourceString("IdentityReference_MustBeIdentityReference"), "targetType");
	}

	public static bool operator ==(SecurityIdentifier left, SecurityIdentifier right)
	{
		if ((object)left == null && (object)right == null)
		{
			return true;
		}
		if ((object)left == null || (object)right == null)
		{
			return false;
		}
		return left.CompareTo(right) == 0;
	}

	public static bool operator !=(SecurityIdentifier left, SecurityIdentifier right)
	{
		return !(left == right);
	}

	public int CompareTo(SecurityIdentifier sid)
	{
		if (sid == null)
		{
			throw new ArgumentNullException("sid");
		}
		if (IdentifierAuthority < sid.IdentifierAuthority)
		{
			return -1;
		}
		if (IdentifierAuthority > sid.IdentifierAuthority)
		{
			return 1;
		}
		if (SubAuthorityCount < sid.SubAuthorityCount)
		{
			return -1;
		}
		if (SubAuthorityCount > sid.SubAuthorityCount)
		{
			return 1;
		}
		for (int i = 0; i < SubAuthorityCount; i++)
		{
			int num = GetSubAuthority(i) - sid.GetSubAuthority(i);
			if (num != 0)
			{
				return num;
			}
		}
		return 0;
	}

	internal int GetSubAuthority(int index)
	{
		return _SubAuthorities[index];
	}

	[SecuritySafeCritical]
	public bool IsWellKnown(WellKnownSidType type)
	{
		return Win32.IsWellKnownSid(this, type);
	}

	public void GetBinaryForm(byte[] binaryForm, int offset)
	{
		_BinaryForm.CopyTo(binaryForm, offset);
	}

	[SecuritySafeCritical]
	public bool IsEqualDomainSid(SecurityIdentifier sid)
	{
		return Win32.IsEqualDomainSid(this, sid);
	}

	[SecurityCritical]
	private static IdentityReferenceCollection TranslateToNTAccounts(IdentityReferenceCollection sourceSids, out bool someFailed)
	{
		if (sourceSids == null)
		{
			throw new ArgumentNullException("sourceSids");
		}
		if (sourceSids.Count == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EmptyCollection"), "sourceSids");
		}
		IntPtr[] array = new IntPtr[sourceSids.Count];
		GCHandle[] array2 = new GCHandle[sourceSids.Count];
		SafeLsaPolicyHandle safeLsaPolicyHandle = SafeLsaPolicyHandle.InvalidHandle;
		SafeLsaMemoryHandle referencedDomains = SafeLsaMemoryHandle.InvalidHandle;
		SafeLsaMemoryHandle names = SafeLsaMemoryHandle.InvalidHandle;
		try
		{
			int num = 0;
			foreach (IdentityReference sourceSid in sourceSids)
			{
				SecurityIdentifier securityIdentifier = sourceSid as SecurityIdentifier;
				if (securityIdentifier == null)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_ImproperType"), "sourceSids");
				}
				array2[num] = GCHandle.Alloc(securityIdentifier.BinaryForm, GCHandleType.Pinned);
				array[num] = array2[num].AddrOfPinnedObject();
				num++;
			}
			safeLsaPolicyHandle = Win32.LsaOpenPolicy(null, PolicyRights.POLICY_LOOKUP_NAMES);
			someFailed = false;
			uint num2 = Win32Native.LsaLookupSids(safeLsaPolicyHandle, sourceSids.Count, array, ref referencedDomains, ref names);
			switch (num2)
			{
			case 3221225495u:
			case 3221225626u:
				throw new OutOfMemoryException();
			case 3221225506u:
				throw new UnauthorizedAccessException();
			case 3221225587u:
			case 263u:
				someFailed = true;
				break;
			default:
			{
				int errorCode = Win32Native.LsaNtStatusToWinError((int)num2);
				throw new SystemException(Win32Native.GetMessage(errorCode));
			}
			case 0u:
				break;
			}
			names.Initialize((uint)sourceSids.Count, (uint)Marshal.SizeOf(typeof(Win32Native.LSA_TRANSLATED_NAME)));
			Win32.InitializeReferencedDomainsPointer(referencedDomains);
			IdentityReferenceCollection identityReferenceCollection = new IdentityReferenceCollection(sourceSids.Count);
			if (num2 == 0 || num2 == 263)
			{
				Win32Native.LSA_REFERENCED_DOMAIN_LIST lSA_REFERENCED_DOMAIN_LIST = referencedDomains.Read<Win32Native.LSA_REFERENCED_DOMAIN_LIST>(0uL);
				string[] array3 = new string[lSA_REFERENCED_DOMAIN_LIST.Entries];
				for (int i = 0; i < lSA_REFERENCED_DOMAIN_LIST.Entries; i++)
				{
					Win32Native.LSA_TRUST_INFORMATION lSA_TRUST_INFORMATION = (Win32Native.LSA_TRUST_INFORMATION)Marshal.PtrToStructure(new IntPtr((long)lSA_REFERENCED_DOMAIN_LIST.Domains + i * Marshal.SizeOf(typeof(Win32Native.LSA_TRUST_INFORMATION))), typeof(Win32Native.LSA_TRUST_INFORMATION));
					array3[i] = Marshal.PtrToStringUni(lSA_TRUST_INFORMATION.Name.Buffer, lSA_TRUST_INFORMATION.Name.Length / 2);
				}
				Win32Native.LSA_TRANSLATED_NAME[] array4 = new Win32Native.LSA_TRANSLATED_NAME[sourceSids.Count];
				names.ReadArray(0uL, array4, 0, array4.Length);
				for (int j = 0; j < sourceSids.Count; j++)
				{
					Win32Native.LSA_TRANSLATED_NAME lSA_TRANSLATED_NAME = array4[j];
					switch ((SidNameUse)lSA_TRANSLATED_NAME.Use)
					{
					case SidNameUse.User:
					case SidNameUse.Group:
					case SidNameUse.Alias:
					case SidNameUse.WellKnownGroup:
					case SidNameUse.Computer:
					{
						string accountName = Marshal.PtrToStringUni(lSA_TRANSLATED_NAME.Name.Buffer, lSA_TRANSLATED_NAME.Name.Length / 2);
						string domainName = array3[lSA_TRANSLATED_NAME.DomainIndex];
						identityReferenceCollection.Add(new NTAccount(domainName, accountName));
						break;
					}
					default:
						someFailed = true;
						identityReferenceCollection.Add(sourceSids[j]);
						break;
					}
				}
			}
			else
			{
				for (int k = 0; k < sourceSids.Count; k++)
				{
					identityReferenceCollection.Add(sourceSids[k]);
				}
			}
			return identityReferenceCollection;
		}
		finally
		{
			for (int l = 0; l < sourceSids.Count; l++)
			{
				if (array2[l].IsAllocated)
				{
					array2[l].Free();
				}
			}
			safeLsaPolicyHandle.Dispose();
			referencedDomains.Dispose();
			names.Dispose();
		}
	}

	[SecurityCritical]
	internal static IdentityReferenceCollection Translate(IdentityReferenceCollection sourceSids, Type targetType, bool forceSuccess)
	{
		bool someFailed = false;
		IdentityReferenceCollection identityReferenceCollection = Translate(sourceSids, targetType, out someFailed);
		if (forceSuccess && someFailed)
		{
			IdentityReferenceCollection identityReferenceCollection2 = new IdentityReferenceCollection();
			foreach (IdentityReference item in identityReferenceCollection)
			{
				if (item.GetType() != targetType)
				{
					identityReferenceCollection2.Add(item);
				}
			}
			throw new IdentityNotMappedException(Environment.GetResourceString("IdentityReference_IdentityNotMapped"), identityReferenceCollection2);
		}
		return identityReferenceCollection;
	}

	[SecurityCritical]
	internal static IdentityReferenceCollection Translate(IdentityReferenceCollection sourceSids, Type targetType, out bool someFailed)
	{
		if (sourceSids == null)
		{
			throw new ArgumentNullException("sourceSids");
		}
		if (targetType == typeof(NTAccount))
		{
			return TranslateToNTAccounts(sourceSids, out someFailed);
		}
		throw new ArgumentException(Environment.GetResourceString("IdentityReference_MustBeIdentityReference"), "targetType");
	}
}
