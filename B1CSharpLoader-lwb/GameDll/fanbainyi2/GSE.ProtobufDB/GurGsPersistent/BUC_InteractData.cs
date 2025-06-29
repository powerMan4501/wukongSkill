using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class BUC_InteractData : IMessage<BUC_InteractData>, IMessage, IEquatable<BUC_InteractData>, IDeepCloneable<BUC_InteractData>
{
	private static readonly MessageParser<BUC_InteractData> _parser = new MessageParser<BUC_InteractData>(() => new BUC_InteractData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int interactUnitStatePersistent_;

	private int actionGroupIDPersistent_;

	public static MessageParser<BUC_InteractData> Parser => _parser;

	public int InteractUnitStatePersistent
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return interactUnitStatePersistent_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			interactUnitStatePersistent_ = value;
		}
	}

	public bool HasInteractUnitStatePersistent => (_hasBits0 & 1) != 0;

	public int ActionGroupIDPersistent
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return actionGroupIDPersistent_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			actionGroupIDPersistent_ = value;
		}
	}

	public bool HasActionGroupIDPersistent => (_hasBits0 & 2) != 0;

	public BUC_InteractData()
	{
	}

	public BUC_InteractData(BUC_InteractData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		interactUnitStatePersistent_ = other.interactUnitStatePersistent_;
		actionGroupIDPersistent_ = other.actionGroupIDPersistent_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BUC_InteractData Clone()
	{
		return new BUC_InteractData(this);
	}

	public void ClearInteractUnitStatePersistent()
	{
		_hasBits0 &= -2;
	}

	public void ClearActionGroupIDPersistent()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BUC_InteractData);
	}

	public bool Equals(BUC_InteractData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InteractUnitStatePersistent != other.InteractUnitStatePersistent)
		{
			return false;
		}
		if (ActionGroupIDPersistent != other.ActionGroupIDPersistent)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasInteractUnitStatePersistent)
		{
			num ^= InteractUnitStatePersistent.GetHashCode();
		}
		if (HasActionGroupIDPersistent)
		{
			num ^= ActionGroupIDPersistent.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasInteractUnitStatePersistent)
		{
			output.WriteRawTag(8);
			output.WriteInt32(InteractUnitStatePersistent);
		}
		if (HasActionGroupIDPersistent)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ActionGroupIDPersistent);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasInteractUnitStatePersistent)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractUnitStatePersistent);
		}
		if (HasActionGroupIDPersistent)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ActionGroupIDPersistent);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BUC_InteractData other)
	{
		if (other != null)
		{
			if (other.HasInteractUnitStatePersistent)
			{
				InteractUnitStatePersistent = other.InteractUnitStatePersistent;
			}
			if (other.HasActionGroupIDPersistent)
			{
				ActionGroupIDPersistent = other.ActionGroupIDPersistent;
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
				InteractUnitStatePersistent = input.ReadInt32();
				break;
			case 16u:
				ActionGroupIDPersistent = input.ReadInt32();
				break;
			}
		}
	}
}
