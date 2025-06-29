using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class UserClientSetting : IMessage<UserClientSetting>, IMessage, IEquatable<UserClientSetting>, IDeepCloneable<UserClientSetting>
{
	private static readonly MessageParser<UserClientSetting> _parser = new MessageParser<UserClientSetting>(() => new UserClientSetting());

	private UnknownFieldSet _unknownFields;

	private string appChannel_ = "";

	private string appVersion_ = "";

	private int buildRevision_;

	private string gitCodeRevision_ = "";

	private int p4ProjRevision_;

	private int p4EngineRevision_;

	private string buildTime_ = "";

	private string pkgTag_ = "";

	private string language_ = "";

	private string region_ = "";

	private int tzOffset_;

	private string playMode_ = "";

	private string env_ = "";

	private string branch_ = "";

	private string graphicApi_ = "";

	private string vcRedist_ = "";

	private string cultureDesc_ = "";

	public static MessageParser<UserClientSetting> Parser => _parser;

	public string AppChannel
	{
		get
		{
			return appChannel_;
		}
		set
		{
			appChannel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AppVersion
	{
		get
		{
			return appVersion_;
		}
		set
		{
			appVersion_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int BuildRevision
	{
		get
		{
			return buildRevision_;
		}
		set
		{
			buildRevision_ = value;
		}
	}

	public string GitCodeRevision
	{
		get
		{
			return gitCodeRevision_;
		}
		set
		{
			gitCodeRevision_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int P4ProjRevision
	{
		get
		{
			return p4ProjRevision_;
		}
		set
		{
			p4ProjRevision_ = value;
		}
	}

	public int P4EngineRevision
	{
		get
		{
			return p4EngineRevision_;
		}
		set
		{
			p4EngineRevision_ = value;
		}
	}

	public string BuildTime
	{
		get
		{
			return buildTime_;
		}
		set
		{
			buildTime_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PkgTag
	{
		get
		{
			return pkgTag_;
		}
		set
		{
			pkgTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Language
	{
		get
		{
			return language_;
		}
		set
		{
			language_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Region
	{
		get
		{
			return region_;
		}
		set
		{
			region_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TzOffset
	{
		get
		{
			return tzOffset_;
		}
		set
		{
			tzOffset_ = value;
		}
	}

	public string PlayMode
	{
		get
		{
			return playMode_;
		}
		set
		{
			playMode_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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

	public string Branch
	{
		get
		{
			return branch_;
		}
		set
		{
			branch_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string GraphicApi
	{
		get
		{
			return graphicApi_;
		}
		set
		{
			graphicApi_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string VcRedist
	{
		get
		{
			return vcRedist_;
		}
		set
		{
			vcRedist_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string CultureDesc
	{
		get
		{
			return cultureDesc_;
		}
		set
		{
			cultureDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public UserClientSetting()
	{
	}

	public UserClientSetting(UserClientSetting other)
		: this()
	{
		appChannel_ = other.appChannel_;
		appVersion_ = other.appVersion_;
		buildRevision_ = other.buildRevision_;
		gitCodeRevision_ = other.gitCodeRevision_;
		p4ProjRevision_ = other.p4ProjRevision_;
		p4EngineRevision_ = other.p4EngineRevision_;
		buildTime_ = other.buildTime_;
		pkgTag_ = other.pkgTag_;
		language_ = other.language_;
		region_ = other.region_;
		tzOffset_ = other.tzOffset_;
		playMode_ = other.playMode_;
		env_ = other.env_;
		branch_ = other.branch_;
		graphicApi_ = other.graphicApi_;
		vcRedist_ = other.vcRedist_;
		cultureDesc_ = other.cultureDesc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UserClientSetting Clone()
	{
		return new UserClientSetting(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UserClientSetting);
	}

	public bool Equals(UserClientSetting other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AppChannel != other.AppChannel)
		{
			return false;
		}
		if (AppVersion != other.AppVersion)
		{
			return false;
		}
		if (BuildRevision != other.BuildRevision)
		{
			return false;
		}
		if (GitCodeRevision != other.GitCodeRevision)
		{
			return false;
		}
		if (P4ProjRevision != other.P4ProjRevision)
		{
			return false;
		}
		if (P4EngineRevision != other.P4EngineRevision)
		{
			return false;
		}
		if (BuildTime != other.BuildTime)
		{
			return false;
		}
		if (PkgTag != other.PkgTag)
		{
			return false;
		}
		if (Language != other.Language)
		{
			return false;
		}
		if (Region != other.Region)
		{
			return false;
		}
		if (TzOffset != other.TzOffset)
		{
			return false;
		}
		if (PlayMode != other.PlayMode)
		{
			return false;
		}
		if (Env != other.Env)
		{
			return false;
		}
		if (Branch != other.Branch)
		{
			return false;
		}
		if (GraphicApi != other.GraphicApi)
		{
			return false;
		}
		if (VcRedist != other.VcRedist)
		{
			return false;
		}
		if (CultureDesc != other.CultureDesc)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AppChannel.Length != 0)
		{
			num ^= AppChannel.GetHashCode();
		}
		if (AppVersion.Length != 0)
		{
			num ^= AppVersion.GetHashCode();
		}
		if (BuildRevision != 0)
		{
			num ^= BuildRevision.GetHashCode();
		}
		if (GitCodeRevision.Length != 0)
		{
			num ^= GitCodeRevision.GetHashCode();
		}
		if (P4ProjRevision != 0)
		{
			num ^= P4ProjRevision.GetHashCode();
		}
		if (P4EngineRevision != 0)
		{
			num ^= P4EngineRevision.GetHashCode();
		}
		if (BuildTime.Length != 0)
		{
			num ^= BuildTime.GetHashCode();
		}
		if (PkgTag.Length != 0)
		{
			num ^= PkgTag.GetHashCode();
		}
		if (Language.Length != 0)
		{
			num ^= Language.GetHashCode();
		}
		if (Region.Length != 0)
		{
			num ^= Region.GetHashCode();
		}
		if (TzOffset != 0)
		{
			num ^= TzOffset.GetHashCode();
		}
		if (PlayMode.Length != 0)
		{
			num ^= PlayMode.GetHashCode();
		}
		if (Env.Length != 0)
		{
			num ^= Env.GetHashCode();
		}
		if (Branch.Length != 0)
		{
			num ^= Branch.GetHashCode();
		}
		if (GraphicApi.Length != 0)
		{
			num ^= GraphicApi.GetHashCode();
		}
		if (VcRedist.Length != 0)
		{
			num ^= VcRedist.GetHashCode();
		}
		if (CultureDesc.Length != 0)
		{
			num ^= CultureDesc.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AppChannel.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AppChannel);
		}
		if (AppVersion.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AppVersion);
		}
		if (BuildRevision != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BuildRevision);
		}
		if (GitCodeRevision.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(GitCodeRevision);
		}
		if (P4ProjRevision != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(P4ProjRevision);
		}
		if (P4EngineRevision != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(P4EngineRevision);
		}
		if (BuildTime.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(BuildTime);
		}
		if (PkgTag.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(PkgTag);
		}
		if (Language.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(Language);
		}
		if (Region.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(Region);
		}
		if (TzOffset != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(TzOffset);
		}
		if (PlayMode.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(PlayMode);
		}
		if (Env.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(Env);
		}
		if (Branch.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(Branch);
		}
		if (GraphicApi.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(GraphicApi);
		}
		if (VcRedist.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(VcRedist);
		}
		if (CultureDesc.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(CultureDesc);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AppChannel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AppChannel);
		}
		if (AppVersion.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AppVersion);
		}
		if (BuildRevision != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuildRevision);
		}
		if (GitCodeRevision.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GitCodeRevision);
		}
		if (P4ProjRevision != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(P4ProjRevision);
		}
		if (P4EngineRevision != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(P4EngineRevision);
		}
		if (BuildTime.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BuildTime);
		}
		if (PkgTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PkgTag);
		}
		if (Language.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Language);
		}
		if (Region.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Region);
		}
		if (TzOffset != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TzOffset);
		}
		if (PlayMode.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PlayMode);
		}
		if (Env.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Env);
		}
		if (Branch.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Branch);
		}
		if (GraphicApi.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GraphicApi);
		}
		if (VcRedist.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(VcRedist);
		}
		if (CultureDesc.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(CultureDesc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UserClientSetting other)
	{
		if (other != null)
		{
			if (other.AppChannel.Length != 0)
			{
				AppChannel = other.AppChannel;
			}
			if (other.AppVersion.Length != 0)
			{
				AppVersion = other.AppVersion;
			}
			if (other.BuildRevision != 0)
			{
				BuildRevision = other.BuildRevision;
			}
			if (other.GitCodeRevision.Length != 0)
			{
				GitCodeRevision = other.GitCodeRevision;
			}
			if (other.P4ProjRevision != 0)
			{
				P4ProjRevision = other.P4ProjRevision;
			}
			if (other.P4EngineRevision != 0)
			{
				P4EngineRevision = other.P4EngineRevision;
			}
			if (other.BuildTime.Length != 0)
			{
				BuildTime = other.BuildTime;
			}
			if (other.PkgTag.Length != 0)
			{
				PkgTag = other.PkgTag;
			}
			if (other.Language.Length != 0)
			{
				Language = other.Language;
			}
			if (other.Region.Length != 0)
			{
				Region = other.Region;
			}
			if (other.TzOffset != 0)
			{
				TzOffset = other.TzOffset;
			}
			if (other.PlayMode.Length != 0)
			{
				PlayMode = other.PlayMode;
			}
			if (other.Env.Length != 0)
			{
				Env = other.Env;
			}
			if (other.Branch.Length != 0)
			{
				Branch = other.Branch;
			}
			if (other.GraphicApi.Length != 0)
			{
				GraphicApi = other.GraphicApi;
			}
			if (other.VcRedist.Length != 0)
			{
				VcRedist = other.VcRedist;
			}
			if (other.CultureDesc.Length != 0)
			{
				CultureDesc = other.CultureDesc;
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
				AppChannel = input.ReadString();
				break;
			case 18u:
				AppVersion = input.ReadString();
				break;
			case 24u:
				BuildRevision = input.ReadInt32();
				break;
			case 34u:
				GitCodeRevision = input.ReadString();
				break;
			case 40u:
				P4ProjRevision = input.ReadInt32();
				break;
			case 48u:
				P4EngineRevision = input.ReadInt32();
				break;
			case 58u:
				BuildTime = input.ReadString();
				break;
			case 66u:
				PkgTag = input.ReadString();
				break;
			case 74u:
				Language = input.ReadString();
				break;
			case 82u:
				Region = input.ReadString();
				break;
			case 88u:
				TzOffset = input.ReadInt32();
				break;
			case 98u:
				PlayMode = input.ReadString();
				break;
			case 106u:
				Env = input.ReadString();
				break;
			case 114u:
				Branch = input.ReadString();
				break;
			case 122u:
				GraphicApi = input.ReadString();
				break;
			case 130u:
				VcRedist = input.ReadString();
				break;
			case 138u:
				CultureDesc = input.ReadString();
				break;
			}
		}
	}
}
