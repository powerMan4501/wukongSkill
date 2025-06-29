using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class WearAccessorySyncWrapper : IMessage<WearAccessorySyncWrapper>, IMessage, IEquatable<WearAccessorySyncWrapper>, IDeepCloneable<WearAccessorySyncWrapper>
{
	private static readonly MessageParser<WearAccessorySyncWrapper> _parser = new MessageParser<WearAccessorySyncWrapper>(() => new WearAccessorySyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<AccessoryPropSyncWrapper> _repeated_accessorylist_codec = FieldCodec.ForMessage(34u, AccessoryPropSyncWrapper.Parser);

	private readonly RepeatedField<AccessoryPropSyncWrapper> accessorylist_ = new RepeatedField<AccessoryPropSyncWrapper>();

	public static MessageParser<WearAccessorySyncWrapper> Parser => _parser;

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

	public RepeatedField<AccessoryPropSyncWrapper> Accessorylist => accessorylist_;

	public WearAccessorySyncWrapper()
	{
	}

	public WearAccessorySyncWrapper(WearAccessorySyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		accessorylist_ = other.accessorylist_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public WearAccessorySyncWrapper Clone()
	{
		return new WearAccessorySyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as WearAccessorySyncWrapper);
	}

	public bool Equals(WearAccessorySyncWrapper other)
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
		if (!accessorylist_.Equals(other.accessorylist_))
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
		num ^= accessorylist_.GetHashCode();
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
		accessorylist_.WriteTo(output, _repeated_accessorylist_codec);
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
		num += accessorylist_.CalculateSize(_repeated_accessorylist_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(WearAccessorySyncWrapper other)
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
			accessorylist_.Add(other.accessorylist_);
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
			case 34u:
				accessorylist_.AddEntriesFrom(input, _repeated_accessorylist_codec);
				break;
			}
		}
	}
}
