using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EProjectileBeHittedCostAttrTypeSyncWrapper : IMessage<EProjectileBeHittedCostAttrTypeSyncWrapper>, IMessage, IEquatable<EProjectileBeHittedCostAttrTypeSyncWrapper>, IDeepCloneable<EProjectileBeHittedCostAttrTypeSyncWrapper>
{
	private static readonly MessageParser<EProjectileBeHittedCostAttrTypeSyncWrapper> _parser = new MessageParser<EProjectileBeHittedCostAttrTypeSyncWrapper>(() => new EProjectileBeHittedCostAttrTypeSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private EProjectileBeHittedCostAttrType value_;

	public static MessageParser<EProjectileBeHittedCostAttrTypeSyncWrapper> Parser => _parser;

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

	public EProjectileBeHittedCostAttrType Value
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

	public EProjectileBeHittedCostAttrTypeSyncWrapper()
	{
	}

	public EProjectileBeHittedCostAttrTypeSyncWrapper(EProjectileBeHittedCostAttrTypeSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EProjectileBeHittedCostAttrTypeSyncWrapper Clone()
	{
		return new EProjectileBeHittedCostAttrTypeSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EProjectileBeHittedCostAttrTypeSyncWrapper);
	}

	public bool Equals(EProjectileBeHittedCostAttrTypeSyncWrapper other)
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
		if (Value != EProjectileBeHittedCostAttrType.None)
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
		if (Value != EProjectileBeHittedCostAttrType.None)
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
		if (Value != EProjectileBeHittedCostAttrType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EProjectileBeHittedCostAttrTypeSyncWrapper other)
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
			if (other.Value != EProjectileBeHittedCostAttrType.None)
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
				Value = (EProjectileBeHittedCostAttrType)input.ReadEnum();
				break;
			}
		}
	}
}
