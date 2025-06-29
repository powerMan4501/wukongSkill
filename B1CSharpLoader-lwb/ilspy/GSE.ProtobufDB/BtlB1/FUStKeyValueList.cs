using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStKeyValueList : IMessage<FUStKeyValueList>, IMessage, IEquatable<FUStKeyValueList>, IDeepCloneable<FUStKeyValueList>
{
	private static readonly MessageParser<FUStKeyValueList> _parser = new MessageParser<FUStKeyValueList>(() => new FUStKeyValueList());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStKeyValue> _repeated_kvList_codec = FieldCodec.ForMessage(10u, FUStKeyValue.Parser);

	private readonly RepeatedField<FUStKeyValue> kvList_ = new RepeatedField<FUStKeyValue>();

	public static MessageParser<FUStKeyValueList> Parser => _parser;

	public RepeatedField<FUStKeyValue> KvList => kvList_;

	public FUStKeyValueList()
	{
	}

	public FUStKeyValueList(FUStKeyValueList other)
		: this()
	{
		kvList_ = other.kvList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStKeyValueList Clone()
	{
		return new FUStKeyValueList(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStKeyValueList);
	}

	public bool Equals(FUStKeyValueList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kvList_.Equals(other.kvList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= kvList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		kvList_.WriteTo(output, _repeated_kvList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += kvList_.CalculateSize(_repeated_kvList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStKeyValueList other)
	{
		if (other != null)
		{
			kvList_.Add(other.kvList_);
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
				kvList_.AddEntriesFrom(input, _repeated_kvList_codec);
			}
		}
	}
}
