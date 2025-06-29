using System.Security.Principal;

namespace System.Security.AccessControl;

public abstract class KnownAce : GenericAce
{
	private int _accessMask;

	private SecurityIdentifier _sid;

	internal const int AccessMaskLength = 4;

	public int AccessMask
	{
		get
		{
			return _accessMask;
		}
		set
		{
			_accessMask = value;
		}
	}

	public SecurityIdentifier SecurityIdentifier
	{
		get
		{
			return _sid;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			_sid = value;
		}
	}

	internal KnownAce(AceType type, AceFlags flags, int accessMask, SecurityIdentifier securityIdentifier)
		: base(type, flags)
	{
		if (securityIdentifier == null)
		{
			throw new ArgumentNullException("securityIdentifier");
		}
		AccessMask = accessMask;
		SecurityIdentifier = securityIdentifier;
	}
}
