using System;
using Google.Protobuf;

namespace CommB1;

public sealed class AwolMsgPlayerChat : IMessage<AwolMsgPlayerChat>, IMessage, IEquatable<AwolMsgPlayerChat>, IDeepCloneable<AwolMsgPlayerChat>
{
	private static readonly MessageParser<AwolMsgPlayerChat> _parser = new MessageParser<AwolMsgPlayerChat>(() => new AwolMsgPlayerChat());

	private UnknownFieldSet _unknownFields;

	private uint id_;

	public static MessageParser<AwolMsgPlayerChat> Parser => _parser;

	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public AwolMsgPlayerChat()
	{
	}

	public AwolMsgPlayerChat(AwolMsgPlayerChat other)
		: this()
	{
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AwolMsgPlayerChat Clone()
	{
		return new AwolMsgPlayerChat(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AwolMsgPlayerChat);
	}

	public bool Equals(AwolMsgPlayerChat other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Id);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AwolMsgPlayerChat other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				Id = input.ReadUInt32();
			}
		}
	}
}
