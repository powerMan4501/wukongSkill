using System;
using Google.Protobuf;

namespace BtlU3;

public sealed class EB2DDamageCauseDeadTypeSyncWrapper : IMessage<EB2DDamageCauseDeadTypeSyncWrapper>, IMessage, IEquatable<EB2DDamageCauseDeadTypeSyncWrapper>, IDeepCloneable<EB2DDamageCauseDeadTypeSyncWrapper>
{
	private static readonly MessageParser<EB2DDamageCauseDeadTypeSyncWrapper> _parser = new MessageParser<EB2DDamageCauseDeadTypeSyncWrapper>(() => new EB2DDamageCauseDeadTypeSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private EB2DDamageCauseDeadType value_;

	public static MessageParser<EB2DDamageCauseDeadTypeSyncWrapper> Parser => _parser;

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

	public EB2DDamageCauseDeadType Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	public EB2DDamageCauseDeadTypeSyncWrapper()
	{
	}

	public EB2DDamageCauseDeadTypeSyncWrapper(EB2DDamageCauseDeadTypeSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EB2DDamageCauseDeadTypeSyncWrapper Clone()
	{
		return new EB2DDamageCauseDeadTypeSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EB2DDamageCauseDeadTypeSyncWrapper);
	}

	public bool Equals(EB2DDamageCauseDeadTypeSyncWrapper other)
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
		if (Value != other.Value)
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
		if (Value != EB2DDamageCauseDeadType.Norm)
		{
			num ^= Value.GetHashCode();
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
		if (Value != EB2DDamageCauseDeadType.Norm)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Value);
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
		if (Value != EB2DDamageCauseDeadType.Norm)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EB2DDamageCauseDeadTypeSyncWrapper other)
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
			if (other.Value != EB2DDamageCauseDeadType.Norm)
			{
				Value = other.Value;
			}
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
			case 24u:
				Value = (EB2DDamageCauseDeadType)input.ReadEnum();
				break;
			}
		}
	}
}
