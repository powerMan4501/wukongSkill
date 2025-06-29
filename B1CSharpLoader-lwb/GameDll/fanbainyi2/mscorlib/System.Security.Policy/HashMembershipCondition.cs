using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Util;
using System.Threading;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class HashMembershipCondition : ISerializable, IDeserializationCallback, IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IReportMatchMembershipCondition
{
	private byte[] m_value;

	private HashAlgorithm m_hashAlg;

	private SecurityElement m_element;

	private object s_InternalSyncObject;

	private const string s_tagHashValue = "HashValue";

	private const string s_tagHashAlgorithm = "HashAlgorithm";

	private object InternalSyncObject
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

	public HashAlgorithm HashAlgorithm
	{
		get
		{
			if (m_hashAlg == null && m_element != null)
			{
				ParseHashAlgorithm();
			}
			return m_hashAlg;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("HashAlgorithm");
			}
			m_hashAlg = value;
		}
	}

	public byte[] HashValue
	{
		get
		{
			if (m_value == null && m_element != null)
			{
				ParseHashValue();
			}
			if (m_value == null)
			{
				return null;
			}
			byte[] array = new byte[m_value.Length];
			Array.Copy(m_value, array, m_value.Length);
			return array;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			m_value = new byte[value.Length];
			Array.Copy(value, m_value, value.Length);
		}
	}

	internal HashMembershipCondition()
	{
	}

	private HashMembershipCondition(SerializationInfo info, StreamingContext context)
	{
		m_value = (byte[])info.GetValue("HashValue", typeof(byte[]));
		string text = (string)info.GetValue("HashAlgorithm", typeof(string));
		if (text != null)
		{
			m_hashAlg = HashAlgorithm.Create(text);
		}
		else
		{
			m_hashAlg = new SHA1Managed();
		}
	}

	public HashMembershipCondition(HashAlgorithm hashAlg, byte[] value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (hashAlg == null)
		{
			throw new ArgumentNullException("hashAlg");
		}
		m_value = new byte[value.Length];
		Array.Copy(value, m_value, value.Length);
		m_hashAlg = hashAlg;
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("HashValue", HashValue);
		info.AddValue("HashAlgorithm", HashAlgorithm.ToString());
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	public bool Check(Evidence evidence)
	{
		object usedEvidence = null;
		return ((IReportMatchMembershipCondition)this).Check(evidence, out usedEvidence);
	}

	bool IReportMatchMembershipCondition.Check(Evidence evidence, out object usedEvidence)
	{
		usedEvidence = null;
		if (evidence == null)
		{
			return false;
		}
		Hash hostEvidence = evidence.GetHostEvidence<Hash>();
		if (hostEvidence != null)
		{
			if (m_value == null && m_element != null)
			{
				ParseHashValue();
			}
			if (m_hashAlg == null && m_element != null)
			{
				ParseHashAlgorithm();
			}
			byte[] array = null;
			lock (InternalSyncObject)
			{
				array = hostEvidence.GenerateHash(m_hashAlg);
			}
			if (array != null && CompareArrays(array, m_value))
			{
				usedEvidence = hostEvidence;
				return true;
			}
		}
		return false;
	}

	public IMembershipCondition Copy()
	{
		if (m_value == null && m_element != null)
		{
			ParseHashValue();
		}
		if (m_hashAlg == null && m_element != null)
		{
			ParseHashAlgorithm();
		}
		return new HashMembershipCondition(m_hashAlg, m_value);
	}

	public SecurityElement ToXml()
	{
		return ToXml(null);
	}

	public void FromXml(SecurityElement e)
	{
		FromXml(e, null);
	}

	public SecurityElement ToXml(PolicyLevel level)
	{
		if (m_value == null && m_element != null)
		{
			ParseHashValue();
		}
		if (m_hashAlg == null && m_element != null)
		{
			ParseHashAlgorithm();
		}
		SecurityElement securityElement = new SecurityElement("IMembershipCondition");
		XMLUtil.AddClassAttribute(securityElement, GetType(), "System.Security.Policy.HashMembershipCondition");
		securityElement.AddAttribute("version", "1");
		if (m_value != null)
		{
			securityElement.AddAttribute("HashValue", Hex.EncodeHexString(HashValue));
		}
		if (m_hashAlg != null)
		{
			securityElement.AddAttribute("HashAlgorithm", HashAlgorithm.GetType().FullName);
		}
		return securityElement;
	}

	public void FromXml(SecurityElement e, PolicyLevel level)
	{
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		if (!e.Tag.Equals("IMembershipCondition"))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MembershipConditionElement"));
		}
		lock (InternalSyncObject)
		{
			m_element = e;
			m_value = null;
			m_hashAlg = null;
		}
	}

	public override bool Equals(object o)
	{
		if (o is HashMembershipCondition hashMembershipCondition)
		{
			if (m_hashAlg == null && m_element != null)
			{
				ParseHashAlgorithm();
			}
			if (hashMembershipCondition.m_hashAlg == null && hashMembershipCondition.m_element != null)
			{
				hashMembershipCondition.ParseHashAlgorithm();
			}
			if (m_hashAlg != null && hashMembershipCondition.m_hashAlg != null && m_hashAlg.GetType() == hashMembershipCondition.m_hashAlg.GetType())
			{
				if (m_value == null && m_element != null)
				{
					ParseHashValue();
				}
				if (hashMembershipCondition.m_value == null && hashMembershipCondition.m_element != null)
				{
					hashMembershipCondition.ParseHashValue();
				}
				if (m_value.Length != hashMembershipCondition.m_value.Length)
				{
					return false;
				}
				for (int i = 0; i < m_value.Length; i++)
				{
					if (m_value[i] != hashMembershipCondition.m_value[i])
					{
						return false;
					}
				}
				return true;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (m_hashAlg == null && m_element != null)
		{
			ParseHashAlgorithm();
		}
		int num = ((m_hashAlg != null) ? m_hashAlg.GetType().GetHashCode() : 0);
		if (m_value == null && m_element != null)
		{
			ParseHashValue();
		}
		return num ^ GetByteArrayHashCode(m_value);
	}

	public override string ToString()
	{
		if (m_hashAlg == null)
		{
			ParseHashAlgorithm();
		}
		return Environment.GetResourceString("Hash_ToString", m_hashAlg.GetType().AssemblyQualifiedName, Hex.EncodeHexString(HashValue));
	}

	private void ParseHashValue()
	{
		lock (InternalSyncObject)
		{
			if (m_element != null)
			{
				string text = m_element.Attribute("HashValue");
				if (text == null)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidXMLElement", "HashValue", GetType().FullName));
				}
				m_value = Hex.DecodeHexString(text);
				if (m_value != null && m_hashAlg != null)
				{
					m_element = null;
				}
			}
		}
	}

	private void ParseHashAlgorithm()
	{
		lock (InternalSyncObject)
		{
			if (m_element != null)
			{
				string text = m_element.Attribute("HashAlgorithm");
				if (text != null)
				{
					m_hashAlg = HashAlgorithm.Create(text);
				}
				else
				{
					m_hashAlg = new SHA1Managed();
				}
				if (m_value != null && m_hashAlg != null)
				{
					m_element = null;
				}
			}
		}
	}

	private static bool CompareArrays(byte[] first, byte[] second)
	{
		if (first.Length != second.Length)
		{
			return false;
		}
		int num = first.Length;
		for (int i = 0; i < num; i++)
		{
			if (first[i] != second[i])
			{
				return false;
			}
		}
		return true;
	}

	private static int GetByteArrayHashCode(byte[] baData)
	{
		if (baData == null)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < baData.Length; i++)
		{
			num = (num << 8) ^ baData[i] ^ (num >> 24);
		}
		return num;
	}
}
