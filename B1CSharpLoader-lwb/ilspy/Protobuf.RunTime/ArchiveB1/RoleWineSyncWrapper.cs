using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class RoleWineSyncWrapper : IMessage<RoleWineSyncWrapper>, IMessage, IEquatable<RoleWineSyncWrapper>, IDeepCloneable<RoleWineSyncWrapper>
{
	private static readonly MessageParser<RoleWineSyncWrapper> _parser = new MessageParser<RoleWineSyncWrapper>(() => new RoleWineSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper wineId_;

	private static readonly FieldCodec<WinePartnerSyncWrapper> _repeated_itemList_codec = FieldCodec.ForMessage(34u, WinePartnerSyncWrapper.Parser);

	private readonly RepeatedField<WinePartnerSyncWrapper> itemList_ = new RepeatedField<WinePartnerSyncWrapper>();

	private Uint64SyncWrapper uid_;

	public static MessageParser<RoleWineSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper WineId
	{
		get
		{
			return wineId_;
		}
		set
		{
			wineId_ = value;
		}
	}

	public RepeatedField<WinePartnerSyncWrapper> ItemList => itemList_;

	public Uint64SyncWrapper Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	public RoleWineSyncWrapper()
	{
	}

	public RoleWineSyncWrapper(RoleWineSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		wineId_ = ((other.wineId_ != null) ? other.wineId_.Clone() : null);
		itemList_ = other.itemList_.Clone();
		uid_ = ((other.uid_ != null) ? other.uid_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleWineSyncWrapper Clone()
	{
		return new RoleWineSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleWineSyncWrapper);
	}

	public bool Equals(RoleWineSyncWrapper other)
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
		if (!object.Equals(WineId, other.WineId))
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (!object.Equals(Uid, other.Uid))
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
		if (wineId_ != null)
		{
			num ^= WineId.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (uid_ != null)
		{
			num ^= Uid.GetHashCode();
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
		if (wineId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(WineId);
		}
		itemList_.WriteTo(output, _repeated_itemList_codec);
		if (uid_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Uid);
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
		if (wineId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(WineId);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (uid_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleWineSyncWrapper other)
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
		if (other.wineId_ != null)
		{
			if (wineId_ == null)
			{
				WineId = new Int32SyncWrapper();
			}
			WineId.MergeFrom(other.WineId);
		}
		itemList_.Add(other.itemList_);
		if (other.uid_ != null)
		{
			if (uid_ == null)
			{
				Uid = new Uint64SyncWrapper();
			}
			Uid.MergeFrom(other.Uid);
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
				if (wineId_ == null)
				{
					WineId = new Int32SyncWrapper();
				}
				input.ReadMessage(WineId);
				break;
			case 34u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			case 42u:
				if (uid_ == null)
				{
					Uid = new Uint64SyncWrapper();
				}
				input.ReadMessage(Uid);
				break;
			}
		}
	}
}
