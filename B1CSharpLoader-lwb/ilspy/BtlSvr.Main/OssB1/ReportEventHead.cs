using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventHead : IMessage<ReportEventHead>, IMessage, IEquatable<ReportEventHead>, IDeepCloneable<ReportEventHead>
{
	private static readonly MessageParser<ReportEventHead> _parser = new MessageParser<ReportEventHead>(() => new ReportEventHead());

	private UnknownFieldSet _unknownFields;

	private ReportMsgComm comm_;

	private static readonly FieldCodec<ReportClientInfo> _repeated_clientList_codec = FieldCodec.ForMessage(18u, ReportClientInfo.Parser);

	private readonly RepeatedField<ReportClientInfo> clientList_ = new RepeatedField<ReportClientInfo>();

	public static MessageParser<ReportEventHead> Parser => _parser;

	public ReportMsgComm Comm
	{
		get
		{
			return comm_;
		}
		set
		{
			comm_ = value;
		}
	}

	public RepeatedField<ReportClientInfo> ClientList => clientList_;

	public ReportEventHead()
	{
	}

	public ReportEventHead(ReportEventHead other)
		: this()
	{
		comm_ = ((other.comm_ != null) ? other.comm_.Clone() : null);
		clientList_ = other.clientList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventHead Clone()
	{
		return new ReportEventHead(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventHead);
	}

	public bool Equals(ReportEventHead other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Comm, other.Comm))
		{
			return false;
		}
		if (!clientList_.Equals(other.clientList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (comm_ != null)
		{
			num ^= Comm.GetHashCode();
		}
		num ^= clientList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (comm_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Comm);
		}
		clientList_.WriteTo(output, _repeated_clientList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (comm_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Comm);
		}
		num += clientList_.CalculateSize(_repeated_clientList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventHead other)
	{
		if (other == null)
		{
			return;
		}
		if (other.comm_ != null)
		{
			if (comm_ == null)
			{
				Comm = new ReportMsgComm();
			}
			Comm.MergeFrom(other.Comm);
		}
		clientList_.Add(other.clientList_);
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
				if (comm_ == null)
				{
					Comm = new ReportMsgComm();
				}
				input.ReadMessage(Comm);
				break;
			case 18u:
				clientList_.AddEntriesFrom(input, _repeated_clientList_codec);
				break;
			}
		}
	}
}
