using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class GameStateTestData : IMessage<GameStateTestData>, IMessage, IEquatable<GameStateTestData>, IDeepCloneable<GameStateTestData>
{
	private static readonly MessageParser<GameStateTestData> _parser = new MessageParser<GameStateTestData>(() => new GameStateTestData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int testID_;

	private static readonly FieldCodec<ListDeltaMsgInt> _repeated_testArr_codec = FieldCodec.ForMessage(18u, ListDeltaMsgInt.Parser);

	private readonly RepeatedField<ListDeltaMsgInt> testArr_ = new RepeatedField<ListDeltaMsgInt>();

	public static MessageParser<GameStateTestData> Parser => _parser;

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

	public RepeatedField<ListDeltaMsgInt> TestArr => testArr_;

	public GameStateTestData()
	{
	}

	public GameStateTestData(GameStateTestData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		testID_ = other.testID_;
		testArr_ = other.testArr_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GameStateTestData Clone()
	{
		return new GameStateTestData(this);
	}

	public void ClearTestID()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as GameStateTestData);
	}

	public bool Equals(GameStateTestData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TestID != other.TestID)
		{
			return false;
		}
		if (!testArr_.Equals(other.testArr_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasTestID)
		{
			num ^= TestID.GetHashCode();
		}
		num ^= testArr_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasTestID)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TestID);
		}
		testArr_.WriteTo(output, _repeated_testArr_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasTestID)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TestID);
		}
		num += testArr_.CalculateSize(_repeated_testArr_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GameStateTestData other)
	{
		if (other != null)
		{
			if (other.HasTestID)
			{
				TestID = other.TestID;
			}
			testArr_.Add(other.testArr_);
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
				TestID = input.ReadInt32();
				break;
			case 18u:
				testArr_.AddEntriesFrom(input, _repeated_testArr_codec);
				break;
			}
		}
	}
}
