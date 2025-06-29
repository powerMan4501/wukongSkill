using System;
using Google.Protobuf;

namespace CommB1;

public sealed class NetioSessionEnv : IMessage<NetioSessionEnv>, IMessage, IEquatable<NetioSessionEnv>, IDeepCloneable<NetioSessionEnv>
{
	private static readonly MessageParser<NetioSessionEnv> _parser = new MessageParser<NetioSessionEnv>(() => new NetioSessionEnv());

	private UnknownFieldSet _unknownFields;

	private ConnxEnv connxEnv_;

	private LoginEnv loginEnv_;

	private bool isProxied_;

	private ulong proxyAuthCookie_;

	public static MessageParser<NetioSessionEnv> Parser => _parser;

	public ConnxEnv ConnxEnv
	{
		get
		{
			return connxEnv_;
		}
		set
		{
			connxEnv_ = value;
		}
	}

	public LoginEnv LoginEnv
	{
		get
		{
			return loginEnv_;
		}
		set
		{
			loginEnv_ = value;
		}
	}

	public bool IsProxied
	{
		get
		{
			return isProxied_;
		}
		set
		{
			isProxied_ = value;
		}
	}

	public ulong ProxyAuthCookie
	{
		get
		{
			return proxyAuthCookie_;
		}
		set
		{
			proxyAuthCookie_ = value;
		}
	}

	public NetioSessionEnv()
	{
	}

	public NetioSessionEnv(NetioSessionEnv other)
		: this()
	{
		connxEnv_ = ((other.connxEnv_ != null) ? other.connxEnv_.Clone() : null);
		loginEnv_ = ((other.loginEnv_ != null) ? other.loginEnv_.Clone() : null);
		isProxied_ = other.isProxied_;
		proxyAuthCookie_ = other.proxyAuthCookie_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public NetioSessionEnv Clone()
	{
		return new NetioSessionEnv(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as NetioSessionEnv);
	}

	public bool Equals(NetioSessionEnv other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ConnxEnv, other.ConnxEnv))
		{
			return false;
		}
		if (!object.Equals(LoginEnv, other.LoginEnv))
		{
			return false;
		}
		if (IsProxied != other.IsProxied)
		{
			return false;
		}
		if (ProxyAuthCookie != other.ProxyAuthCookie)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (connxEnv_ != null)
		{
			num ^= ConnxEnv.GetHashCode();
		}
		if (loginEnv_ != null)
		{
			num ^= LoginEnv.GetHashCode();
		}
		if (IsProxied)
		{
			num ^= IsProxied.GetHashCode();
		}
		if (ProxyAuthCookie != 0L)
		{
			num ^= ProxyAuthCookie.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (connxEnv_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ConnxEnv);
		}
		if (loginEnv_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(LoginEnv);
		}
		if (IsProxied)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsProxied);
		}
		if (ProxyAuthCookie != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(ProxyAuthCookie);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (connxEnv_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ConnxEnv);
		}
		if (loginEnv_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LoginEnv);
		}
		if (IsProxied)
		{
			num += 2;
		}
		if (ProxyAuthCookie != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ProxyAuthCookie);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(NetioSessionEnv other)
	{
		if (other == null)
		{
			return;
		}
		if (other.connxEnv_ != null)
		{
			if (connxEnv_ == null)
			{
				ConnxEnv = new ConnxEnv();
			}
			ConnxEnv.MergeFrom(other.ConnxEnv);
		}
		if (other.loginEnv_ != null)
		{
			if (loginEnv_ == null)
			{
				LoginEnv = new LoginEnv();
			}
			LoginEnv.MergeFrom(other.LoginEnv);
		}
		if (other.IsProxied)
		{
			IsProxied = other.IsProxied;
		}
		if (other.ProxyAuthCookie != 0L)
		{
			ProxyAuthCookie = other.ProxyAuthCookie;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (connxEnv_ == null)
				{
					ConnxEnv = new ConnxEnv();
				}
				input.ReadMessage(ConnxEnv);
				break;
			case 18u:
				if (loginEnv_ == null)
				{
					LoginEnv = new LoginEnv();
				}
				input.ReadMessage(LoginEnv);
				break;
			case 24u:
				IsProxied = input.ReadBool();
				break;
			case 32u:
				ProxyAuthCookie = input.ReadUInt64();
				break;
			}
		}
	}
}
