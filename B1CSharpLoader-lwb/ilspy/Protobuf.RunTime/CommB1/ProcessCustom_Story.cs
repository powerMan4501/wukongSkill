using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ProcessCustom_Story : IMessage<ProcessCustom_Story>, IMessage, IEquatable<ProcessCustom_Story>, IDeepCloneable<ProcessCustom_Story>
{
	private static readonly MessageParser<ProcessCustom_Story> _parser = new MessageParser<ProcessCustom_Story>(() => new ProcessCustom_Story());

	private UnknownFieldSet _unknownFields;

	private bool isWaitPlayFinish_;

	private string sequenceId_ = "";

	private bool isGainItemWhenFinish_;

	private static readonly FieldCodec<CalliopeCustom_GainItem> _repeated_gainItems_codec = FieldCodec.ForMessage(34u, CalliopeCustom_GainItem.Parser);

	private readonly RepeatedField<CalliopeCustom_GainItem> gainItems_ = new RepeatedField<CalliopeCustom_GainItem>();

	private bool isChapterEndStory_;

	private int chapterId_;

	private bool isTriggerTransback_;

	private bool isTriggerMonsterGoHome_;

	private bool isDisablePlayerControl_;

	private bool isDisableMovementInput_;

	private bool isDisableLookAtInput_;

	private bool isHidePlayer_;

	private bool isHideHud_;

	private static readonly FieldCodec<CalliopeCustom_ManagedSceneObj> _repeated_managedObjs_codec = FieldCodec.ForMessage(114u, CalliopeCustom_ManagedSceneObj.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedSceneObj> managedObjs_ = new RepeatedField<CalliopeCustom_ManagedSceneObj>();

	private static readonly FieldCodec<CalliopeCustom_ManagedNPCUnit> _repeated_managedNpcUnits_codec = FieldCodec.ForMessage(122u, CalliopeCustom_ManagedNPCUnit.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedNPCUnit> managedNpcUnits_ = new RepeatedField<CalliopeCustom_ManagedNPCUnit>();

	private static readonly FieldCodec<CalliopeCustom_ManagedInteractor> _repeated_managedInteractors_codec = FieldCodec.ForMessage(130u, CalliopeCustom_ManagedInteractor.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedInteractor> managedInteractors_ = new RepeatedField<CalliopeCustom_ManagedInteractor>();

	private static readonly FieldCodec<CalliopeCustom_ManagedStreamingLevelStateConfig> _repeated_managedStreamingLevelStateConfigs_codec = FieldCodec.ForMessage(138u, CalliopeCustom_ManagedStreamingLevelStateConfig.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedStreamingLevelStateConfig> managedStreamingLevelStateConfigs_ = new RepeatedField<CalliopeCustom_ManagedStreamingLevelStateConfig>();

	private static readonly FieldCodec<CalliopeCustom_ManagedGroupUnit> _repeated_managedGroupUnits_codec = FieldCodec.ForMessage(146u, CalliopeCustom_ManagedGroupUnit.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedGroupUnit> managedGroupUnits_ = new RepeatedField<CalliopeCustom_ManagedGroupUnit>();

	private int matchType_;

	private string matchOverlapBox_ = "";

	public static MessageParser<ProcessCustom_Story> Parser => _parser;

	public bool IsWaitPlayFinish
	{
		get
		{
			return isWaitPlayFinish_;
		}
		set
		{
			isWaitPlayFinish_ = value;
		}
	}

	public string SequenceId
	{
		get
		{
			return sequenceId_;
		}
		set
		{
			sequenceId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsGainItemWhenFinish
	{
		get
		{
			return isGainItemWhenFinish_;
		}
		set
		{
			isGainItemWhenFinish_ = value;
		}
	}

	public RepeatedField<CalliopeCustom_GainItem> GainItems => gainItems_;

	public bool IsChapterEndStory
	{
		get
		{
			return isChapterEndStory_;
		}
		set
		{
			isChapterEndStory_ = value;
		}
	}

	public int ChapterId
	{
		get
		{
			return chapterId_;
		}
		set
		{
			chapterId_ = value;
		}
	}

	public bool IsTriggerTransback
	{
		get
		{
			return isTriggerTransback_;
		}
		set
		{
			isTriggerTransback_ = value;
		}
	}

	public bool IsTriggerMonsterGoHome
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

	public bool IsDisablePlayerControl
	{
		get
		{
			return isDisablePlayerControl_;
		}
		set
		{
			isDisablePlayerControl_ = value;
		}
	}

	public bool IsDisableMovementInput
	{
		get
		{
			return isDisableMovementInput_;
		}
		set
		{
			isDisableMovementInput_ = value;
		}
	}

	public bool IsDisableLookAtInput
	{
		get
		{
			return isDisableLookAtInput_;
		}
		set
		{
			isDisableLookAtInput_ = value;
		}
	}

	public bool IsHidePlayer
	{
		get
		{
			return isHidePlayer_;
		}
		set
		{
			isHidePlayer_ = value;
		}
	}

	public bool IsHideHud
	{
		get
		{
			return isHideHud_;
		}
		set
		{
			isHideHud_ = value;
		}
	}

	public RepeatedField<CalliopeCustom_ManagedSceneObj> ManagedObjs => managedObjs_;

	public RepeatedField<CalliopeCustom_ManagedNPCUnit> ManagedNpcUnits => managedNpcUnits_;

	public RepeatedField<CalliopeCustom_ManagedInteractor> ManagedInteractors => managedInteractors_;

	public RepeatedField<CalliopeCustom_ManagedStreamingLevelStateConfig> ManagedStreamingLevelStateConfigs => managedStreamingLevelStateConfigs_;

	public RepeatedField<CalliopeCustom_ManagedGroupUnit> ManagedGroupUnits => managedGroupUnits_;

	public int MatchType
	{
		get
		{
			return matchType_;
		}
		set
		{
			matchType_ = value;
		}
	}

	public string MatchOverlapBox
	{
		get
		{
			return matchOverlapBox_;
		}
		set
		{
			matchOverlapBox_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ProcessCustom_Story()
	{
	}

	public ProcessCustom_Story(ProcessCustom_Story other)
		: this()
	{
		isWaitPlayFinish_ = other.isWaitPlayFinish_;
		sequenceId_ = other.sequenceId_;
		isGainItemWhenFinish_ = other.isGainItemWhenFinish_;
		gainItems_ = other.gainItems_.Clone();
		isChapterEndStory_ = other.isChapterEndStory_;
		chapterId_ = other.chapterId_;
		isTriggerTransback_ = other.isTriggerTransback_;
		isTriggerMonsterGoHome_ = other.isTriggerMonsterGoHome_;
		isDisablePlayerControl_ = other.isDisablePlayerControl_;
		isDisableMovementInput_ = other.isDisableMovementInput_;
		isDisableLookAtInput_ = other.isDisableLookAtInput_;
		isHidePlayer_ = other.isHidePlayer_;
		isHideHud_ = other.isHideHud_;
		managedObjs_ = other.managedObjs_.Clone();
		managedNpcUnits_ = other.managedNpcUnits_.Clone();
		managedInteractors_ = other.managedInteractors_.Clone();
		managedStreamingLevelStateConfigs_ = other.managedStreamingLevelStateConfigs_.Clone();
		managedGroupUnits_ = other.managedGroupUnits_.Clone();
		matchType_ = other.matchType_;
		matchOverlapBox_ = other.matchOverlapBox_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessCustom_Story Clone()
	{
		return new ProcessCustom_Story(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessCustom_Story);
	}

	public bool Equals(ProcessCustom_Story other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsWaitPlayFinish != other.IsWaitPlayFinish)
		{
			return false;
		}
		if (SequenceId != other.SequenceId)
		{
			return false;
		}
		if (IsGainItemWhenFinish != other.IsGainItemWhenFinish)
		{
			return false;
		}
		if (!gainItems_.Equals(other.gainItems_))
		{
			return false;
		}
		if (IsChapterEndStory != other.IsChapterEndStory)
		{
			return false;
		}
		if (ChapterId != other.ChapterId)
		{
			return false;
		}
		if (IsTriggerTransback != other.IsTriggerTransback)
		{
			return false;
		}
		if (IsTriggerMonsterGoHome != other.IsTriggerMonsterGoHome)
		{
			return false;
		}
		if (IsDisablePlayerControl != other.IsDisablePlayerControl)
		{
			return false;
		}
		if (IsDisableMovementInput != other.IsDisableMovementInput)
		{
			return false;
		}
		if (IsDisableLookAtInput != other.IsDisableLookAtInput)
		{
			return false;
		}
		if (IsHidePlayer != other.IsHidePlayer)
		{
			return false;
		}
		if (IsHideHud != other.IsHideHud)
		{
			return false;
		}
		if (!managedObjs_.Equals(other.managedObjs_))
		{
			return false;
		}
		if (!managedNpcUnits_.Equals(other.managedNpcUnits_))
		{
			return false;
		}
		if (!managedInteractors_.Equals(other.managedInteractors_))
		{
			return false;
		}
		if (!managedStreamingLevelStateConfigs_.Equals(other.managedStreamingLevelStateConfigs_))
		{
			return false;
		}
		if (!managedGroupUnits_.Equals(other.managedGroupUnits_))
		{
			return false;
		}
		if (MatchType != other.MatchType)
		{
			return false;
		}
		if (MatchOverlapBox != other.MatchOverlapBox)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsWaitPlayFinish)
		{
			num ^= IsWaitPlayFinish.GetHashCode();
		}
		if (SequenceId.Length != 0)
		{
			num ^= SequenceId.GetHashCode();
		}
		if (IsGainItemWhenFinish)
		{
			num ^= IsGainItemWhenFinish.GetHashCode();
		}
		num ^= gainItems_.GetHashCode();
		if (IsChapterEndStory)
		{
			num ^= IsChapterEndStory.GetHashCode();
		}
		if (ChapterId != 0)
		{
			num ^= ChapterId.GetHashCode();
		}
		if (IsTriggerTransback)
		{
			num ^= IsTriggerTransback.GetHashCode();
		}
		if (IsTriggerMonsterGoHome)
		{
			num ^= IsTriggerMonsterGoHome.GetHashCode();
		}
		if (IsDisablePlayerControl)
		{
			num ^= IsDisablePlayerControl.GetHashCode();
		}
		if (IsDisableMovementInput)
		{
			num ^= IsDisableMovementInput.GetHashCode();
		}
		if (IsDisableLookAtInput)
		{
			num ^= IsDisableLookAtInput.GetHashCode();
		}
		if (IsHidePlayer)
		{
			num ^= IsHidePlayer.GetHashCode();
		}
		if (IsHideHud)
		{
			num ^= IsHideHud.GetHashCode();
		}
		num ^= managedObjs_.GetHashCode();
		num ^= managedNpcUnits_.GetHashCode();
		num ^= managedInteractors_.GetHashCode();
		num ^= managedStreamingLevelStateConfigs_.GetHashCode();
		num ^= managedGroupUnits_.GetHashCode();
		if (MatchType != 0)
		{
			num ^= MatchType.GetHashCode();
		}
		if (MatchOverlapBox.Length != 0)
		{
			num ^= MatchOverlapBox.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsWaitPlayFinish)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsWaitPlayFinish);
		}
		if (SequenceId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SequenceId);
		}
		if (IsGainItemWhenFinish)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsGainItemWhenFinish);
		}
		gainItems_.WriteTo(output, _repeated_gainItems_codec);
		if (IsChapterEndStory)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsChapterEndStory);
		}
		if (ChapterId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ChapterId);
		}
		if (IsTriggerTransback)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsTriggerTransback);
		}
		if (IsTriggerMonsterGoHome)
		{
			output.WriteRawTag(64);
			output.WriteBool(IsTriggerMonsterGoHome);
		}
		if (IsDisablePlayerControl)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsDisablePlayerControl);
		}
		if (IsDisableMovementInput)
		{
			output.WriteRawTag(80);
			output.WriteBool(IsDisableMovementInput);
		}
		if (IsDisableLookAtInput)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsDisableLookAtInput);
		}
		if (IsHidePlayer)
		{
			output.WriteRawTag(96);
			output.WriteBool(IsHidePlayer);
		}
		if (IsHideHud)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsHideHud);
		}
		managedObjs_.WriteTo(output, _repeated_managedObjs_codec);
		managedNpcUnits_.WriteTo(output, _repeated_managedNpcUnits_codec);
		managedInteractors_.WriteTo(output, _repeated_managedInteractors_codec);
		managedStreamingLevelStateConfigs_.WriteTo(output, _repeated_managedStreamingLevelStateConfigs_codec);
		managedGroupUnits_.WriteTo(output, _repeated_managedGroupUnits_codec);
		if (MatchType != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(MatchType);
		}
		if (MatchOverlapBox.Length != 0)
		{
			output.WriteRawTag(162, 1);
			output.WriteString(MatchOverlapBox);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsWaitPlayFinish)
		{
			num += 2;
		}
		if (SequenceId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SequenceId);
		}
		if (IsGainItemWhenFinish)
		{
			num += 2;
		}
		num += gainItems_.CalculateSize(_repeated_gainItems_codec);
		if (IsChapterEndStory)
		{
			num += 2;
		}
		if (ChapterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterId);
		}
		if (IsTriggerTransback)
		{
			num += 2;
		}
		if (IsTriggerMonsterGoHome)
		{
			num += 2;
		}
		if (IsDisablePlayerControl)
		{
			num += 2;
		}
		if (IsDisableMovementInput)
		{
			num += 2;
		}
		if (IsDisableLookAtInput)
		{
			num += 2;
		}
		if (IsHidePlayer)
		{
			num += 2;
		}
		if (IsHideHud)
		{
			num += 2;
		}
		num += managedObjs_.CalculateSize(_repeated_managedObjs_codec);
		num += managedNpcUnits_.CalculateSize(_repeated_managedNpcUnits_codec);
		num += managedInteractors_.CalculateSize(_repeated_managedInteractors_codec);
		num += managedStreamingLevelStateConfigs_.CalculateSize(_repeated_managedStreamingLevelStateConfigs_codec);
		num += managedGroupUnits_.CalculateSize(_repeated_managedGroupUnits_codec);
		if (MatchType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MatchType);
		}
		if (MatchOverlapBox.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(MatchOverlapBox);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessCustom_Story other)
	{
		if (other != null)
		{
			if (other.IsWaitPlayFinish)
			{
				IsWaitPlayFinish = other.IsWaitPlayFinish;
			}
			if (other.SequenceId.Length != 0)
			{
				SequenceId = other.SequenceId;
			}
			if (other.IsGainItemWhenFinish)
			{
				IsGainItemWhenFinish = other.IsGainItemWhenFinish;
			}
			gainItems_.Add(other.gainItems_);
			if (other.IsChapterEndStory)
			{
				IsChapterEndStory = other.IsChapterEndStory;
			}
			if (other.ChapterId != 0)
			{
				ChapterId = other.ChapterId;
			}
			if (other.IsTriggerTransback)
			{
				IsTriggerTransback = other.IsTriggerTransback;
			}
			if (other.IsTriggerMonsterGoHome)
			{
				IsTriggerMonsterGoHome = other.IsTriggerMonsterGoHome;
			}
			if (other.IsDisablePlayerControl)
			{
				IsDisablePlayerControl = other.IsDisablePlayerControl;
			}
			if (other.IsDisableMovementInput)
			{
				IsDisableMovementInput = other.IsDisableMovementInput;
			}
			if (other.IsDisableLookAtInput)
			{
				IsDisableLookAtInput = other.IsDisableLookAtInput;
			}
			if (other.IsHidePlayer)
			{
				IsHidePlayer = other.IsHidePlayer;
			}
			if (other.IsHideHud)
			{
				IsHideHud = other.IsHideHud;
			}
			managedObjs_.Add(other.managedObjs_);
			managedNpcUnits_.Add(other.managedNpcUnits_);
			managedInteractors_.Add(other.managedInteractors_);
			managedStreamingLevelStateConfigs_.Add(other.managedStreamingLevelStateConfigs_);
			managedGroupUnits_.Add(other.managedGroupUnits_);
			if (other.MatchType != 0)
			{
				MatchType = other.MatchType;
			}
			if (other.MatchOverlapBox.Length != 0)
			{
				MatchOverlapBox = other.MatchOverlapBox;
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
				IsWaitPlayFinish = input.ReadBool();
				break;
			case 18u:
				SequenceId = input.ReadString();
				break;
			case 24u:
				IsGainItemWhenFinish = input.ReadBool();
				break;
			case 34u:
				gainItems_.AddEntriesFrom(input, _repeated_gainItems_codec);
				break;
			case 40u:
				IsChapterEndStory = input.ReadBool();
				break;
			case 48u:
				ChapterId = input.ReadInt32();
				break;
			case 56u:
				IsTriggerTransback = input.ReadBool();
				break;
			case 64u:
				IsTriggerMonsterGoHome = input.ReadBool();
				break;
			case 72u:
				IsDisablePlayerControl = input.ReadBool();
				break;
			case 80u:
				IsDisableMovementInput = input.ReadBool();
				break;
			case 88u:
				IsDisableLookAtInput = input.ReadBool();
				break;
			case 96u:
				IsHidePlayer = input.ReadBool();
				break;
			case 104u:
				IsHideHud = input.ReadBool();
				break;
			case 114u:
				managedObjs_.AddEntriesFrom(input, _repeated_managedObjs_codec);
				break;
			case 122u:
				managedNpcUnits_.AddEntriesFrom(input, _repeated_managedNpcUnits_codec);
				break;
			case 130u:
				managedInteractors_.AddEntriesFrom(input, _repeated_managedInteractors_codec);
				break;
			case 138u:
				managedStreamingLevelStateConfigs_.AddEntriesFrom(input, _repeated_managedStreamingLevelStateConfigs_codec);
				break;
			case 146u:
				managedGroupUnits_.AddEntriesFrom(input, _repeated_managedGroupUnits_codec);
				break;
			case 152u:
				MatchType = input.ReadInt32();
				break;
			case 162u:
				MatchOverlapBox = input.ReadString();
				break;
			}
		}
	}
}
