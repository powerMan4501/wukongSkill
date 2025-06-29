using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_SetAwardState : IMessage<QuestCustom_SetAwardState>, IMessage, IEquatable<QuestCustom_SetAwardState>, IDeepCloneable<QuestCustom_SetAwardState>
{
	private static readonly MessageParser<QuestCustom_SetAwardState> _parser = new MessageParser<QuestCustom_SetAwardState>(() => new QuestCustom_SetAwardState());

	private UnknownFieldSet _unknownFields;

	private int eventId_;

	private int distance_;

	private int centerDistance_;

	private float centerPointX_;

	private float centerPointY_;

	private float centerPointZ_;

	private string observedActorGuid_ = "";

	private static readonly FieldCodec<int> _repeated_conditionList_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> conditionList_ = new RepeatedField<int>();

	public static MessageParser<QuestCustom_SetAwardState> Parser => _parser;

	public int EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	public int Distance
	{
		get
		{
			return distance_;
		}
		set
		{
			distance_ = value;
		}
	}

	public int CenterDistance
	{
		get
		{
			return centerDistance_;
		}
		set
		{
			centerDistance_ = value;
		}
	}

	public float CenterPointX
	{
		get
		{
			return centerPointX_;
		}
		set
		{
			centerPointX_ = value;
		}
	}

	public float CenterPointY
	{
		get
		{
			return centerPointY_;
		}
		set
		{
			centerPointY_ = value;
		}
	}

	public float CenterPointZ
	{
		get
		{
			return centerPointZ_;
		}
		set
		{
			centerPointZ_ = value;
		}
	}

	public string ObservedActorGuid
	{
		get
		{
			return observedActorGuid_;
		}
		set
		{
			observedActorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> ConditionList => conditionList_;

	public QuestCustom_SetAwardState()
	{
	}

	public QuestCustom_SetAwardState(QuestCustom_SetAwardState other)
		: this()
	{
		eventId_ = other.eventId_;
		distance_ = other.distance_;
		centerDistance_ = other.centerDistance_;
		centerPointX_ = other.centerPointX_;
		centerPointY_ = other.centerPointY_;
		centerPointZ_ = other.centerPointZ_;
		observedActorGuid_ = other.observedActorGuid_;
		conditionList_ = other.conditionList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_SetAwardState Clone()
	{
		return new QuestCustom_SetAwardState(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_SetAwardState);
	}

	public bool Equals(QuestCustom_SetAwardState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (Distance != other.Distance)
		{
			return false;
		}
		if (CenterDistance != other.CenterDistance)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CenterPointX, other.CenterPointX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CenterPointY, other.CenterPointY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CenterPointZ, other.CenterPointZ))
		{
			return false;
		}
		if (ObservedActorGuid != other.ObservedActorGuid)
		{
			return false;
		}
		if (!conditionList_.Equals(other.conditionList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (Distance != 0)
		{
			num ^= Distance.GetHashCode();
		}
		if (CenterDistance != 0)
		{
			num ^= CenterDistance.GetHashCode();
		}
		if (CenterPointX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CenterPointX);
		}
		if (CenterPointY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CenterPointY);
		}
		if (CenterPointZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CenterPointZ);
		}
		if (ObservedActorGuid.Length != 0)
		{
			num ^= ObservedActorGuid.GetHashCode();
		}
		num ^= conditionList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EventId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventId);
		}
		if (Distance != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Distance);
		}
		if (CenterDistance != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CenterDistance);
		}
		if (CenterPointX != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(CenterPointX);
		}
		if (CenterPointY != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(CenterPointY);
		}
		if (CenterPointZ != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(CenterPointZ);
		}
		if (ObservedActorGuid.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(ObservedActorGuid);
		}
		conditionList_.WriteTo(output, _repeated_conditionList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventId);
		}
		if (Distance != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Distance);
		}
		if (CenterDistance != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CenterDistance);
		}
		if (CenterPointX != 0f)
		{
			num += 5;
		}
		if (CenterPointY != 0f)
		{
			num += 5;
		}
		if (CenterPointZ != 0f)
		{
			num += 5;
		}
		if (ObservedActorGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ObservedActorGuid);
		}
		num += conditionList_.CalculateSize(_repeated_conditionList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_SetAwardState other)
	{
		if (other != null)
		{
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.Distance != 0)
			{
				Distance = other.Distance;
			}
			if (other.CenterDistance != 0)
			{
				CenterDistance = other.CenterDistance;
			}
			if (other.CenterPointX != 0f)
			{
				CenterPointX = other.CenterPointX;
			}
			if (other.CenterPointY != 0f)
			{
				CenterPointY = other.CenterPointY;
			}
			if (other.CenterPointZ != 0f)
			{
				CenterPointZ = other.CenterPointZ;
			}
			if (other.ObservedActorGuid.Length != 0)
			{
				ObservedActorGuid = other.ObservedActorGuid;
			}
			conditionList_.Add(other.conditionList_);
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
				EventId = input.ReadInt32();
				break;
			case 16u:
				Distance = input.ReadInt32();
				break;
			case 24u:
				CenterDistance = input.ReadInt32();
				break;
			case 37u:
				CenterPointX = input.ReadFloat();
				break;
			case 45u:
				CenterPointY = input.ReadFloat();
				break;
			case 53u:
				CenterPointZ = input.ReadFloat();
				break;
			case 58u:
				ObservedActorGuid = input.ReadString();
				break;
			case 64u:
			case 66u:
				conditionList_.AddEntriesFrom(input, _repeated_conditionList_codec);
				break;
			}
		}
	}
}
