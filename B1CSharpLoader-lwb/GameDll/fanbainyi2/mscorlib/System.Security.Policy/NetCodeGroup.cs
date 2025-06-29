using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class NetCodeGroup : CodeGroup, IUnionSemanticCodeGroup
{
	[OptionalField(VersionAdded = 2)]
	private ArrayList m_schemesList;

	[OptionalField(VersionAdded = 2)]
	private ArrayList m_accessList;

	private const string c_IgnoreUserInfo = "";

	private const string c_AnyScheme = "([0-9a-z+\\-\\.]+)://";

	private static readonly char[] c_SomeRegexChars = new char[12]
	{
		'.', '-', '+', '[', ']', '{', '$', '^', '#', ')',
		'(', ' '
	};

	public static readonly string AnyOtherOriginScheme = CodeConnectAccess.AnyScheme;

	public static readonly string AbsentOriginScheme = string.Empty;

	public override string MergeLogic => Environment.GetResourceString("MergeLogic_Union");

	public override string PermissionSetName => Environment.GetResourceString("NetCodeGroup_PermissionSet");

	public override string AttributeString => null;

	[SecurityCritical]
	[Conditional("_DEBUG")]
	private static void DEBUG_OUT(string str)
	{
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
		m_schemesList = null;
		m_accessList = null;
	}

	internal NetCodeGroup()
	{
		SetDefaults();
	}

	public NetCodeGroup(IMembershipCondition membershipCondition)
		: base(membershipCondition, (PolicyStatement)null)
	{
		SetDefaults();
	}

	public void ResetConnectAccess()
	{
		m_schemesList = null;
		m_accessList = null;
	}

	public void AddConnectAccess(string originScheme, CodeConnectAccess connectAccess)
	{
		if (originScheme == null)
		{
			throw new ArgumentNullException("originScheme");
		}
		if (originScheme != AbsentOriginScheme && originScheme != AnyOtherOriginScheme && !CodeConnectAccess.IsValidScheme(originScheme))
		{
			throw new ArgumentOutOfRangeException("originScheme");
		}
		if (originScheme == AbsentOriginScheme && connectAccess.IsOriginScheme)
		{
			throw new ArgumentOutOfRangeException("connectAccess");
		}
		if (m_schemesList == null)
		{
			m_schemesList = new ArrayList();
			m_accessList = new ArrayList();
		}
		originScheme = originScheme.ToLower(CultureInfo.InvariantCulture);
		for (int i = 0; i < m_schemesList.Count; i++)
		{
			if (!((string)m_schemesList[i] == originScheme))
			{
				continue;
			}
			if (connectAccess == null)
			{
				return;
			}
			ArrayList arrayList = (ArrayList)m_accessList[i];
			for (i = 0; i < arrayList.Count; i++)
			{
				if (((CodeConnectAccess)arrayList[i]).Equals(connectAccess))
				{
					return;
				}
			}
			arrayList.Add(connectAccess);
			return;
		}
		m_schemesList.Add(originScheme);
		ArrayList arrayList2 = new ArrayList();
		m_accessList.Add(arrayList2);
		if (connectAccess != null)
		{
			arrayList2.Add(connectAccess);
		}
	}

	public DictionaryEntry[] GetConnectAccessRules()
	{
		if (m_schemesList == null)
		{
			return null;
		}
		DictionaryEntry[] array = new DictionaryEntry[m_schemesList.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Key = m_schemesList[i];
			array[i].Value = ((ArrayList)m_accessList[i]).ToArray(typeof(CodeConnectAccess));
		}
		return array;
	}

	[SecuritySafeCritical]
	public override PolicyStatement Resolve(Evidence evidence)
	{
		if (evidence == null)
		{
			throw new ArgumentNullException("evidence");
		}
		object usedEvidence = null;
		if (PolicyManager.CheckMembershipCondition(base.MembershipCondition, evidence, out usedEvidence))
		{
			PolicyStatement policyStatement = CalculateAssemblyPolicy(evidence);
			if (usedEvidence is IDelayEvaluatedEvidence { IsVerified: false } delayEvaluatedEvidence)
			{
				policyStatement.AddDependentEvidence(delayEvaluatedEvidence);
			}
			bool flag = false;
			IEnumerator enumerator = base.Children.GetEnumerator();
			while (enumerator.MoveNext() && !flag)
			{
				PolicyStatement policyStatement2 = PolicyManager.ResolveCodeGroup(enumerator.Current as CodeGroup, evidence);
				if (policyStatement2 != null)
				{
					policyStatement.InplaceUnion(policyStatement2);
					if ((policyStatement2.Attributes & PolicyStatementAttribute.Exclusive) == PolicyStatementAttribute.Exclusive)
					{
						flag = true;
					}
				}
			}
			return policyStatement;
		}
		return null;
	}

	PolicyStatement IUnionSemanticCodeGroup.InternalResolve(Evidence evidence)
	{
		if (evidence == null)
		{
			throw new ArgumentNullException("evidence");
		}
		if (base.MembershipCondition.Check(evidence))
		{
			return CalculateAssemblyPolicy(evidence);
		}
		return null;
	}

	public override CodeGroup ResolveMatchingCodeGroups(Evidence evidence)
	{
		if (evidence == null)
		{
			throw new ArgumentNullException("evidence");
		}
		if (base.MembershipCondition.Check(evidence))
		{
			CodeGroup codeGroup = Copy();
			codeGroup.Children = new ArrayList();
			IEnumerator enumerator = base.Children.GetEnumerator();
			while (enumerator.MoveNext())
			{
				CodeGroup codeGroup2 = ((CodeGroup)enumerator.Current).ResolveMatchingCodeGroups(evidence);
				if (codeGroup2 != null)
				{
					codeGroup.AddChild(codeGroup2);
				}
			}
			return codeGroup;
		}
		return null;
	}

	private string EscapeStringForRegex(string str)
	{
		int num = 0;
		StringBuilder stringBuilder = null;
		int num2;
		while (num < str.Length && (num2 = str.IndexOfAny(c_SomeRegexChars, num)) != -1)
		{
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder(str.Length * 2);
			}
			stringBuilder.Append(str, num, num2 - num).Append('\\').Append(str[num2]);
			num = num2 + 1;
		}
		if (stringBuilder == null)
		{
			return str;
		}
		if (num < str.Length)
		{
			stringBuilder.Append(str, num, str.Length - num);
		}
		return stringBuilder.ToString();
	}

	internal SecurityElement CreateWebPermission(string host, string scheme, string port, string assemblyOverride)
	{
		if (scheme == null)
		{
			scheme = string.Empty;
		}
		if (host == null || host.Length == 0)
		{
			return null;
		}
		host = host.ToLower(CultureInfo.InvariantCulture);
		scheme = scheme.ToLower(CultureInfo.InvariantCulture);
		int intPort = -1;
		if (port != null && port.Length != 0)
		{
			intPort = int.Parse(port, CultureInfo.InvariantCulture);
		}
		else
		{
			port = string.Empty;
		}
		CodeConnectAccess[] array = FindAccessRulesForScheme(scheme);
		if (array == null || array.Length == 0)
		{
			return null;
		}
		SecurityElement securityElement = new SecurityElement("IPermission");
		string text = ((assemblyOverride == null) ? "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" : assemblyOverride);
		securityElement.AddAttribute("class", "System.Net.WebPermission, " + text);
		securityElement.AddAttribute("version", "1");
		SecurityElement securityElement2 = new SecurityElement("ConnectAccess");
		host = EscapeStringForRegex(host);
		scheme = EscapeStringForRegex(scheme);
		string text2 = TryPermissionAsOneString(array, scheme, host, intPort);
		if (text2 != null)
		{
			SecurityElement securityElement3 = new SecurityElement("URI");
			securityElement3.AddAttribute("uri", text2);
			securityElement2.AddChild(securityElement3);
		}
		else
		{
			if (port.Length != 0)
			{
				port = ":" + port;
			}
			for (int i = 0; i < array.Length; i++)
			{
				text2 = GetPermissionAccessElementString(array[i], scheme, host, port);
				SecurityElement securityElement4 = new SecurityElement("URI");
				securityElement4.AddAttribute("uri", text2);
				securityElement2.AddChild(securityElement4);
			}
		}
		securityElement.AddChild(securityElement2);
		return securityElement;
	}

	private CodeConnectAccess[] FindAccessRulesForScheme(string lowerCaseScheme)
	{
		if (m_schemesList == null)
		{
			return null;
		}
		int num = m_schemesList.IndexOf(lowerCaseScheme);
		if (num == -1 && (lowerCaseScheme == AbsentOriginScheme || (num = m_schemesList.IndexOf(AnyOtherOriginScheme)) == -1))
		{
			return null;
		}
		ArrayList arrayList = (ArrayList)m_accessList[num];
		return (CodeConnectAccess[])arrayList.ToArray(typeof(CodeConnectAccess));
	}

	private string TryPermissionAsOneString(CodeConnectAccess[] access, string escapedScheme, string escapedHost, int intPort)
	{
		bool flag = true;
		bool flag2 = true;
		bool flag3 = false;
		int num = -2;
		for (int i = 0; i < access.Length; i++)
		{
			flag &= access[i].IsDefaultPort || (access[i].IsOriginPort && intPort == -1);
			flag2 &= access[i].IsOriginPort || access[i].Port == intPort;
			if (access[i].Port >= 0)
			{
				if (num == -2)
				{
					num = access[i].Port;
				}
				else if (access[i].Port != num)
				{
					num = -1;
				}
			}
			else
			{
				num = -1;
			}
			if (access[i].IsAnyScheme)
			{
				flag3 = true;
			}
		}
		if (!flag && !flag2 && num == -1)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder("([0-9a-z+\\-\\.]+)://".Length * access.Length + "".Length * 2 + escapedHost.Length);
		if (flag3)
		{
			stringBuilder.Append("([0-9a-z+\\-\\.]+)://");
		}
		else
		{
			stringBuilder.Append('(');
			for (int j = 0; j < access.Length; j++)
			{
				int k;
				for (k = 0; k < j && !(access[j].Scheme == access[k].Scheme); k++)
				{
				}
				if (k == j)
				{
					if (j != 0)
					{
						stringBuilder.Append('|');
					}
					stringBuilder.Append(access[j].IsOriginScheme ? escapedScheme : EscapeStringForRegex(access[j].Scheme));
				}
			}
			stringBuilder.Append(")://");
		}
		stringBuilder.Append("").Append(escapedHost);
		if (!flag)
		{
			if (flag2)
			{
				stringBuilder.Append(':').Append(intPort);
			}
			else
			{
				stringBuilder.Append(':').Append(num);
			}
		}
		stringBuilder.Append("/.*");
		return stringBuilder.ToString();
	}

	private string GetPermissionAccessElementString(CodeConnectAccess access, string escapedScheme, string escapedHost, string strPort)
	{
		StringBuilder stringBuilder = new StringBuilder("([0-9a-z+\\-\\.]+)://".Length * 2 + "".Length + escapedHost.Length);
		if (access.IsAnyScheme)
		{
			stringBuilder.Append("([0-9a-z+\\-\\.]+)://");
		}
		else if (access.IsOriginScheme)
		{
			stringBuilder.Append(escapedScheme).Append("://");
		}
		else
		{
			stringBuilder.Append(EscapeStringForRegex(access.Scheme)).Append("://");
		}
		stringBuilder.Append("").Append(escapedHost);
		if (!access.IsDefaultPort)
		{
			if (access.IsOriginPort)
			{
				stringBuilder.Append(strPort);
			}
			else
			{
				stringBuilder.Append(':').Append(access.StrPort);
			}
		}
		stringBuilder.Append("/.*");
		return stringBuilder.ToString();
	}

	internal PolicyStatement CalculatePolicy(string host, string scheme, string port)
	{
		SecurityElement securityElement = CreateWebPermission(host, scheme, port, null);
		SecurityElement securityElement2 = new SecurityElement("PolicyStatement");
		SecurityElement securityElement3 = new SecurityElement("PermissionSet");
		securityElement3.AddAttribute("class", "System.Security.PermissionSet");
		securityElement3.AddAttribute("version", "1");
		if (securityElement != null)
		{
			securityElement3.AddChild(securityElement);
		}
		securityElement2.AddChild(securityElement3);
		PolicyStatement policyStatement = new PolicyStatement();
		policyStatement.FromXml(securityElement2);
		return policyStatement;
	}

	private PolicyStatement CalculateAssemblyPolicy(Evidence evidence)
	{
		PolicyStatement policyStatement = null;
		Url hostEvidence = evidence.GetHostEvidence<Url>();
		if (hostEvidence != null)
		{
			policyStatement = CalculatePolicy(hostEvidence.GetURLString().Host, hostEvidence.GetURLString().Scheme, hostEvidence.GetURLString().Port);
		}
		if (policyStatement == null)
		{
			Site hostEvidence2 = evidence.GetHostEvidence<Site>();
			if (hostEvidence2 != null)
			{
				policyStatement = CalculatePolicy(hostEvidence2.Name, null, null);
			}
		}
		if (policyStatement == null)
		{
			policyStatement = new PolicyStatement(new PermissionSet(fUnrestricted: false), PolicyStatementAttribute.Nothing);
		}
		return policyStatement;
	}

	public override CodeGroup Copy()
	{
		NetCodeGroup netCodeGroup = new NetCodeGroup(base.MembershipCondition);
		netCodeGroup.Name = base.Name;
		netCodeGroup.Description = base.Description;
		if (m_schemesList != null)
		{
			netCodeGroup.m_schemesList = (ArrayList)m_schemesList.Clone();
			netCodeGroup.m_accessList = new ArrayList(m_accessList.Count);
			for (int i = 0; i < m_accessList.Count; i++)
			{
				netCodeGroup.m_accessList.Add(((ArrayList)m_accessList[i]).Clone());
			}
		}
		IEnumerator enumerator = base.Children.GetEnumerator();
		while (enumerator.MoveNext())
		{
			netCodeGroup.AddChild((CodeGroup)enumerator.Current);
		}
		return netCodeGroup;
	}

	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (!(o is NetCodeGroup netCodeGroup) || !base.Equals((object)netCodeGroup))
		{
			return false;
		}
		if (m_schemesList == null != (netCodeGroup.m_schemesList == null))
		{
			return false;
		}
		if (m_schemesList == null)
		{
			return true;
		}
		if (m_schemesList.Count != netCodeGroup.m_schemesList.Count)
		{
			return false;
		}
		for (int i = 0; i < m_schemesList.Count; i++)
		{
			int num = netCodeGroup.m_schemesList.IndexOf(m_schemesList[i]);
			if (num == -1)
			{
				return false;
			}
			ArrayList arrayList = (ArrayList)m_accessList[i];
			ArrayList arrayList2 = (ArrayList)netCodeGroup.m_accessList[num];
			if (arrayList.Count != arrayList2.Count)
			{
				return false;
			}
			for (int j = 0; j < arrayList.Count; j++)
			{
				if (!arrayList2.Contains(arrayList[j]))
				{
					return false;
				}
			}
		}
		return true;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode() + GetRulesHashCode();
	}

	private int GetRulesHashCode()
	{
		if (m_schemesList == null)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < m_schemesList.Count; i++)
		{
			num += ((string)m_schemesList[i]).GetHashCode();
		}
		foreach (ArrayList access in m_accessList)
		{
			for (int j = 0; j < access.Count; j++)
			{
				num += ((CodeConnectAccess)access[j]).GetHashCode();
			}
		}
		return num;
	}

	protected override void CreateXml(SecurityElement element, PolicyLevel level)
	{
		DictionaryEntry[] connectAccessRules = GetConnectAccessRules();
		if (connectAccessRules == null)
		{
			return;
		}
		SecurityElement securityElement = new SecurityElement("connectAccessRules");
		DictionaryEntry[] array = connectAccessRules;
		for (int i = 0; i < array.Length; i++)
		{
			DictionaryEntry dictionaryEntry = array[i];
			SecurityElement securityElement2 = new SecurityElement("codeOrigin");
			securityElement2.AddAttribute("scheme", (string)dictionaryEntry.Key);
			CodeConnectAccess[] array2 = (CodeConnectAccess[])dictionaryEntry.Value;
			foreach (CodeConnectAccess codeConnectAccess in array2)
			{
				SecurityElement securityElement3 = new SecurityElement("connectAccess");
				securityElement3.AddAttribute("scheme", codeConnectAccess.Scheme);
				securityElement3.AddAttribute("port", codeConnectAccess.StrPort);
				securityElement2.AddChild(securityElement3);
			}
			securityElement.AddChild(securityElement2);
		}
		element.AddChild(securityElement);
	}

	protected override void ParseXml(SecurityElement e, PolicyLevel level)
	{
		ResetConnectAccess();
		SecurityElement securityElement = e.SearchForChildByTag("connectAccessRules");
		if (securityElement == null || securityElement.Children == null)
		{
			SetDefaults();
			return;
		}
		foreach (SecurityElement child in securityElement.Children)
		{
			if (!child.Tag.Equals("codeOrigin"))
			{
				continue;
			}
			string originScheme = child.Attribute("scheme");
			bool flag = false;
			if (child.Children != null)
			{
				foreach (SecurityElement child2 in child.Children)
				{
					if (child2.Tag.Equals("connectAccess"))
					{
						string allowScheme = child2.Attribute("scheme");
						string allowPort = child2.Attribute("port");
						AddConnectAccess(originScheme, new CodeConnectAccess(allowScheme, allowPort));
						flag = true;
					}
				}
			}
			if (!flag)
			{
				AddConnectAccess(originScheme, null);
			}
		}
	}

	internal override string GetTypeName()
	{
		return "System.Security.Policy.NetCodeGroup";
	}

	private void SetDefaults()
	{
		AddConnectAccess("file", null);
		AddConnectAccess("http", new CodeConnectAccess("http", CodeConnectAccess.OriginPort));
		AddConnectAccess("http", new CodeConnectAccess("https", CodeConnectAccess.OriginPort));
		AddConnectAccess("https", new CodeConnectAccess("https", CodeConnectAccess.OriginPort));
		AddConnectAccess(AbsentOriginScheme, CodeConnectAccess.CreateAnySchemeAccess(CodeConnectAccess.OriginPort));
		AddConnectAccess(AnyOtherOriginScheme, CodeConnectAccess.CreateOriginSchemeAccess(CodeConnectAccess.OriginPort));
	}
}
