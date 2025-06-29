using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStAttachedNiagaraByHitDesc : IMessage<FUStAttachedNiagaraByHitDesc>, IMessage, IEquatable<FUStAttachedNiagaraByHitDesc>, IDeepCloneable<FUStAttachedNiagaraByHitDesc>
{
	private static readonly MessageParser<FUStAttachedNiagaraByHitDesc> _parser = new MessageParser<FUStAttachedNiagaraByHitDesc>(() => new FUStAttachedNiagaraByHitDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int resID_;

	private EAttachNiagaraEventType attachNiagaraEventType_;

	private int priority_;

	private ERemoveAttachedNiagaraRule removeAttachedNiagaraRule_;

	private string dBCPath_ = "";

	private EGSYesNo isUseUnitBodyCondition_;

	private string noneDBCpath_ = "";

	private string smallDBCpath_ = "";

	private string mediumDBCpath_ = "";

	private string mediumBigDBCpath_ = "";

	private string bigDBCpath_ = "";

	private string hugeDBCpath_ = "";

	public static MessageParser<FUStAttachedNiagaraByHitDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public int ResID
	{
		get
		{
			return resID_;
		}
		set
		{
			resID_ = value;
		}
	}

	public EAttachNiagaraEventType AttachNiagaraEventType
	{
		get
		{
			return attachNiagaraEventType_;
		}
		set
		{
			attachNiagaraEventType_ = value;
		}
	}

	public int Priority
	{
		get
		{
			return priority_;
		}
		set
		{
			priority_ = value;
		}
	}

	public ERemoveAttachedNiagaraRule RemoveAttachedNiagaraRule
	{
		get
		{
			return removeAttachedNiagaraRule_;
		}
		set
		{
			removeAttachedNiagaraRule_ = value;
		}
	}

	public string DBCPath
	{
		get
		{
			return dBCPath_;
		}
		set
		{
			dBCPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo IsUseUnitBodyCondition
	{
		get
		{
			return isUseUnitBodyCondition_;
		}
		set
		{
			isUseUnitBodyCondition_ = value;
		}
	}

	public string NoneDBCpath
	{
		get
		{
			return noneDBCpath_;
		}
		set
		{
			noneDBCpath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SmallDBCpath
	{
		get
		{
			return smallDBCpath_;
		}
		set
		{
			smallDBCpath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MediumDBCpath
	{
		get
		{
			return mediumDBCpath_;
		}
		set
		{
			mediumDBCpath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MediumBigDBCpath
	{
		get
		{
			return mediumBigDBCpath_;
		}
		set
		{
			mediumBigDBCpath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BigDBCpath
	{
		get
		{
			return bigDBCpath_;
		}
		set
		{
			bigDBCpath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string HugeDBCpath
	{
		get
		{
			return hugeDBCpath_;
		}
		set
		{
			hugeDBCpath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStAttachedNiagaraByHitDesc()
	{
	}

	public FUStAttachedNiagaraByHitDesc(FUStAttachedNiagaraByHitDesc other)
		: this()
	{
		iD_ = other.iD_;
		resID_ = other.resID_;
		attachNiagaraEventType_ = other.attachNiagaraEventType_;
		priority_ = other.priority_;
		removeAttachedNiagaraRule_ = other.removeAttachedNiagaraRule_;
		dBCPath_ = other.dBCPath_;
		isUseUnitBodyCondition_ = other.isUseUnitBodyCondition_;
		noneDBCpath_ = other.noneDBCpath_;
		smallDBCpath_ = other.smallDBCpath_;
		mediumDBCpath_ = other.mediumDBCpath_;
		mediumBigDBCpath_ = other.mediumBigDBCpath_;
		bigDBCpath_ = other.bigDBCpath_;
		hugeDBCpath_ = other.hugeDBCpath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAttachedNiagaraByHitDesc Clone()
	{
		return new FUStAttachedNiagaraByHitDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAttachedNiagaraByHitDesc);
	}

	public bool Equals(FUStAttachedNiagaraByHitDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (ResID != other.ResID)
		{
			return false;
		}
		if (AttachNiagaraEventType != other.AttachNiagaraEventType)
		{
			return false;
		}
		if (Priority != other.Priority)
		{
			return false;
		}
		if (RemoveAttachedNiagaraRule != other.RemoveAttachedNiagaraRule)
		{
			return false;
		}
		if (DBCPath != other.DBCPath)
		{
			return false;
		}
		if (IsUseUnitBodyCondition != other.IsUseUnitBodyCondition)
		{
			return false;
		}
		if (NoneDBCpath != other.NoneDBCpath)
		{
			return false;
		}
		if (SmallDBCpath != other.SmallDBCpath)
		{
			return false;
		}
		if (MediumDBCpath != other.MediumDBCpath)
		{
			return false;
		}
		if (MediumBigDBCpath != other.MediumBigDBCpath)
		{
			return false;
		}
		if (BigDBCpath != other.BigDBCpath)
		{
			return false;
		}
		if (HugeDBCpath != other.HugeDBCpath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (AttachNiagaraEventType != EAttachNiagaraEventType.SpiderEggByDetonate)
		{
			num ^= AttachNiagaraEventType.GetHashCode();
		}
		if (Priority != 0)
		{
			num ^= Priority.GetHashCode();
		}
		if (RemoveAttachedNiagaraRule != ERemoveAttachedNiagaraRule.Stack)
		{
			num ^= RemoveAttachedNiagaraRule.GetHashCode();
		}
		if (DBCPath.Length != 0)
		{
			num ^= DBCPath.GetHashCode();
		}
		if (IsUseUnitBodyCondition != EGSYesNo.No)
		{
			num ^= IsUseUnitBodyCondition.GetHashCode();
		}
		if (NoneDBCpath.Length != 0)
		{
			num ^= NoneDBCpath.GetHashCode();
		}
		if (SmallDBCpath.Length != 0)
		{
			num ^= SmallDBCpath.GetHashCode();
		}
		if (MediumDBCpath.Length != 0)
		{
			num ^= MediumDBCpath.GetHashCode();
		}
		if (MediumBigDBCpath.Length != 0)
		{
			num ^= MediumBigDBCpath.GetHashCode();
		}
		if (BigDBCpath.Length != 0)
		{
			num ^= BigDBCpath.GetHashCode();
		}
		if (HugeDBCpath.Length != 0)
		{
			num ^= HugeDBCpath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (ResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ResID);
		}
		if (AttachNiagaraEventType != EAttachNiagaraEventType.SpiderEggByDetonate)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)AttachNiagaraEventType);
		}
		if (Priority != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Priority);
		}
		if (RemoveAttachedNiagaraRule != ERemoveAttachedNiagaraRule.Stack)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)RemoveAttachedNiagaraRule);
		}
		if (DBCPath.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(DBCPath);
		}
		if (IsUseUnitBodyCondition != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)IsUseUnitBodyCondition);
		}
		if (NoneDBCpath.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(NoneDBCpath);
		}
		if (SmallDBCpath.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(SmallDBCpath);
		}
		if (MediumDBCpath.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(MediumDBCpath);
		}
		if (MediumBigDBCpath.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(MediumBigDBCpath);
		}
		if (BigDBCpath.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(BigDBCpath);
		}
		if (HugeDBCpath.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(HugeDBCpath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (AttachNiagaraEventType != EAttachNiagaraEventType.SpiderEggByDetonate)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AttachNiagaraEventType);
		}
		if (Priority != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Priority);
		}
		if (RemoveAttachedNiagaraRule != ERemoveAttachedNiagaraRule.Stack)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RemoveAttachedNiagaraRule);
		}
		if (DBCPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCPath);
		}
		if (IsUseUnitBodyCondition != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsUseUnitBodyCondition);
		}
		if (NoneDBCpath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NoneDBCpath);
		}
		if (SmallDBCpath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SmallDBCpath);
		}
		if (MediumDBCpath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MediumDBCpath);
		}
		if (MediumBigDBCpath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MediumBigDBCpath);
		}
		if (BigDBCpath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BigDBCpath);
		}
		if (HugeDBCpath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HugeDBCpath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAttachedNiagaraByHitDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.AttachNiagaraEventType != EAttachNiagaraEventType.SpiderEggByDetonate)
			{
				AttachNiagaraEventType = other.AttachNiagaraEventType;
			}
			if (other.Priority != 0)
			{
				Priority = other.Priority;
			}
			if (other.RemoveAttachedNiagaraRule != ERemoveAttachedNiagaraRule.Stack)
			{
				RemoveAttachedNiagaraRule = other.RemoveAttachedNiagaraRule;
			}
			if (other.DBCPath.Length != 0)
			{
				DBCPath = other.DBCPath;
			}
			if (other.IsUseUnitBodyCondition != EGSYesNo.No)
			{
				IsUseUnitBodyCondition = other.IsUseUnitBodyCondition;
			}
			if (other.NoneDBCpath.Length != 0)
			{
				NoneDBCpath = other.NoneDBCpath;
			}
			if (other.SmallDBCpath.Length != 0)
			{
				SmallDBCpath = other.SmallDBCpath;
			}
			if (other.MediumDBCpath.Length != 0)
			{
				MediumDBCpath = other.MediumDBCpath;
			}
			if (other.MediumBigDBCpath.Length != 0)
			{
				MediumBigDBCpath = other.MediumBigDBCpath;
			}
			if (other.BigDBCpath.Length != 0)
			{
				BigDBCpath = other.BigDBCpath;
			}
			if (other.HugeDBCpath.Length != 0)
			{
				HugeDBCpath = other.HugeDBCpath;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				ResID = input.ReadInt32();
				break;
			case 24u:
				AttachNiagaraEventType = (EAttachNiagaraEventType)input.ReadEnum();
				break;
			case 32u:
				Priority = input.ReadInt32();
				break;
			case 40u:
				RemoveAttachedNiagaraRule = (ERemoveAttachedNiagaraRule)input.ReadEnum();
				break;
			case 50u:
				DBCPath = input.ReadString();
				break;
			case 56u:
				IsUseUnitBodyCondition = (EGSYesNo)input.ReadEnum();
				break;
			case 66u:
				NoneDBCpath = input.ReadString();
				break;
			case 74u:
				SmallDBCpath = input.ReadString();
				break;
			case 82u:
				MediumDBCpath = input.ReadString();
				break;
			case 90u:
				MediumBigDBCpath = input.ReadString();
				break;
			case 98u:
				BigDBCpath = input.ReadString();
				break;
			case 106u:
				HugeDBCpath = input.ReadString();
				break;
			}
		}
	}
}
