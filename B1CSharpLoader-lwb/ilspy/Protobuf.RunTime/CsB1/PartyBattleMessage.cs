using System;
using Google.Protobuf;

namespace CsB1;

public sealed class PartyBattleMessage : IMessage<PartyBattleMessage>, IMessage, IEquatable<PartyBattleMessage>, IDeepCloneable<PartyBattleMessage>
{
	private static readonly MessageParser<PartyBattleMessage> _parser = new MessageParser<PartyBattleMessage>(() => new PartyBattleMessage());

	private UnknownFieldSet _unknownFields;

	private PartyMessageTargetType targetType_;

	private ulong targetUser_;

	private ByteString msgBuff_ = ByteString.Empty;

	public static MessageParser<PartyBattleMessage> Parser => _parser;

	public PartyMessageTargetType TargetType
	{
		get
		{
			return targetType_;
		}
		set
		{
			targetType_ = value;
		}
	}

	public ulong TargetUser
	{
		get
		{
			return targetUser_;
		}
		set
		{
			targetUser_ = value;
		}
	}

	public ByteString MsgBuff
	{
		get
		{
			return msgBuff_;
		}
		set
		{
			msgBuff_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public PartyBattleMessage()
	{
	}

	public PartyBattleMessage(PartyBattleMessage other)
		: this()
	{
		targetType_ = other.targetType_;
		targetUser_ = other.targetUser_;
		msgBuff_ = other.msgBuff_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyBattleMessage Clone()
	{
		return new PartyBattleMessage(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyBattleMessage);
	}

	public bool Equals(PartyBattleMessage other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TargetType != other.TargetType)
		{
			return false;
		}
		if (TargetUser != other.TargetUser)
		{
			return false;
		}
		if (MsgBuff != other.MsgBuff)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TargetType != PartyMessageTargetType.All)
		{
			num ^= TargetType.GetHashCode();
		}
		if (TargetUser != 0L)
		{
			num ^= TargetUser.GetHashCode();
		}
		if (MsgBuff.Length != 0)
		{
			num ^= MsgBuff.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TargetType != PartyMessageTargetType.All)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)TargetType);
		}
		if (TargetUser != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(TargetUser);
		}
		if (MsgBuff.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteBytes(MsgBuff);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TargetType != PartyMessageTargetType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TargetType);
		}
		if (TargetUser != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(TargetUser);
		}
		if (MsgBuff.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(MsgBuff);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyBattleMessage other)
	{
		if (other != null)
		{
			if (other.TargetType != PartyMessageTargetType.All)
			{
				TargetType = other.TargetType;
			}
			if (other.TargetUser != 0L)
			{
				TargetUser = other.TargetUser;
			}
			if (other.MsgBuff.Length != 0)
			{
				MsgBuff = other.MsgBuff;
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
				TargetType = (PartyMessageTargetType)input.ReadEnum();
				break;
			case 16u:
				TargetUser = input.ReadUInt64();
				break;
			case 26u:
				MsgBuff = input.ReadBytes();
				break;
			}
		}
	}
}
