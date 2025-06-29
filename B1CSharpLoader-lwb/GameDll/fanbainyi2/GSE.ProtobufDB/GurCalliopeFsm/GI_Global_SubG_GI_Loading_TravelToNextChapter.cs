using System;
using Google.Protobuf;

namespace GurCalliopeFsm;

public sealed class GI_Global_SubG_GI_Loading_TravelToNextChapter : IMessage<GI_Global_SubG_GI_Loading_TravelToNextChapter>, IMessage, IEquatable<GI_Global_SubG_GI_Loading_TravelToNextChapter>, IDeepCloneable<GI_Global_SubG_GI_Loading_TravelToNextChapter>
{
	private static readonly MessageParser<GI_Global_SubG_GI_Loading_TravelToNextChapter> _parser = new MessageParser<GI_Global_SubG_GI_Loading_TravelToNextChapter>(() => new GI_Global_SubG_GI_Loading_TravelToNextChapter());

	private UnknownFieldSet _unknownFields;

	private string subGraphAsset_ = "";

	public static MessageParser<GI_Global_SubG_GI_Loading_TravelToNextChapter> Parser => _parser;

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

	public GI_Global_SubG_GI_Loading_TravelToNextChapter()
	{
	}

	public GI_Global_SubG_GI_Loading_TravelToNextChapter(GI_Global_SubG_GI_Loading_TravelToNextChapter other)
		: this()
	{
		subGraphAsset_ = other.subGraphAsset_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GI_Global_SubG_GI_Loading_TravelToNextChapter Clone()
	{
		return new GI_Global_SubG_GI_Loading_TravelToNextChapter(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GI_Global_SubG_GI_Loading_TravelToNextChapter);
	}

	public bool Equals(GI_Global_SubG_GI_Loading_TravelToNextChapter other)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SubGraphAsset.Length != 0)
		{
			num ^= SubGraphAsset.GetHashCode();
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GI_Global_SubG_GI_Loading_TravelToNextChapter other)
	{
		if (other != null)
		{
			if (other.SubGraphAsset.Length != 0)
			{
				SubGraphAsset = other.SubGraphAsset;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				SubGraphAsset = input.ReadString();
			}
		}
	}
}
