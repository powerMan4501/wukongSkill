using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class FTestPersistence : IMessage<FTestPersistence>, IMessage, IEquatable<FTestPersistence>, IDeepCloneable<FTestPersistence>
{
	private static readonly MessageParser<FTestPersistence> _parser = new MessageParser<FTestPersistence>(() => new FTestPersistence());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int testInt_;

	public static MessageParser<FTestPersistence> Parser => _parser;

	public int TestInt
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return testInt_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			testInt_ = value;
		}
	}

	public bool HasTestInt => (_hasBits0 & 1) != 0;

	public FTestPersistence()
	{
	}

	public FTestPersistence(FTestPersistence other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		testInt_ = other.testInt_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FTestPersistence Clone()
	{
		return new FTestPersistence(this);
	}

	public void ClearTestInt()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as FTestPersistence);
	}

	public bool Equals(FTestPersistence other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TestInt != other.TestInt)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasTestInt)
		{
			num ^= TestInt.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasTestInt)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TestInt);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasTestInt)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TestInt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FTestPersistence other)
	{
		if (other != null)
		{
			if (other.HasTestInt)
			{
				TestInt = other.TestInt;
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
				TestInt = input.ReadInt32();
			}
		}
	}
}
