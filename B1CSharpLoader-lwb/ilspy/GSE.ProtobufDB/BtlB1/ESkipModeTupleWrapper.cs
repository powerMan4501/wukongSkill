using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class ESkipModeTupleWrapper : IMessage<ESkipModeTupleWrapper>, IMessage, IEquatable<ESkipModeTupleWrapper>, IDeepCloneable<ESkipModeTupleWrapper>
{
	private static readonly MessageParser<ESkipModeTupleWrapper> _parser = new MessageParser<ESkipModeTupleWrapper>(() => new ESkipModeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESkipMode item1_;

	private ESkipMode item2_;

	public static MessageParser<ESkipModeTupleWrapper> Parser => _parser;

	public ESkipMode Item1
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

	public ESkipMode Item2
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

	public ESkipModeTupleWrapper()
	{
	}

	public ESkipModeTupleWrapper(ESkipModeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESkipModeTupleWrapper Clone()
	{
		return new ESkipModeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESkipModeTupleWrapper);
	}

	public bool Equals(ESkipModeTupleWrapper other)
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
		if (Item1 != ESkipMode.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESkipMode.None)
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
		if (Item1 != ESkipMode.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESkipMode.None)
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
		if (Item1 != ESkipMode.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESkipMode.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESkipModeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESkipMode.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESkipMode.None)
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
				Item1 = (ESkipMode)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESkipMode)input.ReadEnum();
				break;
			}
		}
	}
}
