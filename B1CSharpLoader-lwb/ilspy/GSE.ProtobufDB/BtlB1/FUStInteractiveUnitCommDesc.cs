using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStInteractiveUnitCommDesc : IMessage<FUStInteractiveUnitCommDesc>, IMessage, IEquatable<FUStInteractiveUnitCommDesc>, IDeepCloneable<FUStInteractiveUnitCommDesc>
{
	private static readonly MessageParser<FUStInteractiveUnitCommDesc> _parser = new MessageParser<FUStInteractiveUnitCommDesc>(() => new FUStInteractiveUnitCommDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string name_ = "";

	private float interactDistance_;

	private float interactAngle_;

	private float activableDistance_;

	private int breakDistance_;

	private EGSYesNo ignorePlayerOrientation_;

	private string focusIconPath_ = "";

	private EInteractType interactType_;

	private int defaultTask_;

	private string highLightFXPath_ = "";

	private int highLightFXActiveRange_;

	private int handbookCardID_;

	private EGSYesNo netGameSync_;

	private EGSYesNo netGameMultiInteract_;

	private string talentHighLightFXPath_ = "";

	private int localizationTag_;

	public static MessageParser<FUStInteractiveUnitCommDesc> Parser => _parser;

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

	public float InteractDistance
	{
		get
		{
			return interactDistance_;
		}
		set
		{
			interactDistance_ = value;
		}
	}

	public float InteractAngle
	{
		get
		{
			return interactAngle_;
		}
		set
		{
			interactAngle_ = value;
		}
	}

	public float ActivableDistance
	{
		get
		{
			return activableDistance_;
		}
		set
		{
			activableDistance_ = value;
		}
	}

	public int BreakDistance
	{
		get
		{
			return breakDistance_;
		}
		set
		{
			breakDistance_ = value;
		}
	}

	public EGSYesNo IgnorePlayerOrientation
	{
		get
		{
			return ignorePlayerOrientation_;
		}
		set
		{
			ignorePlayerOrientation_ = value;
		}
	}

	public string FocusIconPath
	{
		get
		{
			return focusIconPath_;
		}
		set
		{
			focusIconPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EInteractType InteractType
	{
		get
		{
			return interactType_;
		}
		set
		{
			interactType_ = value;
		}
	}

	public int DefaultTask
	{
		get
		{
			return defaultTask_;
		}
		set
		{
			defaultTask_ = value;
		}
	}

	public string HighLightFXPath
	{
		get
		{
			return highLightFXPath_;
		}
		set
		{
			highLightFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int HighLightFXActiveRange
	{
		get
		{
			return highLightFXActiveRange_;
		}
		set
		{
			highLightFXActiveRange_ = value;
		}
	}

	public int HandbookCardID
	{
		get
		{
			return handbookCardID_;
		}
		set
		{
			handbookCardID_ = value;
		}
	}

	public EGSYesNo NetGameSync
	{
		get
		{
			return netGameSync_;
		}
		set
		{
			netGameSync_ = value;
		}
	}

	public EGSYesNo NetGameMultiInteract
	{
		get
		{
			return netGameMultiInteract_;
		}
		set
		{
			netGameMultiInteract_ = value;
		}
	}

	public string TalentHighLightFXPath
	{
		get
		{
			return talentHighLightFXPath_;
		}
		set
		{
			talentHighLightFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public FUStInteractiveUnitCommDesc()
	{
	}

	public FUStInteractiveUnitCommDesc(FUStInteractiveUnitCommDesc other)
		: this()
	{
		iD_ = other.iD_;
		name_ = other.name_;
		interactDistance_ = other.interactDistance_;
		interactAngle_ = other.interactAngle_;
		activableDistance_ = other.activableDistance_;
		breakDistance_ = other.breakDistance_;
		ignorePlayerOrientation_ = other.ignorePlayerOrientation_;
		focusIconPath_ = other.focusIconPath_;
		interactType_ = other.interactType_;
		defaultTask_ = other.defaultTask_;
		highLightFXPath_ = other.highLightFXPath_;
		highLightFXActiveRange_ = other.highLightFXActiveRange_;
		handbookCardID_ = other.handbookCardID_;
		netGameSync_ = other.netGameSync_;
		netGameMultiInteract_ = other.netGameMultiInteract_;
		talentHighLightFXPath_ = other.talentHighLightFXPath_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStInteractiveUnitCommDesc Clone()
	{
		return new FUStInteractiveUnitCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStInteractiveUnitCommDesc);
	}

	public bool Equals(FUStInteractiveUnitCommDesc other)
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
		if (Name != other.Name)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InteractDistance, other.InteractDistance))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InteractAngle, other.InteractAngle))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ActivableDistance, other.ActivableDistance))
		{
			return false;
		}
		if (BreakDistance != other.BreakDistance)
		{
			return false;
		}
		if (IgnorePlayerOrientation != other.IgnorePlayerOrientation)
		{
			return false;
		}
		if (FocusIconPath != other.FocusIconPath)
		{
			return false;
		}
		if (InteractType != other.InteractType)
		{
			return false;
		}
		if (DefaultTask != other.DefaultTask)
		{
			return false;
		}
		if (HighLightFXPath != other.HighLightFXPath)
		{
			return false;
		}
		if (HighLightFXActiveRange != other.HighLightFXActiveRange)
		{
			return false;
		}
		if (HandbookCardID != other.HandbookCardID)
		{
			return false;
		}
		if (NetGameSync != other.NetGameSync)
		{
			return false;
		}
		if (NetGameMultiInteract != other.NetGameMultiInteract)
		{
			return false;
		}
		if (TalentHighLightFXPath != other.TalentHighLightFXPath)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (InteractDistance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InteractDistance);
		}
		if (InteractAngle != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InteractAngle);
		}
		if (ActivableDistance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ActivableDistance);
		}
		if (BreakDistance != 0)
		{
			num ^= BreakDistance.GetHashCode();
		}
		if (IgnorePlayerOrientation != EGSYesNo.No)
		{
			num ^= IgnorePlayerOrientation.GetHashCode();
		}
		if (FocusIconPath.Length != 0)
		{
			num ^= FocusIconPath.GetHashCode();
		}
		if (InteractType != EInteractType.None)
		{
			num ^= InteractType.GetHashCode();
		}
		if (DefaultTask != 0)
		{
			num ^= DefaultTask.GetHashCode();
		}
		if (HighLightFXPath.Length != 0)
		{
			num ^= HighLightFXPath.GetHashCode();
		}
		if (HighLightFXActiveRange != 0)
		{
			num ^= HighLightFXActiveRange.GetHashCode();
		}
		if (HandbookCardID != 0)
		{
			num ^= HandbookCardID.GetHashCode();
		}
		if (NetGameSync != EGSYesNo.No)
		{
			num ^= NetGameSync.GetHashCode();
		}
		if (NetGameMultiInteract != EGSYesNo.No)
		{
			num ^= NetGameMultiInteract.GetHashCode();
		}
		if (TalentHighLightFXPath.Length != 0)
		{
			num ^= TalentHighLightFXPath.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (InteractDistance != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(InteractDistance);
		}
		if (InteractAngle != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(InteractAngle);
		}
		if (ActivableDistance != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(ActivableDistance);
		}
		if (BreakDistance != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BreakDistance);
		}
		if (IgnorePlayerOrientation != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)IgnorePlayerOrientation);
		}
		if (FocusIconPath.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(FocusIconPath);
		}
		if (InteractType != EInteractType.None)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)InteractType);
		}
		if (DefaultTask != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(DefaultTask);
		}
		if (HighLightFXPath.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(HighLightFXPath);
		}
		if (HighLightFXActiveRange != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(HighLightFXActiveRange);
		}
		if (HandbookCardID != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(HandbookCardID);
		}
		if (NetGameSync != EGSYesNo.No)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)NetGameSync);
		}
		if (NetGameMultiInteract != EGSYesNo.No)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)NetGameMultiInteract);
		}
		if (TalentHighLightFXPath.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(TalentHighLightFXPath);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(LocalizationTag);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (InteractDistance != 0f)
		{
			num += 5;
		}
		if (InteractAngle != 0f)
		{
			num += 5;
		}
		if (ActivableDistance != 0f)
		{
			num += 5;
		}
		if (BreakDistance != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BreakDistance);
		}
		if (IgnorePlayerOrientation != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IgnorePlayerOrientation);
		}
		if (FocusIconPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FocusIconPath);
		}
		if (InteractType != EInteractType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)InteractType);
		}
		if (DefaultTask != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultTask);
		}
		if (HighLightFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HighLightFXPath);
		}
		if (HighLightFXActiveRange != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HighLightFXActiveRange);
		}
		if (HandbookCardID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HandbookCardID);
		}
		if (NetGameSync != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NetGameSync);
		}
		if (NetGameMultiInteract != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NetGameMultiInteract);
		}
		if (TalentHighLightFXPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(TalentHighLightFXPath);
		}
		if (LocalizationTag != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStInteractiveUnitCommDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.InteractDistance != 0f)
			{
				InteractDistance = other.InteractDistance;
			}
			if (other.InteractAngle != 0f)
			{
				InteractAngle = other.InteractAngle;
			}
			if (other.ActivableDistance != 0f)
			{
				ActivableDistance = other.ActivableDistance;
			}
			if (other.BreakDistance != 0)
			{
				BreakDistance = other.BreakDistance;
			}
			if (other.IgnorePlayerOrientation != EGSYesNo.No)
			{
				IgnorePlayerOrientation = other.IgnorePlayerOrientation;
			}
			if (other.FocusIconPath.Length != 0)
			{
				FocusIconPath = other.FocusIconPath;
			}
			if (other.InteractType != EInteractType.None)
			{
				InteractType = other.InteractType;
			}
			if (other.DefaultTask != 0)
			{
				DefaultTask = other.DefaultTask;
			}
			if (other.HighLightFXPath.Length != 0)
			{
				HighLightFXPath = other.HighLightFXPath;
			}
			if (other.HighLightFXActiveRange != 0)
			{
				HighLightFXActiveRange = other.HighLightFXActiveRange;
			}
			if (other.HandbookCardID != 0)
			{
				HandbookCardID = other.HandbookCardID;
			}
			if (other.NetGameSync != EGSYesNo.No)
			{
				NetGameSync = other.NetGameSync;
			}
			if (other.NetGameMultiInteract != EGSYesNo.No)
			{
				NetGameMultiInteract = other.NetGameMultiInteract;
			}
			if (other.TalentHighLightFXPath.Length != 0)
			{
				TalentHighLightFXPath = other.TalentHighLightFXPath;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
			case 18u:
				Name = input.ReadString();
				break;
			case 29u:
				InteractDistance = input.ReadFloat();
				break;
			case 37u:
				InteractAngle = input.ReadFloat();
				break;
			case 45u:
				ActivableDistance = input.ReadFloat();
				break;
			case 48u:
				BreakDistance = input.ReadInt32();
				break;
			case 56u:
				IgnorePlayerOrientation = (EGSYesNo)input.ReadEnum();
				break;
			case 66u:
				FocusIconPath = input.ReadString();
				break;
			case 72u:
				InteractType = (EInteractType)input.ReadEnum();
				break;
			case 80u:
				DefaultTask = input.ReadInt32();
				break;
			case 90u:
				HighLightFXPath = input.ReadString();
				break;
			case 96u:
				HighLightFXActiveRange = input.ReadInt32();
				break;
			case 104u:
				HandbookCardID = input.ReadInt32();
				break;
			case 112u:
				NetGameSync = (EGSYesNo)input.ReadEnum();
				break;
			case 120u:
				NetGameMultiInteract = (EGSYesNo)input.ReadEnum();
				break;
			case 130u:
				TalentHighLightFXPath = input.ReadString();
				break;
			case 136u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
