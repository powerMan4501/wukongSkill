using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EHitDestructibleDirTypeTupleWrapper : IMessage<EHitDestructibleDirTypeTupleWrapper>, IMessage, IEquatable<EHitDestructibleDirTypeTupleWrapper>, IDeepCloneable<EHitDestructibleDirTypeTupleWrapper>
{
	private static readonly MessageParser<EHitDestructibleDirTypeTupleWrapper> _parser = new MessageParser<EHitDestructibleDirTypeTupleWrapper>(() => new EHitDestructibleDirTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EHitDestructibleDirType item1_;

	private EHitDestructibleDirType item2_;

	public static MessageParser<EHitDestructibleDirTypeTupleWrapper> Parser => _parser;

	public EHitDestructibleDirType Item1
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

	public EHitDestructibleDirType Item2
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

	public EHitDestructibleDirTypeTupleWrapper()
	{
	}

	public EHitDestructibleDirTypeTupleWrapper(EHitDestructibleDirTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EHitDestructibleDirTypeTupleWrapper Clone()
	{
		return new EHitDestructibleDirTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EHitDestructibleDirTypeTupleWrapper);
	}

	public bool Equals(EHitDestructibleDirTypeTupleWrapper other)
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
		if (Item1 != EHitDestructibleDirType.DestructibleDirection)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EHitDestructibleDirType.DestructibleDirection)
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
		if (Item1 != EHitDestructibleDirType.DestructibleDirection)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EHitDestructibleDirType.DestructibleDirection)
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
		if (Item1 != EHitDestructibleDirType.DestructibleDirection)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EHitDestructibleDirType.DestructibleDirection)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EHitDestructibleDirTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EHitDestructibleDirType.DestructibleDirection)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EHitDestructibleDirType.DestructibleDirection)
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
				Item1 = (EHitDestructibleDirType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EHitDestructibleDirType)input.ReadEnum();
				break;
			}
		}
	}
}
