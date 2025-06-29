using System;
using Google.Protobuf;

namespace CommB1;

public sealed class GuideCustom_Mark : IMessage<GuideCustom_Mark>, IMessage, IEquatable<GuideCustom_Mark>, IDeepCloneable<GuideCustom_Mark>
{
	private static readonly MessageParser<GuideCustom_Mark> _parser = new MessageParser<GuideCustom_Mark>(() => new GuideCustom_Mark());

	private UnknownFieldSet _unknownFields;

	private int guideGroupId_;

	private bool isWaitUntilGuideFinish_;

	public static MessageParser<GuideCustom_Mark> Parser => _parser;

	public int GuideGroupId
	{
		get
		{
			return guideGroupId_;
		}
		set
		{
			guideGroupId_ = value;
		}
	}

	public bool IsWaitUntilGuideFinish
	{
		get
		{
			return isWaitUntilGuideFinish_;
		}
		set
		{
			isWaitUntilGuideFinish_ = value;
		}
	}

	public GuideCustom_Mark()
	{
	}

	public GuideCustom_Mark(GuideCustom_Mark other)
		: this()
	{
		guideGroupId_ = other.guideGroupId_;
		isWaitUntilGuideFinish_ = other.isWaitUntilGuideFinish_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GuideCustom_Mark Clone()
	{
		return new GuideCustom_Mark(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GuideCustom_Mark);
	}

	public bool Equals(GuideCustom_Mark other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GuideGroupId != other.GuideGroupId)
		{
			return false;
		}
		if (IsWaitUntilGuideFinish != other.IsWaitUntilGuideFinish)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GuideGroupId != 0)
		{
			num ^= GuideGroupId.GetHashCode();
		}
		if (IsWaitUntilGuideFinish)
		{
			num ^= IsWaitUntilGuideFinish.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GuideGroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GuideGroupId);
		}
		if (IsWaitUntilGuideFinish)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsWaitUntilGuideFinish);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GuideGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuideGroupId);
		}
		if (IsWaitUntilGuideFinish)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GuideCustom_Mark other)
	{
		if (other != null)
		{
			if (other.GuideGroupId != 0)
			{
				GuideGroupId = other.GuideGroupId;
			}
			if (other.IsWaitUntilGuideFinish)
			{
				IsWaitUntilGuideFinish = other.IsWaitUntilGuideFinish;
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
				GuideGroupId = input.ReadInt32();
				break;
			case 16u:
				IsWaitUntilGuideFinish = input.ReadBool();
				break;
			}
		}
	}
}
