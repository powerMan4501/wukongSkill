using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class ReportEventReq : IMessage<ReportEventReq>, IMessage, IEquatable<ReportEventReq>, IDeepCloneable<ReportEventReq>
{
	private static readonly MessageParser<ReportEventReq> _parser = new MessageParser<ReportEventReq>(() => new ReportEventReq());

	private UnknownFieldSet _unknownFields;

	private ReportUserKey userKey_;

	private static readonly FieldCodec<ReportUserEvent> _repeated_eventList_codec = FieldCodec.ForMessage(18u, ReportUserEvent.Parser);

	private readonly RepeatedField<ReportUserEvent> eventList_ = new RepeatedField<ReportUserEvent>();

	public static MessageParser<ReportEventReq> Parser => _parser;

	public ReportUserKey UserKey
	{
		get
		{
			return userKey_;
		}
		set
		{
			userKey_ = value;
		}
	}

	public RepeatedField<ReportUserEvent> EventList => eventList_;

	public ReportEventReq()
	{
	}

	public ReportEventReq(ReportEventReq other)
		: this()
	{
		userKey_ = ((other.userKey_ != null) ? other.userKey_.Clone() : null);
		eventList_ = other.eventList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventReq Clone()
	{
		return new ReportEventReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventReq);
	}

	public bool Equals(ReportEventReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(UserKey, other.UserKey))
		{
			return false;
		}
		if (!eventList_.Equals(other.eventList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (userKey_ != null)
		{
			num ^= UserKey.GetHashCode();
		}
		num ^= eventList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (userKey_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(UserKey);
		}
		eventList_.WriteTo(output, _repeated_eventList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (userKey_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserKey);
		}
		num += eventList_.CalculateSize(_repeated_eventList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.userKey_ != null)
		{
			if (userKey_ == null)
			{
				UserKey = new ReportUserKey();
			}
			UserKey.MergeFrom(other.UserKey);
		}
		eventList_.Add(other.eventList_);
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
				if (userKey_ == null)
				{
					UserKey = new ReportUserKey();
				}
				input.ReadMessage(UserKey);
				break;
			case 18u:
				eventList_.AddEntriesFrom(input, _repeated_eventList_codec);
				break;
			}
		}
	}
}
