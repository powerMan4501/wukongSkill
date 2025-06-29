using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BPC_PlayerAttrData : IMessage<BPC_PlayerAttrData>, IMessage, IEquatable<BPC_PlayerAttrData>, IDeepCloneable<BPC_PlayerAttrData>
{
	private static readonly MessageParser<BPC_PlayerAttrData> _parser = new MessageParser<BPC_PlayerAttrData>(() => new BPC_PlayerAttrData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private static readonly FieldCodec<ListDeltaMsgPlayerPersistentAttr> _repeated_playerPersistentAttr_codec = FieldCodec.ForMessage(10u, ListDeltaMsgPlayerPersistentAttr.Parser);

	private readonly RepeatedField<ListDeltaMsgPlayerPersistentAttr> playerPersistentAttr_ = new RepeatedField<ListDeltaMsgPlayerPersistentAttr>();

	private static readonly FieldCodec<ListDeltaMsgPlayerFabaoCd> _repeated_playerFabaoCdRemoved_codec = FieldCodec.ForMessage(18u, ListDeltaMsgPlayerFabaoCd.Parser);

	private readonly RepeatedField<ListDeltaMsgPlayerFabaoCd> playerFabaoCdRemoved_ = new RepeatedField<ListDeltaMsgPlayerFabaoCd>();

	private static readonly FieldCodec<ListDeltaMsgPlayerMagicSkillCd> _repeated_playerMagicSkillCd_codec = FieldCodec.ForMessage(26u, ListDeltaMsgPlayerMagicSkillCd.Parser);

	private readonly RepeatedField<ListDeltaMsgPlayerMagicSkillCd> playerMagicSkillCd_ = new RepeatedField<ListDeltaMsgPlayerMagicSkillCd>();

	private PlayerLifeSavingHairInfo playerLifeSavingHairInfoRemoved_;

	private PlayerLifeSavingHairInfo lifeSavingHairInfoRemoved_;

	private static readonly FieldCodec<DictDeltaMsgString_Int> _repeated_keyMonsterMeetCount_codec = FieldCodec.ForMessage(50u, DictDeltaMsgString_Int.Parser);

	private readonly RepeatedField<DictDeltaMsgString_Int> keyMonsterMeetCount_ = new RepeatedField<DictDeltaMsgString_Int>();

	private static readonly FieldCodec<DictDeltaMsgString_Int> _repeated_keyMonsterBattlePlayerDieTimes_codec = FieldCodec.ForMessage(58u, DictDeltaMsgString_Int.Parser);

	private readonly RepeatedField<DictDeltaMsgString_Int> keyMonsterBattlePlayerDieTimes_ = new RepeatedField<DictDeltaMsgString_Int>();

	private float playerLifeSavingCoolDownRemainTime_;

	public static MessageParser<BPC_PlayerAttrData> Parser => _parser;

	public RepeatedField<ListDeltaMsgPlayerPersistentAttr> PlayerPersistentAttr => playerPersistentAttr_;

	public RepeatedField<ListDeltaMsgPlayerFabaoCd> PlayerFabaoCdRemoved => playerFabaoCdRemoved_;

	public RepeatedField<ListDeltaMsgPlayerMagicSkillCd> PlayerMagicSkillCd => playerMagicSkillCd_;

	public PlayerLifeSavingHairInfo PlayerLifeSavingHairInfoRemoved
	{
		get
		{
			return playerLifeSavingHairInfoRemoved_;
		}
		set
		{
			playerLifeSavingHairInfoRemoved_ = value;
		}
	}

	public PlayerLifeSavingHairInfo LifeSavingHairInfoRemoved
	{
		get
		{
			return lifeSavingHairInfoRemoved_;
		}
		set
		{
			lifeSavingHairInfoRemoved_ = value;
		}
	}

	public RepeatedField<DictDeltaMsgString_Int> KeyMonsterMeetCount => keyMonsterMeetCount_;

	public RepeatedField<DictDeltaMsgString_Int> KeyMonsterBattlePlayerDieTimes => keyMonsterBattlePlayerDieTimes_;

	public float PlayerLifeSavingCoolDownRemainTime
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return playerLifeSavingCoolDownRemainTime_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 1;
			playerLifeSavingCoolDownRemainTime_ = value;
		}
	}

	public bool HasPlayerLifeSavingCoolDownRemainTime => (_hasBits0 & 1) != 0;

	public BPC_PlayerAttrData()
	{
	}

	public BPC_PlayerAttrData(BPC_PlayerAttrData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		playerPersistentAttr_ = other.playerPersistentAttr_.Clone();
		playerFabaoCdRemoved_ = other.playerFabaoCdRemoved_.Clone();
		playerMagicSkillCd_ = other.playerMagicSkillCd_.Clone();
		playerLifeSavingHairInfoRemoved_ = ((other.playerLifeSavingHairInfoRemoved_ != null) ? other.playerLifeSavingHairInfoRemoved_.Clone() : null);
		lifeSavingHairInfoRemoved_ = ((other.lifeSavingHairInfoRemoved_ != null) ? other.lifeSavingHairInfoRemoved_.Clone() : null);
		keyMonsterMeetCount_ = other.keyMonsterMeetCount_.Clone();
		keyMonsterBattlePlayerDieTimes_ = other.keyMonsterBattlePlayerDieTimes_.Clone();
		playerLifeSavingCoolDownRemainTime_ = other.playerLifeSavingCoolDownRemainTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BPC_PlayerAttrData Clone()
	{
		return new BPC_PlayerAttrData(this);
	}

	public void ClearPlayerLifeSavingCoolDownRemainTime()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BPC_PlayerAttrData);
	}

	public bool Equals(BPC_PlayerAttrData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!playerPersistentAttr_.Equals(other.playerPersistentAttr_))
		{
			return false;
		}
		if (!playerFabaoCdRemoved_.Equals(other.playerFabaoCdRemoved_))
		{
			return false;
		}
		if (!playerMagicSkillCd_.Equals(other.playerMagicSkillCd_))
		{
			return false;
		}
		if (!object.Equals(PlayerLifeSavingHairInfoRemoved, other.PlayerLifeSavingHairInfoRemoved))
		{
			return false;
		}
		if (!object.Equals(LifeSavingHairInfoRemoved, other.LifeSavingHairInfoRemoved))
		{
			return false;
		}
		if (!keyMonsterMeetCount_.Equals(other.keyMonsterMeetCount_))
		{
			return false;
		}
		if (!keyMonsterBattlePlayerDieTimes_.Equals(other.keyMonsterBattlePlayerDieTimes_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayerLifeSavingCoolDownRemainTime, other.PlayerLifeSavingCoolDownRemainTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= playerPersistentAttr_.GetHashCode();
		num ^= playerFabaoCdRemoved_.GetHashCode();
		num ^= playerMagicSkillCd_.GetHashCode();
		if (playerLifeSavingHairInfoRemoved_ != null)
		{
			num ^= PlayerLifeSavingHairInfoRemoved.GetHashCode();
		}
		if (lifeSavingHairInfoRemoved_ != null)
		{
			num ^= LifeSavingHairInfoRemoved.GetHashCode();
		}
		num ^= keyMonsterMeetCount_.GetHashCode();
		num ^= keyMonsterBattlePlayerDieTimes_.GetHashCode();
		if (HasPlayerLifeSavingCoolDownRemainTime)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayerLifeSavingCoolDownRemainTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		playerPersistentAttr_.WriteTo(output, _repeated_playerPersistentAttr_codec);
		playerFabaoCdRemoved_.WriteTo(output, _repeated_playerFabaoCdRemoved_codec);
		playerMagicSkillCd_.WriteTo(output, _repeated_playerMagicSkillCd_codec);
		if (playerLifeSavingHairInfoRemoved_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PlayerLifeSavingHairInfoRemoved);
		}
		if (lifeSavingHairInfoRemoved_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(LifeSavingHairInfoRemoved);
		}
		keyMonsterMeetCount_.WriteTo(output, _repeated_keyMonsterMeetCount_codec);
		keyMonsterBattlePlayerDieTimes_.WriteTo(output, _repeated_keyMonsterBattlePlayerDieTimes_codec);
		if (HasPlayerLifeSavingCoolDownRemainTime)
		{
			output.WriteRawTag(69);
			output.WriteFloat(PlayerLifeSavingCoolDownRemainTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += playerPersistentAttr_.CalculateSize(_repeated_playerPersistentAttr_codec);
		num += playerFabaoCdRemoved_.CalculateSize(_repeated_playerFabaoCdRemoved_codec);
		num += playerMagicSkillCd_.CalculateSize(_repeated_playerMagicSkillCd_codec);
		if (playerLifeSavingHairInfoRemoved_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerLifeSavingHairInfoRemoved);
		}
		if (lifeSavingHairInfoRemoved_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LifeSavingHairInfoRemoved);
		}
		num += keyMonsterMeetCount_.CalculateSize(_repeated_keyMonsterMeetCount_codec);
		num += keyMonsterBattlePlayerDieTimes_.CalculateSize(_repeated_keyMonsterBattlePlayerDieTimes_codec);
		if (HasPlayerLifeSavingCoolDownRemainTime)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BPC_PlayerAttrData other)
	{
		if (other == null)
		{
			return;
		}
		playerPersistentAttr_.Add(other.playerPersistentAttr_);
		playerFabaoCdRemoved_.Add(other.playerFabaoCdRemoved_);
		playerMagicSkillCd_.Add(other.playerMagicSkillCd_);
		if (other.playerLifeSavingHairInfoRemoved_ != null)
		{
			if (playerLifeSavingHairInfoRemoved_ == null)
			{
				PlayerLifeSavingHairInfoRemoved = new PlayerLifeSavingHairInfo();
			}
			PlayerLifeSavingHairInfoRemoved.MergeFrom(other.PlayerLifeSavingHairInfoRemoved);
		}
		if (other.lifeSavingHairInfoRemoved_ != null)
		{
			if (lifeSavingHairInfoRemoved_ == null)
			{
				LifeSavingHairInfoRemoved = new PlayerLifeSavingHairInfo();
			}
			LifeSavingHairInfoRemoved.MergeFrom(other.LifeSavingHairInfoRemoved);
		}
		keyMonsterMeetCount_.Add(other.keyMonsterMeetCount_);
		keyMonsterBattlePlayerDieTimes_.Add(other.keyMonsterBattlePlayerDieTimes_);
		if (other.HasPlayerLifeSavingCoolDownRemainTime)
		{
			PlayerLifeSavingCoolDownRemainTime = other.PlayerLifeSavingCoolDownRemainTime;
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
			case 10u:
				playerPersistentAttr_.AddEntriesFrom(input, _repeated_playerPersistentAttr_codec);
				break;
			case 18u:
				playerFabaoCdRemoved_.AddEntriesFrom(input, _repeated_playerFabaoCdRemoved_codec);
				break;
			case 26u:
				playerMagicSkillCd_.AddEntriesFrom(input, _repeated_playerMagicSkillCd_codec);
				break;
			case 34u:
				if (playerLifeSavingHairInfoRemoved_ == null)
				{
					PlayerLifeSavingHairInfoRemoved = new PlayerLifeSavingHairInfo();
				}
				input.ReadMessage(PlayerLifeSavingHairInfoRemoved);
				break;
			case 42u:
				if (lifeSavingHairInfoRemoved_ == null)
				{
					LifeSavingHairInfoRemoved = new PlayerLifeSavingHairInfo();
				}
				input.ReadMessage(LifeSavingHairInfoRemoved);
				break;
			case 50u:
				keyMonsterMeetCount_.AddEntriesFrom(input, _repeated_keyMonsterMeetCount_codec);
				break;
			case 58u:
				keyMonsterBattlePlayerDieTimes_.AddEntriesFrom(input, _repeated_keyMonsterBattlePlayerDieTimes_codec);
				break;
			case 69u:
				PlayerLifeSavingCoolDownRemainTime = input.ReadFloat();
				break;
			}
		}
	}
}
