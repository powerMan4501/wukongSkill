using System;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSMsgBriefMsgGetReq : IMessage<CSMsgBriefMsgGetReq>, IMessage, IEquatable<CSMsgBriefMsgGetReq>, IDeepCloneable<CSMsgBriefMsgGetReq>
{
	private static readonly MessageParser<CSMsgBriefMsgGetReq> _parser = new MessageParser<CSMsgBriefMsgGetReq>(() => new CSMsgBriefMsgGetReq());

	private UnknownFieldSet _unknownFields;

	private ShareMsgType msgType_;

	private static readonly FieldCodec<ulong> _repeated_idList_codec = FieldCodec.ForFixed64(18u);

	private readonly RepeatedField<ulong> idList_ = new RepeatedField<ulong>();

	public static MessageParser<CSMsgBriefMsgGetReq> Parser => _parser;

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

	public RepeatedField<ulong> IdList => idList_;

	public CSMsgBriefMsgGetReq()
	{
	}

	public CSMsgBriefMsgGetReq(CSMsgBriefMsgGetReq other)
		: this()
	{
		msgType_ = other.msgType_;
		idList_ = other.idList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBriefMsgGetReq Clone()
	{
		return new CSMsgBriefMsgGetReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBriefMsgGetReq);
	}

	public bool Equals(CSMsgBriefMsgGetReq other)
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
		if (!idList_.Equals(other.idList_))
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
		num ^= idList_.GetHashCode();
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
		idList_.WriteTo(output, _repeated_idList_codec);
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
		num += idList_.CalculateSize(_repeated_idList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBriefMsgGetReq other)
	{
		if (other != null)
		{
			if (other.MsgType != ShareMsgType.None)
			{
				MsgType = other.MsgType;
			}
			idList_.Add(other.idList_);
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
			case 17u:
			case 18u:
				idList_.AddEntriesFrom(input, _repeated_idList_codec);
				break;
			}
		}
	}
}
