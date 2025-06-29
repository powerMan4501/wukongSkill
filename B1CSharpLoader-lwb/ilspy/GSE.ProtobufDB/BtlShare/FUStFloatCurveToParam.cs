using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class FUStFloatCurveToParam : IMessage<FUStFloatCurveToParam>, IMessage, IEquatable<FUStFloatCurveToParam>, IDeepCloneable<FUStFloatCurveToParam>
{
	private static readonly MessageParser<FUStFloatCurveToParam> _parser = new MessageParser<FUStFloatCurveToParam>(() => new FUStFloatCurveToParam());

	private UnknownFieldSet _unknownFields;

	private string floatCurvePath_ = "";

	private string paramName_ = "";

	private EGSPosFitType curvePosFitType_;

	private EGSYesNo isResetOnEnd_;

	private EGSYesNo usePrimitiveData_;

	private int dataIndex_;

	public static MessageParser<FUStFloatCurveToParam> Parser => _parser;

	public string FloatCurvePath
	{
		get
		{
			return floatCurvePath_;
		}
		set
		{
			floatCurvePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ParamName
	{
		get
		{
			return paramName_;
		}
		set
		{
			paramName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSPosFitType CurvePosFitType
	{
		get
		{
			return curvePosFitType_;
		}
		set
		{
			curvePosFitType_ = value;
		}
	}

	public EGSYesNo IsResetOnEnd
	{
		get
		{
			return isResetOnEnd_;
		}
		set
		{
			isResetOnEnd_ = value;
		}
	}

	public EGSYesNo UsePrimitiveData
	{
		get
		{
			return usePrimitiveData_;
		}
		set
		{
			usePrimitiveData_ = value;
		}
	}

	public int DataIndex
	{
		get
		{
			return dataIndex_;
		}
		set
		{
			dataIndex_ = value;
		}
	}

	public FUStFloatCurveToParam()
	{
	}

	public FUStFloatCurveToParam(FUStFloatCurveToParam other)
		: this()
	{
		floatCurvePath_ = other.floatCurvePath_;
		paramName_ = other.paramName_;
		curvePosFitType_ = other.curvePosFitType_;
		isResetOnEnd_ = other.isResetOnEnd_;
		usePrimitiveData_ = other.usePrimitiveData_;
		dataIndex_ = other.dataIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStFloatCurveToParam Clone()
	{
		return new FUStFloatCurveToParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStFloatCurveToParam);
	}

	public bool Equals(FUStFloatCurveToParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FloatCurvePath != other.FloatCurvePath)
		{
			return false;
		}
		if (ParamName != other.ParamName)
		{
			return false;
		}
		if (CurvePosFitType != other.CurvePosFitType)
		{
			return false;
		}
		if (IsResetOnEnd != other.IsResetOnEnd)
		{
			return false;
		}
		if (UsePrimitiveData != other.UsePrimitiveData)
		{
			return false;
		}
		if (DataIndex != other.DataIndex)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (FloatCurvePath.Length != 0)
		{
			num ^= FloatCurvePath.GetHashCode();
		}
		if (ParamName.Length != 0)
		{
			num ^= ParamName.GetHashCode();
		}
		if (CurvePosFitType != EGSPosFitType.FitBegin)
		{
			num ^= CurvePosFitType.GetHashCode();
		}
		if (IsResetOnEnd != EGSYesNo.No)
		{
			num ^= IsResetOnEnd.GetHashCode();
		}
		if (UsePrimitiveData != EGSYesNo.No)
		{
			num ^= UsePrimitiveData.GetHashCode();
		}
		if (DataIndex != 0)
		{
			num ^= DataIndex.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (FloatCurvePath.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(FloatCurvePath);
		}
		if (ParamName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ParamName);
		}
		if (CurvePosFitType != EGSPosFitType.FitBegin)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)CurvePosFitType);
		}
		if (IsResetOnEnd != EGSYesNo.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)IsResetOnEnd);
		}
		if (UsePrimitiveData != EGSYesNo.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)UsePrimitiveData);
		}
		if (DataIndex != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(DataIndex);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (FloatCurvePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FloatCurvePath);
		}
		if (ParamName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ParamName);
		}
		if (CurvePosFitType != EGSPosFitType.FitBegin)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CurvePosFitType);
		}
		if (IsResetOnEnd != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsResetOnEnd);
		}
		if (UsePrimitiveData != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UsePrimitiveData);
		}
		if (DataIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DataIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStFloatCurveToParam other)
	{
		if (other != null)
		{
			if (other.FloatCurvePath.Length != 0)
			{
				FloatCurvePath = other.FloatCurvePath;
			}
			if (other.ParamName.Length != 0)
			{
				ParamName = other.ParamName;
			}
			if (other.CurvePosFitType != EGSPosFitType.FitBegin)
			{
				CurvePosFitType = other.CurvePosFitType;
			}
			if (other.IsResetOnEnd != EGSYesNo.No)
			{
				IsResetOnEnd = other.IsResetOnEnd;
			}
			if (other.UsePrimitiveData != EGSYesNo.No)
			{
				UsePrimitiveData = other.UsePrimitiveData;
			}
			if (other.DataIndex != 0)
			{
				DataIndex = other.DataIndex;
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
				FloatCurvePath = input.ReadString();
				break;
			case 18u:
				ParamName = input.ReadString();
				break;
			case 24u:
				CurvePosFitType = (EGSPosFitType)input.ReadEnum();
				break;
			case 32u:
				IsResetOnEnd = (EGSYesNo)input.ReadEnum();
				break;
			case 40u:
				UsePrimitiveData = (EGSYesNo)input.ReadEnum();
				break;
			case 48u:
				DataIndex = input.ReadInt32();
				break;
			}
		}
	}
}
