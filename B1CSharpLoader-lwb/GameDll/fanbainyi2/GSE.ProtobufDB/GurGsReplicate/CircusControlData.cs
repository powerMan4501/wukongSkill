using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class CircusControlData : IMessage<CircusControlData>, IMessage, IEquatable<CircusControlData>, IDeepCloneable<CircusControlData>
{
	private static readonly MessageParser<CircusControlData> _parser = new MessageParser<CircusControlData>(() => new CircusControlData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ListDeltaMsgString> _repeated_alwaysSpawnTamerGuidList_codec = FieldCodec.ForMessage(10u, ListDeltaMsgString.Parser);

	private readonly RepeatedField<ListDeltaMsgString> alwaysSpawnTamerGuidList_ = new RepeatedField<ListDeltaMsgString>();

	private static readonly FieldCodec<ListDeltaMsgString> _repeated_neverSpawnTamerGuidList_codec = FieldCodec.ForMessage(18u, ListDeltaMsgString.Parser);

	private readonly RepeatedField<ListDeltaMsgString> neverSpawnTamerGuidList_ = new RepeatedField<ListDeltaMsgString>();

	public static MessageParser<CircusControlData> Parser => _parser;

	public RepeatedField<ListDeltaMsgString> AlwaysSpawnTamerGuidList => alwaysSpawnTamerGuidList_;

	public RepeatedField<ListDeltaMsgString> NeverSpawnTamerGuidList => neverSpawnTamerGuidList_;

	public CircusControlData()
	{
	}

	public CircusControlData(CircusControlData other)
		: this()
	{
		alwaysSpawnTamerGuidList_ = other.alwaysSpawnTamerGuidList_.Clone();
		neverSpawnTamerGuidList_ = other.neverSpawnTamerGuidList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CircusControlData Clone()
	{
		return new CircusControlData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CircusControlData);
	}

	public bool Equals(CircusControlData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!alwaysSpawnTamerGuidList_.Equals(other.alwaysSpawnTamerGuidList_))
		{
			return false;
		}
		if (!neverSpawnTamerGuidList_.Equals(other.neverSpawnTamerGuidList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= alwaysSpawnTamerGuidList_.GetHashCode();
		num ^= neverSpawnTamerGuidList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		alwaysSpawnTamerGuidList_.WriteTo(output, _repeated_alwaysSpawnTamerGuidList_codec);
		neverSpawnTamerGuidList_.WriteTo(output, _repeated_neverSpawnTamerGuidList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += alwaysSpawnTamerGuidList_.CalculateSize(_repeated_alwaysSpawnTamerGuidList_codec);
		num += neverSpawnTamerGuidList_.CalculateSize(_repeated_neverSpawnTamerGuidList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CircusControlData other)
	{
		if (other != null)
		{
			alwaysSpawnTamerGuidList_.Add(other.alwaysSpawnTamerGuidList_);
			neverSpawnTamerGuidList_.Add(other.neverSpawnTamerGuidList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 10u:
				alwaysSpawnTamerGuidList_.AddEntriesFrom(input, _repeated_alwaysSpawnTamerGuidList_codec);
				break;
			case 18u:
				neverSpawnTamerGuidList_.AddEntriesFrom(input, _repeated_neverSpawnTamerGuidList_codec);
				break;
			}
		}
	}
}
