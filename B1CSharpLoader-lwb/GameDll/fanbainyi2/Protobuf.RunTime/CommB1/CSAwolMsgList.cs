using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CSAwolMsgList : IMessage<CSAwolMsgList>, IMessage, IEquatable<CSAwolMsgList>, IDeepCloneable<CSAwolMsgList>
{
	private static readonly MessageParser<CSAwolMsgList> _parser = new MessageParser<CSAwolMsgList>(() => new CSAwolMsgList());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<AwolMsgPlayerMail> _repeated_mails_codec = FieldCodec.ForMessage(10u, AwolMsgPlayerMail.Parser);

	private readonly RepeatedField<AwolMsgPlayerMail> mails_ = new RepeatedField<AwolMsgPlayerMail>();

	private static readonly FieldCodec<AwolMsgPlayerChat> _repeated_chats_codec = FieldCodec.ForMessage(18u, AwolMsgPlayerChat.Parser);

	private readonly RepeatedField<AwolMsgPlayerChat> chats_ = new RepeatedField<AwolMsgPlayerChat>();

	private static readonly FieldCodec<AwolMsgPlayerNotify> _repeated_notifys_codec = FieldCodec.ForMessage(26u, AwolMsgPlayerNotify.Parser);

	private readonly RepeatedField<AwolMsgPlayerNotify> notifys_ = new RepeatedField<AwolMsgPlayerNotify>();

	public static MessageParser<CSAwolMsgList> Parser => _parser;

	public RepeatedField<AwolMsgPlayerMail> Mails => mails_;

	public RepeatedField<AwolMsgPlayerChat> Chats => chats_;

	public RepeatedField<AwolMsgPlayerNotify> Notifys => notifys_;

	public CSAwolMsgList()
	{
	}

	public CSAwolMsgList(CSAwolMsgList other)
		: this()
	{
		mails_ = other.mails_.Clone();
		chats_ = other.chats_.Clone();
		notifys_ = other.notifys_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSAwolMsgList Clone()
	{
		return new CSAwolMsgList(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSAwolMsgList);
	}

	public bool Equals(CSAwolMsgList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mails_.Equals(other.mails_))
		{
			return false;
		}
		if (!chats_.Equals(other.chats_))
		{
			return false;
		}
		if (!notifys_.Equals(other.notifys_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= mails_.GetHashCode();
		num ^= chats_.GetHashCode();
		num ^= notifys_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		mails_.WriteTo(output, _repeated_mails_codec);
		chats_.WriteTo(output, _repeated_chats_codec);
		notifys_.WriteTo(output, _repeated_notifys_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += mails_.CalculateSize(_repeated_mails_codec);
		num += chats_.CalculateSize(_repeated_chats_codec);
		num += notifys_.CalculateSize(_repeated_notifys_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSAwolMsgList other)
	{
		if (other != null)
		{
			mails_.Add(other.mails_);
			chats_.Add(other.chats_);
			notifys_.Add(other.notifys_);
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
			case 10u:
				mails_.AddEntriesFrom(input, _repeated_mails_codec);
				break;
			case 18u:
				chats_.AddEntriesFrom(input, _repeated_chats_codec);
				break;
			case 26u:
				notifys_.AddEntriesFrom(input, _repeated_notifys_codec);
				break;
			}
		}
	}
}
