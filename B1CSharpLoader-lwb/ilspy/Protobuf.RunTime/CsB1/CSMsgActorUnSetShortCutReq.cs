using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSMsgActorUnSetShortCutReq : IMessage<CSMsgActorUnSetShortCutReq>, IMessage, IEquatable<CSMsgActorUnSetShortCutReq>, IDeepCloneable<CSMsgActorUnSetShortCutReq>
{
	private static readonly MessageParser<CSMsgActorUnSetShortCutReq> _parser = new MessageParser<CSMsgActorUnSetShortCutReq>(() => new CSMsgActorUnSetShortCutReq());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<int> _repeated_positions_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> positions_ = new RepeatedField<int>();

	public static MessageParser<CSMsgActorUnSetShortCutReq> Parser => _parser;

	public RepeatedField<int> Positions => positions_;

	public CSMsgActorUnSetShortCutReq()
	{
	}

	public CSMsgActorUnSetShortCutReq(CSMsgActorUnSetShortCutReq other)
		: this()
	{
		positions_ = other.positions_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnSetShortCutReq Clone()
	{
		return new CSMsgActorUnSetShortCutReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnSetShortCutReq);
	}

	public bool Equals(CSMsgActorUnSetShortCutReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!positions_.Equals(other.positions_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= positions_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		positions_.WriteTo(output, _repeated_positions_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += positions_.CalculateSize(_repeated_positions_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorUnSetShortCutReq other)
	{
		if (other != null)
		{
			positions_.Add(other.positions_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8 && num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				positions_.AddEntriesFrom(input, _repeated_positions_codec);
			}
		}
	}
}
