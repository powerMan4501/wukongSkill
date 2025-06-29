using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionGetCustomCfgReq : IMessage<VersionGetCustomCfgReq>, IMessage, IEquatable<VersionGetCustomCfgReq>, IDeepCloneable<VersionGetCustomCfgReq>
{
	private static readonly MessageParser<VersionGetCustomCfgReq> _parser = new MessageParser<VersionGetCustomCfgReq>(() => new VersionGetCustomCfgReq());

	private UnknownFieldSet _unknownFields;

	private int resv_;

	public static MessageParser<VersionGetCustomCfgReq> Parser => _parser;

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

	public VersionGetCustomCfgReq()
	{
	}

	public VersionGetCustomCfgReq(VersionGetCustomCfgReq other)
		: this()
	{
		resv_ = other.resv_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionGetCustomCfgReq Clone()
	{
		return new VersionGetCustomCfgReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionGetCustomCfgReq);
	}

	public bool Equals(VersionGetCustomCfgReq other)
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

	public void MergeFrom(VersionGetCustomCfgReq other)
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
