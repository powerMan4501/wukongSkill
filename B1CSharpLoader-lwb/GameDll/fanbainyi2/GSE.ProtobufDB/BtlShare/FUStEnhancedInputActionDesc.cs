using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStEnhancedInputActionDesc : IMessage<FUStEnhancedInputActionDesc>, IMessage, IEquatable<FUStEnhancedInputActionDesc>, IDeepCloneable<FUStEnhancedInputActionDesc>
{
	private static readonly MessageParser<FUStEnhancedInputActionDesc> _parser = new MessageParser<FUStEnhancedInputActionDesc>(() => new FUStEnhancedInputActionDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string actionName_ = "";

	private EEnhancedTriggerEvent enhancedTriggerEvent_;

	private int resID_;

	private EInputActionType inputActionType_;

	private static readonly FieldCodec<int> _repeated_inputActionParamsInt_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> inputActionParamsInt_ = new RepeatedField<int>();

	private string debugActionName_ = "";

	private int debugSortId_;

	private int isDebugInfoShow_;

	private int isDebugReleaseEvent_;

	private int isNotDebugPressNum_;

	public static MessageParser<FUStEnhancedInputActionDesc> Parser => _parser;

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

	public string ActionName
	{
		get
		{
			return actionName_;
		}
		set
		{
			actionName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EEnhancedTriggerEvent EnhancedTriggerEvent
	{
		get
		{
			return enhancedTriggerEvent_;
		}
		set
		{
			enhancedTriggerEvent_ = value;
		}
	}

	public int ResID
	{
		get
		{
			return resID_;
		}
		set
		{
			resID_ = value;
		}
	}

	public EInputActionType InputActionType
	{
		get
		{
			return inputActionType_;
		}
		set
		{
			inputActionType_ = value;
		}
	}

	public RepeatedField<int> InputActionParamsInt => inputActionParamsInt_;

	public string DebugActionName
	{
		get
		{
			return debugActionName_;
		}
		set
		{
			debugActionName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int DebugSortId
	{
		get
		{
			return debugSortId_;
		}
		set
		{
			debugSortId_ = value;
		}
	}

	public int IsDebugInfoShow
	{
		get
		{
			return isDebugInfoShow_;
		}
		set
		{
			isDebugInfoShow_ = value;
		}
	}

	public int IsDebugReleaseEvent
	{
		get
		{
			return isDebugReleaseEvent_;
		}
		set
		{
			isDebugReleaseEvent_ = value;
		}
	}

	public int IsNotDebugPressNum
	{
		get
		{
			return isNotDebugPressNum_;
		}
		set
		{
			isNotDebugPressNum_ = value;
		}
	}

	public FUStEnhancedInputActionDesc()
	{
	}

	public FUStEnhancedInputActionDesc(FUStEnhancedInputActionDesc other)
		: this()
	{
		iD_ = other.iD_;
		actionName_ = other.actionName_;
		enhancedTriggerEvent_ = other.enhancedTriggerEvent_;
		resID_ = other.resID_;
		inputActionType_ = other.inputActionType_;
		inputActionParamsInt_ = other.inputActionParamsInt_.Clone();
		debugActionName_ = other.debugActionName_;
		debugSortId_ = other.debugSortId_;
		isDebugInfoShow_ = other.isDebugInfoShow_;
		isDebugReleaseEvent_ = other.isDebugReleaseEvent_;
		isNotDebugPressNum_ = other.isNotDebugPressNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStEnhancedInputActionDesc Clone()
	{
		return new FUStEnhancedInputActionDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStEnhancedInputActionDesc);
	}

	public bool Equals(FUStEnhancedInputActionDesc other)
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
		if (ActionName != other.ActionName)
		{
			return false;
		}
		if (EnhancedTriggerEvent != other.EnhancedTriggerEvent)
		{
			return false;
		}
		if (ResID != other.ResID)
		{
			return false;
		}
		if (InputActionType != other.InputActionType)
		{
			return false;
		}
		if (!inputActionParamsInt_.Equals(other.inputActionParamsInt_))
		{
			return false;
		}
		if (DebugActionName != other.DebugActionName)
		{
			return false;
		}
		if (DebugSortId != other.DebugSortId)
		{
			return false;
		}
		if (IsDebugInfoShow != other.IsDebugInfoShow)
		{
			return false;
		}
		if (IsDebugReleaseEvent != other.IsDebugReleaseEvent)
		{
			return false;
		}
		if (IsNotDebugPressNum != other.IsNotDebugPressNum)
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
		if (ActionName.Length != 0)
		{
			num ^= ActionName.GetHashCode();
		}
		if (EnhancedTriggerEvent != EEnhancedTriggerEvent.None)
		{
			num ^= EnhancedTriggerEvent.GetHashCode();
		}
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (InputActionType != EInputActionType.None)
		{
			num ^= InputActionType.GetHashCode();
		}
		num ^= inputActionParamsInt_.GetHashCode();
		if (DebugActionName.Length != 0)
		{
			num ^= DebugActionName.GetHashCode();
		}
		if (DebugSortId != 0)
		{
			num ^= DebugSortId.GetHashCode();
		}
		if (IsDebugInfoShow != 0)
		{
			num ^= IsDebugInfoShow.GetHashCode();
		}
		if (IsDebugReleaseEvent != 0)
		{
			num ^= IsDebugReleaseEvent.GetHashCode();
		}
		if (IsNotDebugPressNum != 0)
		{
			num ^= IsNotDebugPressNum.GetHashCode();
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
		if (ActionName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ActionName);
		}
		if (EnhancedTriggerEvent != EEnhancedTriggerEvent.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)EnhancedTriggerEvent);
		}
		if (ResID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ResID);
		}
		if (InputActionType != EInputActionType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)InputActionType);
		}
		inputActionParamsInt_.WriteTo(output, _repeated_inputActionParamsInt_codec);
		if (DebugActionName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(DebugActionName);
		}
		if (DebugSortId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(DebugSortId);
		}
		if (IsDebugInfoShow != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(IsDebugInfoShow);
		}
		if (IsDebugReleaseEvent != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(IsDebugReleaseEvent);
		}
		if (IsNotDebugPressNum != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(IsNotDebugPressNum);
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
		if (ActionName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ActionName);
		}
		if (EnhancedTriggerEvent != EEnhancedTriggerEvent.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EnhancedTriggerEvent);
		}
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (InputActionType != EInputActionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)InputActionType);
		}
		num += inputActionParamsInt_.CalculateSize(_repeated_inputActionParamsInt_codec);
		if (DebugActionName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DebugActionName);
		}
		if (DebugSortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DebugSortId);
		}
		if (IsDebugInfoShow != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsDebugInfoShow);
		}
		if (IsDebugReleaseEvent != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsDebugReleaseEvent);
		}
		if (IsNotDebugPressNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsNotDebugPressNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStEnhancedInputActionDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ActionName.Length != 0)
			{
				ActionName = other.ActionName;
			}
			if (other.EnhancedTriggerEvent != EEnhancedTriggerEvent.None)
			{
				EnhancedTriggerEvent = other.EnhancedTriggerEvent;
			}
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.InputActionType != EInputActionType.None)
			{
				InputActionType = other.InputActionType;
			}
			inputActionParamsInt_.Add(other.inputActionParamsInt_);
			if (other.DebugActionName.Length != 0)
			{
				DebugActionName = other.DebugActionName;
			}
			if (other.DebugSortId != 0)
			{
				DebugSortId = other.DebugSortId;
			}
			if (other.IsDebugInfoShow != 0)
			{
				IsDebugInfoShow = other.IsDebugInfoShow;
			}
			if (other.IsDebugReleaseEvent != 0)
			{
				IsDebugReleaseEvent = other.IsDebugReleaseEvent;
			}
			if (other.IsNotDebugPressNum != 0)
			{
				IsNotDebugPressNum = other.IsNotDebugPressNum;
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
			case 18u:
				ActionName = input.ReadString();
				break;
			case 24u:
				EnhancedTriggerEvent = (EEnhancedTriggerEvent)input.ReadEnum();
				break;
			case 32u:
				ResID = input.ReadInt32();
				break;
			case 40u:
				InputActionType = (EInputActionType)input.ReadEnum();
				break;
			case 48u:
			case 50u:
				inputActionParamsInt_.AddEntriesFrom(input, _repeated_inputActionParamsInt_codec);
				break;
			case 58u:
				DebugActionName = input.ReadString();
				break;
			case 64u:
				DebugSortId = input.ReadInt32();
				break;
			case 72u:
				IsDebugInfoShow = input.ReadInt32();
				break;
			case 80u:
				IsDebugReleaseEvent = input.ReadInt32();
				break;
			case 88u:
				IsNotDebugPressNum = input.ReadInt32();
				break;
			}
		}
	}
}
