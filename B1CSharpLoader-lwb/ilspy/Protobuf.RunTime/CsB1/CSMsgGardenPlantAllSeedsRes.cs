using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgGardenPlantAllSeedsRes : IMessage<CSMsgGardenPlantAllSeedsRes>, IMessage, IEquatable<CSMsgGardenPlantAllSeedsRes>, IDeepCloneable<CSMsgGardenPlantAllSeedsRes>
{
	private static readonly MessageParser<CSMsgGardenPlantAllSeedsRes> _parser = new MessageParser<CSMsgGardenPlantAllSeedsRes>(() => new CSMsgGardenPlantAllSeedsRes());

	private UnknownFieldSet _unknownFields;

	private string animMontagePath_ = "";

	private AwardList awardList_;

	public static MessageParser<CSMsgGardenPlantAllSeedsRes> Parser => _parser;

	public string AnimMontagePath
	{
		get
		{
			return animMontagePath_;
		}
		set
		{
			animMontagePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public AwardList AwardList
	{
		get
		{
			return awardList_;
		}
		set
		{
			awardList_ = value;
		}
	}

	public CSMsgGardenPlantAllSeedsRes()
	{
	}

	public CSMsgGardenPlantAllSeedsRes(CSMsgGardenPlantAllSeedsRes other)
		: this()
	{
		animMontagePath_ = other.animMontagePath_;
		awardList_ = ((other.awardList_ != null) ? other.awardList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgGardenPlantAllSeedsRes Clone()
	{
		return new CSMsgGardenPlantAllSeedsRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgGardenPlantAllSeedsRes);
	}

	public bool Equals(CSMsgGardenPlantAllSeedsRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AnimMontagePath != other.AnimMontagePath)
		{
			return false;
		}
		if (!object.Equals(AwardList, other.AwardList))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AnimMontagePath.Length != 0)
		{
			num ^= AnimMontagePath.GetHashCode();
		}
		if (awardList_ != null)
		{
			num ^= AwardList.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AnimMontagePath.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AnimMontagePath);
		}
		if (awardList_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(AwardList);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AnimMontagePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AnimMontagePath);
		}
		if (awardList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AwardList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgGardenPlantAllSeedsRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AnimMontagePath.Length != 0)
		{
			AnimMontagePath = other.AnimMontagePath;
		}
		if (other.awardList_ != null)
		{
			if (awardList_ == null)
			{
				AwardList = new AwardList();
			}
			AwardList.MergeFrom(other.AwardList);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				AnimMontagePath = input.ReadString();
				break;
			case 18u:
				if (awardList_ == null)
				{
					AwardList = new AwardList();
				}
				input.ReadMessage(AwardList);
				break;
			}
		}
	}
}
