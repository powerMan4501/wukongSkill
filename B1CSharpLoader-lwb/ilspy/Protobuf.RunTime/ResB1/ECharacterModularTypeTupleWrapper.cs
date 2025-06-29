using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ECharacterModularTypeTupleWrapper : IMessage<ECharacterModularTypeTupleWrapper>, IMessage, IEquatable<ECharacterModularTypeTupleWrapper>, IDeepCloneable<ECharacterModularTypeTupleWrapper>
{
	private static readonly MessageParser<ECharacterModularTypeTupleWrapper> _parser = new MessageParser<ECharacterModularTypeTupleWrapper>(() => new ECharacterModularTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ECharacterModularType item1_;

	private ECharacterModularType item2_;

	public static MessageParser<ECharacterModularTypeTupleWrapper> Parser => _parser;

	public ECharacterModularType Item1
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

	public ECharacterModularType Item2
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

	public ECharacterModularTypeTupleWrapper()
	{
	}

	public ECharacterModularTypeTupleWrapper(ECharacterModularTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ECharacterModularTypeTupleWrapper Clone()
	{
		return new ECharacterModularTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ECharacterModularTypeTupleWrapper);
	}

	public bool Equals(ECharacterModularTypeTupleWrapper other)
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
		if (Item1 != ECharacterModularType.MasterPose)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ECharacterModularType.MasterPose)
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
		if (Item1 != ECharacterModularType.MasterPose)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ECharacterModularType.MasterPose)
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
		if (Item1 != ECharacterModularType.MasterPose)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ECharacterModularType.MasterPose)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ECharacterModularTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ECharacterModularType.MasterPose)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ECharacterModularType.MasterPose)
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
				Item1 = (ECharacterModularType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ECharacterModularType)input.ReadEnum();
				break;
			}
		}
	}
}
