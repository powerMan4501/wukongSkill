using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_UpdateInteractGroup : IMessage<ProcessStateCustom_UpdateInteractGroup>, IMessage, IEquatable<ProcessStateCustom_UpdateInteractGroup>, IDeepCloneable<ProcessStateCustom_UpdateInteractGroup>
{
	private static readonly MessageParser<ProcessStateCustom_UpdateInteractGroup> _parser = new MessageParser<ProcessStateCustom_UpdateInteractGroup>(() => new ProcessStateCustom_UpdateInteractGroup());

	private UnknownFieldSet _unknownFields;

	private string unitGuid_ = "";

	private int interactGroupId_;

	public static MessageParser<ProcessStateCustom_UpdateInteractGroup> Parser => _parser;

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

	public int InteractGroupId
	{
		get
		{
			return interactGroupId_;
		}
		set
		{
			interactGroupId_ = value;
		}
	}

	public ProcessStateCustom_UpdateInteractGroup()
	{
	}

	public ProcessStateCustom_UpdateInteractGroup(ProcessStateCustom_UpdateInteractGroup other)
		: this()
	{
		unitGuid_ = other.unitGuid_;
		interactGroupId_ = other.interactGroupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_UpdateInteractGroup Clone()
	{
		return new ProcessStateCustom_UpdateInteractGroup(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_UpdateInteractGroup);
	}

	public bool Equals(ProcessStateCustom_UpdateInteractGroup other)
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
		if (InteractGroupId != other.InteractGroupId)
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
		if (InteractGroupId != 0)
		{
			num ^= InteractGroupId.GetHashCode();
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
		if (InteractGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(InteractGroupId);
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
		if (InteractGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractGroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_UpdateInteractGroup other)
	{
		if (other != null)
		{
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.InteractGroupId != 0)
			{
				InteractGroupId = other.InteractGroupId;
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
				InteractGroupId = input.ReadInt32();
				break;
			}
		}
	}
}
