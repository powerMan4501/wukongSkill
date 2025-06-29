using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBMantraDesc : IMessage<TBMantraDesc>, IMessage, IEquatable<TBMantraDesc>, IDeepCloneable<TBMantraDesc>
{
	private static readonly MessageParser<TBMantraDesc> _parser = new MessageParser<TBMantraDesc>(() => new TBMantraDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<MantraDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, MantraDesc.Parser);

	private readonly RepeatedField<MantraDesc> list_ = new RepeatedField<MantraDesc>();

	public static MessageParser<TBMantraDesc> Parser => _parser;

	public RepeatedField<MantraDesc> List => list_;

	public TBMantraDesc()
	{
	}

	public TBMantraDesc(TBMantraDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBMantraDesc Clone()
	{
		return new TBMantraDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBMantraDesc);
	}

	public bool Equals(TBMantraDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!list_.Equals(other.list_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= list_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		list_.WriteTo(output, _repeated_list_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += list_.CalculateSize(_repeated_list_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TBMantraDesc other)
	{
		if (other != null)
		{
			list_.Add(other.list_);
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
				list_.AddEntriesFrom(input, _repeated_list_codec);
			}
		}
	}
}
