using System;
using Google.Protobuf;

namespace ResB1;

public sealed class CommonErrorUITipsDesc : IMessage<CommonErrorUITipsDesc>, IMessage, IEquatable<CommonErrorUITipsDesc>, IDeepCloneable<CommonErrorUITipsDesc>
{
	private static readonly MessageParser<CommonErrorUITipsDesc> _parser = new MessageParser<CommonErrorUITipsDesc>(() => new CommonErrorUITipsDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private ECommonErrorType errorType_;

	private int errorCode_;

	private ECommonErrorLevel errorLevel_;

	private string errorTips_ = "";

	private int localizationTag_;

	private YesNoType isShowTipsOnce_;

	public static MessageParser<CommonErrorUITipsDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public ECommonErrorType ErrorType
	{
		get
		{
			return errorType_;
		}
		set
		{
			errorType_ = value;
		}
	}

	public int ErrorCode
	{
		get
		{
			return errorCode_;
		}
		set
		{
			errorCode_ = value;
		}
	}

	public ECommonErrorLevel ErrorLevel
	{
		get
		{
			return errorLevel_;
		}
		set
		{
			errorLevel_ = value;
		}
	}

	public string ErrorTips
	{
		get
		{
			return errorTips_;
		}
		set
		{
			errorTips_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public YesNoType IsShowTipsOnce
	{
		get
		{
			return isShowTipsOnce_;
		}
		set
		{
			isShowTipsOnce_ = value;
		}
	}

	public CommonErrorUITipsDesc()
	{
	}

	public CommonErrorUITipsDesc(CommonErrorUITipsDesc other)
		: this()
	{
		id_ = other.id_;
		errorType_ = other.errorType_;
		errorCode_ = other.errorCode_;
		errorLevel_ = other.errorLevel_;
		errorTips_ = other.errorTips_;
		localizationTag_ = other.localizationTag_;
		isShowTipsOnce_ = other.isShowTipsOnce_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CommonErrorUITipsDesc Clone()
	{
		return new CommonErrorUITipsDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CommonErrorUITipsDesc);
	}

	public bool Equals(CommonErrorUITipsDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (ErrorType != other.ErrorType)
		{
			return false;
		}
		if (ErrorCode != other.ErrorCode)
		{
			return false;
		}
		if (ErrorLevel != other.ErrorLevel)
		{
			return false;
		}
		if (ErrorTips != other.ErrorTips)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (IsShowTipsOnce != other.IsShowTipsOnce)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ErrorType != ECommonErrorType.None)
		{
			num ^= ErrorType.GetHashCode();
		}
		if (ErrorCode != 0)
		{
			num ^= ErrorCode.GetHashCode();
		}
		if (ErrorLevel != ECommonErrorLevel.Ignorable)
		{
			num ^= ErrorLevel.GetHashCode();
		}
		if (ErrorTips.Length != 0)
		{
			num ^= ErrorTips.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (IsShowTipsOnce != YesNoType.No)
		{
			num ^= IsShowTipsOnce.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (ErrorType != ECommonErrorType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ErrorType);
		}
		if (ErrorCode != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ErrorCode);
		}
		if (ErrorLevel != ECommonErrorLevel.Ignorable)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ErrorLevel);
		}
		if (ErrorTips.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ErrorTips);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(LocalizationTag);
		}
		if (IsShowTipsOnce != YesNoType.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)IsShowTipsOnce);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ErrorType != ECommonErrorType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ErrorType);
		}
		if (ErrorCode != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ErrorCode);
		}
		if (ErrorLevel != ECommonErrorLevel.Ignorable)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ErrorLevel);
		}
		if (ErrorTips.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ErrorTips);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (IsShowTipsOnce != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsShowTipsOnce);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CommonErrorUITipsDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ErrorType != ECommonErrorType.None)
			{
				ErrorType = other.ErrorType;
			}
			if (other.ErrorCode != 0)
			{
				ErrorCode = other.ErrorCode;
			}
			if (other.ErrorLevel != ECommonErrorLevel.Ignorable)
			{
				ErrorLevel = other.ErrorLevel;
			}
			if (other.ErrorTips.Length != 0)
			{
				ErrorTips = other.ErrorTips;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.IsShowTipsOnce != YesNoType.No)
			{
				IsShowTipsOnce = other.IsShowTipsOnce;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				ErrorType = (ECommonErrorType)input.ReadEnum();
				break;
			case 24u:
				ErrorCode = input.ReadInt32();
				break;
			case 32u:
				ErrorLevel = (ECommonErrorLevel)input.ReadEnum();
				break;
			case 42u:
				ErrorTips = input.ReadString();
				break;
			case 48u:
				LocalizationTag = input.ReadInt32();
				break;
			case 56u:
				IsShowTipsOnce = (YesNoType)input.ReadEnum();
				break;
			}
		}
	}
}
