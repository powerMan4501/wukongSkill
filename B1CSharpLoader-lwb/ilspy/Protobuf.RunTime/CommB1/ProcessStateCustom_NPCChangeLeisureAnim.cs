using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_NPCChangeLeisureAnim : IMessage<ProcessStateCustom_NPCChangeLeisureAnim>, IMessage, IEquatable<ProcessStateCustom_NPCChangeLeisureAnim>, IDeepCloneable<ProcessStateCustom_NPCChangeLeisureAnim>
{
	private static readonly MessageParser<ProcessStateCustom_NPCChangeLeisureAnim> _parser = new MessageParser<ProcessStateCustom_NPCChangeLeisureAnim>(() => new ProcessStateCustom_NPCChangeLeisureAnim());

	private UnknownFieldSet _unknownFields;

	private string notifyActorGuid_ = "";

	private int changeLeisureAnimIndex_;

	public static MessageParser<ProcessStateCustom_NPCChangeLeisureAnim> Parser => _parser;

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

	public int ChangeLeisureAnimIndex
	{
		get
		{
			return changeLeisureAnimIndex_;
		}
		set
		{
			changeLeisureAnimIndex_ = value;
		}
	}

	public ProcessStateCustom_NPCChangeLeisureAnim()
	{
	}

	public ProcessStateCustom_NPCChangeLeisureAnim(ProcessStateCustom_NPCChangeLeisureAnim other)
		: this()
	{
		notifyActorGuid_ = other.notifyActorGuid_;
		changeLeisureAnimIndex_ = other.changeLeisureAnimIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_NPCChangeLeisureAnim Clone()
	{
		return new ProcessStateCustom_NPCChangeLeisureAnim(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_NPCChangeLeisureAnim);
	}

	public bool Equals(ProcessStateCustom_NPCChangeLeisureAnim other)
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
		if (ChangeLeisureAnimIndex != other.ChangeLeisureAnimIndex)
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
		if (ChangeLeisureAnimIndex != 0)
		{
			num ^= ChangeLeisureAnimIndex.GetHashCode();
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
		if (ChangeLeisureAnimIndex != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ChangeLeisureAnimIndex);
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
		if (ChangeLeisureAnimIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChangeLeisureAnimIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_NPCChangeLeisureAnim other)
	{
		if (other != null)
		{
			if (other.NotifyActorGuid.Length != 0)
			{
				NotifyActorGuid = other.NotifyActorGuid;
			}
			if (other.ChangeLeisureAnimIndex != 0)
			{
				ChangeLeisureAnimIndex = other.ChangeLeisureAnimIndex;
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
				ChangeLeisureAnimIndex = input.ReadInt32();
				break;
			}
		}
	}
}
