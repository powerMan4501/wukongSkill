using System;
using Google.Protobuf;

namespace CommB1;

public sealed class AwolMsgPlayerMail : IMessage<AwolMsgPlayerMail>, IMessage, IEquatable<AwolMsgPlayerMail>, IDeepCloneable<AwolMsgPlayerMail>
{
	private static readonly MessageParser<AwolMsgPlayerMail> _parser = new MessageParser<AwolMsgPlayerMail>(() => new AwolMsgPlayerMail());

	private UnknownFieldSet _unknownFields;

	private MailBase base_;

	private PlayerMailContent content_;

	public static MessageParser<AwolMsgPlayerMail> Parser => _parser;

	public MailBase Base
	{
		get
		{
			return base_;
		}
		set
		{
			base_ = value;
		}
	}

	public PlayerMailContent Content
	{
		get
		{
			return content_;
		}
		set
		{
			content_ = value;
		}
	}

	public AwolMsgPlayerMail()
	{
	}

	public AwolMsgPlayerMail(AwolMsgPlayerMail other)
		: this()
	{
		base_ = ((other.base_ != null) ? other.base_.Clone() : null);
		content_ = ((other.content_ != null) ? other.content_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AwolMsgPlayerMail Clone()
	{
		return new AwolMsgPlayerMail(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AwolMsgPlayerMail);
	}

	public bool Equals(AwolMsgPlayerMail other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Base, other.Base))
		{
			return false;
		}
		if (!object.Equals(Content, other.Content))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (base_ != null)
		{
			num ^= Base.GetHashCode();
		}
		if (content_ != null)
		{
			num ^= Content.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (base_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Base);
		}
		if (content_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Content);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (base_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Base);
		}
		if (content_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Content);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AwolMsgPlayerMail other)
	{
		if (other == null)
		{
			return;
		}
		if (other.base_ != null)
		{
			if (base_ == null)
			{
				Base = new MailBase();
			}
			Base.MergeFrom(other.Base);
		}
		if (other.content_ != null)
		{
			if (content_ == null)
			{
				Content = new PlayerMailContent();
			}
			Content.MergeFrom(other.Content);
		}
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
				if (base_ == null)
				{
					Base = new MailBase();
				}
				input.ReadMessage(Base);
				break;
			case 18u:
				if (content_ == null)
				{
					Content = new PlayerMailContent();
				}
				input.ReadMessage(Content);
				break;
			}
		}
	}
}
