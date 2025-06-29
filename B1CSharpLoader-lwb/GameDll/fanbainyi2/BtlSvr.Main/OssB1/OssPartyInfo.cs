using System;
using Google.Protobuf;

namespace OssB1;

public sealed class OssPartyInfo : IMessage<OssPartyInfo>, IMessage, IEquatable<OssPartyInfo>, IDeepCloneable<OssPartyInfo>
{
	private static readonly MessageParser<OssPartyInfo> _parser = new MessageParser<OssPartyInfo>(() => new OssPartyInfo());

	private UnknownFieldSet _unknownFields;

	private ulong partyId_;

	public static MessageParser<OssPartyInfo> Parser => _parser;

	public ulong PartyId
	{
		get
		{
			return partyId_;
		}
		set
		{
			partyId_ = value;
		}
	}

	public OssPartyInfo()
	{
	}

	public OssPartyInfo(OssPartyInfo other)
		: this()
	{
		partyId_ = other.partyId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public OssPartyInfo Clone()
	{
		return new OssPartyInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as OssPartyInfo);
	}

	public bool Equals(OssPartyInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PartyId != other.PartyId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PartyId != 0L)
		{
			num ^= PartyId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PartyId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(PartyId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PartyId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PartyId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(OssPartyInfo other)
	{
		if (other != null)
		{
			if (other.PartyId != 0L)
			{
				PartyId = other.PartyId;
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
				PartyId = input.ReadUInt64();
			}
		}
	}
}
