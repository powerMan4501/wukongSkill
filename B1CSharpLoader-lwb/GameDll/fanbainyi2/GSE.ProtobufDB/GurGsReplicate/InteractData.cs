using System;
using Google.Protobuf;

namespace GurGsReplicate;

public sealed class InteractData : IMessage<InteractData>, IMessage, IEquatable<InteractData>, IDeepCloneable<InteractData>
{
	private static readonly MessageParser<InteractData> _parser = new MessageParser<InteractData>(() => new InteractData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int interactUnitState_;

	private int interactConstraint_;

	public static MessageParser<InteractData> Parser => _parser;

	public int InteractUnitState
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return interactUnitState_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			interactUnitState_ = value;
		}
	}

	public bool HasInteractUnitState => (_hasBits0 & 1) != 0;

	public int InteractConstraint
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return interactConstraint_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			interactConstraint_ = value;
		}
	}

	public bool HasInteractConstraint => (_hasBits0 & 2) != 0;

	public InteractData()
	{
	}

	public InteractData(InteractData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		interactUnitState_ = other.interactUnitState_;
		interactConstraint_ = other.interactConstraint_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public InteractData Clone()
	{
		return new InteractData(this);
	}

	public void ClearInteractUnitState()
	{
		_hasBits0 &= -2;
	}

	public void ClearInteractConstraint()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as InteractData);
	}

	public bool Equals(InteractData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InteractUnitState != other.InteractUnitState)
		{
			return false;
		}
		if (InteractConstraint != other.InteractConstraint)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasInteractUnitState)
		{
			num ^= InteractUnitState.GetHashCode();
		}
		if (HasInteractConstraint)
		{
			num ^= InteractConstraint.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasInteractUnitState)
		{
			output.WriteRawTag(8);
			output.WriteInt32(InteractUnitState);
		}
		if (HasInteractConstraint)
		{
			output.WriteRawTag(16);
			output.WriteInt32(InteractConstraint);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasInteractUnitState)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractUnitState);
		}
		if (HasInteractConstraint)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractConstraint);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(InteractData other)
	{
		if (other != null)
		{
			if (other.HasInteractUnitState)
			{
				InteractUnitState = other.InteractUnitState;
			}
			if (other.HasInteractConstraint)
			{
				InteractConstraint = other.InteractConstraint;
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
				InteractUnitState = input.ReadInt32();
				break;
			case 16u:
				InteractConstraint = input.ReadInt32();
				break;
			}
		}
	}
}
