using System;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSMsgAwolMsgNotifyRemoveRes : IMessage<CSMsgAwolMsgNotifyRemoveRes>, IMessage, IEquatable<CSMsgAwolMsgNotifyRemoveRes>, IDeepCloneable<CSMsgAwolMsgNotifyRemoveRes>
{
	private static readonly MessageParser<CSMsgAwolMsgNotifyRemoveRes> _parser = new MessageParser<CSMsgAwolMsgNotifyRemoveRes>(() => new CSMsgAwolMsgNotifyRemoveRes());

	private UnknownFieldSet _unknownFields;

	private AwolMsgType msgType_;

	private static readonly FieldCodec<ulong> _repeated_removeMailList_codec = FieldCodec.ForUInt64(18u);

	private readonly RepeatedField<ulong> removeMailList_ = new RepeatedField<ulong>();

	public static MessageParser<CSMsgAwolMsgNotifyRemoveRes> Parser => _parser;

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

	public RepeatedField<ulong> RemoveMailList => removeMailList_;

	public CSMsgAwolMsgNotifyRemoveRes()
	{
	}

	public CSMsgAwolMsgNotifyRemoveRes(CSMsgAwolMsgNotifyRemoveRes other)
		: this()
	{
		msgType_ = other.msgType_;
		removeMailList_ = other.removeMailList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgNotifyRemoveRes Clone()
	{
		return new CSMsgAwolMsgNotifyRemoveRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgNotifyRemoveRes);
	}

	public bool Equals(CSMsgAwolMsgNotifyRemoveRes other)
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
		if (!removeMailList_.Equals(other.removeMailList_))
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
		num ^= removeMailList_.GetHashCode();
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
		removeMailList_.WriteTo(output, _repeated_removeMailList_codec);
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
		num += removeMailList_.CalculateSize(_repeated_removeMailList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgAwolMsgNotifyRemoveRes other)
	{
		if (other != null)
		{
			if (other.MsgType != AwolMsgType.None)
			{
				MsgType = other.MsgType;
			}
			removeMailList_.Add(other.removeMailList_);
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
			case 16u:
			case 18u:
				removeMailList_.AddEntriesFrom(input, _repeated_removeMailList_codec);
				break;
			}
		}
	}
}
