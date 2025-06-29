using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class MuseumRedPointSyncWrapper : IMessage<MuseumRedPointSyncWrapper>, IMessage, IEquatable<MuseumRedPointSyncWrapper>, IDeepCloneable<MuseumRedPointSyncWrapper>
{
	private static readonly MessageParser<MuseumRedPointSyncWrapper> _parser = new MessageParser<MuseumRedPointSyncWrapper>(() => new MuseumRedPointSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_mvRedpoint_codec = FieldCodec.ForMessage(58u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> mvRedpoint_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_soundtrackRedpointList_codec = FieldCodec.ForMessage(66u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> soundtrackRedpointList_ = new RepeatedField<Int32SyncWrapper>();

	public static MessageParser<MuseumRedPointSyncWrapper> Parser => _parser;

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

	public RepeatedField<Int32SyncWrapper> MvRedpoint => mvRedpoint_;

	public RepeatedField<Int32SyncWrapper> SoundtrackRedpointList => soundtrackRedpointList_;

	public MuseumRedPointSyncWrapper()
	{
	}

	public MuseumRedPointSyncWrapper(MuseumRedPointSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		mvRedpoint_ = other.mvRedpoint_.Clone();
		soundtrackRedpointList_ = other.soundtrackRedpointList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MuseumRedPointSyncWrapper Clone()
	{
		return new MuseumRedPointSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MuseumRedPointSyncWrapper);
	}

	public bool Equals(MuseumRedPointSyncWrapper other)
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
		if (!mvRedpoint_.Equals(other.mvRedpoint_))
		{
			return false;
		}
		if (!soundtrackRedpointList_.Equals(other.soundtrackRedpointList_))
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
		num ^= mvRedpoint_.GetHashCode();
		num ^= soundtrackRedpointList_.GetHashCode();
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
		mvRedpoint_.WriteTo(output, _repeated_mvRedpoint_codec);
		soundtrackRedpointList_.WriteTo(output, _repeated_soundtrackRedpointList_codec);
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
		num += mvRedpoint_.CalculateSize(_repeated_mvRedpoint_codec);
		num += soundtrackRedpointList_.CalculateSize(_repeated_soundtrackRedpointList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MuseumRedPointSyncWrapper other)
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
			mvRedpoint_.Add(other.mvRedpoint_);
			soundtrackRedpointList_.Add(other.soundtrackRedpointList_);
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
			case 58u:
				mvRedpoint_.AddEntriesFrom(input, _repeated_mvRedpoint_codec);
				break;
			case 66u:
				soundtrackRedpointList_.AddEntriesFrom(input, _repeated_soundtrackRedpointList_codec);
				break;
			}
		}
	}
}
