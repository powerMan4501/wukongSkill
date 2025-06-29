using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventBattle : IMessage<ReportEventBattle>, IMessage, IEquatable<ReportEventBattle>, IDeepCloneable<ReportEventBattle>
{
	private static readonly MessageParser<ReportEventBattle> _parser = new MessageParser<ReportEventBattle>(() => new ReportEventBattle());

	private UnknownFieldSet _unknownFields;

	private string roundId_ = "";

	private PlayType playType_;

	private static readonly FieldCodec<BattlePlayer> _repeated_players_codec = FieldCodec.ForMessage(26u, BattlePlayer.Parser);

	private readonly RepeatedField<BattlePlayer> players_ = new RepeatedField<BattlePlayer>();

	private static readonly FieldCodec<BattlePlayer> _repeated_unitTrans_codec = FieldCodec.ForMessage(34u, BattlePlayer.Parser);

	private readonly RepeatedField<BattlePlayer> unitTrans_ = new RepeatedField<BattlePlayer>();

	private static readonly FieldCodec<BattleMonster> _repeated_monsts_codec = FieldCodec.ForMessage(42u, BattleMonster.Parser);

	private readonly RepeatedField<BattleMonster> monsts_ = new RepeatedField<BattleMonster>();

	private static readonly FieldCodec<BattleMonster> _repeated_aiPartners_codec = FieldCodec.ForMessage(50u, BattleMonster.Parser);

	private readonly RepeatedField<BattleMonster> aiPartners_ = new RepeatedField<BattleMonster>();

	private int dur_;

	private int totalMonster_;

	private int hardLevel_;

	private static readonly FieldCodec<int> _repeated_debuffList_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> debuffList_ = new RepeatedField<int>();

	public static MessageParser<ReportEventBattle> Parser => _parser;

	public string RoundId
	{
		get
		{
			return roundId_;
		}
		set
		{
			roundId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public PlayType PlayType
	{
		get
		{
			return playType_;
		}
		set
		{
			playType_ = value;
		}
	}

	public RepeatedField<BattlePlayer> Players => players_;

	public RepeatedField<BattlePlayer> UnitTrans => unitTrans_;

	public RepeatedField<BattleMonster> Monsts => monsts_;

	public RepeatedField<BattleMonster> AiPartners => aiPartners_;

	public int Dur
	{
		get
		{
			return dur_;
		}
		set
		{
			dur_ = value;
		}
	}

	public int TotalMonster
	{
		get
		{
			return totalMonster_;
		}
		set
		{
			totalMonster_ = value;
		}
	}

	public int HardLevel
	{
		get
		{
			return hardLevel_;
		}
		set
		{
			hardLevel_ = value;
		}
	}

	public RepeatedField<int> DebuffList => debuffList_;

	public ReportEventBattle()
	{
	}

	public ReportEventBattle(ReportEventBattle other)
		: this()
	{
		roundId_ = other.roundId_;
		playType_ = other.playType_;
		players_ = other.players_.Clone();
		unitTrans_ = other.unitTrans_.Clone();
		monsts_ = other.monsts_.Clone();
		aiPartners_ = other.aiPartners_.Clone();
		dur_ = other.dur_;
		totalMonster_ = other.totalMonster_;
		hardLevel_ = other.hardLevel_;
		debuffList_ = other.debuffList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventBattle Clone()
	{
		return new ReportEventBattle(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventBattle);
	}

	public bool Equals(ReportEventBattle other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoundId != other.RoundId)
		{
			return false;
		}
		if (PlayType != other.PlayType)
		{
			return false;
		}
		if (!players_.Equals(other.players_))
		{
			return false;
		}
		if (!unitTrans_.Equals(other.unitTrans_))
		{
			return false;
		}
		if (!monsts_.Equals(other.monsts_))
		{
			return false;
		}
		if (!aiPartners_.Equals(other.aiPartners_))
		{
			return false;
		}
		if (Dur != other.Dur)
		{
			return false;
		}
		if (TotalMonster != other.TotalMonster)
		{
			return false;
		}
		if (HardLevel != other.HardLevel)
		{
			return false;
		}
		if (!debuffList_.Equals(other.debuffList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoundId.Length != 0)
		{
			num ^= RoundId.GetHashCode();
		}
		if (PlayType != PlayType.Single)
		{
			num ^= PlayType.GetHashCode();
		}
		num ^= players_.GetHashCode();
		num ^= unitTrans_.GetHashCode();
		num ^= monsts_.GetHashCode();
		num ^= aiPartners_.GetHashCode();
		if (Dur != 0)
		{
			num ^= Dur.GetHashCode();
		}
		if (TotalMonster != 0)
		{
			num ^= TotalMonster.GetHashCode();
		}
		if (HardLevel != 0)
		{
			num ^= HardLevel.GetHashCode();
		}
		num ^= debuffList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoundId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(RoundId);
		}
		if (PlayType != PlayType.Single)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)PlayType);
		}
		players_.WriteTo(output, _repeated_players_codec);
		unitTrans_.WriteTo(output, _repeated_unitTrans_codec);
		monsts_.WriteTo(output, _repeated_monsts_codec);
		aiPartners_.WriteTo(output, _repeated_aiPartners_codec);
		if (Dur != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Dur);
		}
		if (TotalMonster != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TotalMonster);
		}
		if (HardLevel != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(HardLevel);
		}
		debuffList_.WriteTo(output, _repeated_debuffList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoundId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RoundId);
		}
		if (PlayType != PlayType.Single)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PlayType);
		}
		num += players_.CalculateSize(_repeated_players_codec);
		num += unitTrans_.CalculateSize(_repeated_unitTrans_codec);
		num += monsts_.CalculateSize(_repeated_monsts_codec);
		num += aiPartners_.CalculateSize(_repeated_aiPartners_codec);
		if (Dur != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Dur);
		}
		if (TotalMonster != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalMonster);
		}
		if (HardLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HardLevel);
		}
		num += debuffList_.CalculateSize(_repeated_debuffList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventBattle other)
	{
		if (other != null)
		{
			if (other.RoundId.Length != 0)
			{
				RoundId = other.RoundId;
			}
			if (other.PlayType != PlayType.Single)
			{
				PlayType = other.PlayType;
			}
			players_.Add(other.players_);
			unitTrans_.Add(other.unitTrans_);
			monsts_.Add(other.monsts_);
			aiPartners_.Add(other.aiPartners_);
			if (other.Dur != 0)
			{
				Dur = other.Dur;
			}
			if (other.TotalMonster != 0)
			{
				TotalMonster = other.TotalMonster;
			}
			if (other.HardLevel != 0)
			{
				HardLevel = other.HardLevel;
			}
			debuffList_.Add(other.debuffList_);
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
				RoundId = input.ReadString();
				break;
			case 16u:
				PlayType = (PlayType)input.ReadEnum();
				break;
			case 26u:
				players_.AddEntriesFrom(input, _repeated_players_codec);
				break;
			case 34u:
				unitTrans_.AddEntriesFrom(input, _repeated_unitTrans_codec);
				break;
			case 42u:
				monsts_.AddEntriesFrom(input, _repeated_monsts_codec);
				break;
			case 50u:
				aiPartners_.AddEntriesFrom(input, _repeated_aiPartners_codec);
				break;
			case 56u:
				Dur = input.ReadInt32();
				break;
			case 64u:
				TotalMonster = input.ReadInt32();
				break;
			case 72u:
				HardLevel = input.ReadInt32();
				break;
			case 80u:
			case 82u:
				debuffList_.AddEntriesFrom(input, _repeated_debuffList_codec);
				break;
			}
		}
	}
}
