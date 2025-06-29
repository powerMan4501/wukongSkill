using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Security.Util;
using System.Text;
using System.Threading;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class PolicyLevel
{
	private ArrayList m_fullTrustAssemblies;

	private ArrayList m_namedPermissionSets;

	private CodeGroup m_rootCodeGroup;

	private string m_label;

	[OptionalField(VersionAdded = 2)]
	private PolicyLevelType m_type;

	private ConfigId m_configId;

	private bool m_useDefaultCodeGroupsOnReset;

	private bool m_generateQuickCacheOnLoad;

	private bool m_caching;

	private bool m_throwOnLoadError;

	private Encoding m_encoding;

	private bool m_loaded;

	private SecurityElement m_permSetElement;

	private string m_path;

	private static object s_InternalSyncObject;

	private static readonly string[] s_reservedNamedPermissionSets;

	private static string[] EcmaFullTrustAssemblies;

	private static string[] MicrosoftFullTrustAssemblies;

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
			}
			return s_InternalSyncObject;
		}
	}

	public string Label
	{
		get
		{
			if (m_label == null)
			{
				m_label = DeriveLabelFromType();
			}
			return m_label;
		}
	}

	[ComVisible(false)]
	public PolicyLevelType Type => m_type;

	internal ConfigId ConfigId => m_configId;

	internal string Path => m_path;

	public string StoreLocation
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPolicy)]
		get
		{
			return GetLocationFromType(m_type);
		}
	}

	public CodeGroup RootCodeGroup
	{
		[SecuritySafeCritical]
		get
		{
			CheckLoaded();
			return m_rootCodeGroup;
		}
		[SecuritySafeCritical]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("RootCodeGroup");
			}
			CheckLoaded();
			m_rootCodeGroup = value.Copy();
		}
	}

	public IList NamedPermissionSets
	{
		[SecuritySafeCritical]
		get
		{
			CheckLoaded();
			LoadAllPermissionSets();
			ArrayList arrayList = new ArrayList(m_namedPermissionSets.Count);
			IEnumerator enumerator = m_namedPermissionSets.GetEnumerator();
			while (enumerator.MoveNext())
			{
				arrayList.Add(((NamedPermissionSet)enumerator.Current).Copy());
			}
			return arrayList;
		}
	}

	[Obsolete("Because all GAC assemblies always get full trust, the full trust list is no longer meaningful. You should install any assemblies that are used in security policy in the GAC to ensure they are trusted.")]
	public IList FullTrustAssemblies
	{
		[SecuritySafeCritical]
		get
		{
			CheckLoaded();
			return new ArrayList(m_fullTrustAssemblies);
		}
	}

	static PolicyLevel()
	{
		s_reservedNamedPermissionSets = new string[7] { "FullTrust", "Nothing", "Execution", "SkipVerification", "Internet", "LocalIntranet", "Everything" };
		EcmaFullTrustAssemblies = new string[9] { "mscorlib.resources", "System", "System.resources", "System.Xml", "System.Xml.resources", "System.Windows.Forms", "System.Windows.Forms.resources", "System.Data", "System.Data.resources" };
		MicrosoftFullTrustAssemblies = new string[12]
		{
			"System.Security", "System.Security.resources", "System.Drawing", "System.Drawing.resources", "System.Messaging", "System.Messaging.resources", "System.ServiceProcess", "System.ServiceProcess.resources", "System.DirectoryServices", "System.DirectoryServices.resources",
			"System.Deployment", "System.Deployment.resources"
		};
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
		if (m_label != null)
		{
			DeriveTypeFromLabel();
		}
	}

	private void DeriveTypeFromLabel()
	{
		if (m_label.Equals(Environment.GetResourceString("Policy_PL_User")))
		{
			m_type = PolicyLevelType.User;
			return;
		}
		if (m_label.Equals(Environment.GetResourceString("Policy_PL_Machine")))
		{
			m_type = PolicyLevelType.Machine;
			return;
		}
		if (m_label.Equals(Environment.GetResourceString("Policy_PL_Enterprise")))
		{
			m_type = PolicyLevelType.Enterprise;
			return;
		}
		if (m_label.Equals(Environment.GetResourceString("Policy_PL_AppDomain")))
		{
			m_type = PolicyLevelType.AppDomain;
			return;
		}
		throw new ArgumentException(Environment.GetResourceString("Policy_Default"));
	}

	private string DeriveLabelFromType()
	{
		return m_type switch
		{
			PolicyLevelType.User => Environment.GetResourceString("Policy_PL_User"), 
			PolicyLevelType.Machine => Environment.GetResourceString("Policy_PL_Machine"), 
			PolicyLevelType.Enterprise => Environment.GetResourceString("Policy_PL_Enterprise"), 
			PolicyLevelType.AppDomain => Environment.GetResourceString("Policy_PL_AppDomain"), 
			_ => throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)m_type)), 
		};
	}

	private PolicyLevel()
	{
	}

	[SecurityCritical]
	internal PolicyLevel(PolicyLevelType type)
		: this(type, GetLocationFromType(type))
	{
	}

	internal PolicyLevel(PolicyLevelType type, string path)
		: this(type, path, ConfigId.None)
	{
	}

	internal PolicyLevel(PolicyLevelType type, string path, ConfigId configId)
	{
		m_type = type;
		m_path = path;
		m_loaded = path == null;
		if (m_path == null)
		{
			m_rootCodeGroup = CreateDefaultAllGroup();
			SetFactoryPermissionSets();
			SetDefaultFullTrustAssemblies();
		}
		m_configId = configId;
	}

	[SecurityCritical]
	internal static string GetLocationFromType(PolicyLevelType type)
	{
		return type switch
		{
			PolicyLevelType.User => Config.UserDirectory + "security.config", 
			PolicyLevelType.Machine => Config.MachineDirectory + "security.config", 
			PolicyLevelType.Enterprise => Config.MachineDirectory + "enterprisesec.config", 
			_ => null, 
		};
	}

	[SecuritySafeCritical]
	[Obsolete("AppDomain policy levels are obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static PolicyLevel CreateAppDomainLevel()
	{
		return new PolicyLevel(PolicyLevelType.AppDomain);
	}

	public CodeGroup ResolveMatchingCodeGroups(Evidence evidence)
	{
		if (evidence == null)
		{
			throw new ArgumentNullException("evidence");
		}
		return RootCodeGroup.ResolveMatchingCodeGroups(evidence);
	}

	[Obsolete("Because all GAC assemblies always get full trust, the full trust list is no longer meaningful. You should install any assemblies that are used in security policy in the GAC to ensure they are trusted.")]
	public void AddFullTrustAssembly(StrongName sn)
	{
		if (sn == null)
		{
			throw new ArgumentNullException("sn");
		}
		AddFullTrustAssembly(new StrongNameMembershipCondition(sn.PublicKey, sn.Name, sn.Version));
	}

	[SecuritySafeCritical]
	[Obsolete("Because all GAC assemblies always get full trust, the full trust list is no longer meaningful. You should install any assemblies that are used in security policy in the GAC to ensure they are trusted.")]
	public void AddFullTrustAssembly(StrongNameMembershipCondition snMC)
	{
		if (snMC == null)
		{
			throw new ArgumentNullException("snMC");
		}
		CheckLoaded();
		IEnumerator enumerator = m_fullTrustAssemblies.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (((StrongNameMembershipCondition)enumerator.Current).Equals(snMC))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_AssemblyAlreadyFullTrust"));
			}
		}
		lock (m_fullTrustAssemblies)
		{
			m_fullTrustAssemblies.Add(snMC);
		}
	}

	[Obsolete("Because all GAC assemblies always get full trust, the full trust list is no longer meaningful. You should install any assemblies that are used in security policy in the GAC to ensure they are trusted.")]
	public void RemoveFullTrustAssembly(StrongName sn)
	{
		if (sn == null)
		{
			throw new ArgumentNullException("assembly");
		}
		RemoveFullTrustAssembly(new StrongNameMembershipCondition(sn.PublicKey, sn.Name, sn.Version));
	}

	[SecuritySafeCritical]
	[Obsolete("Because all GAC assemblies always get full trust, the full trust list is no longer meaningful. You should install any assemblies that are used in security policy in the GAC to ensure they are trusted.")]
	public void RemoveFullTrustAssembly(StrongNameMembershipCondition snMC)
	{
		if (snMC == null)
		{
			throw new ArgumentNullException("snMC");
		}
		CheckLoaded();
		object obj = null;
		IEnumerator enumerator = m_fullTrustAssemblies.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (((StrongNameMembershipCondition)enumerator.Current).Equals(snMC))
			{
				obj = enumerator.Current;
				break;
			}
		}
		if (obj == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_AssemblyNotFullTrust"));
		}
		lock (m_fullTrustAssemblies)
		{
			m_fullTrustAssemblies.Remove(obj);
		}
	}

	[SecuritySafeCritical]
	public void AddNamedPermissionSet(NamedPermissionSet permSet)
	{
		if (permSet == null)
		{
			throw new ArgumentNullException("permSet");
		}
		CheckLoaded();
		LoadAllPermissionSets();
		lock (this)
		{
			IEnumerator enumerator = m_namedPermissionSets.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (((NamedPermissionSet)enumerator.Current).Name.Equals(permSet.Name))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_DuplicateName"));
				}
			}
			NamedPermissionSet namedPermissionSet = (NamedPermissionSet)permSet.Copy();
			namedPermissionSet.IgnoreTypeLoadFailures = true;
			m_namedPermissionSets.Add(namedPermissionSet);
		}
	}

	public NamedPermissionSet RemoveNamedPermissionSet(NamedPermissionSet permSet)
	{
		if (permSet == null)
		{
			throw new ArgumentNullException("permSet");
		}
		return RemoveNamedPermissionSet(permSet.Name);
	}

	[SecuritySafeCritical]
	public NamedPermissionSet RemoveNamedPermissionSet(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		CheckLoaded();
		LoadAllPermissionSets();
		int num = -1;
		for (int i = 0; i < s_reservedNamedPermissionSets.Length; i++)
		{
			if (s_reservedNamedPermissionSets[i].Equals(name))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_ReservedNPMS", name));
			}
		}
		ArrayList namedPermissionSets = m_namedPermissionSets;
		for (int j = 0; j < namedPermissionSets.Count; j++)
		{
			if (((NamedPermissionSet)namedPermissionSets[j]).Name.Equals(name))
			{
				num = j;
				break;
			}
		}
		if (num == -1)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NoNPMS"));
		}
		ArrayList arrayList = new ArrayList();
		arrayList.Add(m_rootCodeGroup);
		for (int k = 0; k < arrayList.Count; k++)
		{
			CodeGroup codeGroup = (CodeGroup)arrayList[k];
			if (codeGroup.PermissionSetName != null && codeGroup.PermissionSetName.Equals(name))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_NPMSInUse", name));
			}
			IEnumerator enumerator = codeGroup.Children.GetEnumerator();
			if (enumerator != null)
			{
				while (enumerator.MoveNext())
				{
					arrayList.Add(enumerator.Current);
				}
			}
		}
		NamedPermissionSet result = (NamedPermissionSet)namedPermissionSets[num];
		namedPermissionSets.RemoveAt(num);
		return result;
	}

	[SecuritySafeCritical]
	public NamedPermissionSet ChangeNamedPermissionSet(string name, PermissionSet pSet)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (pSet == null)
		{
			throw new ArgumentNullException("pSet");
		}
		for (int i = 0; i < s_reservedNamedPermissionSets.Length; i++)
		{
			if (s_reservedNamedPermissionSets[i].Equals(name))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_ReservedNPMS", name));
			}
		}
		NamedPermissionSet namedPermissionSetInternal = GetNamedPermissionSetInternal(name);
		if (namedPermissionSetInternal == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NoNPMS"));
		}
		NamedPermissionSet result = (NamedPermissionSet)namedPermissionSetInternal.Copy();
		namedPermissionSetInternal.Reset();
		namedPermissionSetInternal.SetUnrestricted(pSet.IsUnrestricted());
		IEnumerator enumerator = pSet.GetEnumerator();
		while (enumerator.MoveNext())
		{
			namedPermissionSetInternal.SetPermission(((IPermission)enumerator.Current).Copy());
		}
		if (pSet is NamedPermissionSet)
		{
			namedPermissionSetInternal.Description = ((NamedPermissionSet)pSet).Description;
		}
		return result;
	}

	[SecuritySafeCritical]
	public NamedPermissionSet GetNamedPermissionSet(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		NamedPermissionSet namedPermissionSetInternal = GetNamedPermissionSetInternal(name);
		if (namedPermissionSetInternal != null)
		{
			return new NamedPermissionSet(namedPermissionSetInternal);
		}
		return null;
	}

	[SecuritySafeCritical]
	public void Recover()
	{
		if (m_configId == ConfigId.None)
		{
			throw new PolicyException(Environment.GetResourceString("Policy_RecoverNotFileBased"));
		}
		lock (this)
		{
			if (!Config.RecoverData(m_configId))
			{
				throw new PolicyException(Environment.GetResourceString("Policy_RecoverNoConfigFile"));
			}
			m_loaded = false;
			m_rootCodeGroup = null;
			m_namedPermissionSets = null;
			m_fullTrustAssemblies = new ArrayList();
		}
	}

	[SecuritySafeCritical]
	public void Reset()
	{
		SetDefault();
	}

	[SecuritySafeCritical]
	public PolicyStatement Resolve(Evidence evidence)
	{
		return Resolve(evidence, 0, null);
	}

	[SecuritySafeCritical]
	public SecurityElement ToXml()
	{
		CheckLoaded();
		LoadAllPermissionSets();
		SecurityElement securityElement = new SecurityElement("PolicyLevel");
		securityElement.AddAttribute("version", "1");
		Hashtable hashtable = new Hashtable();
		lock (this)
		{
			SecurityElement securityElement2 = new SecurityElement("NamedPermissionSets");
			IEnumerator enumerator = m_namedPermissionSets.GetEnumerator();
			while (enumerator.MoveNext())
			{
				securityElement2.AddChild(NormalizeClassDeep(((NamedPermissionSet)enumerator.Current).ToXml(), hashtable));
			}
			SecurityElement child = NormalizeClassDeep(m_rootCodeGroup.ToXml(this), hashtable);
			SecurityElement securityElement3 = new SecurityElement("FullTrustAssemblies");
			enumerator = m_fullTrustAssemblies.GetEnumerator();
			while (enumerator.MoveNext())
			{
				securityElement3.AddChild(NormalizeClassDeep(((StrongNameMembershipCondition)enumerator.Current).ToXml(), hashtable));
			}
			SecurityElement securityElement4 = new SecurityElement("SecurityClasses");
			IDictionaryEnumerator enumerator2 = hashtable.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				SecurityElement securityElement5 = new SecurityElement("SecurityClass");
				securityElement5.AddAttribute("Name", (string)enumerator2.Value);
				securityElement5.AddAttribute("Description", (string)enumerator2.Key);
				securityElement4.AddChild(securityElement5);
			}
			securityElement.AddChild(securityElement4);
			securityElement.AddChild(securityElement2);
			securityElement.AddChild(child);
			securityElement.AddChild(securityElement3);
			return securityElement;
		}
	}

	public void FromXml(SecurityElement e)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		lock (this)
		{
			ArrayList arrayList = new ArrayList();
			SecurityElement securityElement = e.SearchForChildByTag("SecurityClasses");
			Hashtable hashtable;
			if (securityElement != null)
			{
				hashtable = new Hashtable();
				IEnumerator enumerator = securityElement.Children.GetEnumerator();
				while (enumerator.MoveNext())
				{
					SecurityElement securityElement2 = (SecurityElement)enumerator.Current;
					if (securityElement2.Tag.Equals("SecurityClass"))
					{
						string text = securityElement2.Attribute("Name");
						string text2 = securityElement2.Attribute("Description");
						if (text != null && text2 != null)
						{
							hashtable.Add(text, text2);
						}
					}
				}
			}
			else
			{
				hashtable = null;
			}
			SecurityElement securityElement3 = e.SearchForChildByTag("FullTrustAssemblies");
			if (securityElement3 != null && securityElement3.InternalChildren != null)
			{
				string assemblyQualifiedName = typeof(StrongNameMembershipCondition).AssemblyQualifiedName;
				IEnumerator enumerator2 = securityElement3.Children.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					StrongNameMembershipCondition strongNameMembershipCondition = new StrongNameMembershipCondition();
					strongNameMembershipCondition.FromXml((SecurityElement)enumerator2.Current);
					arrayList.Add(strongNameMembershipCondition);
				}
			}
			m_fullTrustAssemblies = arrayList;
			ArrayList arrayList2 = new ArrayList();
			SecurityElement securityElement4 = e.SearchForChildByTag("NamedPermissionSets");
			SecurityElement securityElement5 = null;
			if (securityElement4 != null && securityElement4.InternalChildren != null)
			{
				securityElement5 = UnnormalizeClassDeep(securityElement4, hashtable);
				string[] array = s_reservedNamedPermissionSets;
				foreach (string name in array)
				{
					FindElement(securityElement5, name);
				}
			}
			if (securityElement5 == null)
			{
				securityElement5 = new SecurityElement("NamedPermissionSets");
			}
			arrayList2.Add(BuiltInPermissionSets.FullTrust);
			arrayList2.Add(BuiltInPermissionSets.Everything);
			arrayList2.Add(BuiltInPermissionSets.SkipVerification);
			arrayList2.Add(BuiltInPermissionSets.Execution);
			arrayList2.Add(BuiltInPermissionSets.Nothing);
			arrayList2.Add(BuiltInPermissionSets.Internet);
			arrayList2.Add(BuiltInPermissionSets.LocalIntranet);
			foreach (PermissionSet item in arrayList2)
			{
				item.IgnoreTypeLoadFailures = true;
			}
			m_namedPermissionSets = arrayList2;
			m_permSetElement = securityElement5;
			SecurityElement securityElement6 = e.SearchForChildByTag("CodeGroup");
			if (securityElement6 == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidXMLElement", "CodeGroup", GetType().FullName));
			}
			CodeGroup codeGroup = XMLUtil.CreateCodeGroup(UnnormalizeClassDeep(securityElement6, hashtable));
			if (codeGroup == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidXMLElement", "CodeGroup", GetType().FullName));
			}
			codeGroup.FromXml(securityElement6, this);
			m_rootCodeGroup = codeGroup;
		}
	}

	[SecurityCritical]
	internal static PermissionSet GetBuiltInSet(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		if (name.Equals("FullTrust"))
		{
			return BuiltInPermissionSets.FullTrust;
		}
		if (name.Equals("Nothing"))
		{
			return BuiltInPermissionSets.Nothing;
		}
		if (name.Equals("Execution"))
		{
			return BuiltInPermissionSets.Execution;
		}
		if (name.Equals("SkipVerification"))
		{
			return BuiltInPermissionSets.SkipVerification;
		}
		if (name.Equals("Internet"))
		{
			return BuiltInPermissionSets.Internet;
		}
		if (name.Equals("LocalIntranet"))
		{
			return BuiltInPermissionSets.LocalIntranet;
		}
		return null;
	}

	[SecurityCritical]
	internal NamedPermissionSet GetNamedPermissionSetInternal(string name)
	{
		CheckLoaded();
		lock (InternalSyncObject)
		{
			foreach (NamedPermissionSet namedPermissionSet3 in m_namedPermissionSets)
			{
				if (namedPermissionSet3.Name.Equals(name))
				{
					return namedPermissionSet3;
				}
			}
			if (m_permSetElement != null)
			{
				SecurityElement securityElement = FindElement(m_permSetElement, name);
				if (securityElement != null)
				{
					NamedPermissionSet namedPermissionSet2 = new NamedPermissionSet();
					namedPermissionSet2.Name = name;
					m_namedPermissionSets.Add(namedPermissionSet2);
					try
					{
						namedPermissionSet2.FromXml(securityElement, allowInternalOnly: false, ignoreTypeLoadFailures: true);
					}
					catch
					{
						m_namedPermissionSets.Remove(namedPermissionSet2);
						return null;
					}
					if (namedPermissionSet2.Name != null)
					{
						return namedPermissionSet2;
					}
					m_namedPermissionSets.Remove(namedPermissionSet2);
				}
			}
		}
		return null;
	}

	[SecurityCritical]
	internal PolicyStatement Resolve(Evidence evidence, int count, byte[] serializedEvidence)
	{
		if (evidence == null)
		{
			throw new ArgumentNullException("evidence");
		}
		PolicyStatement policyStatement = null;
		if (serializedEvidence != null)
		{
			policyStatement = CheckCache(count, serializedEvidence);
		}
		if (policyStatement == null)
		{
			CheckLoaded();
			bool allConst;
			if (m_fullTrustAssemblies != null && IsFullTrustAssembly(m_fullTrustAssemblies, evidence))
			{
				policyStatement = new PolicyStatement(new PermissionSet(fUnrestricted: true), PolicyStatementAttribute.Nothing);
				allConst = true;
			}
			else
			{
				ArrayList arrayList = GenericResolve(evidence, out allConst);
				policyStatement = new PolicyStatement();
				policyStatement.PermissionSet = null;
				IEnumerator enumerator = arrayList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					PolicyStatement policy = ((CodeGroupStackFrame)enumerator.Current).policy;
					if (policy == null)
					{
						continue;
					}
					policyStatement.GetPermissionSetNoCopy().InplaceUnion(policy.GetPermissionSetNoCopy());
					policyStatement.Attributes |= policy.Attributes;
					if (!policy.HasDependentEvidence)
					{
						continue;
					}
					foreach (IDelayEvaluatedEvidence item in policy.DependentEvidence)
					{
						item.MarkUsed();
					}
				}
			}
			if (allConst)
			{
				Cache(count, evidence.RawSerialize(), policyStatement);
			}
		}
		return policyStatement;
	}

	[SecurityCritical]
	private void CheckLoaded()
	{
		if (m_loaded)
		{
			return;
		}
		lock (InternalSyncObject)
		{
			if (!m_loaded)
			{
				LoadPolicyLevel();
			}
		}
	}

	private static byte[] ReadFile(string fileName)
	{
		using FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
		int num = (int)fileStream.Length;
		byte[] array = new byte[num];
		num = fileStream.Read(array, 0, num);
		fileStream.Close();
		return array;
	}

	[SecurityCritical]
	private void LoadPolicyLevel()
	{
		Exception ex = null;
		CodeAccessPermission.Assert(allPossible: true);
		if (File.InternalExists(m_path))
		{
			Encoding uTF = Encoding.UTF8;
			SecurityElement securityElement;
			try
			{
				string xml = uTF.GetString(ReadFile(m_path));
				securityElement = SecurityElement.FromString(xml);
			}
			catch (Exception ex2)
			{
				string text = (string.IsNullOrEmpty(ex2.Message) ? ex2.GetType().AssemblyQualifiedName : ex2.Message);
				ex = LoadError(Environment.GetResourceString("Error_SecurityPolicyFileParseEx", Label, text));
				goto IL_01bd;
			}
			if (securityElement == null)
			{
				ex = LoadError(Environment.GetResourceString("Error_SecurityPolicyFileParse", Label));
			}
			else
			{
				SecurityElement securityElement2 = securityElement.SearchForChildByTag("mscorlib");
				if (securityElement2 == null)
				{
					ex = LoadError(Environment.GetResourceString("Error_SecurityPolicyFileParse", Label));
				}
				else
				{
					SecurityElement securityElement3 = securityElement2.SearchForChildByTag("security");
					if (securityElement3 == null)
					{
						ex = LoadError(Environment.GetResourceString("Error_SecurityPolicyFileParse", Label));
					}
					else
					{
						SecurityElement securityElement4 = securityElement3.SearchForChildByTag("policy");
						if (securityElement4 == null)
						{
							ex = LoadError(Environment.GetResourceString("Error_SecurityPolicyFileParse", Label));
						}
						else
						{
							SecurityElement securityElement5 = securityElement4.SearchForChildByTag("PolicyLevel");
							if (securityElement5 != null)
							{
								try
								{
									FromXml(securityElement5);
								}
								catch (Exception)
								{
									ex = LoadError(Environment.GetResourceString("Error_SecurityPolicyFileParse", Label));
									goto IL_01bd;
								}
								m_loaded = true;
								return;
							}
							ex = LoadError(Environment.GetResourceString("Error_SecurityPolicyFileParse", Label));
						}
					}
				}
			}
		}
		goto IL_01bd;
		IL_01bd:
		SetDefault();
		m_loaded = true;
		if (ex != null)
		{
			throw ex;
		}
	}

	[SecurityCritical]
	private Exception LoadError(string message)
	{
		if (m_type != PolicyLevelType.User && m_type != PolicyLevelType.Machine && m_type != PolicyLevelType.Enterprise)
		{
			return new ArgumentException(message);
		}
		Config.WriteToEventLog(message);
		return null;
	}

	[SecurityCritical]
	private void Cache(int count, byte[] serializedEvidence, PolicyStatement policy)
	{
		if (m_configId != ConfigId.None && serializedEvidence != null)
		{
			byte[] data = new SecurityDocument(policy.ToXml(null, useInternal: true)).m_data;
			Config.AddCacheEntry(m_configId, count, serializedEvidence, data);
		}
	}

	[SecurityCritical]
	private PolicyStatement CheckCache(int count, byte[] serializedEvidence)
	{
		if (m_configId == ConfigId.None)
		{
			return null;
		}
		if (serializedEvidence == null)
		{
			return null;
		}
		if (!Config.GetCacheEntry(m_configId, count, serializedEvidence, out var data))
		{
			return null;
		}
		PolicyStatement policyStatement = new PolicyStatement();
		SecurityDocument doc = new SecurityDocument(data);
		policyStatement.FromXml(doc, 0, null, allowInternalOnly: true);
		return policyStatement;
	}

	[SecurityCritical]
	private static bool IsFullTrustAssembly(ArrayList fullTrustAssemblies, Evidence evidence)
	{
		if (fullTrustAssemblies.Count == 0)
		{
			return false;
		}
		if (evidence != null)
		{
			lock (fullTrustAssemblies)
			{
				IEnumerator enumerator = fullTrustAssemblies.GetEnumerator();
				while (enumerator.MoveNext())
				{
					StrongNameMembershipCondition strongNameMembershipCondition = (StrongNameMembershipCondition)enumerator.Current;
					if (!strongNameMembershipCondition.Check(evidence))
					{
						continue;
					}
					if (Environment.GetCompatibilityFlag(CompatibilityFlag.FullTrustListAssembliesInGac))
					{
						if (new ZoneMembershipCondition().Check(evidence))
						{
							return true;
						}
					}
					else if (new GacMembershipCondition().Check(evidence))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private CodeGroup CreateDefaultAllGroup()
	{
		UnionCodeGroup unionCodeGroup = new UnionCodeGroup();
		unionCodeGroup.FromXml(CreateCodeGroupElement("UnionCodeGroup", "FullTrust", new AllMembershipCondition().ToXml()), this);
		unionCodeGroup.Name = Environment.GetResourceString("Policy_AllCode_Name");
		unionCodeGroup.Description = Environment.GetResourceString("Policy_AllCode_DescriptionFullTrust");
		return unionCodeGroup;
	}

	[SecurityCritical]
	private CodeGroup CreateDefaultMachinePolicy()
	{
		UnionCodeGroup unionCodeGroup = new UnionCodeGroup();
		unionCodeGroup.FromXml(CreateCodeGroupElement("UnionCodeGroup", "Nothing", new AllMembershipCondition().ToXml()), this);
		unionCodeGroup.Name = Environment.GetResourceString("Policy_AllCode_Name");
		unionCodeGroup.Description = Environment.GetResourceString("Policy_AllCode_DescriptionNothing");
		UnionCodeGroup unionCodeGroup2 = new UnionCodeGroup();
		unionCodeGroup2.FromXml(CreateCodeGroupElement("UnionCodeGroup", "FullTrust", new ZoneMembershipCondition(SecurityZone.MyComputer).ToXml()), this);
		unionCodeGroup2.Name = Environment.GetResourceString("Policy_MyComputer_Name");
		unionCodeGroup2.Description = Environment.GetResourceString("Policy_MyComputer_Description");
		StrongNamePublicKeyBlob blob = new StrongNamePublicKeyBlob("002400000480000094000000060200000024000052534131000400000100010007D1FA57C4AED9F0A32E84AA0FAEFD0DE9E8FD6AEC8F87FB03766C834C99921EB23BE79AD9D5DCC1DD9AD236132102900B723CF980957FC4E177108FC607774F29E8320E92EA05ECE4E821C0A5EFE8F1645C4C0C93C1AB99285D622CAA652C1DFAD63D745D6F2DE5F17E5EAF0FC4963D261C8A12436518206DC093344D5AD293");
		UnionCodeGroup unionCodeGroup3 = new UnionCodeGroup();
		unionCodeGroup3.FromXml(CreateCodeGroupElement("UnionCodeGroup", "FullTrust", new StrongNameMembershipCondition(blob, null, null).ToXml()), this);
		unionCodeGroup3.Name = Environment.GetResourceString("Policy_Microsoft_Name");
		unionCodeGroup3.Description = Environment.GetResourceString("Policy_Microsoft_Description");
		unionCodeGroup2.AddChildInternal(unionCodeGroup3);
		blob = new StrongNamePublicKeyBlob("00000000000000000400000000000000");
		UnionCodeGroup unionCodeGroup4 = new UnionCodeGroup();
		unionCodeGroup4.FromXml(CreateCodeGroupElement("UnionCodeGroup", "FullTrust", new StrongNameMembershipCondition(blob, null, null).ToXml()), this);
		unionCodeGroup4.Name = Environment.GetResourceString("Policy_Ecma_Name");
		unionCodeGroup4.Description = Environment.GetResourceString("Policy_Ecma_Description");
		unionCodeGroup2.AddChildInternal(unionCodeGroup4);
		unionCodeGroup.AddChildInternal(unionCodeGroup2);
		CodeGroup codeGroup = new UnionCodeGroup();
		codeGroup.FromXml(CreateCodeGroupElement("UnionCodeGroup", "LocalIntranet", new ZoneMembershipCondition(SecurityZone.Intranet).ToXml()), this);
		codeGroup.Name = Environment.GetResourceString("Policy_Intranet_Name");
		codeGroup.Description = Environment.GetResourceString("Policy_Intranet_Description");
		CodeGroup codeGroup2 = new NetCodeGroup(new AllMembershipCondition());
		codeGroup2.Name = Environment.GetResourceString("Policy_IntranetNet_Name");
		codeGroup2.Description = Environment.GetResourceString("Policy_IntranetNet_Description");
		codeGroup.AddChildInternal(codeGroup2);
		CodeGroup codeGroup3 = new FileCodeGroup(new AllMembershipCondition(), FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery);
		codeGroup3.Name = Environment.GetResourceString("Policy_IntranetFile_Name");
		codeGroup3.Description = Environment.GetResourceString("Policy_IntranetFile_Description");
		codeGroup.AddChildInternal(codeGroup3);
		unionCodeGroup.AddChildInternal(codeGroup);
		CodeGroup codeGroup4 = new UnionCodeGroup();
		codeGroup4.FromXml(CreateCodeGroupElement("UnionCodeGroup", "Internet", new ZoneMembershipCondition(SecurityZone.Internet).ToXml()), this);
		codeGroup4.Name = Environment.GetResourceString("Policy_Internet_Name");
		codeGroup4.Description = Environment.GetResourceString("Policy_Internet_Description");
		CodeGroup codeGroup5 = new NetCodeGroup(new AllMembershipCondition());
		codeGroup5.Name = Environment.GetResourceString("Policy_InternetNet_Name");
		codeGroup5.Description = Environment.GetResourceString("Policy_InternetNet_Description");
		codeGroup4.AddChildInternal(codeGroup5);
		unionCodeGroup.AddChildInternal(codeGroup4);
		CodeGroup codeGroup6 = new UnionCodeGroup();
		codeGroup6.FromXml(CreateCodeGroupElement("UnionCodeGroup", "Nothing", new ZoneMembershipCondition(SecurityZone.Untrusted).ToXml()), this);
		codeGroup6.Name = Environment.GetResourceString("Policy_Untrusted_Name");
		codeGroup6.Description = Environment.GetResourceString("Policy_Untrusted_Description");
		unionCodeGroup.AddChildInternal(codeGroup6);
		CodeGroup codeGroup7 = new UnionCodeGroup();
		codeGroup7.FromXml(CreateCodeGroupElement("UnionCodeGroup", "Internet", new ZoneMembershipCondition(SecurityZone.Trusted).ToXml()), this);
		codeGroup7.Name = Environment.GetResourceString("Policy_Trusted_Name");
		codeGroup7.Description = Environment.GetResourceString("Policy_Trusted_Description");
		CodeGroup codeGroup8 = new NetCodeGroup(new AllMembershipCondition());
		codeGroup8.Name = Environment.GetResourceString("Policy_TrustedNet_Name");
		codeGroup8.Description = Environment.GetResourceString("Policy_TrustedNet_Description");
		codeGroup7.AddChildInternal(codeGroup8);
		unionCodeGroup.AddChildInternal(codeGroup7);
		return unionCodeGroup;
	}

	private static SecurityElement CreateCodeGroupElement(string codeGroupType, string permissionSetName, SecurityElement mshipElement)
	{
		SecurityElement securityElement = new SecurityElement("CodeGroup");
		securityElement.AddAttribute("class", "System.Security." + codeGroupType + ", mscorlib, Version={VERSION}, Culture=neutral, PublicKeyToken=b77a5c561934e089");
		securityElement.AddAttribute("version", "1");
		securityElement.AddAttribute("PermissionSetName", permissionSetName);
		securityElement.AddChild(mshipElement);
		return securityElement;
	}

	private void SetDefaultFullTrustAssemblies()
	{
		m_fullTrustAssemblies = new ArrayList();
		StrongNamePublicKeyBlob blob = new StrongNamePublicKeyBlob("00000000000000000400000000000000");
		for (int i = 0; i < EcmaFullTrustAssemblies.Length; i++)
		{
			StrongNameMembershipCondition value = new StrongNameMembershipCondition(blob, EcmaFullTrustAssemblies[i], new Version("4.0.0.0"));
			m_fullTrustAssemblies.Add(value);
		}
		StrongNamePublicKeyBlob blob2 = new StrongNamePublicKeyBlob("002400000480000094000000060200000024000052534131000400000100010007D1FA57C4AED9F0A32E84AA0FAEFD0DE9E8FD6AEC8F87FB03766C834C99921EB23BE79AD9D5DCC1DD9AD236132102900B723CF980957FC4E177108FC607774F29E8320E92EA05ECE4E821C0A5EFE8F1645C4C0C93C1AB99285D622CAA652C1DFAD63D745D6F2DE5F17E5EAF0FC4963D261C8A12436518206DC093344D5AD293");
		for (int j = 0; j < MicrosoftFullTrustAssemblies.Length; j++)
		{
			StrongNameMembershipCondition value2 = new StrongNameMembershipCondition(blob2, MicrosoftFullTrustAssemblies[j], new Version("4.0.0.0"));
			m_fullTrustAssemblies.Add(value2);
		}
	}

	[SecurityCritical]
	private void SetDefault()
	{
		lock (this)
		{
			string path = GetLocationFromType(m_type) + ".default";
			if (File.InternalExists(path))
			{
				PolicyLevel policyLevel = new PolicyLevel(m_type, path);
				m_rootCodeGroup = policyLevel.RootCodeGroup;
				m_namedPermissionSets = (ArrayList)policyLevel.NamedPermissionSets;
				m_fullTrustAssemblies = (ArrayList)policyLevel.FullTrustAssemblies;
				m_loaded = true;
			}
			else
			{
				m_namedPermissionSets = null;
				m_rootCodeGroup = null;
				m_permSetElement = null;
				m_rootCodeGroup = ((m_type == PolicyLevelType.Machine) ? CreateDefaultMachinePolicy() : CreateDefaultAllGroup());
				SetFactoryPermissionSets();
				SetDefaultFullTrustAssemblies();
				m_loaded = true;
			}
		}
	}

	private void SetFactoryPermissionSets()
	{
		lock (InternalSyncObject)
		{
			m_namedPermissionSets = new ArrayList();
			m_namedPermissionSets.Add(BuiltInPermissionSets.FullTrust);
			m_namedPermissionSets.Add(BuiltInPermissionSets.Everything);
			m_namedPermissionSets.Add(BuiltInPermissionSets.Nothing);
			m_namedPermissionSets.Add(BuiltInPermissionSets.SkipVerification);
			m_namedPermissionSets.Add(BuiltInPermissionSets.Execution);
			m_namedPermissionSets.Add(BuiltInPermissionSets.Internet);
			m_namedPermissionSets.Add(BuiltInPermissionSets.LocalIntranet);
		}
	}

	private SecurityElement FindElement(SecurityElement element, string name)
	{
		IEnumerator enumerator = element.Children.GetEnumerator();
		while (enumerator.MoveNext())
		{
			SecurityElement securityElement = (SecurityElement)enumerator.Current;
			if (securityElement.Tag.Equals("PermissionSet"))
			{
				string text = securityElement.Attribute("Name");
				if (text != null && text.Equals(name))
				{
					element.InternalChildren.Remove(securityElement);
					return securityElement;
				}
			}
		}
		return null;
	}

	[SecurityCritical]
	private void LoadAllPermissionSets()
	{
		if (m_permSetElement == null || m_permSetElement.InternalChildren == null)
		{
			return;
		}
		lock (InternalSyncObject)
		{
			while (m_permSetElement != null && m_permSetElement.InternalChildren.Count != 0)
			{
				SecurityElement securityElement = (SecurityElement)m_permSetElement.Children[m_permSetElement.InternalChildren.Count - 1];
				m_permSetElement.InternalChildren.RemoveAt(m_permSetElement.InternalChildren.Count - 1);
				if (!securityElement.Tag.Equals("PermissionSet") || !securityElement.Attribute("class").Equals("System.Security.NamedPermissionSet"))
				{
					continue;
				}
				NamedPermissionSet namedPermissionSet = new NamedPermissionSet();
				namedPermissionSet.FromXmlNameOnly(securityElement);
				if (namedPermissionSet.Name != null)
				{
					m_namedPermissionSets.Add(namedPermissionSet);
					try
					{
						namedPermissionSet.FromXml(securityElement, allowInternalOnly: false, ignoreTypeLoadFailures: true);
					}
					catch
					{
						m_namedPermissionSets.Remove(namedPermissionSet);
					}
				}
			}
			m_permSetElement = null;
		}
	}

	[SecurityCritical]
	private ArrayList GenericResolve(Evidence evidence, out bool allConst)
	{
		CodeGroupStack codeGroupStack = new CodeGroupStack();
		CodeGroup rootCodeGroup = m_rootCodeGroup;
		if (rootCodeGroup == null)
		{
			throw new PolicyException(Environment.GetResourceString("Policy_NonFullTrustAssembly"));
		}
		CodeGroupStackFrame codeGroupStackFrame = new CodeGroupStackFrame();
		codeGroupStackFrame.current = rootCodeGroup;
		codeGroupStackFrame.parent = null;
		codeGroupStack.Push(codeGroupStackFrame);
		ArrayList arrayList = new ArrayList();
		bool flag = false;
		allConst = true;
		Exception ex = null;
		while (!codeGroupStack.IsEmpty())
		{
			codeGroupStackFrame = codeGroupStack.Pop();
			FirstMatchCodeGroup firstMatchCodeGroup = codeGroupStackFrame.current as FirstMatchCodeGroup;
			UnionCodeGroup unionCodeGroup = codeGroupStackFrame.current as UnionCodeGroup;
			if (!(codeGroupStackFrame.current.MembershipCondition is IConstantMembershipCondition) || (unionCodeGroup == null && firstMatchCodeGroup == null))
			{
				allConst = false;
			}
			try
			{
				codeGroupStackFrame.policy = PolicyManager.ResolveCodeGroup(codeGroupStackFrame.current, evidence);
			}
			catch (Exception ex2)
			{
				if (ex == null)
				{
					ex = ex2;
				}
			}
			if (codeGroupStackFrame.policy == null)
			{
				continue;
			}
			if ((codeGroupStackFrame.policy.Attributes & PolicyStatementAttribute.Exclusive) != PolicyStatementAttribute.Nothing)
			{
				if (flag)
				{
					throw new PolicyException(Environment.GetResourceString("Policy_MultipleExclusive"));
				}
				arrayList.RemoveRange(0, arrayList.Count);
				arrayList.Add(codeGroupStackFrame);
				flag = true;
			}
			if (!flag)
			{
				arrayList.Add(codeGroupStackFrame);
			}
		}
		if (ex != null)
		{
			throw ex;
		}
		return arrayList;
	}

	private static string GenerateFriendlyName(string className, Hashtable classes)
	{
		if (classes.ContainsKey(className))
		{
			return (string)classes[className];
		}
		Type type = System.Type.GetType(className, throwOnError: false, ignoreCase: false);
		if (type != null && !type.IsVisible)
		{
			type = null;
		}
		if (type == null)
		{
			return className;
		}
		if (!classes.ContainsValue(type.Name))
		{
			classes.Add(className, type.Name);
			return type.Name;
		}
		if (!classes.ContainsValue(type.FullName))
		{
			classes.Add(className, type.FullName);
			return type.FullName;
		}
		classes.Add(className, type.AssemblyQualifiedName);
		return type.AssemblyQualifiedName;
	}

	private SecurityElement NormalizeClassDeep(SecurityElement elem, Hashtable classes)
	{
		NormalizeClass(elem, classes);
		if (elem.InternalChildren != null && elem.InternalChildren.Count > 0)
		{
			IEnumerator enumerator = elem.Children.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NormalizeClassDeep((SecurityElement)enumerator.Current, classes);
			}
		}
		return elem;
	}

	private SecurityElement NormalizeClass(SecurityElement elem, Hashtable classes)
	{
		if (elem.m_lAttributes == null || elem.m_lAttributes.Count == 0)
		{
			return elem;
		}
		int count = elem.m_lAttributes.Count;
		for (int i = 0; i < count; i += 2)
		{
			string text = (string)elem.m_lAttributes[i];
			if (text.Equals("class"))
			{
				string className = (string)elem.m_lAttributes[i + 1];
				elem.m_lAttributes[i + 1] = GenerateFriendlyName(className, classes);
				break;
			}
		}
		return elem;
	}

	private SecurityElement UnnormalizeClassDeep(SecurityElement elem, Hashtable classes)
	{
		UnnormalizeClass(elem, classes);
		if (elem.InternalChildren != null && elem.InternalChildren.Count > 0)
		{
			IEnumerator enumerator = elem.Children.GetEnumerator();
			while (enumerator.MoveNext())
			{
				UnnormalizeClassDeep((SecurityElement)enumerator.Current, classes);
			}
		}
		return elem;
	}

	private SecurityElement UnnormalizeClass(SecurityElement elem, Hashtable classes)
	{
		if (classes == null || elem.m_lAttributes == null || elem.m_lAttributes.Count == 0)
		{
			return elem;
		}
		int count = elem.m_lAttributes.Count;
		for (int i = 0; i < count; i += 2)
		{
			string text = (string)elem.m_lAttributes[i];
			if (text.Equals("class"))
			{
				string key = (string)elem.m_lAttributes[i + 1];
				string text2 = (string)classes[key];
				if (text2 != null)
				{
					elem.m_lAttributes[i + 1] = text2;
				}
				break;
			}
		}
		return elem;
	}
}
