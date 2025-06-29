using System;
using Google.Protobuf;

namespace ResB1;

public sealed class LoadingTipsTypeTupleWrapper : IMessage<LoadingTipsTypeTupleWrapper>, IMessage, IEquatable<LoadingTipsTypeTupleWrapper>, IDeepCloneable<LoadingTipsTypeTupleWrapper>
{
	private static readonly MessageParser<LoadingTipsTypeTupleWrapper> _parser = new MessageParser<LoadingTipsTypeTupleWrapper>(() => new LoadingTipsTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private LoadingTipsType item1_;

	private LoadingTipsType item2_;

	public static MessageParser<LoadingTipsTypeTupleWrapper> Parser => _parser;

	public LoadingTipsType Item1
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

	public LoadingTipsType Item2
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

	public LoadingTipsTypeTupleWrapper()
	{
	}

	public LoadingTipsTypeTupleWrapper(LoadingTipsTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LoadingTipsTypeTupleWrapper Clone()
	{
		return new LoadingTipsTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LoadingTipsTypeTupleWrapper);
	}

	public bool Equals(LoadingTipsTypeTupleWrapper other)
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
		if (Item1 != LoadingTipsType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != LoadingTipsType.None)
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
		if (Item1 != LoadingTipsType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != LoadingTipsType.None)
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
		if (Item1 != LoadingTipsType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != LoadingTipsType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LoadingTipsTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != LoadingTipsType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != LoadingTipsType.None)
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
				Item1 = (LoadingTipsType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (LoadingTipsType)input.ReadEnum();
				break;
			}
		}
	}
}
