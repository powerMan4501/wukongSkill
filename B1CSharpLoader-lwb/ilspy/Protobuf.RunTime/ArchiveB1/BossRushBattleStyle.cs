using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class BossRushBattleStyle : IMessage<BossRushBattleStyle>, IMessage, IEquatable<BossRushBattleStyle>, IDeepCloneable<BossRushBattleStyle>
{
	private static readonly MessageParser<BossRushBattleStyle> _parser = new MessageParser<BossRushBattleStyle>(() => new BossRushBattleStyle());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<BossRushCastCount> _repeated_spellList_codec = FieldCodec.ForMessage(10u, BossRushCastCount.Parser);

	private readonly RepeatedField<BossRushCastCount> spellList_ = new RepeatedField<BossRushCastCount>();

	private BossRushCastCount fabaoInfo_;

	private BossRushCastCount soulInfo_;

	private int itemCount_;

	private int wineCount_;

	private int rollCount_;

	private int defuseCount_;

	private int fourPeCount_;

	public static MessageParser<BossRushBattleStyle> Parser => _parser;

	public RepeatedField<BossRushCastCount> SpellList => spellList_;

	public BossRushCastCount FabaoInfo
	{
		get
		{
			return fabaoInfo_;
		}
		set
		{
			fabaoInfo_ = value;
		}
	}

	public BossRushCastCount SoulInfo
	{
		get
		{
			return soulInfo_;
		}
		set
		{
			soulInfo_ = value;
		}
	}

	public int ItemCount
	{
		get
		{
			return itemCount_;
		}
		set
		{
			itemCount_ = value;
		}
	}

	public int WineCount
	{
		get
		{
			return wineCount_;
		}
		set
		{
			wineCount_ = value;
		}
	}

	public int RollCount
	{
		get
		{
			return rollCount_;
		}
		set
		{
			rollCount_ = value;
		}
	}

	public int DefuseCount
	{
		get
		{
			return defuseCount_;
		}
		set
		{
			defuseCount_ = value;
		}
	}

	public int FourPeCount
	{
		get
		{
			return fourPeCount_;
		}
		set
		{
			fourPeCount_ = value;
		}
	}

	public BossRushBattleStyle()
	{
	}

	public BossRushBattleStyle(BossRushBattleStyle other)
		: this()
	{
		spellList_ = other.spellList_.Clone();
		fabaoInfo_ = ((other.fabaoInfo_ != null) ? other.fabaoInfo_.Clone() : null);
		soulInfo_ = ((other.soulInfo_ != null) ? other.soulInfo_.Clone() : null);
		itemCount_ = other.itemCount_;
		wineCount_ = other.wineCount_;
		rollCount_ = other.rollCount_;
		defuseCount_ = other.defuseCount_;
		fourPeCount_ = other.fourPeCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushBattleStyle Clone()
	{
		return new BossRushBattleStyle(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushBattleStyle);
	}

	public bool Equals(BossRushBattleStyle other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!spellList_.Equals(other.spellList_))
		{
			return false;
		}
		if (!object.Equals(FabaoInfo, other.FabaoInfo))
		{
			return false;
		}
		if (!object.Equals(SoulInfo, other.SoulInfo))
		{
			return false;
		}
		if (ItemCount != other.ItemCount)
		{
			return false;
		}
		if (WineCount != other.WineCount)
		{
			return false;
		}
		if (RollCount != other.RollCount)
		{
			return false;
		}
		if (DefuseCount != other.DefuseCount)
		{
			return false;
		}
		if (FourPeCount != other.FourPeCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= spellList_.GetHashCode();
		if (fabaoInfo_ != null)
		{
			num ^= FabaoInfo.GetHashCode();
		}
		if (soulInfo_ != null)
		{
			num ^= SoulInfo.GetHashCode();
		}
		if (ItemCount != 0)
		{
			num ^= ItemCount.GetHashCode();
		}
		if (WineCount != 0)
		{
			num ^= WineCount.GetHashCode();
		}
		if (RollCount != 0)
		{
			num ^= RollCount.GetHashCode();
		}
		if (DefuseCount != 0)
		{
			num ^= DefuseCount.GetHashCode();
		}
		if (FourPeCount != 0)
		{
			num ^= FourPeCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		spellList_.WriteTo(output, _repeated_spellList_codec);
		if (fabaoInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(FabaoInfo);
		}
		if (soulInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(SoulInfo);
		}
		if (ItemCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ItemCount);
		}
		if (WineCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(WineCount);
		}
		if (RollCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(RollCount);
		}
		if (DefuseCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(DefuseCount);
		}
		if (FourPeCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(FourPeCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += spellList_.CalculateSize(_repeated_spellList_codec);
		if (fabaoInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FabaoInfo);
		}
		if (soulInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SoulInfo);
		}
		if (ItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemCount);
		}
		if (WineCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WineCount);
		}
		if (RollCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RollCount);
		}
		if (DefuseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefuseCount);
		}
		if (FourPeCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FourPeCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushBattleStyle other)
	{
		if (other == null)
		{
			return;
		}
		spellList_.Add(other.spellList_);
		if (other.fabaoInfo_ != null)
		{
			if (fabaoInfo_ == null)
			{
				FabaoInfo = new BossRushCastCount();
			}
			FabaoInfo.MergeFrom(other.FabaoInfo);
		}
		if (other.soulInfo_ != null)
		{
			if (soulInfo_ == null)
			{
				SoulInfo = new BossRushCastCount();
			}
			SoulInfo.MergeFrom(other.SoulInfo);
		}
		if (other.ItemCount != 0)
		{
			ItemCount = other.ItemCount;
		}
		if (other.WineCount != 0)
		{
			WineCount = other.WineCount;
		}
		if (other.RollCount != 0)
		{
			RollCount = other.RollCount;
		}
		if (other.DefuseCount != 0)
		{
			DefuseCount = other.DefuseCount;
		}
		if (other.FourPeCount != 0)
		{
			FourPeCount = other.FourPeCount;
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
				spellList_.AddEntriesFrom(input, _repeated_spellList_codec);
				break;
			case 18u:
				if (fabaoInfo_ == null)
				{
					FabaoInfo = new BossRushCastCount();
				}
				input.ReadMessage(FabaoInfo);
				break;
			case 26u:
				if (soulInfo_ == null)
				{
					SoulInfo = new BossRushCastCount();
				}
				input.ReadMessage(SoulInfo);
				break;
			case 32u:
				ItemCount = input.ReadInt32();
				break;
			case 40u:
				WineCount = input.ReadInt32();
				break;
			case 48u:
				RollCount = input.ReadInt32();
				break;
			case 56u:
				DefuseCount = input.ReadInt32();
				break;
			case 64u:
				FourPeCount = input.ReadInt32();
				break;
			}
		}
	}
}
