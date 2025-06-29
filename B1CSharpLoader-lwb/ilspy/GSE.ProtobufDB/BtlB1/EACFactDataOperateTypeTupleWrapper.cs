using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EACFactDataOperateTypeTupleWrapper : IMessage<EACFactDataOperateTypeTupleWrapper>, IMessage, IEquatable<EACFactDataOperateTypeTupleWrapper>, IDeepCloneable<EACFactDataOperateTypeTupleWrapper>
{
	private static readonly MessageParser<EACFactDataOperateTypeTupleWrapper> _parser = new MessageParser<EACFactDataOperateTypeTupleWrapper>(() => new EACFactDataOperateTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EACFactDataOperateType item1_;

	private EACFactDataOperateType item2_;

	public static MessageParser<EACFactDataOperateTypeTupleWrapper> Parser => _parser;

	public EACFactDataOperateType Item1
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

	public EACFactDataOperateType Item2
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

	public EACFactDataOperateTypeTupleWrapper()
	{
	}

	public EACFactDataOperateTypeTupleWrapper(EACFactDataOperateTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EACFactDataOperateTypeTupleWrapper Clone()
	{
		return new EACFactDataOperateTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EACFactDataOperateTypeTupleWrapper);
	}

	public bool Equals(EACFactDataOperateTypeTupleWrapper other)
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
		if (Item1 != EACFactDataOperateType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EACFactDataOperateType.None)
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
		if (Item1 != EACFactDataOperateType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EACFactDataOperateType.None)
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
		if (Item1 != EACFactDataOperateType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EACFactDataOperateType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EACFactDataOperateTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EACFactDataOperateType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EACFactDataOperateType.None)
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
				Item1 = (EACFactDataOperateType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EACFactDataOperateType)input.ReadEnum();
				break;
			}
		}
	}
}
