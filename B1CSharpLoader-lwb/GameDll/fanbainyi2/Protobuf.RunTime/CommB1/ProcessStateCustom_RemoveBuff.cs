using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_RemoveBuff : IMessage<ProcessStateCustom_RemoveBuff>, IMessage, IEquatable<ProcessStateCustom_RemoveBuff>, IDeepCloneable<ProcessStateCustom_RemoveBuff>
{
	private static readonly MessageParser<ProcessStateCustom_RemoveBuff> _parser = new MessageParser<ProcessStateCustom_RemoveBuff>(() => new ProcessStateCustom_RemoveBuff());

	private UnknownFieldSet _unknownFields;

	private string unitGuid_ = "";

	private int buffId_;

	private int buffLayer_;

	private bool isTriggerRemoveEffect_;

	public static MessageParser<ProcessStateCustom_RemoveBuff> Parser => _parser;

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

	public bool IsTriggerRemoveEffect
	{
		get
		{
			return isTriggerRemoveEffect_;
		}
		set
		{
			isTriggerRemoveEffect_ = value;
		}
	}

	public ProcessStateCustom_RemoveBuff()
	{
	}

	public ProcessStateCustom_RemoveBuff(ProcessStateCustom_RemoveBuff other)
		: this()
	{
		unitGuid_ = other.unitGuid_;
		buffId_ = other.buffId_;
		buffLayer_ = other.buffLayer_;
		isTriggerRemoveEffect_ = other.isTriggerRemoveEffect_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_RemoveBuff Clone()
	{
		return new ProcessStateCustom_RemoveBuff(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_RemoveBuff);
	}

	public bool Equals(ProcessStateCustom_RemoveBuff other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitGuid != other.UnitGuid)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (BuffLayer != other.BuffLayer)
		{
			return false;
		}
		if (IsTriggerRemoveEffect != other.IsTriggerRemoveEffect)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (BuffLayer != 0)
		{
			num ^= BuffLayer.GetHashCode();
		}
		if (IsTriggerRemoveEffect)
		{
			num ^= IsTriggerRemoveEffect.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(UnitGuid);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuffId);
		}
		if (BuffLayer != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BuffLayer);
		}
		if (IsTriggerRemoveEffect)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsTriggerRemoveEffect);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (BuffLayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffLayer);
		}
		if (IsTriggerRemoveEffect)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_RemoveBuff other)
	{
		if (other != null)
		{
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.BuffLayer != 0)
			{
				BuffLayer = other.BuffLayer;
			}
			if (other.IsTriggerRemoveEffect)
			{
				IsTriggerRemoveEffect = other.IsTriggerRemoveEffect;
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
				UnitGuid = input.ReadString();
				break;
			case 16u:
				BuffId = input.ReadInt32();
				break;
			case 24u:
				BuffLayer = input.ReadInt32();
				break;
			case 32u:
				IsTriggerRemoveEffect = input.ReadBool();
				break;
			}
		}
	}
}
