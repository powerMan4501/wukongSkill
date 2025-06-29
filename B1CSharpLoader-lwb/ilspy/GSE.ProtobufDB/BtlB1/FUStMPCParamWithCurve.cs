using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStMPCParamWithCurve : IMessage<FUStMPCParamWithCurve>, IMessage, IEquatable<FUStMPCParamWithCurve>, IDeepCloneable<FUStMPCParamWithCurve>
{
	private static readonly MessageParser<FUStMPCParamWithCurve> _parser = new MessageParser<FUStMPCParamWithCurve>(() => new FUStMPCParamWithCurve());

	private UnknownFieldSet _unknownFields;

	private string mPCParamName_ = "";

	private string mPCFloatCurvePath_ = "";

	private float mPCCurveTotalTime_;

	private float mPCFloatOriValue_;

	public static MessageParser<FUStMPCParamWithCurve> Parser => _parser;

	public string MPCParamName
	{
		get
		{
			return mPCParamName_;
		}
		set
		{
			mPCParamName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MPCFloatCurvePath
	{
		get
		{
			return mPCFloatCurvePath_;
		}
		set
		{
			mPCFloatCurvePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float MPCCurveTotalTime
	{
		get
		{
			return mPCCurveTotalTime_;
		}
		set
		{
			mPCCurveTotalTime_ = value;
		}
	}

	public float MPCFloatOriValue
	{
		get
		{
			return mPCFloatOriValue_;
		}
		set
		{
			mPCFloatOriValue_ = value;
		}
	}

	public FUStMPCParamWithCurve()
	{
	}

	public FUStMPCParamWithCurve(FUStMPCParamWithCurve other)
		: this()
	{
		mPCParamName_ = other.mPCParamName_;
		mPCFloatCurvePath_ = other.mPCFloatCurvePath_;
		mPCCurveTotalTime_ = other.mPCCurveTotalTime_;
		mPCFloatOriValue_ = other.mPCFloatOriValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStMPCParamWithCurve Clone()
	{
		return new FUStMPCParamWithCurve(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStMPCParamWithCurve);
	}

	public bool Equals(FUStMPCParamWithCurve other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MPCParamName != other.MPCParamName)
		{
			return false;
		}
		if (MPCFloatCurvePath != other.MPCFloatCurvePath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MPCCurveTotalTime, other.MPCCurveTotalTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MPCFloatOriValue, other.MPCFloatOriValue))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MPCParamName.Length != 0)
		{
			num ^= MPCParamName.GetHashCode();
		}
		if (MPCFloatCurvePath.Length != 0)
		{
			num ^= MPCFloatCurvePath.GetHashCode();
		}
		if (MPCCurveTotalTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MPCCurveTotalTime);
		}
		if (MPCFloatOriValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MPCFloatOriValue);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MPCParamName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(MPCParamName);
		}
		if (MPCFloatCurvePath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(MPCFloatCurvePath);
		}
		if (MPCCurveTotalTime != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(MPCCurveTotalTime);
		}
		if (MPCFloatOriValue != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(MPCFloatOriValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MPCParamName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MPCParamName);
		}
		if (MPCFloatCurvePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MPCFloatCurvePath);
		}
		if (MPCCurveTotalTime != 0f)
		{
			num += 5;
		}
		if (MPCFloatOriValue != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStMPCParamWithCurve other)
	{
		if (other != null)
		{
			if (other.MPCParamName.Length != 0)
			{
				MPCParamName = other.MPCParamName;
			}
			if (other.MPCFloatCurvePath.Length != 0)
			{
				MPCFloatCurvePath = other.MPCFloatCurvePath;
			}
			if (other.MPCCurveTotalTime != 0f)
			{
				MPCCurveTotalTime = other.MPCCurveTotalTime;
			}
			if (other.MPCFloatOriValue != 0f)
			{
				MPCFloatOriValue = other.MPCFloatOriValue;
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
				MPCParamName = input.ReadString();
				break;
			case 18u:
				MPCFloatCurvePath = input.ReadString();
				break;
			case 29u:
				MPCCurveTotalTime = input.ReadFloat();
				break;
			case 37u:
				MPCFloatOriValue = input.ReadFloat();
				break;
			}
		}
	}
}
