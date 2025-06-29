using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthGetOneReq : IMessage<AuthGetOneReq>, IMessage, IEquatable<AuthGetOneReq>, IDeepCloneable<AuthGetOneReq>
{
	private static readonly MessageParser<AuthGetOneReq> _parser = new MessageParser<AuthGetOneReq>(() => new AuthGetOneReq());

	private UnknownFieldSet _unknownFields;

	private long id_;

	public static MessageParser<AuthGetOneReq> Parser => _parser;

	public long Id
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

	public AuthGetOneReq()
	{
	}

	public AuthGetOneReq(AuthGetOneReq other)
		: this()
	{
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthGetOneReq Clone()
	{
		return new AuthGetOneReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthGetOneReq);
	}

	public bool Equals(AuthGetOneReq other)
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
		if (Id != 0L)
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
		if (Id != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(Id);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthGetOneReq other)
	{
		if (other != null)
		{
			if (other.Id != 0L)
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
				Id = input.ReadInt64();
			}
		}
	}
}
