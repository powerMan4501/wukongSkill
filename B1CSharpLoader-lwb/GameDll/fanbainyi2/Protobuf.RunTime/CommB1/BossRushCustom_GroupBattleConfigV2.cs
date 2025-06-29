using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BossRushCustom_GroupBattleConfigV2 : IMessage<BossRushCustom_GroupBattleConfigV2>, IMessage, IEquatable<BossRushCustom_GroupBattleConfigV2>, IDeepCloneable<BossRushCustom_GroupBattleConfigV2>
{
	private static readonly MessageParser<BossRushCustom_GroupBattleConfigV2> _parser = new MessageParser<BossRushCustom_GroupBattleConfigV2>(() => new BossRushCustom_GroupBattleConfigV2());

	private UnknownFieldSet _unknownFields;

	private int groupId_;

	private static readonly FieldCodec<BossRushCustom_TamerOverrideProperty> _repeated_tamerOverrideProperties_codec = FieldCodec.ForMessage(18u, BossRushCustom_TamerOverrideProperty.Parser);

	private readonly RepeatedField<BossRushCustom_TamerOverrideProperty> tamerOverrideProperties_ = new RepeatedField<BossRushCustom_TamerOverrideProperty>();

	private static readonly FieldCodec<BossRushCustom_ServantOverrideProperty> _repeated_servantOverrideProperties_codec = FieldCodec.ForMessage(26u, BossRushCustom_ServantOverrideProperty.Parser);

	private readonly RepeatedField<BossRushCustom_ServantOverrideProperty> servantOverrideProperties_ = new RepeatedField<BossRushCustom_ServantOverrideProperty>();

	private int levelNumericalStrength_;

	public static MessageParser<BossRushCustom_GroupBattleConfigV2> Parser => _parser;

	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	public RepeatedField<BossRushCustom_TamerOverrideProperty> TamerOverrideProperties => tamerOverrideProperties_;

	public RepeatedField<BossRushCustom_ServantOverrideProperty> ServantOverrideProperties => servantOverrideProperties_;

	public int LevelNumericalStrength
	{
		get
		{
			return levelNumericalStrength_;
		}
		set
		{
			levelNumericalStrength_ = value;
		}
	}

	public BossRushCustom_GroupBattleConfigV2()
	{
	}

	public BossRushCustom_GroupBattleConfigV2(BossRushCustom_GroupBattleConfigV2 other)
		: this()
	{
		groupId_ = other.groupId_;
		tamerOverrideProperties_ = other.tamerOverrideProperties_.Clone();
		servantOverrideProperties_ = other.servantOverrideProperties_.Clone();
		levelNumericalStrength_ = other.levelNumericalStrength_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushCustom_GroupBattleConfigV2 Clone()
	{
		return new BossRushCustom_GroupBattleConfigV2(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushCustom_GroupBattleConfigV2);
	}

	public bool Equals(BossRushCustom_GroupBattleConfigV2 other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (!tamerOverrideProperties_.Equals(other.tamerOverrideProperties_))
		{
			return false;
		}
		if (!servantOverrideProperties_.Equals(other.servantOverrideProperties_))
		{
			return false;
		}
		if (LevelNumericalStrength != other.LevelNumericalStrength)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		num ^= tamerOverrideProperties_.GetHashCode();
		num ^= servantOverrideProperties_.GetHashCode();
		if (LevelNumericalStrength != 0)
		{
			num ^= LevelNumericalStrength.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		tamerOverrideProperties_.WriteTo(output, _repeated_tamerOverrideProperties_codec);
		servantOverrideProperties_.WriteTo(output, _repeated_servantOverrideProperties_codec);
		if (LevelNumericalStrength != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LevelNumericalStrength);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		num += tamerOverrideProperties_.CalculateSize(_repeated_tamerOverrideProperties_codec);
		num += servantOverrideProperties_.CalculateSize(_repeated_servantOverrideProperties_codec);
		if (LevelNumericalStrength != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelNumericalStrength);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushCustom_GroupBattleConfigV2 other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			tamerOverrideProperties_.Add(other.tamerOverrideProperties_);
			servantOverrideProperties_.Add(other.servantOverrideProperties_);
			if (other.LevelNumericalStrength != 0)
			{
				LevelNumericalStrength = other.LevelNumericalStrength;
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
				GroupId = input.ReadInt32();
				break;
			case 18u:
				tamerOverrideProperties_.AddEntriesFrom(input, _repeated_tamerOverrideProperties_codec);
				break;
			case 26u:
				servantOverrideProperties_.AddEntriesFrom(input, _repeated_servantOverrideProperties_codec);
				break;
			case 32u:
				LevelNumericalStrength = input.ReadInt32();
				break;
			}
		}
	}
}
