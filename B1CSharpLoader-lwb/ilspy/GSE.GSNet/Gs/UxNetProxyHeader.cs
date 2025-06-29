using System;
using Google.Protobuf;

namespace Gs;

public sealed class UxNetProxyHeader : IMessage<UxNetProxyHeader>, IMessage, IEquatable<UxNetProxyHeader>, IDeepCloneable<UxNetProxyHeader>
{
	private static readonly MessageParser<UxNetProxyHeader> _parser = new MessageParser<UxNetProxyHeader>(() => new UxNetProxyHeader());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private string clientEp_ = "";

	private ulong dsAuthToken_;

	public static MessageParser<UxNetProxyHeader> Parser => _parser;

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public string ClientEp
	{
		get
		{
			return clientEp_;
		}
		set
		{
			clientEp_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ulong DsAuthToken
	{
		get
		{
			return dsAuthToken_;
		}
		set
		{
			dsAuthToken_ = value;
		}
	}

	public UxNetProxyHeader()
	{
	}

	public UxNetProxyHeader(UxNetProxyHeader other)
		: this()
	{
		roleId_ = other.roleId_;
		clientEp_ = other.clientEp_;
		dsAuthToken_ = other.dsAuthToken_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UxNetProxyHeader Clone()
	{
		return new UxNetProxyHeader(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UxNetProxyHeader);
	}

	public bool Equals(UxNetProxyHeader other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (ClientEp != other.ClientEp)
		{
			return false;
		}
		if (DsAuthToken != other.DsAuthToken)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		if (ClientEp.Length != 0)
		{
			num ^= ClientEp.GetHashCode();
		}
		if (DsAuthToken != 0L)
		{
			num ^= DsAuthToken.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoleId);
		}
		if (ClientEp.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ClientEp);
		}
		if (DsAuthToken != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(DsAuthToken);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (ClientEp.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ClientEp);
		}
		if (DsAuthToken != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(DsAuthToken);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UxNetProxyHeader other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.ClientEp.Length != 0)
			{
				ClientEp = other.ClientEp;
			}
			if (other.DsAuthToken != 0L)
			{
				DsAuthToken = other.DsAuthToken;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				RoleId = input.ReadUInt64();
				break;
			case 18u:
				ClientEp = input.ReadString();
				break;
			case 24u:
				DsAuthToken = input.ReadUInt64();
				break;
			}
		}
	}
}
