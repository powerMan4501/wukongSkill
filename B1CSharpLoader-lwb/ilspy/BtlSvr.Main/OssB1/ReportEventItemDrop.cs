using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventItemDrop : IMessage<ReportEventItemDrop>, IMessage, IEquatable<ReportEventItemDrop>, IDeepCloneable<ReportEventItemDrop>
{
	private static readonly MessageParser<ReportEventItemDrop> _parser = new MessageParser<ReportEventItemDrop>(() => new ReportEventItemDrop());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private OSSDropType dropType_;

	private static readonly FieldCodec<int> _repeated_dropId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> dropId_ = new RepeatedField<int>();

	private static readonly FieldCodec<Item> _repeated_dropItemList_codec = FieldCodec.ForMessage(34u, Item.Parser);

	private readonly RepeatedField<Item> dropItemList_ = new RepeatedField<Item>();

	private string commDropReason_ = "";

	private int commDropFromId_;

	private int unitId_;

	private int unitExtendId_;

	private int collectionId_;

	private int collectionDropLevel_;

	private int soulSkillId_;

	public static MessageParser<ReportEventItemDrop> Parser => _parser;

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public OSSDropType DropType
	{
		get
		{
			return dropType_;
		}
		set
		{
			dropType_ = value;
		}
	}

	public RepeatedField<int> DropId => dropId_;

	public RepeatedField<Item> DropItemList => dropItemList_;

	public string CommDropReason
	{
		get
		{
			return commDropReason_;
		}
		set
		{
			commDropReason_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int CommDropFromId
	{
		get
		{
			return commDropFromId_;
		}
		set
		{
			commDropFromId_ = value;
		}
	}

	public int UnitId
	{
		get
		{
			return unitId_;
		}
		set
		{
			unitId_ = value;
		}
	}

	public int UnitExtendId
	{
		get
		{
			return unitExtendId_;
		}
		set
		{
			unitExtendId_ = value;
		}
	}

	public int CollectionId
	{
		get
		{
			return collectionId_;
		}
		set
		{
			collectionId_ = value;
		}
	}

	public int CollectionDropLevel
	{
		get
		{
			return collectionDropLevel_;
		}
		set
		{
			collectionDropLevel_ = value;
		}
	}

	public int SoulSkillId
	{
		get
		{
			return soulSkillId_;
		}
		set
		{
			soulSkillId_ = value;
		}
	}

	public ReportEventItemDrop()
	{
	}

	public ReportEventItemDrop(ReportEventItemDrop other)
		: this()
	{
		roleId_ = other.roleId_;
		dropType_ = other.dropType_;
		dropId_ = other.dropId_.Clone();
		dropItemList_ = other.dropItemList_.Clone();
		commDropReason_ = other.commDropReason_;
		commDropFromId_ = other.commDropFromId_;
		unitId_ = other.unitId_;
		unitExtendId_ = other.unitExtendId_;
		collectionId_ = other.collectionId_;
		collectionDropLevel_ = other.collectionDropLevel_;
		soulSkillId_ = other.soulSkillId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventItemDrop Clone()
	{
		return new ReportEventItemDrop(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventItemDrop);
	}

	public bool Equals(ReportEventItemDrop other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (DropType != other.DropType)
		{
			return false;
		}
		if (!dropId_.Equals(other.dropId_))
		{
			return false;
		}
		if (!dropItemList_.Equals(other.dropItemList_))
		{
			return false;
		}
		if (CommDropReason != other.CommDropReason)
		{
			return false;
		}
		if (CommDropFromId != other.CommDropFromId)
		{
			return false;
		}
		if (UnitId != other.UnitId)
		{
			return false;
		}
		if (UnitExtendId != other.UnitExtendId)
		{
			return false;
		}
		if (CollectionId != other.CollectionId)
		{
			return false;
		}
		if (CollectionDropLevel != other.CollectionDropLevel)
		{
			return false;
		}
		if (SoulSkillId != other.SoulSkillId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		if (DropType != OSSDropType.CommDrop)
		{
			num ^= DropType.GetHashCode();
		}
		num ^= dropId_.GetHashCode();
		num ^= dropItemList_.GetHashCode();
		if (CommDropReason.Length != 0)
		{
			num ^= CommDropReason.GetHashCode();
		}
		if (CommDropFromId != 0)
		{
			num ^= CommDropFromId.GetHashCode();
		}
		if (UnitId != 0)
		{
			num ^= UnitId.GetHashCode();
		}
		if (UnitExtendId != 0)
		{
			num ^= UnitExtendId.GetHashCode();
		}
		if (CollectionId != 0)
		{
			num ^= CollectionId.GetHashCode();
		}
		if (CollectionDropLevel != 0)
		{
			num ^= CollectionDropLevel.GetHashCode();
		}
		if (SoulSkillId != 0)
		{
			num ^= SoulSkillId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoleId);
		}
		if (DropType != OSSDropType.CommDrop)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)DropType);
		}
		dropId_.WriteTo(output, _repeated_dropId_codec);
		dropItemList_.WriteTo(output, _repeated_dropItemList_codec);
		if (CommDropReason.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(CommDropReason);
		}
		if (CommDropFromId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(CommDropFromId);
		}
		if (UnitId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(UnitId);
		}
		if (UnitExtendId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(UnitExtendId);
		}
		if (CollectionId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(CollectionId);
		}
		if (CollectionDropLevel != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(CollectionDropLevel);
		}
		if (SoulSkillId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(SoulSkillId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (DropType != OSSDropType.CommDrop)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DropType);
		}
		num += dropId_.CalculateSize(_repeated_dropId_codec);
		num += dropItemList_.CalculateSize(_repeated_dropItemList_codec);
		if (CommDropReason.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CommDropReason);
		}
		if (CommDropFromId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CommDropFromId);
		}
		if (UnitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitId);
		}
		if (UnitExtendId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitExtendId);
		}
		if (CollectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CollectionId);
		}
		if (CollectionDropLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CollectionDropLevel);
		}
		if (SoulSkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SoulSkillId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventItemDrop other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.DropType != OSSDropType.CommDrop)
			{
				DropType = other.DropType;
			}
			dropId_.Add(other.dropId_);
			dropItemList_.Add(other.dropItemList_);
			if (other.CommDropReason.Length != 0)
			{
				CommDropReason = other.CommDropReason;
			}
			if (other.CommDropFromId != 0)
			{
				CommDropFromId = other.CommDropFromId;
			}
			if (other.UnitId != 0)
			{
				UnitId = other.UnitId;
			}
			if (other.UnitExtendId != 0)
			{
				UnitExtendId = other.UnitExtendId;
			}
			if (other.CollectionId != 0)
			{
				CollectionId = other.CollectionId;
			}
			if (other.CollectionDropLevel != 0)
			{
				CollectionDropLevel = other.CollectionDropLevel;
			}
			if (other.SoulSkillId != 0)
			{
				SoulSkillId = other.SoulSkillId;
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
				RoleId = input.ReadUInt64();
				break;
			case 16u:
				DropType = (OSSDropType)input.ReadEnum();
				break;
			case 24u:
			case 26u:
				dropId_.AddEntriesFrom(input, _repeated_dropId_codec);
				break;
			case 34u:
				dropItemList_.AddEntriesFrom(input, _repeated_dropItemList_codec);
				break;
			case 42u:
				CommDropReason = input.ReadString();
				break;
			case 48u:
				CommDropFromId = input.ReadInt32();
				break;
			case 56u:
				UnitId = input.ReadInt32();
				break;
			case 64u:
				UnitExtendId = input.ReadInt32();
				break;
			case 72u:
				CollectionId = input.ReadInt32();
				break;
			case 80u:
				CollectionDropLevel = input.ReadInt32();
				break;
			case 88u:
				SoulSkillId = input.ReadInt32();
				break;
			}
		}
	}
}
