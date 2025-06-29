using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class BossRushBattleStyleSyncWrapper : IMessage<BossRushBattleStyleSyncWrapper>, IMessage, IEquatable<BossRushBattleStyleSyncWrapper>, IDeepCloneable<BossRushBattleStyleSyncWrapper>
{
	private static readonly MessageParser<BossRushBattleStyleSyncWrapper> _parser = new MessageParser<BossRushBattleStyleSyncWrapper>(() => new BossRushBattleStyleSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<BossRushCastCountSyncWrapper> _repeated_spellList_codec = FieldCodec.ForMessage(26u, BossRushCastCountSyncWrapper.Parser);

	private readonly RepeatedField<BossRushCastCountSyncWrapper> spellList_ = new RepeatedField<BossRushCastCountSyncWrapper>();

	private BossRushCastCountSyncWrapper fabaoInfo_;

	private BossRushCastCountSyncWrapper soulInfo_;

	private Int32SyncWrapper itemCount_;

	private Int32SyncWrapper wineCount_;

	private Int32SyncWrapper rollCount_;

	private Int32SyncWrapper defuseCount_;

	private Int32SyncWrapper fourPeCount_;

	public static MessageParser<BossRushBattleStyleSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public RepeatedField<BossRushCastCountSyncWrapper> SpellList => spellList_;

	public BossRushCastCountSyncWrapper FabaoInfo
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

	public BossRushCastCountSyncWrapper SoulInfo
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

	public Int32SyncWrapper ItemCount
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

	public Int32SyncWrapper WineCount
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

	public Int32SyncWrapper RollCount
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

	public Int32SyncWrapper DefuseCount
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

	public Int32SyncWrapper FourPeCount
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

	public BossRushBattleStyleSyncWrapper()
	{
	}

	public BossRushBattleStyleSyncWrapper(BossRushBattleStyleSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		spellList_ = other.spellList_.Clone();
		fabaoInfo_ = ((other.fabaoInfo_ != null) ? other.fabaoInfo_.Clone() : null);
		soulInfo_ = ((other.soulInfo_ != null) ? other.soulInfo_.Clone() : null);
		itemCount_ = ((other.itemCount_ != null) ? other.itemCount_.Clone() : null);
		wineCount_ = ((other.wineCount_ != null) ? other.wineCount_.Clone() : null);
		rollCount_ = ((other.rollCount_ != null) ? other.rollCount_.Clone() : null);
		defuseCount_ = ((other.defuseCount_ != null) ? other.defuseCount_.Clone() : null);
		fourPeCount_ = ((other.fourPeCount_ != null) ? other.fourPeCount_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushBattleStyleSyncWrapper Clone()
	{
		return new BossRushBattleStyleSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushBattleStyleSyncWrapper);
	}

	public bool Equals(BossRushBattleStyleSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
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
		if (!object.Equals(ItemCount, other.ItemCount))
		{
			return false;
		}
		if (!object.Equals(WineCount, other.WineCount))
		{
			return false;
		}
		if (!object.Equals(RollCount, other.RollCount))
		{
			return false;
		}
		if (!object.Equals(DefuseCount, other.DefuseCount))
		{
			return false;
		}
		if (!object.Equals(FourPeCount, other.FourPeCount))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		num ^= spellList_.GetHashCode();
		if (fabaoInfo_ != null)
		{
			num ^= FabaoInfo.GetHashCode();
		}
		if (soulInfo_ != null)
		{
			num ^= SoulInfo.GetHashCode();
		}
		if (itemCount_ != null)
		{
			num ^= ItemCount.GetHashCode();
		}
		if (wineCount_ != null)
		{
			num ^= WineCount.GetHashCode();
		}
		if (rollCount_ != null)
		{
			num ^= RollCount.GetHashCode();
		}
		if (defuseCount_ != null)
		{
			num ^= DefuseCount.GetHashCode();
		}
		if (fourPeCount_ != null)
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
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		spellList_.WriteTo(output, _repeated_spellList_codec);
		if (fabaoInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(FabaoInfo);
		}
		if (soulInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(SoulInfo);
		}
		if (itemCount_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ItemCount);
		}
		if (wineCount_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(WineCount);
		}
		if (rollCount_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(RollCount);
		}
		if (defuseCount_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(DefuseCount);
		}
		if (fourPeCount_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(FourPeCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		num += spellList_.CalculateSize(_repeated_spellList_codec);
		if (fabaoInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FabaoInfo);
		}
		if (soulInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SoulInfo);
		}
		if (itemCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemCount);
		}
		if (wineCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(WineCount);
		}
		if (rollCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RollCount);
		}
		if (defuseCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DefuseCount);
		}
		if (fourPeCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FourPeCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushBattleStyleSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		spellList_.Add(other.spellList_);
		if (other.fabaoInfo_ != null)
		{
			if (fabaoInfo_ == null)
			{
				FabaoInfo = new BossRushCastCountSyncWrapper();
			}
			FabaoInfo.MergeFrom(other.FabaoInfo);
		}
		if (other.soulInfo_ != null)
		{
			if (soulInfo_ == null)
			{
				SoulInfo = new BossRushCastCountSyncWrapper();
			}
			SoulInfo.MergeFrom(other.SoulInfo);
		}
		if (other.itemCount_ != null)
		{
			if (itemCount_ == null)
			{
				ItemCount = new Int32SyncWrapper();
			}
			ItemCount.MergeFrom(other.ItemCount);
		}
		if (other.wineCount_ != null)
		{
			if (wineCount_ == null)
			{
				WineCount = new Int32SyncWrapper();
			}
			WineCount.MergeFrom(other.WineCount);
		}
		if (other.rollCount_ != null)
		{
			if (rollCount_ == null)
			{
				RollCount = new Int32SyncWrapper();
			}
			RollCount.MergeFrom(other.RollCount);
		}
		if (other.defuseCount_ != null)
		{
			if (defuseCount_ == null)
			{
				DefuseCount = new Int32SyncWrapper();
			}
			DefuseCount.MergeFrom(other.DefuseCount);
		}
		if (other.fourPeCount_ != null)
		{
			if (fourPeCount_ == null)
			{
				FourPeCount = new Int32SyncWrapper();
			}
			FourPeCount.MergeFrom(other.FourPeCount);
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
			case 8u:
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				spellList_.AddEntriesFrom(input, _repeated_spellList_codec);
				break;
			case 34u:
				if (fabaoInfo_ == null)
				{
					FabaoInfo = new BossRushCastCountSyncWrapper();
				}
				input.ReadMessage(FabaoInfo);
				break;
			case 42u:
				if (soulInfo_ == null)
				{
					SoulInfo = new BossRushCastCountSyncWrapper();
				}
				input.ReadMessage(SoulInfo);
				break;
			case 50u:
				if (itemCount_ == null)
				{
					ItemCount = new Int32SyncWrapper();
				}
				input.ReadMessage(ItemCount);
				break;
			case 58u:
				if (wineCount_ == null)
				{
					WineCount = new Int32SyncWrapper();
				}
				input.ReadMessage(WineCount);
				break;
			case 66u:
				if (rollCount_ == null)
				{
					RollCount = new Int32SyncWrapper();
				}
				input.ReadMessage(RollCount);
				break;
			case 74u:
				if (defuseCount_ == null)
				{
					DefuseCount = new Int32SyncWrapper();
				}
				input.ReadMessage(DefuseCount);
				break;
			case 82u:
				if (fourPeCount_ == null)
				{
					FourPeCount = new Int32SyncWrapper();
				}
				input.ReadMessage(FourPeCount);
				break;
			}
		}
	}
}
