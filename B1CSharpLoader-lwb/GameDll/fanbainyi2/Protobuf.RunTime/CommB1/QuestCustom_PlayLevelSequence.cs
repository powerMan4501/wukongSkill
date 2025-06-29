using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_PlayLevelSequence : IMessage<QuestCustom_PlayLevelSequence>, IMessage, IEquatable<QuestCustom_PlayLevelSequence>, IDeepCloneable<QuestCustom_PlayLevelSequence>
{
	private static readonly MessageParser<QuestCustom_PlayLevelSequence> _parser = new MessageParser<QuestCustom_PlayLevelSequence>(() => new QuestCustom_PlayLevelSequence());

	private UnknownFieldSet _unknownFields;

	private int sequenceId_;

	private float startTime_;

	private bool isDisableMovementInput_;

	private bool isDisableLookAtInput_;

	private bool isHidePlayer_;

	private bool isHideHud_;

	private bool isDisableCameraCuts_;

	private bool isUseCrane_;

	private bool isUseRail_;

	private bool isUsePlayerCamera_;

	private bool isTriggerTransback_;

	private bool isTriggerMonsterGoHome_;

	public static MessageParser<QuestCustom_PlayLevelSequence> Parser => _parser;

	public int SequenceId
	{
		get
		{
			return sequenceId_;
		}
		set
		{
			sequenceId_ = value;
		}
	}

	public float StartTime
	{
		get
		{
			return startTime_;
		}
		set
		{
			startTime_ = value;
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

	public bool IsDisableCameraCuts
	{
		get
		{
			return isDisableCameraCuts_;
		}
		set
		{
			isDisableCameraCuts_ = value;
		}
	}

	public bool IsUseCrane
	{
		get
		{
			return isUseCrane_;
		}
		set
		{
			isUseCrane_ = value;
		}
	}

	public bool IsUseRail
	{
		get
		{
			return isUseRail_;
		}
		set
		{
			isUseRail_ = value;
		}
	}

	public bool IsUsePlayerCamera
	{
		get
		{
			return isUsePlayerCamera_;
		}
		set
		{
			isUsePlayerCamera_ = value;
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

	public QuestCustom_PlayLevelSequence()
	{
	}

	public QuestCustom_PlayLevelSequence(QuestCustom_PlayLevelSequence other)
		: this()
	{
		sequenceId_ = other.sequenceId_;
		startTime_ = other.startTime_;
		isDisableMovementInput_ = other.isDisableMovementInput_;
		isDisableLookAtInput_ = other.isDisableLookAtInput_;
		isHidePlayer_ = other.isHidePlayer_;
		isHideHud_ = other.isHideHud_;
		isDisableCameraCuts_ = other.isDisableCameraCuts_;
		isUseCrane_ = other.isUseCrane_;
		isUseRail_ = other.isUseRail_;
		isUsePlayerCamera_ = other.isUsePlayerCamera_;
		isTriggerTransback_ = other.isTriggerTransback_;
		isTriggerMonsterGoHome_ = other.isTriggerMonsterGoHome_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_PlayLevelSequence Clone()
	{
		return new QuestCustom_PlayLevelSequence(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_PlayLevelSequence);
	}

	public bool Equals(QuestCustom_PlayLevelSequence other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SequenceId != other.SequenceId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(StartTime, other.StartTime))
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
		if (IsDisableCameraCuts != other.IsDisableCameraCuts)
		{
			return false;
		}
		if (IsUseCrane != other.IsUseCrane)
		{
			return false;
		}
		if (IsUseRail != other.IsUseRail)
		{
			return false;
		}
		if (IsUsePlayerCamera != other.IsUsePlayerCamera)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SequenceId != 0)
		{
			num ^= SequenceId.GetHashCode();
		}
		if (StartTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(StartTime);
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
		if (IsDisableCameraCuts)
		{
			num ^= IsDisableCameraCuts.GetHashCode();
		}
		if (IsUseCrane)
		{
			num ^= IsUseCrane.GetHashCode();
		}
		if (IsUseRail)
		{
			num ^= IsUseRail.GetHashCode();
		}
		if (IsUsePlayerCamera)
		{
			num ^= IsUsePlayerCamera.GetHashCode();
		}
		if (IsTriggerTransback)
		{
			num ^= IsTriggerTransback.GetHashCode();
		}
		if (IsTriggerMonsterGoHome)
		{
			num ^= IsTriggerMonsterGoHome.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SequenceId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SequenceId);
		}
		if (StartTime != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(StartTime);
		}
		if (IsDisableMovementInput)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsDisableMovementInput);
		}
		if (IsDisableLookAtInput)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsDisableLookAtInput);
		}
		if (IsHidePlayer)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsHidePlayer);
		}
		if (IsHideHud)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsHideHud);
		}
		if (IsDisableCameraCuts)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsDisableCameraCuts);
		}
		if (IsUseCrane)
		{
			output.WriteRawTag(64);
			output.WriteBool(IsUseCrane);
		}
		if (IsUseRail)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsUseRail);
		}
		if (IsUsePlayerCamera)
		{
			output.WriteRawTag(80);
			output.WriteBool(IsUsePlayerCamera);
		}
		if (IsTriggerTransback)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsTriggerTransback);
		}
		if (IsTriggerMonsterGoHome)
		{
			output.WriteRawTag(96);
			output.WriteBool(IsTriggerMonsterGoHome);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SequenceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SequenceId);
		}
		if (StartTime != 0f)
		{
			num += 5;
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
		if (IsDisableCameraCuts)
		{
			num += 2;
		}
		if (IsUseCrane)
		{
			num += 2;
		}
		if (IsUseRail)
		{
			num += 2;
		}
		if (IsUsePlayerCamera)
		{
			num += 2;
		}
		if (IsTriggerTransback)
		{
			num += 2;
		}
		if (IsTriggerMonsterGoHome)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_PlayLevelSequence other)
	{
		if (other != null)
		{
			if (other.SequenceId != 0)
			{
				SequenceId = other.SequenceId;
			}
			if (other.StartTime != 0f)
			{
				StartTime = other.StartTime;
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
			if (other.IsDisableCameraCuts)
			{
				IsDisableCameraCuts = other.IsDisableCameraCuts;
			}
			if (other.IsUseCrane)
			{
				IsUseCrane = other.IsUseCrane;
			}
			if (other.IsUseRail)
			{
				IsUseRail = other.IsUseRail;
			}
			if (other.IsUsePlayerCamera)
			{
				IsUsePlayerCamera = other.IsUsePlayerCamera;
			}
			if (other.IsTriggerTransback)
			{
				IsTriggerTransback = other.IsTriggerTransback;
			}
			if (other.IsTriggerMonsterGoHome)
			{
				IsTriggerMonsterGoHome = other.IsTriggerMonsterGoHome;
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
				SequenceId = input.ReadInt32();
				break;
			case 21u:
				StartTime = input.ReadFloat();
				break;
			case 24u:
				IsDisableMovementInput = input.ReadBool();
				break;
			case 32u:
				IsDisableLookAtInput = input.ReadBool();
				break;
			case 40u:
				IsHidePlayer = input.ReadBool();
				break;
			case 48u:
				IsHideHud = input.ReadBool();
				break;
			case 56u:
				IsDisableCameraCuts = input.ReadBool();
				break;
			case 64u:
				IsUseCrane = input.ReadBool();
				break;
			case 72u:
				IsUseRail = input.ReadBool();
				break;
			case 80u:
				IsUsePlayerCamera = input.ReadBool();
				break;
			case 88u:
				IsTriggerTransback = input.ReadBool();
				break;
			case 96u:
				IsTriggerMonsterGoHome = input.ReadBool();
				break;
			}
		}
	}
}
