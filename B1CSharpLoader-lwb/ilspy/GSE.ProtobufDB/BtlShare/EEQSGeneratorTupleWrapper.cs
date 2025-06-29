using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EEQSGeneratorTupleWrapper : IMessage<EEQSGeneratorTupleWrapper>, IMessage, IEquatable<EEQSGeneratorTupleWrapper>, IDeepCloneable<EEQSGeneratorTupleWrapper>
{
	private static readonly MessageParser<EEQSGeneratorTupleWrapper> _parser = new MessageParser<EEQSGeneratorTupleWrapper>(() => new EEQSGeneratorTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EEQSGenerator item1_;

	private EEQSGenerator item2_;

	public static MessageParser<EEQSGeneratorTupleWrapper> Parser => _parser;

	public EEQSGenerator Item1
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

	public EEQSGenerator Item2
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

	public EEQSGeneratorTupleWrapper()
	{
	}

	public EEQSGeneratorTupleWrapper(EEQSGeneratorTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EEQSGeneratorTupleWrapper Clone()
	{
		return new EEQSGeneratorTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EEQSGeneratorTupleWrapper);
	}

	public bool Equals(EEQSGeneratorTupleWrapper other)
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
		if (Item1 != EEQSGenerator.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EEQSGenerator.None)
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
		if (Item1 != EEQSGenerator.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EEQSGenerator.None)
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
		if (Item1 != EEQSGenerator.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EEQSGenerator.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EEQSGeneratorTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EEQSGenerator.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EEQSGenerator.None)
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
				Item1 = (EEQSGenerator)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EEQSGenerator)input.ReadEnum();
				break;
			}
		}
	}
}
