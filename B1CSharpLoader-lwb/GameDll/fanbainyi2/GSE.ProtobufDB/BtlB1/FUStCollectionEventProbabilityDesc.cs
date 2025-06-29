using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStCollectionEventProbabilityDesc : IMessage<FUStCollectionEventProbabilityDesc>, IMessage, IEquatable<FUStCollectionEventProbabilityDesc>, IDeepCloneable<FUStCollectionEventProbabilityDesc>
{
	private static readonly MessageParser<FUStCollectionEventProbabilityDesc> _parser = new MessageParser<FUStCollectionEventProbabilityDesc>(() => new FUStCollectionEventProbabilityDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int monsterRate_;

	private int plusMonsterRate_;

	private int chiefRate_;

	public static MessageParser<FUStCollectionEventProbabilityDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public int MonsterRate
	{
		get
		{
			return monsterRate_;
		}
		set
		{
			monsterRate_ = value;
		}
	}

	public int PlusMonsterRate
	{
		get
		{
			return plusMonsterRate_;
		}
		set
		{
			plusMonsterRate_ = value;
		}
	}

	public int ChiefRate
	{
		get
		{
			return chiefRate_;
		}
		set
		{
			chiefRate_ = value;
		}
	}

	public FUStCollectionEventProbabilityDesc()
	{
	}

	public FUStCollectionEventProbabilityDesc(FUStCollectionEventProbabilityDesc other)
		: this()
	{
		iD_ = other.iD_;
		monsterRate_ = other.monsterRate_;
		plusMonsterRate_ = other.plusMonsterRate_;
		chiefRate_ = other.chiefRate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStCollectionEventProbabilityDesc Clone()
	{
		return new FUStCollectionEventProbabilityDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStCollectionEventProbabilityDesc);
	}

	public bool Equals(FUStCollectionEventProbabilityDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (MonsterRate != other.MonsterRate)
		{
			return false;
		}
		if (PlusMonsterRate != other.PlusMonsterRate)
		{
			return false;
		}
		if (ChiefRate != other.ChiefRate)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (MonsterRate != 0)
		{
			num ^= MonsterRate.GetHashCode();
		}
		if (PlusMonsterRate != 0)
		{
			num ^= PlusMonsterRate.GetHashCode();
		}
		if (ChiefRate != 0)
		{
			num ^= ChiefRate.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (MonsterRate != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MonsterRate);
		}
		if (PlusMonsterRate != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PlusMonsterRate);
		}
		if (ChiefRate != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ChiefRate);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (MonsterRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterRate);
		}
		if (PlusMonsterRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlusMonsterRate);
		}
		if (ChiefRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChiefRate);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStCollectionEventProbabilityDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.MonsterRate != 0)
			{
				MonsterRate = other.MonsterRate;
			}
			if (other.PlusMonsterRate != 0)
			{
				PlusMonsterRate = other.PlusMonsterRate;
			}
			if (other.ChiefRate != 0)
			{
				ChiefRate = other.ChiefRate;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				MonsterRate = input.ReadInt32();
				break;
			case 24u:
				PlusMonsterRate = input.ReadInt32();
				break;
			case 32u:
				ChiefRate = input.ReadInt32();
				break;
			}
		}
	}
}
