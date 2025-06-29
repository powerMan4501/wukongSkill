using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PlayerMailContent : IMessage<PlayerMailContent>, IMessage, IEquatable<PlayerMailContent>, IDeepCloneable<PlayerMailContent>
{
	private static readonly MessageParser<PlayerMailContent> _parser = new MessageParser<PlayerMailContent>(() => new PlayerMailContent());

	private UnknownFieldSet _unknownFields;

	private MailContentType contentType_;

	private string sender_ = "";

	private string subject_ = "";

	private ByteString data_ = ByteString.Empty;

	private string forwardButton_ = "";

	private string forwardUrl_ = "";

	public static MessageParser<PlayerMailContent> Parser => _parser;

	public MailContentType ContentType
	{
		get
		{
			return contentType_;
		}
		set
		{
			contentType_ = value;
		}
	}

	public string Sender
	{
		get
		{
			return sender_;
		}
		set
		{
			sender_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Subject
	{
		get
		{
			return subject_;
		}
		set
		{
			subject_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ByteString Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ForwardButton
	{
		get
		{
			return forwardButton_;
		}
		set
		{
			forwardButton_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ForwardUrl
	{
		get
		{
			return forwardUrl_;
		}
		set
		{
			forwardUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public PlayerMailContent()
	{
	}

	public PlayerMailContent(PlayerMailContent other)
		: this()
	{
		contentType_ = other.contentType_;
		sender_ = other.sender_;
		subject_ = other.subject_;
		data_ = other.data_;
		forwardButton_ = other.forwardButton_;
		forwardUrl_ = other.forwardUrl_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerMailContent Clone()
	{
		return new PlayerMailContent(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerMailContent);
	}

	public bool Equals(PlayerMailContent other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ContentType != other.ContentType)
		{
			return false;
		}
		if (Sender != other.Sender)
		{
			return false;
		}
		if (Subject != other.Subject)
		{
			return false;
		}
		if (Data != other.Data)
		{
			return false;
		}
		if (ForwardButton != other.ForwardButton)
		{
			return false;
		}
		if (ForwardUrl != other.ForwardUrl)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ContentType != MailContentType.MailContentText)
		{
			num ^= ContentType.GetHashCode();
		}
		if (Sender.Length != 0)
		{
			num ^= Sender.GetHashCode();
		}
		if (Subject.Length != 0)
		{
			num ^= Subject.GetHashCode();
		}
		if (Data.Length != 0)
		{
			num ^= Data.GetHashCode();
		}
		if (ForwardButton.Length != 0)
		{
			num ^= ForwardButton.GetHashCode();
		}
		if (ForwardUrl.Length != 0)
		{
			num ^= ForwardUrl.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ContentType != MailContentType.MailContentText)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ContentType);
		}
		if (Sender.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Sender);
		}
		if (Subject.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Subject);
		}
		if (Data.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteBytes(Data);
		}
		if (ForwardButton.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ForwardButton);
		}
		if (ForwardUrl.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(ForwardUrl);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ContentType != MailContentType.MailContentText)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ContentType);
		}
		if (Sender.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Sender);
		}
		if (Subject.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Subject);
		}
		if (Data.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Data);
		}
		if (ForwardButton.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ForwardButton);
		}
		if (ForwardUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ForwardUrl);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerMailContent other)
	{
		if (other != null)
		{
			if (other.ContentType != MailContentType.MailContentText)
			{
				ContentType = other.ContentType;
			}
			if (other.Sender.Length != 0)
			{
				Sender = other.Sender;
			}
			if (other.Subject.Length != 0)
			{
				Subject = other.Subject;
			}
			if (other.Data.Length != 0)
			{
				Data = other.Data;
			}
			if (other.ForwardButton.Length != 0)
			{
				ForwardButton = other.ForwardButton;
			}
			if (other.ForwardUrl.Length != 0)
			{
				ForwardUrl = other.ForwardUrl;
			}
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
				ContentType = (MailContentType)input.ReadEnum();
				break;
			case 18u:
				Sender = input.ReadString();
				break;
			case 26u:
				Subject = input.ReadString();
				break;
			case 34u:
				Data = input.ReadBytes();
				break;
			case 42u:
				ForwardButton = input.ReadString();
				break;
			case 50u:
				ForwardUrl = input.ReadString();
				break;
			}
		}
	}
}
