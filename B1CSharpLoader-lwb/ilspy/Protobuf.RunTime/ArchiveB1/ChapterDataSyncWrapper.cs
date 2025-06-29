using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class ChapterDataSyncWrapper : IMessage<ChapterDataSyncWrapper>, IMessage, IEquatable<ChapterDataSyncWrapper>, IDeepCloneable<ChapterDataSyncWrapper>
{
	private static readonly MessageParser<ChapterDataSyncWrapper> _parser = new MessageParser<ChapterDataSyncWrapper>(() => new ChapterDataSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper id_;

	private ChapterStageSyncWrapper stage_;

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_surpriseList_codec = FieldCodec.ForMessage(50u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> surpriseList_ = new RepeatedField<Int32SyncWrapper>();

	public static MessageParser<ChapterDataSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public ChapterStageSyncWrapper Stage
	{
		get
		{
			return stage_;
		}
		set
		{
			stage_ = value;
		}
	}

	public RepeatedField<Int32SyncWrapper> SurpriseList => surpriseList_;

	public ChapterDataSyncWrapper()
	{
	}

	public ChapterDataSyncWrapper(ChapterDataSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		id_ = ((other.id_ != null) ? other.id_.Clone() : null);
		stage_ = ((other.stage_ != null) ? other.stage_.Clone() : null);
		surpriseList_ = other.surpriseList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ChapterDataSyncWrapper Clone()
	{
		return new ChapterDataSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ChapterDataSyncWrapper);
	}

	public bool Equals(ChapterDataSyncWrapper other)
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
		if (!object.Equals(Id, other.Id))
		{
			return false;
		}
		if (!object.Equals(Stage, other.Stage))
		{
			return false;
		}
		if (!surpriseList_.Equals(other.surpriseList_))
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
		if (id_ != null)
		{
			num ^= Id.GetHashCode();
		}
		if (stage_ != null)
		{
			num ^= Stage.GetHashCode();
		}
		num ^= surpriseList_.GetHashCode();
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
		if (id_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Id);
		}
		if (stage_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Stage);
		}
		surpriseList_.WriteTo(output, _repeated_surpriseList_codec);
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
		if (id_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Id);
		}
		if (stage_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stage);
		}
		num += surpriseList_.CalculateSize(_repeated_surpriseList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ChapterDataSyncWrapper other)
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
		if (other.id_ != null)
		{
			if (id_ == null)
			{
				Id = new Int32SyncWrapper();
			}
			Id.MergeFrom(other.Id);
		}
		if (other.stage_ != null)
		{
			if (stage_ == null)
			{
				Stage = new ChapterStageSyncWrapper();
			}
			Stage.MergeFrom(other.Stage);
		}
		surpriseList_.Add(other.surpriseList_);
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
				if (id_ == null)
				{
					Id = new Int32SyncWrapper();
				}
				input.ReadMessage(Id);
				break;
			case 34u:
				if (stage_ == null)
				{
					Stage = new ChapterStageSyncWrapper();
				}
				input.ReadMessage(Stage);
				break;
			case 50u:
				surpriseList_.AddEntriesFrom(input, _repeated_surpriseList_codec);
				break;
			}
		}
	}
}
