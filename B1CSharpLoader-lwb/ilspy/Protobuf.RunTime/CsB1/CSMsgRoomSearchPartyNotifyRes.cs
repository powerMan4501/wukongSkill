using System;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSMsgRoomSearchPartyNotifyRes : IMessage<CSMsgRoomSearchPartyNotifyRes>, IMessage, IEquatable<CSMsgRoomSearchPartyNotifyRes>, IDeepCloneable<CSMsgRoomSearchPartyNotifyRes>
{
	private static readonly MessageParser<CSMsgRoomSearchPartyNotifyRes> _parser = new MessageParser<CSMsgRoomSearchPartyNotifyRes>(() => new CSMsgRoomSearchPartyNotifyRes());

	private UnknownFieldSet _unknownFields;

	private PartySearchParam searchParam_;

	private static readonly FieldCodec<PartyInfo> _repeated_result_codec = FieldCodec.ForMessage(18u, PartyInfo.Parser);

	private readonly RepeatedField<PartyInfo> result_ = new RepeatedField<PartyInfo>();

	public static MessageParser<CSMsgRoomSearchPartyNotifyRes> Parser => _parser;

	public PartySearchParam SearchParam
	{
		get
		{
			return searchParam_;
		}
		set
		{
			searchParam_ = value;
		}
	}

	public RepeatedField<PartyInfo> Result => result_;

	public CSMsgRoomSearchPartyNotifyRes()
	{
	}

	public CSMsgRoomSearchPartyNotifyRes(CSMsgRoomSearchPartyNotifyRes other)
		: this()
	{
		searchParam_ = ((other.searchParam_ != null) ? other.searchParam_.Clone() : null);
		result_ = other.result_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomSearchPartyNotifyRes Clone()
	{
		return new CSMsgRoomSearchPartyNotifyRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomSearchPartyNotifyRes);
	}

	public bool Equals(CSMsgRoomSearchPartyNotifyRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(SearchParam, other.SearchParam))
		{
			return false;
		}
		if (!result_.Equals(other.result_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (searchParam_ != null)
		{
			num ^= SearchParam.GetHashCode();
		}
		num ^= result_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (searchParam_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(SearchParam);
		}
		result_.WriteTo(output, _repeated_result_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (searchParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SearchParam);
		}
		num += result_.CalculateSize(_repeated_result_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoomSearchPartyNotifyRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.searchParam_ != null)
		{
			if (searchParam_ == null)
			{
				SearchParam = new PartySearchParam();
			}
			SearchParam.MergeFrom(other.SearchParam);
		}
		result_.Add(other.result_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (searchParam_ == null)
				{
					SearchParam = new PartySearchParam();
				}
				input.ReadMessage(SearchParam);
				break;
			case 18u:
				result_.AddEntriesFrom(input, _repeated_result_codec);
				break;
			}
		}
	}
}
