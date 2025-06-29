using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BGC_PlayerGuideData : IMessage<BGC_PlayerGuideData>, IMessage, IEquatable<BGC_PlayerGuideData>, IDeepCloneable<BGC_PlayerGuideData>
{
	private static readonly MessageParser<BGC_PlayerGuideData> _parser = new MessageParser<BGC_PlayerGuideData>(() => new BGC_PlayerGuideData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ListDeltaMsgInt> _repeated_finishedGroupGuideList_codec = FieldCodec.ForMessage(10u, ListDeltaMsgInt.Parser);

	private readonly RepeatedField<ListDeltaMsgInt> finishedGroupGuideList_ = new RepeatedField<ListDeltaMsgInt>();

	public static MessageParser<BGC_PlayerGuideData> Parser => _parser;

	public RepeatedField<ListDeltaMsgInt> FinishedGroupGuideList => finishedGroupGuideList_;

	public BGC_PlayerGuideData()
	{
	}

	public BGC_PlayerGuideData(BGC_PlayerGuideData other)
		: this()
	{
		finishedGroupGuideList_ = other.finishedGroupGuideList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BGC_PlayerGuideData Clone()
	{
		return new BGC_PlayerGuideData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BGC_PlayerGuideData);
	}

	public bool Equals(BGC_PlayerGuideData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!finishedGroupGuideList_.Equals(other.finishedGroupGuideList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= finishedGroupGuideList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		finishedGroupGuideList_.WriteTo(output, _repeated_finishedGroupGuideList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += finishedGroupGuideList_.CalculateSize(_repeated_finishedGroupGuideList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BGC_PlayerGuideData other)
	{
		if (other != null)
		{
			finishedGroupGuideList_.Add(other.finishedGroupGuideList_);
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
				finishedGroupGuideList_.AddEntriesFrom(input, _repeated_finishedGroupGuideList_codec);
			}
		}
	}
}
