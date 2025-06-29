namespace System.ComponentModel.Design.Serialization;

public struct MemberRelationship
{
	private object _owner;

	private MemberDescriptor _member;

	public static readonly MemberRelationship Empty;

	public bool IsEmpty => _owner == null;

	public MemberDescriptor Member => _member;

	public object Owner => _owner;

	public MemberRelationship(object owner, MemberDescriptor member)
	{
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		if (member == null)
		{
			throw new ArgumentNullException("member");
		}
		_owner = owner;
		_member = member;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is MemberRelationship memberRelationship))
		{
			return false;
		}
		if (memberRelationship.Owner == Owner)
		{
			return memberRelationship.Member == Member;
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (_owner == null)
		{
			return base.GetHashCode();
		}
		return _owner.GetHashCode() ^ _member.GetHashCode();
	}

	public static bool operator ==(MemberRelationship left, MemberRelationship right)
	{
		if (left.Owner == right.Owner)
		{
			return left.Member == right.Member;
		}
		return false;
	}

	public static bool operator !=(MemberRelationship left, MemberRelationship right)
	{
		return !(left == right);
	}
}
