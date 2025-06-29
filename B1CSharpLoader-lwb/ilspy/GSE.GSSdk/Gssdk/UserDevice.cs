using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class UserDevice : IMessage<UserDevice>, IMessage, IEquatable<UserDevice>, IDeepCloneable<UserDevice>
{
	private static readonly MessageParser<UserDevice> _parser = new MessageParser<UserDevice>(() => new UserDevice());

	private UnknownFieldSet _unknownFields;

	private string deviceId_ = "";

	private string mac_ = "";

	private string platform_ = "";

	private int height_;

	private int width_;

	private string osVer_ = "";

	private string localIpList_ = "";

	private int memMbTotal_;

	private int memMbFree_;

	private string cpuModel_ = "";

	private string gpuModel_ = "";

	private int cpuCores_;

	private int cpuLogicThreads_;

	private int installDirIsSsd_;

	private string gpuDriverDesc_ = "";

	private string osName_ = "";

	private string osRawDesc_ = "";

	private string cpuArch_ = "";

	private string pcHdId_ = "";

	private string pcMsProductid_ = "";

	private string pcMachineGuid_ = "";

	private string pcBiosUuid_ = "";

	private string natType_ = "";

	private string pcDeviceId_ = "";

	public static MessageParser<UserDevice> Parser => _parser;

	public string DeviceId
	{
		get
		{
			return deviceId_;
		}
		set
		{
			deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Mac
	{
		get
		{
			return mac_;
		}
		set
		{
			mac_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public int Height
	{
		get
		{
			return height_;
		}
		set
		{
			height_ = value;
		}
	}

	public int Width
	{
		get
		{
			return width_;
		}
		set
		{
			width_ = value;
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

	public string LocalIpList
	{
		get
		{
			return localIpList_;
		}
		set
		{
			localIpList_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int MemMbTotal
	{
		get
		{
			return memMbTotal_;
		}
		set
		{
			memMbTotal_ = value;
		}
	}

	public int MemMbFree
	{
		get
		{
			return memMbFree_;
		}
		set
		{
			memMbFree_ = value;
		}
	}

	public string CpuModel
	{
		get
		{
			return cpuModel_;
		}
		set
		{
			cpuModel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string GpuModel
	{
		get
		{
			return gpuModel_;
		}
		set
		{
			gpuModel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int CpuCores
	{
		get
		{
			return cpuCores_;
		}
		set
		{
			cpuCores_ = value;
		}
	}

	public int CpuLogicThreads
	{
		get
		{
			return cpuLogicThreads_;
		}
		set
		{
			cpuLogicThreads_ = value;
		}
	}

	public int InstallDirIsSsd
	{
		get
		{
			return installDirIsSsd_;
		}
		set
		{
			installDirIsSsd_ = value;
		}
	}

	public string GpuDriverDesc
	{
		get
		{
			return gpuDriverDesc_;
		}
		set
		{
			gpuDriverDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string OsName
	{
		get
		{
			return osName_;
		}
		set
		{
			osName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string OsRawDesc
	{
		get
		{
			return osRawDesc_;
		}
		set
		{
			osRawDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string CpuArch
	{
		get
		{
			return cpuArch_;
		}
		set
		{
			cpuArch_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PcHdId
	{
		get
		{
			return pcHdId_;
		}
		set
		{
			pcHdId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PcMsProductid
	{
		get
		{
			return pcMsProductid_;
		}
		set
		{
			pcMsProductid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PcMachineGuid
	{
		get
		{
			return pcMachineGuid_;
		}
		set
		{
			pcMachineGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PcBiosUuid
	{
		get
		{
			return pcBiosUuid_;
		}
		set
		{
			pcBiosUuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string NatType
	{
		get
		{
			return natType_;
		}
		set
		{
			natType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PcDeviceId
	{
		get
		{
			return pcDeviceId_;
		}
		set
		{
			pcDeviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public UserDevice()
	{
	}

	public UserDevice(UserDevice other)
		: this()
	{
		deviceId_ = other.deviceId_;
		mac_ = other.mac_;
		platform_ = other.platform_;
		height_ = other.height_;
		width_ = other.width_;
		osVer_ = other.osVer_;
		localIpList_ = other.localIpList_;
		memMbTotal_ = other.memMbTotal_;
		memMbFree_ = other.memMbFree_;
		cpuModel_ = other.cpuModel_;
		gpuModel_ = other.gpuModel_;
		cpuCores_ = other.cpuCores_;
		cpuLogicThreads_ = other.cpuLogicThreads_;
		installDirIsSsd_ = other.installDirIsSsd_;
		gpuDriverDesc_ = other.gpuDriverDesc_;
		osName_ = other.osName_;
		osRawDesc_ = other.osRawDesc_;
		cpuArch_ = other.cpuArch_;
		pcHdId_ = other.pcHdId_;
		pcMsProductid_ = other.pcMsProductid_;
		pcMachineGuid_ = other.pcMachineGuid_;
		pcBiosUuid_ = other.pcBiosUuid_;
		natType_ = other.natType_;
		pcDeviceId_ = other.pcDeviceId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UserDevice Clone()
	{
		return new UserDevice(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UserDevice);
	}

	public bool Equals(UserDevice other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DeviceId != other.DeviceId)
		{
			return false;
		}
		if (Mac != other.Mac)
		{
			return false;
		}
		if (Platform != other.Platform)
		{
			return false;
		}
		if (Height != other.Height)
		{
			return false;
		}
		if (Width != other.Width)
		{
			return false;
		}
		if (OsVer != other.OsVer)
		{
			return false;
		}
		if (LocalIpList != other.LocalIpList)
		{
			return false;
		}
		if (MemMbTotal != other.MemMbTotal)
		{
			return false;
		}
		if (MemMbFree != other.MemMbFree)
		{
			return false;
		}
		if (CpuModel != other.CpuModel)
		{
			return false;
		}
		if (GpuModel != other.GpuModel)
		{
			return false;
		}
		if (CpuCores != other.CpuCores)
		{
			return false;
		}
		if (CpuLogicThreads != other.CpuLogicThreads)
		{
			return false;
		}
		if (InstallDirIsSsd != other.InstallDirIsSsd)
		{
			return false;
		}
		if (GpuDriverDesc != other.GpuDriverDesc)
		{
			return false;
		}
		if (OsName != other.OsName)
		{
			return false;
		}
		if (OsRawDesc != other.OsRawDesc)
		{
			return false;
		}
		if (CpuArch != other.CpuArch)
		{
			return false;
		}
		if (PcHdId != other.PcHdId)
		{
			return false;
		}
		if (PcMsProductid != other.PcMsProductid)
		{
			return false;
		}
		if (PcMachineGuid != other.PcMachineGuid)
		{
			return false;
		}
		if (PcBiosUuid != other.PcBiosUuid)
		{
			return false;
		}
		if (NatType != other.NatType)
		{
			return false;
		}
		if (PcDeviceId != other.PcDeviceId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (DeviceId.Length != 0)
		{
			num ^= DeviceId.GetHashCode();
		}
		if (Mac.Length != 0)
		{
			num ^= Mac.GetHashCode();
		}
		if (Platform.Length != 0)
		{
			num ^= Platform.GetHashCode();
		}
		if (Height != 0)
		{
			num ^= Height.GetHashCode();
		}
		if (Width != 0)
		{
			num ^= Width.GetHashCode();
		}
		if (OsVer.Length != 0)
		{
			num ^= OsVer.GetHashCode();
		}
		if (LocalIpList.Length != 0)
		{
			num ^= LocalIpList.GetHashCode();
		}
		if (MemMbTotal != 0)
		{
			num ^= MemMbTotal.GetHashCode();
		}
		if (MemMbFree != 0)
		{
			num ^= MemMbFree.GetHashCode();
		}
		if (CpuModel.Length != 0)
		{
			num ^= CpuModel.GetHashCode();
		}
		if (GpuModel.Length != 0)
		{
			num ^= GpuModel.GetHashCode();
		}
		if (CpuCores != 0)
		{
			num ^= CpuCores.GetHashCode();
		}
		if (CpuLogicThreads != 0)
		{
			num ^= CpuLogicThreads.GetHashCode();
		}
		if (InstallDirIsSsd != 0)
		{
			num ^= InstallDirIsSsd.GetHashCode();
		}
		if (GpuDriverDesc.Length != 0)
		{
			num ^= GpuDriverDesc.GetHashCode();
		}
		if (OsName.Length != 0)
		{
			num ^= OsName.GetHashCode();
		}
		if (OsRawDesc.Length != 0)
		{
			num ^= OsRawDesc.GetHashCode();
		}
		if (CpuArch.Length != 0)
		{
			num ^= CpuArch.GetHashCode();
		}
		if (PcHdId.Length != 0)
		{
			num ^= PcHdId.GetHashCode();
		}
		if (PcMsProductid.Length != 0)
		{
			num ^= PcMsProductid.GetHashCode();
		}
		if (PcMachineGuid.Length != 0)
		{
			num ^= PcMachineGuid.GetHashCode();
		}
		if (PcBiosUuid.Length != 0)
		{
			num ^= PcBiosUuid.GetHashCode();
		}
		if (NatType.Length != 0)
		{
			num ^= NatType.GetHashCode();
		}
		if (PcDeviceId.Length != 0)
		{
			num ^= PcDeviceId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (DeviceId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(DeviceId);
		}
		if (Mac.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Mac);
		}
		if (Platform.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Platform);
		}
		if (Height != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Height);
		}
		if (Width != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Width);
		}
		if (OsVer.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(OsVer);
		}
		if (LocalIpList.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(LocalIpList);
		}
		if (MemMbTotal != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(MemMbTotal);
		}
		if (MemMbFree != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(MemMbFree);
		}
		if (CpuModel.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(CpuModel);
		}
		if (GpuModel.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(GpuModel);
		}
		if (CpuCores != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(CpuCores);
		}
		if (CpuLogicThreads != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(CpuLogicThreads);
		}
		if (InstallDirIsSsd != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(InstallDirIsSsd);
		}
		if (GpuDriverDesc.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(GpuDriverDesc);
		}
		if (OsName.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(OsName);
		}
		if (OsRawDesc.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(OsRawDesc);
		}
		if (CpuArch.Length != 0)
		{
			output.WriteRawTag(146, 1);
			output.WriteString(CpuArch);
		}
		if (PcHdId.Length != 0)
		{
			output.WriteRawTag(154, 1);
			output.WriteString(PcHdId);
		}
		if (PcMsProductid.Length != 0)
		{
			output.WriteRawTag(162, 1);
			output.WriteString(PcMsProductid);
		}
		if (PcMachineGuid.Length != 0)
		{
			output.WriteRawTag(170, 1);
			output.WriteString(PcMachineGuid);
		}
		if (PcBiosUuid.Length != 0)
		{
			output.WriteRawTag(178, 1);
			output.WriteString(PcBiosUuid);
		}
		if (NatType.Length != 0)
		{
			output.WriteRawTag(186, 1);
			output.WriteString(NatType);
		}
		if (PcDeviceId.Length != 0)
		{
			output.WriteRawTag(194, 1);
			output.WriteString(PcDeviceId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DeviceId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
		}
		if (Mac.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Mac);
		}
		if (Platform.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Platform);
		}
		if (Height != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Height);
		}
		if (Width != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Width);
		}
		if (OsVer.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OsVer);
		}
		if (LocalIpList.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LocalIpList);
		}
		if (MemMbTotal != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MemMbTotal);
		}
		if (MemMbFree != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MemMbFree);
		}
		if (CpuModel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CpuModel);
		}
		if (GpuModel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GpuModel);
		}
		if (CpuCores != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CpuCores);
		}
		if (CpuLogicThreads != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CpuLogicThreads);
		}
		if (InstallDirIsSsd != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InstallDirIsSsd);
		}
		if (GpuDriverDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GpuDriverDesc);
		}
		if (OsName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(OsName);
		}
		if (OsRawDesc.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(OsRawDesc);
		}
		if (CpuArch.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(CpuArch);
		}
		if (PcHdId.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PcHdId);
		}
		if (PcMsProductid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PcMsProductid);
		}
		if (PcMachineGuid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PcMachineGuid);
		}
		if (PcBiosUuid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PcBiosUuid);
		}
		if (NatType.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(NatType);
		}
		if (PcDeviceId.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PcDeviceId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UserDevice other)
	{
		if (other != null)
		{
			if (other.DeviceId.Length != 0)
			{
				DeviceId = other.DeviceId;
			}
			if (other.Mac.Length != 0)
			{
				Mac = other.Mac;
			}
			if (other.Platform.Length != 0)
			{
				Platform = other.Platform;
			}
			if (other.Height != 0)
			{
				Height = other.Height;
			}
			if (other.Width != 0)
			{
				Width = other.Width;
			}
			if (other.OsVer.Length != 0)
			{
				OsVer = other.OsVer;
			}
			if (other.LocalIpList.Length != 0)
			{
				LocalIpList = other.LocalIpList;
			}
			if (other.MemMbTotal != 0)
			{
				MemMbTotal = other.MemMbTotal;
			}
			if (other.MemMbFree != 0)
			{
				MemMbFree = other.MemMbFree;
			}
			if (other.CpuModel.Length != 0)
			{
				CpuModel = other.CpuModel;
			}
			if (other.GpuModel.Length != 0)
			{
				GpuModel = other.GpuModel;
			}
			if (other.CpuCores != 0)
			{
				CpuCores = other.CpuCores;
			}
			if (other.CpuLogicThreads != 0)
			{
				CpuLogicThreads = other.CpuLogicThreads;
			}
			if (other.InstallDirIsSsd != 0)
			{
				InstallDirIsSsd = other.InstallDirIsSsd;
			}
			if (other.GpuDriverDesc.Length != 0)
			{
				GpuDriverDesc = other.GpuDriverDesc;
			}
			if (other.OsName.Length != 0)
			{
				OsName = other.OsName;
			}
			if (other.OsRawDesc.Length != 0)
			{
				OsRawDesc = other.OsRawDesc;
			}
			if (other.CpuArch.Length != 0)
			{
				CpuArch = other.CpuArch;
			}
			if (other.PcHdId.Length != 0)
			{
				PcHdId = other.PcHdId;
			}
			if (other.PcMsProductid.Length != 0)
			{
				PcMsProductid = other.PcMsProductid;
			}
			if (other.PcMachineGuid.Length != 0)
			{
				PcMachineGuid = other.PcMachineGuid;
			}
			if (other.PcBiosUuid.Length != 0)
			{
				PcBiosUuid = other.PcBiosUuid;
			}
			if (other.NatType.Length != 0)
			{
				NatType = other.NatType;
			}
			if (other.PcDeviceId.Length != 0)
			{
				PcDeviceId = other.PcDeviceId;
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
				DeviceId = input.ReadString();
				break;
			case 18u:
				Mac = input.ReadString();
				break;
			case 26u:
				Platform = input.ReadString();
				break;
			case 32u:
				Height = input.ReadInt32();
				break;
			case 40u:
				Width = input.ReadInt32();
				break;
			case 50u:
				OsVer = input.ReadString();
				break;
			case 58u:
				LocalIpList = input.ReadString();
				break;
			case 64u:
				MemMbTotal = input.ReadInt32();
				break;
			case 72u:
				MemMbFree = input.ReadInt32();
				break;
			case 82u:
				CpuModel = input.ReadString();
				break;
			case 90u:
				GpuModel = input.ReadString();
				break;
			case 96u:
				CpuCores = input.ReadInt32();
				break;
			case 104u:
				CpuLogicThreads = input.ReadInt32();
				break;
			case 112u:
				InstallDirIsSsd = input.ReadInt32();
				break;
			case 122u:
				GpuDriverDesc = input.ReadString();
				break;
			case 130u:
				OsName = input.ReadString();
				break;
			case 138u:
				OsRawDesc = input.ReadString();
				break;
			case 146u:
				CpuArch = input.ReadString();
				break;
			case 154u:
				PcHdId = input.ReadString();
				break;
			case 162u:
				PcMsProductid = input.ReadString();
				break;
			case 170u:
				PcMachineGuid = input.ReadString();
				break;
			case 178u:
				PcBiosUuid = input.ReadString();
				break;
			case 186u:
				NatType = input.ReadString();
				break;
			case 194u:
				PcDeviceId = input.ReadString();
				break;
			}
		}
	}
}
