using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStAssociationUnitInfoSDesc : IMessage<TBFUStAssociationUnitInfoSDesc>, IMessage, IEquatable<TBFUStAssociationUnitInfoSDesc>, IDeepCloneable<TBFUStAssociationUnitInfoSDesc>
{
	private static readonly MessageParser<TBFUStAssociationUnitInfoSDesc> _parser = new MessageParser<TBFUStAssociationUnitInfoSDesc>(() => new TBFUStAssociationUnitInfoSDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStAssociationUnitInfoSDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStAssociationUnitInfoSDesc.Parser);

	private readonly RepeatedField<FUStAssociationUnitInfoSDesc> list_ = new RepeatedField<FUStAssociationUnitInfoSDesc>();

	public static MessageParser<TBFUStAssociationUnitInfoSDesc> Parser => _parser;

	public RepeatedField<FUStAssociationUnitInfoSDesc> List => list_;

	public TBFUStAssociationUnitInfoSDesc()
	{
	}

	public TBFUStAssociationUnitInfoSDesc(TBFUStAssociationUnitInfoSDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStAssociationUnitInfoSDesc Clone()
	{
		return new TBFUStAssociationUnitInfoSDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStAssociationUnitInfoSDesc);
	}

	public bool Equals(TBFUStAssociationUnitInfoSDesc other)
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

	public void MergeFrom(TBFUStAssociationUnitInfoSDesc other)
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
