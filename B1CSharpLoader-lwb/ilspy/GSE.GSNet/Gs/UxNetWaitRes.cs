using System;
using Google.Protobuf;

namespace Gs;

public sealed class UxNetWaitRes : IMessage<UxNetWaitRes>, IMessage, IEquatable<UxNetWaitRes>, IDeepCloneable<UxNetWaitRes>
{
	private static readonly MessageParser<UxNetWaitRes> _parser = new MessageParser<UxNetWaitRes>(() => new UxNetWaitRes());

	private UnknownFieldSet _unknownFields;

	private uint waitQueueOrder_;

	private uint estimateTime_;

	public static MessageParser<UxNetWaitRes> Parser => _parser;

	public uint WaitQueueOrder
	{
		get
		{
			return waitQueueOrder_;
		}
		set
		{
			waitQueueOrder_ = value;
		}
	}

	public uint EstimateTime
	{
		get
		{
			return estimateTime_;
		}
		set
		{
			estimateTime_ = value;
		}
	}

	public UxNetWaitRes()
	{
	}

	public UxNetWaitRes(UxNetWaitRes other)
		: this()
	{
		waitQueueOrder_ = other.waitQueueOrder_;
		estimateTime_ = other.estimateTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UxNetWaitRes Clone()
	{
		return new UxNetWaitRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UxNetWaitRes);
	}

	public bool Equals(UxNetWaitRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (WaitQueueOrder != other.WaitQueueOrder)
		{
			return false;
		}
		if (EstimateTime != other.EstimateTime)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (WaitQueueOrder != 0)
		{
			num ^= WaitQueueOrder.GetHashCode();
		}
		if (EstimateTime != 0)
		{
			num ^= EstimateTime.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (WaitQueueOrder != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(WaitQueueOrder);
		}
		if (EstimateTime != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EstimateTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (WaitQueueOrder != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WaitQueueOrder);
		}
		if (EstimateTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EstimateTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UxNetWaitRes other)
	{
		if (other != null)
		{
			if (other.WaitQueueOrder != 0)
			{
				WaitQueueOrder = other.WaitQueueOrder;
			}
			if (other.EstimateTime != 0)
			{
				EstimateTime = other.EstimateTime;
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
				WaitQueueOrder = input.ReadUInt32();
				break;
			case 16u:
				EstimateTime = input.ReadUInt32();
				break;
			}
		}
	}
}
