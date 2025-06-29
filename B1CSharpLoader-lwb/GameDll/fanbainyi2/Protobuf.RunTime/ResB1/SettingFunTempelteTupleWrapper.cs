using System;
using Google.Protobuf;

namespace ResB1;

public sealed class SettingFunTempelteTupleWrapper : IMessage<SettingFunTempelteTupleWrapper>, IMessage, IEquatable<SettingFunTempelteTupleWrapper>, IDeepCloneable<SettingFunTempelteTupleWrapper>
{
	private static readonly MessageParser<SettingFunTempelteTupleWrapper> _parser = new MessageParser<SettingFunTempelteTupleWrapper>(() => new SettingFunTempelteTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private SettingFunTempelte item1_;

	private SettingFunTempelte item2_;

	public static MessageParser<SettingFunTempelteTupleWrapper> Parser => _parser;

	public SettingFunTempelte Item1
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

	public SettingFunTempelte Item2
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

	public SettingFunTempelteTupleWrapper()
	{
	}

	public SettingFunTempelteTupleWrapper(SettingFunTempelteTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SettingFunTempelteTupleWrapper Clone()
	{
		return new SettingFunTempelteTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SettingFunTempelteTupleWrapper);
	}

	public bool Equals(SettingFunTempelteTupleWrapper other)
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
		if (Item1 != SettingFunTempelte.ConsoleVariable)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != SettingFunTempelte.ConsoleVariable)
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
		if (Item1 != SettingFunTempelte.ConsoleVariable)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != SettingFunTempelte.ConsoleVariable)
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
		if (Item1 != SettingFunTempelte.ConsoleVariable)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != SettingFunTempelte.ConsoleVariable)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SettingFunTempelteTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != SettingFunTempelte.ConsoleVariable)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != SettingFunTempelte.ConsoleVariable)
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
				Item1 = (SettingFunTempelte)input.ReadEnum();
				break;
			case 16u:
				Item2 = (SettingFunTempelte)input.ReadEnum();
				break;
			}
		}
	}
}
