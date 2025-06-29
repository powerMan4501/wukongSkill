using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BGC_GameStateTestData : IMessage<BGC_GameStateTestData>, IMessage, IEquatable<BGC_GameStateTestData>, IDeepCloneable<BGC_GameStateTestData>
{
	private static readonly MessageParser<BGC_GameStateTestData> _parser = new MessageParser<BGC_GameStateTestData>(() => new BGC_GameStateTestData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private static readonly FieldCodec<ListDeltaMsgInt> _repeated_testIDList_codec = FieldCodec.ForMessage(10u, ListDeltaMsgInt.Parser);

	private readonly RepeatedField<ListDeltaMsgInt> testIDList_ = new RepeatedField<ListDeltaMsgInt>();

	private static readonly FieldCodec<DictDeltaMsgEPropType_UInt> _repeated_testPropIDDict_codec = FieldCodec.ForMessage(18u, DictDeltaMsgEPropType_UInt.Parser);

	private readonly RepeatedField<DictDeltaMsgEPropType_UInt> testPropIDDict_ = new RepeatedField<DictDeltaMsgEPropType_UInt>();

	private static readonly FieldCodec<ListDeltaMsgFRepInnerClass> _repeated_testInnerClassList_codec = FieldCodec.ForMessage(26u, ListDeltaMsgFRepInnerClass.Parser);

	private readonly RepeatedField<ListDeltaMsgFRepInnerClass> testInnerClassList_ = new RepeatedField<ListDeltaMsgFRepInnerClass>();

	private int testID_;

	public static MessageParser<BGC_GameStateTestData> Parser => _parser;

	public RepeatedField<ListDeltaMsgInt> TestIDList => testIDList_;

	public RepeatedField<DictDeltaMsgEPropType_UInt> TestPropIDDict => testPropIDDict_;

	public RepeatedField<ListDeltaMsgFRepInnerClass> TestInnerClassList => testInnerClassList_;

	public int TestID
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return testID_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			testID_ = value;
		}
	}

	public bool HasTestID => (_hasBits0 & 1) != 0;

	public BGC_GameStateTestData()
	{
	}

	public BGC_GameStateTestData(BGC_GameStateTestData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		testIDList_ = other.testIDList_.Clone();
		testPropIDDict_ = other.testPropIDDict_.Clone();
		testInnerClassList_ = other.testInnerClassList_.Clone();
		testID_ = other.testID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BGC_GameStateTestData Clone()
	{
		return new BGC_GameStateTestData(this);
	}

	public void ClearTestID()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BGC_GameStateTestData);
	}

	public bool Equals(BGC_GameStateTestData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!testIDList_.Equals(other.testIDList_))
		{
			return false;
		}
		if (!testPropIDDict_.Equals(other.testPropIDDict_))
		{
			return false;
		}
		if (!testInnerClassList_.Equals(other.testInnerClassList_))
		{
			return false;
		}
		if (TestID != other.TestID)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= testIDList_.GetHashCode();
		num ^= testPropIDDict_.GetHashCode();
		num ^= testInnerClassList_.GetHashCode();
		if (HasTestID)
		{
			num ^= TestID.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		testIDList_.WriteTo(output, _repeated_testIDList_codec);
		testPropIDDict_.WriteTo(output, _repeated_testPropIDDict_codec);
		testInnerClassList_.WriteTo(output, _repeated_testInnerClassList_codec);
		if (HasTestID)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TestID);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += testIDList_.CalculateSize(_repeated_testIDList_codec);
		num += testPropIDDict_.CalculateSize(_repeated_testPropIDDict_codec);
		num += testInnerClassList_.CalculateSize(_repeated_testInnerClassList_codec);
		if (HasTestID)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TestID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BGC_GameStateTestData other)
	{
		if (other != null)
		{
			testIDList_.Add(other.testIDList_);
			testPropIDDict_.Add(other.testPropIDDict_);
			testInnerClassList_.Add(other.testInnerClassList_);
			if (other.HasTestID)
			{
				TestID = other.TestID;
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
			case 10u:
				testIDList_.AddEntriesFrom(input, _repeated_testIDList_codec);
				break;
			case 18u:
				testPropIDDict_.AddEntriesFrom(input, _repeated_testPropIDDict_codec);
				break;
			case 26u:
				testInnerClassList_.AddEntriesFrom(input, _repeated_testInnerClassList_codec);
				break;
			case 32u:
				TestID = input.ReadInt32();
				break;
			}
		}
	}
}
