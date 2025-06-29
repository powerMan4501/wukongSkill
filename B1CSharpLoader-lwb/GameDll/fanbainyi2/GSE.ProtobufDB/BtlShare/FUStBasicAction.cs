using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStBasicAction : IMessage<FUStBasicAction>, IMessage, IEquatable<FUStBasicAction>, IDeepCloneable<FUStBasicAction>
{
	private static readonly MessageParser<FUStBasicAction> _parser = new MessageParser<FUStBasicAction>(() => new FUStBasicAction());

	private UnknownFieldSet _unknownFields;

	private EAIBasicActionType basicActionType_;

	private float minRange_;

	private float maxRange_;

	private static readonly FieldCodec<float> _repeated_actionParam_codec = FieldCodec.ForFloat(34u);

	private readonly RepeatedField<float> actionParam_ = new RepeatedField<float>();

	public static MessageParser<FUStBasicAction> Parser => _parser;

	public EAIBasicActionType BasicActionType
	{
		get
		{
			return basicActionType_;
		}
		set
		{
			basicActionType_ = value;
		}
	}

	public float MinRange
	{
		get
		{
			return minRange_;
		}
		set
		{
			minRange_ = value;
		}
	}

	public float MaxRange
	{
		get
		{
			return maxRange_;
		}
		set
		{
			maxRange_ = value;
		}
	}

	public RepeatedField<float> ActionParam => actionParam_;

	public FUStBasicAction()
	{
	}

	public FUStBasicAction(FUStBasicAction other)
		: this()
	{
		basicActionType_ = other.basicActionType_;
		minRange_ = other.minRange_;
		maxRange_ = other.maxRange_;
		actionParam_ = other.actionParam_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBasicAction Clone()
	{
		return new FUStBasicAction(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBasicAction);
	}

	public bool Equals(FUStBasicAction other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BasicActionType != other.BasicActionType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinRange, other.MinRange))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxRange, other.MaxRange))
		{
			return false;
		}
		if (!actionParam_.Equals(other.actionParam_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BasicActionType != EAIBasicActionType.DirectionMove)
		{
			num ^= BasicActionType.GetHashCode();
		}
		if (MinRange != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinRange);
		}
		if (MaxRange != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxRange);
		}
		num ^= actionParam_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BasicActionType != EAIBasicActionType.DirectionMove)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)BasicActionType);
		}
		if (MinRange != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(MinRange);
		}
		if (MaxRange != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(MaxRange);
		}
		actionParam_.WriteTo(output, _repeated_actionParam_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BasicActionType != EAIBasicActionType.DirectionMove)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BasicActionType);
		}
		if (MinRange != 0f)
		{
			num += 5;
		}
		if (MaxRange != 0f)
		{
			num += 5;
		}
		num += actionParam_.CalculateSize(_repeated_actionParam_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBasicAction other)
	{
		if (other != null)
		{
			if (other.BasicActionType != EAIBasicActionType.DirectionMove)
			{
				BasicActionType = other.BasicActionType;
			}
			if (other.MinRange != 0f)
			{
				MinRange = other.MinRange;
			}
			if (other.MaxRange != 0f)
			{
				MaxRange = other.MaxRange;
			}
			actionParam_.Add(other.actionParam_);
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
				BasicActionType = (EAIBasicActionType)input.ReadEnum();
				break;
			case 21u:
				MinRange = input.ReadFloat();
				break;
			case 29u:
				MaxRange = input.ReadFloat();
				break;
			case 34u:
			case 37u:
				actionParam_.AddEntriesFrom(input, _repeated_actionParam_codec);
				break;
			}
		}
	}
}
