using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ResConstValueDefTupleWrapper : IMessage<ResConstValueDefTupleWrapper>, IMessage, IEquatable<ResConstValueDefTupleWrapper>, IDeepCloneable<ResConstValueDefTupleWrapper>
{
	private static readonly MessageParser<ResConstValueDefTupleWrapper> _parser = new MessageParser<ResConstValueDefTupleWrapper>(() => new ResConstValueDefTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ResConstValueDef item1_;

	private ResConstValueDef item2_;

	public static MessageParser<ResConstValueDefTupleWrapper> Parser => _parser;

	public ResConstValueDef Item1
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

	public ResConstValueDef Item2
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

	public ResConstValueDefTupleWrapper()
	{
	}

	public ResConstValueDefTupleWrapper(ResConstValueDefTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ResConstValueDefTupleWrapper Clone()
	{
		return new ResConstValueDefTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ResConstValueDefTupleWrapper);
	}

	public bool Equals(ResConstValueDefTupleWrapper other)
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
		if (Item1 != ResConstValueDef.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ResConstValueDef.Default)
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
		if (Item1 != ResConstValueDef.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ResConstValueDef.Default)
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
		if (Item1 != ResConstValueDef.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ResConstValueDef.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ResConstValueDefTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ResConstValueDef.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ResConstValueDef.Default)
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
				Item1 = (ResConstValueDef)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ResConstValueDef)input.ReadEnum();
				break;
			}
		}
	}
}
