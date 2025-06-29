using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthGetOneRes : IMessage<AuthGetOneRes>, IMessage, IEquatable<AuthGetOneRes>, IDeepCloneable<AuthGetOneRes>
{
	private static readonly MessageParser<AuthGetOneRes> _parser = new MessageParser<AuthGetOneRes>(() => new AuthGetOneRes());

	private UnknownFieldSet _unknownFields;

	private AccountProfile data_;

	public static MessageParser<AuthGetOneRes> Parser => _parser;

	public AccountProfile Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = value;
		}
	}

	public AuthGetOneRes()
	{
	}

	public AuthGetOneRes(AuthGetOneRes other)
		: this()
	{
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthGetOneRes Clone()
	{
		return new AuthGetOneRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthGetOneRes);
	}

	public bool Equals(AuthGetOneRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Data, other.Data))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (data_ != null)
		{
			num ^= Data.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (data_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Data);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (data_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Data);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthGetOneRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.data_ != null)
		{
			if (data_ == null)
			{
				Data = new AccountProfile();
			}
			Data.MergeFrom(other.Data);
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
			if (data_ == null)
			{
				Data = new AccountProfile();
			}
			input.ReadMessage(Data);
		}
	}
}
