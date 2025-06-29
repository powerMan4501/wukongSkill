using System;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSMsgAwolMsgNotifyAddRes : IMessage<CSMsgAwolMsgNotifyAddRes>, IMessage, IEquatable<CSMsgAwolMsgNotifyAddRes>, IDeepCloneable<CSMsgAwolMsgNotifyAddRes>
{
	private static readonly MessageParser<CSMsgAwolMsgNotifyAddRes> _parser = new MessageParser<CSMsgAwolMsgNotifyAddRes>(() => new CSMsgAwolMsgNotifyAddRes());

	private UnknownFieldSet _unknownFields;

	private AwolMsgType msgType_;

	private static readonly FieldCodec<AwolMsgPlayerMail> _repeated_addMailList_codec = FieldCodec.ForMessage(18u, AwolMsgPlayerMail.Parser);

	private readonly RepeatedField<AwolMsgPlayerMail> addMailList_ = new RepeatedField<AwolMsgPlayerMail>();

	public static MessageParser<CSMsgAwolMsgNotifyAddRes> Parser => _parser;

	public AwolMsgType MsgType
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

	public RepeatedField<AwolMsgPlayerMail> AddMailList => addMailList_;

	public CSMsgAwolMsgNotifyAddRes()
	{
	}

	public CSMsgAwolMsgNotifyAddRes(CSMsgAwolMsgNotifyAddRes other)
		: this()
	{
		msgType_ = other.msgType_;
		addMailList_ = other.addMailList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgNotifyAddRes Clone()
	{
		return new CSMsgAwolMsgNotifyAddRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgNotifyAddRes);
	}

	public bool Equals(CSMsgAwolMsgNotifyAddRes other)
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
		if (!addMailList_.Equals(other.addMailList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MsgType != AwolMsgType.None)
		{
			num ^= MsgType.GetHashCode();
		}
		num ^= addMailList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MsgType != AwolMsgType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)MsgType);
		}
		addMailList_.WriteTo(output, _repeated_addMailList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MsgType != AwolMsgType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MsgType);
		}
		num += addMailList_.CalculateSize(_repeated_addMailList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgAwolMsgNotifyAddRes other)
	{
		if (other != null)
		{
			if (other.MsgType != AwolMsgType.None)
			{
				MsgType = other.MsgType;
			}
			addMailList_.Add(other.addMailList_);
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
				MsgType = (AwolMsgType)input.ReadEnum();
				break;
			case 18u:
				addMailList_.AddEntriesFrom(input, _repeated_addMailList_codec);
				break;
			}
		}
	}
}
