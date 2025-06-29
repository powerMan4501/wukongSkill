using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class DropRecordSyncWrapper : IMessage<DropRecordSyncWrapper>, IMessage, IEquatable<DropRecordSyncWrapper>, IDeepCloneable<DropRecordSyncWrapper>
{
	private static readonly MessageParser<DropRecordSyncWrapper> _parser = new MessageParser<DropRecordSyncWrapper>(() => new DropRecordSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper dropId_;

	private Uint32SyncWrapper dropCount_;

	private Uint32SyncWrapper guaranteeDropCount_;

	public static MessageParser<DropRecordSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper DropId
	{
		get
		{
			return dropId_;
		}
		set
		{
			dropId_ = value;
		}
	}

	public Uint32SyncWrapper DropCount
	{
		get
		{
			return dropCount_;
		}
		set
		{
			dropCount_ = value;
		}
	}

	public Uint32SyncWrapper GuaranteeDropCount
	{
		get
		{
			return guaranteeDropCount_;
		}
		set
		{
			guaranteeDropCount_ = value;
		}
	}

	public DropRecordSyncWrapper()
	{
	}

	public DropRecordSyncWrapper(DropRecordSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		dropId_ = ((other.dropId_ != null) ? other.dropId_.Clone() : null);
		dropCount_ = ((other.dropCount_ != null) ? other.dropCount_.Clone() : null);
		guaranteeDropCount_ = ((other.guaranteeDropCount_ != null) ? other.guaranteeDropCount_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DropRecordSyncWrapper Clone()
	{
		return new DropRecordSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DropRecordSyncWrapper);
	}

	public bool Equals(DropRecordSyncWrapper other)
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
		if (!object.Equals(DropId, other.DropId))
		{
			return false;
		}
		if (!object.Equals(DropCount, other.DropCount))
		{
			return false;
		}
		if (!object.Equals(GuaranteeDropCount, other.GuaranteeDropCount))
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
		if (dropId_ != null)
		{
			num ^= DropId.GetHashCode();
		}
		if (dropCount_ != null)
		{
			num ^= DropCount.GetHashCode();
		}
		if (guaranteeDropCount_ != null)
		{
			num ^= GuaranteeDropCount.GetHashCode();
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
		if (dropId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(DropId);
		}
		if (dropCount_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(DropCount);
		}
		if (guaranteeDropCount_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(GuaranteeDropCount);
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
		if (dropId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DropId);
		}
		if (dropCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DropCount);
		}
		if (guaranteeDropCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GuaranteeDropCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DropRecordSyncWrapper other)
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
		if (other.dropId_ != null)
		{
			if (dropId_ == null)
			{
				DropId = new Int32SyncWrapper();
			}
			DropId.MergeFrom(other.DropId);
		}
		if (other.dropCount_ != null)
		{
			if (dropCount_ == null)
			{
				DropCount = new Uint32SyncWrapper();
			}
			DropCount.MergeFrom(other.DropCount);
		}
		if (other.guaranteeDropCount_ != null)
		{
			if (guaranteeDropCount_ == null)
			{
				GuaranteeDropCount = new Uint32SyncWrapper();
			}
			GuaranteeDropCount.MergeFrom(other.GuaranteeDropCount);
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
				if (dropId_ == null)
				{
					DropId = new Int32SyncWrapper();
				}
				input.ReadMessage(DropId);
				break;
			case 34u:
				if (dropCount_ == null)
				{
					DropCount = new Uint32SyncWrapper();
				}
				input.ReadMessage(DropCount);
				break;
			case 42u:
				if (guaranteeDropCount_ == null)
				{
					GuaranteeDropCount = new Uint32SyncWrapper();
				}
				input.ReadMessage(GuaranteeDropCount);
				break;
			}
		}
	}
}
