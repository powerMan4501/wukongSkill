using System;
using Google.Protobuf;

namespace ResB1;

public sealed class HistoricTypeTupleWrapper : IMessage<HistoricTypeTupleWrapper>, IMessage, IEquatable<HistoricTypeTupleWrapper>, IDeepCloneable<HistoricTypeTupleWrapper>
{
	private static readonly MessageParser<HistoricTypeTupleWrapper> _parser = new MessageParser<HistoricTypeTupleWrapper>(() => new HistoricTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private HistoricType item1_;

	private HistoricType item2_;

	public static MessageParser<HistoricTypeTupleWrapper> Parser => _parser;

	public HistoricType Item1
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

	public HistoricType Item2
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

	public HistoricTypeTupleWrapper()
	{
	}

	public HistoricTypeTupleWrapper(HistoricTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public HistoricTypeTupleWrapper Clone()
	{
		return new HistoricTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as HistoricTypeTupleWrapper);
	}

	public bool Equals(HistoricTypeTupleWrapper other)
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
		if (Item1 != HistoricType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != HistoricType.None)
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
		if (Item1 != HistoricType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != HistoricType.None)
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
		if (Item1 != HistoricType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != HistoricType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(HistoricTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != HistoricType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != HistoricType.None)
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
				Item1 = (HistoricType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (HistoricType)input.ReadEnum();
				break;
			}
		}
	}
}
