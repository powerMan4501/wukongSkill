using System;
using Google.Protobuf;

namespace GsOnlineFriend;

public sealed class BytesTupleWrapper : IMessage<BytesTupleWrapper>, IMessage, IEquatable<BytesTupleWrapper>, IDeepCloneable<BytesTupleWrapper>
{
	private static readonly MessageParser<BytesTupleWrapper> _parser = new MessageParser<BytesTupleWrapper>(() => new BytesTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ByteString item1_ = ByteString.Empty;

	private ByteString item2_ = ByteString.Empty;

	public static MessageParser<BytesTupleWrapper> Parser => _parser;

	public ByteString Item1
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

	public ByteString Item2
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

	public BytesTupleWrapper()
	{
	}

	public BytesTupleWrapper(BytesTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BytesTupleWrapper Clone()
	{
		return new BytesTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BytesTupleWrapper);
	}

	public bool Equals(BytesTupleWrapper other)
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
			output.WriteBytes(Item1);
		}
		if (Item2.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(Item2);
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
			num += 1 + CodedOutputStream.ComputeBytesSize(Item1);
		}
		if (Item2.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BytesTupleWrapper other)
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
				Item1 = input.ReadBytes();
				break;
			case 18u:
				Item2 = input.ReadBytes();
				break;
			}
		}
	}
}
