using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStPotentialEnergyConfigDesc : IMessage<TBFUStPotentialEnergyConfigDesc>, IMessage, IEquatable<TBFUStPotentialEnergyConfigDesc>, IDeepCloneable<TBFUStPotentialEnergyConfigDesc>
{
	private static readonly MessageParser<TBFUStPotentialEnergyConfigDesc> _parser = new MessageParser<TBFUStPotentialEnergyConfigDesc>(() => new TBFUStPotentialEnergyConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStPotentialEnergyConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStPotentialEnergyConfigDesc.Parser);

	private readonly RepeatedField<FUStPotentialEnergyConfigDesc> list_ = new RepeatedField<FUStPotentialEnergyConfigDesc>();

	public static MessageParser<TBFUStPotentialEnergyConfigDesc> Parser => _parser;

	public RepeatedField<FUStPotentialEnergyConfigDesc> List => list_;

	public TBFUStPotentialEnergyConfigDesc()
	{
	}

	public TBFUStPotentialEnergyConfigDesc(TBFUStPotentialEnergyConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStPotentialEnergyConfigDesc Clone()
	{
		return new TBFUStPotentialEnergyConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStPotentialEnergyConfigDesc);
	}

	public bool Equals(TBFUStPotentialEnergyConfigDesc other)
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

	public void MergeFrom(TBFUStPotentialEnergyConfigDesc other)
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
