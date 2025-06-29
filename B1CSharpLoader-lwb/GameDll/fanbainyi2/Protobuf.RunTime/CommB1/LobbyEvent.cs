using System;
using Google.Protobuf;

namespace CommB1;

public sealed class LobbyEvent : IMessage<LobbyEvent>, IMessage, IEquatable<LobbyEvent>, IDeepCloneable<LobbyEvent>
{
	private static readonly MessageParser<LobbyEvent> _parser = new MessageParser<LobbyEvent>(() => new LobbyEvent());

	private UnknownFieldSet _unknownFields;

	private LobbyEventType eventType_;

	private ulong userId_;

	private ulong receptorUserId_;

	public static MessageParser<LobbyEvent> Parser => _parser;

	public LobbyEventType EventType
	{
		get
		{
			return eventType_;
		}
		set
		{
			eventType_ = value;
		}
	}

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

	public ulong ReceptorUserId
	{
		get
		{
			return receptorUserId_;
		}
		set
		{
			receptorUserId_ = value;
		}
	}

	public LobbyEvent()
	{
	}

	public LobbyEvent(LobbyEvent other)
		: this()
	{
		eventType_ = other.eventType_;
		userId_ = other.userId_;
		receptorUserId_ = other.receptorUserId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LobbyEvent Clone()
	{
		return new LobbyEvent(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LobbyEvent);
	}

	public bool Equals(LobbyEvent other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventType != other.EventType)
		{
			return false;
		}
		if (UserId != other.UserId)
		{
			return false;
		}
		if (ReceptorUserId != other.ReceptorUserId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EventType != LobbyEventType.None)
		{
			num ^= EventType.GetHashCode();
		}
		if (UserId != 0L)
		{
			num ^= UserId.GetHashCode();
		}
		if (ReceptorUserId != 0L)
		{
			num ^= ReceptorUserId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EventType != LobbyEventType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)EventType);
		}
		if (UserId != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(UserId);
		}
		if (ReceptorUserId != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(ReceptorUserId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EventType != LobbyEventType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EventType);
		}
		if (UserId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(UserId);
		}
		if (ReceptorUserId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ReceptorUserId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LobbyEvent other)
	{
		if (other != null)
		{
			if (other.EventType != LobbyEventType.None)
			{
				EventType = other.EventType;
			}
			if (other.UserId != 0L)
			{
				UserId = other.UserId;
			}
			if (other.ReceptorUserId != 0L)
			{
				ReceptorUserId = other.ReceptorUserId;
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
				EventType = (LobbyEventType)input.ReadEnum();
				break;
			case 16u:
				UserId = input.ReadUInt64();
				break;
			case 24u:
				ReceptorUserId = input.ReadUInt64();
				break;
			}
		}
	}
}
