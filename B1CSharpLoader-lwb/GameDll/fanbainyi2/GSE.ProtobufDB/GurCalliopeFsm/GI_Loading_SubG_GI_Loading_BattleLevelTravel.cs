using System;
using Google.Protobuf;

namespace GurCalliopeFsm;

public sealed class GI_Loading_SubG_GI_Loading_BattleLevelTravel : IMessage<GI_Loading_SubG_GI_Loading_BattleLevelTravel>, IMessage, IEquatable<GI_Loading_SubG_GI_Loading_BattleLevelTravel>, IDeepCloneable<GI_Loading_SubG_GI_Loading_BattleLevelTravel>
{
	private static readonly MessageParser<GI_Loading_SubG_GI_Loading_BattleLevelTravel> _parser = new MessageParser<GI_Loading_SubG_GI_Loading_BattleLevelTravel>(() => new GI_Loading_SubG_GI_Loading_BattleLevelTravel());

	private UnknownFieldSet _unknownFields;

	private string subGraphAsset_ = "";

	private bool needWaitCameraBlend_;

	public static MessageParser<GI_Loading_SubG_GI_Loading_BattleLevelTravel> Parser => _parser;

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

	public bool NeedWaitCameraBlend
	{
		get
		{
			return needWaitCameraBlend_;
		}
		set
		{
			needWaitCameraBlend_ = value;
		}
	}

	public GI_Loading_SubG_GI_Loading_BattleLevelTravel()
	{
	}

	public GI_Loading_SubG_GI_Loading_BattleLevelTravel(GI_Loading_SubG_GI_Loading_BattleLevelTravel other)
		: this()
	{
		subGraphAsset_ = other.subGraphAsset_;
		needWaitCameraBlend_ = other.needWaitCameraBlend_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GI_Loading_SubG_GI_Loading_BattleLevelTravel Clone()
	{
		return new GI_Loading_SubG_GI_Loading_BattleLevelTravel(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GI_Loading_SubG_GI_Loading_BattleLevelTravel);
	}

	public bool Equals(GI_Loading_SubG_GI_Loading_BattleLevelTravel other)
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
		if (NeedWaitCameraBlend != other.NeedWaitCameraBlend)
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
		if (NeedWaitCameraBlend)
		{
			num ^= NeedWaitCameraBlend.GetHashCode();
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
		if (NeedWaitCameraBlend)
		{
			output.WriteRawTag(16);
			output.WriteBool(NeedWaitCameraBlend);
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
		if (NeedWaitCameraBlend)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GI_Loading_SubG_GI_Loading_BattleLevelTravel other)
	{
		if (other != null)
		{
			if (other.SubGraphAsset.Length != 0)
			{
				SubGraphAsset = other.SubGraphAsset;
			}
			if (other.NeedWaitCameraBlend)
			{
				NeedWaitCameraBlend = other.NeedWaitCameraBlend;
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
				NeedWaitCameraBlend = input.ReadBool();
				break;
			}
		}
	}
}
