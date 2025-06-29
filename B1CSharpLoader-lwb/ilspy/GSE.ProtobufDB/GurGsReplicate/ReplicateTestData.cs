using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class ReplicateTestData : IMessage<ReplicateTestData>, IMessage, IEquatable<ReplicateTestData>, IDeepCloneable<ReplicateTestData>
{
	private static readonly MessageParser<ReplicateTestData> _parser = new MessageParser<ReplicateTestData>(() => new ReplicateTestData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int testInt_;

	private static readonly FieldCodec<ClassDeltaMsgFRepTestClass> _repeated_testClass_codec = FieldCodec.ForMessage(18u, ClassDeltaMsgFRepTestClass.Parser);

	private readonly RepeatedField<ClassDeltaMsgFRepTestClass> testClass_ = new RepeatedField<ClassDeltaMsgFRepTestClass>();

	private static readonly FieldCodec<ListDeltaMsgInt> _repeated_intArr_codec = FieldCodec.ForMessage(26u, ListDeltaMsgInt.Parser);

	private readonly RepeatedField<ListDeltaMsgInt> intArr_ = new RepeatedField<ListDeltaMsgInt>();

	private static readonly FieldCodec<ListDeltaMsgFRepInnerClass> _repeated_innerClassList_codec = FieldCodec.ForMessage(34u, ListDeltaMsgFRepInnerClass.Parser);

	private readonly RepeatedField<ListDeltaMsgFRepInnerClass> innerClassList_ = new RepeatedField<ListDeltaMsgFRepInnerClass>();

	public static MessageParser<ReplicateTestData> Parser => _parser;

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

	public RepeatedField<ClassDeltaMsgFRepTestClass> TestClass => testClass_;

	public RepeatedField<ListDeltaMsgInt> IntArr => intArr_;

	public RepeatedField<ListDeltaMsgFRepInnerClass> InnerClassList => innerClassList_;

	public ReplicateTestData()
	{
	}

	public ReplicateTestData(ReplicateTestData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		testInt_ = other.testInt_;
		testClass_ = other.testClass_.Clone();
		intArr_ = other.intArr_.Clone();
		innerClassList_ = other.innerClassList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReplicateTestData Clone()
	{
		return new ReplicateTestData(this);
	}

	public void ClearTestInt()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReplicateTestData);
	}

	public bool Equals(ReplicateTestData other)
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
		if (!testClass_.Equals(other.testClass_))
		{
			return false;
		}
		if (!intArr_.Equals(other.intArr_))
		{
			return false;
		}
		if (!innerClassList_.Equals(other.innerClassList_))
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
		num ^= testClass_.GetHashCode();
		num ^= intArr_.GetHashCode();
		num ^= innerClassList_.GetHashCode();
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
		testClass_.WriteTo(output, _repeated_testClass_codec);
		intArr_.WriteTo(output, _repeated_intArr_codec);
		innerClassList_.WriteTo(output, _repeated_innerClassList_codec);
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
		num += testClass_.CalculateSize(_repeated_testClass_codec);
		num += intArr_.CalculateSize(_repeated_intArr_codec);
		num += innerClassList_.CalculateSize(_repeated_innerClassList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReplicateTestData other)
	{
		if (other != null)
		{
			if (other.HasTestInt)
			{
				TestInt = other.TestInt;
			}
			testClass_.Add(other.testClass_);
			intArr_.Add(other.intArr_);
			innerClassList_.Add(other.innerClassList_);
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
				TestInt = input.ReadInt32();
				break;
			case 18u:
				testClass_.AddEntriesFrom(input, _repeated_testClass_codec);
				break;
			case 26u:
				intArr_.AddEntriesFrom(input, _repeated_intArr_codec);
				break;
			case 34u:
				innerClassList_.AddEntriesFrom(input, _repeated_innerClassList_codec);
				break;
			}
		}
	}
}
