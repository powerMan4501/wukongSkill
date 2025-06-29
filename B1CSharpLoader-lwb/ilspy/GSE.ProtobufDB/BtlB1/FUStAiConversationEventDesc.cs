using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStAiConversationEventDesc : IMessage<FUStAiConversationEventDesc>, IMessage, IEquatable<FUStAiConversationEventDesc>, IDeepCloneable<FUStAiConversationEventDesc>
{
	private static readonly MessageParser<FUStAiConversationEventDesc> _parser = new MessageParser<FUStAiConversationEventDesc>(() => new FUStAiConversationEventDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int resID_;

	private EAiConversationEventType eventType_;

	private int prority_;

	private int distanceToPlayer_;

	private static readonly FieldCodec<int> _repeated_conversationIDs_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> conversationIDs_ = new RepeatedField<int>();

	public static MessageParser<FUStAiConversationEventDesc> Parser => _parser;

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

	public EAiConversationEventType EventType
	{
		get
		{
			return eventType_;
		}
		set
		{
			eventType_ = value;
		}
	}

	public int Prority
	{
		get
		{
			return prority_;
		}
		set
		{
			prority_ = value;
		}
	}

	public int DistanceToPlayer
	{
		get
		{
			return distanceToPlayer_;
		}
		set
		{
			distanceToPlayer_ = value;
		}
	}

	public RepeatedField<int> ConversationIDs => conversationIDs_;

	public FUStAiConversationEventDesc()
	{
	}

	public FUStAiConversationEventDesc(FUStAiConversationEventDesc other)
		: this()
	{
		iD_ = other.iD_;
		resID_ = other.resID_;
		eventType_ = other.eventType_;
		prority_ = other.prority_;
		distanceToPlayer_ = other.distanceToPlayer_;
		conversationIDs_ = other.conversationIDs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAiConversationEventDesc Clone()
	{
		return new FUStAiConversationEventDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAiConversationEventDesc);
	}

	public bool Equals(FUStAiConversationEventDesc other)
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
		if (EventType != other.EventType)
		{
			return false;
		}
		if (Prority != other.Prority)
		{
			return false;
		}
		if (DistanceToPlayer != other.DistanceToPlayer)
		{
			return false;
		}
		if (!conversationIDs_.Equals(other.conversationIDs_))
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
		if (EventType != EAiConversationEventType.None)
		{
			num ^= EventType.GetHashCode();
		}
		if (Prority != 0)
		{
			num ^= Prority.GetHashCode();
		}
		if (DistanceToPlayer != 0)
		{
			num ^= DistanceToPlayer.GetHashCode();
		}
		num ^= conversationIDs_.GetHashCode();
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
		if (EventType != EAiConversationEventType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)EventType);
		}
		if (Prority != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Prority);
		}
		if (DistanceToPlayer != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DistanceToPlayer);
		}
		conversationIDs_.WriteTo(output, _repeated_conversationIDs_codec);
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
		if (EventType != EAiConversationEventType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EventType);
		}
		if (Prority != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Prority);
		}
		if (DistanceToPlayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DistanceToPlayer);
		}
		num += conversationIDs_.CalculateSize(_repeated_conversationIDs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAiConversationEventDesc other)
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
			if (other.EventType != EAiConversationEventType.None)
			{
				EventType = other.EventType;
			}
			if (other.Prority != 0)
			{
				Prority = other.Prority;
			}
			if (other.DistanceToPlayer != 0)
			{
				DistanceToPlayer = other.DistanceToPlayer;
			}
			conversationIDs_.Add(other.conversationIDs_);
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
				EventType = (EAiConversationEventType)input.ReadEnum();
				break;
			case 32u:
				Prority = input.ReadInt32();
				break;
			case 40u:
				DistanceToPlayer = input.ReadInt32();
				break;
			case 48u:
			case 50u:
				conversationIDs_.AddEntriesFrom(input, _repeated_conversationIDs_codec);
				break;
			}
		}
	}
}
