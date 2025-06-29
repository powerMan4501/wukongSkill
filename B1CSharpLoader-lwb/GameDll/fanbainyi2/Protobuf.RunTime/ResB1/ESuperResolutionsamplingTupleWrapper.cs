using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ESuperResolutionsamplingTupleWrapper : IMessage<ESuperResolutionsamplingTupleWrapper>, IMessage, IEquatable<ESuperResolutionsamplingTupleWrapper>, IDeepCloneable<ESuperResolutionsamplingTupleWrapper>
{
	private static readonly MessageParser<ESuperResolutionsamplingTupleWrapper> _parser = new MessageParser<ESuperResolutionsamplingTupleWrapper>(() => new ESuperResolutionsamplingTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESuperResolutionsampling item1_;

	private ESuperResolutionsampling item2_;

	public static MessageParser<ESuperResolutionsamplingTupleWrapper> Parser => _parser;

	public ESuperResolutionsampling Item1
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

	public ESuperResolutionsampling Item2
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

	public ESuperResolutionsamplingTupleWrapper()
	{
	}

	public ESuperResolutionsamplingTupleWrapper(ESuperResolutionsamplingTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESuperResolutionsamplingTupleWrapper Clone()
	{
		return new ESuperResolutionsamplingTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESuperResolutionsamplingTupleWrapper);
	}

	public bool Equals(ESuperResolutionsamplingTupleWrapper other)
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
		if (Item1 != ESuperResolutionsampling.Fsr)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESuperResolutionsampling.Fsr)
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
		if (Item1 != ESuperResolutionsampling.Fsr)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESuperResolutionsampling.Fsr)
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
		if (Item1 != ESuperResolutionsampling.Fsr)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESuperResolutionsampling.Fsr)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESuperResolutionsamplingTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESuperResolutionsampling.Fsr)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESuperResolutionsampling.Fsr)
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
				Item1 = (ESuperResolutionsampling)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESuperResolutionsampling)input.ReadEnum();
				break;
			}
		}
	}
}
