using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionChangePatchReq : IMessage<VersionChangePatchReq>, IMessage, IEquatable<VersionChangePatchReq>, IDeepCloneable<VersionChangePatchReq>
{
	private static readonly MessageParser<VersionChangePatchReq> _parser = new MessageParser<VersionChangePatchReq>(() => new VersionChangePatchReq());

	private UnknownFieldSet _unknownFields;

	private string env_ = "";

	private string platform_ = "";

	private string ver_ = "";

	private int stInuse_;

	private int stGray_;

	private string verBase_ = "";

	private string verFile_ = "";

	public static MessageParser<VersionChangePatchReq> Parser => _parser;

	public string Env
	{
		get
		{
			return env_;
		}
		set
		{
			env_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Platform
	{
		get
		{
			return platform_;
		}
		set
		{
			platform_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Ver
	{
		get
		{
			return ver_;
		}
		set
		{
			ver_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int StInuse
	{
		get
		{
			return stInuse_;
		}
		set
		{
			stInuse_ = value;
		}
	}

	public int StGray
	{
		get
		{
			return stGray_;
		}
		set
		{
			stGray_ = value;
		}
	}

	public string VerBase
	{
		get
		{
			return verBase_;
		}
		set
		{
			verBase_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string VerFile
	{
		get
		{
			return verFile_;
		}
		set
		{
			verFile_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public VersionChangePatchReq()
	{
	}

	public VersionChangePatchReq(VersionChangePatchReq other)
		: this()
	{
		env_ = other.env_;
		platform_ = other.platform_;
		ver_ = other.ver_;
		stInuse_ = other.stInuse_;
		stGray_ = other.stGray_;
		verBase_ = other.verBase_;
		verFile_ = other.verFile_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionChangePatchReq Clone()
	{
		return new VersionChangePatchReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionChangePatchReq);
	}

	public bool Equals(VersionChangePatchReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Env != other.Env)
		{
			return false;
		}
		if (Platform != other.Platform)
		{
			return false;
		}
		if (Ver != other.Ver)
		{
			return false;
		}
		if (StInuse != other.StInuse)
		{
			return false;
		}
		if (StGray != other.StGray)
		{
			return false;
		}
		if (VerBase != other.VerBase)
		{
			return false;
		}
		if (VerFile != other.VerFile)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Env.Length != 0)
		{
			num ^= Env.GetHashCode();
		}
		if (Platform.Length != 0)
		{
			num ^= Platform.GetHashCode();
		}
		if (Ver.Length != 0)
		{
			num ^= Ver.GetHashCode();
		}
		if (StInuse != 0)
		{
			num ^= StInuse.GetHashCode();
		}
		if (StGray != 0)
		{
			num ^= StGray.GetHashCode();
		}
		if (VerBase.Length != 0)
		{
			num ^= VerBase.GetHashCode();
		}
		if (VerFile.Length != 0)
		{
			num ^= VerFile.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Env.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Env);
		}
		if (Platform.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Platform);
		}
		if (Ver.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Ver);
		}
		if (StInuse != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(StInuse);
		}
		if (StGray != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(StGray);
		}
		if (VerBase.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(VerBase);
		}
		if (VerFile.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(VerFile);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Env.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Env);
		}
		if (Platform.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Platform);
		}
		if (Ver.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Ver);
		}
		if (StInuse != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StInuse);
		}
		if (StGray != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StGray);
		}
		if (VerBase.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VerBase);
		}
		if (VerFile.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VerFile);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionChangePatchReq other)
	{
		if (other != null)
		{
			if (other.Env.Length != 0)
			{
				Env = other.Env;
			}
			if (other.Platform.Length != 0)
			{
				Platform = other.Platform;
			}
			if (other.Ver.Length != 0)
			{
				Ver = other.Ver;
			}
			if (other.StInuse != 0)
			{
				StInuse = other.StInuse;
			}
			if (other.StGray != 0)
			{
				StGray = other.StGray;
			}
			if (other.VerBase.Length != 0)
			{
				VerBase = other.VerBase;
			}
			if (other.VerFile.Length != 0)
			{
				VerFile = other.VerFile;
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
				Env = input.ReadString();
				break;
			case 18u:
				Platform = input.ReadString();
				break;
			case 26u:
				Ver = input.ReadString();
				break;
			case 32u:
				StInuse = input.ReadInt32();
				break;
			case 40u:
				StGray = input.ReadInt32();
				break;
			case 50u:
				VerBase = input.ReadString();
				break;
			case 58u:
				VerFile = input.ReadString();
				break;
			}
		}
	}
}
