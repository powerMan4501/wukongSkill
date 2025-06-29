using System;
using Google.Protobuf;

namespace Gs;

public sealed class UxNetConnxEnv : IMessage<UxNetConnxEnv>, IMessage, IEquatable<UxNetConnxEnv>, IDeepCloneable<UxNetConnxEnv>
{
	private static readonly MessageParser<UxNetConnxEnv> _parser = new MessageParser<UxNetConnxEnv>(() => new UxNetConnxEnv());

	private UnknownFieldSet _unknownFields;

	private string platform_ = "";

	private string appChannel_ = "";

	private string subChannel_ = "";

	private string deviceModel_ = "";

	private uint deviceHeight_;

	private uint deviceWidth_;

	private string os_ = "";

	private string osVer_ = "";

	private string macAddr_ = "";

	private string udid_ = "";

	private string isp_ = "";

	private string network_ = "";

	private uint isFirstConnect_;

	private uint isRoot_;

	private uint binVer_;

	private uint resVer_;

	private string language_ = "";

	private string region_ = "";

	private int tzOffset_;

	private int deviceScore_;

	private int deviceMem_;

	private string ip_ = "";

	public static MessageParser<UxNetConnxEnv> Parser => _parser;

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

	public string SubChannel
	{
		get
		{
			return subChannel_;
		}
		set
		{
			subChannel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeviceModel
	{
		get
		{
			return deviceModel_;
		}
		set
		{
			deviceModel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint DeviceHeight
	{
		get
		{
			return deviceHeight_;
		}
		set
		{
			deviceHeight_ = value;
		}
	}

	public uint DeviceWidth
	{
		get
		{
			return deviceWidth_;
		}
		set
		{
			deviceWidth_ = value;
		}
	}

	public string Os
	{
		get
		{
			return os_;
		}
		set
		{
			os_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string OsVer
	{
		get
		{
			return osVer_;
		}
		set
		{
			osVer_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MacAddr
	{
		get
		{
			return macAddr_;
		}
		set
		{
			macAddr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Udid
	{
		get
		{
			return udid_;
		}
		set
		{
			udid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Isp
	{
		get
		{
			return isp_;
		}
		set
		{
			isp_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Network
	{
		get
		{
			return network_;
		}
		set
		{
			network_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint IsFirstConnect
	{
		get
		{
			return isFirstConnect_;
		}
		set
		{
			isFirstConnect_ = value;
		}
	}

	public uint IsRoot
	{
		get
		{
			return isRoot_;
		}
		set
		{
			isRoot_ = value;
		}
	}

	public uint BinVer
	{
		get
		{
			return binVer_;
		}
		set
		{
			binVer_ = value;
		}
	}

	public uint ResVer
	{
		get
		{
			return resVer_;
		}
		set
		{
			resVer_ = value;
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

	public int DeviceScore
	{
		get
		{
			return deviceScore_;
		}
		set
		{
			deviceScore_ = value;
		}
	}

	public int DeviceMem
	{
		get
		{
			return deviceMem_;
		}
		set
		{
			deviceMem_ = value;
		}
	}

	public string Ip
	{
		get
		{
			return ip_;
		}
		set
		{
			ip_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public UxNetConnxEnv()
	{
	}

	public UxNetConnxEnv(UxNetConnxEnv other)
		: this()
	{
		platform_ = other.platform_;
		appChannel_ = other.appChannel_;
		subChannel_ = other.subChannel_;
		deviceModel_ = other.deviceModel_;
		deviceHeight_ = other.deviceHeight_;
		deviceWidth_ = other.deviceWidth_;
		os_ = other.os_;
		osVer_ = other.osVer_;
		macAddr_ = other.macAddr_;
		udid_ = other.udid_;
		isp_ = other.isp_;
		network_ = other.network_;
		isFirstConnect_ = other.isFirstConnect_;
		isRoot_ = other.isRoot_;
		binVer_ = other.binVer_;
		resVer_ = other.resVer_;
		language_ = other.language_;
		region_ = other.region_;
		tzOffset_ = other.tzOffset_;
		deviceScore_ = other.deviceScore_;
		deviceMem_ = other.deviceMem_;
		ip_ = other.ip_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UxNetConnxEnv Clone()
	{
		return new UxNetConnxEnv(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UxNetConnxEnv);
	}

	public bool Equals(UxNetConnxEnv other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Platform != other.Platform)
		{
			return false;
		}
		if (AppChannel != other.AppChannel)
		{
			return false;
		}
		if (SubChannel != other.SubChannel)
		{
			return false;
		}
		if (DeviceModel != other.DeviceModel)
		{
			return false;
		}
		if (DeviceHeight != other.DeviceHeight)
		{
			return false;
		}
		if (DeviceWidth != other.DeviceWidth)
		{
			return false;
		}
		if (Os != other.Os)
		{
			return false;
		}
		if (OsVer != other.OsVer)
		{
			return false;
		}
		if (MacAddr != other.MacAddr)
		{
			return false;
		}
		if (Udid != other.Udid)
		{
			return false;
		}
		if (Isp != other.Isp)
		{
			return false;
		}
		if (Network != other.Network)
		{
			return false;
		}
		if (IsFirstConnect != other.IsFirstConnect)
		{
			return false;
		}
		if (IsRoot != other.IsRoot)
		{
			return false;
		}
		if (BinVer != other.BinVer)
		{
			return false;
		}
		if (ResVer != other.ResVer)
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
		if (DeviceScore != other.DeviceScore)
		{
			return false;
		}
		if (DeviceMem != other.DeviceMem)
		{
			return false;
		}
		if (Ip != other.Ip)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Platform.Length != 0)
		{
			num ^= Platform.GetHashCode();
		}
		if (AppChannel.Length != 0)
		{
			num ^= AppChannel.GetHashCode();
		}
		if (SubChannel.Length != 0)
		{
			num ^= SubChannel.GetHashCode();
		}
		if (DeviceModel.Length != 0)
		{
			num ^= DeviceModel.GetHashCode();
		}
		if (DeviceHeight != 0)
		{
			num ^= DeviceHeight.GetHashCode();
		}
		if (DeviceWidth != 0)
		{
			num ^= DeviceWidth.GetHashCode();
		}
		if (Os.Length != 0)
		{
			num ^= Os.GetHashCode();
		}
		if (OsVer.Length != 0)
		{
			num ^= OsVer.GetHashCode();
		}
		if (MacAddr.Length != 0)
		{
			num ^= MacAddr.GetHashCode();
		}
		if (Udid.Length != 0)
		{
			num ^= Udid.GetHashCode();
		}
		if (Isp.Length != 0)
		{
			num ^= Isp.GetHashCode();
		}
		if (Network.Length != 0)
		{
			num ^= Network.GetHashCode();
		}
		if (IsFirstConnect != 0)
		{
			num ^= IsFirstConnect.GetHashCode();
		}
		if (IsRoot != 0)
		{
			num ^= IsRoot.GetHashCode();
		}
		if (BinVer != 0)
		{
			num ^= BinVer.GetHashCode();
		}
		if (ResVer != 0)
		{
			num ^= ResVer.GetHashCode();
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
		if (DeviceScore != 0)
		{
			num ^= DeviceScore.GetHashCode();
		}
		if (DeviceMem != 0)
		{
			num ^= DeviceMem.GetHashCode();
		}
		if (Ip.Length != 0)
		{
			num ^= Ip.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Platform.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Platform);
		}
		if (AppChannel.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AppChannel);
		}
		if (SubChannel.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(SubChannel);
		}
		if (DeviceModel.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DeviceModel);
		}
		if (DeviceHeight != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DeviceHeight);
		}
		if (DeviceWidth != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DeviceWidth);
		}
		if (Os.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(Os);
		}
		if (OsVer.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(OsVer);
		}
		if (MacAddr.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(MacAddr);
		}
		if (Udid.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(Udid);
		}
		if (Isp.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(Isp);
		}
		if (Network.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(Network);
		}
		if (IsFirstConnect != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(IsFirstConnect);
		}
		if (IsRoot != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(IsRoot);
		}
		if (BinVer != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(BinVer);
		}
		if (ResVer != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteUInt32(ResVer);
		}
		if (Language.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(Language);
		}
		if (Region.Length != 0)
		{
			output.WriteRawTag(146, 1);
			output.WriteString(Region);
		}
		if (TzOffset != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(TzOffset);
		}
		if (DeviceScore != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(DeviceScore);
		}
		if (DeviceMem != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(DeviceMem);
		}
		if (Ip.Length != 0)
		{
			output.WriteRawTag(178, 1);
			output.WriteString(Ip);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Platform.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Platform);
		}
		if (AppChannel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AppChannel);
		}
		if (SubChannel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SubChannel);
		}
		if (DeviceModel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeviceModel);
		}
		if (DeviceHeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DeviceHeight);
		}
		if (DeviceWidth != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DeviceWidth);
		}
		if (Os.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Os);
		}
		if (OsVer.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OsVer);
		}
		if (MacAddr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MacAddr);
		}
		if (Udid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Udid);
		}
		if (Isp.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Isp);
		}
		if (Network.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Network);
		}
		if (IsFirstConnect != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IsFirstConnect);
		}
		if (IsRoot != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IsRoot);
		}
		if (BinVer != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BinVer);
		}
		if (ResVer != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(ResVer);
		}
		if (Language.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Language);
		}
		if (Region.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Region);
		}
		if (TzOffset != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TzOffset);
		}
		if (DeviceScore != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DeviceScore);
		}
		if (DeviceMem != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DeviceMem);
		}
		if (Ip.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Ip);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UxNetConnxEnv other)
	{
		if (other != null)
		{
			if (other.Platform.Length != 0)
			{
				Platform = other.Platform;
			}
			if (other.AppChannel.Length != 0)
			{
				AppChannel = other.AppChannel;
			}
			if (other.SubChannel.Length != 0)
			{
				SubChannel = other.SubChannel;
			}
			if (other.DeviceModel.Length != 0)
			{
				DeviceModel = other.DeviceModel;
			}
			if (other.DeviceHeight != 0)
			{
				DeviceHeight = other.DeviceHeight;
			}
			if (other.DeviceWidth != 0)
			{
				DeviceWidth = other.DeviceWidth;
			}
			if (other.Os.Length != 0)
			{
				Os = other.Os;
			}
			if (other.OsVer.Length != 0)
			{
				OsVer = other.OsVer;
			}
			if (other.MacAddr.Length != 0)
			{
				MacAddr = other.MacAddr;
			}
			if (other.Udid.Length != 0)
			{
				Udid = other.Udid;
			}
			if (other.Isp.Length != 0)
			{
				Isp = other.Isp;
			}
			if (other.Network.Length != 0)
			{
				Network = other.Network;
			}
			if (other.IsFirstConnect != 0)
			{
				IsFirstConnect = other.IsFirstConnect;
			}
			if (other.IsRoot != 0)
			{
				IsRoot = other.IsRoot;
			}
			if (other.BinVer != 0)
			{
				BinVer = other.BinVer;
			}
			if (other.ResVer != 0)
			{
				ResVer = other.ResVer;
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
			if (other.DeviceScore != 0)
			{
				DeviceScore = other.DeviceScore;
			}
			if (other.DeviceMem != 0)
			{
				DeviceMem = other.DeviceMem;
			}
			if (other.Ip.Length != 0)
			{
				Ip = other.Ip;
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
				Platform = input.ReadString();
				break;
			case 18u:
				AppChannel = input.ReadString();
				break;
			case 26u:
				SubChannel = input.ReadString();
				break;
			case 34u:
				DeviceModel = input.ReadString();
				break;
			case 40u:
				DeviceHeight = input.ReadUInt32();
				break;
			case 48u:
				DeviceWidth = input.ReadUInt32();
				break;
			case 58u:
				Os = input.ReadString();
				break;
			case 66u:
				OsVer = input.ReadString();
				break;
			case 74u:
				MacAddr = input.ReadString();
				break;
			case 82u:
				Udid = input.ReadString();
				break;
			case 90u:
				Isp = input.ReadString();
				break;
			case 98u:
				Network = input.ReadString();
				break;
			case 104u:
				IsFirstConnect = input.ReadUInt32();
				break;
			case 112u:
				IsRoot = input.ReadUInt32();
				break;
			case 120u:
				BinVer = input.ReadUInt32();
				break;
			case 128u:
				ResVer = input.ReadUInt32();
				break;
			case 138u:
				Language = input.ReadString();
				break;
			case 146u:
				Region = input.ReadString();
				break;
			case 152u:
				TzOffset = input.ReadInt32();
				break;
			case 160u:
				DeviceScore = input.ReadInt32();
				break;
			case 168u:
				DeviceMem = input.ReadInt32();
				break;
			case 178u:
				Ip = input.ReadString();
				break;
			}
		}
	}
}
