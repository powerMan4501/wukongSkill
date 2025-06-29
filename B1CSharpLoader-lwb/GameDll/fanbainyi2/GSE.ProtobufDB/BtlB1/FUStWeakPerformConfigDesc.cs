using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStWeakPerformConfigDesc : IMessage<FUStWeakPerformConfigDesc>, IMessage, IEquatable<FUStWeakPerformConfigDesc>, IDeepCloneable<FUStWeakPerformConfigDesc>
{
	private static readonly MessageParser<FUStWeakPerformConfigDesc> _parser = new MessageParser<FUStWeakPerformConfigDesc>(() => new FUStWeakPerformConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGSYesNo isDisableXAxisMove_;

	private EGSYesNo isDisableMoveBack_;

	private EGSYesNo isDisableInteract_;

	private EPerformLockType lockType_;

	private string lockTargetTag_ = "";

	private float exitDelayTime_;

	private float durationTime_;

	public static MessageParser<FUStWeakPerformConfigDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public EGSYesNo IsDisableXAxisMove
	{
		get
		{
			return isDisableXAxisMove_;
		}
		set
		{
			isDisableXAxisMove_ = value;
		}
	}

	public EGSYesNo IsDisableMoveBack
	{
		get
		{
			return isDisableMoveBack_;
		}
		set
		{
			isDisableMoveBack_ = value;
		}
	}

	public EGSYesNo IsDisableInteract
	{
		get
		{
			return isDisableInteract_;
		}
		set
		{
			isDisableInteract_ = value;
		}
	}

	public EPerformLockType LockType
	{
		get
		{
			return lockType_;
		}
		set
		{
			lockType_ = value;
		}
	}

	public string LockTargetTag
	{
		get
		{
			return lockTargetTag_;
		}
		set
		{
			lockTargetTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float ExitDelayTime
	{
		get
		{
			return exitDelayTime_;
		}
		set
		{
			exitDelayTime_ = value;
		}
	}

	public float DurationTime
	{
		get
		{
			return durationTime_;
		}
		set
		{
			durationTime_ = value;
		}
	}

	public FUStWeakPerformConfigDesc()
	{
	}

	public FUStWeakPerformConfigDesc(FUStWeakPerformConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		isDisableXAxisMove_ = other.isDisableXAxisMove_;
		isDisableMoveBack_ = other.isDisableMoveBack_;
		isDisableInteract_ = other.isDisableInteract_;
		lockType_ = other.lockType_;
		lockTargetTag_ = other.lockTargetTag_;
		exitDelayTime_ = other.exitDelayTime_;
		durationTime_ = other.durationTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStWeakPerformConfigDesc Clone()
	{
		return new FUStWeakPerformConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStWeakPerformConfigDesc);
	}

	public bool Equals(FUStWeakPerformConfigDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (IsDisableXAxisMove != other.IsDisableXAxisMove)
		{
			return false;
		}
		if (IsDisableMoveBack != other.IsDisableMoveBack)
		{
			return false;
		}
		if (IsDisableInteract != other.IsDisableInteract)
		{
			return false;
		}
		if (LockType != other.LockType)
		{
			return false;
		}
		if (LockTargetTag != other.LockTargetTag)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExitDelayTime, other.ExitDelayTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DurationTime, other.DurationTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (IsDisableXAxisMove != EGSYesNo.No)
		{
			num ^= IsDisableXAxisMove.GetHashCode();
		}
		if (IsDisableMoveBack != EGSYesNo.No)
		{
			num ^= IsDisableMoveBack.GetHashCode();
		}
		if (IsDisableInteract != EGSYesNo.No)
		{
			num ^= IsDisableInteract.GetHashCode();
		}
		if (LockType != EPerformLockType.None)
		{
			num ^= LockType.GetHashCode();
		}
		if (LockTargetTag.Length != 0)
		{
			num ^= LockTargetTag.GetHashCode();
		}
		if (ExitDelayTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExitDelayTime);
		}
		if (DurationTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DurationTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (IsDisableXAxisMove != EGSYesNo.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IsDisableXAxisMove);
		}
		if (IsDisableMoveBack != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)IsDisableMoveBack);
		}
		if (IsDisableInteract != EGSYesNo.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)IsDisableInteract);
		}
		if (LockType != EPerformLockType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)LockType);
		}
		if (LockTargetTag.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(LockTargetTag);
		}
		if (ExitDelayTime != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(ExitDelayTime);
		}
		if (DurationTime != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(DurationTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (IsDisableXAxisMove != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsDisableXAxisMove);
		}
		if (IsDisableMoveBack != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsDisableMoveBack);
		}
		if (IsDisableInteract != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsDisableInteract);
		}
		if (LockType != EPerformLockType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LockType);
		}
		if (LockTargetTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LockTargetTag);
		}
		if (ExitDelayTime != 0f)
		{
			num += 5;
		}
		if (DurationTime != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStWeakPerformConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.IsDisableXAxisMove != EGSYesNo.No)
			{
				IsDisableXAxisMove = other.IsDisableXAxisMove;
			}
			if (other.IsDisableMoveBack != EGSYesNo.No)
			{
				IsDisableMoveBack = other.IsDisableMoveBack;
			}
			if (other.IsDisableInteract != EGSYesNo.No)
			{
				IsDisableInteract = other.IsDisableInteract;
			}
			if (other.LockType != EPerformLockType.None)
			{
				LockType = other.LockType;
			}
			if (other.LockTargetTag.Length != 0)
			{
				LockTargetTag = other.LockTargetTag;
			}
			if (other.ExitDelayTime != 0f)
			{
				ExitDelayTime = other.ExitDelayTime;
			}
			if (other.DurationTime != 0f)
			{
				DurationTime = other.DurationTime;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				IsDisableXAxisMove = (EGSYesNo)input.ReadEnum();
				break;
			case 24u:
				IsDisableMoveBack = (EGSYesNo)input.ReadEnum();
				break;
			case 32u:
				IsDisableInteract = (EGSYesNo)input.ReadEnum();
				break;
			case 40u:
				LockType = (EPerformLockType)input.ReadEnum();
				break;
			case 50u:
				LockTargetTag = input.ReadString();
				break;
			case 61u:
				ExitDelayTime = input.ReadFloat();
				break;
			case 69u:
				DurationTime = input.ReadFloat();
				break;
			}
		}
	}
}
