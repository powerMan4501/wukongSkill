using System;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSMsgAwolMsgNotifyUpdateRes : IMessage<CSMsgAwolMsgNotifyUpdateRes>, IMessage, IEquatable<CSMsgAwolMsgNotifyUpdateRes>, IDeepCloneable<CSMsgAwolMsgNotifyUpdateRes>
{
	private static readonly MessageParser<CSMsgAwolMsgNotifyUpdateRes> _parser = new MessageParser<CSMsgAwolMsgNotifyUpdateRes>(() => new CSMsgAwolMsgNotifyUpdateRes());

	private UnknownFieldSet _unknownFields;

	private AwolMsgType msgType_;

	private static readonly FieldCodec<AwolMsgPlayerMail> _repeated_updateMailList_codec = FieldCodec.ForMessage(18u, AwolMsgPlayerMail.Parser);

	private readonly RepeatedField<AwolMsgPlayerMail> updateMailList_ = new RepeatedField<AwolMsgPlayerMail>();

	public static MessageParser<CSMsgAwolMsgNotifyUpdateRes> Parser => _parser;

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

	public RepeatedField<AwolMsgPlayerMail> UpdateMailList => updateMailList_;

	public CSMsgAwolMsgNotifyUpdateRes()
	{
	}

	public CSMsgAwolMsgNotifyUpdateRes(CSMsgAwolMsgNotifyUpdateRes other)
		: this()
	{
		msgType_ = other.msgType_;
		updateMailList_ = other.updateMailList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgNotifyUpdateRes Clone()
	{
		return new CSMsgAwolMsgNotifyUpdateRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgNotifyUpdateRes);
	}

	public bool Equals(CSMsgAwolMsgNotifyUpdateRes other)
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
		if (!updateMailList_.Equals(other.updateMailList_))
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
		num ^= updateMailList_.GetHashCode();
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
		updateMailList_.WriteTo(output, _repeated_updateMailList_codec);
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
		num += updateMailList_.CalculateSize(_repeated_updateMailList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgAwolMsgNotifyUpdateRes other)
	{
		if (other != null)
		{
			if (other.MsgType != AwolMsgType.None)
			{
				MsgType = other.MsgType;
			}
			updateMailList_.Add(other.updateMailList_);
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
				updateMailList_.AddEntriesFrom(input, _repeated_updateMailList_codec);
				break;
			}
		}
	}
}
