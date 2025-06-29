using System;
using Google.Protobuf;

namespace OssB1;

public sealed class PlayTypeTupleWrapper : IMessage<PlayTypeTupleWrapper>, IMessage, IEquatable<PlayTypeTupleWrapper>, IDeepCloneable<PlayTypeTupleWrapper>
{
	private static readonly MessageParser<PlayTypeTupleWrapper> _parser = new MessageParser<PlayTypeTupleWrapper>(() => new PlayTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private PlayType item1_;

	private PlayType item2_;

	public static MessageParser<PlayTypeTupleWrapper> Parser => _parser;

	public PlayType Item1
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

	public PlayType Item2
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

	public PlayTypeTupleWrapper()
	{
	}

	public PlayTypeTupleWrapper(PlayTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayTypeTupleWrapper Clone()
	{
		return new PlayTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayTypeTupleWrapper);
	}

	public bool Equals(PlayTypeTupleWrapper other)
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
		if (Item1 != PlayType.Single)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != PlayType.Single)
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
		if (Item1 != PlayType.Single)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != PlayType.Single)
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
		if (Item1 != PlayType.Single)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != PlayType.Single)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != PlayType.Single)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != PlayType.Single)
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
				Item1 = (PlayType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (PlayType)input.ReadEnum();
				break;
			}
		}
	}
}
