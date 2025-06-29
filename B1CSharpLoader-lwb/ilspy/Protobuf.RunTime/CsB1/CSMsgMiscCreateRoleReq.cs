using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgMiscCreateRoleReq : IMessage<CSMsgMiscCreateRoleReq>, IMessage, IEquatable<CSMsgMiscCreateRoleReq>, IDeepCloneable<CSMsgMiscCreateRoleReq>
{
	private static readonly MessageParser<CSMsgMiscCreateRoleReq> _parser = new MessageParser<CSMsgMiscCreateRoleReq>(() => new CSMsgMiscCreateRoleReq());

	private UnknownFieldSet _unknownFields;

	private string name_ = "";

	public static MessageParser<CSMsgMiscCreateRoleReq> Parser => _parser;

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CSMsgMiscCreateRoleReq()
	{
	}

	public CSMsgMiscCreateRoleReq(CSMsgMiscCreateRoleReq other)
		: this()
	{
		name_ = other.name_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMiscCreateRoleReq Clone()
	{
		return new CSMsgMiscCreateRoleReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMiscCreateRoleReq);
	}

	public bool Equals(CSMsgMiscCreateRoleReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Name.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Name);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgMiscCreateRoleReq other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				Name = input.ReadString();
			}
		}
	}
}
