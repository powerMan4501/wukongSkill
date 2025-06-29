using System;
using Google.Protobuf;

namespace ResB1;

public sealed class PlayerLevelDesc : IMessage<PlayerLevelDesc>, IMessage, IEquatable<PlayerLevelDesc>, IDeepCloneable<PlayerLevelDesc>
{
	private static readonly MessageParser<PlayerLevelDesc> _parser = new MessageParser<PlayerLevelDesc>(() => new PlayerLevelDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int nextLevelExp_;

	private int nextLevelGainTalent_;

	public static MessageParser<PlayerLevelDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int NextLevelExp
	{
		get
		{
			return nextLevelExp_;
		}
		set
		{
			nextLevelExp_ = value;
		}
	}

	public int NextLevelGainTalent
	{
		get
		{
			return nextLevelGainTalent_;
		}
		set
		{
			nextLevelGainTalent_ = value;
		}
	}

	public PlayerLevelDesc()
	{
	}

	public PlayerLevelDesc(PlayerLevelDesc other)
		: this()
	{
		id_ = other.id_;
		nextLevelExp_ = other.nextLevelExp_;
		nextLevelGainTalent_ = other.nextLevelGainTalent_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerLevelDesc Clone()
	{
		return new PlayerLevelDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerLevelDesc);
	}

	public bool Equals(PlayerLevelDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (NextLevelExp != other.NextLevelExp)
		{
			return false;
		}
		if (NextLevelGainTalent != other.NextLevelGainTalent)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (NextLevelExp != 0)
		{
			num ^= NextLevelExp.GetHashCode();
		}
		if (NextLevelGainTalent != 0)
		{
			num ^= NextLevelGainTalent.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (NextLevelExp != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(NextLevelExp);
		}
		if (NextLevelGainTalent != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(NextLevelGainTalent);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (NextLevelExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NextLevelExp);
		}
		if (NextLevelGainTalent != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NextLevelGainTalent);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerLevelDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.NextLevelExp != 0)
			{
				NextLevelExp = other.NextLevelExp;
			}
			if (other.NextLevelGainTalent != 0)
			{
				NextLevelGainTalent = other.NextLevelGainTalent;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				NextLevelExp = input.ReadInt32();
				break;
			case 24u:
				NextLevelGainTalent = input.ReadInt32();
				break;
			}
		}
	}
}
