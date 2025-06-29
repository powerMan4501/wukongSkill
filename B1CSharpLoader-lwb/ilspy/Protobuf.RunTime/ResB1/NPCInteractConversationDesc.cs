using System;
using Google.Protobuf;

namespace ResB1;

public sealed class NPCInteractConversationDesc : IMessage<NPCInteractConversationDesc>, IMessage, IEquatable<NPCInteractConversationDesc>, IDeepCloneable<NPCInteractConversationDesc>
{
	private static readonly MessageParser<NPCInteractConversationDesc> _parser = new MessageParser<NPCInteractConversationDesc>(() => new NPCInteractConversationDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int interactId_;

	private NPCConversationTriggerType triggerType_;

	private int param1_;

	private int param2_;

	private int aiConversationId_;

	public static MessageParser<NPCInteractConversationDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int InteractId
	{
		get
		{
			return interactId_;
		}
		set
		{
			interactId_ = value;
		}
	}

	public NPCConversationTriggerType TriggerType
	{
		get
		{
			return triggerType_;
		}
		set
		{
			triggerType_ = value;
		}
	}

	public int Param1
	{
		get
		{
			return param1_;
		}
		set
		{
			param1_ = value;
		}
	}

	public int Param2
	{
		get
		{
			return param2_;
		}
		set
		{
			param2_ = value;
		}
	}

	public int AiConversationId
	{
		get
		{
			return aiConversationId_;
		}
		set
		{
			aiConversationId_ = value;
		}
	}

	public NPCInteractConversationDesc()
	{
	}

	public NPCInteractConversationDesc(NPCInteractConversationDesc other)
		: this()
	{
		id_ = other.id_;
		interactId_ = other.interactId_;
		triggerType_ = other.triggerType_;
		param1_ = other.param1_;
		param2_ = other.param2_;
		aiConversationId_ = other.aiConversationId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public NPCInteractConversationDesc Clone()
	{
		return new NPCInteractConversationDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as NPCInteractConversationDesc);
	}

	public bool Equals(NPCInteractConversationDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (TriggerType != other.TriggerType)
		{
			return false;
		}
		if (Param1 != other.Param1)
		{
			return false;
		}
		if (Param2 != other.Param2)
		{
			return false;
		}
		if (AiConversationId != other.AiConversationId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (InteractId != 0)
		{
			num ^= InteractId.GetHashCode();
		}
		if (TriggerType != NPCConversationTriggerType.GetItem)
		{
			num ^= TriggerType.GetHashCode();
		}
		if (Param1 != 0)
		{
			num ^= Param1.GetHashCode();
		}
		if (Param2 != 0)
		{
			num ^= Param2.GetHashCode();
		}
		if (AiConversationId != 0)
		{
			num ^= AiConversationId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (InteractId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(InteractId);
		}
		if (TriggerType != NPCConversationTriggerType.GetItem)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)TriggerType);
		}
		if (Param1 != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Param1);
		}
		if (Param2 != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Param2);
		}
		if (AiConversationId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(AiConversationId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (InteractId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractId);
		}
		if (TriggerType != NPCConversationTriggerType.GetItem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TriggerType);
		}
		if (Param1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Param1);
		}
		if (Param2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Param2);
		}
		if (AiConversationId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AiConversationId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(NPCInteractConversationDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.InteractId != 0)
			{
				InteractId = other.InteractId;
			}
			if (other.TriggerType != NPCConversationTriggerType.GetItem)
			{
				TriggerType = other.TriggerType;
			}
			if (other.Param1 != 0)
			{
				Param1 = other.Param1;
			}
			if (other.Param2 != 0)
			{
				Param2 = other.Param2;
			}
			if (other.AiConversationId != 0)
			{
				AiConversationId = other.AiConversationId;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				InteractId = input.ReadInt32();
				break;
			case 24u:
				TriggerType = (NPCConversationTriggerType)input.ReadEnum();
				break;
			case 32u:
				Param1 = input.ReadInt32();
				break;
			case 40u:
				Param2 = input.ReadInt32();
				break;
			case 48u:
				AiConversationId = input.ReadInt32();
				break;
			}
		}
	}
}
