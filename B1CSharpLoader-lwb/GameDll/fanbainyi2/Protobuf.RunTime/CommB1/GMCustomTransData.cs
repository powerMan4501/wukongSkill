using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class GMCustomTransData : IMessage<GMCustomTransData>, IMessage, IEquatable<GMCustomTransData>, IDeepCloneable<GMCustomTransData>
{
	private static readonly MessageParser<GMCustomTransData> _parser = new MessageParser<GMCustomTransData>(() => new GMCustomTransData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<GMCustomTransOne> _repeated_customTransList_codec = FieldCodec.ForMessage(10u, GMCustomTransOne.Parser);

	private readonly RepeatedField<GMCustomTransOne> customTransList_ = new RepeatedField<GMCustomTransOne>();

	public static MessageParser<GMCustomTransData> Parser => _parser;

	public RepeatedField<GMCustomTransOne> CustomTransList => customTransList_;

	public GMCustomTransData()
	{
	}

	public GMCustomTransData(GMCustomTransData other)
		: this()
	{
		customTransList_ = other.customTransList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GMCustomTransData Clone()
	{
		return new GMCustomTransData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GMCustomTransData);
	}

	public bool Equals(GMCustomTransData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!customTransList_.Equals(other.customTransList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= customTransList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		customTransList_.WriteTo(output, _repeated_customTransList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += customTransList_.CalculateSize(_repeated_customTransList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GMCustomTransData other)
	{
		if (other != null)
		{
			customTransList_.Add(other.customTransList_);
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
				customTransList_.AddEntriesFrom(input, _repeated_customTransList_codec);
			}
		}
	}
}
