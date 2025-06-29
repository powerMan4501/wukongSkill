using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkReviewStatusTupleWrapper : IMessage<GssdkReviewStatusTupleWrapper>, IMessage, IEquatable<GssdkReviewStatusTupleWrapper>, IDeepCloneable<GssdkReviewStatusTupleWrapper>
{
	private static readonly MessageParser<GssdkReviewStatusTupleWrapper> _parser = new MessageParser<GssdkReviewStatusTupleWrapper>(() => new GssdkReviewStatusTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private GssdkReviewStatus item1_;

	private GssdkReviewStatus item2_;

	public static MessageParser<GssdkReviewStatusTupleWrapper> Parser => _parser;

	public GssdkReviewStatus Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public GssdkReviewStatus Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public GssdkReviewStatusTupleWrapper()
	{
	}

	public GssdkReviewStatusTupleWrapper(GssdkReviewStatusTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkReviewStatusTupleWrapper Clone()
	{
		return new GssdkReviewStatusTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkReviewStatusTupleWrapper);
	}

	public bool Equals(GssdkReviewStatusTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Item1 != other.Item1)
		{
			return false;
		}
		if (Item2 != other.Item2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != GssdkReviewStatus.Normal)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != GssdkReviewStatus.Normal)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != GssdkReviewStatus.Normal)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != GssdkReviewStatus.Normal)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != GssdkReviewStatus.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != GssdkReviewStatus.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkReviewStatusTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != GssdkReviewStatus.Normal)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != GssdkReviewStatus.Normal)
			{
				Item2 = other.Item2;
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
				Item1 = (GssdkReviewStatus)input.ReadEnum();
				break;
			case 16u:
				Item2 = (GssdkReviewStatus)input.ReadEnum();
				break;
			}
		}
	}
}
