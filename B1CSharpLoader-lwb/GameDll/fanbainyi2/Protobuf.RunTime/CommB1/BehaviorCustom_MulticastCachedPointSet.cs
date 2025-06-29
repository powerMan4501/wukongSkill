using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_MulticastCachedPointSet : IMessage<BehaviorCustom_MulticastCachedPointSet>, IMessage, IEquatable<BehaviorCustom_MulticastCachedPointSet>, IDeepCloneable<BehaviorCustom_MulticastCachedPointSet>
{
	private static readonly MessageParser<BehaviorCustom_MulticastCachedPointSet> _parser = new MessageParser<BehaviorCustom_MulticastCachedPointSet>(() => new BehaviorCustom_MulticastCachedPointSet());

	private UnknownFieldSet _unknownFields;

	private int requestId_;

	public static MessageParser<BehaviorCustom_MulticastCachedPointSet> Parser => _parser;

	public int RequestId
	{
		get
		{
			return requestId_;
		}
		set
		{
			requestId_ = value;
		}
	}

	public BehaviorCustom_MulticastCachedPointSet()
	{
	}

	public BehaviorCustom_MulticastCachedPointSet(BehaviorCustom_MulticastCachedPointSet other)
		: this()
	{
		requestId_ = other.requestId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_MulticastCachedPointSet Clone()
	{
		return new BehaviorCustom_MulticastCachedPointSet(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_MulticastCachedPointSet);
	}

	public bool Equals(BehaviorCustom_MulticastCachedPointSet other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RequestId != other.RequestId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RequestId != 0)
		{
			num ^= RequestId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RequestId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(RequestId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RequestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RequestId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_MulticastCachedPointSet other)
	{
		if (other != null)
		{
			if (other.RequestId != 0)
			{
				RequestId = other.RequestId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				RequestId = input.ReadInt32();
			}
		}
	}
}
