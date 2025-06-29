using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ESettingExitTypeTupleWrapper : IMessage<ESettingExitTypeTupleWrapper>, IMessage, IEquatable<ESettingExitTypeTupleWrapper>, IDeepCloneable<ESettingExitTypeTupleWrapper>
{
	private static readonly MessageParser<ESettingExitTypeTupleWrapper> _parser = new MessageParser<ESettingExitTypeTupleWrapper>(() => new ESettingExitTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESettingExitType item1_;

	private ESettingExitType item2_;

	public static MessageParser<ESettingExitTypeTupleWrapper> Parser => _parser;

	public ESettingExitType Item1
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

	public ESettingExitType Item2
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

	public ESettingExitTypeTupleWrapper()
	{
	}

	public ESettingExitTypeTupleWrapper(ESettingExitTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESettingExitTypeTupleWrapper Clone()
	{
		return new ESettingExitTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESettingExitTypeTupleWrapper);
	}

	public bool Equals(ESettingExitTypeTupleWrapper other)
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
		if (Item1 != ESettingExitType.BackToMainMeum)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESettingExitType.BackToMainMeum)
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
		if (Item1 != ESettingExitType.BackToMainMeum)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESettingExitType.BackToMainMeum)
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
		if (Item1 != ESettingExitType.BackToMainMeum)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESettingExitType.BackToMainMeum)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESettingExitTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESettingExitType.BackToMainMeum)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESettingExitType.BackToMainMeum)
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
				Item1 = (ESettingExitType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESettingExitType)input.ReadEnum();
				break;
			}
		}
	}
}
