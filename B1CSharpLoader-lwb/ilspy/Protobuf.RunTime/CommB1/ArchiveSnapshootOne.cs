using System;
using ArchiveB1;
using Google.Protobuf;

namespace CommB1;

public sealed class ArchiveSnapshootOne : IMessage<ArchiveSnapshootOne>, IMessage, IEquatable<ArchiveSnapshootOne>, IDeepCloneable<ArchiveSnapshootOne>
{
	private static readonly MessageParser<ArchiveSnapshootOne> _parser = new MessageParser<ArchiveSnapshootOne>(() => new ArchiveSnapshootOne());

	private UnknownFieldSet _unknownFields;

	private int index_;

	private string name_ = "";

	private bool autoRun_;

	private RoleDataCS roleData_;

	private EffectAttrList attrList_;

	private CustomAttrList customAttrList_;

	private ProtocolTag snapshootTag_;

	private FUStBEDArchivesData archiveData_;

	private GMTransportTarget transportTarget_;

	public static MessageParser<ArchiveSnapshootOne> Parser => _parser;

	public int Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
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

	public bool AutoRun
	{
		get
		{
			return autoRun_;
		}
		set
		{
			autoRun_ = value;
		}
	}

	public RoleDataCS RoleData
	{
		get
		{
			return roleData_;
		}
		set
		{
			roleData_ = value;
		}
	}

	public EffectAttrList AttrList
	{
		get
		{
			return attrList_;
		}
		set
		{
			attrList_ = value;
		}
	}

	public CustomAttrList CustomAttrList
	{
		get
		{
			return customAttrList_;
		}
		set
		{
			customAttrList_ = value;
		}
	}

	public ProtocolTag SnapshootTag
	{
		get
		{
			return snapshootTag_;
		}
		set
		{
			snapshootTag_ = value;
		}
	}

	public FUStBEDArchivesData ArchiveData
	{
		get
		{
			return archiveData_;
		}
		set
		{
			archiveData_ = value;
		}
	}

	public GMTransportTarget TransportTarget
	{
		get
		{
			return transportTarget_;
		}
		set
		{
			transportTarget_ = value;
		}
	}

	public ArchiveSnapshootOne()
	{
	}

	public ArchiveSnapshootOne(ArchiveSnapshootOne other)
		: this()
	{
		index_ = other.index_;
		name_ = other.name_;
		autoRun_ = other.autoRun_;
		roleData_ = ((other.roleData_ != null) ? other.roleData_.Clone() : null);
		attrList_ = ((other.attrList_ != null) ? other.attrList_.Clone() : null);
		customAttrList_ = ((other.customAttrList_ != null) ? other.customAttrList_.Clone() : null);
		snapshootTag_ = other.snapshootTag_;
		archiveData_ = ((other.archiveData_ != null) ? other.archiveData_.Clone() : null);
		transportTarget_ = ((other.transportTarget_ != null) ? other.transportTarget_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ArchiveSnapshootOne Clone()
	{
		return new ArchiveSnapshootOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ArchiveSnapshootOne);
	}

	public bool Equals(ArchiveSnapshootOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (AutoRun != other.AutoRun)
		{
			return false;
		}
		if (!object.Equals(RoleData, other.RoleData))
		{
			return false;
		}
		if (!object.Equals(AttrList, other.AttrList))
		{
			return false;
		}
		if (!object.Equals(CustomAttrList, other.CustomAttrList))
		{
			return false;
		}
		if (SnapshootTag != other.SnapshootTag)
		{
			return false;
		}
		if (!object.Equals(ArchiveData, other.ArchiveData))
		{
			return false;
		}
		if (!object.Equals(TransportTarget, other.TransportTarget))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (AutoRun)
		{
			num ^= AutoRun.GetHashCode();
		}
		if (roleData_ != null)
		{
			num ^= RoleData.GetHashCode();
		}
		if (attrList_ != null)
		{
			num ^= AttrList.GetHashCode();
		}
		if (customAttrList_ != null)
		{
			num ^= CustomAttrList.GetHashCode();
		}
		if (SnapshootTag != ProtocolTag.Default)
		{
			num ^= SnapshootTag.GetHashCode();
		}
		if (archiveData_ != null)
		{
			num ^= ArchiveData.GetHashCode();
		}
		if (transportTarget_ != null)
		{
			num ^= TransportTarget.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Index != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Index);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (AutoRun)
		{
			output.WriteRawTag(24);
			output.WriteBool(AutoRun);
		}
		if (roleData_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(RoleData);
		}
		if (attrList_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(AttrList);
		}
		if (customAttrList_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(CustomAttrList);
		}
		if (SnapshootTag != ProtocolTag.Default)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)SnapshootTag);
		}
		if (archiveData_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(ArchiveData);
		}
		if (transportTarget_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(TransportTarget);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Index);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (AutoRun)
		{
			num += 2;
		}
		if (roleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleData);
		}
		if (attrList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AttrList);
		}
		if (customAttrList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CustomAttrList);
		}
		if (SnapshootTag != ProtocolTag.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SnapshootTag);
		}
		if (archiveData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ArchiveData);
		}
		if (transportTarget_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TransportTarget);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ArchiveSnapshootOne other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Index != 0)
		{
			Index = other.Index;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		if (other.AutoRun)
		{
			AutoRun = other.AutoRun;
		}
		if (other.roleData_ != null)
		{
			if (roleData_ == null)
			{
				RoleData = new RoleDataCS();
			}
			RoleData.MergeFrom(other.RoleData);
		}
		if (other.attrList_ != null)
		{
			if (attrList_ == null)
			{
				AttrList = new EffectAttrList();
			}
			AttrList.MergeFrom(other.AttrList);
		}
		if (other.customAttrList_ != null)
		{
			if (customAttrList_ == null)
			{
				CustomAttrList = new CustomAttrList();
			}
			CustomAttrList.MergeFrom(other.CustomAttrList);
		}
		if (other.SnapshootTag != ProtocolTag.Default)
		{
			SnapshootTag = other.SnapshootTag;
		}
		if (other.archiveData_ != null)
		{
			if (archiveData_ == null)
			{
				ArchiveData = new FUStBEDArchivesData();
			}
			ArchiveData.MergeFrom(other.ArchiveData);
		}
		if (other.transportTarget_ != null)
		{
			if (transportTarget_ == null)
			{
				TransportTarget = new GMTransportTarget();
			}
			TransportTarget.MergeFrom(other.TransportTarget);
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
			case 8u:
				Index = input.ReadInt32();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 24u:
				AutoRun = input.ReadBool();
				break;
			case 34u:
				if (roleData_ == null)
				{
					RoleData = new RoleDataCS();
				}
				input.ReadMessage(RoleData);
				break;
			case 42u:
				if (attrList_ == null)
				{
					AttrList = new EffectAttrList();
				}
				input.ReadMessage(AttrList);
				break;
			case 50u:
				if (customAttrList_ == null)
				{
					CustomAttrList = new CustomAttrList();
				}
				input.ReadMessage(CustomAttrList);
				break;
			case 56u:
				SnapshootTag = (ProtocolTag)input.ReadEnum();
				break;
			case 66u:
				if (archiveData_ == null)
				{
					ArchiveData = new FUStBEDArchivesData();
				}
				input.ReadMessage(ArchiveData);
				break;
			case 74u:
				if (transportTarget_ == null)
				{
					TransportTarget = new GMTransportTarget();
				}
				input.ReadMessage(TransportTarget);
				break;
			}
		}
	}
}
