using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStDialogueDesc : IMessage<FUStDialogueDesc>, IMessage, IEquatable<FUStDialogueDesc>, IDeepCloneable<FUStDialogueDesc>
{
	private static readonly MessageParser<FUStDialogueDesc> _parser = new MessageParser<FUStDialogueDesc>(() => new FUStDialogueDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string name_ = "";

	private string content_ = "";

	private int localizationTag_;

	private EGSYesNo isSupportSoundDirection_;

	private int resID_;

	private string facialAnimPath_ = "";

	private float facialAnimTimeOffset_;

	private float facialAnimAutoBlendOutTime_;

	private EGSYesNo isSupportSkip_;

	public static MessageParser<FUStDialogueDesc> Parser => _parser;

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

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Content
	{
		get
		{
			return content_;
		}
		set
		{
			content_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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

	public EGSYesNo IsSupportSoundDirection
	{
		get
		{
			return isSupportSoundDirection_;
		}
		set
		{
			isSupportSoundDirection_ = value;
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

	public string FacialAnimPath
	{
		get
		{
			return facialAnimPath_;
		}
		set
		{
			facialAnimPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float FacialAnimTimeOffset
	{
		get
		{
			return facialAnimTimeOffset_;
		}
		set
		{
			facialAnimTimeOffset_ = value;
		}
	}

	public float FacialAnimAutoBlendOutTime
	{
		get
		{
			return facialAnimAutoBlendOutTime_;
		}
		set
		{
			facialAnimAutoBlendOutTime_ = value;
		}
	}

	public EGSYesNo IsSupportSkip
	{
		get
		{
			return isSupportSkip_;
		}
		set
		{
			isSupportSkip_ = value;
		}
	}

	public FUStDialogueDesc()
	{
	}

	public FUStDialogueDesc(FUStDialogueDesc other)
		: this()
	{
		iD_ = other.iD_;
		name_ = other.name_;
		content_ = other.content_;
		localizationTag_ = other.localizationTag_;
		isSupportSoundDirection_ = other.isSupportSoundDirection_;
		resID_ = other.resID_;
		facialAnimPath_ = other.facialAnimPath_;
		facialAnimTimeOffset_ = other.facialAnimTimeOffset_;
		facialAnimAutoBlendOutTime_ = other.facialAnimAutoBlendOutTime_;
		isSupportSkip_ = other.isSupportSkip_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStDialogueDesc Clone()
	{
		return new FUStDialogueDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStDialogueDesc);
	}

	public bool Equals(FUStDialogueDesc other)
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
		if (Name != other.Name)
		{
			return false;
		}
		if (Content != other.Content)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (IsSupportSoundDirection != other.IsSupportSoundDirection)
		{
			return false;
		}
		if (ResID != other.ResID)
		{
			return false;
		}
		if (FacialAnimPath != other.FacialAnimPath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FacialAnimTimeOffset, other.FacialAnimTimeOffset))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FacialAnimAutoBlendOutTime, other.FacialAnimAutoBlendOutTime))
		{
			return false;
		}
		if (IsSupportSkip != other.IsSupportSkip)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Content.Length != 0)
		{
			num ^= Content.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (IsSupportSoundDirection != EGSYesNo.No)
		{
			num ^= IsSupportSoundDirection.GetHashCode();
		}
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (FacialAnimPath.Length != 0)
		{
			num ^= FacialAnimPath.GetHashCode();
		}
		if (FacialAnimTimeOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FacialAnimTimeOffset);
		}
		if (FacialAnimAutoBlendOutTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FacialAnimAutoBlendOutTime);
		}
		if (IsSupportSkip != EGSYesNo.No)
		{
			num ^= IsSupportSkip.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (Content.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Content);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LocalizationTag);
		}
		if (IsSupportSoundDirection != EGSYesNo.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)IsSupportSoundDirection);
		}
		if (ResID != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ResID);
		}
		if (FacialAnimPath.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(FacialAnimPath);
		}
		if (FacialAnimTimeOffset != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(FacialAnimTimeOffset);
		}
		if (FacialAnimAutoBlendOutTime != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(FacialAnimAutoBlendOutTime);
		}
		if (IsSupportSkip != EGSYesNo.No)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)IsSupportSkip);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Content.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Content);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (IsSupportSoundDirection != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsSupportSoundDirection);
		}
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (FacialAnimPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FacialAnimPath);
		}
		if (FacialAnimTimeOffset != 0f)
		{
			num += 5;
		}
		if (FacialAnimAutoBlendOutTime != 0f)
		{
			num += 5;
		}
		if (IsSupportSkip != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsSupportSkip);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStDialogueDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Content.Length != 0)
			{
				Content = other.Content;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.IsSupportSoundDirection != EGSYesNo.No)
			{
				IsSupportSoundDirection = other.IsSupportSoundDirection;
			}
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.FacialAnimPath.Length != 0)
			{
				FacialAnimPath = other.FacialAnimPath;
			}
			if (other.FacialAnimTimeOffset != 0f)
			{
				FacialAnimTimeOffset = other.FacialAnimTimeOffset;
			}
			if (other.FacialAnimAutoBlendOutTime != 0f)
			{
				FacialAnimAutoBlendOutTime = other.FacialAnimAutoBlendOutTime;
			}
			if (other.IsSupportSkip != EGSYesNo.No)
			{
				IsSupportSkip = other.IsSupportSkip;
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
				Name = input.ReadString();
				break;
			case 26u:
				Content = input.ReadString();
				break;
			case 32u:
				LocalizationTag = input.ReadInt32();
				break;
			case 40u:
				IsSupportSoundDirection = (EGSYesNo)input.ReadEnum();
				break;
			case 48u:
				ResID = input.ReadInt32();
				break;
			case 58u:
				FacialAnimPath = input.ReadString();
				break;
			case 69u:
				FacialAnimTimeOffset = input.ReadFloat();
				break;
			case 77u:
				FacialAnimAutoBlendOutTime = input.ReadFloat();
				break;
			case 80u:
				IsSupportSkip = (EGSYesNo)input.ReadEnum();
				break;
			}
		}
	}
}
