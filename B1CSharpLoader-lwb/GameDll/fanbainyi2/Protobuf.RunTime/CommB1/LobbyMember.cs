using System;
using Google.Protobuf;

namespace CommB1;

public sealed class LobbyMember : IMessage<LobbyMember>, IMessage, IEquatable<LobbyMember>, IDeepCloneable<LobbyMember>
{
	private static readonly MessageParser<LobbyMember> _parser = new MessageParser<LobbyMember>(() => new LobbyMember());

	private UnknownFieldSet _unknownFields;

	private ulong memberId_;

	private string memberName_ = "";

	private ulong svrId_;

	private LobbyMemberState state_;

	public static MessageParser<LobbyMember> Parser => _parser;

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

	public ulong SvrId
	{
		get
		{
			return svrId_;
		}
		set
		{
			svrId_ = value;
		}
	}

	public LobbyMemberState State
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

	public LobbyMember()
	{
	}

	public LobbyMember(LobbyMember other)
		: this()
	{
		memberId_ = other.memberId_;
		memberName_ = other.memberName_;
		svrId_ = other.svrId_;
		state_ = other.state_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LobbyMember Clone()
	{
		return new LobbyMember(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LobbyMember);
	}

	public bool Equals(LobbyMember other)
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
		if (SvrId != other.SvrId)
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
		if (SvrId != 0L)
		{
			num ^= SvrId.GetHashCode();
		}
		if (State != LobbyMemberState.Join)
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
		if (SvrId != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(SvrId);
		}
		if (State != LobbyMemberState.Join)
		{
			output.WriteRawTag(32);
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
		if (SvrId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(SvrId);
		}
		if (State != LobbyMemberState.Join)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LobbyMember other)
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
			if (other.SvrId != 0L)
			{
				SvrId = other.SvrId;
			}
			if (other.State != LobbyMemberState.Join)
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
				SvrId = input.ReadUInt64();
				break;
			case 32u:
				State = (LobbyMemberState)input.ReadEnum();
				break;
			}
		}
	}
}
