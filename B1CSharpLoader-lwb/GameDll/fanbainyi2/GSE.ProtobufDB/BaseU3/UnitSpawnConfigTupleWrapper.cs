using System;
using Google.Protobuf;

namespace BaseU3;

public sealed class UnitSpawnConfigTupleWrapper : IMessage<UnitSpawnConfigTupleWrapper>, IMessage, IEquatable<UnitSpawnConfigTupleWrapper>, IDeepCloneable<UnitSpawnConfigTupleWrapper>
{
	private static readonly MessageParser<UnitSpawnConfigTupleWrapper> _parser = new MessageParser<UnitSpawnConfigTupleWrapper>(() => new UnitSpawnConfigTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private UnitSpawnConfig item1_;

	private UnitSpawnConfig item2_;

	public static MessageParser<UnitSpawnConfigTupleWrapper> Parser => _parser;

	public UnitSpawnConfig Item1
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

	public UnitSpawnConfig Item2
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

	public UnitSpawnConfigTupleWrapper()
	{
	}

	public UnitSpawnConfigTupleWrapper(UnitSpawnConfigTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UnitSpawnConfigTupleWrapper Clone()
	{
		return new UnitSpawnConfigTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UnitSpawnConfigTupleWrapper);
	}

	public bool Equals(UnitSpawnConfigTupleWrapper other)
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
		if (Item1 != UnitSpawnConfig.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != UnitSpawnConfig.Default)
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
		if (Item1 != UnitSpawnConfig.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != UnitSpawnConfig.Default)
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
		if (Item1 != UnitSpawnConfig.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != UnitSpawnConfig.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UnitSpawnConfigTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != UnitSpawnConfig.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != UnitSpawnConfig.Default)
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
				Item1 = (UnitSpawnConfig)input.ReadEnum();
				break;
			case 16u:
				Item2 = (UnitSpawnConfig)input.ReadEnum();
				break;
			}
		}
	}
}
