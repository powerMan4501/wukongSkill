using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class PlayerStateTestData : IMessage<PlayerStateTestData>, IMessage, IEquatable<PlayerStateTestData>, IDeepCloneable<PlayerStateTestData>
{
	private static readonly MessageParser<PlayerStateTestData> _parser = new MessageParser<PlayerStateTestData>(() => new PlayerStateTestData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int testID_;

	private static readonly FieldCodec<ListDeltaMsgPlayerTransactionBase> _repeated_activeTransactions_codec = FieldCodec.ForMessage(18u, ListDeltaMsgPlayerTransactionBase.Parser);

	private readonly RepeatedField<ListDeltaMsgPlayerTransactionBase> activeTransactions_ = new RepeatedField<ListDeltaMsgPlayerTransactionBase>();

	public static MessageParser<PlayerStateTestData> Parser => _parser;

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

	public RepeatedField<ListDeltaMsgPlayerTransactionBase> ActiveTransactions => activeTransactions_;

	public PlayerStateTestData()
	{
	}

	public PlayerStateTestData(PlayerStateTestData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		testID_ = other.testID_;
		activeTransactions_ = other.activeTransactions_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerStateTestData Clone()
	{
		return new PlayerStateTestData(this);
	}

	public void ClearTestID()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerStateTestData);
	}

	public bool Equals(PlayerStateTestData other)
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
		if (!activeTransactions_.Equals(other.activeTransactions_))
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
		num ^= activeTransactions_.GetHashCode();
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
		activeTransactions_.WriteTo(output, _repeated_activeTransactions_codec);
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
		num += activeTransactions_.CalculateSize(_repeated_activeTransactions_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerStateTestData other)
	{
		if (other != null)
		{
			if (other.HasTestID)
			{
				TestID = other.TestID;
			}
			activeTransactions_.Add(other.activeTransactions_);
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
				activeTransactions_.AddEntriesFrom(input, _repeated_activeTransactions_codec);
				break;
			}
		}
	}
}
