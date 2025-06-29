using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class KickSessionMemberRequest : IMessage<KickSessionMemberRequest>, IMessage, IEquatable<KickSessionMemberRequest>, IDeepCloneable<KickSessionMemberRequest>
{
	private static readonly MessageParser<KickSessionMemberRequest> _parser = new MessageParser<KickSessionMemberRequest>(() => new KickSessionMemberRequest());

	private UnknownFieldSet _unknownFields;

	private ulong userId_;

	private ulong sessionId_;

	private ulong memberId_;

	public static MessageParser<KickSessionMemberRequest> Parser => _parser;

	public ulong UserId
	{
		get
		{
			return userId_;
		}
		set
		{
			userId_ = value;
		}
	}

	public ulong SessionId
	{
		get
		{
			return sessionId_;
		}
		set
		{
			sessionId_ = value;
		}
	}

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

	public KickSessionMemberRequest()
	{
	}

	public KickSessionMemberRequest(KickSessionMemberRequest other)
		: this()
	{
		userId_ = other.userId_;
		sessionId_ = other.sessionId_;
		memberId_ = other.memberId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public KickSessionMemberRequest Clone()
	{
		return new KickSessionMemberRequest(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as KickSessionMemberRequest);
	}

	public bool Equals(KickSessionMemberRequest other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UserId != other.UserId)
		{
			return false;
		}
		if (SessionId != other.SessionId)
		{
			return false;
		}
		if (MemberId != other.MemberId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UserId != 0L)
		{
			num ^= UserId.GetHashCode();
		}
		if (SessionId != 0L)
		{
			num ^= SessionId.GetHashCode();
		}
		if (MemberId != 0L)
		{
			num ^= MemberId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UserId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(UserId);
		}
		if (SessionId != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(SessionId);
		}
		if (MemberId != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(MemberId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UserId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(UserId);
		}
		if (SessionId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(SessionId);
		}
		if (MemberId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MemberId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(KickSessionMemberRequest other)
	{
		if (other != null)
		{
			if (other.UserId != 0L)
			{
				UserId = other.UserId;
			}
			if (other.SessionId != 0L)
			{
				SessionId = other.SessionId;
			}
			if (other.MemberId != 0L)
			{
				MemberId = other.MemberId;
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
				UserId = input.ReadUInt64();
				break;
			case 16u:
				SessionId = input.ReadUInt64();
				break;
			case 24u:
				MemberId = input.ReadUInt64();
				break;
			}
		}
	}
}
