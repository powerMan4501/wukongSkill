using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAwolMsgGetListRes : IMessage<CSMsgAwolMsgGetListRes>, IMessage, IEquatable<CSMsgAwolMsgGetListRes>, IDeepCloneable<CSMsgAwolMsgGetListRes>
{
	private static readonly MessageParser<CSMsgAwolMsgGetListRes> _parser = new MessageParser<CSMsgAwolMsgGetListRes>(() => new CSMsgAwolMsgGetListRes());

	private UnknownFieldSet _unknownFields;

	private CSAwolMsgList msgList_;

	public static MessageParser<CSMsgAwolMsgGetListRes> Parser => _parser;

	public CSAwolMsgList MsgList
	{
		get
		{
			return msgList_;
		}
		set
		{
			msgList_ = value;
		}
	}

	public CSMsgAwolMsgGetListRes()
	{
	}

	public CSMsgAwolMsgGetListRes(CSMsgAwolMsgGetListRes other)
		: this()
	{
		msgList_ = ((other.msgList_ != null) ? other.msgList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgGetListRes Clone()
	{
		return new CSMsgAwolMsgGetListRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgGetListRes);
	}

	public bool Equals(CSMsgAwolMsgGetListRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MsgList, other.MsgList))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (msgList_ != null)
		{
			num ^= MsgList.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (msgList_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MsgList);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (msgList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MsgList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgAwolMsgGetListRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.msgList_ != null)
		{
			if (msgList_ == null)
			{
				MsgList = new CSAwolMsgList();
			}
			MsgList.MergeFrom(other.MsgList);
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
			if (msgList_ == null)
			{
				MsgList = new CSAwolMsgList();
			}
			input.ReadMessage(MsgList);
		}
	}
}
