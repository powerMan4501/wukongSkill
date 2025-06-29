using System;
using Google.Protobuf;

namespace GurCalliopeFsm;

public sealed class GI_Global_SubG_GI_Loading_TravelLevel : IMessage<GI_Global_SubG_GI_Loading_TravelLevel>, IMessage, IEquatable<GI_Global_SubG_GI_Loading_TravelLevel>, IDeepCloneable<GI_Global_SubG_GI_Loading_TravelLevel>
{
	private static readonly MessageParser<GI_Global_SubG_GI_Loading_TravelLevel> _parser = new MessageParser<GI_Global_SubG_GI_Loading_TravelLevel>(() => new GI_Global_SubG_GI_Loading_TravelLevel());

	private UnknownFieldSet _unknownFields;

	private string subGraphAsset_ = "";

	private int travelLevelType_;

	private int targetLevelNetType_;

	public static MessageParser<GI_Global_SubG_GI_Loading_TravelLevel> Parser => _parser;

	public string SubGraphAsset
	{
		get
		{
			return subGraphAsset_;
		}
		set
		{
			subGraphAsset_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TravelLevelType
	{
		get
		{
			return travelLevelType_;
		}
		set
		{
			travelLevelType_ = value;
		}
	}

	public int TargetLevelNetType
	{
		get
		{
			return targetLevelNetType_;
		}
		set
		{
			targetLevelNetType_ = value;
		}
	}

	public GI_Global_SubG_GI_Loading_TravelLevel()
	{
	}

	public GI_Global_SubG_GI_Loading_TravelLevel(GI_Global_SubG_GI_Loading_TravelLevel other)
		: this()
	{
		subGraphAsset_ = other.subGraphAsset_;
		travelLevelType_ = other.travelLevelType_;
		targetLevelNetType_ = other.targetLevelNetType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GI_Global_SubG_GI_Loading_TravelLevel Clone()
	{
		return new GI_Global_SubG_GI_Loading_TravelLevel(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GI_Global_SubG_GI_Loading_TravelLevel);
	}

	public bool Equals(GI_Global_SubG_GI_Loading_TravelLevel other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SubGraphAsset != other.SubGraphAsset)
		{
			return false;
		}
		if (TravelLevelType != other.TravelLevelType)
		{
			return false;
		}
		if (TargetLevelNetType != other.TargetLevelNetType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SubGraphAsset.Length != 0)
		{
			num ^= SubGraphAsset.GetHashCode();
		}
		if (TravelLevelType != 0)
		{
			num ^= TravelLevelType.GetHashCode();
		}
		if (TargetLevelNetType != 0)
		{
			num ^= TargetLevelNetType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SubGraphAsset.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(SubGraphAsset);
		}
		if (TravelLevelType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TravelLevelType);
		}
		if (TargetLevelNetType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TargetLevelNetType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SubGraphAsset.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SubGraphAsset);
		}
		if (TravelLevelType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TravelLevelType);
		}
		if (TargetLevelNetType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetLevelNetType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GI_Global_SubG_GI_Loading_TravelLevel other)
	{
		if (other != null)
		{
			if (other.SubGraphAsset.Length != 0)
			{
				SubGraphAsset = other.SubGraphAsset;
			}
			if (other.TravelLevelType != 0)
			{
				TravelLevelType = other.TravelLevelType;
			}
			if (other.TargetLevelNetType != 0)
			{
				TargetLevelNetType = other.TargetLevelNetType;
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
				SubGraphAsset = input.ReadString();
				break;
			case 16u:
				TravelLevelType = input.ReadInt32();
				break;
			case 24u:
				TargetLevelNetType = input.ReadInt32();
				break;
			}
		}
	}
}
