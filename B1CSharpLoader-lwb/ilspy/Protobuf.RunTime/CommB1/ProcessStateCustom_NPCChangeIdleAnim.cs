using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_NPCChangeIdleAnim : IMessage<ProcessStateCustom_NPCChangeIdleAnim>, IMessage, IEquatable<ProcessStateCustom_NPCChangeIdleAnim>, IDeepCloneable<ProcessStateCustom_NPCChangeIdleAnim>
{
	private static readonly MessageParser<ProcessStateCustom_NPCChangeIdleAnim> _parser = new MessageParser<ProcessStateCustom_NPCChangeIdleAnim>(() => new ProcessStateCustom_NPCChangeIdleAnim());

	private UnknownFieldSet _unknownFields;

	private string notifyActorGuid_ = "";

	private int changeIdleAnimIdx_;

	public static MessageParser<ProcessStateCustom_NPCChangeIdleAnim> Parser => _parser;

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

	public int ChangeIdleAnimIdx
	{
		get
		{
			return changeIdleAnimIdx_;
		}
		set
		{
			changeIdleAnimIdx_ = value;
		}
	}

	public ProcessStateCustom_NPCChangeIdleAnim()
	{
	}

	public ProcessStateCustom_NPCChangeIdleAnim(ProcessStateCustom_NPCChangeIdleAnim other)
		: this()
	{
		notifyActorGuid_ = other.notifyActorGuid_;
		changeIdleAnimIdx_ = other.changeIdleAnimIdx_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_NPCChangeIdleAnim Clone()
	{
		return new ProcessStateCustom_NPCChangeIdleAnim(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_NPCChangeIdleAnim);
	}

	public bool Equals(ProcessStateCustom_NPCChangeIdleAnim other)
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
		if (ChangeIdleAnimIdx != other.ChangeIdleAnimIdx)
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
		if (ChangeIdleAnimIdx != 0)
		{
			num ^= ChangeIdleAnimIdx.GetHashCode();
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
		if (ChangeIdleAnimIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ChangeIdleAnimIdx);
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
		if (ChangeIdleAnimIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChangeIdleAnimIdx);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_NPCChangeIdleAnim other)
	{
		if (other != null)
		{
			if (other.NotifyActorGuid.Length != 0)
			{
				NotifyActorGuid = other.NotifyActorGuid;
			}
			if (other.ChangeIdleAnimIdx != 0)
			{
				ChangeIdleAnimIdx = other.ChangeIdleAnimIdx;
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
				ChangeIdleAnimIdx = input.ReadInt32();
				break;
			}
		}
	}
}
