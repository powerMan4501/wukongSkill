using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagHuluUpgradeReq : IMessage<CSMsgBagHuluUpgradeReq>, IMessage, IEquatable<CSMsgBagHuluUpgradeReq>, IDeepCloneable<CSMsgBagHuluUpgradeReq>
{
	private static readonly MessageParser<CSMsgBagHuluUpgradeReq> _parser = new MessageParser<CSMsgBagHuluUpgradeReq>(() => new CSMsgBagHuluUpgradeReq());

	private UnknownFieldSet _unknownFields;

	private ulong uid_;

	public static MessageParser<CSMsgBagHuluUpgradeReq> Parser => _parser;

	public ulong Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	public CSMsgBagHuluUpgradeReq()
	{
	}

	public CSMsgBagHuluUpgradeReq(CSMsgBagHuluUpgradeReq other)
		: this()
	{
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagHuluUpgradeReq Clone()
	{
		return new CSMsgBagHuluUpgradeReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagHuluUpgradeReq);
	}

	public bool Equals(CSMsgBagHuluUpgradeReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Uid != 0L)
		{
			num ^= Uid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Uid != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(Uid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Uid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagHuluUpgradeReq other)
	{
		if (other != null)
		{
			if (other.Uid != 0L)
			{
				Uid = other.Uid;
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
				Uid = input.ReadUInt64();
			}
		}
	}
}
