using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_NPCShow : IMessage<ProcessStateCustom_NPCShow>, IMessage, IEquatable<ProcessStateCustom_NPCShow>, IDeepCloneable<ProcessStateCustom_NPCShow>
{
	private static readonly MessageParser<ProcessStateCustom_NPCShow> _parser = new MessageParser<ProcessStateCustom_NPCShow>(() => new ProcessStateCustom_NPCShow());

	private UnknownFieldSet _unknownFields;

	private string notifyActorGuid_ = "";

	private bool npcIsShow_;

	public static MessageParser<ProcessStateCustom_NPCShow> Parser => _parser;

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

	public bool NpcIsShow
	{
		get
		{
			return npcIsShow_;
		}
		set
		{
			npcIsShow_ = value;
		}
	}

	public ProcessStateCustom_NPCShow()
	{
	}

	public ProcessStateCustom_NPCShow(ProcessStateCustom_NPCShow other)
		: this()
	{
		notifyActorGuid_ = other.notifyActorGuid_;
		npcIsShow_ = other.npcIsShow_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_NPCShow Clone()
	{
		return new ProcessStateCustom_NPCShow(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_NPCShow);
	}

	public bool Equals(ProcessStateCustom_NPCShow other)
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
		if (NpcIsShow != other.NpcIsShow)
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
		if (NpcIsShow)
		{
			num ^= NpcIsShow.GetHashCode();
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
		if (NpcIsShow)
		{
			output.WriteRawTag(16);
			output.WriteBool(NpcIsShow);
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
		if (NpcIsShow)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_NPCShow other)
	{
		if (other != null)
		{
			if (other.NotifyActorGuid.Length != 0)
			{
				NotifyActorGuid = other.NotifyActorGuid;
			}
			if (other.NpcIsShow)
			{
				NpcIsShow = other.NpcIsShow;
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
				NpcIsShow = input.ReadBool();
				break;
			}
		}
	}
}
