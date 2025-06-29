using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class OnlineChallengeData : IMessage<OnlineChallengeData>, IMessage, IEquatable<OnlineChallengeData>, IDeepCloneable<OnlineChallengeData>
{
	private static readonly MessageParser<OnlineChallengeData> _parser = new MessageParser<OnlineChallengeData>(() => new OnlineChallengeData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<DictDeltaMsgInt_ChallengeInfo> _repeated_onlineChallengeList_codec = FieldCodec.ForMessage(10u, DictDeltaMsgInt_ChallengeInfo.Parser);

	private readonly RepeatedField<DictDeltaMsgInt_ChallengeInfo> onlineChallengeList_ = new RepeatedField<DictDeltaMsgInt_ChallengeInfo>();

	private static readonly FieldCodec<DictDeltaMsgInt_EChallengeState> _repeated_onlineChallengeStageDict_codec = FieldCodec.ForMessage(18u, DictDeltaMsgInt_EChallengeState.Parser);

	private readonly RepeatedField<DictDeltaMsgInt_EChallengeState> onlineChallengeStageDict_ = new RepeatedField<DictDeltaMsgInt_EChallengeState>();

	public static MessageParser<OnlineChallengeData> Parser => _parser;

	public RepeatedField<DictDeltaMsgInt_ChallengeInfo> OnlineChallengeList => onlineChallengeList_;

	public RepeatedField<DictDeltaMsgInt_EChallengeState> OnlineChallengeStageDict => onlineChallengeStageDict_;

	public OnlineChallengeData()
	{
	}

	public OnlineChallengeData(OnlineChallengeData other)
		: this()
	{
		onlineChallengeList_ = other.onlineChallengeList_.Clone();
		onlineChallengeStageDict_ = other.onlineChallengeStageDict_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public OnlineChallengeData Clone()
	{
		return new OnlineChallengeData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as OnlineChallengeData);
	}

	public bool Equals(OnlineChallengeData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!onlineChallengeList_.Equals(other.onlineChallengeList_))
		{
			return false;
		}
		if (!onlineChallengeStageDict_.Equals(other.onlineChallengeStageDict_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= onlineChallengeList_.GetHashCode();
		num ^= onlineChallengeStageDict_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		onlineChallengeList_.WriteTo(output, _repeated_onlineChallengeList_codec);
		onlineChallengeStageDict_.WriteTo(output, _repeated_onlineChallengeStageDict_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += onlineChallengeList_.CalculateSize(_repeated_onlineChallengeList_codec);
		num += onlineChallengeStageDict_.CalculateSize(_repeated_onlineChallengeStageDict_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(OnlineChallengeData other)
	{
		if (other != null)
		{
			onlineChallengeList_.Add(other.onlineChallengeList_);
			onlineChallengeStageDict_.Add(other.onlineChallengeStageDict_);
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
				onlineChallengeList_.AddEntriesFrom(input, _repeated_onlineChallengeList_codec);
				break;
			case 18u:
				onlineChallengeStageDict_.AddEntriesFrom(input, _repeated_onlineChallengeStageDict_codec);
				break;
			}
		}
	}
}
