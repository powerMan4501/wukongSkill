using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class RoleMuseumSyncWrapper : IMessage<RoleMuseumSyncWrapper>, IMessage, IEquatable<RoleMuseumSyncWrapper>, IDeepCloneable<RoleMuseumSyncWrapper>
{
	private static readonly MessageParser<RoleMuseumSyncWrapper> _parser = new MessageParser<RoleMuseumSyncWrapper>(() => new RoleMuseumSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private MuseumRedPointSyncWrapper redPoint_;

	private GlobalDataSyncWrapper globalData_;

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_mvIdList_codec = FieldCodec.ForMessage(74u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> mvIdList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_soundtrackIdList_codec = FieldCodec.ForMessage(82u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> soundtrackIdList_ = new RepeatedField<Int32SyncWrapper>();

	public static MessageParser<RoleMuseumSyncWrapper> Parser => _parser;

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

	public MuseumRedPointSyncWrapper RedPoint
	{
		get
		{
			return redPoint_;
		}
		set
		{
			redPoint_ = value;
		}
	}

	public GlobalDataSyncWrapper GlobalData
	{
		get
		{
			return globalData_;
		}
		set
		{
			globalData_ = value;
		}
	}

	public RepeatedField<Int32SyncWrapper> MvIdList => mvIdList_;

	public RepeatedField<Int32SyncWrapper> SoundtrackIdList => soundtrackIdList_;

	public RoleMuseumSyncWrapper()
	{
	}

	public RoleMuseumSyncWrapper(RoleMuseumSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		redPoint_ = ((other.redPoint_ != null) ? other.redPoint_.Clone() : null);
		globalData_ = ((other.globalData_ != null) ? other.globalData_.Clone() : null);
		mvIdList_ = other.mvIdList_.Clone();
		soundtrackIdList_ = other.soundtrackIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleMuseumSyncWrapper Clone()
	{
		return new RoleMuseumSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleMuseumSyncWrapper);
	}

	public bool Equals(RoleMuseumSyncWrapper other)
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
		if (!object.Equals(RedPoint, other.RedPoint))
		{
			return false;
		}
		if (!object.Equals(GlobalData, other.GlobalData))
		{
			return false;
		}
		if (!mvIdList_.Equals(other.mvIdList_))
		{
			return false;
		}
		if (!soundtrackIdList_.Equals(other.soundtrackIdList_))
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
		if (redPoint_ != null)
		{
			num ^= RedPoint.GetHashCode();
		}
		if (globalData_ != null)
		{
			num ^= GlobalData.GetHashCode();
		}
		num ^= mvIdList_.GetHashCode();
		num ^= soundtrackIdList_.GetHashCode();
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
		if (redPoint_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(RedPoint);
		}
		if (globalData_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(GlobalData);
		}
		mvIdList_.WriteTo(output, _repeated_mvIdList_codec);
		soundtrackIdList_.WriteTo(output, _repeated_soundtrackIdList_codec);
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
		if (redPoint_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RedPoint);
		}
		if (globalData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GlobalData);
		}
		num += mvIdList_.CalculateSize(_repeated_mvIdList_codec);
		num += soundtrackIdList_.CalculateSize(_repeated_soundtrackIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleMuseumSyncWrapper other)
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
		if (other.redPoint_ != null)
		{
			if (redPoint_ == null)
			{
				RedPoint = new MuseumRedPointSyncWrapper();
			}
			RedPoint.MergeFrom(other.RedPoint);
		}
		if (other.globalData_ != null)
		{
			if (globalData_ == null)
			{
				GlobalData = new GlobalDataSyncWrapper();
			}
			GlobalData.MergeFrom(other.GlobalData);
		}
		mvIdList_.Add(other.mvIdList_);
		soundtrackIdList_.Add(other.soundtrackIdList_);
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
			case 58u:
				if (redPoint_ == null)
				{
					RedPoint = new MuseumRedPointSyncWrapper();
				}
				input.ReadMessage(RedPoint);
				break;
			case 66u:
				if (globalData_ == null)
				{
					GlobalData = new GlobalDataSyncWrapper();
				}
				input.ReadMessage(GlobalData);
				break;
			case 74u:
				mvIdList_.AddEntriesFrom(input, _repeated_mvIdList_codec);
				break;
			case 82u:
				soundtrackIdList_.AddEntriesFrom(input, _repeated_soundtrackIdList_codec);
				break;
			}
		}
	}
}
