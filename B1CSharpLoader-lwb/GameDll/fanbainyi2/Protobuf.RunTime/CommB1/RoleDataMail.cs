using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class RoleDataMail : IMessage<RoleDataMail>, IMessage, IEquatable<RoleDataMail>, IDeepCloneable<RoleDataMail>
{
	private static readonly MessageParser<RoleDataMail> _parser = new MessageParser<RoleDataMail>(() => new RoleDataMail());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<AwolMsgPlayerMail> _repeated_mails_codec = FieldCodec.ForMessage(10u, AwolMsgPlayerMail.Parser);

	private readonly RepeatedField<AwolMsgPlayerMail> mails_ = new RepeatedField<AwolMsgPlayerMail>();

	private static readonly FieldCodec<ulong> _repeated_receivedServerMail_codec = FieldCodec.ForUInt64(18u);

	private readonly RepeatedField<ulong> receivedServerMail_ = new RepeatedField<ulong>();

	public static MessageParser<RoleDataMail> Parser => _parser;

	public RepeatedField<AwolMsgPlayerMail> Mails => mails_;

	public RepeatedField<ulong> ReceivedServerMail => receivedServerMail_;

	public RoleDataMail()
	{
	}

	public RoleDataMail(RoleDataMail other)
		: this()
	{
		mails_ = other.mails_.Clone();
		receivedServerMail_ = other.receivedServerMail_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleDataMail Clone()
	{
		return new RoleDataMail(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDataMail);
	}

	public bool Equals(RoleDataMail other)
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
		if (!receivedServerMail_.Equals(other.receivedServerMail_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= mails_.GetHashCode();
		num ^= receivedServerMail_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		mails_.WriteTo(output, _repeated_mails_codec);
		receivedServerMail_.WriteTo(output, _repeated_receivedServerMail_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += mails_.CalculateSize(_repeated_mails_codec);
		num += receivedServerMail_.CalculateSize(_repeated_receivedServerMail_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleDataMail other)
	{
		if (other != null)
		{
			mails_.Add(other.mails_);
			receivedServerMail_.Add(other.receivedServerMail_);
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
			case 16u:
			case 18u:
				receivedServerMail_.AddEntriesFrom(input, _repeated_receivedServerMail_codec);
				break;
			}
		}
	}
}
