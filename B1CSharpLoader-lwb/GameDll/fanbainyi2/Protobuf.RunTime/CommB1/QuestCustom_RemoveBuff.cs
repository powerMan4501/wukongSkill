using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_RemoveBuff : IMessage<QuestCustom_RemoveBuff>, IMessage, IEquatable<QuestCustom_RemoveBuff>, IDeepCloneable<QuestCustom_RemoveBuff>
{
	private static readonly MessageParser<QuestCustom_RemoveBuff> _parser = new MessageParser<QuestCustom_RemoveBuff>(() => new QuestCustom_RemoveBuff());

	private UnknownFieldSet _unknownFields;

	private int buffId_;

	private int buffLayer_;

	private string unitGuid_ = "";

	public static MessageParser<QuestCustom_RemoveBuff> Parser => _parser;

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

	public QuestCustom_RemoveBuff()
	{
	}

	public QuestCustom_RemoveBuff(QuestCustom_RemoveBuff other)
		: this()
	{
		buffId_ = other.buffId_;
		buffLayer_ = other.buffLayer_;
		unitGuid_ = other.unitGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_RemoveBuff Clone()
	{
		return new QuestCustom_RemoveBuff(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_RemoveBuff);
	}

	public bool Equals(QuestCustom_RemoveBuff other)
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
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(26);
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

	public void MergeFrom(QuestCustom_RemoveBuff other)
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
			case 26u:
				UnitGuid = input.ReadString();
				break;
			}
		}
	}
}
