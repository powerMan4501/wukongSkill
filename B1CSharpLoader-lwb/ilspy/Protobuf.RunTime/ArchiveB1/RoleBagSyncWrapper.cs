using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleBagSyncWrapper : IMessage<RoleBagSyncWrapper>, IMessage, IEquatable<RoleBagSyncWrapper>, IDeepCloneable<RoleBagSyncWrapper>
{
	private static readonly MessageParser<RoleBagSyncWrapper> _parser = new MessageParser<RoleBagSyncWrapper>(() => new RoleBagSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<RoleMoneySyncWrapper> _repeated_moneyList_codec = FieldCodec.ForMessage(26u, RoleMoneySyncWrapper.Parser);

	private readonly RepeatedField<RoleMoneySyncWrapper> moneyList_ = new RepeatedField<RoleMoneySyncWrapper>();

	private static readonly FieldCodec<RoleItemSyncWrapper> _repeated_itemList_codec = FieldCodec.ForMessage(34u, RoleItemSyncWrapper.Parser);

	private readonly RepeatedField<RoleItemSyncWrapper> itemList_ = new RepeatedField<RoleItemSyncWrapper>();

	private static readonly FieldCodec<RoleEquipSyncWrapper> _repeated_equipList_codec = FieldCodec.ForMessage(42u, RoleEquipSyncWrapper.Parser);

	private readonly RepeatedField<RoleEquipSyncWrapper> equipList_ = new RepeatedField<RoleEquipSyncWrapper>();

	private static readonly FieldCodec<AttrItemSyncWrapper> _repeated_attrList_codec = FieldCodec.ForMessage(50u, AttrItemSyncWrapper.Parser);

	private readonly RepeatedField<AttrItemSyncWrapper> attrList_ = new RepeatedField<AttrItemSyncWrapper>();

	private static readonly FieldCodec<RoleWineSyncWrapper> _repeated_wineList_codec = FieldCodec.ForMessage(58u, RoleWineSyncWrapper.Parser);

	private readonly RepeatedField<RoleWineSyncWrapper> wineList_ = new RepeatedField<RoleWineSyncWrapper>();

	private RoleBagInfoSyncWrapper info_;

	private static readonly FieldCodec<RoleSoulSkillSyncWrapper> _repeated_soulSkillList_codec = FieldCodec.ForMessage(74u, RoleSoulSkillSyncWrapper.Parser);

	private readonly RepeatedField<RoleSoulSkillSyncWrapper> soulSkillList_ = new RepeatedField<RoleSoulSkillSyncWrapper>();

	public static MessageParser<RoleBagSyncWrapper> Parser => _parser;

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

	public RepeatedField<RoleMoneySyncWrapper> MoneyList => moneyList_;

	public RepeatedField<RoleItemSyncWrapper> ItemList => itemList_;

	public RepeatedField<RoleEquipSyncWrapper> EquipList => equipList_;

	public RepeatedField<AttrItemSyncWrapper> AttrList => attrList_;

	public RepeatedField<RoleWineSyncWrapper> WineList => wineList_;

	public RoleBagInfoSyncWrapper Info
	{
		get
		{
			return info_;
		}
		set
		{
			info_ = value;
		}
	}

	public RepeatedField<RoleSoulSkillSyncWrapper> SoulSkillList => soulSkillList_;

	public RoleBagSyncWrapper()
	{
	}

	public RoleBagSyncWrapper(RoleBagSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		moneyList_ = other.moneyList_.Clone();
		itemList_ = other.itemList_.Clone();
		equipList_ = other.equipList_.Clone();
		attrList_ = other.attrList_.Clone();
		wineList_ = other.wineList_.Clone();
		info_ = ((other.info_ != null) ? other.info_.Clone() : null);
		soulSkillList_ = other.soulSkillList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleBagSyncWrapper Clone()
	{
		return new RoleBagSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleBagSyncWrapper);
	}

	public bool Equals(RoleBagSyncWrapper other)
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
		if (!moneyList_.Equals(other.moneyList_))
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (!equipList_.Equals(other.equipList_))
		{
			return false;
		}
		if (!attrList_.Equals(other.attrList_))
		{
			return false;
		}
		if (!wineList_.Equals(other.wineList_))
		{
			return false;
		}
		if (!object.Equals(Info, other.Info))
		{
			return false;
		}
		if (!soulSkillList_.Equals(other.soulSkillList_))
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
		num ^= moneyList_.GetHashCode();
		num ^= itemList_.GetHashCode();
		num ^= equipList_.GetHashCode();
		num ^= attrList_.GetHashCode();
		num ^= wineList_.GetHashCode();
		if (info_ != null)
		{
			num ^= Info.GetHashCode();
		}
		num ^= soulSkillList_.GetHashCode();
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
		moneyList_.WriteTo(output, _repeated_moneyList_codec);
		itemList_.WriteTo(output, _repeated_itemList_codec);
		equipList_.WriteTo(output, _repeated_equipList_codec);
		attrList_.WriteTo(output, _repeated_attrList_codec);
		wineList_.WriteTo(output, _repeated_wineList_codec);
		if (info_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Info);
		}
		soulSkillList_.WriteTo(output, _repeated_soulSkillList_codec);
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
		num += moneyList_.CalculateSize(_repeated_moneyList_codec);
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		num += equipList_.CalculateSize(_repeated_equipList_codec);
		num += attrList_.CalculateSize(_repeated_attrList_codec);
		num += wineList_.CalculateSize(_repeated_wineList_codec);
		if (info_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Info);
		}
		num += soulSkillList_.CalculateSize(_repeated_soulSkillList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleBagSyncWrapper other)
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
		moneyList_.Add(other.moneyList_);
		itemList_.Add(other.itemList_);
		equipList_.Add(other.equipList_);
		attrList_.Add(other.attrList_);
		wineList_.Add(other.wineList_);
		if (other.info_ != null)
		{
			if (info_ == null)
			{
				Info = new RoleBagInfoSyncWrapper();
			}
			Info.MergeFrom(other.Info);
		}
		soulSkillList_.Add(other.soulSkillList_);
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
				moneyList_.AddEntriesFrom(input, _repeated_moneyList_codec);
				break;
			case 34u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			case 42u:
				equipList_.AddEntriesFrom(input, _repeated_equipList_codec);
				break;
			case 50u:
				attrList_.AddEntriesFrom(input, _repeated_attrList_codec);
				break;
			case 58u:
				wineList_.AddEntriesFrom(input, _repeated_wineList_codec);
				break;
			case 66u:
				if (info_ == null)
				{
					Info = new RoleBagInfoSyncWrapper();
				}
				input.ReadMessage(Info);
				break;
			case 74u:
				soulSkillList_.AddEntriesFrom(input, _repeated_soulSkillList_codec);
				break;
			}
		}
	}
}
