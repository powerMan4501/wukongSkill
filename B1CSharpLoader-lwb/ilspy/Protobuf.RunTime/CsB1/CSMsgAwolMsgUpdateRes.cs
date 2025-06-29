using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAwolMsgUpdateRes : IMessage<CSMsgAwolMsgUpdateRes>, IMessage, IEquatable<CSMsgAwolMsgUpdateRes>, IDeepCloneable<CSMsgAwolMsgUpdateRes>
{
	private static readonly MessageParser<CSMsgAwolMsgUpdateRes> _parser = new MessageParser<CSMsgAwolMsgUpdateRes>(() => new CSMsgAwolMsgUpdateRes());

	private UnknownFieldSet _unknownFields;

	private AwardList mailAward_;

	public static MessageParser<CSMsgAwolMsgUpdateRes> Parser => _parser;

	public AwardList MailAward
	{
		get
		{
			return mailAward_;
		}
		set
		{
			mailAward_ = value;
		}
	}

	public CSMsgAwolMsgUpdateRes()
	{
	}

	public CSMsgAwolMsgUpdateRes(CSMsgAwolMsgUpdateRes other)
		: this()
	{
		mailAward_ = ((other.mailAward_ != null) ? other.mailAward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgUpdateRes Clone()
	{
		return new CSMsgAwolMsgUpdateRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgUpdateRes);
	}

	public bool Equals(CSMsgAwolMsgUpdateRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MailAward, other.MailAward))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (mailAward_ != null)
		{
			num ^= MailAward.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (mailAward_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MailAward);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (mailAward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MailAward);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgAwolMsgUpdateRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mailAward_ != null)
		{
			if (mailAward_ == null)
			{
				MailAward = new AwardList();
			}
			MailAward.MergeFrom(other.MailAward);
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
			if (mailAward_ == null)
			{
				MailAward = new AwardList();
			}
			input.ReadMessage(MailAward);
		}
	}
}
