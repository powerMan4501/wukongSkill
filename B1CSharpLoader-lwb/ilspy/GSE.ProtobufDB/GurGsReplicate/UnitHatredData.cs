using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class UnitHatredData : IMessage<UnitHatredData>, IMessage, IEquatable<UnitHatredData>, IDeepCloneable<UnitHatredData>
{
	private static readonly MessageParser<UnitHatredData> _parser = new MessageParser<UnitHatredData>(() => new UnitHatredData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ListDeltaMsgEntity> _repeated_playerHatredEntityList_codec = FieldCodec.ForMessage(10u, ListDeltaMsgEntity.Parser);

	private readonly RepeatedField<ListDeltaMsgEntity> playerHatredEntityList_ = new RepeatedField<ListDeltaMsgEntity>();

	public static MessageParser<UnitHatredData> Parser => _parser;

	public RepeatedField<ListDeltaMsgEntity> PlayerHatredEntityList => playerHatredEntityList_;

	public UnitHatredData()
	{
	}

	public UnitHatredData(UnitHatredData other)
		: this()
	{
		playerHatredEntityList_ = other.playerHatredEntityList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UnitHatredData Clone()
	{
		return new UnitHatredData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UnitHatredData);
	}

	public bool Equals(UnitHatredData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!playerHatredEntityList_.Equals(other.playerHatredEntityList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= playerHatredEntityList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		playerHatredEntityList_.WriteTo(output, _repeated_playerHatredEntityList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += playerHatredEntityList_.CalculateSize(_repeated_playerHatredEntityList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UnitHatredData other)
	{
		if (other != null)
		{
			playerHatredEntityList_.Add(other.playerHatredEntityList_);
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
				playerHatredEntityList_.AddEntriesFrom(input, _repeated_playerHatredEntityList_codec);
			}
		}
	}
}
