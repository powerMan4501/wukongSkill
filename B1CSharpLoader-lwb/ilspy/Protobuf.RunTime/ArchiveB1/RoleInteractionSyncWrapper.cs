using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class RoleInteractionSyncWrapper : IMessage<RoleInteractionSyncWrapper>, IMessage, IEquatable<RoleInteractionSyncWrapper>, IDeepCloneable<RoleInteractionSyncWrapper>
{
	private static readonly MessageParser<RoleInteractionSyncWrapper> _parser = new MessageParser<RoleInteractionSyncWrapper>(() => new RoleInteractionSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_interactionFuncList_codec = FieldCodec.ForMessage(26u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> interactionFuncList_ = new RepeatedField<Int32SyncWrapper>();

	public static MessageParser<RoleInteractionSyncWrapper> Parser => _parser;

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

	public RepeatedField<Int32SyncWrapper> InteractionFuncList => interactionFuncList_;

	public RoleInteractionSyncWrapper()
	{
	}

	public RoleInteractionSyncWrapper(RoleInteractionSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		interactionFuncList_ = other.interactionFuncList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleInteractionSyncWrapper Clone()
	{
		return new RoleInteractionSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleInteractionSyncWrapper);
	}

	public bool Equals(RoleInteractionSyncWrapper other)
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
		if (!interactionFuncList_.Equals(other.interactionFuncList_))
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
		num ^= interactionFuncList_.GetHashCode();
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
		interactionFuncList_.WriteTo(output, _repeated_interactionFuncList_codec);
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
		num += interactionFuncList_.CalculateSize(_repeated_interactionFuncList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleInteractionSyncWrapper other)
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
			interactionFuncList_.Add(other.interactionFuncList_);
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
				interactionFuncList_.AddEntriesFrom(input, _repeated_interactionFuncList_codec);
				break;
			}
		}
	}
}
