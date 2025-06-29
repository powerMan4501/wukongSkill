using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class CollectionGroupDataInfo : IMessage<CollectionGroupDataInfo>, IMessage, IEquatable<CollectionGroupDataInfo>, IDeepCloneable<CollectionGroupDataInfo>
{
	private static readonly MessageParser<CollectionGroupDataInfo> _parser = new MessageParser<CollectionGroupDataInfo>(() => new CollectionGroupDataInfo());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int freshTime_;

	private int freshCount_;

	public static MessageParser<CollectionGroupDataInfo> Parser => _parser;

	public int FreshTime
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return freshTime_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			freshTime_ = value;
		}
	}

	public bool HasFreshTime => (_hasBits0 & 1) != 0;

	public int FreshCount
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return freshCount_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			freshCount_ = value;
		}
	}

	public bool HasFreshCount => (_hasBits0 & 2) != 0;

	public CollectionGroupDataInfo()
	{
	}

	public CollectionGroupDataInfo(CollectionGroupDataInfo other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		freshTime_ = other.freshTime_;
		freshCount_ = other.freshCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CollectionGroupDataInfo Clone()
	{
		return new CollectionGroupDataInfo(this);
	}

	public void ClearFreshTime()
	{
		_hasBits0 &= -2;
	}

	public void ClearFreshCount()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CollectionGroupDataInfo);
	}

	public bool Equals(CollectionGroupDataInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FreshTime != other.FreshTime)
		{
			return false;
		}
		if (FreshCount != other.FreshCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasFreshTime)
		{
			num ^= FreshTime.GetHashCode();
		}
		if (HasFreshCount)
		{
			num ^= FreshCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasFreshTime)
		{
			output.WriteRawTag(8);
			output.WriteInt32(FreshTime);
		}
		if (HasFreshCount)
		{
			output.WriteRawTag(16);
			output.WriteInt32(FreshCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasFreshTime)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FreshTime);
		}
		if (HasFreshCount)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FreshCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CollectionGroupDataInfo other)
	{
		if (other != null)
		{
			if (other.HasFreshTime)
			{
				FreshTime = other.FreshTime;
			}
			if (other.HasFreshCount)
			{
				FreshCount = other.FreshCount;
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
				FreshTime = input.ReadInt32();
				break;
			case 16u:
				FreshCount = input.ReadInt32();
				break;
			}
		}
	}
}
