using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStGuideNodeDesc : IMessage<FUStGuideNodeDesc>, IMessage, IEquatable<FUStGuideNodeDesc>, IDeepCloneable<FUStGuideNodeDesc>
{
	private static readonly MessageParser<FUStGuideNodeDesc> _parser = new MessageParser<FUStGuideNodeDesc>(() => new FUStGuideNodeDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int sortId_;

	private string guideTitle_ = "";

	private string guideDesc_ = "";

	private EGuideNodeFinishType finishType_;

	private string finishParam_ = "";

	private string inputAction_ = "";

	private static readonly FieldCodec<GuideInputAction> _repeated_inputActionTips_codec = FieldCodec.ForMessage(66u, GuideInputAction.Parser);

	private readonly RepeatedField<GuideInputAction> inputActionTips_ = new RepeatedField<GuideInputAction>();

	private int localizationTag_;

	public static MessageParser<FUStGuideNodeDesc> Parser => _parser;

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

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public string GuideTitle
	{
		get
		{
			return guideTitle_;
		}
		set
		{
			guideTitle_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string GuideDesc
	{
		get
		{
			return guideDesc_;
		}
		set
		{
			guideDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGuideNodeFinishType FinishType
	{
		get
		{
			return finishType_;
		}
		set
		{
			finishType_ = value;
		}
	}

	public string FinishParam
	{
		get
		{
			return finishParam_;
		}
		set
		{
			finishParam_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string InputAction
	{
		get
		{
			return inputAction_;
		}
		set
		{
			inputAction_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<GuideInputAction> InputActionTips => inputActionTips_;

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public FUStGuideNodeDesc()
	{
	}

	public FUStGuideNodeDesc(FUStGuideNodeDesc other)
		: this()
	{
		iD_ = other.iD_;
		sortId_ = other.sortId_;
		guideTitle_ = other.guideTitle_;
		guideDesc_ = other.guideDesc_;
		finishType_ = other.finishType_;
		finishParam_ = other.finishParam_;
		inputAction_ = other.inputAction_;
		inputActionTips_ = other.inputActionTips_.Clone();
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStGuideNodeDesc Clone()
	{
		return new FUStGuideNodeDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStGuideNodeDesc);
	}

	public bool Equals(FUStGuideNodeDesc other)
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
		if (SortId != other.SortId)
		{
			return false;
		}
		if (GuideTitle != other.GuideTitle)
		{
			return false;
		}
		if (GuideDesc != other.GuideDesc)
		{
			return false;
		}
		if (FinishType != other.FinishType)
		{
			return false;
		}
		if (FinishParam != other.FinishParam)
		{
			return false;
		}
		if (InputAction != other.InputAction)
		{
			return false;
		}
		if (!inputActionTips_.Equals(other.inputActionTips_))
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
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
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (GuideTitle.Length != 0)
		{
			num ^= GuideTitle.GetHashCode();
		}
		if (GuideDesc.Length != 0)
		{
			num ^= GuideDesc.GetHashCode();
		}
		if (FinishType != EGuideNodeFinishType.None)
		{
			num ^= FinishType.GetHashCode();
		}
		if (FinishParam.Length != 0)
		{
			num ^= FinishParam.GetHashCode();
		}
		if (InputAction.Length != 0)
		{
			num ^= InputAction.GetHashCode();
		}
		num ^= inputActionTips_.GetHashCode();
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
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
		if (SortId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SortId);
		}
		if (GuideTitle.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(GuideTitle);
		}
		if (GuideDesc.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(GuideDesc);
		}
		if (FinishType != EGuideNodeFinishType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)FinishType);
		}
		if (FinishParam.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(FinishParam);
		}
		if (InputAction.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(InputAction);
		}
		inputActionTips_.WriteTo(output, _repeated_inputActionTips_codec);
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(LocalizationTag);
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
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (GuideTitle.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GuideTitle);
		}
		if (GuideDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GuideDesc);
		}
		if (FinishType != EGuideNodeFinishType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FinishType);
		}
		if (FinishParam.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FinishParam);
		}
		if (InputAction.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(InputAction);
		}
		num += inputActionTips_.CalculateSize(_repeated_inputActionTips_codec);
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStGuideNodeDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.GuideTitle.Length != 0)
			{
				GuideTitle = other.GuideTitle;
			}
			if (other.GuideDesc.Length != 0)
			{
				GuideDesc = other.GuideDesc;
			}
			if (other.FinishType != EGuideNodeFinishType.None)
			{
				FinishType = other.FinishType;
			}
			if (other.FinishParam.Length != 0)
			{
				FinishParam = other.FinishParam;
			}
			if (other.InputAction.Length != 0)
			{
				InputAction = other.InputAction;
			}
			inputActionTips_.Add(other.inputActionTips_);
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
				SortId = input.ReadInt32();
				break;
			case 26u:
				GuideTitle = input.ReadString();
				break;
			case 34u:
				GuideDesc = input.ReadString();
				break;
			case 40u:
				FinishType = (EGuideNodeFinishType)input.ReadEnum();
				break;
			case 50u:
				FinishParam = input.ReadString();
				break;
			case 58u:
				InputAction = input.ReadString();
				break;
			case 66u:
				inputActionTips_.AddEntriesFrom(input, _repeated_inputActionTips_codec);
				break;
			case 72u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
