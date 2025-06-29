using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSCheckResList : IMessage<CSCheckResList>, IMessage, IEquatable<CSCheckResList>, IDeepCloneable<CSCheckResList>
{
	private static readonly MessageParser<CSCheckResList> _parser = new MessageParser<CSCheckResList>(() => new CSCheckResList());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<CSCheckResResult> _repeated_checkPair_codec = FieldCodec.ForMessage(10u, CSCheckResResult.Parser);

	private readonly RepeatedField<CSCheckResResult> checkPair_ = new RepeatedField<CSCheckResResult>();

	public static MessageParser<CSCheckResList> Parser => _parser;

	public RepeatedField<CSCheckResResult> CheckPair => checkPair_;

	public CSCheckResList()
	{
	}

	public CSCheckResList(CSCheckResList other)
		: this()
	{
		checkPair_ = other.checkPair_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSCheckResList Clone()
	{
		return new CSCheckResList(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSCheckResList);
	}

	public bool Equals(CSCheckResList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!checkPair_.Equals(other.checkPair_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= checkPair_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		checkPair_.WriteTo(output, _repeated_checkPair_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += checkPair_.CalculateSize(_repeated_checkPair_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSCheckResList other)
	{
		if (other != null)
		{
			checkPair_.Add(other.checkPair_);
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
				checkPair_.AddEntriesFrom(input, _repeated_checkPair_codec);
			}
		}
	}
}
