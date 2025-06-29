using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CommConstValueDefTupleWrapper : IMessage<CommConstValueDefTupleWrapper>, IMessage, IEquatable<CommConstValueDefTupleWrapper>, IDeepCloneable<CommConstValueDefTupleWrapper>
{
	private static readonly MessageParser<CommConstValueDefTupleWrapper> _parser = new MessageParser<CommConstValueDefTupleWrapper>(() => new CommConstValueDefTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private CommConstValueDef item1_;

	private CommConstValueDef item2_;

	public static MessageParser<CommConstValueDefTupleWrapper> Parser => _parser;

	public CommConstValueDef Item1
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

	public CommConstValueDef Item2
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

	public CommConstValueDefTupleWrapper()
	{
	}

	public CommConstValueDefTupleWrapper(CommConstValueDefTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CommConstValueDefTupleWrapper Clone()
	{
		return new CommConstValueDefTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CommConstValueDefTupleWrapper);
	}

	public bool Equals(CommConstValueDefTupleWrapper other)
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
		if (Item1 != CommConstValueDef.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != CommConstValueDef.Default)
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
		if (Item1 != CommConstValueDef.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != CommConstValueDef.Default)
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
		if (Item1 != CommConstValueDef.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != CommConstValueDef.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CommConstValueDefTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != CommConstValueDef.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != CommConstValueDef.Default)
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
				Item1 = (CommConstValueDef)input.ReadEnum();
				break;
			case 16u:
				Item2 = (CommConstValueDef)input.ReadEnum();
				break;
			}
		}
	}
}
