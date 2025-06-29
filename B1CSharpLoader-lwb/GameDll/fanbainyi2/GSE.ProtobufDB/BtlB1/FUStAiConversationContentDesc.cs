using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStAiConversationContentDesc : IMessage<FUStAiConversationContentDesc>, IMessage, IEquatable<FUStAiConversationContentDesc>, IDeepCloneable<FUStAiConversationContentDesc>
{
	private static readonly MessageParser<FUStAiConversationContentDesc> _parser = new MessageParser<FUStAiConversationContentDesc>(() => new FUStAiConversationContentDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int resID_;

	private int levelID_;

	private EAiConversationTargetType speakerType_;

	private string speakerFilterParam_ = "";

	private float interruptionDistance_;

	private EGSYesNo overDistIntrruptAsComplete_;

	private string forceListenerGuid_ = "";

	private float forceListenerDistance_;

	private int probability_;

	private int contentPriority_;

	private int weightInSameLevel_;

	private int waitTimeMs_;

	private EAiConversationEndType endType_;

	private int contentDurTimeMs_;

	private string subtitle_ = "";

	private string dialogueIDs_ = "";

	private string subtitleDurTimeMs_ = "";

	private string nextConversationIDList_ = "";

	private string akEventPath_ = "";

	private EGSYesNo isGlobalCD_;

	private int cDTimeMs_;

	private static readonly FieldCodec<FAiConversationCondition> _repeated_conditions_codec = FieldCodec.ForMessage(186u, FAiConversationCondition.Parser);

	private readonly RepeatedField<FAiConversationCondition> conditions_ = new RepeatedField<FAiConversationCondition>();

	private static readonly FieldCodec<FACModifyFactData> _repeated_modifyFacts_codec = FieldCodec.ForMessage(194u, FACModifyFactData.Parser);

	private readonly RepeatedField<FACModifyFactData> modifyFacts_ = new RepeatedField<FACModifyFactData>();

	private string aMPath_ = "";

	private int localizationTag_;

	private EGSYesNo notStopMontageWhenEnd_;

	public static MessageParser<FUStAiConversationContentDesc> Parser => _parser;

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

	public int LevelID
	{
		get
		{
			return levelID_;
		}
		set
		{
			levelID_ = value;
		}
	}

	public EAiConversationTargetType SpeakerType
	{
		get
		{
			return speakerType_;
		}
		set
		{
			speakerType_ = value;
		}
	}

	public string SpeakerFilterParam
	{
		get
		{
			return speakerFilterParam_;
		}
		set
		{
			speakerFilterParam_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float InterruptionDistance
	{
		get
		{
			return interruptionDistance_;
		}
		set
		{
			interruptionDistance_ = value;
		}
	}

	public EGSYesNo OverDistIntrruptAsComplete
	{
		get
		{
			return overDistIntrruptAsComplete_;
		}
		set
		{
			overDistIntrruptAsComplete_ = value;
		}
	}

	public string ForceListenerGuid
	{
		get
		{
			return forceListenerGuid_;
		}
		set
		{
			forceListenerGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float ForceListenerDistance
	{
		get
		{
			return forceListenerDistance_;
		}
		set
		{
			forceListenerDistance_ = value;
		}
	}

	public int Probability
	{
		get
		{
			return probability_;
		}
		set
		{
			probability_ = value;
		}
	}

	public int ContentPriority
	{
		get
		{
			return contentPriority_;
		}
		set
		{
			contentPriority_ = value;
		}
	}

	public int WeightInSameLevel
	{
		get
		{
			return weightInSameLevel_;
		}
		set
		{
			weightInSameLevel_ = value;
		}
	}

	public int WaitTimeMs
	{
		get
		{
			return waitTimeMs_;
		}
		set
		{
			waitTimeMs_ = value;
		}
	}

	public EAiConversationEndType EndType
	{
		get
		{
			return endType_;
		}
		set
		{
			endType_ = value;
		}
	}

	public int ContentDurTimeMs
	{
		get
		{
			return contentDurTimeMs_;
		}
		set
		{
			contentDurTimeMs_ = value;
		}
	}

	public string Subtitle
	{
		get
		{
			return subtitle_;
		}
		set
		{
			subtitle_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DialogueIDs
	{
		get
		{
			return dialogueIDs_;
		}
		set
		{
			dialogueIDs_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SubtitleDurTimeMs
	{
		get
		{
			return subtitleDurTimeMs_;
		}
		set
		{
			subtitleDurTimeMs_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string NextConversationIDList
	{
		get
		{
			return nextConversationIDList_;
		}
		set
		{
			nextConversationIDList_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AkEventPath
	{
		get
		{
			return akEventPath_;
		}
		set
		{
			akEventPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo IsGlobalCD
	{
		get
		{
			return isGlobalCD_;
		}
		set
		{
			isGlobalCD_ = value;
		}
	}

	public int CDTimeMs
	{
		get
		{
			return cDTimeMs_;
		}
		set
		{
			cDTimeMs_ = value;
		}
	}

	public RepeatedField<FAiConversationCondition> Conditions => conditions_;

	public RepeatedField<FACModifyFactData> ModifyFacts => modifyFacts_;

	public string AMPath
	{
		get
		{
			return aMPath_;
		}
		set
		{
			aMPath_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public EGSYesNo NotStopMontageWhenEnd
	{
		get
		{
			return notStopMontageWhenEnd_;
		}
		set
		{
			notStopMontageWhenEnd_ = value;
		}
	}

	public FUStAiConversationContentDesc()
	{
	}

	public FUStAiConversationContentDesc(FUStAiConversationContentDesc other)
		: this()
	{
		iD_ = other.iD_;
		resID_ = other.resID_;
		levelID_ = other.levelID_;
		speakerType_ = other.speakerType_;
		speakerFilterParam_ = other.speakerFilterParam_;
		interruptionDistance_ = other.interruptionDistance_;
		overDistIntrruptAsComplete_ = other.overDistIntrruptAsComplete_;
		forceListenerGuid_ = other.forceListenerGuid_;
		forceListenerDistance_ = other.forceListenerDistance_;
		probability_ = other.probability_;
		contentPriority_ = other.contentPriority_;
		weightInSameLevel_ = other.weightInSameLevel_;
		waitTimeMs_ = other.waitTimeMs_;
		endType_ = other.endType_;
		contentDurTimeMs_ = other.contentDurTimeMs_;
		subtitle_ = other.subtitle_;
		dialogueIDs_ = other.dialogueIDs_;
		subtitleDurTimeMs_ = other.subtitleDurTimeMs_;
		nextConversationIDList_ = other.nextConversationIDList_;
		akEventPath_ = other.akEventPath_;
		isGlobalCD_ = other.isGlobalCD_;
		cDTimeMs_ = other.cDTimeMs_;
		conditions_ = other.conditions_.Clone();
		modifyFacts_ = other.modifyFacts_.Clone();
		aMPath_ = other.aMPath_;
		localizationTag_ = other.localizationTag_;
		notStopMontageWhenEnd_ = other.notStopMontageWhenEnd_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAiConversationContentDesc Clone()
	{
		return new FUStAiConversationContentDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAiConversationContentDesc);
	}

	public bool Equals(FUStAiConversationContentDesc other)
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
		if (LevelID != other.LevelID)
		{
			return false;
		}
		if (SpeakerType != other.SpeakerType)
		{
			return false;
		}
		if (SpeakerFilterParam != other.SpeakerFilterParam)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InterruptionDistance, other.InterruptionDistance))
		{
			return false;
		}
		if (OverDistIntrruptAsComplete != other.OverDistIntrruptAsComplete)
		{
			return false;
		}
		if (ForceListenerGuid != other.ForceListenerGuid)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ForceListenerDistance, other.ForceListenerDistance))
		{
			return false;
		}
		if (Probability != other.Probability)
		{
			return false;
		}
		if (ContentPriority != other.ContentPriority)
		{
			return false;
		}
		if (WeightInSameLevel != other.WeightInSameLevel)
		{
			return false;
		}
		if (WaitTimeMs != other.WaitTimeMs)
		{
			return false;
		}
		if (EndType != other.EndType)
		{
			return false;
		}
		if (ContentDurTimeMs != other.ContentDurTimeMs)
		{
			return false;
		}
		if (Subtitle != other.Subtitle)
		{
			return false;
		}
		if (DialogueIDs != other.DialogueIDs)
		{
			return false;
		}
		if (SubtitleDurTimeMs != other.SubtitleDurTimeMs)
		{
			return false;
		}
		if (NextConversationIDList != other.NextConversationIDList)
		{
			return false;
		}
		if (AkEventPath != other.AkEventPath)
		{
			return false;
		}
		if (IsGlobalCD != other.IsGlobalCD)
		{
			return false;
		}
		if (CDTimeMs != other.CDTimeMs)
		{
			return false;
		}
		if (!conditions_.Equals(other.conditions_))
		{
			return false;
		}
		if (!modifyFacts_.Equals(other.modifyFacts_))
		{
			return false;
		}
		if (AMPath != other.AMPath)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (NotStopMontageWhenEnd != other.NotStopMontageWhenEnd)
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
		if (LevelID != 0)
		{
			num ^= LevelID.GetHashCode();
		}
		if (SpeakerType != EAiConversationTargetType.None)
		{
			num ^= SpeakerType.GetHashCode();
		}
		if (SpeakerFilterParam.Length != 0)
		{
			num ^= SpeakerFilterParam.GetHashCode();
		}
		if (InterruptionDistance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InterruptionDistance);
		}
		if (OverDistIntrruptAsComplete != EGSYesNo.No)
		{
			num ^= OverDistIntrruptAsComplete.GetHashCode();
		}
		if (ForceListenerGuid.Length != 0)
		{
			num ^= ForceListenerGuid.GetHashCode();
		}
		if (ForceListenerDistance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ForceListenerDistance);
		}
		if (Probability != 0)
		{
			num ^= Probability.GetHashCode();
		}
		if (ContentPriority != 0)
		{
			num ^= ContentPriority.GetHashCode();
		}
		if (WeightInSameLevel != 0)
		{
			num ^= WeightInSameLevel.GetHashCode();
		}
		if (WaitTimeMs != 0)
		{
			num ^= WaitTimeMs.GetHashCode();
		}
		if (EndType != EAiConversationEndType.None)
		{
			num ^= EndType.GetHashCode();
		}
		if (ContentDurTimeMs != 0)
		{
			num ^= ContentDurTimeMs.GetHashCode();
		}
		if (Subtitle.Length != 0)
		{
			num ^= Subtitle.GetHashCode();
		}
		if (DialogueIDs.Length != 0)
		{
			num ^= DialogueIDs.GetHashCode();
		}
		if (SubtitleDurTimeMs.Length != 0)
		{
			num ^= SubtitleDurTimeMs.GetHashCode();
		}
		if (NextConversationIDList.Length != 0)
		{
			num ^= NextConversationIDList.GetHashCode();
		}
		if (AkEventPath.Length != 0)
		{
			num ^= AkEventPath.GetHashCode();
		}
		if (IsGlobalCD != EGSYesNo.No)
		{
			num ^= IsGlobalCD.GetHashCode();
		}
		if (CDTimeMs != 0)
		{
			num ^= CDTimeMs.GetHashCode();
		}
		num ^= conditions_.GetHashCode();
		num ^= modifyFacts_.GetHashCode();
		if (AMPath.Length != 0)
		{
			num ^= AMPath.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (NotStopMontageWhenEnd != EGSYesNo.No)
		{
			num ^= NotStopMontageWhenEnd.GetHashCode();
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
		if (LevelID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LevelID);
		}
		if (SpeakerType != EAiConversationTargetType.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)SpeakerType);
		}
		if (SpeakerFilterParam.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(SpeakerFilterParam);
		}
		if (InterruptionDistance != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(InterruptionDistance);
		}
		if (OverDistIntrruptAsComplete != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)OverDistIntrruptAsComplete);
		}
		if (ForceListenerGuid.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(ForceListenerGuid);
		}
		if (ForceListenerDistance != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(ForceListenerDistance);
		}
		if (Probability != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(Probability);
		}
		if (ContentPriority != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(ContentPriority);
		}
		if (WeightInSameLevel != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(WeightInSameLevel);
		}
		if (WaitTimeMs != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(WaitTimeMs);
		}
		if (EndType != EAiConversationEndType.None)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)EndType);
		}
		if (ContentDurTimeMs != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(ContentDurTimeMs);
		}
		if (Subtitle.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(Subtitle);
		}
		if (DialogueIDs.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(DialogueIDs);
		}
		if (SubtitleDurTimeMs.Length != 0)
		{
			output.WriteRawTag(146, 1);
			output.WriteString(SubtitleDurTimeMs);
		}
		if (NextConversationIDList.Length != 0)
		{
			output.WriteRawTag(154, 1);
			output.WriteString(NextConversationIDList);
		}
		if (AkEventPath.Length != 0)
		{
			output.WriteRawTag(162, 1);
			output.WriteString(AkEventPath);
		}
		if (IsGlobalCD != EGSYesNo.No)
		{
			output.WriteRawTag(168, 1);
			output.WriteEnum((int)IsGlobalCD);
		}
		if (CDTimeMs != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(CDTimeMs);
		}
		conditions_.WriteTo(output, _repeated_conditions_codec);
		modifyFacts_.WriteTo(output, _repeated_modifyFacts_codec);
		if (AMPath.Length != 0)
		{
			output.WriteRawTag(202, 1);
			output.WriteString(AMPath);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(LocalizationTag);
		}
		if (NotStopMontageWhenEnd != EGSYesNo.No)
		{
			output.WriteRawTag(216, 1);
			output.WriteEnum((int)NotStopMontageWhenEnd);
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
		if (LevelID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelID);
		}
		if (SpeakerType != EAiConversationTargetType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SpeakerType);
		}
		if (SpeakerFilterParam.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SpeakerFilterParam);
		}
		if (InterruptionDistance != 0f)
		{
			num += 5;
		}
		if (OverDistIntrruptAsComplete != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OverDistIntrruptAsComplete);
		}
		if (ForceListenerGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ForceListenerGuid);
		}
		if (ForceListenerDistance != 0f)
		{
			num += 5;
		}
		if (Probability != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Probability);
		}
		if (ContentPriority != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentPriority);
		}
		if (WeightInSameLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WeightInSameLevel);
		}
		if (WaitTimeMs != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WaitTimeMs);
		}
		if (EndType != EAiConversationEndType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EndType);
		}
		if (ContentDurTimeMs != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentDurTimeMs);
		}
		if (Subtitle.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Subtitle);
		}
		if (DialogueIDs.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(DialogueIDs);
		}
		if (SubtitleDurTimeMs.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(SubtitleDurTimeMs);
		}
		if (NextConversationIDList.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(NextConversationIDList);
		}
		if (AkEventPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(AkEventPath);
		}
		if (IsGlobalCD != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsGlobalCD);
		}
		if (CDTimeMs != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CDTimeMs);
		}
		num += conditions_.CalculateSize(_repeated_conditions_codec);
		num += modifyFacts_.CalculateSize(_repeated_modifyFacts_codec);
		if (AMPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(AMPath);
		}
		if (LocalizationTag != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (NotStopMontageWhenEnd != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)NotStopMontageWhenEnd);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAiConversationContentDesc other)
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
			if (other.LevelID != 0)
			{
				LevelID = other.LevelID;
			}
			if (other.SpeakerType != EAiConversationTargetType.None)
			{
				SpeakerType = other.SpeakerType;
			}
			if (other.SpeakerFilterParam.Length != 0)
			{
				SpeakerFilterParam = other.SpeakerFilterParam;
			}
			if (other.InterruptionDistance != 0f)
			{
				InterruptionDistance = other.InterruptionDistance;
			}
			if (other.OverDistIntrruptAsComplete != EGSYesNo.No)
			{
				OverDistIntrruptAsComplete = other.OverDistIntrruptAsComplete;
			}
			if (other.ForceListenerGuid.Length != 0)
			{
				ForceListenerGuid = other.ForceListenerGuid;
			}
			if (other.ForceListenerDistance != 0f)
			{
				ForceListenerDistance = other.ForceListenerDistance;
			}
			if (other.Probability != 0)
			{
				Probability = other.Probability;
			}
			if (other.ContentPriority != 0)
			{
				ContentPriority = other.ContentPriority;
			}
			if (other.WeightInSameLevel != 0)
			{
				WeightInSameLevel = other.WeightInSameLevel;
			}
			if (other.WaitTimeMs != 0)
			{
				WaitTimeMs = other.WaitTimeMs;
			}
			if (other.EndType != EAiConversationEndType.None)
			{
				EndType = other.EndType;
			}
			if (other.ContentDurTimeMs != 0)
			{
				ContentDurTimeMs = other.ContentDurTimeMs;
			}
			if (other.Subtitle.Length != 0)
			{
				Subtitle = other.Subtitle;
			}
			if (other.DialogueIDs.Length != 0)
			{
				DialogueIDs = other.DialogueIDs;
			}
			if (other.SubtitleDurTimeMs.Length != 0)
			{
				SubtitleDurTimeMs = other.SubtitleDurTimeMs;
			}
			if (other.NextConversationIDList.Length != 0)
			{
				NextConversationIDList = other.NextConversationIDList;
			}
			if (other.AkEventPath.Length != 0)
			{
				AkEventPath = other.AkEventPath;
			}
			if (other.IsGlobalCD != EGSYesNo.No)
			{
				IsGlobalCD = other.IsGlobalCD;
			}
			if (other.CDTimeMs != 0)
			{
				CDTimeMs = other.CDTimeMs;
			}
			conditions_.Add(other.conditions_);
			modifyFacts_.Add(other.modifyFacts_);
			if (other.AMPath.Length != 0)
			{
				AMPath = other.AMPath;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.NotStopMontageWhenEnd != EGSYesNo.No)
			{
				NotStopMontageWhenEnd = other.NotStopMontageWhenEnd;
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
				LevelID = input.ReadInt32();
				break;
			case 32u:
				SpeakerType = (EAiConversationTargetType)input.ReadEnum();
				break;
			case 42u:
				SpeakerFilterParam = input.ReadString();
				break;
			case 53u:
				InterruptionDistance = input.ReadFloat();
				break;
			case 56u:
				OverDistIntrruptAsComplete = (EGSYesNo)input.ReadEnum();
				break;
			case 66u:
				ForceListenerGuid = input.ReadString();
				break;
			case 77u:
				ForceListenerDistance = input.ReadFloat();
				break;
			case 80u:
				Probability = input.ReadInt32();
				break;
			case 88u:
				ContentPriority = input.ReadInt32();
				break;
			case 96u:
				WeightInSameLevel = input.ReadInt32();
				break;
			case 104u:
				WaitTimeMs = input.ReadInt32();
				break;
			case 112u:
				EndType = (EAiConversationEndType)input.ReadEnum();
				break;
			case 120u:
				ContentDurTimeMs = input.ReadInt32();
				break;
			case 130u:
				Subtitle = input.ReadString();
				break;
			case 138u:
				DialogueIDs = input.ReadString();
				break;
			case 146u:
				SubtitleDurTimeMs = input.ReadString();
				break;
			case 154u:
				NextConversationIDList = input.ReadString();
				break;
			case 162u:
				AkEventPath = input.ReadString();
				break;
			case 168u:
				IsGlobalCD = (EGSYesNo)input.ReadEnum();
				break;
			case 176u:
				CDTimeMs = input.ReadInt32();
				break;
			case 186u:
				conditions_.AddEntriesFrom(input, _repeated_conditions_codec);
				break;
			case 194u:
				modifyFacts_.AddEntriesFrom(input, _repeated_modifyFacts_codec);
				break;
			case 202u:
				AMPath = input.ReadString();
				break;
			case 208u:
				LocalizationTag = input.ReadInt32();
				break;
			case 216u:
				NotStopMontageWhenEnd = (EGSYesNo)input.ReadEnum();
				break;
			}
		}
	}
}
