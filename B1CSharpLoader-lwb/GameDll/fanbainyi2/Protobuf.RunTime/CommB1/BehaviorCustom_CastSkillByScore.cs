using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_CastSkillByScore : IMessage<BehaviorCustom_CastSkillByScore>, IMessage, IEquatable<BehaviorCustom_CastSkillByScore>, IDeepCloneable<BehaviorCustom_CastSkillByScore>
{
	private static readonly MessageParser<BehaviorCustom_CastSkillByScore> _parser = new MessageParser<BehaviorCustom_CastSkillByScore>(() => new BehaviorCustom_CastSkillByScore());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<OneCBGCastSkillInfo> _repeated_skillInfoList_codec = FieldCodec.ForMessage(10u, OneCBGCastSkillInfo.Parser);

	private readonly RepeatedField<OneCBGCastSkillInfo> skillInfoList_ = new RepeatedField<OneCBGCastSkillInfo>();

	private bool isGetTopRandomSkill_;

	private int topRandomSkillPercent_;

	private bool needTryCastAllSkillUntilSuccess_;

	public static MessageParser<BehaviorCustom_CastSkillByScore> Parser => _parser;

	public RepeatedField<OneCBGCastSkillInfo> SkillInfoList => skillInfoList_;

	public bool IsGetTopRandomSkill
	{
		get
		{
			return isGetTopRandomSkill_;
		}
		set
		{
			isGetTopRandomSkill_ = value;
		}
	}

	public int TopRandomSkillPercent
	{
		get
		{
			return topRandomSkillPercent_;
		}
		set
		{
			topRandomSkillPercent_ = value;
		}
	}

	public bool NeedTryCastAllSkillUntilSuccess
	{
		get
		{
			return needTryCastAllSkillUntilSuccess_;
		}
		set
		{
			needTryCastAllSkillUntilSuccess_ = value;
		}
	}

	public BehaviorCustom_CastSkillByScore()
	{
	}

	public BehaviorCustom_CastSkillByScore(BehaviorCustom_CastSkillByScore other)
		: this()
	{
		skillInfoList_ = other.skillInfoList_.Clone();
		isGetTopRandomSkill_ = other.isGetTopRandomSkill_;
		topRandomSkillPercent_ = other.topRandomSkillPercent_;
		needTryCastAllSkillUntilSuccess_ = other.needTryCastAllSkillUntilSuccess_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_CastSkillByScore Clone()
	{
		return new BehaviorCustom_CastSkillByScore(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_CastSkillByScore);
	}

	public bool Equals(BehaviorCustom_CastSkillByScore other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!skillInfoList_.Equals(other.skillInfoList_))
		{
			return false;
		}
		if (IsGetTopRandomSkill != other.IsGetTopRandomSkill)
		{
			return false;
		}
		if (TopRandomSkillPercent != other.TopRandomSkillPercent)
		{
			return false;
		}
		if (NeedTryCastAllSkillUntilSuccess != other.NeedTryCastAllSkillUntilSuccess)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= skillInfoList_.GetHashCode();
		if (IsGetTopRandomSkill)
		{
			num ^= IsGetTopRandomSkill.GetHashCode();
		}
		if (TopRandomSkillPercent != 0)
		{
			num ^= TopRandomSkillPercent.GetHashCode();
		}
		if (NeedTryCastAllSkillUntilSuccess)
		{
			num ^= NeedTryCastAllSkillUntilSuccess.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		skillInfoList_.WriteTo(output, _repeated_skillInfoList_codec);
		if (IsGetTopRandomSkill)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsGetTopRandomSkill);
		}
		if (TopRandomSkillPercent != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TopRandomSkillPercent);
		}
		if (NeedTryCastAllSkillUntilSuccess)
		{
			output.WriteRawTag(32);
			output.WriteBool(NeedTryCastAllSkillUntilSuccess);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += skillInfoList_.CalculateSize(_repeated_skillInfoList_codec);
		if (IsGetTopRandomSkill)
		{
			num += 2;
		}
		if (TopRandomSkillPercent != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TopRandomSkillPercent);
		}
		if (NeedTryCastAllSkillUntilSuccess)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_CastSkillByScore other)
	{
		if (other != null)
		{
			skillInfoList_.Add(other.skillInfoList_);
			if (other.IsGetTopRandomSkill)
			{
				IsGetTopRandomSkill = other.IsGetTopRandomSkill;
			}
			if (other.TopRandomSkillPercent != 0)
			{
				TopRandomSkillPercent = other.TopRandomSkillPercent;
			}
			if (other.NeedTryCastAllSkillUntilSuccess)
			{
				NeedTryCastAllSkillUntilSuccess = other.NeedTryCastAllSkillUntilSuccess;
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
				skillInfoList_.AddEntriesFrom(input, _repeated_skillInfoList_codec);
				break;
			case 16u:
				IsGetTopRandomSkill = input.ReadBool();
				break;
			case 24u:
				TopRandomSkillPercent = input.ReadInt32();
				break;
			case 32u:
				NeedTryCastAllSkillUntilSuccess = input.ReadBool();
				break;
			}
		}
	}
}
