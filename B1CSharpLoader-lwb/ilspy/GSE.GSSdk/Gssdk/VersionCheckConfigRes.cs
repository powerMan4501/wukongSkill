using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class VersionCheckConfigRes : IMessage<VersionCheckConfigRes>, IMessage, IEquatable<VersionCheckConfigRes>, IDeepCloneable<VersionCheckConfigRes>
{
	private static readonly MessageParser<VersionCheckConfigRes> _parser = new MessageParser<VersionCheckConfigRes>(() => new VersionCheckConfigRes());

	private UnknownFieldSet _unknownFields;

	private GssdkRet ret_;

	private static readonly FieldCodec<string> _repeated_patchCdnList_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> patchCdnList_ = new RepeatedField<string>();

	private string patchListUrl_ = "";

	private string serverEnv_ = "";

	private string binVersion_ = "";

	private string resVersion_ = "";

	private string curPkgMd5_ = "";

	private string baseBuildVersion_ = "";

	private string reviewBuildVersion_ = "";

	private static readonly FieldCodec<string> _repeated_envSdkServerList_codec = FieldCodec.ForString(82u);

	private readonly RepeatedField<string> envSdkServerList_ = new RepeatedField<string>();

	private string jsonExConfig_ = "";

	private string patchListContent_ = "";

	private static readonly FieldCodec<string> _repeated_serverJsonConfig_codec = FieldCodec.ForString(106u);

	private readonly RepeatedField<string> serverJsonConfig_ = new RepeatedField<string>();

	public static MessageParser<VersionCheckConfigRes> Parser => _parser;

	public GssdkRet Ret
	{
		get
		{
			return ret_;
		}
		set
		{
			ret_ = value;
		}
	}

	public RepeatedField<string> PatchCdnList => patchCdnList_;

	public string PatchListUrl
	{
		get
		{
			return patchListUrl_;
		}
		set
		{
			patchListUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ServerEnv
	{
		get
		{
			return serverEnv_;
		}
		set
		{
			serverEnv_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BinVersion
	{
		get
		{
			return binVersion_;
		}
		set
		{
			binVersion_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ResVersion
	{
		get
		{
			return resVersion_;
		}
		set
		{
			resVersion_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string CurPkgMd5
	{
		get
		{
			return curPkgMd5_;
		}
		set
		{
			curPkgMd5_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BaseBuildVersion
	{
		get
		{
			return baseBuildVersion_;
		}
		set
		{
			baseBuildVersion_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ReviewBuildVersion
	{
		get
		{
			return reviewBuildVersion_;
		}
		set
		{
			reviewBuildVersion_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> EnvSdkServerList => envSdkServerList_;

	public string JsonExConfig
	{
		get
		{
			return jsonExConfig_;
		}
		set
		{
			jsonExConfig_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PatchListContent
	{
		get
		{
			return patchListContent_;
		}
		set
		{
			patchListContent_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> ServerJsonConfig => serverJsonConfig_;

	public VersionCheckConfigRes()
	{
	}

	public VersionCheckConfigRes(VersionCheckConfigRes other)
		: this()
	{
		ret_ = ((other.ret_ != null) ? other.ret_.Clone() : null);
		patchCdnList_ = other.patchCdnList_.Clone();
		patchListUrl_ = other.patchListUrl_;
		serverEnv_ = other.serverEnv_;
		binVersion_ = other.binVersion_;
		resVersion_ = other.resVersion_;
		curPkgMd5_ = other.curPkgMd5_;
		baseBuildVersion_ = other.baseBuildVersion_;
		reviewBuildVersion_ = other.reviewBuildVersion_;
		envSdkServerList_ = other.envSdkServerList_.Clone();
		jsonExConfig_ = other.jsonExConfig_;
		patchListContent_ = other.patchListContent_;
		serverJsonConfig_ = other.serverJsonConfig_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionCheckConfigRes Clone()
	{
		return new VersionCheckConfigRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionCheckConfigRes);
	}

	public bool Equals(VersionCheckConfigRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Ret, other.Ret))
		{
			return false;
		}
		if (!patchCdnList_.Equals(other.patchCdnList_))
		{
			return false;
		}
		if (PatchListUrl != other.PatchListUrl)
		{
			return false;
		}
		if (ServerEnv != other.ServerEnv)
		{
			return false;
		}
		if (BinVersion != other.BinVersion)
		{
			return false;
		}
		if (ResVersion != other.ResVersion)
		{
			return false;
		}
		if (CurPkgMd5 != other.CurPkgMd5)
		{
			return false;
		}
		if (BaseBuildVersion != other.BaseBuildVersion)
		{
			return false;
		}
		if (ReviewBuildVersion != other.ReviewBuildVersion)
		{
			return false;
		}
		if (!envSdkServerList_.Equals(other.envSdkServerList_))
		{
			return false;
		}
		if (JsonExConfig != other.JsonExConfig)
		{
			return false;
		}
		if (PatchListContent != other.PatchListContent)
		{
			return false;
		}
		if (!serverJsonConfig_.Equals(other.serverJsonConfig_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ret_ != null)
		{
			num ^= Ret.GetHashCode();
		}
		num ^= patchCdnList_.GetHashCode();
		if (PatchListUrl.Length != 0)
		{
			num ^= PatchListUrl.GetHashCode();
		}
		if (ServerEnv.Length != 0)
		{
			num ^= ServerEnv.GetHashCode();
		}
		if (BinVersion.Length != 0)
		{
			num ^= BinVersion.GetHashCode();
		}
		if (ResVersion.Length != 0)
		{
			num ^= ResVersion.GetHashCode();
		}
		if (CurPkgMd5.Length != 0)
		{
			num ^= CurPkgMd5.GetHashCode();
		}
		if (BaseBuildVersion.Length != 0)
		{
			num ^= BaseBuildVersion.GetHashCode();
		}
		if (ReviewBuildVersion.Length != 0)
		{
			num ^= ReviewBuildVersion.GetHashCode();
		}
		num ^= envSdkServerList_.GetHashCode();
		if (JsonExConfig.Length != 0)
		{
			num ^= JsonExConfig.GetHashCode();
		}
		if (PatchListContent.Length != 0)
		{
			num ^= PatchListContent.GetHashCode();
		}
		num ^= serverJsonConfig_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ret_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Ret);
		}
		patchCdnList_.WriteTo(output, _repeated_patchCdnList_codec);
		if (PatchListUrl.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(PatchListUrl);
		}
		if (ServerEnv.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ServerEnv);
		}
		if (BinVersion.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(BinVersion);
		}
		if (ResVersion.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(ResVersion);
		}
		if (CurPkgMd5.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(CurPkgMd5);
		}
		if (BaseBuildVersion.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(BaseBuildVersion);
		}
		if (ReviewBuildVersion.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(ReviewBuildVersion);
		}
		envSdkServerList_.WriteTo(output, _repeated_envSdkServerList_codec);
		if (JsonExConfig.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(JsonExConfig);
		}
		if (PatchListContent.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(PatchListContent);
		}
		serverJsonConfig_.WriteTo(output, _repeated_serverJsonConfig_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ret_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Ret);
		}
		num += patchCdnList_.CalculateSize(_repeated_patchCdnList_codec);
		if (PatchListUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PatchListUrl);
		}
		if (ServerEnv.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ServerEnv);
		}
		if (BinVersion.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BinVersion);
		}
		if (ResVersion.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ResVersion);
		}
		if (CurPkgMd5.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CurPkgMd5);
		}
		if (BaseBuildVersion.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BaseBuildVersion);
		}
		if (ReviewBuildVersion.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ReviewBuildVersion);
		}
		num += envSdkServerList_.CalculateSize(_repeated_envSdkServerList_codec);
		if (JsonExConfig.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(JsonExConfig);
		}
		if (PatchListContent.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PatchListContent);
		}
		num += serverJsonConfig_.CalculateSize(_repeated_serverJsonConfig_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionCheckConfigRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ret_ != null)
		{
			if (ret_ == null)
			{
				Ret = new GssdkRet();
			}
			Ret.MergeFrom(other.Ret);
		}
		patchCdnList_.Add(other.patchCdnList_);
		if (other.PatchListUrl.Length != 0)
		{
			PatchListUrl = other.PatchListUrl;
		}
		if (other.ServerEnv.Length != 0)
		{
			ServerEnv = other.ServerEnv;
		}
		if (other.BinVersion.Length != 0)
		{
			BinVersion = other.BinVersion;
		}
		if (other.ResVersion.Length != 0)
		{
			ResVersion = other.ResVersion;
		}
		if (other.CurPkgMd5.Length != 0)
		{
			CurPkgMd5 = other.CurPkgMd5;
		}
		if (other.BaseBuildVersion.Length != 0)
		{
			BaseBuildVersion = other.BaseBuildVersion;
		}
		if (other.ReviewBuildVersion.Length != 0)
		{
			ReviewBuildVersion = other.ReviewBuildVersion;
		}
		envSdkServerList_.Add(other.envSdkServerList_);
		if (other.JsonExConfig.Length != 0)
		{
			JsonExConfig = other.JsonExConfig;
		}
		if (other.PatchListContent.Length != 0)
		{
			PatchListContent = other.PatchListContent;
		}
		serverJsonConfig_.Add(other.serverJsonConfig_);
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
				if (ret_ == null)
				{
					Ret = new GssdkRet();
				}
				input.ReadMessage(Ret);
				break;
			case 18u:
				patchCdnList_.AddEntriesFrom(input, _repeated_patchCdnList_codec);
				break;
			case 26u:
				PatchListUrl = input.ReadString();
				break;
			case 34u:
				ServerEnv = input.ReadString();
				break;
			case 42u:
				BinVersion = input.ReadString();
				break;
			case 50u:
				ResVersion = input.ReadString();
				break;
			case 58u:
				CurPkgMd5 = input.ReadString();
				break;
			case 66u:
				BaseBuildVersion = input.ReadString();
				break;
			case 74u:
				ReviewBuildVersion = input.ReadString();
				break;
			case 82u:
				envSdkServerList_.AddEntriesFrom(input, _repeated_envSdkServerList_codec);
				break;
			case 90u:
				JsonExConfig = input.ReadString();
				break;
			case 98u:
				PatchListContent = input.ReadString();
				break;
			case 106u:
				serverJsonConfig_.AddEntriesFrom(input, _repeated_serverJsonConfig_codec);
				break;
			}
		}
	}
}
