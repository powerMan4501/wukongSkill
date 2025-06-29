using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBMantraWeightDesc : IMessage<TBMantraWeightDesc>, IMessage, IEquatable<TBMantraWeightDesc>, IDeepCloneable<TBMantraWeightDesc>
{
	private static readonly MessageParser<TBMantraWeightDesc> _parser = new MessageParser<TBMantraWeightDesc>(() => new TBMantraWeightDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<MantraWeightDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, MantraWeightDesc.Parser);

	private readonly RepeatedField<MantraWeightDesc> list_ = new RepeatedField<MantraWeightDesc>();

	public static MessageParser<TBMantraWeightDesc> Parser => _parser;

	public RepeatedField<MantraWeightDesc> List => list_;

	public TBMantraWeightDesc()
	{
	}

	public TBMantraWeightDesc(TBMantraWeightDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBMantraWeightDesc Clone()
	{
		return new TBMantraWeightDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBMantraWeightDesc);
	}

	public bool Equals(TBMantraWeightDesc other)
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

	public void MergeFrom(TBMantraWeightDesc other)
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
