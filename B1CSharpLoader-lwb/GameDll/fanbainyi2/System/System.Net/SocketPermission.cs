using System.Collections;
using System.Globalization;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Net;

[Serializable]
public sealed class SocketPermission : CodeAccessPermission, IUnrestrictedPermission
{
	private ArrayList m_connectList;

	private ArrayList m_acceptList;

	private bool m_noRestriction;

	public const int AllPorts = -1;

	internal const int AnyPort = 0;

	public IEnumerator ConnectList => m_connectList.GetEnumerator();

	public IEnumerator AcceptList => m_acceptList.GetEnumerator();

	public SocketPermission(PermissionState state)
	{
		initialize();
		m_noRestriction = state == PermissionState.Unrestricted;
	}

	internal SocketPermission(bool free)
	{
		initialize();
		m_noRestriction = free;
	}

	public SocketPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber)
	{
		initialize();
		m_noRestriction = false;
		AddPermission(access, transport, hostName, portNumber);
	}

	public void AddPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber)
	{
		if (hostName == null)
		{
			throw new ArgumentNullException("hostName");
		}
		EndpointPermission endPoint = new EndpointPermission(hostName, portNumber, transport);
		AddPermission(access, endPoint);
	}

	internal void AddPermission(NetworkAccess access, EndpointPermission endPoint)
	{
		if (!m_noRestriction)
		{
			if ((access & NetworkAccess.Connect) != 0)
			{
				m_connectList.Add(endPoint);
			}
			if ((access & NetworkAccess.Accept) != 0)
			{
				m_acceptList.Add(endPoint);
			}
		}
	}

	public bool IsUnrestricted()
	{
		return m_noRestriction;
	}

	public override IPermission Copy()
	{
		SocketPermission socketPermission = new SocketPermission(m_noRestriction);
		socketPermission.m_connectList = (ArrayList)m_connectList.Clone();
		socketPermission.m_acceptList = (ArrayList)m_acceptList.Clone();
		return socketPermission;
	}

	private bool FindSubset(ArrayList source, ArrayList target)
	{
		foreach (EndpointPermission item in source)
		{
			bool flag = false;
			foreach (EndpointPermission item2 in target)
			{
				if (item.SubsetMatch(item2))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			return Copy();
		}
		if (!(target is SocketPermission socketPermission))
		{
			throw new ArgumentException(SR.GetString("net_perm_target"), "target");
		}
		if (m_noRestriction || socketPermission.m_noRestriction)
		{
			return new SocketPermission(free: true);
		}
		SocketPermission socketPermission2 = (SocketPermission)socketPermission.Copy();
		for (int i = 0; i < m_connectList.Count; i++)
		{
			socketPermission2.AddPermission(NetworkAccess.Connect, (EndpointPermission)m_connectList[i]);
		}
		for (int j = 0; j < m_acceptList.Count; j++)
		{
			socketPermission2.AddPermission(NetworkAccess.Accept, (EndpointPermission)m_acceptList[j]);
		}
		return socketPermission2;
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (!(target is SocketPermission socketPermission))
		{
			throw new ArgumentException(SR.GetString("net_perm_target"), "target");
		}
		SocketPermission socketPermission2;
		if (m_noRestriction)
		{
			socketPermission2 = (SocketPermission)socketPermission.Copy();
		}
		else if (socketPermission.m_noRestriction)
		{
			socketPermission2 = (SocketPermission)Copy();
		}
		else
		{
			socketPermission2 = new SocketPermission(free: false);
			intersectLists(m_connectList, socketPermission.m_connectList, socketPermission2.m_connectList);
			intersectLists(m_acceptList, socketPermission.m_acceptList, socketPermission2.m_acceptList);
		}
		if (!socketPermission2.m_noRestriction && socketPermission2.m_connectList.Count == 0 && socketPermission2.m_acceptList.Count == 0)
		{
			return null;
		}
		return socketPermission2;
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			if (!m_noRestriction && m_connectList.Count == 0)
			{
				return m_acceptList.Count == 0;
			}
			return false;
		}
		if (!(target is SocketPermission socketPermission))
		{
			throw new ArgumentException(SR.GetString("net_perm_target"), "target");
		}
		if (socketPermission.IsUnrestricted())
		{
			return true;
		}
		if (IsUnrestricted())
		{
			return false;
		}
		if (m_acceptList.Count + m_connectList.Count == 0)
		{
			return true;
		}
		if (socketPermission.m_acceptList.Count + socketPermission.m_connectList.Count == 0)
		{
			return false;
		}
		bool result = false;
		try
		{
			if (FindSubset(m_connectList, socketPermission.m_connectList) && FindSubset(m_acceptList, socketPermission.m_acceptList))
			{
				result = true;
			}
		}
		finally
		{
			CleanupDNS();
		}
		return result;
	}

	private void CleanupDNS()
	{
		foreach (EndpointPermission connect in m_connectList)
		{
			if (!connect.cached)
			{
				connect.address = null;
			}
		}
		foreach (EndpointPermission accept in m_acceptList)
		{
			if (!accept.cached)
			{
				accept.address = null;
			}
		}
	}

	public override void FromXml(SecurityElement securityElement)
	{
		if (securityElement == null)
		{
			throw new ArgumentNullException("securityElement");
		}
		if (!securityElement.Tag.Equals("IPermission"))
		{
			throw new ArgumentException(SR.GetString("net_not_ipermission"), "securityElement");
		}
		string text = securityElement.Attribute("class");
		if (text == null)
		{
			throw new ArgumentException(SR.GetString("net_no_classname"), "securityElement");
		}
		if (text.IndexOf(GetType().FullName) < 0)
		{
			throw new ArgumentException(SR.GetString("net_no_typename"), "securityElement");
		}
		initialize();
		string text2 = securityElement.Attribute("Unrestricted");
		if (text2 != null)
		{
			m_noRestriction = string.Compare(text2, "true", StringComparison.OrdinalIgnoreCase) == 0;
			if (m_noRestriction)
			{
				return;
			}
		}
		m_noRestriction = false;
		m_connectList = new ArrayList();
		m_acceptList = new ArrayList();
		SecurityElement securityElement2 = securityElement.SearchForChildByTag("ConnectAccess");
		if (securityElement2 != null)
		{
			ParseAddXmlElement(securityElement2, m_connectList, "ConnectAccess, ");
		}
		securityElement2 = securityElement.SearchForChildByTag("AcceptAccess");
		if (securityElement2 != null)
		{
			ParseAddXmlElement(securityElement2, m_acceptList, "AcceptAccess, ");
		}
	}

	private static void ParseAddXmlElement(SecurityElement et, ArrayList listToAdd, string accessStr)
	{
		foreach (SecurityElement child in et.Children)
		{
			if (!child.Tag.Equals("ENDPOINT"))
			{
				continue;
			}
			Hashtable attributes = child.Attributes;
			string text;
			try
			{
				text = attributes["host"] as string;
			}
			catch
			{
				text = null;
			}
			if (text == null)
			{
				throw new ArgumentNullException(accessStr + "host");
			}
			string epname = text;
			try
			{
				text = attributes["transport"] as string;
			}
			catch
			{
				text = null;
			}
			if (text == null)
			{
				throw new ArgumentNullException(accessStr + "transport");
			}
			TransportType trtype;
			try
			{
				trtype = (TransportType)Enum.Parse(typeof(TransportType), text, ignoreCase: true);
			}
			catch (Exception ex)
			{
				if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
				{
					throw;
				}
				throw new ArgumentException(accessStr + "transport", ex);
			}
			try
			{
				text = attributes["port"] as string;
			}
			catch
			{
				text = null;
			}
			if (text == null)
			{
				throw new ArgumentNullException(accessStr + "port");
			}
			if (string.Compare(text, "All", StringComparison.OrdinalIgnoreCase) == 0)
			{
				text = "-1";
			}
			int num;
			try
			{
				num = int.Parse(text, NumberFormatInfo.InvariantInfo);
			}
			catch (Exception ex2)
			{
				if (ex2 is ThreadAbortException || ex2 is StackOverflowException || ex2 is OutOfMemoryException)
				{
					throw;
				}
				throw new ArgumentException(SR.GetString("net_perm_invalid_val", accessStr + "port", text), ex2);
			}
			if (!ValidationHelper.ValidateTcpPort(num) && num != -1)
			{
				throw new ArgumentOutOfRangeException("port", num, SR.GetString("net_perm_invalid_val", accessStr + "port", text));
			}
			listToAdd.Add(new EndpointPermission(epname, num, trtype));
		}
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("IPermission");
		securityElement.AddAttribute("class", GetType().FullName + ", " + GetType().Module.Assembly.FullName.Replace('"', '\''));
		securityElement.AddAttribute("version", "1");
		if (!IsUnrestricted())
		{
			if (m_connectList.Count > 0)
			{
				SecurityElement securityElement2 = new SecurityElement("ConnectAccess");
				foreach (EndpointPermission connect in m_connectList)
				{
					SecurityElement securityElement3 = new SecurityElement("ENDPOINT");
					securityElement3.AddAttribute("host", connect.Hostname);
					securityElement3.AddAttribute("transport", connect.Transport.ToString());
					securityElement3.AddAttribute("port", (connect.Port != -1) ? connect.Port.ToString(NumberFormatInfo.InvariantInfo) : "All");
					securityElement2.AddChild(securityElement3);
				}
				securityElement.AddChild(securityElement2);
			}
			if (m_acceptList.Count > 0)
			{
				SecurityElement securityElement4 = new SecurityElement("AcceptAccess");
				foreach (EndpointPermission accept in m_acceptList)
				{
					SecurityElement securityElement5 = new SecurityElement("ENDPOINT");
					securityElement5.AddAttribute("host", accept.Hostname);
					securityElement5.AddAttribute("transport", accept.Transport.ToString());
					securityElement5.AddAttribute("port", (accept.Port != -1) ? accept.Port.ToString(NumberFormatInfo.InvariantInfo) : "All");
					securityElement4.AddChild(securityElement5);
				}
				securityElement.AddChild(securityElement4);
			}
		}
		else
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		return securityElement;
	}

	private void initialize()
	{
		m_noRestriction = false;
		m_connectList = new ArrayList();
		m_acceptList = new ArrayList();
	}

	private static void intersectLists(ArrayList A, ArrayList B, ArrayList result)
	{
		bool[] array = new bool[A.Count];
		bool[] array2 = new bool[B.Count];
		int num = 0;
		int num2 = 0;
		foreach (EndpointPermission item in A)
		{
			num2 = 0;
			foreach (EndpointPermission item2 in B)
			{
				if (!array2[num2] && item.Equals(item2))
				{
					result.Add(item);
					array[num] = (array2[num2] = true);
					break;
				}
				num2++;
			}
			num++;
		}
		num = 0;
		foreach (EndpointPermission item3 in A)
		{
			if (!array[num])
			{
				num2 = 0;
				foreach (EndpointPermission item4 in B)
				{
					if (!array2[num2])
					{
						EndpointPermission endpointPermission3 = item3.Intersect(item4);
						if (endpointPermission3 != null)
						{
							bool flag = false;
							foreach (EndpointPermission item5 in result)
							{
								if (item5.Equals(endpointPermission3))
								{
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								result.Add(endpointPermission3);
							}
						}
					}
					num2++;
				}
			}
			num++;
		}
	}
}
