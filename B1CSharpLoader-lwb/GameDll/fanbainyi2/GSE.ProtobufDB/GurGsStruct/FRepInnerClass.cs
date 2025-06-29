using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class FRepInnerClass : IMessage<FRepInnerClass>, IMessage, IEquatable<FRepInnerClass>, IDeepCloneable<FRepInnerClass>
{
	private static readonly MessageParser<FRepInnerClass> _parser = new MessageParser<FRepInnerClass>(() => new FRepInnerClass());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int innerInt_;

	public static MessageParser<FRepInnerClass> Parser => _parser;

	public int InnerInt
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return innerInt_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			innerInt_ = value;
		}
	}

	public bool HasInnerInt => (_hasBits0 & 1) != 0;

	public FRepInnerClass()
	{
	}

	public FRepInnerClass(FRepInnerClass other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		innerInt_ = other.innerInt_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FRepInnerClass Clone()
	{
		return new FRepInnerClass(this);
	}

	public void ClearInnerInt()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as FRepInnerClass);
	}

	public bool Equals(FRepInnerClass other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InnerInt != other.InnerInt)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasInnerInt)
		{
			num ^= InnerInt.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasInnerInt)
		{
			output.WriteRawTag(8);
			output.WriteInt32(InnerInt);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasInnerInt)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InnerInt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FRepInnerClass other)
	{
		if (other != null)
		{
			if (other.HasInnerInt)
			{
				InnerInt = other.InnerInt;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				InnerInt = input.ReadInt32();
			}
		}
	}
}
