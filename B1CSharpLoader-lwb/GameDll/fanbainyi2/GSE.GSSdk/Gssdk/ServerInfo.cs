using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ServerInfo : IMessage<ServerInfo>, IMessage, IEquatable<ServerInfo>, IDeepCloneable<ServerInfo>
{
	private static readonly MessageParser<ServerInfo> _parser = new MessageParser<ServerInfo>(() => new ServerInfo());

	private UnknownFieldSet _unknownFields;

	private int serverId_;

	private string name_ = "";

	private string version_ = "";

	private int load_;

	private int level_;

	private string addr_ = "";

	private string flag_ = "";

	private string lastLogin_ = "";

	private string oaddr_ = "";

	private string alias_ = "";

	private int sort_;

	private int isopen_;

	public static MessageParser<ServerInfo> Parser => _parser;

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

	public string Flag
	{
		get
		{
			return flag_;
		}
		set
		{
			flag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LastLogin
	{
		get
		{
			return lastLogin_;
		}
		set
		{
			lastLogin_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Oaddr
	{
		get
		{
			return oaddr_;
		}
		set
		{
			oaddr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Alias
	{
		get
		{
			return alias_;
		}
		set
		{
			alias_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public int Isopen
	{
		get
		{
			return isopen_;
		}
		set
		{
			isopen_ = value;
		}
	}

	public ServerInfo()
	{
	}

	public ServerInfo(ServerInfo other)
		: this()
	{
		serverId_ = other.serverId_;
		name_ = other.name_;
		version_ = other.version_;
		load_ = other.load_;
		level_ = other.level_;
		addr_ = other.addr_;
		flag_ = other.flag_;
		lastLogin_ = other.lastLogin_;
		oaddr_ = other.oaddr_;
		alias_ = other.alias_;
		sort_ = other.sort_;
		isopen_ = other.isopen_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ServerInfo Clone()
	{
		return new ServerInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ServerInfo);
	}

	public bool Equals(ServerInfo other)
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
		if (Flag != other.Flag)
		{
			return false;
		}
		if (LastLogin != other.LastLogin)
		{
			return false;
		}
		if (Oaddr != other.Oaddr)
		{
			return false;
		}
		if (Alias != other.Alias)
		{
			return false;
		}
		if (Sort != other.Sort)
		{
			return false;
		}
		if (Isopen != other.Isopen)
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
		if (Flag.Length != 0)
		{
			num ^= Flag.GetHashCode();
		}
		if (LastLogin.Length != 0)
		{
			num ^= LastLogin.GetHashCode();
		}
		if (Oaddr.Length != 0)
		{
			num ^= Oaddr.GetHashCode();
		}
		if (Alias.Length != 0)
		{
			num ^= Alias.GetHashCode();
		}
		if (Sort != 0)
		{
			num ^= Sort.GetHashCode();
		}
		if (Isopen != 0)
		{
			num ^= Isopen.GetHashCode();
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
		if (Flag.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(Flag);
		}
		if (LastLogin.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(LastLogin);
		}
		if (Oaddr.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(Oaddr);
		}
		if (Alias.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(Alias);
		}
		if (Sort != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(Sort);
		}
		if (Isopen != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(Isopen);
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
		if (Flag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Flag);
		}
		if (LastLogin.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LastLogin);
		}
		if (Oaddr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Oaddr);
		}
		if (Alias.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Alias);
		}
		if (Sort != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Sort);
		}
		if (Isopen != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Isopen);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ServerInfo other)
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
			if (other.Flag.Length != 0)
			{
				Flag = other.Flag;
			}
			if (other.LastLogin.Length != 0)
			{
				LastLogin = other.LastLogin;
			}
			if (other.Oaddr.Length != 0)
			{
				Oaddr = other.Oaddr;
			}
			if (other.Alias.Length != 0)
			{
				Alias = other.Alias;
			}
			if (other.Sort != 0)
			{
				Sort = other.Sort;
			}
			if (other.Isopen != 0)
			{
				Isopen = other.Isopen;
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
			case 58u:
				Flag = input.ReadString();
				break;
			case 66u:
				LastLogin = input.ReadString();
				break;
			case 74u:
				Oaddr = input.ReadString();
				break;
			case 82u:
				Alias = input.ReadString();
				break;
			case 88u:
				Sort = input.ReadInt32();
				break;
			case 96u:
				Isopen = input.ReadInt32();
				break;
			}
		}
	}
}
