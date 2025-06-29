using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStGuideNodeDesc : IMessage<TBFUStGuideNodeDesc>, IMessage, IEquatable<TBFUStGuideNodeDesc>, IDeepCloneable<TBFUStGuideNodeDesc>
{
	private static readonly MessageParser<TBFUStGuideNodeDesc> _parser = new MessageParser<TBFUStGuideNodeDesc>(() => new TBFUStGuideNodeDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStGuideNodeDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStGuideNodeDesc.Parser);

	private readonly RepeatedField<FUStGuideNodeDesc> list_ = new RepeatedField<FUStGuideNodeDesc>();

	public static MessageParser<TBFUStGuideNodeDesc> Parser => _parser;

	public RepeatedField<FUStGuideNodeDesc> List => list_;

	public TBFUStGuideNodeDesc()
	{
	}

	public TBFUStGuideNodeDesc(TBFUStGuideNodeDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStGuideNodeDesc Clone()
	{
		return new TBFUStGuideNodeDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStGuideNodeDesc);
	}

	public bool Equals(TBFUStGuideNodeDesc other)
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

	public void MergeFrom(TBFUStGuideNodeDesc other)
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
