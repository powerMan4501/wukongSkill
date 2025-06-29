using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EUIConfigTabTupleWrapper : IMessage<EUIConfigTabTupleWrapper>, IMessage, IEquatable<EUIConfigTabTupleWrapper>, IDeepCloneable<EUIConfigTabTupleWrapper>
{
	private static readonly MessageParser<EUIConfigTabTupleWrapper> _parser = new MessageParser<EUIConfigTabTupleWrapper>(() => new EUIConfigTabTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EUIConfigTab item1_;

	private EUIConfigTab item2_;

	public static MessageParser<EUIConfigTabTupleWrapper> Parser => _parser;

	public EUIConfigTab Item1
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

	public EUIConfigTab Item2
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

	public EUIConfigTabTupleWrapper()
	{
	}

	public EUIConfigTabTupleWrapper(EUIConfigTabTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EUIConfigTabTupleWrapper Clone()
	{
		return new EUIConfigTabTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EUIConfigTabTupleWrapper);
	}

	public bool Equals(EUIConfigTabTupleWrapper other)
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
		if (Item1 != EUIConfigTab.Gamepad)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EUIConfigTab.Gamepad)
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
		if (Item1 != EUIConfigTab.Gamepad)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EUIConfigTab.Gamepad)
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
		if (Item1 != EUIConfigTab.Gamepad)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EUIConfigTab.Gamepad)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EUIConfigTabTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EUIConfigTab.Gamepad)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EUIConfigTab.Gamepad)
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
				Item1 = (EUIConfigTab)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EUIConfigTab)input.ReadEnum();
				break;
			}
		}
	}
}
