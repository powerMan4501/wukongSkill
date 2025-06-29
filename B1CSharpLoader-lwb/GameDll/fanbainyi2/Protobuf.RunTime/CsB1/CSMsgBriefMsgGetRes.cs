using System;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSMsgBriefMsgGetRes : IMessage<CSMsgBriefMsgGetRes>, IMessage, IEquatable<CSMsgBriefMsgGetRes>, IDeepCloneable<CSMsgBriefMsgGetRes>
{
	private static readonly MessageParser<CSMsgBriefMsgGetRes> _parser = new MessageParser<CSMsgBriefMsgGetRes>(() => new CSMsgBriefMsgGetRes());

	private UnknownFieldSet _unknownFields;

	private ShareMsgType msgType_;

	private static readonly FieldCodec<CSShareMsg> _repeated_msgList_codec = FieldCodec.ForMessage(18u, CSShareMsg.Parser);

	private readonly RepeatedField<CSShareMsg> msgList_ = new RepeatedField<CSShareMsg>();

	public static MessageParser<CSMsgBriefMsgGetRes> Parser => _parser;

	public ShareMsgType MsgType
	{
		get
		{
			return msgType_;
		}
		set
		{
			msgType_ = value;
		}
	}

	public RepeatedField<CSShareMsg> MsgList => msgList_;

	public CSMsgBriefMsgGetRes()
	{
	}

	public CSMsgBriefMsgGetRes(CSMsgBriefMsgGetRes other)
		: this()
	{
		msgType_ = other.msgType_;
		msgList_ = other.msgList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBriefMsgGetRes Clone()
	{
		return new CSMsgBriefMsgGetRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBriefMsgGetRes);
	}

	public bool Equals(CSMsgBriefMsgGetRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MsgType != other.MsgType)
		{
			return false;
		}
		if (!msgList_.Equals(other.msgList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MsgType != ShareMsgType.None)
		{
			num ^= MsgType.GetHashCode();
		}
		num ^= msgList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MsgType != ShareMsgType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)MsgType);
		}
		msgList_.WriteTo(output, _repeated_msgList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MsgType != ShareMsgType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MsgType);
		}
		num += msgList_.CalculateSize(_repeated_msgList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBriefMsgGetRes other)
	{
		if (other != null)
		{
			if (other.MsgType != ShareMsgType.None)
			{
				MsgType = other.MsgType;
			}
			msgList_.Add(other.msgList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 8u:
				MsgType = (ShareMsgType)input.ReadEnum();
				break;
			case 18u:
				msgList_.AddEntriesFrom(input, _repeated_msgList_codec);
				break;
			}
		}
	}
}
