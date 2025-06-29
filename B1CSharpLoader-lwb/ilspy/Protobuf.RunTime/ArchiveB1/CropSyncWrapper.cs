using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class CropSyncWrapper : IMessage<CropSyncWrapper>, IMessage, IEquatable<CropSyncWrapper>, IDeepCloneable<CropSyncWrapper>
{
	private static readonly MessageParser<CropSyncWrapper> _parser = new MessageParser<CropSyncWrapper>(() => new CropSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper seedId_;

	private static readonly FieldCodec<CropOutputSyncWrapper> _repeated_outputList_codec = FieldCodec.ForMessage(58u, CropOutputSyncWrapper.Parser);

	private readonly RepeatedField<CropOutputSyncWrapper> outputList_ = new RepeatedField<CropOutputSyncWrapper>();

	public static MessageParser<CropSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper SeedId
	{
		get
		{
			return seedId_;
		}
		set
		{
			seedId_ = value;
		}
	}

	public RepeatedField<CropOutputSyncWrapper> OutputList => outputList_;

	public CropSyncWrapper()
	{
	}

	public CropSyncWrapper(CropSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		seedId_ = ((other.seedId_ != null) ? other.seedId_.Clone() : null);
		outputList_ = other.outputList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CropSyncWrapper Clone()
	{
		return new CropSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CropSyncWrapper);
	}

	public bool Equals(CropSyncWrapper other)
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
		if (!object.Equals(SeedId, other.SeedId))
		{
			return false;
		}
		if (!outputList_.Equals(other.outputList_))
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
		if (seedId_ != null)
		{
			num ^= SeedId.GetHashCode();
		}
		num ^= outputList_.GetHashCode();
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
		if (seedId_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(SeedId);
		}
		outputList_.WriteTo(output, _repeated_outputList_codec);
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
		if (seedId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SeedId);
		}
		num += outputList_.CalculateSize(_repeated_outputList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CropSyncWrapper other)
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
		if (other.seedId_ != null)
		{
			if (seedId_ == null)
			{
				SeedId = new Int32SyncWrapper();
			}
			SeedId.MergeFrom(other.SeedId);
		}
		outputList_.Add(other.outputList_);
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
			case 50u:
				if (seedId_ == null)
				{
					SeedId = new Int32SyncWrapper();
				}
				input.ReadMessage(SeedId);
				break;
			case 58u:
				outputList_.AddEntriesFrom(input, _repeated_outputList_codec);
				break;
			}
		}
	}
}
