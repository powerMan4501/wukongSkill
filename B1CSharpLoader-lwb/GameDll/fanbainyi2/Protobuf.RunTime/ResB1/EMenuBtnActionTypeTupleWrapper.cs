using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EMenuBtnActionTypeTupleWrapper : IMessage<EMenuBtnActionTypeTupleWrapper>, IMessage, IEquatable<EMenuBtnActionTypeTupleWrapper>, IDeepCloneable<EMenuBtnActionTypeTupleWrapper>
{
	private static readonly MessageParser<EMenuBtnActionTypeTupleWrapper> _parser = new MessageParser<EMenuBtnActionTypeTupleWrapper>(() => new EMenuBtnActionTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EMenuBtnActionType item1_;

	private EMenuBtnActionType item2_;

	public static MessageParser<EMenuBtnActionTypeTupleWrapper> Parser => _parser;

	public EMenuBtnActionType Item1
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

	public EMenuBtnActionType Item2
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

	public EMenuBtnActionTypeTupleWrapper()
	{
	}

	public EMenuBtnActionTypeTupleWrapper(EMenuBtnActionTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EMenuBtnActionTypeTupleWrapper Clone()
	{
		return new EMenuBtnActionTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EMenuBtnActionTypeTupleWrapper);
	}

	public bool Equals(EMenuBtnActionTypeTupleWrapper other)
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
		if (Item1 != EMenuBtnActionType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EMenuBtnActionType.None)
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
		if (Item1 != EMenuBtnActionType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EMenuBtnActionType.None)
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
		if (Item1 != EMenuBtnActionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EMenuBtnActionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EMenuBtnActionTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EMenuBtnActionType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EMenuBtnActionType.None)
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
				Item1 = (EMenuBtnActionType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EMenuBtnActionType)input.ReadEnum();
				break;
			}
		}
	}
}
