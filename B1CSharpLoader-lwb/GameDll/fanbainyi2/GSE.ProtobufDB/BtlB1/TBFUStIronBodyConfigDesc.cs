using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStIronBodyConfigDesc : IMessage<TBFUStIronBodyConfigDesc>, IMessage, IEquatable<TBFUStIronBodyConfigDesc>, IDeepCloneable<TBFUStIronBodyConfigDesc>
{
	private static readonly MessageParser<TBFUStIronBodyConfigDesc> _parser = new MessageParser<TBFUStIronBodyConfigDesc>(() => new TBFUStIronBodyConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStIronBodyConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStIronBodyConfigDesc.Parser);

	private readonly RepeatedField<FUStIronBodyConfigDesc> list_ = new RepeatedField<FUStIronBodyConfigDesc>();

	public static MessageParser<TBFUStIronBodyConfigDesc> Parser => _parser;

	public RepeatedField<FUStIronBodyConfigDesc> List => list_;

	public TBFUStIronBodyConfigDesc()
	{
	}

	public TBFUStIronBodyConfigDesc(TBFUStIronBodyConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStIronBodyConfigDesc Clone()
	{
		return new TBFUStIronBodyConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStIronBodyConfigDesc);
	}

	public bool Equals(TBFUStIronBodyConfigDesc other)
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

	public void MergeFrom(TBFUStIronBodyConfigDesc other)
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
