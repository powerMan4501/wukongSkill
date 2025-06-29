using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthGetCustomCfgReq : IMessage<AuthGetCustomCfgReq>, IMessage, IEquatable<AuthGetCustomCfgReq>, IDeepCloneable<AuthGetCustomCfgReq>
{
	private static readonly MessageParser<AuthGetCustomCfgReq> _parser = new MessageParser<AuthGetCustomCfgReq>(() => new AuthGetCustomCfgReq());

	private UnknownFieldSet _unknownFields;

	private int resv_;

	public static MessageParser<AuthGetCustomCfgReq> Parser => _parser;

	public int Resv
	{
		get
		{
			return resv_;
		}
		set
		{
			resv_ = value;
		}
	}

	public AuthGetCustomCfgReq()
	{
	}

	public AuthGetCustomCfgReq(AuthGetCustomCfgReq other)
		: this()
	{
		resv_ = other.resv_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthGetCustomCfgReq Clone()
	{
		return new AuthGetCustomCfgReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthGetCustomCfgReq);
	}

	public bool Equals(AuthGetCustomCfgReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Resv != other.Resv)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Resv != 0)
		{
			num ^= Resv.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Resv != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Resv);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Resv != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Resv);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthGetCustomCfgReq other)
	{
		if (other != null)
		{
			if (other.Resv != 0)
			{
				Resv = other.Resv;
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
				Resv = input.ReadInt32();
			}
		}
	}
}
