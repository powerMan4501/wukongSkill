using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class AchievementStatSyncWrapper : IMessage<AchievementStatSyncWrapper>, IMessage, IEquatable<AchievementStatSyncWrapper>, IDeepCloneable<AchievementStatSyncWrapper>
{
	private static readonly MessageParser<AchievementStatSyncWrapper> _parser = new MessageParser<AchievementStatSyncWrapper>(() => new AchievementStatSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_equipIdList_codec = FieldCodec.ForMessage(26u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> equipIdList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_spellIdList_codec = FieldCodec.ForMessage(34u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> spellIdList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<ItemStatSyncWrapper> _repeated_itemList_codec = FieldCodec.ForMessage(42u, ItemStatSyncWrapper.Parser);

	private readonly RepeatedField<ItemStatSyncWrapper> itemList_ = new RepeatedField<ItemStatSyncWrapper>();

	public static MessageParser<AchievementStatSyncWrapper> Parser => _parser;

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

	public RepeatedField<Int32SyncWrapper> EquipIdList => equipIdList_;

	public RepeatedField<Int32SyncWrapper> SpellIdList => spellIdList_;

	public RepeatedField<ItemStatSyncWrapper> ItemList => itemList_;

	public AchievementStatSyncWrapper()
	{
	}

	public AchievementStatSyncWrapper(AchievementStatSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		equipIdList_ = other.equipIdList_.Clone();
		spellIdList_ = other.spellIdList_.Clone();
		itemList_ = other.itemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementStatSyncWrapper Clone()
	{
		return new AchievementStatSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementStatSyncWrapper);
	}

	public bool Equals(AchievementStatSyncWrapper other)
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
		if (!equipIdList_.Equals(other.equipIdList_))
		{
			return false;
		}
		if (!spellIdList_.Equals(other.spellIdList_))
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
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
		num ^= equipIdList_.GetHashCode();
		num ^= spellIdList_.GetHashCode();
		num ^= itemList_.GetHashCode();
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
		equipIdList_.WriteTo(output, _repeated_equipIdList_codec);
		spellIdList_.WriteTo(output, _repeated_spellIdList_codec);
		itemList_.WriteTo(output, _repeated_itemList_codec);
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
		num += equipIdList_.CalculateSize(_repeated_equipIdList_codec);
		num += spellIdList_.CalculateSize(_repeated_spellIdList_codec);
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementStatSyncWrapper other)
	{
		if (other != null)
		{
			if (other.SyncFlag != 0)
			{
				SyncFlag = other.SyncFlag;
			}
			if (other.SyncIdx != 0)
			{
				SyncIdx = other.SyncIdx;
			}
			equipIdList_.Add(other.equipIdList_);
			spellIdList_.Add(other.spellIdList_);
			itemList_.Add(other.itemList_);
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				equipIdList_.AddEntriesFrom(input, _repeated_equipIdList_codec);
				break;
			case 34u:
				spellIdList_.AddEntriesFrom(input, _repeated_spellIdList_codec);
				break;
			case 42u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			}
		}
	}
}
