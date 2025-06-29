using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_ChildActorCastSkill : IMessage<BehaviorCustom_ChildActorCastSkill>, IMessage, IEquatable<BehaviorCustom_ChildActorCastSkill>, IDeepCloneable<BehaviorCustom_ChildActorCastSkill>
{
	private static readonly MessageParser<BehaviorCustom_ChildActorCastSkill> _parser = new MessageParser<BehaviorCustom_ChildActorCastSkill>(() => new BehaviorCustom_ChildActorCastSkill());

	private UnknownFieldSet _unknownFields;

	private int skillId_;

	private bool needCheckSkillCanCast_;

	private ByteString matchInfo_ = ByteString.Empty;

	public static MessageParser<BehaviorCustom_ChildActorCastSkill> Parser => _parser;

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

	public ByteString MatchInfo
	{
		get
		{
			return matchInfo_;
		}
		set
		{
			matchInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_ChildActorCastSkill()
	{
	}

	public BehaviorCustom_ChildActorCastSkill(BehaviorCustom_ChildActorCastSkill other)
		: this()
	{
		skillId_ = other.skillId_;
		needCheckSkillCanCast_ = other.needCheckSkillCanCast_;
		matchInfo_ = other.matchInfo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_ChildActorCastSkill Clone()
	{
		return new BehaviorCustom_ChildActorCastSkill(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_ChildActorCastSkill);
	}

	public bool Equals(BehaviorCustom_ChildActorCastSkill other)
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
		if (MatchInfo != other.MatchInfo)
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
		if (MatchInfo.Length != 0)
		{
			num ^= MatchInfo.GetHashCode();
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
		if (MatchInfo.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteBytes(MatchInfo);
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
		if (MatchInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(MatchInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_ChildActorCastSkill other)
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
			if (other.MatchInfo.Length != 0)
			{
				MatchInfo = other.MatchInfo;
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
				MatchInfo = input.ReadBytes();
				break;
			}
		}
	}
}
