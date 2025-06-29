using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStSuperArmorLevelDesc : IMessage<TBFUStSuperArmorLevelDesc>, IMessage, IEquatable<TBFUStSuperArmorLevelDesc>, IDeepCloneable<TBFUStSuperArmorLevelDesc>
{
	private static readonly MessageParser<TBFUStSuperArmorLevelDesc> _parser = new MessageParser<TBFUStSuperArmorLevelDesc>(() => new TBFUStSuperArmorLevelDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStSuperArmorLevelDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStSuperArmorLevelDesc.Parser);

	private readonly RepeatedField<FUStSuperArmorLevelDesc> list_ = new RepeatedField<FUStSuperArmorLevelDesc>();

	public static MessageParser<TBFUStSuperArmorLevelDesc> Parser => _parser;

	public RepeatedField<FUStSuperArmorLevelDesc> List => list_;

	public TBFUStSuperArmorLevelDesc()
	{
	}

	public TBFUStSuperArmorLevelDesc(TBFUStSuperArmorLevelDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStSuperArmorLevelDesc Clone()
	{
		return new TBFUStSuperArmorLevelDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStSuperArmorLevelDesc);
	}

	public bool Equals(TBFUStSuperArmorLevelDesc other)
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

	public void MergeFrom(TBFUStSuperArmorLevelDesc other)
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
