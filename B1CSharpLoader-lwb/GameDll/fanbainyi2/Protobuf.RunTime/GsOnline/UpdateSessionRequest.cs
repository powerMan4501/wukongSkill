using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class UpdateSessionRequest : IMessage<UpdateSessionRequest>, IMessage, IEquatable<UpdateSessionRequest>, IDeepCloneable<UpdateSessionRequest>
{
	private static readonly MessageParser<UpdateSessionRequest> _parser = new MessageParser<UpdateSessionRequest>(() => new UpdateSessionRequest());

	private UnknownFieldSet _unknownFields;

	private ulong userId_;

	private ulong sessionId_;

	private SessionSetting setting_;

	public static MessageParser<UpdateSessionRequest> Parser => _parser;

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

	public SessionSetting Setting
	{
		get
		{
			return setting_;
		}
		set
		{
			setting_ = value;
		}
	}

	public UpdateSessionRequest()
	{
	}

	public UpdateSessionRequest(UpdateSessionRequest other)
		: this()
	{
		userId_ = other.userId_;
		sessionId_ = other.sessionId_;
		setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UpdateSessionRequest Clone()
	{
		return new UpdateSessionRequest(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UpdateSessionRequest);
	}

	public bool Equals(UpdateSessionRequest other)
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
		if (!object.Equals(Setting, other.Setting))
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
		if (setting_ != null)
		{
			num ^= Setting.GetHashCode();
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
		if (setting_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Setting);
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
		if (setting_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Setting);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UpdateSessionRequest other)
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
		if (other.setting_ != null)
		{
			if (setting_ == null)
			{
				Setting = new SessionSetting();
			}
			Setting.MergeFrom(other.Setting);
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
				if (setting_ == null)
				{
					Setting = new SessionSetting();
				}
				input.ReadMessage(Setting);
				break;
			}
		}
	}
}
