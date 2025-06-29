using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleShopSyncWrapper : IMessage<RoleShopSyncWrapper>, IMessage, IEquatable<RoleShopSyncWrapper>, IDeepCloneable<RoleShopSyncWrapper>
{
	private static readonly MessageParser<RoleShopSyncWrapper> _parser = new MessageParser<RoleShopSyncWrapper>(() => new RoleShopSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<ShopOneSyncWrapper> _repeated_shopList_codec = FieldCodec.ForMessage(26u, ShopOneSyncWrapper.Parser);

	private readonly RepeatedField<ShopOneSyncWrapper> shopList_ = new RepeatedField<ShopOneSyncWrapper>();

	private static readonly FieldCodec<ShopBuyRecordSyncWrapper> _repeated_buyRecords_codec = FieldCodec.ForMessage(34u, ShopBuyRecordSyncWrapper.Parser);

	private readonly RepeatedField<ShopBuyRecordSyncWrapper> buyRecords_ = new RepeatedField<ShopBuyRecordSyncWrapper>();

	public static MessageParser<RoleShopSyncWrapper> Parser => _parser;

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

	public RepeatedField<ShopOneSyncWrapper> ShopList => shopList_;

	public RepeatedField<ShopBuyRecordSyncWrapper> BuyRecords => buyRecords_;

	public RoleShopSyncWrapper()
	{
	}

	public RoleShopSyncWrapper(RoleShopSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		shopList_ = other.shopList_.Clone();
		buyRecords_ = other.buyRecords_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleShopSyncWrapper Clone()
	{
		return new RoleShopSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleShopSyncWrapper);
	}

	public bool Equals(RoleShopSyncWrapper other)
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
		if (!shopList_.Equals(other.shopList_))
		{
			return false;
		}
		if (!buyRecords_.Equals(other.buyRecords_))
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
		num ^= shopList_.GetHashCode();
		num ^= buyRecords_.GetHashCode();
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
		shopList_.WriteTo(output, _repeated_shopList_codec);
		buyRecords_.WriteTo(output, _repeated_buyRecords_codec);
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
		num += shopList_.CalculateSize(_repeated_shopList_codec);
		num += buyRecords_.CalculateSize(_repeated_buyRecords_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleShopSyncWrapper other)
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
			shopList_.Add(other.shopList_);
			buyRecords_.Add(other.buyRecords_);
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
				shopList_.AddEntriesFrom(input, _repeated_shopList_codec);
				break;
			case 34u:
				buyRecords_.AddEntriesFrom(input, _repeated_buyRecords_codec);
				break;
			}
		}
	}
}
