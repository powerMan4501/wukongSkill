using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_PlayerCastSkill : IMessage<QuestCustom_PlayerCastSkill>, IMessage, IEquatable<QuestCustom_PlayerCastSkill>, IDeepCloneable<QuestCustom_PlayerCastSkill>
{
	private static readonly MessageParser<QuestCustom_PlayerCastSkill> _parser = new MessageParser<QuestCustom_PlayerCastSkill>(() => new QuestCustom_PlayerCastSkill());

	private UnknownFieldSet _unknownFields;

	private int comboKey_;

	private int direction_;

	private int skillId_;

	private QuestCustom_PlayerCastSkillConditionGroupList skillCastCondition_;

	public static MessageParser<QuestCustom_PlayerCastSkill> Parser => _parser;

	public int ComboKey
	{
		get
		{
			return comboKey_;
		}
		set
		{
			comboKey_ = value;
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

	public int SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
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

	public QuestCustom_PlayerCastSkill()
	{
	}

	public QuestCustom_PlayerCastSkill(QuestCustom_PlayerCastSkill other)
		: this()
	{
		comboKey_ = other.comboKey_;
		direction_ = other.direction_;
		skillId_ = other.skillId_;
		skillCastCondition_ = ((other.skillCastCondition_ != null) ? other.skillCastCondition_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_PlayerCastSkill Clone()
	{
		return new QuestCustom_PlayerCastSkill(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_PlayerCastSkill);
	}

	public bool Equals(QuestCustom_PlayerCastSkill other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ComboKey != other.ComboKey)
		{
			return false;
		}
		if (Direction != other.Direction)
		{
			return false;
		}
		if (SkillId != other.SkillId)
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
		if (ComboKey != 0)
		{
			num ^= ComboKey.GetHashCode();
		}
		if (Direction != 0)
		{
			num ^= Direction.GetHashCode();
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
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
		if (ComboKey != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ComboKey);
		}
		if (Direction != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Direction);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SkillId);
		}
		if (skillCastCondition_ != null)
		{
			output.WriteRawTag(34);
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
		if (ComboKey != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ComboKey);
		}
		if (Direction != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Direction);
		}
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillId);
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

	public void MergeFrom(QuestCustom_PlayerCastSkill other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ComboKey != 0)
		{
			ComboKey = other.ComboKey;
		}
		if (other.Direction != 0)
		{
			Direction = other.Direction;
		}
		if (other.SkillId != 0)
		{
			SkillId = other.SkillId;
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
				ComboKey = input.ReadInt32();
				break;
			case 16u:
				Direction = input.ReadInt32();
				break;
			case 24u:
				SkillId = input.ReadInt32();
				break;
			case 34u:
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
