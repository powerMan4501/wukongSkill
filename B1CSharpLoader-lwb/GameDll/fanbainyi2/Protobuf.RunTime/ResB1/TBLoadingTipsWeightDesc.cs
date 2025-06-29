using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBLoadingTipsWeightDesc : IMessage<TBLoadingTipsWeightDesc>, IMessage, IEquatable<TBLoadingTipsWeightDesc>, IDeepCloneable<TBLoadingTipsWeightDesc>
{
	private static readonly MessageParser<TBLoadingTipsWeightDesc> _parser = new MessageParser<TBLoadingTipsWeightDesc>(() => new TBLoadingTipsWeightDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<LoadingTipsWeightDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, LoadingTipsWeightDesc.Parser);

	private readonly RepeatedField<LoadingTipsWeightDesc> list_ = new RepeatedField<LoadingTipsWeightDesc>();

	public static MessageParser<TBLoadingTipsWeightDesc> Parser => _parser;

	public RepeatedField<LoadingTipsWeightDesc> List => list_;

	public TBLoadingTipsWeightDesc()
	{
	}

	public TBLoadingTipsWeightDesc(TBLoadingTipsWeightDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBLoadingTipsWeightDesc Clone()
	{
		return new TBLoadingTipsWeightDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBLoadingTipsWeightDesc);
	}

	public bool Equals(TBLoadingTipsWeightDesc other)
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

	public void MergeFrom(TBLoadingTipsWeightDesc other)
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
