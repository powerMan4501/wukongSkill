using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class AwolMsgServerMail : IMessage<AwolMsgServerMail>, IMessage, IEquatable<AwolMsgServerMail>, IDeepCloneable<AwolMsgServerMail>
{
	private static readonly MessageParser<AwolMsgServerMail> _parser = new MessageParser<AwolMsgServerMail>(() => new AwolMsgServerMail());

	private UnknownFieldSet _unknownFields;

	private MailBase base_;

	private static readonly FieldCodec<ServerMailContent> _repeated_contents_codec = FieldCodec.ForMessage(18u, ServerMailContent.Parser);

	private readonly RepeatedField<ServerMailContent> contents_ = new RepeatedField<ServerMailContent>();

	public static MessageParser<AwolMsgServerMail> Parser => _parser;

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

	public RepeatedField<ServerMailContent> Contents => contents_;

	public AwolMsgServerMail()
	{
	}

	public AwolMsgServerMail(AwolMsgServerMail other)
		: this()
	{
		base_ = ((other.base_ != null) ? other.base_.Clone() : null);
		contents_ = other.contents_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AwolMsgServerMail Clone()
	{
		return new AwolMsgServerMail(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AwolMsgServerMail);
	}

	public bool Equals(AwolMsgServerMail other)
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
		if (!contents_.Equals(other.contents_))
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
		num ^= contents_.GetHashCode();
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
		contents_.WriteTo(output, _repeated_contents_codec);
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
		num += contents_.CalculateSize(_repeated_contents_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AwolMsgServerMail other)
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
		contents_.Add(other.contents_);
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
				contents_.AddEntriesFrom(input, _repeated_contents_codec);
				break;
			}
		}
	}
}
