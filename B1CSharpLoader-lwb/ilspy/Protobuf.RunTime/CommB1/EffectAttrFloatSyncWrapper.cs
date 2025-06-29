using System;
using BtlShare;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class EffectAttrFloatSyncWrapper : IMessage<EffectAttrFloatSyncWrapper>, IMessage, IEquatable<EffectAttrFloatSyncWrapper>, IDeepCloneable<EffectAttrFloatSyncWrapper>
{
	private static readonly MessageParser<EffectAttrFloatSyncWrapper> _parser = new MessageParser<EffectAttrFloatSyncWrapper>(() => new EffectAttrFloatSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private EBGUAttrFloatSyncWrapper type_;

	private FloatSyncWrapper value_;

	public static MessageParser<EffectAttrFloatSyncWrapper> Parser => _parser;

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

	public EBGUAttrFloatSyncWrapper Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public FloatSyncWrapper Value
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

	public EffectAttrFloatSyncWrapper()
	{
	}

	public EffectAttrFloatSyncWrapper(EffectAttrFloatSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		type_ = ((other.type_ != null) ? other.type_.Clone() : null);
		value_ = ((other.value_ != null) ? other.value_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EffectAttrFloatSyncWrapper Clone()
	{
		return new EffectAttrFloatSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EffectAttrFloatSyncWrapper);
	}

	public bool Equals(EffectAttrFloatSyncWrapper other)
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
		if (!object.Equals(Type, other.Type))
		{
			return false;
		}
		if (!object.Equals(Value, other.Value))
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
		if (type_ != null)
		{
			num ^= Type.GetHashCode();
		}
		if (value_ != null)
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
		if (type_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Type);
		}
		if (value_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Value);
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
		if (type_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Type);
		}
		if (value_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EffectAttrFloatSyncWrapper other)
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
		if (other.type_ != null)
		{
			if (type_ == null)
			{
				Type = new EBGUAttrFloatSyncWrapper();
			}
			Type.MergeFrom(other.Type);
		}
		if (other.value_ != null)
		{
			if (value_ == null)
			{
				Value = new FloatSyncWrapper();
			}
			Value.MergeFrom(other.Value);
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
				if (type_ == null)
				{
					Type = new EBGUAttrFloatSyncWrapper();
				}
				input.ReadMessage(Type);
				break;
			case 34u:
				if (value_ == null)
				{
					Value = new FloatSyncWrapper();
				}
				input.ReadMessage(Value);
				break;
			}
		}
	}
}
