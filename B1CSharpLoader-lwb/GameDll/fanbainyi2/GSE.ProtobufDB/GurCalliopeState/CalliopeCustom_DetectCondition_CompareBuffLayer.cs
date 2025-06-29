using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_CompareBuffLayer : IMessage<CalliopeCustom_DetectCondition_CompareBuffLayer>, IMessage, IEquatable<CalliopeCustom_DetectCondition_CompareBuffLayer>, IDeepCloneable<CalliopeCustom_DetectCondition_CompareBuffLayer>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_CompareBuffLayer> _parser = new MessageParser<CalliopeCustom_DetectCondition_CompareBuffLayer>(() => new CalliopeCustom_DetectCondition_CompareBuffLayer());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int buffId_;

	private int buffLayer_;

	private int operationType_;

	public static MessageParser<CalliopeCustom_DetectCondition_CompareBuffLayer> Parser => _parser;

	public int BuffId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return buffId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			buffId_ = value;
		}
	}

	public bool HasBuffId => (_hasBits0 & 1) != 0;

	public int BuffLayer
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return buffLayer_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			buffLayer_ = value;
		}
	}

	public bool HasBuffLayer => (_hasBits0 & 2) != 0;

	public int OperationType
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return operationType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			operationType_ = value;
		}
	}

	public bool HasOperationType => (_hasBits0 & 4) != 0;

	public CalliopeCustom_DetectCondition_CompareBuffLayer()
	{
	}

	public CalliopeCustom_DetectCondition_CompareBuffLayer(CalliopeCustom_DetectCondition_CompareBuffLayer other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		buffId_ = other.buffId_;
		buffLayer_ = other.buffLayer_;
		operationType_ = other.operationType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_CompareBuffLayer Clone()
	{
		return new CalliopeCustom_DetectCondition_CompareBuffLayer(this);
	}

	public void ClearBuffId()
	{
		_hasBits0 &= -2;
	}

	public void ClearBuffLayer()
	{
		_hasBits0 &= -3;
	}

	public void ClearOperationType()
	{
		_hasBits0 &= -5;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_CompareBuffLayer);
	}

	public bool Equals(CalliopeCustom_DetectCondition_CompareBuffLayer other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (BuffLayer != other.BuffLayer)
		{
			return false;
		}
		if (OperationType != other.OperationType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasBuffId)
		{
			num ^= BuffId.GetHashCode();
		}
		if (HasBuffLayer)
		{
			num ^= BuffLayer.GetHashCode();
		}
		if (HasOperationType)
		{
			num ^= OperationType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasBuffId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BuffId);
		}
		if (HasBuffLayer)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuffLayer);
		}
		if (HasOperationType)
		{
			output.WriteRawTag(24);
			output.WriteInt32(OperationType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasBuffId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (HasBuffLayer)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffLayer);
		}
		if (HasOperationType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OperationType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_CompareBuffLayer other)
	{
		if (other != null)
		{
			if (other.HasBuffId)
			{
				BuffId = other.BuffId;
			}
			if (other.HasBuffLayer)
			{
				BuffLayer = other.BuffLayer;
			}
			if (other.HasOperationType)
			{
				OperationType = other.OperationType;
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
				BuffId = input.ReadInt32();
				break;
			case 16u:
				BuffLayer = input.ReadInt32();
				break;
			case 24u:
				OperationType = input.ReadInt32();
				break;
			}
		}
	}
}
