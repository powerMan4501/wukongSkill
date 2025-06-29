using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class DirGetOneReq : IMessage<DirGetOneReq>, IMessage, IEquatable<DirGetOneReq>, IDeepCloneable<DirGetOneReq>
{
	private static readonly MessageParser<DirGetOneReq> _parser = new MessageParser<DirGetOneReq>(() => new DirGetOneReq());

	private UnknownFieldSet _unknownFields;

	private int serverId_;

	public static MessageParser<DirGetOneReq> Parser => _parser;

	public int ServerId
	{
		get
		{
			return serverId_;
		}
		set
		{
			serverId_ = value;
		}
	}

	public DirGetOneReq()
	{
	}

	public DirGetOneReq(DirGetOneReq other)
		: this()
	{
		serverId_ = other.serverId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DirGetOneReq Clone()
	{
		return new DirGetOneReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DirGetOneReq);
	}

	public bool Equals(DirGetOneReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ServerId != other.ServerId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ServerId != 0)
		{
			num ^= ServerId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ServerId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ServerId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ServerId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ServerId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DirGetOneReq other)
	{
		if (other != null)
		{
			if (other.ServerId != 0)
			{
				ServerId = other.ServerId;
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
				ServerId = input.ReadInt32();
			}
		}
	}
}
