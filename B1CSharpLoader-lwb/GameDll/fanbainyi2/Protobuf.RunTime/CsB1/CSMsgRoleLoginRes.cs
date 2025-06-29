using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoleLoginRes : IMessage<CSMsgRoleLoginRes>, IMessage, IEquatable<CSMsgRoleLoginRes>, IDeepCloneable<CSMsgRoleLoginRes>
{
	private static readonly MessageParser<CSMsgRoleLoginRes> _parser = new MessageParser<CSMsgRoleLoginRes>(() => new CSMsgRoleLoginRes());

	private UnknownFieldSet _unknownFields;

	private ulong onlineRoleid_;

	public static MessageParser<CSMsgRoleLoginRes> Parser => _parser;

	public ulong OnlineRoleid
	{
		get
		{
			return onlineRoleid_;
		}
		set
		{
			onlineRoleid_ = value;
		}
	}

	public CSMsgRoleLoginRes()
	{
	}

	public CSMsgRoleLoginRes(CSMsgRoleLoginRes other)
		: this()
	{
		onlineRoleid_ = other.onlineRoleid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoleLoginRes Clone()
	{
		return new CSMsgRoleLoginRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoleLoginRes);
	}

	public bool Equals(CSMsgRoleLoginRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OnlineRoleid != other.OnlineRoleid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (OnlineRoleid != 0L)
		{
			num ^= OnlineRoleid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (OnlineRoleid != 0L)
		{
			output.WriteRawTag(9);
			output.WriteFixed64(OnlineRoleid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (OnlineRoleid != 0L)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoleLoginRes other)
	{
		if (other != null)
		{
			if (other.OnlineRoleid != 0L)
			{
				OnlineRoleid = other.OnlineRoleid;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 9)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				OnlineRoleid = input.ReadFixed64();
			}
		}
	}
}
