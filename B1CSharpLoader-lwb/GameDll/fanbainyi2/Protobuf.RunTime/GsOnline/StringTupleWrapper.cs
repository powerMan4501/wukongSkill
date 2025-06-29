using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class StringTupleWrapper : IMessage<StringTupleWrapper>, IMessage, IEquatable<StringTupleWrapper>, IDeepCloneable<StringTupleWrapper>
{
	private static readonly MessageParser<StringTupleWrapper> _parser = new MessageParser<StringTupleWrapper>(() => new StringTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private string item1_ = "";

	private string item2_ = "";

	public static MessageParser<StringTupleWrapper> Parser => _parser;

	public string Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public StringTupleWrapper()
	{
	}

	public StringTupleWrapper(StringTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public StringTupleWrapper Clone()
	{
		return new StringTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as StringTupleWrapper);
	}

	public bool Equals(StringTupleWrapper other)
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
		if (Item1.Length != 0)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2.Length != 0)
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
		if (Item1.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Item1);
		}
		if (Item2.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Item1);
		}
		if (Item2.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(StringTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1.Length != 0)
			{
				Item1 = other.Item1;
			}
			if (other.Item2.Length != 0)
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
			case 10u:
				Item1 = input.ReadString();
				break;
			case 18u:
				Item2 = input.ReadString();
				break;
			}
		}
	}
}
