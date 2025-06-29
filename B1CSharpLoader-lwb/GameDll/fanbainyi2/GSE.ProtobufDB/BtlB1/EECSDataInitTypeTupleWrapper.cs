using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EECSDataInitTypeTupleWrapper : IMessage<EECSDataInitTypeTupleWrapper>, IMessage, IEquatable<EECSDataInitTypeTupleWrapper>, IDeepCloneable<EECSDataInitTypeTupleWrapper>
{
	private static readonly MessageParser<EECSDataInitTypeTupleWrapper> _parser = new MessageParser<EECSDataInitTypeTupleWrapper>(() => new EECSDataInitTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EECSDataInitType item1_;

	private EECSDataInitType item2_;

	public static MessageParser<EECSDataInitTypeTupleWrapper> Parser => _parser;

	public EECSDataInitType Item1
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

	public EECSDataInitType Item2
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

	public EECSDataInitTypeTupleWrapper()
	{
	}

	public EECSDataInitTypeTupleWrapper(EECSDataInitTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EECSDataInitTypeTupleWrapper Clone()
	{
		return new EECSDataInitTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EECSDataInitTypeTupleWrapper);
	}

	public bool Equals(EECSDataInitTypeTupleWrapper other)
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
		if (Item1 != EECSDataInitType.PlayerAttr)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EECSDataInitType.PlayerAttr)
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
		if (Item1 != EECSDataInitType.PlayerAttr)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EECSDataInitType.PlayerAttr)
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
		if (Item1 != EECSDataInitType.PlayerAttr)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EECSDataInitType.PlayerAttr)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EECSDataInitTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EECSDataInitType.PlayerAttr)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EECSDataInitType.PlayerAttr)
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
				Item1 = (EECSDataInitType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EECSDataInitType)input.ReadEnum();
				break;
			}
		}
	}
}
