using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class UpdateSessionMemberRequest : IMessage<UpdateSessionMemberRequest>, IMessage, IEquatable<UpdateSessionMemberRequest>, IDeepCloneable<UpdateSessionMemberRequest>
{
	private static readonly MessageParser<UpdateSessionMemberRequest> _parser = new MessageParser<UpdateSessionMemberRequest>(() => new UpdateSessionMemberRequest());

	private UnknownFieldSet _unknownFields;

	private ulong userId_;

	private ulong sessionId_;

	private MemberUpdateParam updateParam_;

	public static MessageParser<UpdateSessionMemberRequest> Parser => _parser;

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

	public MemberUpdateParam UpdateParam
	{
		get
		{
			return updateParam_;
		}
		set
		{
			updateParam_ = value;
		}
	}

	public UpdateSessionMemberRequest()
	{
	}

	public UpdateSessionMemberRequest(UpdateSessionMemberRequest other)
		: this()
	{
		userId_ = other.userId_;
		sessionId_ = other.sessionId_;
		updateParam_ = ((other.updateParam_ != null) ? other.updateParam_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UpdateSessionMemberRequest Clone()
	{
		return new UpdateSessionMemberRequest(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UpdateSessionMemberRequest);
	}

	public bool Equals(UpdateSessionMemberRequest other)
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
		if (!object.Equals(UpdateParam, other.UpdateParam))
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
		if (updateParam_ != null)
		{
			num ^= UpdateParam.GetHashCode();
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
		if (updateParam_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(UpdateParam);
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
		if (updateParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UpdateParam);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UpdateSessionMemberRequest other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UserId != 0L)
		{
			UserId = other.UserId;
		}
		if (other.SessionId != 0L)
		{
			SessionId = other.SessionId;
		}
		if (other.updateParam_ != null)
		{
			if (updateParam_ == null)
			{
				UpdateParam = new MemberUpdateParam();
			}
			UpdateParam.MergeFrom(other.UpdateParam);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 26u:
				if (updateParam_ == null)
				{
					UpdateParam = new MemberUpdateParam();
				}
				input.ReadMessage(UpdateParam);
				break;
			}
		}
	}
}
