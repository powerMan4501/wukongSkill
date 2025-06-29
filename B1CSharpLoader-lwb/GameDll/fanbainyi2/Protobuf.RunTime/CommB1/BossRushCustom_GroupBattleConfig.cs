using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BossRushCustom_GroupBattleConfig : IMessage<BossRushCustom_GroupBattleConfig>, IMessage, IEquatable<BossRushCustom_GroupBattleConfig>, IDeepCloneable<BossRushCustom_GroupBattleConfig>
{
	private static readonly MessageParser<BossRushCustom_GroupBattleConfig> _parser = new MessageParser<BossRushCustom_GroupBattleConfig>(() => new BossRushCustom_GroupBattleConfig());

	private UnknownFieldSet _unknownFields;

	private int groupId_;

	private static readonly FieldCodec<BossRushCustom_TamerOverrideProperty> _repeated_tamerOverrideProperties_codec = FieldCodec.ForMessage(18u, BossRushCustom_TamerOverrideProperty.Parser);

	private readonly RepeatedField<BossRushCustom_TamerOverrideProperty> tamerOverrideProperties_ = new RepeatedField<BossRushCustom_TamerOverrideProperty>();

	public static MessageParser<BossRushCustom_GroupBattleConfig> Parser => _parser;

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

	public BossRushCustom_GroupBattleConfig()
	{
	}

	public BossRushCustom_GroupBattleConfig(BossRushCustom_GroupBattleConfig other)
		: this()
	{
		groupId_ = other.groupId_;
		tamerOverrideProperties_ = other.tamerOverrideProperties_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushCustom_GroupBattleConfig Clone()
	{
		return new BossRushCustom_GroupBattleConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushCustom_GroupBattleConfig);
	}

	public bool Equals(BossRushCustom_GroupBattleConfig other)
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushCustom_GroupBattleConfig other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			tamerOverrideProperties_.Add(other.tamerOverrideProperties_);
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
			}
		}
	}
}
