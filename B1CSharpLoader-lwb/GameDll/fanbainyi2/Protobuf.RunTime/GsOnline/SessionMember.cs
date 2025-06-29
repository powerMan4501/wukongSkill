using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class SessionMember : IMessage<SessionMember>, IMessage, IEquatable<SessionMember>, IDeepCloneable<SessionMember>
{
	private static readonly MessageParser<SessionMember> _parser = new MessageParser<SessionMember>(() => new SessionMember());

	private UnknownFieldSet _unknownFields;

	private ulong memberId_;

	private string memberName_ = "";

	private MemberState state_;

	public static MessageParser<SessionMember> Parser => _parser;

	public ulong MemberId
	{
		get
		{
			return memberId_;
		}
		set
		{
			memberId_ = value;
		}
	}

	public string MemberName
	{
		get
		{
			return memberName_;
		}
		set
		{
			memberName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public MemberState State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	public SessionMember()
	{
	}

	public SessionMember(SessionMember other)
		: this()
	{
		memberId_ = other.memberId_;
		memberName_ = other.memberName_;
		state_ = other.state_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SessionMember Clone()
	{
		return new SessionMember(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SessionMember);
	}

	public bool Equals(SessionMember other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MemberId != other.MemberId)
		{
			return false;
		}
		if (MemberName != other.MemberName)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MemberId != 0L)
		{
			num ^= MemberId.GetHashCode();
		}
		if (MemberName.Length != 0)
		{
			num ^= MemberName.GetHashCode();
		}
		if (State != MemberState.Join)
		{
			num ^= State.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MemberId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(MemberId);
		}
		if (MemberName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(MemberName);
		}
		if (State != MemberState.Join)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)State);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MemberId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MemberId);
		}
		if (MemberName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MemberName);
		}
		if (State != MemberState.Join)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SessionMember other)
	{
		if (other != null)
		{
			if (other.MemberId != 0L)
			{
				MemberId = other.MemberId;
			}
			if (other.MemberName.Length != 0)
			{
				MemberName = other.MemberName;
			}
			if (other.State != MemberState.Join)
			{
				State = other.State;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				MemberId = input.ReadUInt64();
				break;
			case 18u:
				MemberName = input.ReadString();
				break;
			case 24u:
				State = (MemberState)input.ReadEnum();
				break;
			}
		}
	}
}
