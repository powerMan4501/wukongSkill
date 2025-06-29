using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_PlayerCastMagic : IMessage<QuestCustom_PlayerCastMagic>, IMessage, IEquatable<QuestCustom_PlayerCastMagic>, IDeepCloneable<QuestCustom_PlayerCastMagic>
{
	private static readonly MessageParser<QuestCustom_PlayerCastMagic> _parser = new MessageParser<QuestCustom_PlayerCastMagic>(() => new QuestCustom_PlayerCastMagic());

	private UnknownFieldSet _unknownFields;

	private int castType_;

	private int direction_;

	private QuestCustom_PlayerCastSkillConditionGroupList skillCastCondition_;

	public static MessageParser<QuestCustom_PlayerCastMagic> Parser => _parser;

	public int CastType
	{
		get
		{
			return castType_;
		}
		set
		{
			castType_ = value;
		}
	}

	public int Direction
	{
		get
		{
			return direction_;
		}
		set
		{
			direction_ = value;
		}
	}

	public QuestCustom_PlayerCastSkillConditionGroupList SkillCastCondition
	{
		get
		{
			return skillCastCondition_;
		}
		set
		{
			skillCastCondition_ = value;
		}
	}

	public QuestCustom_PlayerCastMagic()
	{
	}

	public QuestCustom_PlayerCastMagic(QuestCustom_PlayerCastMagic other)
		: this()
	{
		castType_ = other.castType_;
		direction_ = other.direction_;
		skillCastCondition_ = ((other.skillCastCondition_ != null) ? other.skillCastCondition_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_PlayerCastMagic Clone()
	{
		return new QuestCustom_PlayerCastMagic(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_PlayerCastMagic);
	}

	public bool Equals(QuestCustom_PlayerCastMagic other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CastType != other.CastType)
		{
			return false;
		}
		if (Direction != other.Direction)
		{
			return false;
		}
		if (!object.Equals(SkillCastCondition, other.SkillCastCondition))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CastType != 0)
		{
			num ^= CastType.GetHashCode();
		}
		if (Direction != 0)
		{
			num ^= Direction.GetHashCode();
		}
		if (skillCastCondition_ != null)
		{
			num ^= SkillCastCondition.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CastType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CastType);
		}
		if (Direction != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Direction);
		}
		if (skillCastCondition_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(SkillCastCondition);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CastType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CastType);
		}
		if (Direction != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Direction);
		}
		if (skillCastCondition_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SkillCastCondition);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_PlayerCastMagic other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CastType != 0)
		{
			CastType = other.CastType;
		}
		if (other.Direction != 0)
		{
			Direction = other.Direction;
		}
		if (other.skillCastCondition_ != null)
		{
			if (skillCastCondition_ == null)
			{
				SkillCastCondition = new QuestCustom_PlayerCastSkillConditionGroupList();
			}
			SkillCastCondition.MergeFrom(other.SkillCastCondition);
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
				CastType = input.ReadInt32();
				break;
			case 16u:
				Direction = input.ReadInt32();
				break;
			case 26u:
				if (skillCastCondition_ == null)
				{
					SkillCastCondition = new QuestCustom_PlayerCastSkillConditionGroupList();
				}
				input.ReadMessage(SkillCastCondition);
				break;
			}
		}
	}
}
