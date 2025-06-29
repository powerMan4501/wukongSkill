using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BPC_MapSymbolData : IMessage<BPC_MapSymbolData>, IMessage, IEquatable<BPC_MapSymbolData>, IDeepCloneable<BPC_MapSymbolData>
{
	private static readonly MessageParser<BPC_MapSymbolData> _parser = new MessageParser<BPC_MapSymbolData>(() => new BPC_MapSymbolData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<DictDeltaMsgString_EMapSymbolState> _repeated_mapSymbolStateDict_codec = FieldCodec.ForMessage(10u, DictDeltaMsgString_EMapSymbolState.Parser);

	private readonly RepeatedField<DictDeltaMsgString_EMapSymbolState> mapSymbolStateDict_ = new RepeatedField<DictDeltaMsgString_EMapSymbolState>();

	public static MessageParser<BPC_MapSymbolData> Parser => _parser;

	public RepeatedField<DictDeltaMsgString_EMapSymbolState> MapSymbolStateDict => mapSymbolStateDict_;

	public BPC_MapSymbolData()
	{
	}

	public BPC_MapSymbolData(BPC_MapSymbolData other)
		: this()
	{
		mapSymbolStateDict_ = other.mapSymbolStateDict_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BPC_MapSymbolData Clone()
	{
		return new BPC_MapSymbolData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BPC_MapSymbolData);
	}

	public bool Equals(BPC_MapSymbolData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mapSymbolStateDict_.Equals(other.mapSymbolStateDict_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= mapSymbolStateDict_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		mapSymbolStateDict_.WriteTo(output, _repeated_mapSymbolStateDict_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += mapSymbolStateDict_.CalculateSize(_repeated_mapSymbolStateDict_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BPC_MapSymbolData other)
	{
		if (other != null)
		{
			mapSymbolStateDict_.Add(other.mapSymbolStateDict_);
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
				mapSymbolStateDict_.AddEntriesFrom(input, _repeated_mapSymbolStateDict_codec);
			}
		}
	}
}
