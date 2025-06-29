using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStGuideGroupDesc : IMessage<FUStGuideGroupDesc>, IMessage, IEquatable<FUStGuideGroupDesc>, IDeepCloneable<FUStGuideGroupDesc>
{
	private static readonly MessageParser<FUStGuideGroupDesc> _parser = new MessageParser<FUStGuideGroupDesc>(() => new FUStGuideGroupDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGuideGroupType guideGroupType_;

	private static readonly FieldCodec<int> _repeated_guideId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> guideId_ = new RepeatedField<int>();

	private EGuideGroupFinishType finishType_;

	private int finishParam_;

	private EGuideType guideType_;

	private EGSYesNo isCollected_;

	private EGSYesNo isShowHud_;

	private int sortId_;

	public static MessageParser<FUStGuideGroupDesc> Parser => _parser;

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

	public EGuideGroupType GuideGroupType
	{
		get
		{
			return guideGroupType_;
		}
		set
		{
			guideGroupType_ = value;
		}
	}

	public RepeatedField<int> GuideId => guideId_;

	public EGuideGroupFinishType FinishType
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

	public int FinishParam
	{
		get
		{
			return finishParam_;
		}
		set
		{
			finishParam_ = value;
		}
	}

	public EGuideType GuideType
	{
		get
		{
			return guideType_;
		}
		set
		{
			guideType_ = value;
		}
	}

	public EGSYesNo IsCollected
	{
		get
		{
			return isCollected_;
		}
		set
		{
			isCollected_ = value;
		}
	}

	public EGSYesNo IsShowHud
	{
		get
		{
			return isShowHud_;
		}
		set
		{
			isShowHud_ = value;
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

	public FUStGuideGroupDesc()
	{
	}

	public FUStGuideGroupDesc(FUStGuideGroupDesc other)
		: this()
	{
		iD_ = other.iD_;
		guideGroupType_ = other.guideGroupType_;
		guideId_ = other.guideId_.Clone();
		finishType_ = other.finishType_;
		finishParam_ = other.finishParam_;
		guideType_ = other.guideType_;
		isCollected_ = other.isCollected_;
		isShowHud_ = other.isShowHud_;
		sortId_ = other.sortId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStGuideGroupDesc Clone()
	{
		return new FUStGuideGroupDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStGuideGroupDesc);
	}

	public bool Equals(FUStGuideGroupDesc other)
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
		if (GuideGroupType != other.GuideGroupType)
		{
			return false;
		}
		if (!guideId_.Equals(other.guideId_))
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
		if (GuideType != other.GuideType)
		{
			return false;
		}
		if (IsCollected != other.IsCollected)
		{
			return false;
		}
		if (IsShowHud != other.IsShowHud)
		{
			return false;
		}
		if (SortId != other.SortId)
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
		if (GuideGroupType != EGuideGroupType.Normal)
		{
			num ^= GuideGroupType.GetHashCode();
		}
		num ^= guideId_.GetHashCode();
		if (FinishType != EGuideGroupFinishType.Confirm)
		{
			num ^= FinishType.GetHashCode();
		}
		if (FinishParam != 0)
		{
			num ^= FinishParam.GetHashCode();
		}
		if (GuideType != EGuideType.Battle)
		{
			num ^= GuideType.GetHashCode();
		}
		if (IsCollected != EGSYesNo.No)
		{
			num ^= IsCollected.GetHashCode();
		}
		if (IsShowHud != EGSYesNo.No)
		{
			num ^= IsShowHud.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
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
		if (GuideGroupType != EGuideGroupType.Normal)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)GuideGroupType);
		}
		guideId_.WriteTo(output, _repeated_guideId_codec);
		if (FinishType != EGuideGroupFinishType.Confirm)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)FinishType);
		}
		if (FinishParam != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(FinishParam);
		}
		if (GuideType != EGuideType.Battle)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)GuideType);
		}
		if (IsCollected != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)IsCollected);
		}
		if (IsShowHud != EGSYesNo.No)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)IsShowHud);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(SortId);
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
		if (GuideGroupType != EGuideGroupType.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GuideGroupType);
		}
		num += guideId_.CalculateSize(_repeated_guideId_codec);
		if (FinishType != EGuideGroupFinishType.Confirm)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FinishType);
		}
		if (FinishParam != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FinishParam);
		}
		if (GuideType != EGuideType.Battle)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GuideType);
		}
		if (IsCollected != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsCollected);
		}
		if (IsShowHud != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsShowHud);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStGuideGroupDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.GuideGroupType != EGuideGroupType.Normal)
			{
				GuideGroupType = other.GuideGroupType;
			}
			guideId_.Add(other.guideId_);
			if (other.FinishType != EGuideGroupFinishType.Confirm)
			{
				FinishType = other.FinishType;
			}
			if (other.FinishParam != 0)
			{
				FinishParam = other.FinishParam;
			}
			if (other.GuideType != EGuideType.Battle)
			{
				GuideType = other.GuideType;
			}
			if (other.IsCollected != EGSYesNo.No)
			{
				IsCollected = other.IsCollected;
			}
			if (other.IsShowHud != EGSYesNo.No)
			{
				IsShowHud = other.IsShowHud;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
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
				GuideGroupType = (EGuideGroupType)input.ReadEnum();
				break;
			case 24u:
			case 26u:
				guideId_.AddEntriesFrom(input, _repeated_guideId_codec);
				break;
			case 32u:
				FinishType = (EGuideGroupFinishType)input.ReadEnum();
				break;
			case 40u:
				FinishParam = input.ReadInt32();
				break;
			case 48u:
				GuideType = (EGuideType)input.ReadEnum();
				break;
			case 56u:
				IsCollected = (EGSYesNo)input.ReadEnum();
				break;
			case 64u:
				IsShowHud = (EGSYesNo)input.ReadEnum();
				break;
			case 72u:
				SortId = input.ReadInt32();
				break;
			}
		}
	}
}
