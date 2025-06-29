using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_StopWaveSpawnByChallenge : IMessage<QuestCustom_StopWaveSpawnByChallenge>, IMessage, IEquatable<QuestCustom_StopWaveSpawnByChallenge>, IDeepCloneable<QuestCustom_StopWaveSpawnByChallenge>
{
	private static readonly MessageParser<QuestCustom_StopWaveSpawnByChallenge> _parser = new MessageParser<QuestCustom_StopWaveSpawnByChallenge>(() => new QuestCustom_StopWaveSpawnByChallenge());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<string> _repeated_observeActorGuid_codec = FieldCodec.ForString(10u);

	private readonly RepeatedField<string> observeActorGuid_ = new RepeatedField<string>();

	private int challengeId_;

	public static MessageParser<QuestCustom_StopWaveSpawnByChallenge> Parser => _parser;

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

	public QuestCustom_StopWaveSpawnByChallenge()
	{
	}

	public QuestCustom_StopWaveSpawnByChallenge(QuestCustom_StopWaveSpawnByChallenge other)
		: this()
	{
		observeActorGuid_ = other.observeActorGuid_.Clone();
		challengeId_ = other.challengeId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_StopWaveSpawnByChallenge Clone()
	{
		return new QuestCustom_StopWaveSpawnByChallenge(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_StopWaveSpawnByChallenge);
	}

	public bool Equals(QuestCustom_StopWaveSpawnByChallenge other)
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_StopWaveSpawnByChallenge other)
	{
		if (other != null)
		{
			observeActorGuid_.Add(other.observeActorGuid_);
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
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
			}
		}
	}
}
