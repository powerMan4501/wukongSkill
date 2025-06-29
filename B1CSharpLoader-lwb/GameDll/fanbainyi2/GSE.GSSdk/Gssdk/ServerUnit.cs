using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ServerUnit : IMessage<ServerUnit>, IMessage, IEquatable<ServerUnit>, IDeepCloneable<ServerUnit>
{
	private static readonly MessageParser<ServerUnit> _parser = new MessageParser<ServerUnit>(() => new ServerUnit());

	private UnknownFieldSet _unknownFields;

	private int serverId_;

	private string name_ = "";

	private string version_ = "";

	private int load_;

	private int level_;

	private string addr_ = "";

	private int sort_;

	public static MessageParser<ServerUnit> Parser => _parser;

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

	public string Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Load
	{
		get
		{
			return load_;
		}
		set
		{
			load_ = value;
		}
	}

	public int Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	public string Addr
	{
		get
		{
			return addr_;
		}
		set
		{
			addr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Sort
	{
		get
		{
			return sort_;
		}
		set
		{
			sort_ = value;
		}
	}

	public ServerUnit()
	{
	}

	public ServerUnit(ServerUnit other)
		: this()
	{
		serverId_ = other.serverId_;
		name_ = other.name_;
		version_ = other.version_;
		load_ = other.load_;
		level_ = other.level_;
		addr_ = other.addr_;
		sort_ = other.sort_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ServerUnit Clone()
	{
		return new ServerUnit(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ServerUnit);
	}

	public bool Equals(ServerUnit other)
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
		if (Name != other.Name)
		{
			return false;
		}
		if (Version != other.Version)
		{
			return false;
		}
		if (Load != other.Load)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Addr != other.Addr)
		{
			return false;
		}
		if (Sort != other.Sort)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Version.Length != 0)
		{
			num ^= Version.GetHashCode();
		}
		if (Load != 0)
		{
			num ^= Load.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Addr.Length != 0)
		{
			num ^= Addr.GetHashCode();
		}
		if (Sort != 0)
		{
			num ^= Sort.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (Version.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Version);
		}
		if (Load != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Load);
		}
		if (Level != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Level);
		}
		if (Addr.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Addr);
		}
		if (Sort != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Sort);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Version.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Version);
		}
		if (Load != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Load);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (Addr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Addr);
		}
		if (Sort != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Sort);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ServerUnit other)
	{
		if (other != null)
		{
			if (other.ServerId != 0)
			{
				ServerId = other.ServerId;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Version.Length != 0)
			{
				Version = other.Version;
			}
			if (other.Load != 0)
			{
				Load = other.Load;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Addr.Length != 0)
			{
				Addr = other.Addr;
			}
			if (other.Sort != 0)
			{
				Sort = other.Sort;
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
				ServerId = input.ReadInt32();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 26u:
				Version = input.ReadString();
				break;
			case 32u:
				Load = input.ReadInt32();
				break;
			case 40u:
				Level = input.ReadInt32();
				break;
			case 50u:
				Addr = input.ReadString();
				break;
			case 56u:
				Sort = input.ReadInt32();
				break;
			}
		}
	}
}
