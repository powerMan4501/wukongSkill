using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStUnitFootstepDesc : IMessage<FUStUnitFootstepDesc>, IMessage, IEquatable<FUStUnitFootstepDesc>, IDeepCloneable<FUStUnitFootstepDesc>
{
	private static readonly MessageParser<FUStUnitFootstepDesc> _parser = new MessageParser<FUStUnitFootstepDesc>(() => new FUStUnitFootstepDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int unitResID_;

	private ESceneItemSurfaceType sceneItemSurfaceType_;

	private EGSYesNo showFootDecal_;

	private string walkLeftFootFXPath_ = "";

	private string walkRightFootFXPath_ = "";

	private string runLeftFootFXPath_ = "";

	private string runRightFootFXPath_ = "";

	private string sprintLeftFootFXPath_ = "";

	private string sprintRightFootFXPath_ = "";

	private string leftFootDecalDBC_ = "";

	private string rightFootDecalDBC_ = "";

	private ELandFXPlayType landFXPlayType_;

	private string littleFallLandFXPath_ = "";

	private string middleFallLandFXPath_ = "";

	private string highFallLandFXPath_ = "";

	public static MessageParser<FUStUnitFootstepDesc> Parser => _parser;

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

	public int UnitResID
	{
		get
		{
			return unitResID_;
		}
		set
		{
			unitResID_ = value;
		}
	}

	public ESceneItemSurfaceType SceneItemSurfaceType
	{
		get
		{
			return sceneItemSurfaceType_;
		}
		set
		{
			sceneItemSurfaceType_ = value;
		}
	}

	public EGSYesNo ShowFootDecal
	{
		get
		{
			return showFootDecal_;
		}
		set
		{
			showFootDecal_ = value;
		}
	}

	public string WalkLeftFootFXPath
	{
		get
		{
			return walkLeftFootFXPath_;
		}
		set
		{
			walkLeftFootFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string WalkRightFootFXPath
	{
		get
		{
			return walkRightFootFXPath_;
		}
		set
		{
			walkRightFootFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RunLeftFootFXPath
	{
		get
		{
			return runLeftFootFXPath_;
		}
		set
		{
			runLeftFootFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RunRightFootFXPath
	{
		get
		{
			return runRightFootFXPath_;
		}
		set
		{
			runRightFootFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SprintLeftFootFXPath
	{
		get
		{
			return sprintLeftFootFXPath_;
		}
		set
		{
			sprintLeftFootFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SprintRightFootFXPath
	{
		get
		{
			return sprintRightFootFXPath_;
		}
		set
		{
			sprintRightFootFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LeftFootDecalDBC
	{
		get
		{
			return leftFootDecalDBC_;
		}
		set
		{
			leftFootDecalDBC_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RightFootDecalDBC
	{
		get
		{
			return rightFootDecalDBC_;
		}
		set
		{
			rightFootDecalDBC_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ELandFXPlayType LandFXPlayType
	{
		get
		{
			return landFXPlayType_;
		}
		set
		{
			landFXPlayType_ = value;
		}
	}

	public string LittleFallLandFXPath
	{
		get
		{
			return littleFallLandFXPath_;
		}
		set
		{
			littleFallLandFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MiddleFallLandFXPath
	{
		get
		{
			return middleFallLandFXPath_;
		}
		set
		{
			middleFallLandFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string HighFallLandFXPath
	{
		get
		{
			return highFallLandFXPath_;
		}
		set
		{
			highFallLandFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStUnitFootstepDesc()
	{
	}

	public FUStUnitFootstepDesc(FUStUnitFootstepDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitResID_ = other.unitResID_;
		sceneItemSurfaceType_ = other.sceneItemSurfaceType_;
		showFootDecal_ = other.showFootDecal_;
		walkLeftFootFXPath_ = other.walkLeftFootFXPath_;
		walkRightFootFXPath_ = other.walkRightFootFXPath_;
		runLeftFootFXPath_ = other.runLeftFootFXPath_;
		runRightFootFXPath_ = other.runRightFootFXPath_;
		sprintLeftFootFXPath_ = other.sprintLeftFootFXPath_;
		sprintRightFootFXPath_ = other.sprintRightFootFXPath_;
		leftFootDecalDBC_ = other.leftFootDecalDBC_;
		rightFootDecalDBC_ = other.rightFootDecalDBC_;
		landFXPlayType_ = other.landFXPlayType_;
		littleFallLandFXPath_ = other.littleFallLandFXPath_;
		middleFallLandFXPath_ = other.middleFallLandFXPath_;
		highFallLandFXPath_ = other.highFallLandFXPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitFootstepDesc Clone()
	{
		return new FUStUnitFootstepDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitFootstepDesc);
	}

	public bool Equals(FUStUnitFootstepDesc other)
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
		if (UnitResID != other.UnitResID)
		{
			return false;
		}
		if (SceneItemSurfaceType != other.SceneItemSurfaceType)
		{
			return false;
		}
		if (ShowFootDecal != other.ShowFootDecal)
		{
			return false;
		}
		if (WalkLeftFootFXPath != other.WalkLeftFootFXPath)
		{
			return false;
		}
		if (WalkRightFootFXPath != other.WalkRightFootFXPath)
		{
			return false;
		}
		if (RunLeftFootFXPath != other.RunLeftFootFXPath)
		{
			return false;
		}
		if (RunRightFootFXPath != other.RunRightFootFXPath)
		{
			return false;
		}
		if (SprintLeftFootFXPath != other.SprintLeftFootFXPath)
		{
			return false;
		}
		if (SprintRightFootFXPath != other.SprintRightFootFXPath)
		{
			return false;
		}
		if (LeftFootDecalDBC != other.LeftFootDecalDBC)
		{
			return false;
		}
		if (RightFootDecalDBC != other.RightFootDecalDBC)
		{
			return false;
		}
		if (LandFXPlayType != other.LandFXPlayType)
		{
			return false;
		}
		if (LittleFallLandFXPath != other.LittleFallLandFXPath)
		{
			return false;
		}
		if (MiddleFallLandFXPath != other.MiddleFallLandFXPath)
		{
			return false;
		}
		if (HighFallLandFXPath != other.HighFallLandFXPath)
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
		if (UnitResID != 0)
		{
			num ^= UnitResID.GetHashCode();
		}
		if (SceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			num ^= SceneItemSurfaceType.GetHashCode();
		}
		if (ShowFootDecal != EGSYesNo.No)
		{
			num ^= ShowFootDecal.GetHashCode();
		}
		if (WalkLeftFootFXPath.Length != 0)
		{
			num ^= WalkLeftFootFXPath.GetHashCode();
		}
		if (WalkRightFootFXPath.Length != 0)
		{
			num ^= WalkRightFootFXPath.GetHashCode();
		}
		if (RunLeftFootFXPath.Length != 0)
		{
			num ^= RunLeftFootFXPath.GetHashCode();
		}
		if (RunRightFootFXPath.Length != 0)
		{
			num ^= RunRightFootFXPath.GetHashCode();
		}
		if (SprintLeftFootFXPath.Length != 0)
		{
			num ^= SprintLeftFootFXPath.GetHashCode();
		}
		if (SprintRightFootFXPath.Length != 0)
		{
			num ^= SprintRightFootFXPath.GetHashCode();
		}
		if (LeftFootDecalDBC.Length != 0)
		{
			num ^= LeftFootDecalDBC.GetHashCode();
		}
		if (RightFootDecalDBC.Length != 0)
		{
			num ^= RightFootDecalDBC.GetHashCode();
		}
		if (LandFXPlayType != ELandFXPlayType.JustOnRoot)
		{
			num ^= LandFXPlayType.GetHashCode();
		}
		if (LittleFallLandFXPath.Length != 0)
		{
			num ^= LittleFallLandFXPath.GetHashCode();
		}
		if (MiddleFallLandFXPath.Length != 0)
		{
			num ^= MiddleFallLandFXPath.GetHashCode();
		}
		if (HighFallLandFXPath.Length != 0)
		{
			num ^= HighFallLandFXPath.GetHashCode();
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
		if (UnitResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UnitResID);
		}
		if (SceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)SceneItemSurfaceType);
		}
		if (ShowFootDecal != EGSYesNo.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ShowFootDecal);
		}
		if (WalkLeftFootFXPath.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(WalkLeftFootFXPath);
		}
		if (WalkRightFootFXPath.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(WalkRightFootFXPath);
		}
		if (RunLeftFootFXPath.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(RunLeftFootFXPath);
		}
		if (RunRightFootFXPath.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(RunRightFootFXPath);
		}
		if (SprintLeftFootFXPath.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(SprintLeftFootFXPath);
		}
		if (SprintRightFootFXPath.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(SprintRightFootFXPath);
		}
		if (LeftFootDecalDBC.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(LeftFootDecalDBC);
		}
		if (RightFootDecalDBC.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(RightFootDecalDBC);
		}
		if (LandFXPlayType != ELandFXPlayType.JustOnRoot)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)LandFXPlayType);
		}
		if (LittleFallLandFXPath.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(LittleFallLandFXPath);
		}
		if (MiddleFallLandFXPath.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(MiddleFallLandFXPath);
		}
		if (HighFallLandFXPath.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(HighFallLandFXPath);
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
		if (UnitResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitResID);
		}
		if (SceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SceneItemSurfaceType);
		}
		if (ShowFootDecal != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ShowFootDecal);
		}
		if (WalkLeftFootFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(WalkLeftFootFXPath);
		}
		if (WalkRightFootFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(WalkRightFootFXPath);
		}
		if (RunLeftFootFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RunLeftFootFXPath);
		}
		if (RunRightFootFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RunRightFootFXPath);
		}
		if (SprintLeftFootFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SprintLeftFootFXPath);
		}
		if (SprintRightFootFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SprintRightFootFXPath);
		}
		if (LeftFootDecalDBC.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LeftFootDecalDBC);
		}
		if (RightFootDecalDBC.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RightFootDecalDBC);
		}
		if (LandFXPlayType != ELandFXPlayType.JustOnRoot)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LandFXPlayType);
		}
		if (LittleFallLandFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LittleFallLandFXPath);
		}
		if (MiddleFallLandFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MiddleFallLandFXPath);
		}
		if (HighFallLandFXPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(HighFallLandFXPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitFootstepDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.UnitResID != 0)
			{
				UnitResID = other.UnitResID;
			}
			if (other.SceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
			{
				SceneItemSurfaceType = other.SceneItemSurfaceType;
			}
			if (other.ShowFootDecal != EGSYesNo.No)
			{
				ShowFootDecal = other.ShowFootDecal;
			}
			if (other.WalkLeftFootFXPath.Length != 0)
			{
				WalkLeftFootFXPath = other.WalkLeftFootFXPath;
			}
			if (other.WalkRightFootFXPath.Length != 0)
			{
				WalkRightFootFXPath = other.WalkRightFootFXPath;
			}
			if (other.RunLeftFootFXPath.Length != 0)
			{
				RunLeftFootFXPath = other.RunLeftFootFXPath;
			}
			if (other.RunRightFootFXPath.Length != 0)
			{
				RunRightFootFXPath = other.RunRightFootFXPath;
			}
			if (other.SprintLeftFootFXPath.Length != 0)
			{
				SprintLeftFootFXPath = other.SprintLeftFootFXPath;
			}
			if (other.SprintRightFootFXPath.Length != 0)
			{
				SprintRightFootFXPath = other.SprintRightFootFXPath;
			}
			if (other.LeftFootDecalDBC.Length != 0)
			{
				LeftFootDecalDBC = other.LeftFootDecalDBC;
			}
			if (other.RightFootDecalDBC.Length != 0)
			{
				RightFootDecalDBC = other.RightFootDecalDBC;
			}
			if (other.LandFXPlayType != ELandFXPlayType.JustOnRoot)
			{
				LandFXPlayType = other.LandFXPlayType;
			}
			if (other.LittleFallLandFXPath.Length != 0)
			{
				LittleFallLandFXPath = other.LittleFallLandFXPath;
			}
			if (other.MiddleFallLandFXPath.Length != 0)
			{
				MiddleFallLandFXPath = other.MiddleFallLandFXPath;
			}
			if (other.HighFallLandFXPath.Length != 0)
			{
				HighFallLandFXPath = other.HighFallLandFXPath;
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
				UnitResID = input.ReadInt32();
				break;
			case 24u:
				SceneItemSurfaceType = (ESceneItemSurfaceType)input.ReadEnum();
				break;
			case 32u:
				ShowFootDecal = (EGSYesNo)input.ReadEnum();
				break;
			case 42u:
				WalkLeftFootFXPath = input.ReadString();
				break;
			case 50u:
				WalkRightFootFXPath = input.ReadString();
				break;
			case 58u:
				RunLeftFootFXPath = input.ReadString();
				break;
			case 66u:
				RunRightFootFXPath = input.ReadString();
				break;
			case 74u:
				SprintLeftFootFXPath = input.ReadString();
				break;
			case 82u:
				SprintRightFootFXPath = input.ReadString();
				break;
			case 90u:
				LeftFootDecalDBC = input.ReadString();
				break;
			case 98u:
				RightFootDecalDBC = input.ReadString();
				break;
			case 104u:
				LandFXPlayType = (ELandFXPlayType)input.ReadEnum();
				break;
			case 114u:
				LittleFallLandFXPath = input.ReadString();
				break;
			case 122u:
				MiddleFallLandFXPath = input.ReadString();
				break;
			case 130u:
				HighFallLandFXPath = input.ReadString();
				break;
			}
		}
	}
}
