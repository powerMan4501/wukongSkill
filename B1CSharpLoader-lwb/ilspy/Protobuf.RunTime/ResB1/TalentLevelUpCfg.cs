using System;
using Google.Protobuf;

namespace ResB1;

public sealed class TalentLevelUpCfg : IMessage<TalentLevelUpCfg>, IMessage, IEquatable<TalentLevelUpCfg>, IDeepCloneable<TalentLevelUpCfg>
{
	private static readonly MessageParser<TalentLevelUpCfg> _parser = new MessageParser<TalentLevelUpCfg>(() => new TalentLevelUpCfg());

	private UnknownFieldSet _unknownFields;

	private int level_;

	private int costTalentPoint_;

	private int costItem1Id_;

	private int costItem1Num_;

	private int costItem2Id_;

	private int costItem2Num_;

	private int costItem3Id_;

	private int costItem3Num_;

	private int attrEffectId_;

	public static MessageParser<TalentLevelUpCfg> Parser => _parser;

	public int Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	public int CostTalentPoint
	{
		get
		{
			return costTalentPoint_;
		}
		set
		{
			costTalentPoint_ = value;
		}
	}

	public int CostItem1Id
	{
		get
		{
			return costItem1Id_;
		}
		set
		{
			costItem1Id_ = value;
		}
	}

	public int CostItem1Num
	{
		get
		{
			return costItem1Num_;
		}
		set
		{
			costItem1Num_ = value;
		}
	}

	public int CostItem2Id
	{
		get
		{
			return costItem2Id_;
		}
		set
		{
			costItem2Id_ = value;
		}
	}

	public int CostItem2Num
	{
		get
		{
			return costItem2Num_;
		}
		set
		{
			costItem2Num_ = value;
		}
	}

	public int CostItem3Id
	{
		get
		{
			return costItem3Id_;
		}
		set
		{
			costItem3Id_ = value;
		}
	}

	public int CostItem3Num
	{
		get
		{
			return costItem3Num_;
		}
		set
		{
			costItem3Num_ = value;
		}
	}

	public int AttrEffectId
	{
		get
		{
			return attrEffectId_;
		}
		set
		{
			attrEffectId_ = value;
		}
	}

	public TalentLevelUpCfg()
	{
	}

	public TalentLevelUpCfg(TalentLevelUpCfg other)
		: this()
	{
		level_ = other.level_;
		costTalentPoint_ = other.costTalentPoint_;
		costItem1Id_ = other.costItem1Id_;
		costItem1Num_ = other.costItem1Num_;
		costItem2Id_ = other.costItem2Id_;
		costItem2Num_ = other.costItem2Num_;
		costItem3Id_ = other.costItem3Id_;
		costItem3Num_ = other.costItem3Num_;
		attrEffectId_ = other.attrEffectId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TalentLevelUpCfg Clone()
	{
		return new TalentLevelUpCfg(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TalentLevelUpCfg);
	}

	public bool Equals(TalentLevelUpCfg other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (CostTalentPoint != other.CostTalentPoint)
		{
			return false;
		}
		if (CostItem1Id != other.CostItem1Id)
		{
			return false;
		}
		if (CostItem1Num != other.CostItem1Num)
		{
			return false;
		}
		if (CostItem2Id != other.CostItem2Id)
		{
			return false;
		}
		if (CostItem2Num != other.CostItem2Num)
		{
			return false;
		}
		if (CostItem3Id != other.CostItem3Id)
		{
			return false;
		}
		if (CostItem3Num != other.CostItem3Num)
		{
			return false;
		}
		if (AttrEffectId != other.AttrEffectId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (CostTalentPoint != 0)
		{
			num ^= CostTalentPoint.GetHashCode();
		}
		if (CostItem1Id != 0)
		{
			num ^= CostItem1Id.GetHashCode();
		}
		if (CostItem1Num != 0)
		{
			num ^= CostItem1Num.GetHashCode();
		}
		if (CostItem2Id != 0)
		{
			num ^= CostItem2Id.GetHashCode();
		}
		if (CostItem2Num != 0)
		{
			num ^= CostItem2Num.GetHashCode();
		}
		if (CostItem3Id != 0)
		{
			num ^= CostItem3Id.GetHashCode();
		}
		if (CostItem3Num != 0)
		{
			num ^= CostItem3Num.GetHashCode();
		}
		if (AttrEffectId != 0)
		{
			num ^= AttrEffectId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Level != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Level);
		}
		if (CostTalentPoint != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CostTalentPoint);
		}
		if (CostItem1Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CostItem1Id);
		}
		if (CostItem1Num != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CostItem1Num);
		}
		if (CostItem2Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(CostItem2Id);
		}
		if (CostItem2Num != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(CostItem2Num);
		}
		if (CostItem3Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CostItem3Id);
		}
		if (CostItem3Num != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(CostItem3Num);
		}
		if (AttrEffectId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(AttrEffectId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (CostTalentPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostTalentPoint);
		}
		if (CostItem1Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostItem1Id);
		}
		if (CostItem1Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostItem1Num);
		}
		if (CostItem2Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostItem2Id);
		}
		if (CostItem2Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostItem2Num);
		}
		if (CostItem3Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostItem3Id);
		}
		if (CostItem3Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostItem3Num);
		}
		if (AttrEffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttrEffectId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TalentLevelUpCfg other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.CostTalentPoint != 0)
			{
				CostTalentPoint = other.CostTalentPoint;
			}
			if (other.CostItem1Id != 0)
			{
				CostItem1Id = other.CostItem1Id;
			}
			if (other.CostItem1Num != 0)
			{
				CostItem1Num = other.CostItem1Num;
			}
			if (other.CostItem2Id != 0)
			{
				CostItem2Id = other.CostItem2Id;
			}
			if (other.CostItem2Num != 0)
			{
				CostItem2Num = other.CostItem2Num;
			}
			if (other.CostItem3Id != 0)
			{
				CostItem3Id = other.CostItem3Id;
			}
			if (other.CostItem3Num != 0)
			{
				CostItem3Num = other.CostItem3Num;
			}
			if (other.AttrEffectId != 0)
			{
				AttrEffectId = other.AttrEffectId;
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
				Level = input.ReadInt32();
				break;
			case 16u:
				CostTalentPoint = input.ReadInt32();
				break;
			case 24u:
				CostItem1Id = input.ReadInt32();
				break;
			case 32u:
				CostItem1Num = input.ReadInt32();
				break;
			case 40u:
				CostItem2Id = input.ReadInt32();
				break;
			case 48u:
				CostItem2Num = input.ReadInt32();
				break;
			case 56u:
				CostItem3Id = input.ReadInt32();
				break;
			case 64u:
				CostItem3Num = input.ReadInt32();
				break;
			case 72u:
				AttrEffectId = input.ReadInt32();
				break;
			}
		}
	}
}
