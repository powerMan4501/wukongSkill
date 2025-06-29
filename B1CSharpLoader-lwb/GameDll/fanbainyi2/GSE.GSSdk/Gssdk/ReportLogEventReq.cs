using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class ReportLogEventReq : IMessage<ReportLogEventReq>, IMessage, IEquatable<ReportLogEventReq>, IDeepCloneable<ReportLogEventReq>
{
	private static readonly MessageParser<ReportLogEventReq> _parser = new MessageParser<ReportLogEventReq>(() => new ReportLogEventReq());

	private UnknownFieldSet _unknownFields;

	private ReportLogEventSession session_;

	private static readonly FieldCodec<ReportLogEventLine> _repeated_eventList_codec = FieldCodec.ForMessage(18u, ReportLogEventLine.Parser);

	private readonly RepeatedField<ReportLogEventLine> eventList_ = new RepeatedField<ReportLogEventLine>();

	public static MessageParser<ReportLogEventReq> Parser => _parser;

	public ReportLogEventSession Session
	{
		get
		{
			return session_;
		}
		set
		{
			session_ = value;
		}
	}

	public RepeatedField<ReportLogEventLine> EventList => eventList_;

	public ReportLogEventReq()
	{
	}

	public ReportLogEventReq(ReportLogEventReq other)
		: this()
	{
		session_ = ((other.session_ != null) ? other.session_.Clone() : null);
		eventList_ = other.eventList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportLogEventReq Clone()
	{
		return new ReportLogEventReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportLogEventReq);
	}

	public bool Equals(ReportLogEventReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Session, other.Session))
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
		if (session_ != null)
		{
			num ^= Session.GetHashCode();
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
		if (session_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Session);
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
		if (session_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Session);
		}
		num += eventList_.CalculateSize(_repeated_eventList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportLogEventReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.session_ != null)
		{
			if (session_ == null)
			{
				Session = new ReportLogEventSession();
			}
			Session.MergeFrom(other.Session);
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
				if (session_ == null)
				{
					Session = new ReportLogEventSession();
				}
				input.ReadMessage(Session);
				break;
			case 18u:
				eventList_.AddEntriesFrom(input, _repeated_eventList_codec);
				break;
			}
		}
	}
}
