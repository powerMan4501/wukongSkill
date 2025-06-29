using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStAbnormalDispVictimMapDesc : IMessage<TBFUStAbnormalDispVictimMapDesc>, IMessage, IEquatable<TBFUStAbnormalDispVictimMapDesc>, IDeepCloneable<TBFUStAbnormalDispVictimMapDesc>
{
	private static readonly MessageParser<TBFUStAbnormalDispVictimMapDesc> _parser = new MessageParser<TBFUStAbnormalDispVictimMapDesc>(() => new TBFUStAbnormalDispVictimMapDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStAbnormalDispVictimMapDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStAbnormalDispVictimMapDesc.Parser);

	private readonly RepeatedField<FUStAbnormalDispVictimMapDesc> list_ = new RepeatedField<FUStAbnormalDispVictimMapDesc>();

	public static MessageParser<TBFUStAbnormalDispVictimMapDesc> Parser => _parser;

	public RepeatedField<FUStAbnormalDispVictimMapDesc> List => list_;

	public TBFUStAbnormalDispVictimMapDesc()
	{
	}

	public TBFUStAbnormalDispVictimMapDesc(TBFUStAbnormalDispVictimMapDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStAbnormalDispVictimMapDesc Clone()
	{
		return new TBFUStAbnormalDispVictimMapDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStAbnormalDispVictimMapDesc);
	}

	public bool Equals(TBFUStAbnormalDispVictimMapDesc other)
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

	public void MergeFrom(TBFUStAbnormalDispVictimMapDesc other)
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
