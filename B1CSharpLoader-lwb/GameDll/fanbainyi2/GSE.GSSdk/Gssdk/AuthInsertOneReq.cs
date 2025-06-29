using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthInsertOneReq : IMessage<AuthInsertOneReq>, IMessage, IEquatable<AuthInsertOneReq>, IDeepCloneable<AuthInsertOneReq>
{
	private static readonly MessageParser<AuthInsertOneReq> _parser = new MessageParser<AuthInsertOneReq>(() => new AuthInsertOneReq());

	private UnknownFieldSet _unknownFields;

	private AccountProfile info_;

	public static MessageParser<AuthInsertOneReq> Parser => _parser;

	public AccountProfile Info
	{
		get
		{
			return info_;
		}
		set
		{
			info_ = value;
		}
	}

	public AuthInsertOneReq()
	{
	}

	public AuthInsertOneReq(AuthInsertOneReq other)
		: this()
	{
		info_ = ((other.info_ != null) ? other.info_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthInsertOneReq Clone()
	{
		return new AuthInsertOneReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthInsertOneReq);
	}

	public bool Equals(AuthInsertOneReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Info, other.Info))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (info_ != null)
		{
			num ^= Info.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (info_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Info);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (info_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Info);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthInsertOneReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.info_ != null)
		{
			if (info_ == null)
			{
				Info = new AccountProfile();
			}
			Info.MergeFrom(other.Info);
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
			if (info_ == null)
			{
				Info = new AccountProfile();
			}
			input.ReadMessage(Info);
		}
	}
}
