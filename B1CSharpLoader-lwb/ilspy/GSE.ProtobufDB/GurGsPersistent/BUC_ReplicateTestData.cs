using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BUC_ReplicateTestData : IMessage<BUC_ReplicateTestData>, IMessage, IEquatable<BUC_ReplicateTestData>, IDeepCloneable<BUC_ReplicateTestData>
{
	private static readonly MessageParser<BUC_ReplicateTestData> _parser = new MessageParser<BUC_ReplicateTestData>(() => new BUC_ReplicateTestData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<DictDeltaMsgString_Int> _repeated_persistentTestRemoved_codec = FieldCodec.ForMessage(10u, DictDeltaMsgString_Int.Parser);

	private readonly RepeatedField<DictDeltaMsgString_Int> persistentTestRemoved_ = new RepeatedField<DictDeltaMsgString_Int>();

	public static MessageParser<BUC_ReplicateTestData> Parser => _parser;

	public RepeatedField<DictDeltaMsgString_Int> PersistentTestRemoved => persistentTestRemoved_;

	public BUC_ReplicateTestData()
	{
	}

	public BUC_ReplicateTestData(BUC_ReplicateTestData other)
		: this()
	{
		persistentTestRemoved_ = other.persistentTestRemoved_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BUC_ReplicateTestData Clone()
	{
		return new BUC_ReplicateTestData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BUC_ReplicateTestData);
	}

	public bool Equals(BUC_ReplicateTestData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!persistentTestRemoved_.Equals(other.persistentTestRemoved_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= persistentTestRemoved_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		persistentTestRemoved_.WriteTo(output, _repeated_persistentTestRemoved_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += persistentTestRemoved_.CalculateSize(_repeated_persistentTestRemoved_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BUC_ReplicateTestData other)
	{
		if (other != null)
		{
			persistentTestRemoved_.Add(other.persistentTestRemoved_);
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
				persistentTestRemoved_.AddEntriesFrom(input, _repeated_persistentTestRemoved_codec);
			}
		}
	}
}
