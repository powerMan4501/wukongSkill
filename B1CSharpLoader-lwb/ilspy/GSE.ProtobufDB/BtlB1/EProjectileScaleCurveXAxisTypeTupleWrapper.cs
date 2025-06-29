using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EProjectileScaleCurveXAxisTypeTupleWrapper : IMessage<EProjectileScaleCurveXAxisTypeTupleWrapper>, IMessage, IEquatable<EProjectileScaleCurveXAxisTypeTupleWrapper>, IDeepCloneable<EProjectileScaleCurveXAxisTypeTupleWrapper>
{
	private static readonly MessageParser<EProjectileScaleCurveXAxisTypeTupleWrapper> _parser = new MessageParser<EProjectileScaleCurveXAxisTypeTupleWrapper>(() => new EProjectileScaleCurveXAxisTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EProjectileScaleCurveXAxisType item1_;

	private EProjectileScaleCurveXAxisType item2_;

	public static MessageParser<EProjectileScaleCurveXAxisTypeTupleWrapper> Parser => _parser;

	public EProjectileScaleCurveXAxisType Item1
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

	public EProjectileScaleCurveXAxisType Item2
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

	public EProjectileScaleCurveXAxisTypeTupleWrapper()
	{
	}

	public EProjectileScaleCurveXAxisTypeTupleWrapper(EProjectileScaleCurveXAxisTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EProjectileScaleCurveXAxisTypeTupleWrapper Clone()
	{
		return new EProjectileScaleCurveXAxisTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EProjectileScaleCurveXAxisTypeTupleWrapper);
	}

	public bool Equals(EProjectileScaleCurveXAxisTypeTupleWrapper other)
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
		if (Item1 != EProjectileScaleCurveXAxisType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EProjectileScaleCurveXAxisType.None)
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
		if (Item1 != EProjectileScaleCurveXAxisType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EProjectileScaleCurveXAxisType.None)
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
		if (Item1 != EProjectileScaleCurveXAxisType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EProjectileScaleCurveXAxisType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EProjectileScaleCurveXAxisTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EProjectileScaleCurveXAxisType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EProjectileScaleCurveXAxisType.None)
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
				Item1 = (EProjectileScaleCurveXAxisType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EProjectileScaleCurveXAxisType)input.ReadEnum();
				break;
			}
		}
	}
}
