using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStGuideGroupDesc : IMessage<TBFUStGuideGroupDesc>, IMessage, IEquatable<TBFUStGuideGroupDesc>, IDeepCloneable<TBFUStGuideGroupDesc>
{
	private static readonly MessageParser<TBFUStGuideGroupDesc> _parser = new MessageParser<TBFUStGuideGroupDesc>(() => new TBFUStGuideGroupDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStGuideGroupDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStGuideGroupDesc.Parser);

	private readonly RepeatedField<FUStGuideGroupDesc> list_ = new RepeatedField<FUStGuideGroupDesc>();

	public static MessageParser<TBFUStGuideGroupDesc> Parser => _parser;

	public RepeatedField<FUStGuideGroupDesc> List => list_;

	public TBFUStGuideGroupDesc()
	{
	}

	public TBFUStGuideGroupDesc(TBFUStGuideGroupDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStGuideGroupDesc Clone()
	{
		return new TBFUStGuideGroupDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStGuideGroupDesc);
	}

	public bool Equals(TBFUStGuideGroupDesc other)
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

	public void MergeFrom(TBFUStGuideGroupDesc other)
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
