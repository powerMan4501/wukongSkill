using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BossRushCustom_InitialV2 : IMessage<BossRushCustom_InitialV2>, IMessage, IEquatable<BossRushCustom_InitialV2>, IDeepCloneable<BossRushCustom_InitialV2>
{
	private static readonly MessageParser<BossRushCustom_InitialV2> _parser = new MessageParser<BossRushCustom_InitialV2>(() => new BossRushCustom_InitialV2());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ProcessCustom_Param> _repeated_assetParams_codec = FieldCodec.ForMessage(10u, ProcessCustom_Param.Parser);

	private readonly RepeatedField<ProcessCustom_Param> assetParams_ = new RepeatedField<ProcessCustom_Param>();

	private string levelName_ = "";

	private static readonly FieldCodec<BossRushCustom_LevelLoadState> _repeated_modifiedLevelState_codec = FieldCodec.ForMessage(26u, BossRushCustom_LevelLoadState.Parser);

	private readonly RepeatedField<BossRushCustom_LevelLoadState> modifiedLevelState_ = new RepeatedField<BossRushCustom_LevelLoadState>();

	private CalliopeCustom_Transform playerStartForSingle_;

	private CalliopeCustom_Transform playerStartForGroup_;

	private static readonly FieldCodec<BossRushCustom_GroupBattleConfigV2> _repeated_groupBattleConfigs_codec = FieldCodec.ForMessage(50u, BossRushCustom_GroupBattleConfigV2.Parser);

	private readonly RepeatedField<BossRushCustom_GroupBattleConfigV2> groupBattleConfigs_ = new RepeatedField<BossRushCustom_GroupBattleConfigV2>();

	private static readonly FieldCodec<BossRushCustom_TableOverride> _repeated_tableOverrides_codec = FieldCodec.ForMessage(58u, BossRushCustom_TableOverride.Parser);

	private readonly RepeatedField<BossRushCustom_TableOverride> tableOverrides_ = new RepeatedField<BossRushCustom_TableOverride>();

	public static MessageParser<BossRushCustom_InitialV2> Parser => _parser;

	public RepeatedField<ProcessCustom_Param> AssetParams => assetParams_;

	public string LevelName
	{
		get
		{
			return levelName_;
		}
		set
		{
			levelName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<BossRushCustom_LevelLoadState> ModifiedLevelState => modifiedLevelState_;

	public CalliopeCustom_Transform PlayerStartForSingle
	{
		get
		{
			return playerStartForSingle_;
		}
		set
		{
			playerStartForSingle_ = value;
		}
	}

	public CalliopeCustom_Transform PlayerStartForGroup
	{
		get
		{
			return playerStartForGroup_;
		}
		set
		{
			playerStartForGroup_ = value;
		}
	}

	public RepeatedField<BossRushCustom_GroupBattleConfigV2> GroupBattleConfigs => groupBattleConfigs_;

	public RepeatedField<BossRushCustom_TableOverride> TableOverrides => tableOverrides_;

	public BossRushCustom_InitialV2()
	{
	}

	public BossRushCustom_InitialV2(BossRushCustom_InitialV2 other)
		: this()
	{
		assetParams_ = other.assetParams_.Clone();
		levelName_ = other.levelName_;
		modifiedLevelState_ = other.modifiedLevelState_.Clone();
		playerStartForSingle_ = ((other.playerStartForSingle_ != null) ? other.playerStartForSingle_.Clone() : null);
		playerStartForGroup_ = ((other.playerStartForGroup_ != null) ? other.playerStartForGroup_.Clone() : null);
		groupBattleConfigs_ = other.groupBattleConfigs_.Clone();
		tableOverrides_ = other.tableOverrides_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushCustom_InitialV2 Clone()
	{
		return new BossRushCustom_InitialV2(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushCustom_InitialV2);
	}

	public bool Equals(BossRushCustom_InitialV2 other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!assetParams_.Equals(other.assetParams_))
		{
			return false;
		}
		if (LevelName != other.LevelName)
		{
			return false;
		}
		if (!modifiedLevelState_.Equals(other.modifiedLevelState_))
		{
			return false;
		}
		if (!object.Equals(PlayerStartForSingle, other.PlayerStartForSingle))
		{
			return false;
		}
		if (!object.Equals(PlayerStartForGroup, other.PlayerStartForGroup))
		{
			return false;
		}
		if (!groupBattleConfigs_.Equals(other.groupBattleConfigs_))
		{
			return false;
		}
		if (!tableOverrides_.Equals(other.tableOverrides_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= assetParams_.GetHashCode();
		if (LevelName.Length != 0)
		{
			num ^= LevelName.GetHashCode();
		}
		num ^= modifiedLevelState_.GetHashCode();
		if (playerStartForSingle_ != null)
		{
			num ^= PlayerStartForSingle.GetHashCode();
		}
		if (playerStartForGroup_ != null)
		{
			num ^= PlayerStartForGroup.GetHashCode();
		}
		num ^= groupBattleConfigs_.GetHashCode();
		num ^= tableOverrides_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		assetParams_.WriteTo(output, _repeated_assetParams_codec);
		if (LevelName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(LevelName);
		}
		modifiedLevelState_.WriteTo(output, _repeated_modifiedLevelState_codec);
		if (playerStartForSingle_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PlayerStartForSingle);
		}
		if (playerStartForGroup_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PlayerStartForGroup);
		}
		groupBattleConfigs_.WriteTo(output, _repeated_groupBattleConfigs_codec);
		tableOverrides_.WriteTo(output, _repeated_tableOverrides_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += assetParams_.CalculateSize(_repeated_assetParams_codec);
		if (LevelName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LevelName);
		}
		num += modifiedLevelState_.CalculateSize(_repeated_modifiedLevelState_codec);
		if (playerStartForSingle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerStartForSingle);
		}
		if (playerStartForGroup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerStartForGroup);
		}
		num += groupBattleConfigs_.CalculateSize(_repeated_groupBattleConfigs_codec);
		num += tableOverrides_.CalculateSize(_repeated_tableOverrides_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushCustom_InitialV2 other)
	{
		if (other == null)
		{
			return;
		}
		assetParams_.Add(other.assetParams_);
		if (other.LevelName.Length != 0)
		{
			LevelName = other.LevelName;
		}
		modifiedLevelState_.Add(other.modifiedLevelState_);
		if (other.playerStartForSingle_ != null)
		{
			if (playerStartForSingle_ == null)
			{
				PlayerStartForSingle = new CalliopeCustom_Transform();
			}
			PlayerStartForSingle.MergeFrom(other.PlayerStartForSingle);
		}
		if (other.playerStartForGroup_ != null)
		{
			if (playerStartForGroup_ == null)
			{
				PlayerStartForGroup = new CalliopeCustom_Transform();
			}
			PlayerStartForGroup.MergeFrom(other.PlayerStartForGroup);
		}
		groupBattleConfigs_.Add(other.groupBattleConfigs_);
		tableOverrides_.Add(other.tableOverrides_);
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
			case 10u:
				assetParams_.AddEntriesFrom(input, _repeated_assetParams_codec);
				break;
			case 18u:
				LevelName = input.ReadString();
				break;
			case 26u:
				modifiedLevelState_.AddEntriesFrom(input, _repeated_modifiedLevelState_codec);
				break;
			case 34u:
				if (playerStartForSingle_ == null)
				{
					PlayerStartForSingle = new CalliopeCustom_Transform();
				}
				input.ReadMessage(PlayerStartForSingle);
				break;
			case 42u:
				if (playerStartForGroup_ == null)
				{
					PlayerStartForGroup = new CalliopeCustom_Transform();
				}
				input.ReadMessage(PlayerStartForGroup);
				break;
			case 50u:
				groupBattleConfigs_.AddEntriesFrom(input, _repeated_groupBattleConfigs_codec);
				break;
			case 58u:
				tableOverrides_.AddEntriesFrom(input, _repeated_tableOverrides_codec);
				break;
			}
		}
	}
}
