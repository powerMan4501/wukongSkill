using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomQueryPartyInfoCSRes : IMessage<CSMsgRoomQueryPartyInfoCSRes>, IMessage, IEquatable<CSMsgRoomQueryPartyInfoCSRes>, IDeepCloneable<CSMsgRoomQueryPartyInfoCSRes>
{
	private static readonly MessageParser<CSMsgRoomQueryPartyInfoCSRes> _parser = new MessageParser<CSMsgRoomQueryPartyInfoCSRes>(() => new CSMsgRoomQueryPartyInfoCSRes());

	private UnknownFieldSet _unknownFields;

	private PartyInfo result_;

	public static MessageParser<CSMsgRoomQueryPartyInfoCSRes> Parser => _parser;

	public PartyInfo Result
	{
		get
		{
			return result_;
		}
		set
		{
			result_ = value;
		}
	}

	public CSMsgRoomQueryPartyInfoCSRes()
	{
	}

	public CSMsgRoomQueryPartyInfoCSRes(CSMsgRoomQueryPartyInfoCSRes other)
		: this()
	{
		result_ = ((other.result_ != null) ? other.result_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomQueryPartyInfoCSRes Clone()
	{
		return new CSMsgRoomQueryPartyInfoCSRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomQueryPartyInfoCSRes);
	}

	public bool Equals(CSMsgRoomQueryPartyInfoCSRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Result, other.Result))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (result_ != null)
		{
			num ^= Result.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (result_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Result);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (result_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Result);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoomQueryPartyInfoCSRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.result_ != null)
		{
			if (result_ == null)
			{
				Result = new PartyInfo();
			}
			Result.MergeFrom(other.Result);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (result_ == null)
			{
				Result = new PartyInfo();
			}
			input.ReadMessage(Result);
		}
	}
}
