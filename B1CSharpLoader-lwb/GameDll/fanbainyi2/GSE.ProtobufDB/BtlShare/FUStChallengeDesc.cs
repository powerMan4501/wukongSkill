using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class FUStChallengeDesc : IMessage<FUStChallengeDesc>, IMessage, IEquatable<FUStChallengeDesc>, IDeepCloneable<FUStChallengeDesc>
{
	private static readonly MessageParser<FUStChallengeDesc> _parser = new MessageParser<FUStChallengeDesc>(() => new FUStChallengeDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string challengeName_ = "";

	private string challengeDesc_ = "";

	private string interactGuid_ = "";

	private int easyDropId_;

	private int normalDropId_;

	private int hardDropId_;

	private string teleportName_ = "";

	private int range_;

	private int limitTimeEasy_;

	private int limitTimeNormal_;

	private int limitTimeHard_;

	private string easyDesc_ = "";

	private string normalDesc_ = "";

	private string hardDesc_ = "";

	private int awardDelayTime_;

	private EChallengeSuccessType successType_;

	private int localizationTag_;

	public static MessageParser<FUStChallengeDesc> Parser => _parser;

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

	public string ChallengeName
	{
		get
		{
			return challengeName_;
		}
		set
		{
			challengeName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ChallengeDesc
	{
		get
		{
			return challengeDesc_;
		}
		set
		{
			challengeDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string InteractGuid
	{
		get
		{
			return interactGuid_;
		}
		set
		{
			interactGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int EasyDropId
	{
		get
		{
			return easyDropId_;
		}
		set
		{
			easyDropId_ = value;
		}
	}

	public int NormalDropId
	{
		get
		{
			return normalDropId_;
		}
		set
		{
			normalDropId_ = value;
		}
	}

	public int HardDropId
	{
		get
		{
			return hardDropId_;
		}
		set
		{
			hardDropId_ = value;
		}
	}

	public string TeleportName
	{
		get
		{
			return teleportName_;
		}
		set
		{
			teleportName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Range
	{
		get
		{
			return range_;
		}
		set
		{
			range_ = value;
		}
	}

	public int LimitTimeEasy
	{
		get
		{
			return limitTimeEasy_;
		}
		set
		{
			limitTimeEasy_ = value;
		}
	}

	public int LimitTimeNormal
	{
		get
		{
			return limitTimeNormal_;
		}
		set
		{
			limitTimeNormal_ = value;
		}
	}

	public int LimitTimeHard
	{
		get
		{
			return limitTimeHard_;
		}
		set
		{
			limitTimeHard_ = value;
		}
	}

	public string EasyDesc
	{
		get
		{
			return easyDesc_;
		}
		set
		{
			easyDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string NormalDesc
	{
		get
		{
			return normalDesc_;
		}
		set
		{
			normalDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string HardDesc
	{
		get
		{
			return hardDesc_;
		}
		set
		{
			hardDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int AwardDelayTime
	{
		get
		{
			return awardDelayTime_;
		}
		set
		{
			awardDelayTime_ = value;
		}
	}

	public EChallengeSuccessType SuccessType
	{
		get
		{
			return successType_;
		}
		set
		{
			successType_ = value;
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

	public FUStChallengeDesc()
	{
	}

	public FUStChallengeDesc(FUStChallengeDesc other)
		: this()
	{
		iD_ = other.iD_;
		challengeName_ = other.challengeName_;
		challengeDesc_ = other.challengeDesc_;
		interactGuid_ = other.interactGuid_;
		easyDropId_ = other.easyDropId_;
		normalDropId_ = other.normalDropId_;
		hardDropId_ = other.hardDropId_;
		teleportName_ = other.teleportName_;
		range_ = other.range_;
		limitTimeEasy_ = other.limitTimeEasy_;
		limitTimeNormal_ = other.limitTimeNormal_;
		limitTimeHard_ = other.limitTimeHard_;
		easyDesc_ = other.easyDesc_;
		normalDesc_ = other.normalDesc_;
		hardDesc_ = other.hardDesc_;
		awardDelayTime_ = other.awardDelayTime_;
		successType_ = other.successType_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStChallengeDesc Clone()
	{
		return new FUStChallengeDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStChallengeDesc);
	}

	public bool Equals(FUStChallengeDesc other)
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
		if (ChallengeName != other.ChallengeName)
		{
			return false;
		}
		if (ChallengeDesc != other.ChallengeDesc)
		{
			return false;
		}
		if (InteractGuid != other.InteractGuid)
		{
			return false;
		}
		if (EasyDropId != other.EasyDropId)
		{
			return false;
		}
		if (NormalDropId != other.NormalDropId)
		{
			return false;
		}
		if (HardDropId != other.HardDropId)
		{
			return false;
		}
		if (TeleportName != other.TeleportName)
		{
			return false;
		}
		if (Range != other.Range)
		{
			return false;
		}
		if (LimitTimeEasy != other.LimitTimeEasy)
		{
			return false;
		}
		if (LimitTimeNormal != other.LimitTimeNormal)
		{
			return false;
		}
		if (LimitTimeHard != other.LimitTimeHard)
		{
			return false;
		}
		if (EasyDesc != other.EasyDesc)
		{
			return false;
		}
		if (NormalDesc != other.NormalDesc)
		{
			return false;
		}
		if (HardDesc != other.HardDesc)
		{
			return false;
		}
		if (AwardDelayTime != other.AwardDelayTime)
		{
			return false;
		}
		if (SuccessType != other.SuccessType)
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
		if (ChallengeName.Length != 0)
		{
			num ^= ChallengeName.GetHashCode();
		}
		if (ChallengeDesc.Length != 0)
		{
			num ^= ChallengeDesc.GetHashCode();
		}
		if (InteractGuid.Length != 0)
		{
			num ^= InteractGuid.GetHashCode();
		}
		if (EasyDropId != 0)
		{
			num ^= EasyDropId.GetHashCode();
		}
		if (NormalDropId != 0)
		{
			num ^= NormalDropId.GetHashCode();
		}
		if (HardDropId != 0)
		{
			num ^= HardDropId.GetHashCode();
		}
		if (TeleportName.Length != 0)
		{
			num ^= TeleportName.GetHashCode();
		}
		if (Range != 0)
		{
			num ^= Range.GetHashCode();
		}
		if (LimitTimeEasy != 0)
		{
			num ^= LimitTimeEasy.GetHashCode();
		}
		if (LimitTimeNormal != 0)
		{
			num ^= LimitTimeNormal.GetHashCode();
		}
		if (LimitTimeHard != 0)
		{
			num ^= LimitTimeHard.GetHashCode();
		}
		if (EasyDesc.Length != 0)
		{
			num ^= EasyDesc.GetHashCode();
		}
		if (NormalDesc.Length != 0)
		{
			num ^= NormalDesc.GetHashCode();
		}
		if (HardDesc.Length != 0)
		{
			num ^= HardDesc.GetHashCode();
		}
		if (AwardDelayTime != 0)
		{
			num ^= AwardDelayTime.GetHashCode();
		}
		if (SuccessType != EChallengeSuccessType.KillAllUnit)
		{
			num ^= SuccessType.GetHashCode();
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
		if (ChallengeName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ChallengeName);
		}
		if (ChallengeDesc.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ChallengeDesc);
		}
		if (InteractGuid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(InteractGuid);
		}
		if (EasyDropId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(EasyDropId);
		}
		if (NormalDropId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(NormalDropId);
		}
		if (HardDropId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(HardDropId);
		}
		if (TeleportName.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(TeleportName);
		}
		if (Range != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Range);
		}
		if (LimitTimeEasy != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(LimitTimeEasy);
		}
		if (LimitTimeNormal != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(LimitTimeNormal);
		}
		if (LimitTimeHard != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(LimitTimeHard);
		}
		if (EasyDesc.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(EasyDesc);
		}
		if (NormalDesc.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(NormalDesc);
		}
		if (HardDesc.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(HardDesc);
		}
		if (AwardDelayTime != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(AwardDelayTime);
		}
		if (SuccessType != EChallengeSuccessType.KillAllUnit)
		{
			output.WriteRawTag(136, 1);
			output.WriteEnum((int)SuccessType);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(144, 1);
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
		if (ChallengeName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ChallengeName);
		}
		if (ChallengeDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ChallengeDesc);
		}
		if (InteractGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(InteractGuid);
		}
		if (EasyDropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EasyDropId);
		}
		if (NormalDropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NormalDropId);
		}
		if (HardDropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HardDropId);
		}
		if (TeleportName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TeleportName);
		}
		if (Range != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Range);
		}
		if (LimitTimeEasy != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitTimeEasy);
		}
		if (LimitTimeNormal != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitTimeNormal);
		}
		if (LimitTimeHard != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitTimeHard);
		}
		if (EasyDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EasyDesc);
		}
		if (NormalDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NormalDesc);
		}
		if (HardDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HardDesc);
		}
		if (AwardDelayTime != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AwardDelayTime);
		}
		if (SuccessType != EChallengeSuccessType.KillAllUnit)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)SuccessType);
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

	public void MergeFrom(FUStChallengeDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ChallengeName.Length != 0)
			{
				ChallengeName = other.ChallengeName;
			}
			if (other.ChallengeDesc.Length != 0)
			{
				ChallengeDesc = other.ChallengeDesc;
			}
			if (other.InteractGuid.Length != 0)
			{
				InteractGuid = other.InteractGuid;
			}
			if (other.EasyDropId != 0)
			{
				EasyDropId = other.EasyDropId;
			}
			if (other.NormalDropId != 0)
			{
				NormalDropId = other.NormalDropId;
			}
			if (other.HardDropId != 0)
			{
				HardDropId = other.HardDropId;
			}
			if (other.TeleportName.Length != 0)
			{
				TeleportName = other.TeleportName;
			}
			if (other.Range != 0)
			{
				Range = other.Range;
			}
			if (other.LimitTimeEasy != 0)
			{
				LimitTimeEasy = other.LimitTimeEasy;
			}
			if (other.LimitTimeNormal != 0)
			{
				LimitTimeNormal = other.LimitTimeNormal;
			}
			if (other.LimitTimeHard != 0)
			{
				LimitTimeHard = other.LimitTimeHard;
			}
			if (other.EasyDesc.Length != 0)
			{
				EasyDesc = other.EasyDesc;
			}
			if (other.NormalDesc.Length != 0)
			{
				NormalDesc = other.NormalDesc;
			}
			if (other.HardDesc.Length != 0)
			{
				HardDesc = other.HardDesc;
			}
			if (other.AwardDelayTime != 0)
			{
				AwardDelayTime = other.AwardDelayTime;
			}
			if (other.SuccessType != EChallengeSuccessType.KillAllUnit)
			{
				SuccessType = other.SuccessType;
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
				ChallengeName = input.ReadString();
				break;
			case 26u:
				ChallengeDesc = input.ReadString();
				break;
			case 34u:
				InteractGuid = input.ReadString();
				break;
			case 40u:
				EasyDropId = input.ReadInt32();
				break;
			case 48u:
				NormalDropId = input.ReadInt32();
				break;
			case 56u:
				HardDropId = input.ReadInt32();
				break;
			case 66u:
				TeleportName = input.ReadString();
				break;
			case 72u:
				Range = input.ReadInt32();
				break;
			case 80u:
				LimitTimeEasy = input.ReadInt32();
				break;
			case 88u:
				LimitTimeNormal = input.ReadInt32();
				break;
			case 96u:
				LimitTimeHard = input.ReadInt32();
				break;
			case 106u:
				EasyDesc = input.ReadString();
				break;
			case 114u:
				NormalDesc = input.ReadString();
				break;
			case 122u:
				HardDesc = input.ReadString();
				break;
			case 128u:
				AwardDelayTime = input.ReadInt32();
				break;
			case 136u:
				SuccessType = (EChallengeSuccessType)input.ReadEnum();
				break;
			case 144u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
