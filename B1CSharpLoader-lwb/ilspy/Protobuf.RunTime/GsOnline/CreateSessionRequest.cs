using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class CreateSessionRequest : IMessage<CreateSessionRequest>, IMessage, IEquatable<CreateSessionRequest>, IDeepCloneable<CreateSessionRequest>
{
	private static readonly MessageParser<CreateSessionRequest> _parser = new MessageParser<CreateSessionRequest>(() => new CreateSessionRequest());

	private UnknownFieldSet _unknownFields;

	private ulong userId_;

	private SessionSetting setting_;

	public static MessageParser<CreateSessionRequest> Parser => _parser;

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

	public CreateSessionRequest()
	{
	}

	public CreateSessionRequest(CreateSessionRequest other)
		: this()
	{
		userId_ = other.userId_;
		setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CreateSessionRequest Clone()
	{
		return new CreateSessionRequest(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CreateSessionRequest);
	}

	public bool Equals(CreateSessionRequest other)
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
		if (setting_ != null)
		{
			output.WriteRawTag(18);
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

	public void MergeFrom(CreateSessionRequest other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UserId != 0L)
		{
			UserId = other.UserId;
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
			case 18u:
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
