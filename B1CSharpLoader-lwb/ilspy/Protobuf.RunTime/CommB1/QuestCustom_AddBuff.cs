using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_AddBuff : IMessage<QuestCustom_AddBuff>, IMessage, IEquatable<QuestCustom_AddBuff>, IDeepCloneable<QuestCustom_AddBuff>
{
	private static readonly MessageParser<QuestCustom_AddBuff> _parser = new MessageParser<QuestCustom_AddBuff>(() => new QuestCustom_AddBuff());

	private UnknownFieldSet _unknownFields;

	private int buffId_;

	private int buffLayer_;

	private int buffDuration_;

	private string unitGuid_ = "";

	public static MessageParser<QuestCustom_AddBuff> Parser => _parser;

	public int BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	public int BuffLayer
	{
		get
		{
			return buffLayer_;
		}
		set
		{
			buffLayer_ = value;
		}
	}

	public int BuffDuration
	{
		get
		{
			return buffDuration_;
		}
		set
		{
			buffDuration_ = value;
		}
	}

	public string UnitGuid
	{
		get
		{
			return unitGuid_;
		}
		set
		{
			unitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public QuestCustom_AddBuff()
	{
	}

	public QuestCustom_AddBuff(QuestCustom_AddBuff other)
		: this()
	{
		buffId_ = other.buffId_;
		buffLayer_ = other.buffLayer_;
		buffDuration_ = other.buffDuration_;
		unitGuid_ = other.unitGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_AddBuff Clone()
	{
		return new QuestCustom_AddBuff(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_AddBuff);
	}

	public bool Equals(QuestCustom_AddBuff other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (BuffLayer != other.BuffLayer)
		{
			return false;
		}
		if (BuffDuration != other.BuffDuration)
		{
			return false;
		}
		if (UnitGuid != other.UnitGuid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (BuffLayer != 0)
		{
			num ^= BuffLayer.GetHashCode();
		}
		if (BuffDuration != 0)
		{
			num ^= BuffDuration.GetHashCode();
		}
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BuffId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BuffId);
		}
		if (BuffLayer != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuffLayer);
		}
		if (BuffDuration != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BuffDuration);
		}
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(UnitGuid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (BuffLayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffLayer);
		}
		if (BuffDuration != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffDuration);
		}
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_AddBuff other)
	{
		if (other != null)
		{
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.BuffLayer != 0)
			{
				BuffLayer = other.BuffLayer;
			}
			if (other.BuffDuration != 0)
			{
				BuffDuration = other.BuffDuration;
			}
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
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
				BuffId = input.ReadInt32();
				break;
			case 16u:
				BuffLayer = input.ReadInt32();
				break;
			case 24u:
				BuffDuration = input.ReadInt32();
				break;
			case 34u:
				UnitGuid = input.ReadString();
				break;
			}
		}
	}
}
