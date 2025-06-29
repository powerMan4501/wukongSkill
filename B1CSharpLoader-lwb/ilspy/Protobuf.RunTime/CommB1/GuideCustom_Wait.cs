using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class GuideCustom_Wait : IMessage<GuideCustom_Wait>, IMessage, IEquatable<GuideCustom_Wait>, IDeepCloneable<GuideCustom_Wait>
{
	private static readonly MessageParser<GuideCustom_Wait> _parser = new MessageParser<GuideCustom_Wait>(() => new GuideCustom_Wait());

	private UnknownFieldSet _unknownFields;

	private int waitSecond_;

	private float waitSecondFloat_;

	public static MessageParser<GuideCustom_Wait> Parser => _parser;

	public int WaitSecond
	{
		get
		{
			return waitSecond_;
		}
		set
		{
			waitSecond_ = value;
		}
	}

	public float WaitSecondFloat
	{
		get
		{
			return waitSecondFloat_;
		}
		set
		{
			waitSecondFloat_ = value;
		}
	}

	public GuideCustom_Wait()
	{
	}

	public GuideCustom_Wait(GuideCustom_Wait other)
		: this()
	{
		waitSecond_ = other.waitSecond_;
		waitSecondFloat_ = other.waitSecondFloat_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GuideCustom_Wait Clone()
	{
		return new GuideCustom_Wait(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GuideCustom_Wait);
	}

	public bool Equals(GuideCustom_Wait other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (WaitSecond != other.WaitSecond)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(WaitSecondFloat, other.WaitSecondFloat))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (WaitSecond != 0)
		{
			num ^= WaitSecond.GetHashCode();
		}
		if (WaitSecondFloat != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(WaitSecondFloat);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (WaitSecond != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(WaitSecond);
		}
		if (WaitSecondFloat != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(WaitSecondFloat);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (WaitSecond != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WaitSecond);
		}
		if (WaitSecondFloat != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GuideCustom_Wait other)
	{
		if (other != null)
		{
			if (other.WaitSecond != 0)
			{
				WaitSecond = other.WaitSecond;
			}
			if (other.WaitSecondFloat != 0f)
			{
				WaitSecondFloat = other.WaitSecondFloat;
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
				WaitSecond = input.ReadInt32();
				break;
			case 21u:
				WaitSecondFloat = input.ReadFloat();
				break;
			}
		}
	}
}
