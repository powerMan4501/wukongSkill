using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class EB2DEffectRangeTargetBaseSyncWrapper : IMessage<EB2DEffectRangeTargetBaseSyncWrapper>, IMessage, IEquatable<EB2DEffectRangeTargetBaseSyncWrapper>, IDeepCloneable<EB2DEffectRangeTargetBaseSyncWrapper>
{
	private static readonly MessageParser<EB2DEffectRangeTargetBaseSyncWrapper> _parser = new MessageParser<EB2DEffectRangeTargetBaseSyncWrapper>(() => new EB2DEffectRangeTargetBaseSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private EB2DEffectRangeTargetBase value_;

	public static MessageParser<EB2DEffectRangeTargetBaseSyncWrapper> Parser => _parser;

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

	public EB2DEffectRangeTargetBase Value
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

	public EB2DEffectRangeTargetBaseSyncWrapper()
	{
	}

	public EB2DEffectRangeTargetBaseSyncWrapper(EB2DEffectRangeTargetBaseSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EB2DEffectRangeTargetBaseSyncWrapper Clone()
	{
		return new EB2DEffectRangeTargetBaseSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EB2DEffectRangeTargetBaseSyncWrapper);
	}

	public bool Equals(EB2DEffectRangeTargetBaseSyncWrapper other)
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
		if (Value != EB2DEffectRangeTargetBase.Auto)
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
		if (Value != EB2DEffectRangeTargetBase.Auto)
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
		if (Value != EB2DEffectRangeTargetBase.Auto)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EB2DEffectRangeTargetBaseSyncWrapper other)
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
			if (other.Value != EB2DEffectRangeTargetBase.Auto)
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
				Value = (EB2DEffectRangeTargetBase)input.ReadEnum();
				break;
			}
		}
	}
}
