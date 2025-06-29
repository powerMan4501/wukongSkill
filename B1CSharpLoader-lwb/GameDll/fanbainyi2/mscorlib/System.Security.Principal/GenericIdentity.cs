using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Claims;

namespace System.Security.Principal;

[Serializable]
[ComVisible(true)]
public class GenericIdentity : ClaimsIdentity
{
	private string m_name;

	private string m_type;

	public override IEnumerable<Claim> Claims => base.Claims;

	public override string Name => m_name;

	public override string AuthenticationType => m_type;

	public override bool IsAuthenticated => !m_name.Equals("");

	[SecuritySafeCritical]
	public GenericIdentity(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		m_name = name;
		m_type = "";
		AddNameClaim();
	}

	[SecuritySafeCritical]
	public GenericIdentity(string name, string type)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		m_name = name;
		m_type = type;
		AddNameClaim();
	}

	private GenericIdentity()
	{
	}

	protected GenericIdentity(GenericIdentity identity)
		: base(identity)
	{
		m_name = identity.m_name;
		m_type = identity.m_type;
	}

	public override ClaimsIdentity Clone()
	{
		return new GenericIdentity(this);
	}

	[OnDeserialized]
	private void OnDeserializedMethod(StreamingContext context)
	{
		bool flag = false;
		using (IEnumerator<Claim> enumerator = base.Claims.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				Claim current = enumerator.Current;
				flag = true;
			}
		}
		if (!flag)
		{
			AddNameClaim();
		}
	}

	[SecuritySafeCritical]
	private void AddNameClaim()
	{
		if (m_name != null)
		{
			base.AddClaim(new Claim(base.NameClaimType, m_name, "http://www.w3.org/2001/XMLSchema#string", "LOCAL AUTHORITY", "LOCAL AUTHORITY", this));
		}
	}
}
