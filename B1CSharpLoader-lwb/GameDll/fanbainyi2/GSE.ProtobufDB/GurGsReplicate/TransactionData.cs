using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class TransactionData : IMessage<TransactionData>, IMessage, IEquatable<TransactionData>, IDeepCloneable<TransactionData>
{
	private static readonly MessageParser<TransactionData> _parser = new MessageParser<TransactionData>(() => new TransactionData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ListDeltaMsgPlayerTransactionBase> _repeated_activeTransactions_codec = FieldCodec.ForMessage(10u, ListDeltaMsgPlayerTransactionBase.Parser);

	private readonly RepeatedField<ListDeltaMsgPlayerTransactionBase> activeTransactions_ = new RepeatedField<ListDeltaMsgPlayerTransactionBase>();

	public static MessageParser<TransactionData> Parser => _parser;

	public RepeatedField<ListDeltaMsgPlayerTransactionBase> ActiveTransactions => activeTransactions_;

	public TransactionData()
	{
	}

	public TransactionData(TransactionData other)
		: this()
	{
		activeTransactions_ = other.activeTransactions_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TransactionData Clone()
	{
		return new TransactionData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TransactionData);
	}

	public bool Equals(TransactionData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		num ^= activeTransactions_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		activeTransactions_.WriteTo(output, _repeated_activeTransactions_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += activeTransactions_.CalculateSize(_repeated_activeTransactions_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TransactionData other)
	{
		if (other != null)
		{
			activeTransactions_.Add(other.activeTransactions_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				activeTransactions_.AddEntriesFrom(input, _repeated_activeTransactions_codec);
			}
		}
	}
}
