using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class ArchiveInfo : IMessage<ArchiveInfo>, IMessage, IEquatable<ArchiveInfo>, IDeepCloneable<ArchiveInfo>
{
	private static readonly MessageParser<ArchiveInfo> _parser = new MessageParser<ArchiveInfo>(() => new ArchiveInfo());

	private UnknownFieldSet _unknownFields;

	private string md5Str_ = "";

	private int archiveVersion_;

	private ulong lastSaveTime_;

	private ulong createTime_;

	private ProtocolTag protocolTag_;

	private bool enableEncrypt_;

	private string archiveUid_ = "";

	private int createBuildRevision_;

	private int saveBuildRevision_;

	private string sdkUid_ = "";

	private string sharedArchiveUid_ = "";

	public static MessageParser<ArchiveInfo> Parser => _parser;

	public string Md5Str
	{
		get
		{
			return md5Str_;
		}
		set
		{
			md5Str_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ArchiveVersion
	{
		get
		{
			return archiveVersion_;
		}
		set
		{
			archiveVersion_ = value;
		}
	}

	public ulong LastSaveTime
	{
		get
		{
			return lastSaveTime_;
		}
		set
		{
			lastSaveTime_ = value;
		}
	}

	public ulong CreateTime
	{
		get
		{
			return createTime_;
		}
		set
		{
			createTime_ = value;
		}
	}

	public ProtocolTag ProtocolTag
	{
		get
		{
			return protocolTag_;
		}
		set
		{
			protocolTag_ = value;
		}
	}

	public bool EnableEncrypt
	{
		get
		{
			return enableEncrypt_;
		}
		set
		{
			enableEncrypt_ = value;
		}
	}

	public string ArchiveUid
	{
		get
		{
			return archiveUid_;
		}
		set
		{
			archiveUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int CreateBuildRevision
	{
		get
		{
			return createBuildRevision_;
		}
		set
		{
			createBuildRevision_ = value;
		}
	}

	public int SaveBuildRevision
	{
		get
		{
			return saveBuildRevision_;
		}
		set
		{
			saveBuildRevision_ = value;
		}
	}

	public string SdkUid
	{
		get
		{
			return sdkUid_;
		}
		set
		{
			sdkUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SharedArchiveUid
	{
		get
		{
			return sharedArchiveUid_;
		}
		set
		{
			sharedArchiveUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ArchiveInfo()
	{
	}

	public ArchiveInfo(ArchiveInfo other)
		: this()
	{
		md5Str_ = other.md5Str_;
		archiveVersion_ = other.archiveVersion_;
		lastSaveTime_ = other.lastSaveTime_;
		createTime_ = other.createTime_;
		protocolTag_ = other.protocolTag_;
		enableEncrypt_ = other.enableEncrypt_;
		archiveUid_ = other.archiveUid_;
		createBuildRevision_ = other.createBuildRevision_;
		saveBuildRevision_ = other.saveBuildRevision_;
		sdkUid_ = other.sdkUid_;
		sharedArchiveUid_ = other.sharedArchiveUid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ArchiveInfo Clone()
	{
		return new ArchiveInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ArchiveInfo);
	}

	public bool Equals(ArchiveInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Md5Str != other.Md5Str)
		{
			return false;
		}
		if (ArchiveVersion != other.ArchiveVersion)
		{
			return false;
		}
		if (LastSaveTime != other.LastSaveTime)
		{
			return false;
		}
		if (CreateTime != other.CreateTime)
		{
			return false;
		}
		if (ProtocolTag != other.ProtocolTag)
		{
			return false;
		}
		if (EnableEncrypt != other.EnableEncrypt)
		{
			return false;
		}
		if (ArchiveUid != other.ArchiveUid)
		{
			return false;
		}
		if (CreateBuildRevision != other.CreateBuildRevision)
		{
			return false;
		}
		if (SaveBuildRevision != other.SaveBuildRevision)
		{
			return false;
		}
		if (SdkUid != other.SdkUid)
		{
			return false;
		}
		if (SharedArchiveUid != other.SharedArchiveUid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Md5Str.Length != 0)
		{
			num ^= Md5Str.GetHashCode();
		}
		if (ArchiveVersion != 0)
		{
			num ^= ArchiveVersion.GetHashCode();
		}
		if (LastSaveTime != 0L)
		{
			num ^= LastSaveTime.GetHashCode();
		}
		if (CreateTime != 0L)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (ProtocolTag != ProtocolTag.Default)
		{
			num ^= ProtocolTag.GetHashCode();
		}
		if (EnableEncrypt)
		{
			num ^= EnableEncrypt.GetHashCode();
		}
		if (ArchiveUid.Length != 0)
		{
			num ^= ArchiveUid.GetHashCode();
		}
		if (CreateBuildRevision != 0)
		{
			num ^= CreateBuildRevision.GetHashCode();
		}
		if (SaveBuildRevision != 0)
		{
			num ^= SaveBuildRevision.GetHashCode();
		}
		if (SdkUid.Length != 0)
		{
			num ^= SdkUid.GetHashCode();
		}
		if (SharedArchiveUid.Length != 0)
		{
			num ^= SharedArchiveUid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Md5Str.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Md5Str);
		}
		if (ArchiveVersion != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ArchiveVersion);
		}
		if (LastSaveTime != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(LastSaveTime);
		}
		if (CreateTime != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(CreateTime);
		}
		if (ProtocolTag != ProtocolTag.Default)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)ProtocolTag);
		}
		if (EnableEncrypt)
		{
			output.WriteRawTag(64);
			output.WriteBool(EnableEncrypt);
		}
		if (ArchiveUid.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(ArchiveUid);
		}
		if (CreateBuildRevision != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(CreateBuildRevision);
		}
		if (SaveBuildRevision != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(SaveBuildRevision);
		}
		if (SdkUid.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(SdkUid);
		}
		if (SharedArchiveUid.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(SharedArchiveUid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Md5Str.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Md5Str);
		}
		if (ArchiveVersion != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ArchiveVersion);
		}
		if (LastSaveTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(LastSaveTime);
		}
		if (CreateTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(CreateTime);
		}
		if (ProtocolTag != ProtocolTag.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ProtocolTag);
		}
		if (EnableEncrypt)
		{
			num += 2;
		}
		if (ArchiveUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArchiveUid);
		}
		if (CreateBuildRevision != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CreateBuildRevision);
		}
		if (SaveBuildRevision != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SaveBuildRevision);
		}
		if (SdkUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SdkUid);
		}
		if (SharedArchiveUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SharedArchiveUid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ArchiveInfo other)
	{
		if (other != null)
		{
			if (other.Md5Str.Length != 0)
			{
				Md5Str = other.Md5Str;
			}
			if (other.ArchiveVersion != 0)
			{
				ArchiveVersion = other.ArchiveVersion;
			}
			if (other.LastSaveTime != 0L)
			{
				LastSaveTime = other.LastSaveTime;
			}
			if (other.CreateTime != 0L)
			{
				CreateTime = other.CreateTime;
			}
			if (other.ProtocolTag != ProtocolTag.Default)
			{
				ProtocolTag = other.ProtocolTag;
			}
			if (other.EnableEncrypt)
			{
				EnableEncrypt = other.EnableEncrypt;
			}
			if (other.ArchiveUid.Length != 0)
			{
				ArchiveUid = other.ArchiveUid;
			}
			if (other.CreateBuildRevision != 0)
			{
				CreateBuildRevision = other.CreateBuildRevision;
			}
			if (other.SaveBuildRevision != 0)
			{
				SaveBuildRevision = other.SaveBuildRevision;
			}
			if (other.SdkUid.Length != 0)
			{
				SdkUid = other.SdkUid;
			}
			if (other.SharedArchiveUid.Length != 0)
			{
				SharedArchiveUid = other.SharedArchiveUid;
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
				Md5Str = input.ReadString();
				break;
			case 32u:
				ArchiveVersion = input.ReadInt32();
				break;
			case 40u:
				LastSaveTime = input.ReadUInt64();
				break;
			case 48u:
				CreateTime = input.ReadUInt64();
				break;
			case 56u:
				ProtocolTag = (ProtocolTag)input.ReadEnum();
				break;
			case 64u:
				EnableEncrypt = input.ReadBool();
				break;
			case 74u:
				ArchiveUid = input.ReadString();
				break;
			case 80u:
				CreateBuildRevision = input.ReadInt32();
				break;
			case 88u:
				SaveBuildRevision = input.ReadInt32();
				break;
			case 98u:
				SdkUid = input.ReadString();
				break;
			case 106u:
				SharedArchiveUid = input.ReadString();
				break;
			}
		}
	}
}
