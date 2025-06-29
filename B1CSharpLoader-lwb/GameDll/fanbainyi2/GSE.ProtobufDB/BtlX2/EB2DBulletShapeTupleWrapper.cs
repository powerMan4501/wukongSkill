using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class EB2DBulletShapeTupleWrapper : IMessage<EB2DBulletShapeTupleWrapper>, IMessage, IEquatable<EB2DBulletShapeTupleWrapper>, IDeepCloneable<EB2DBulletShapeTupleWrapper>
{
	private static readonly MessageParser<EB2DBulletShapeTupleWrapper> _parser = new MessageParser<EB2DBulletShapeTupleWrapper>(() => new EB2DBulletShapeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EB2DBulletShape item1_;

	private EB2DBulletShape item2_;

	public static MessageParser<EB2DBulletShapeTupleWrapper> Parser => _parser;

	public EB2DBulletShape Item1
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

	public EB2DBulletShape Item2
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

	public EB2DBulletShapeTupleWrapper()
	{
	}

	public EB2DBulletShapeTupleWrapper(EB2DBulletShapeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EB2DBulletShapeTupleWrapper Clone()
	{
		return new EB2DBulletShapeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EB2DBulletShapeTupleWrapper);
	}

	public bool Equals(EB2DBulletShapeTupleWrapper other)
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
		if (Item1 != EB2DBulletShape.Circle)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EB2DBulletShape.Circle)
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
		if (Item1 != EB2DBulletShape.Circle)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EB2DBulletShape.Circle)
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
		if (Item1 != EB2DBulletShape.Circle)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EB2DBulletShape.Circle)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EB2DBulletShapeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EB2DBulletShape.Circle)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EB2DBulletShape.Circle)
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
				Item1 = (EB2DBulletShape)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EB2DBulletShape)input.ReadEnum();
				break;
			}
		}
	}
}
