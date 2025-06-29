using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace L18NB1;

public sealed class TBLocalizationConfigDesc : IMessage<TBLocalizationConfigDesc>, IMessage, IEquatable<TBLocalizationConfigDesc>, IDeepCloneable<TBLocalizationConfigDesc>
{
	private static readonly MessageParser<TBLocalizationConfigDesc> _parser = new MessageParser<TBLocalizationConfigDesc>(() => new TBLocalizationConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<LocalizationConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, LocalizationConfigDesc.Parser);

	private readonly RepeatedField<LocalizationConfigDesc> list_ = new RepeatedField<LocalizationConfigDesc>();

	public static MessageParser<TBLocalizationConfigDesc> Parser => _parser;

	public RepeatedField<LocalizationConfigDesc> List => list_;

	public TBLocalizationConfigDesc()
	{
	}

	public TBLocalizationConfigDesc(TBLocalizationConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBLocalizationConfigDesc Clone()
	{
		return new TBLocalizationConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBLocalizationConfigDesc);
	}

	public bool Equals(TBLocalizationConfigDesc other)
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

	public void MergeFrom(TBLocalizationConfigDesc other)
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
