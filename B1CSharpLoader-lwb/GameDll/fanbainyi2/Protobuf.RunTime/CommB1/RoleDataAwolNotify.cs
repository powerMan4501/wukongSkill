using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class RoleDataAwolNotify : IMessage<RoleDataAwolNotify>, IMessage, IEquatable<RoleDataAwolNotify>, IDeepCloneable<RoleDataAwolNotify>
{
	private static readonly MessageParser<RoleDataAwolNotify> _parser = new MessageParser<RoleDataAwolNotify>(() => new RoleDataAwolNotify());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<AwolMsgPlayerNotify> _repeated_notifies_codec = FieldCodec.ForMessage(10u, AwolMsgPlayerNotify.Parser);

	private readonly RepeatedField<AwolMsgPlayerNotify> notifies_ = new RepeatedField<AwolMsgPlayerNotify>();

	public static MessageParser<RoleDataAwolNotify> Parser => _parser;

	public RepeatedField<AwolMsgPlayerNotify> Notifies => notifies_;

	public RoleDataAwolNotify()
	{
	}

	public RoleDataAwolNotify(RoleDataAwolNotify other)
		: this()
	{
		notifies_ = other.notifies_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleDataAwolNotify Clone()
	{
		return new RoleDataAwolNotify(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDataAwolNotify);
	}

	public bool Equals(RoleDataAwolNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!notifies_.Equals(other.notifies_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= notifies_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		notifies_.WriteTo(output, _repeated_notifies_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += notifies_.CalculateSize(_repeated_notifies_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleDataAwolNotify other)
	{
		if (other != null)
		{
			notifies_.Add(other.notifies_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				notifies_.AddEntriesFrom(input, _repeated_notifies_codec);
			}
		}
	}
}
