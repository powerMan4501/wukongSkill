using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_CastSkill : IMessage<BehaviorCustom_CastSkill>, IMessage, IEquatable<BehaviorCustom_CastSkill>, IDeepCloneable<BehaviorCustom_CastSkill>
{
	private static readonly MessageParser<BehaviorCustom_CastSkill> _parser = new MessageParser<BehaviorCustom_CastSkill>(() => new BehaviorCustom_CastSkill());

	private UnknownFieldSet _unknownFields;

	private int skillId_;

	private bool needCheckSkillCanCast_;

	private string montageStartSectionName_ = "";

	private bool canCastWhenDead_;

	public static MessageParser<BehaviorCustom_CastSkill> Parser => _parser;

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

	public bool NeedCheckSkillCanCast
	{
		get
		{
			return needCheckSkillCanCast_;
		}
		set
		{
			needCheckSkillCanCast_ = value;
		}
	}

	public string MontageStartSectionName
	{
		get
		{
			return montageStartSectionName_;
		}
		set
		{
			montageStartSectionName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool CanCastWhenDead
	{
		get
		{
			return canCastWhenDead_;
		}
		set
		{
			canCastWhenDead_ = value;
		}
	}

	public BehaviorCustom_CastSkill()
	{
	}

	public BehaviorCustom_CastSkill(BehaviorCustom_CastSkill other)
		: this()
	{
		skillId_ = other.skillId_;
		needCheckSkillCanCast_ = other.needCheckSkillCanCast_;
		montageStartSectionName_ = other.montageStartSectionName_;
		canCastWhenDead_ = other.canCastWhenDead_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_CastSkill Clone()
	{
		return new BehaviorCustom_CastSkill(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_CastSkill);
	}

	public bool Equals(BehaviorCustom_CastSkill other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (NeedCheckSkillCanCast != other.NeedCheckSkillCanCast)
		{
			return false;
		}
		if (MontageStartSectionName != other.MontageStartSectionName)
		{
			return false;
		}
		if (CanCastWhenDead != other.CanCastWhenDead)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (NeedCheckSkillCanCast)
		{
			num ^= NeedCheckSkillCanCast.GetHashCode();
		}
		if (MontageStartSectionName.Length != 0)
		{
			num ^= MontageStartSectionName.GetHashCode();
		}
		if (CanCastWhenDead)
		{
			num ^= CanCastWhenDead.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SkillId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SkillId);
		}
		if (NeedCheckSkillCanCast)
		{
			output.WriteRawTag(16);
			output.WriteBool(NeedCheckSkillCanCast);
		}
		if (MontageStartSectionName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(MontageStartSectionName);
		}
		if (CanCastWhenDead)
		{
			output.WriteRawTag(32);
			output.WriteBool(CanCastWhenDead);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillId);
		}
		if (NeedCheckSkillCanCast)
		{
			num += 2;
		}
		if (MontageStartSectionName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MontageStartSectionName);
		}
		if (CanCastWhenDead)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_CastSkill other)
	{
		if (other != null)
		{
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.NeedCheckSkillCanCast)
			{
				NeedCheckSkillCanCast = other.NeedCheckSkillCanCast;
			}
			if (other.MontageStartSectionName.Length != 0)
			{
				MontageStartSectionName = other.MontageStartSectionName;
			}
			if (other.CanCastWhenDead)
			{
				CanCastWhenDead = other.CanCastWhenDead;
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
				SkillId = input.ReadInt32();
				break;
			case 16u:
				NeedCheckSkillCanCast = input.ReadBool();
				break;
			case 26u:
				MontageStartSectionName = input.ReadString();
				break;
			case 32u:
				CanCastWhenDead = input.ReadBool();
				break;
			}
		}
	}
}
