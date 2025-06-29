using System;
using Google.Protobuf;

namespace ResB1;

public sealed class SignStyleTupleWrapper : IMessage<SignStyleTupleWrapper>, IMessage, IEquatable<SignStyleTupleWrapper>, IDeepCloneable<SignStyleTupleWrapper>
{
	private static readonly MessageParser<SignStyleTupleWrapper> _parser = new MessageParser<SignStyleTupleWrapper>(() => new SignStyleTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private SignStyle item1_;

	private SignStyle item2_;

	public static MessageParser<SignStyleTupleWrapper> Parser => _parser;

	public SignStyle Item1
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

	public SignStyle Item2
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

	public SignStyleTupleWrapper()
	{
	}

	public SignStyleTupleWrapper(SignStyleTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SignStyleTupleWrapper Clone()
	{
		return new SignStyleTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SignStyleTupleWrapper);
	}

	public bool Equals(SignStyleTupleWrapper other)
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
		if (Item1 != SignStyle.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != SignStyle.Default)
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
		if (Item1 != SignStyle.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != SignStyle.Default)
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
		if (Item1 != SignStyle.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != SignStyle.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SignStyleTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != SignStyle.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != SignStyle.Default)
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
				Item1 = (SignStyle)input.ReadEnum();
				break;
			case 16u:
				Item2 = (SignStyle)input.ReadEnum();
				break;
			}
		}
	}
}
