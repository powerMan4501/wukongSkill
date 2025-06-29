using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStMovieSequenceDesc : IMessage<FUStMovieSequenceDesc>, IMessage, IEquatable<FUStMovieSequenceDesc>, IDeepCloneable<FUStMovieSequenceDesc>
{
	private static readonly MessageParser<FUStMovieSequenceDesc> _parser = new MessageParser<FUStMovieSequenceDesc>(() => new FUStMovieSequenceDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string seqDesc_ = "";

	private ESequenceType sequenceType_;

	private EPlayType playType_;

	private ESkipMode skipMode_;

	private ESkipType skipType_;

	private EGSYesNo isTriggerMonsterGoHome_;

	private EGSYesNo isNeedStopBGM_;

	private EGSYesNo isNeedStopEnvSound_;

	private EACInterruptType interruptAiConversationType_;

	private string movieGraphPath_ = "";

	private float matchingPosTime_;

	private EGSYesNo isNeedKeepHPPPV_;

	private EGSYesNo canSaveArchive_;

	private EGSYesNo isHideDropFX_;

	private ESeqHiddenHeadType playerLSPHiddenHeadType_;

	private EGSYesNo isNeedHideFollowPartner_;

	private ESeqClockSource clockSource_;

	public static MessageParser<FUStMovieSequenceDesc> Parser => _parser;

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

	public string SeqDesc
	{
		get
		{
			return seqDesc_;
		}
		set
		{
			seqDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ESequenceType SequenceType
	{
		get
		{
			return sequenceType_;
		}
		set
		{
			sequenceType_ = value;
		}
	}

	public EPlayType PlayType
	{
		get
		{
			return playType_;
		}
		set
		{
			playType_ = value;
		}
	}

	public ESkipMode SkipMode
	{
		get
		{
			return skipMode_;
		}
		set
		{
			skipMode_ = value;
		}
	}

	public ESkipType SkipType
	{
		get
		{
			return skipType_;
		}
		set
		{
			skipType_ = value;
		}
	}

	public EGSYesNo IsTriggerMonsterGoHome
	{
		get
		{
			return isTriggerMonsterGoHome_;
		}
		set
		{
			isTriggerMonsterGoHome_ = value;
		}
	}

	public EGSYesNo IsNeedStopBGM
	{
		get
		{
			return isNeedStopBGM_;
		}
		set
		{
			isNeedStopBGM_ = value;
		}
	}

	public EGSYesNo IsNeedStopEnvSound
	{
		get
		{
			return isNeedStopEnvSound_;
		}
		set
		{
			isNeedStopEnvSound_ = value;
		}
	}

	public EACInterruptType InterruptAiConversationType
	{
		get
		{
			return interruptAiConversationType_;
		}
		set
		{
			interruptAiConversationType_ = value;
		}
	}

	public string MovieGraphPath
	{
		get
		{
			return movieGraphPath_;
		}
		set
		{
			movieGraphPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float MatchingPosTime
	{
		get
		{
			return matchingPosTime_;
		}
		set
		{
			matchingPosTime_ = value;
		}
	}

	public EGSYesNo IsNeedKeepHPPPV
	{
		get
		{
			return isNeedKeepHPPPV_;
		}
		set
		{
			isNeedKeepHPPPV_ = value;
		}
	}

	public EGSYesNo CanSaveArchive
	{
		get
		{
			return canSaveArchive_;
		}
		set
		{
			canSaveArchive_ = value;
		}
	}

	public EGSYesNo IsHideDropFX
	{
		get
		{
			return isHideDropFX_;
		}
		set
		{
			isHideDropFX_ = value;
		}
	}

	public ESeqHiddenHeadType PlayerLSPHiddenHeadType
	{
		get
		{
			return playerLSPHiddenHeadType_;
		}
		set
		{
			playerLSPHiddenHeadType_ = value;
		}
	}

	public EGSYesNo IsNeedHideFollowPartner
	{
		get
		{
			return isNeedHideFollowPartner_;
		}
		set
		{
			isNeedHideFollowPartner_ = value;
		}
	}

	public ESeqClockSource ClockSource
	{
		get
		{
			return clockSource_;
		}
		set
		{
			clockSource_ = value;
		}
	}

	public FUStMovieSequenceDesc()
	{
	}

	public FUStMovieSequenceDesc(FUStMovieSequenceDesc other)
		: this()
	{
		iD_ = other.iD_;
		seqDesc_ = other.seqDesc_;
		sequenceType_ = other.sequenceType_;
		playType_ = other.playType_;
		skipMode_ = other.skipMode_;
		skipType_ = other.skipType_;
		isTriggerMonsterGoHome_ = other.isTriggerMonsterGoHome_;
		isNeedStopBGM_ = other.isNeedStopBGM_;
		isNeedStopEnvSound_ = other.isNeedStopEnvSound_;
		interruptAiConversationType_ = other.interruptAiConversationType_;
		movieGraphPath_ = other.movieGraphPath_;
		matchingPosTime_ = other.matchingPosTime_;
		isNeedKeepHPPPV_ = other.isNeedKeepHPPPV_;
		canSaveArchive_ = other.canSaveArchive_;
		isHideDropFX_ = other.isHideDropFX_;
		playerLSPHiddenHeadType_ = other.playerLSPHiddenHeadType_;
		isNeedHideFollowPartner_ = other.isNeedHideFollowPartner_;
		clockSource_ = other.clockSource_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStMovieSequenceDesc Clone()
	{
		return new FUStMovieSequenceDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStMovieSequenceDesc);
	}

	public bool Equals(FUStMovieSequenceDesc other)
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
		if (SeqDesc != other.SeqDesc)
		{
			return false;
		}
		if (SequenceType != other.SequenceType)
		{
			return false;
		}
		if (PlayType != other.PlayType)
		{
			return false;
		}
		if (SkipMode != other.SkipMode)
		{
			return false;
		}
		if (SkipType != other.SkipType)
		{
			return false;
		}
		if (IsTriggerMonsterGoHome != other.IsTriggerMonsterGoHome)
		{
			return false;
		}
		if (IsNeedStopBGM != other.IsNeedStopBGM)
		{
			return false;
		}
		if (IsNeedStopEnvSound != other.IsNeedStopEnvSound)
		{
			return false;
		}
		if (InterruptAiConversationType != other.InterruptAiConversationType)
		{
			return false;
		}
		if (MovieGraphPath != other.MovieGraphPath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MatchingPosTime, other.MatchingPosTime))
		{
			return false;
		}
		if (IsNeedKeepHPPPV != other.IsNeedKeepHPPPV)
		{
			return false;
		}
		if (CanSaveArchive != other.CanSaveArchive)
		{
			return false;
		}
		if (IsHideDropFX != other.IsHideDropFX)
		{
			return false;
		}
		if (PlayerLSPHiddenHeadType != other.PlayerLSPHiddenHeadType)
		{
			return false;
		}
		if (IsNeedHideFollowPartner != other.IsNeedHideFollowPartner)
		{
			return false;
		}
		if (ClockSource != other.ClockSource)
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
		if (SeqDesc.Length != 0)
		{
			num ^= SeqDesc.GetHashCode();
		}
		if (SequenceType != ESequenceType.None)
		{
			num ^= SequenceType.GetHashCode();
		}
		if (PlayType != EPlayType.None)
		{
			num ^= PlayType.GetHashCode();
		}
		if (SkipMode != ESkipMode.None)
		{
			num ^= SkipMode.GetHashCode();
		}
		if (SkipType != ESkipType.None)
		{
			num ^= SkipType.GetHashCode();
		}
		if (IsTriggerMonsterGoHome != EGSYesNo.No)
		{
			num ^= IsTriggerMonsterGoHome.GetHashCode();
		}
		if (IsNeedStopBGM != EGSYesNo.No)
		{
			num ^= IsNeedStopBGM.GetHashCode();
		}
		if (IsNeedStopEnvSound != EGSYesNo.No)
		{
			num ^= IsNeedStopEnvSound.GetHashCode();
		}
		if (InterruptAiConversationType != EACInterruptType.None)
		{
			num ^= InterruptAiConversationType.GetHashCode();
		}
		if (MovieGraphPath.Length != 0)
		{
			num ^= MovieGraphPath.GetHashCode();
		}
		if (MatchingPosTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MatchingPosTime);
		}
		if (IsNeedKeepHPPPV != EGSYesNo.No)
		{
			num ^= IsNeedKeepHPPPV.GetHashCode();
		}
		if (CanSaveArchive != EGSYesNo.No)
		{
			num ^= CanSaveArchive.GetHashCode();
		}
		if (IsHideDropFX != EGSYesNo.No)
		{
			num ^= IsHideDropFX.GetHashCode();
		}
		if (PlayerLSPHiddenHeadType != ESeqHiddenHeadType.NoHidden)
		{
			num ^= PlayerLSPHiddenHeadType.GetHashCode();
		}
		if (IsNeedHideFollowPartner != EGSYesNo.No)
		{
			num ^= IsNeedHideFollowPartner.GetHashCode();
		}
		if (ClockSource != ESeqClockSource.Tick)
		{
			num ^= ClockSource.GetHashCode();
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
		if (SeqDesc.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SeqDesc);
		}
		if (SequenceType != ESequenceType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)SequenceType);
		}
		if (PlayType != EPlayType.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)PlayType);
		}
		if (SkipMode != ESkipMode.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)SkipMode);
		}
		if (SkipType != ESkipType.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)SkipType);
		}
		if (IsTriggerMonsterGoHome != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)IsTriggerMonsterGoHome);
		}
		if (IsNeedStopBGM != EGSYesNo.No)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)IsNeedStopBGM);
		}
		if (IsNeedStopEnvSound != EGSYesNo.No)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)IsNeedStopEnvSound);
		}
		if (InterruptAiConversationType != EACInterruptType.None)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)InterruptAiConversationType);
		}
		if (MovieGraphPath.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(MovieGraphPath);
		}
		if (MatchingPosTime != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(MatchingPosTime);
		}
		if (IsNeedKeepHPPPV != EGSYesNo.No)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)IsNeedKeepHPPPV);
		}
		if (CanSaveArchive != EGSYesNo.No)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)CanSaveArchive);
		}
		if (IsHideDropFX != EGSYesNo.No)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)IsHideDropFX);
		}
		if (PlayerLSPHiddenHeadType != ESeqHiddenHeadType.NoHidden)
		{
			output.WriteRawTag(128, 1);
			output.WriteEnum((int)PlayerLSPHiddenHeadType);
		}
		if (IsNeedHideFollowPartner != EGSYesNo.No)
		{
			output.WriteRawTag(136, 1);
			output.WriteEnum((int)IsNeedHideFollowPartner);
		}
		if (ClockSource != ESeqClockSource.Tick)
		{
			output.WriteRawTag(144, 1);
			output.WriteEnum((int)ClockSource);
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
		if (SeqDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SeqDesc);
		}
		if (SequenceType != ESequenceType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SequenceType);
		}
		if (PlayType != EPlayType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PlayType);
		}
		if (SkipMode != ESkipMode.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkipMode);
		}
		if (SkipType != ESkipType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkipType);
		}
		if (IsTriggerMonsterGoHome != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsTriggerMonsterGoHome);
		}
		if (IsNeedStopBGM != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsNeedStopBGM);
		}
		if (IsNeedStopEnvSound != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsNeedStopEnvSound);
		}
		if (InterruptAiConversationType != EACInterruptType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)InterruptAiConversationType);
		}
		if (MovieGraphPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MovieGraphPath);
		}
		if (MatchingPosTime != 0f)
		{
			num += 5;
		}
		if (IsNeedKeepHPPPV != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsNeedKeepHPPPV);
		}
		if (CanSaveArchive != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanSaveArchive);
		}
		if (IsHideDropFX != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsHideDropFX);
		}
		if (PlayerLSPHiddenHeadType != ESeqHiddenHeadType.NoHidden)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)PlayerLSPHiddenHeadType);
		}
		if (IsNeedHideFollowPartner != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsNeedHideFollowPartner);
		}
		if (ClockSource != ESeqClockSource.Tick)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)ClockSource);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStMovieSequenceDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.SeqDesc.Length != 0)
			{
				SeqDesc = other.SeqDesc;
			}
			if (other.SequenceType != ESequenceType.None)
			{
				SequenceType = other.SequenceType;
			}
			if (other.PlayType != EPlayType.None)
			{
				PlayType = other.PlayType;
			}
			if (other.SkipMode != ESkipMode.None)
			{
				SkipMode = other.SkipMode;
			}
			if (other.SkipType != ESkipType.None)
			{
				SkipType = other.SkipType;
			}
			if (other.IsTriggerMonsterGoHome != EGSYesNo.No)
			{
				IsTriggerMonsterGoHome = other.IsTriggerMonsterGoHome;
			}
			if (other.IsNeedStopBGM != EGSYesNo.No)
			{
				IsNeedStopBGM = other.IsNeedStopBGM;
			}
			if (other.IsNeedStopEnvSound != EGSYesNo.No)
			{
				IsNeedStopEnvSound = other.IsNeedStopEnvSound;
			}
			if (other.InterruptAiConversationType != EACInterruptType.None)
			{
				InterruptAiConversationType = other.InterruptAiConversationType;
			}
			if (other.MovieGraphPath.Length != 0)
			{
				MovieGraphPath = other.MovieGraphPath;
			}
			if (other.MatchingPosTime != 0f)
			{
				MatchingPosTime = other.MatchingPosTime;
			}
			if (other.IsNeedKeepHPPPV != EGSYesNo.No)
			{
				IsNeedKeepHPPPV = other.IsNeedKeepHPPPV;
			}
			if (other.CanSaveArchive != EGSYesNo.No)
			{
				CanSaveArchive = other.CanSaveArchive;
			}
			if (other.IsHideDropFX != EGSYesNo.No)
			{
				IsHideDropFX = other.IsHideDropFX;
			}
			if (other.PlayerLSPHiddenHeadType != ESeqHiddenHeadType.NoHidden)
			{
				PlayerLSPHiddenHeadType = other.PlayerLSPHiddenHeadType;
			}
			if (other.IsNeedHideFollowPartner != EGSYesNo.No)
			{
				IsNeedHideFollowPartner = other.IsNeedHideFollowPartner;
			}
			if (other.ClockSource != ESeqClockSource.Tick)
			{
				ClockSource = other.ClockSource;
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
				SeqDesc = input.ReadString();
				break;
			case 24u:
				SequenceType = (ESequenceType)input.ReadEnum();
				break;
			case 32u:
				PlayType = (EPlayType)input.ReadEnum();
				break;
			case 40u:
				SkipMode = (ESkipMode)input.ReadEnum();
				break;
			case 48u:
				SkipType = (ESkipType)input.ReadEnum();
				break;
			case 56u:
				IsTriggerMonsterGoHome = (EGSYesNo)input.ReadEnum();
				break;
			case 64u:
				IsNeedStopBGM = (EGSYesNo)input.ReadEnum();
				break;
			case 72u:
				IsNeedStopEnvSound = (EGSYesNo)input.ReadEnum();
				break;
			case 80u:
				InterruptAiConversationType = (EACInterruptType)input.ReadEnum();
				break;
			case 90u:
				MovieGraphPath = input.ReadString();
				break;
			case 101u:
				MatchingPosTime = input.ReadFloat();
				break;
			case 104u:
				IsNeedKeepHPPPV = (EGSYesNo)input.ReadEnum();
				break;
			case 112u:
				CanSaveArchive = (EGSYesNo)input.ReadEnum();
				break;
			case 120u:
				IsHideDropFX = (EGSYesNo)input.ReadEnum();
				break;
			case 128u:
				PlayerLSPHiddenHeadType = (ESeqHiddenHeadType)input.ReadEnum();
				break;
			case 136u:
				IsNeedHideFollowPartner = (EGSYesNo)input.ReadEnum();
				break;
			case 144u:
				ClockSource = (ESeqClockSource)input.ReadEnum();
				break;
			}
		}
	}
}
