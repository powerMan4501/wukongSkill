using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBEquipSeriesDesc : IMessage<TBEquipSeriesDesc>, IMessage, IEquatable<TBEquipSeriesDesc>, IDeepCloneable<TBEquipSeriesDesc>
{
	private static readonly MessageParser<TBEquipSeriesDesc> _parser = new MessageParser<TBEquipSeriesDesc>(() => new TBEquipSeriesDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<EquipSeriesDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, EquipSeriesDesc.Parser);

	private readonly RepeatedField<EquipSeriesDesc> list_ = new RepeatedField<EquipSeriesDesc>();

	public static MessageParser<TBEquipSeriesDesc> Parser => _parser;

	public RepeatedField<EquipSeriesDesc> List => list_;

	public TBEquipSeriesDesc()
	{
	}

	public TBEquipSeriesDesc(TBEquipSeriesDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBEquipSeriesDesc Clone()
	{
		return new TBEquipSeriesDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBEquipSeriesDesc);
	}

	public bool Equals(TBEquipSeriesDesc other)
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

	public void MergeFrom(TBEquipSeriesDesc other)
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
