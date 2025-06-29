using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_StartWaveSpawnByChallenge : IMessage<QuestCustom_StartWaveSpawnByChallenge>, IMessage, IEquatable<QuestCustom_StartWaveSpawnByChallenge>, IDeepCloneable<QuestCustom_StartWaveSpawnByChallenge>
{
	private static readonly MessageParser<QuestCustom_StartWaveSpawnByChallenge> _parser = new MessageParser<QuestCustom_StartWaveSpawnByChallenge>(() => new QuestCustom_StartWaveSpawnByChallenge());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<string> _repeated_observeActorGuid_codec = FieldCodec.ForString(10u);

	private readonly RepeatedField<string> observeActorGuid_ = new RepeatedField<string>();

	private int challengeId_;

	private bool needPlayMontage_;

	private string playMontageActorGuid_ = "";

	private string amPathEasy_ = "";

	private string amPathNormal_ = "";

	private string amPathHard_ = "";

	public static MessageParser<QuestCustom_StartWaveSpawnByChallenge> Parser => _parser;

	public RepeatedField<string> ObserveActorGuid => observeActorGuid_;

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

	public bool NeedPlayMontage
	{
		get
		{
			return needPlayMontage_;
		}
		set
		{
			needPlayMontage_ = value;
		}
	}

	public string PlayMontageActorGuid
	{
		get
		{
			return playMontageActorGuid_;
		}
		set
		{
			playMontageActorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AmPathEasy
	{
		get
		{
			return amPathEasy_;
		}
		set
		{
			amPathEasy_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AmPathNormal
	{
		get
		{
			return amPathNormal_;
		}
		set
		{
			amPathNormal_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AmPathHard
	{
		get
		{
			return amPathHard_;
		}
		set
		{
			amPathHard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public QuestCustom_StartWaveSpawnByChallenge()
	{
	}

	public QuestCustom_StartWaveSpawnByChallenge(QuestCustom_StartWaveSpawnByChallenge other)
		: this()
	{
		observeActorGuid_ = other.observeActorGuid_.Clone();
		challengeId_ = other.challengeId_;
		needPlayMontage_ = other.needPlayMontage_;
		playMontageActorGuid_ = other.playMontageActorGuid_;
		amPathEasy_ = other.amPathEasy_;
		amPathNormal_ = other.amPathNormal_;
		amPathHard_ = other.amPathHard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_StartWaveSpawnByChallenge Clone()
	{
		return new QuestCustom_StartWaveSpawnByChallenge(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_StartWaveSpawnByChallenge);
	}

	public bool Equals(QuestCustom_StartWaveSpawnByChallenge other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!observeActorGuid_.Equals(other.observeActorGuid_))
		{
			return false;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (NeedPlayMontage != other.NeedPlayMontage)
		{
			return false;
		}
		if (PlayMontageActorGuid != other.PlayMontageActorGuid)
		{
			return false;
		}
		if (AmPathEasy != other.AmPathEasy)
		{
			return false;
		}
		if (AmPathNormal != other.AmPathNormal)
		{
			return false;
		}
		if (AmPathHard != other.AmPathHard)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= observeActorGuid_.GetHashCode();
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (NeedPlayMontage)
		{
			num ^= NeedPlayMontage.GetHashCode();
		}
		if (PlayMontageActorGuid.Length != 0)
		{
			num ^= PlayMontageActorGuid.GetHashCode();
		}
		if (AmPathEasy.Length != 0)
		{
			num ^= AmPathEasy.GetHashCode();
		}
		if (AmPathNormal.Length != 0)
		{
			num ^= AmPathNormal.GetHashCode();
		}
		if (AmPathHard.Length != 0)
		{
			num ^= AmPathHard.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		observeActorGuid_.WriteTo(output, _repeated_observeActorGuid_codec);
		if (ChallengeId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ChallengeId);
		}
		if (NeedPlayMontage)
		{
			output.WriteRawTag(24);
			output.WriteBool(NeedPlayMontage);
		}
		if (PlayMontageActorGuid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(PlayMontageActorGuid);
		}
		if (AmPathEasy.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(AmPathEasy);
		}
		if (AmPathNormal.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(AmPathNormal);
		}
		if (AmPathHard.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(AmPathHard);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += observeActorGuid_.CalculateSize(_repeated_observeActorGuid_codec);
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChallengeId);
		}
		if (NeedPlayMontage)
		{
			num += 2;
		}
		if (PlayMontageActorGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PlayMontageActorGuid);
		}
		if (AmPathEasy.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AmPathEasy);
		}
		if (AmPathNormal.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AmPathNormal);
		}
		if (AmPathHard.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AmPathHard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_StartWaveSpawnByChallenge other)
	{
		if (other != null)
		{
			observeActorGuid_.Add(other.observeActorGuid_);
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
			}
			if (other.NeedPlayMontage)
			{
				NeedPlayMontage = other.NeedPlayMontage;
			}
			if (other.PlayMontageActorGuid.Length != 0)
			{
				PlayMontageActorGuid = other.PlayMontageActorGuid;
			}
			if (other.AmPathEasy.Length != 0)
			{
				AmPathEasy = other.AmPathEasy;
			}
			if (other.AmPathNormal.Length != 0)
			{
				AmPathNormal = other.AmPathNormal;
			}
			if (other.AmPathHard.Length != 0)
			{
				AmPathHard = other.AmPathHard;
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
			case 10u:
				observeActorGuid_.AddEntriesFrom(input, _repeated_observeActorGuid_codec);
				break;
			case 16u:
				ChallengeId = input.ReadInt32();
				break;
			case 24u:
				NeedPlayMontage = input.ReadBool();
				break;
			case 34u:
				PlayMontageActorGuid = input.ReadString();
				break;
			case 42u:
				AmPathEasy = input.ReadString();
				break;
			case 50u:
				AmPathNormal = input.ReadString();
				break;
			case 58u:
				AmPathHard = input.ReadString();
				break;
			}
		}
	}
}
