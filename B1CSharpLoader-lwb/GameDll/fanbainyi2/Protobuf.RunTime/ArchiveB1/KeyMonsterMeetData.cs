using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class KeyMonsterMeetData : IMessage<KeyMonsterMeetData>, IMessage, IEquatable<KeyMonsterMeetData>, IDeepCloneable<KeyMonsterMeetData>
{
	private static readonly MessageParser<KeyMonsterMeetData> _parser = new MessageParser<KeyMonsterMeetData>(() => new KeyMonsterMeetData());

	private UnknownFieldSet _unknownFields;

	private int extendId_;

	private int inToBattleCount_;

	private string guid_ = "";

	public static MessageParser<KeyMonsterMeetData> Parser => _parser;

	public int ExtendId
	{
		get
		{
			return extendId_;
		}
		set
		{
			extendId_ = value;
		}
	}

	public int InToBattleCount
	{
		get
		{
			return inToBattleCount_;
		}
		set
		{
			inToBattleCount_ = value;
		}
	}

	public string Guid
	{
		get
		{
			return guid_;
		}
		set
		{
			guid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public KeyMonsterMeetData()
	{
	}

	public KeyMonsterMeetData(KeyMonsterMeetData other)
		: this()
	{
		extendId_ = other.extendId_;
		inToBattleCount_ = other.inToBattleCount_;
		guid_ = other.guid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public KeyMonsterMeetData Clone()
	{
		return new KeyMonsterMeetData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as KeyMonsterMeetData);
	}

	public bool Equals(KeyMonsterMeetData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ExtendId != other.ExtendId)
		{
			return false;
		}
		if (InToBattleCount != other.InToBattleCount)
		{
			return false;
		}
		if (Guid != other.Guid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ExtendId != 0)
		{
			num ^= ExtendId.GetHashCode();
		}
		if (InToBattleCount != 0)
		{
			num ^= InToBattleCount.GetHashCode();
		}
		if (Guid.Length != 0)
		{
			num ^= Guid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ExtendId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ExtendId);
		}
		if (InToBattleCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(InToBattleCount);
		}
		if (Guid.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Guid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ExtendId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtendId);
		}
		if (InToBattleCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InToBattleCount);
		}
		if (Guid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(KeyMonsterMeetData other)
	{
		if (other != null)
		{
			if (other.ExtendId != 0)
			{
				ExtendId = other.ExtendId;
			}
			if (other.InToBattleCount != 0)
			{
				InToBattleCount = other.InToBattleCount;
			}
			if (other.Guid.Length != 0)
			{
				Guid = other.Guid;
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
				ExtendId = input.ReadInt32();
				break;
			case 16u:
				InToBattleCount = input.ReadInt32();
				break;
			case 26u:
				Guid = input.ReadString();
				break;
			}
		}
	}
}
