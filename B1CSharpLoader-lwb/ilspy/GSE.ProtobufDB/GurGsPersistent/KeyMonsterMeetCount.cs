using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class KeyMonsterMeetCount : IMessage<KeyMonsterMeetCount>, IMessage, IEquatable<KeyMonsterMeetCount>, IDeepCloneable<KeyMonsterMeetCount>
{
	private static readonly MessageParser<KeyMonsterMeetCount> _parser = new MessageParser<KeyMonsterMeetCount>(() => new KeyMonsterMeetCount());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private string guid_;

	private int battleCount_;

	public static MessageParser<KeyMonsterMeetCount> Parser => _parser;

	public string Guid
	{
		get
		{
			return guid_ ?? "";
		}
		set
		{
			guid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool HasGuid => guid_ != null;

	public int BattleCount
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return battleCount_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			battleCount_ = value;
		}
	}

	public bool HasBattleCount => (_hasBits0 & 1) != 0;

	public KeyMonsterMeetCount()
	{
	}

	public KeyMonsterMeetCount(KeyMonsterMeetCount other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		guid_ = other.guid_;
		battleCount_ = other.battleCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public KeyMonsterMeetCount Clone()
	{
		return new KeyMonsterMeetCount(this);
	}

	public void ClearGuid()
	{
		guid_ = null;
	}

	public void ClearBattleCount()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as KeyMonsterMeetCount);
	}

	public bool Equals(KeyMonsterMeetCount other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Guid != other.Guid)
		{
			return false;
		}
		if (BattleCount != other.BattleCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasGuid)
		{
			num ^= Guid.GetHashCode();
		}
		if (HasBattleCount)
		{
			num ^= BattleCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasGuid)
		{
			output.WriteRawTag(10);
			output.WriteString(Guid);
		}
		if (HasBattleCount)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattleCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasGuid)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guid);
		}
		if (HasBattleCount)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(KeyMonsterMeetCount other)
	{
		if (other != null)
		{
			if (other.HasGuid)
			{
				Guid = other.Guid;
			}
			if (other.HasBattleCount)
			{
				BattleCount = other.BattleCount;
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
			case 10u:
				Guid = input.ReadString();
				break;
			case 16u:
				BattleCount = input.ReadInt32();
				break;
			}
		}
	}
}
