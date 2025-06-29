using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class RoleGardenSyncWrapper : IMessage<RoleGardenSyncWrapper>, IMessage, IEquatable<RoleGardenSyncWrapper>, IDeepCloneable<RoleGardenSyncWrapper>
{
	private static readonly MessageParser<RoleGardenSyncWrapper> _parser = new MessageParser<RoleGardenSyncWrapper>(() => new RoleGardenSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<CropSyncWrapper> _repeated_cropList_codec = FieldCodec.ForMessage(26u, CropSyncWrapper.Parser);

	private readonly RepeatedField<CropSyncWrapper> cropList_ = new RepeatedField<CropSyncWrapper>();

	private FloatSyncWrapper lastUpdateTime_;

	private FloatSyncWrapper lastCollectTime_;

	public static MessageParser<RoleGardenSyncWrapper> Parser => _parser;

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

	public RepeatedField<CropSyncWrapper> CropList => cropList_;

	public FloatSyncWrapper LastUpdateTime
	{
		get
		{
			return lastUpdateTime_;
		}
		set
		{
			lastUpdateTime_ = value;
		}
	}

	public FloatSyncWrapper LastCollectTime
	{
		get
		{
			return lastCollectTime_;
		}
		set
		{
			lastCollectTime_ = value;
		}
	}

	public RoleGardenSyncWrapper()
	{
	}

	public RoleGardenSyncWrapper(RoleGardenSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		cropList_ = other.cropList_.Clone();
		lastUpdateTime_ = ((other.lastUpdateTime_ != null) ? other.lastUpdateTime_.Clone() : null);
		lastCollectTime_ = ((other.lastCollectTime_ != null) ? other.lastCollectTime_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleGardenSyncWrapper Clone()
	{
		return new RoleGardenSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleGardenSyncWrapper);
	}

	public bool Equals(RoleGardenSyncWrapper other)
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
		if (!cropList_.Equals(other.cropList_))
		{
			return false;
		}
		if (!object.Equals(LastUpdateTime, other.LastUpdateTime))
		{
			return false;
		}
		if (!object.Equals(LastCollectTime, other.LastCollectTime))
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
		num ^= cropList_.GetHashCode();
		if (lastUpdateTime_ != null)
		{
			num ^= LastUpdateTime.GetHashCode();
		}
		if (lastCollectTime_ != null)
		{
			num ^= LastCollectTime.GetHashCode();
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
		cropList_.WriteTo(output, _repeated_cropList_codec);
		if (lastUpdateTime_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(LastUpdateTime);
		}
		if (lastCollectTime_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(LastCollectTime);
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
		num += cropList_.CalculateSize(_repeated_cropList_codec);
		if (lastUpdateTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LastUpdateTime);
		}
		if (lastCollectTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LastCollectTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleGardenSyncWrapper other)
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
		cropList_.Add(other.cropList_);
		if (other.lastUpdateTime_ != null)
		{
			if (lastUpdateTime_ == null)
			{
				LastUpdateTime = new FloatSyncWrapper();
			}
			LastUpdateTime.MergeFrom(other.LastUpdateTime);
		}
		if (other.lastCollectTime_ != null)
		{
			if (lastCollectTime_ == null)
			{
				LastCollectTime = new FloatSyncWrapper();
			}
			LastCollectTime.MergeFrom(other.LastCollectTime);
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
				cropList_.AddEntriesFrom(input, _repeated_cropList_codec);
				break;
			case 34u:
				if (lastUpdateTime_ == null)
				{
					LastUpdateTime = new FloatSyncWrapper();
				}
				input.ReadMessage(LastUpdateTime);
				break;
			case 42u:
				if (lastCollectTime_ == null)
				{
					LastCollectTime = new FloatSyncWrapper();
				}
				input.ReadMessage(LastCollectTime);
				break;
			}
		}
	}
}
