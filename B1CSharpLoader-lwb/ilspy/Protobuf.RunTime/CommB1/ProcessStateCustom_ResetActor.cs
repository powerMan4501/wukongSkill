using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_ResetActor : IMessage<ProcessStateCustom_ResetActor>, IMessage, IEquatable<ProcessStateCustom_ResetActor>, IDeepCloneable<ProcessStateCustom_ResetActor>
{
	private static readonly MessageParser<ProcessStateCustom_ResetActor> _parser = new MessageParser<ProcessStateCustom_ResetActor>(() => new ProcessStateCustom_ResetActor());

	private UnknownFieldSet _unknownFields;

	private string notifyActorGuid_ = "";

	private int actorResetType_;

	public static MessageParser<ProcessStateCustom_ResetActor> Parser => _parser;

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

	public int ActorResetType
	{
		get
		{
			return actorResetType_;
		}
		set
		{
			actorResetType_ = value;
		}
	}

	public ProcessStateCustom_ResetActor()
	{
	}

	public ProcessStateCustom_ResetActor(ProcessStateCustom_ResetActor other)
		: this()
	{
		notifyActorGuid_ = other.notifyActorGuid_;
		actorResetType_ = other.actorResetType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_ResetActor Clone()
	{
		return new ProcessStateCustom_ResetActor(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_ResetActor);
	}

	public bool Equals(ProcessStateCustom_ResetActor other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NotifyActorGuid != other.NotifyActorGuid)
		{
			return false;
		}
		if (ActorResetType != other.ActorResetType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (NotifyActorGuid.Length != 0)
		{
			num ^= NotifyActorGuid.GetHashCode();
		}
		if (ActorResetType != 0)
		{
			num ^= ActorResetType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (NotifyActorGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(NotifyActorGuid);
		}
		if (ActorResetType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ActorResetType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (NotifyActorGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NotifyActorGuid);
		}
		if (ActorResetType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ActorResetType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_ResetActor other)
	{
		if (other != null)
		{
			if (other.NotifyActorGuid.Length != 0)
			{
				NotifyActorGuid = other.NotifyActorGuid;
			}
			if (other.ActorResetType != 0)
			{
				ActorResetType = other.ActorResetType;
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
				NotifyActorGuid = input.ReadString();
				break;
			case 16u:
				ActorResetType = input.ReadInt32();
				break;
			}
		}
	}
}
