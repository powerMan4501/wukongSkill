using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ProcessStateCustom_Log : IMessage<ProcessStateCustom_Log>, IMessage, IEquatable<ProcessStateCustom_Log>, IDeepCloneable<ProcessStateCustom_Log>
{
	private static readonly MessageParser<ProcessStateCustom_Log> _parser = new MessageParser<ProcessStateCustom_Log>(() => new ProcessStateCustom_Log());

	private UnknownFieldSet _unknownFields;

	private string message_ = "";

	private bool isPrintToScreen_;

	private float duration_;

	private float textColorR_;

	private float textColorG_;

	private float textColorB_;

	private float textColorA_;

	public static MessageParser<ProcessStateCustom_Log> Parser => _parser;

	public string Message
	{
		get
		{
			return message_;
		}
		set
		{
			message_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsPrintToScreen
	{
		get
		{
			return isPrintToScreen_;
		}
		set
		{
			isPrintToScreen_ = value;
		}
	}

	public float Duration
	{
		get
		{
			return duration_;
		}
		set
		{
			duration_ = value;
		}
	}

	public float TextColorR
	{
		get
		{
			return textColorR_;
		}
		set
		{
			textColorR_ = value;
		}
	}

	public float TextColorG
	{
		get
		{
			return textColorG_;
		}
		set
		{
			textColorG_ = value;
		}
	}

	public float TextColorB
	{
		get
		{
			return textColorB_;
		}
		set
		{
			textColorB_ = value;
		}
	}

	public float TextColorA
	{
		get
		{
			return textColorA_;
		}
		set
		{
			textColorA_ = value;
		}
	}

	public ProcessStateCustom_Log()
	{
	}

	public ProcessStateCustom_Log(ProcessStateCustom_Log other)
		: this()
	{
		message_ = other.message_;
		isPrintToScreen_ = other.isPrintToScreen_;
		duration_ = other.duration_;
		textColorR_ = other.textColorR_;
		textColorG_ = other.textColorG_;
		textColorB_ = other.textColorB_;
		textColorA_ = other.textColorA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_Log Clone()
	{
		return new ProcessStateCustom_Log(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_Log);
	}

	public bool Equals(ProcessStateCustom_Log other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Message != other.Message)
		{
			return false;
		}
		if (IsPrintToScreen != other.IsPrintToScreen)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Duration, other.Duration))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TextColorR, other.TextColorR))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TextColorG, other.TextColorG))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TextColorB, other.TextColorB))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TextColorA, other.TextColorA))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Message.Length != 0)
		{
			num ^= Message.GetHashCode();
		}
		if (IsPrintToScreen)
		{
			num ^= IsPrintToScreen.GetHashCode();
		}
		if (Duration != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Duration);
		}
		if (TextColorR != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TextColorR);
		}
		if (TextColorG != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TextColorG);
		}
		if (TextColorB != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TextColorB);
		}
		if (TextColorA != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TextColorA);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Message.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Message);
		}
		if (IsPrintToScreen)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsPrintToScreen);
		}
		if (Duration != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(Duration);
		}
		if (TextColorR != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(TextColorR);
		}
		if (TextColorG != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(TextColorG);
		}
		if (TextColorB != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(TextColorB);
		}
		if (TextColorA != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(TextColorA);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Message.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Message);
		}
		if (IsPrintToScreen)
		{
			num += 2;
		}
		if (Duration != 0f)
		{
			num += 5;
		}
		if (TextColorR != 0f)
		{
			num += 5;
		}
		if (TextColorG != 0f)
		{
			num += 5;
		}
		if (TextColorB != 0f)
		{
			num += 5;
		}
		if (TextColorA != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_Log other)
	{
		if (other != null)
		{
			if (other.Message.Length != 0)
			{
				Message = other.Message;
			}
			if (other.IsPrintToScreen)
			{
				IsPrintToScreen = other.IsPrintToScreen;
			}
			if (other.Duration != 0f)
			{
				Duration = other.Duration;
			}
			if (other.TextColorR != 0f)
			{
				TextColorR = other.TextColorR;
			}
			if (other.TextColorG != 0f)
			{
				TextColorG = other.TextColorG;
			}
			if (other.TextColorB != 0f)
			{
				TextColorB = other.TextColorB;
			}
			if (other.TextColorA != 0f)
			{
				TextColorA = other.TextColorA;
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
				Message = input.ReadString();
				break;
			case 16u:
				IsPrintToScreen = input.ReadBool();
				break;
			case 29u:
				Duration = input.ReadFloat();
				break;
			case 37u:
				TextColorR = input.ReadFloat();
				break;
			case 45u:
				TextColorG = input.ReadFloat();
				break;
			case 53u:
				TextColorB = input.ReadFloat();
				break;
			case 61u:
				TextColorA = input.ReadFloat();
				break;
			}
		}
	}
}
