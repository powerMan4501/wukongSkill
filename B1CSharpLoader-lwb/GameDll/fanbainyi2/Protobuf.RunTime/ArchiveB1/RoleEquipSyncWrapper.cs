using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class RoleEquipSyncWrapper : IMessage<RoleEquipSyncWrapper>, IMessage, IEquatable<RoleEquipSyncWrapper>, IDeepCloneable<RoleEquipSyncWrapper>
{
	private static readonly MessageParser<RoleEquipSyncWrapper> _parser = new MessageParser<RoleEquipSyncWrapper>(() => new RoleEquipSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper equipId_;

	private Uint64SyncWrapper uid_;

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_historyIdList_codec = FieldCodec.ForMessage(58u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> historyIdList_ = new RepeatedField<Int32SyncWrapper>();

	public static MessageParser<RoleEquipSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper EquipId
	{
		get
		{
			return equipId_;
		}
		set
		{
			equipId_ = value;
		}
	}

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

	public RepeatedField<Int32SyncWrapper> HistoryIdList => historyIdList_;

	public RoleEquipSyncWrapper()
	{
	}

	public RoleEquipSyncWrapper(RoleEquipSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		equipId_ = ((other.equipId_ != null) ? other.equipId_.Clone() : null);
		uid_ = ((other.uid_ != null) ? other.uid_.Clone() : null);
		historyIdList_ = other.historyIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleEquipSyncWrapper Clone()
	{
		return new RoleEquipSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleEquipSyncWrapper);
	}

	public bool Equals(RoleEquipSyncWrapper other)
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
		if (!object.Equals(EquipId, other.EquipId))
		{
			return false;
		}
		if (!object.Equals(Uid, other.Uid))
		{
			return false;
		}
		if (!historyIdList_.Equals(other.historyIdList_))
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
		if (equipId_ != null)
		{
			num ^= EquipId.GetHashCode();
		}
		if (uid_ != null)
		{
			num ^= Uid.GetHashCode();
		}
		num ^= historyIdList_.GetHashCode();
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
		if (equipId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EquipId);
		}
		if (uid_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Uid);
		}
		historyIdList_.WriteTo(output, _repeated_historyIdList_codec);
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
		if (equipId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EquipId);
		}
		if (uid_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Uid);
		}
		num += historyIdList_.CalculateSize(_repeated_historyIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleEquipSyncWrapper other)
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
		if (other.equipId_ != null)
		{
			if (equipId_ == null)
			{
				EquipId = new Int32SyncWrapper();
			}
			EquipId.MergeFrom(other.EquipId);
		}
		if (other.uid_ != null)
		{
			if (uid_ == null)
			{
				Uid = new Uint64SyncWrapper();
			}
			Uid.MergeFrom(other.Uid);
		}
		historyIdList_.Add(other.historyIdList_);
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
				if (equipId_ == null)
				{
					EquipId = new Int32SyncWrapper();
				}
				input.ReadMessage(EquipId);
				break;
			case 50u:
				if (uid_ == null)
				{
					Uid = new Uint64SyncWrapper();
				}
				input.ReadMessage(Uid);
				break;
			case 58u:
				historyIdList_.AddEntriesFrom(input, _repeated_historyIdList_codec);
				break;
			}
		}
	}
}
