using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_SetInteractState : IMessage<QuestCustom_SetInteractState>, IMessage, IEquatable<QuestCustom_SetInteractState>, IDeepCloneable<QuestCustom_SetInteractState>
{
	private static readonly MessageParser<QuestCustom_SetInteractState> _parser = new MessageParser<QuestCustom_SetInteractState>(() => new QuestCustom_SetInteractState());

	private UnknownFieldSet _unknownFields;

	private bool interactState_;

	private string notifyActorGuid_ = "";

	private bool byChallengeLevel_;

	private int challengeId_;

	private static readonly FieldCodec<string> _repeated_notifyActorGuidList_codec = FieldCodec.ForString(42u);

	private readonly RepeatedField<string> notifyActorGuidList_ = new RepeatedField<string>();

	private bool ingoreHideLogic_;

	public static MessageParser<QuestCustom_SetInteractState> Parser => _parser;

	public bool InteractState
	{
		get
		{
			return interactState_;
		}
		set
		{
			interactState_ = value;
		}
	}

	public string NotifyActorGuid
	{
		get
		{
			return notifyActorGuid_;
		}
		set
		{
			notifyActorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool ByChallengeLevel
	{
		get
		{
			return byChallengeLevel_;
		}
		set
		{
			byChallengeLevel_ = value;
		}
	}

	public int ChallengeId
	{
		get
		{
			return challengeId_;
		}
		set
		{
			challengeId_ = value;
		}
	}

	public RepeatedField<string> NotifyActorGuidList => notifyActorGuidList_;

	public bool IngoreHideLogic
	{
		get
		{
			return ingoreHideLogic_;
		}
		set
		{
			ingoreHideLogic_ = value;
		}
	}

	public QuestCustom_SetInteractState()
	{
	}

	public QuestCustom_SetInteractState(QuestCustom_SetInteractState other)
		: this()
	{
		interactState_ = other.interactState_;
		notifyActorGuid_ = other.notifyActorGuid_;
		byChallengeLevel_ = other.byChallengeLevel_;
		challengeId_ = other.challengeId_;
		notifyActorGuidList_ = other.notifyActorGuidList_.Clone();
		ingoreHideLogic_ = other.ingoreHideLogic_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_SetInteractState Clone()
	{
		return new QuestCustom_SetInteractState(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_SetInteractState);
	}

	public bool Equals(QuestCustom_SetInteractState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InteractState != other.InteractState)
		{
			return false;
		}
		if (NotifyActorGuid != other.NotifyActorGuid)
		{
			return false;
		}
		if (ByChallengeLevel != other.ByChallengeLevel)
		{
			return false;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (!notifyActorGuidList_.Equals(other.notifyActorGuidList_))
		{
			return false;
		}
		if (IngoreHideLogic != other.IngoreHideLogic)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (InteractState)
		{
			num ^= InteractState.GetHashCode();
		}
		if (NotifyActorGuid.Length != 0)
		{
			num ^= NotifyActorGuid.GetHashCode();
		}
		if (ByChallengeLevel)
		{
			num ^= ByChallengeLevel.GetHashCode();
		}
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		num ^= notifyActorGuidList_.GetHashCode();
		if (IngoreHideLogic)
		{
			num ^= IngoreHideLogic.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (InteractState)
		{
			output.WriteRawTag(8);
			output.WriteBool(InteractState);
		}
		if (NotifyActorGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(NotifyActorGuid);
		}
		if (ByChallengeLevel)
		{
			output.WriteRawTag(24);
			output.WriteBool(ByChallengeLevel);
		}
		if (ChallengeId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ChallengeId);
		}
		notifyActorGuidList_.WriteTo(output, _repeated_notifyActorGuidList_codec);
		if (IngoreHideLogic)
		{
			output.WriteRawTag(48);
			output.WriteBool(IngoreHideLogic);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (InteractState)
		{
			num += 2;
		}
		if (NotifyActorGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NotifyActorGuid);
		}
		if (ByChallengeLevel)
		{
			num += 2;
		}
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChallengeId);
		}
		num += notifyActorGuidList_.CalculateSize(_repeated_notifyActorGuidList_codec);
		if (IngoreHideLogic)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_SetInteractState other)
	{
		if (other != null)
		{
			if (other.InteractState)
			{
				InteractState = other.InteractState;
			}
			if (other.NotifyActorGuid.Length != 0)
			{
				NotifyActorGuid = other.NotifyActorGuid;
			}
			if (other.ByChallengeLevel)
			{
				ByChallengeLevel = other.ByChallengeLevel;
			}
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
			}
			notifyActorGuidList_.Add(other.notifyActorGuidList_);
			if (other.IngoreHideLogic)
			{
				IngoreHideLogic = other.IngoreHideLogic;
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
				InteractState = input.ReadBool();
				break;
			case 18u:
				NotifyActorGuid = input.ReadString();
				break;
			case 24u:
				ByChallengeLevel = input.ReadBool();
				break;
			case 32u:
				ChallengeId = input.ReadInt32();
				break;
			case 42u:
				notifyActorGuidList_.AddEntriesFrom(input, _repeated_notifyActorGuidList_codec);
				break;
			case 48u:
				IngoreHideLogic = input.ReadBool();
				break;
			}
		}
	}
}
