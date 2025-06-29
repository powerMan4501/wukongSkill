using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class BattleMonster : IMessage<BattleMonster>, IMessage, IEquatable<BattleMonster>, IDeepCloneable<BattleMonster>
{
	private static readonly MessageParser<BattleMonster> _parser = new MessageParser<BattleMonster>(() => new BattleMonster());

	private UnknownFieldSet _unknownFields;

	private BattleEndType endType_;

	private int extendId_;

	private int quality_;

	private string guid_ = "";

	private static readonly FieldCodec<Item> _repeated_itemUse_codec = FieldCodec.ForMessage(42u, Item.Parser);

	private readonly RepeatedField<Item> itemUse_ = new RepeatedField<Item>();

	private static readonly FieldCodec<Attack> _repeated_atk_codec = FieldCodec.ForMessage(50u, Attack.Parser);

	private readonly RepeatedField<Attack> atk_ = new RepeatedField<Attack>();

	private static readonly FieldCodec<Defence> _repeated_def_codec = FieldCodec.ForMessage(58u, Defence.Parser);

	private readonly RepeatedField<Defence> def_ = new RepeatedField<Defence>();

	private int dur_;

	private int caller_;

	private static readonly FieldCodec<SpellFire> _repeated_spellFires_codec = FieldCodec.ForMessage(82u, SpellFire.Parser);

	private readonly RepeatedField<SpellFire> spellFires_ = new RepeatedField<SpellFire>();

	private int battleCount_;

	private int avgFps_;

	private int maxFps_;

	private int minFps_;

	private int hpMax_;

	private int playerDieTimes_;

	public static MessageParser<BattleMonster> Parser => _parser;

	public BattleEndType EndType
	{
		get
		{
			return endType_;
		}
		set
		{
			endType_ = value;
		}
	}

	public int ExtendId
	{
		get
		{
			return extendId_;
		}
		set
		{
			extendId_ = value;
		}
	}

	public int Quality
	{
		get
		{
			return quality_;
		}
		set
		{
			quality_ = value;
		}
	}

	public string Guid
	{
		get
		{
			return guid_;
		}
		set
		{
			guid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<Item> ItemUse => itemUse_;

	public RepeatedField<Attack> Atk => atk_;

	public RepeatedField<Defence> Def => def_;

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

	public int Caller
	{
		get
		{
			return caller_;
		}
		set
		{
			caller_ = value;
		}
	}

	public RepeatedField<SpellFire> SpellFires => spellFires_;

	public int BattleCount
	{
		get
		{
			return battleCount_;
		}
		set
		{
			battleCount_ = value;
		}
	}

	public int AvgFps
	{
		get
		{
			return avgFps_;
		}
		set
		{
			avgFps_ = value;
		}
	}

	public int MaxFps
	{
		get
		{
			return maxFps_;
		}
		set
		{
			maxFps_ = value;
		}
	}

	public int MinFps
	{
		get
		{
			return minFps_;
		}
		set
		{
			minFps_ = value;
		}
	}

	public int HpMax
	{
		get
		{
			return hpMax_;
		}
		set
		{
			hpMax_ = value;
		}
	}

	public int PlayerDieTimes
	{
		get
		{
			return playerDieTimes_;
		}
		set
		{
			playerDieTimes_ = value;
		}
	}

	public BattleMonster()
	{
	}

	public BattleMonster(BattleMonster other)
		: this()
	{
		endType_ = other.endType_;
		extendId_ = other.extendId_;
		quality_ = other.quality_;
		guid_ = other.guid_;
		itemUse_ = other.itemUse_.Clone();
		atk_ = other.atk_.Clone();
		def_ = other.def_.Clone();
		dur_ = other.dur_;
		caller_ = other.caller_;
		spellFires_ = other.spellFires_.Clone();
		battleCount_ = other.battleCount_;
		avgFps_ = other.avgFps_;
		maxFps_ = other.maxFps_;
		minFps_ = other.minFps_;
		hpMax_ = other.hpMax_;
		playerDieTimes_ = other.playerDieTimes_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BattleMonster Clone()
	{
		return new BattleMonster(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BattleMonster);
	}

	public bool Equals(BattleMonster other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EndType != other.EndType)
		{
			return false;
		}
		if (ExtendId != other.ExtendId)
		{
			return false;
		}
		if (Quality != other.Quality)
		{
			return false;
		}
		if (Guid != other.Guid)
		{
			return false;
		}
		if (!itemUse_.Equals(other.itemUse_))
		{
			return false;
		}
		if (!atk_.Equals(other.atk_))
		{
			return false;
		}
		if (!def_.Equals(other.def_))
		{
			return false;
		}
		if (Dur != other.Dur)
		{
			return false;
		}
		if (Caller != other.Caller)
		{
			return false;
		}
		if (!spellFires_.Equals(other.spellFires_))
		{
			return false;
		}
		if (BattleCount != other.BattleCount)
		{
			return false;
		}
		if (AvgFps != other.AvgFps)
		{
			return false;
		}
		if (MaxFps != other.MaxFps)
		{
			return false;
		}
		if (MinFps != other.MinFps)
		{
			return false;
		}
		if (HpMax != other.HpMax)
		{
			return false;
		}
		if (PlayerDieTimes != other.PlayerDieTimes)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EndType != BattleEndType.Detach)
		{
			num ^= EndType.GetHashCode();
		}
		if (ExtendId != 0)
		{
			num ^= ExtendId.GetHashCode();
		}
		if (Quality != 0)
		{
			num ^= Quality.GetHashCode();
		}
		if (Guid.Length != 0)
		{
			num ^= Guid.GetHashCode();
		}
		num ^= itemUse_.GetHashCode();
		num ^= atk_.GetHashCode();
		num ^= def_.GetHashCode();
		if (Dur != 0)
		{
			num ^= Dur.GetHashCode();
		}
		if (Caller != 0)
		{
			num ^= Caller.GetHashCode();
		}
		num ^= spellFires_.GetHashCode();
		if (BattleCount != 0)
		{
			num ^= BattleCount.GetHashCode();
		}
		if (AvgFps != 0)
		{
			num ^= AvgFps.GetHashCode();
		}
		if (MaxFps != 0)
		{
			num ^= MaxFps.GetHashCode();
		}
		if (MinFps != 0)
		{
			num ^= MinFps.GetHashCode();
		}
		if (HpMax != 0)
		{
			num ^= HpMax.GetHashCode();
		}
		if (PlayerDieTimes != 0)
		{
			num ^= PlayerDieTimes.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EndType != BattleEndType.Detach)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)EndType);
		}
		if (ExtendId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ExtendId);
		}
		if (Quality != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Quality);
		}
		if (Guid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Guid);
		}
		itemUse_.WriteTo(output, _repeated_itemUse_codec);
		atk_.WriteTo(output, _repeated_atk_codec);
		def_.WriteTo(output, _repeated_def_codec);
		if (Dur != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Dur);
		}
		if (Caller != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Caller);
		}
		spellFires_.WriteTo(output, _repeated_spellFires_codec);
		if (BattleCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(BattleCount);
		}
		if (AvgFps != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(AvgFps);
		}
		if (MaxFps != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(MaxFps);
		}
		if (MinFps != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(MinFps);
		}
		if (HpMax != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(HpMax);
		}
		if (PlayerDieTimes != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(PlayerDieTimes);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EndType != BattleEndType.Detach)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EndType);
		}
		if (ExtendId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtendId);
		}
		if (Quality != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Quality);
		}
		if (Guid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guid);
		}
		num += itemUse_.CalculateSize(_repeated_itemUse_codec);
		num += atk_.CalculateSize(_repeated_atk_codec);
		num += def_.CalculateSize(_repeated_def_codec);
		if (Dur != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Dur);
		}
		if (Caller != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Caller);
		}
		num += spellFires_.CalculateSize(_repeated_spellFires_codec);
		if (BattleCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleCount);
		}
		if (AvgFps != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AvgFps);
		}
		if (MaxFps != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxFps);
		}
		if (MinFps != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MinFps);
		}
		if (HpMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HpMax);
		}
		if (PlayerDieTimes != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PlayerDieTimes);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BattleMonster other)
	{
		if (other != null)
		{
			if (other.EndType != BattleEndType.Detach)
			{
				EndType = other.EndType;
			}
			if (other.ExtendId != 0)
			{
				ExtendId = other.ExtendId;
			}
			if (other.Quality != 0)
			{
				Quality = other.Quality;
			}
			if (other.Guid.Length != 0)
			{
				Guid = other.Guid;
			}
			itemUse_.Add(other.itemUse_);
			atk_.Add(other.atk_);
			def_.Add(other.def_);
			if (other.Dur != 0)
			{
				Dur = other.Dur;
			}
			if (other.Caller != 0)
			{
				Caller = other.Caller;
			}
			spellFires_.Add(other.spellFires_);
			if (other.BattleCount != 0)
			{
				BattleCount = other.BattleCount;
			}
			if (other.AvgFps != 0)
			{
				AvgFps = other.AvgFps;
			}
			if (other.MaxFps != 0)
			{
				MaxFps = other.MaxFps;
			}
			if (other.MinFps != 0)
			{
				MinFps = other.MinFps;
			}
			if (other.HpMax != 0)
			{
				HpMax = other.HpMax;
			}
			if (other.PlayerDieTimes != 0)
			{
				PlayerDieTimes = other.PlayerDieTimes;
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
				EndType = (BattleEndType)input.ReadEnum();
				break;
			case 16u:
				ExtendId = input.ReadInt32();
				break;
			case 24u:
				Quality = input.ReadInt32();
				break;
			case 34u:
				Guid = input.ReadString();
				break;
			case 42u:
				itemUse_.AddEntriesFrom(input, _repeated_itemUse_codec);
				break;
			case 50u:
				atk_.AddEntriesFrom(input, _repeated_atk_codec);
				break;
			case 58u:
				def_.AddEntriesFrom(input, _repeated_def_codec);
				break;
			case 64u:
				Dur = input.ReadInt32();
				break;
			case 72u:
				Caller = input.ReadInt32();
				break;
			case 82u:
				spellFires_.AddEntriesFrom(input, _repeated_spellFires_codec);
				break;
			case 88u:
				BattleCount = input.ReadInt32();
				break;
			case 96u:
				AvgFps = input.ReadInt32();
				break;
			case 104u:
				MaxFps = input.ReadInt32();
				break;
			case 112u:
				MinFps = input.ReadInt32();
				break;
			case 120u:
				HpMax = input.ReadInt32();
				break;
			case 128u:
				PlayerDieTimes = input.ReadInt32();
				break;
			}
		}
	}
}
