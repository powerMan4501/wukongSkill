using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BPC_RebirthPointData : IMessage<BPC_RebirthPointData>, IMessage, IEquatable<BPC_RebirthPointData>, IDeepCloneable<BPC_RebirthPointData>
{
	private static readonly MessageParser<BPC_RebirthPointData> _parser = new MessageParser<BPC_RebirthPointData>(() => new BPC_RebirthPointData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private FBirthPointInfo currentBirthPoint_;

	private static readonly FieldCodec<ListDeltaMsgInt> _repeated_activedRebirthPointList_codec = FieldCodec.ForMessage(18u, ListDeltaMsgInt.Parser);

	private readonly RepeatedField<ListDeltaMsgInt> activedRebirthPointList_ = new RepeatedField<ListDeltaMsgInt>();

	private int currentRebirthPointIDRemoved_;

	private int lastRebirthPointTime_;

	private static readonly FieldCodec<DictDeltaMsgInt_Int> _repeated_currentRebirthPointIDMap_codec = FieldCodec.ForMessage(42u, DictDeltaMsgInt_Int.Parser);

	private readonly RepeatedField<DictDeltaMsgInt_Int> currentRebirthPointIDMap_ = new RepeatedField<DictDeltaMsgInt_Int>();

	private static readonly FieldCodec<ListDeltaMsgInt> _repeated_blockdRebirthPointListRemoved_codec = FieldCodec.ForMessage(50u, ListDeltaMsgInt.Parser);

	private readonly RepeatedField<ListDeltaMsgInt> blockdRebirthPointListRemoved_ = new RepeatedField<ListDeltaMsgInt>();

	private static readonly FieldCodec<ListDeltaMsgInt> _repeated_blockedRebirthPointList_codec = FieldCodec.ForMessage(58u, ListDeltaMsgInt.Parser);

	private readonly RepeatedField<ListDeltaMsgInt> blockedRebirthPointList_ = new RepeatedField<ListDeltaMsgInt>();

	public static MessageParser<BPC_RebirthPointData> Parser => _parser;

	public FBirthPointInfo CurrentBirthPoint
	{
		get
		{
			return currentBirthPoint_;
		}
		set
		{
			currentBirthPoint_ = value;
		}
	}

	public RepeatedField<ListDeltaMsgInt> ActivedRebirthPointList => activedRebirthPointList_;

	public int CurrentRebirthPointIDRemoved
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return currentRebirthPointIDRemoved_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			currentRebirthPointIDRemoved_ = value;
		}
	}

	public bool HasCurrentRebirthPointIDRemoved => (_hasBits0 & 1) != 0;

	public int LastRebirthPointTime
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return lastRebirthPointTime_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			lastRebirthPointTime_ = value;
		}
	}

	public bool HasLastRebirthPointTime => (_hasBits0 & 2) != 0;

	public RepeatedField<DictDeltaMsgInt_Int> CurrentRebirthPointIDMap => currentRebirthPointIDMap_;

	public RepeatedField<ListDeltaMsgInt> BlockdRebirthPointListRemoved => blockdRebirthPointListRemoved_;

	public RepeatedField<ListDeltaMsgInt> BlockedRebirthPointList => blockedRebirthPointList_;

	public BPC_RebirthPointData()
	{
	}

	public BPC_RebirthPointData(BPC_RebirthPointData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		currentBirthPoint_ = ((other.currentBirthPoint_ != null) ? other.currentBirthPoint_.Clone() : null);
		activedRebirthPointList_ = other.activedRebirthPointList_.Clone();
		currentRebirthPointIDRemoved_ = other.currentRebirthPointIDRemoved_;
		lastRebirthPointTime_ = other.lastRebirthPointTime_;
		currentRebirthPointIDMap_ = other.currentRebirthPointIDMap_.Clone();
		blockdRebirthPointListRemoved_ = other.blockdRebirthPointListRemoved_.Clone();
		blockedRebirthPointList_ = other.blockedRebirthPointList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BPC_RebirthPointData Clone()
	{
		return new BPC_RebirthPointData(this);
	}

	public void ClearCurrentRebirthPointIDRemoved()
	{
		_hasBits0 &= -2;
	}

	public void ClearLastRebirthPointTime()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BPC_RebirthPointData);
	}

	public bool Equals(BPC_RebirthPointData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CurrentBirthPoint, other.CurrentBirthPoint))
		{
			return false;
		}
		if (!activedRebirthPointList_.Equals(other.activedRebirthPointList_))
		{
			return false;
		}
		if (CurrentRebirthPointIDRemoved != other.CurrentRebirthPointIDRemoved)
		{
			return false;
		}
		if (LastRebirthPointTime != other.LastRebirthPointTime)
		{
			return false;
		}
		if (!currentRebirthPointIDMap_.Equals(other.currentRebirthPointIDMap_))
		{
			return false;
		}
		if (!blockdRebirthPointListRemoved_.Equals(other.blockdRebirthPointListRemoved_))
		{
			return false;
		}
		if (!blockedRebirthPointList_.Equals(other.blockedRebirthPointList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (currentBirthPoint_ != null)
		{
			num ^= CurrentBirthPoint.GetHashCode();
		}
		num ^= activedRebirthPointList_.GetHashCode();
		if (HasCurrentRebirthPointIDRemoved)
		{
			num ^= CurrentRebirthPointIDRemoved.GetHashCode();
		}
		if (HasLastRebirthPointTime)
		{
			num ^= LastRebirthPointTime.GetHashCode();
		}
		num ^= currentRebirthPointIDMap_.GetHashCode();
		num ^= blockdRebirthPointListRemoved_.GetHashCode();
		num ^= blockedRebirthPointList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (currentBirthPoint_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(CurrentBirthPoint);
		}
		activedRebirthPointList_.WriteTo(output, _repeated_activedRebirthPointList_codec);
		if (HasCurrentRebirthPointIDRemoved)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CurrentRebirthPointIDRemoved);
		}
		if (HasLastRebirthPointTime)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LastRebirthPointTime);
		}
		currentRebirthPointIDMap_.WriteTo(output, _repeated_currentRebirthPointIDMap_codec);
		blockdRebirthPointListRemoved_.WriteTo(output, _repeated_blockdRebirthPointListRemoved_codec);
		blockedRebirthPointList_.WriteTo(output, _repeated_blockedRebirthPointList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (currentBirthPoint_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CurrentBirthPoint);
		}
		num += activedRebirthPointList_.CalculateSize(_repeated_activedRebirthPointList_codec);
		if (HasCurrentRebirthPointIDRemoved)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurrentRebirthPointIDRemoved);
		}
		if (HasLastRebirthPointTime)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LastRebirthPointTime);
		}
		num += currentRebirthPointIDMap_.CalculateSize(_repeated_currentRebirthPointIDMap_codec);
		num += blockdRebirthPointListRemoved_.CalculateSize(_repeated_blockdRebirthPointListRemoved_codec);
		num += blockedRebirthPointList_.CalculateSize(_repeated_blockedRebirthPointList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BPC_RebirthPointData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.currentBirthPoint_ != null)
		{
			if (currentBirthPoint_ == null)
			{
				CurrentBirthPoint = new FBirthPointInfo();
			}
			CurrentBirthPoint.MergeFrom(other.CurrentBirthPoint);
		}
		activedRebirthPointList_.Add(other.activedRebirthPointList_);
		if (other.HasCurrentRebirthPointIDRemoved)
		{
			CurrentRebirthPointIDRemoved = other.CurrentRebirthPointIDRemoved;
		}
		if (other.HasLastRebirthPointTime)
		{
			LastRebirthPointTime = other.LastRebirthPointTime;
		}
		currentRebirthPointIDMap_.Add(other.currentRebirthPointIDMap_);
		blockdRebirthPointListRemoved_.Add(other.blockdRebirthPointListRemoved_);
		blockedRebirthPointList_.Add(other.blockedRebirthPointList_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (currentBirthPoint_ == null)
				{
					CurrentBirthPoint = new FBirthPointInfo();
				}
				input.ReadMessage(CurrentBirthPoint);
				break;
			case 18u:
				activedRebirthPointList_.AddEntriesFrom(input, _repeated_activedRebirthPointList_codec);
				break;
			case 24u:
				CurrentRebirthPointIDRemoved = input.ReadInt32();
				break;
			case 32u:
				LastRebirthPointTime = input.ReadInt32();
				break;
			case 42u:
				currentRebirthPointIDMap_.AddEntriesFrom(input, _repeated_currentRebirthPointIDMap_codec);
				break;
			case 50u:
				blockdRebirthPointListRemoved_.AddEntriesFrom(input, _repeated_blockdRebirthPointListRemoved_codec);
				break;
			case 58u:
				blockedRebirthPointList_.AddEntriesFrom(input, _repeated_blockedRebirthPointList_codec);
				break;
			}
		}
	}
}
