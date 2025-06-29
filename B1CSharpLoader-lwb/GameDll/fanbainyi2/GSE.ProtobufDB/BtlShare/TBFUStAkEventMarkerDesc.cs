using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStAkEventMarkerDesc : IMessage<TBFUStAkEventMarkerDesc>, IMessage, IEquatable<TBFUStAkEventMarkerDesc>, IDeepCloneable<TBFUStAkEventMarkerDesc>
{
	private static readonly MessageParser<TBFUStAkEventMarkerDesc> _parser = new MessageParser<TBFUStAkEventMarkerDesc>(() => new TBFUStAkEventMarkerDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStAkEventMarkerDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStAkEventMarkerDesc.Parser);

	private readonly RepeatedField<FUStAkEventMarkerDesc> list_ = new RepeatedField<FUStAkEventMarkerDesc>();

	public static MessageParser<TBFUStAkEventMarkerDesc> Parser => _parser;

	public RepeatedField<FUStAkEventMarkerDesc> List => list_;

	public TBFUStAkEventMarkerDesc()
	{
	}

	public TBFUStAkEventMarkerDesc(TBFUStAkEventMarkerDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStAkEventMarkerDesc Clone()
	{
		return new TBFUStAkEventMarkerDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStAkEventMarkerDesc);
	}

	public bool Equals(TBFUStAkEventMarkerDesc other)
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

	public void MergeFrom(TBFUStAkEventMarkerDesc other)
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
