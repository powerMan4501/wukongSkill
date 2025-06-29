using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_ChallengeSuccess : IMessage<QuestCustom_ChallengeSuccess>, IMessage, IEquatable<QuestCustom_ChallengeSuccess>, IDeepCloneable<QuestCustom_ChallengeSuccess>
{
	private static readonly MessageParser<QuestCustom_ChallengeSuccess> _parser = new MessageParser<QuestCustom_ChallengeSuccess>(() => new QuestCustom_ChallengeSuccess());

	private UnknownFieldSet _unknownFields;

	private int challengeId_;

	public static MessageParser<QuestCustom_ChallengeSuccess> Parser => _parser;

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

	public QuestCustom_ChallengeSuccess()
	{
	}

	public QuestCustom_ChallengeSuccess(QuestCustom_ChallengeSuccess other)
		: this()
	{
		challengeId_ = other.challengeId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_ChallengeSuccess Clone()
	{
		return new QuestCustom_ChallengeSuccess(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_ChallengeSuccess);
	}

	public bool Equals(QuestCustom_ChallengeSuccess other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (ChallengeId != 0)
		{
			output.WriteRawTag(8);
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

	public void MergeFrom(QuestCustom_ChallengeSuccess other)
	{
		if (other != null)
		{
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				ChallengeId = input.ReadInt32();
			}
		}
	}
}
