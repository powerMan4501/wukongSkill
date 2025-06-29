using System;
using Google.Protobuf;

namespace Gs;

public sealed class UxNetUdpAsk : IMessage<UxNetUdpAsk>, IMessage, IEquatable<UxNetUdpAsk>, IDeepCloneable<UxNetUdpAsk>
{
	private static readonly MessageParser<UxNetUdpAsk> _parser = new MessageParser<UxNetUdpAsk>(() => new UxNetUdpAsk());

	private UnknownFieldSet _unknownFields;

	private string connectHost_ = "";

	private uint port_;

	public static MessageParser<UxNetUdpAsk> Parser => _parser;

	public string ConnectHost
	{
		get
		{
			return connectHost_;
		}
		set
		{
			connectHost_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint Port
	{
		get
		{
			return port_;
		}
		set
		{
			port_ = value;
		}
	}

	public UxNetUdpAsk()
	{
	}

	public UxNetUdpAsk(UxNetUdpAsk other)
		: this()
	{
		connectHost_ = other.connectHost_;
		port_ = other.port_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UxNetUdpAsk Clone()
	{
		return new UxNetUdpAsk(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UxNetUdpAsk);
	}

	public bool Equals(UxNetUdpAsk other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConnectHost != other.ConnectHost)
		{
			return false;
		}
		if (Port != other.Port)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConnectHost.Length != 0)
		{
			num ^= ConnectHost.GetHashCode();
		}
		if (Port != 0)
		{
			num ^= Port.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConnectHost.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ConnectHost);
		}
		if (Port != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Port);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConnectHost.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConnectHost);
		}
		if (Port != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Port);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UxNetUdpAsk other)
	{
		if (other != null)
		{
			if (other.ConnectHost.Length != 0)
			{
				ConnectHost = other.ConnectHost;
			}
			if (other.Port != 0)
			{
				Port = other.Port;
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
			case 10u:
				ConnectHost = input.ReadString();
				break;
			case 16u:
				Port = input.ReadUInt32();
				break;
			}
		}
	}
}
