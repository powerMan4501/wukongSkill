using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class ReadArchiveResultTupleWrapper : IMessage<ReadArchiveResultTupleWrapper>, IMessage, IEquatable<ReadArchiveResultTupleWrapper>, IDeepCloneable<ReadArchiveResultTupleWrapper>
{
	private static readonly MessageParser<ReadArchiveResultTupleWrapper> _parser = new MessageParser<ReadArchiveResultTupleWrapper>(() => new ReadArchiveResultTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ReadArchiveResult item1_;

	private ReadArchiveResult item2_;

	public static MessageParser<ReadArchiveResultTupleWrapper> Parser => _parser;

	public ReadArchiveResult Item1
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

	public ReadArchiveResult Item2
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

	public ReadArchiveResultTupleWrapper()
	{
	}

	public ReadArchiveResultTupleWrapper(ReadArchiveResultTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReadArchiveResultTupleWrapper Clone()
	{
		return new ReadArchiveResultTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReadArchiveResultTupleWrapper);
	}

	public bool Equals(ReadArchiveResultTupleWrapper other)
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
		if (Item1 != ReadArchiveResult.Success)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ReadArchiveResult.Success)
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
		if (Item1 != ReadArchiveResult.Success)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ReadArchiveResult.Success)
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
		if (Item1 != ReadArchiveResult.Success)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ReadArchiveResult.Success)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReadArchiveResultTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ReadArchiveResult.Success)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ReadArchiveResult.Success)
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
				Item1 = (ReadArchiveResult)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ReadArchiveResult)input.ReadEnum();
				break;
			}
		}
	}
}
