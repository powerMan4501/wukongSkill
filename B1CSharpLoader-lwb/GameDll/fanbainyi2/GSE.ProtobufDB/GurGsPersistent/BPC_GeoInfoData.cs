using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BPC_GeoInfoData : IMessage<BPC_GeoInfoData>, IMessage, IEquatable<BPC_GeoInfoData>, IDeepCloneable<BPC_GeoInfoData>
{
	private static readonly MessageParser<BPC_GeoInfoData> _parser = new MessageParser<BPC_GeoInfoData>(() => new BPC_GeoInfoData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private static readonly FieldCodec<ListDeltaMsgGeoInfoAreaData> _repeated_areaPointGeoInfoList_codec = FieldCodec.ForMessage(10u, ListDeltaMsgGeoInfoAreaData.Parser);

	private readonly RepeatedField<ListDeltaMsgGeoInfoAreaData> areaPointGeoInfoList_ = new RepeatedField<ListDeltaMsgGeoInfoAreaData>();

	private static readonly FieldCodec<ListDeltaMsgGeoInfoCustomData> _repeated_customGeoInfoList_codec = FieldCodec.ForMessage(18u, ListDeltaMsgGeoInfoCustomData.Parser);

	private readonly RepeatedField<ListDeltaMsgGeoInfoCustomData> customGeoInfoList_ = new RepeatedField<ListDeltaMsgGeoInfoCustomData>();

	private int curMapSpriteId_;

	public static MessageParser<BPC_GeoInfoData> Parser => _parser;

	public RepeatedField<ListDeltaMsgGeoInfoAreaData> AreaPointGeoInfoList => areaPointGeoInfoList_;

	public RepeatedField<ListDeltaMsgGeoInfoCustomData> CustomGeoInfoList => customGeoInfoList_;

	public int CurMapSpriteId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return curMapSpriteId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			curMapSpriteId_ = value;
		}
	}

	public bool HasCurMapSpriteId => (_hasBits0 & 1) != 0;

	public BPC_GeoInfoData()
	{
	}

	public BPC_GeoInfoData(BPC_GeoInfoData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		areaPointGeoInfoList_ = other.areaPointGeoInfoList_.Clone();
		customGeoInfoList_ = other.customGeoInfoList_.Clone();
		curMapSpriteId_ = other.curMapSpriteId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BPC_GeoInfoData Clone()
	{
		return new BPC_GeoInfoData(this);
	}

	public void ClearCurMapSpriteId()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BPC_GeoInfoData);
	}

	public bool Equals(BPC_GeoInfoData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!areaPointGeoInfoList_.Equals(other.areaPointGeoInfoList_))
		{
			return false;
		}
		if (!customGeoInfoList_.Equals(other.customGeoInfoList_))
		{
			return false;
		}
		if (CurMapSpriteId != other.CurMapSpriteId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= areaPointGeoInfoList_.GetHashCode();
		num ^= customGeoInfoList_.GetHashCode();
		if (HasCurMapSpriteId)
		{
			num ^= CurMapSpriteId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		areaPointGeoInfoList_.WriteTo(output, _repeated_areaPointGeoInfoList_codec);
		customGeoInfoList_.WriteTo(output, _repeated_customGeoInfoList_codec);
		if (HasCurMapSpriteId)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CurMapSpriteId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += areaPointGeoInfoList_.CalculateSize(_repeated_areaPointGeoInfoList_codec);
		num += customGeoInfoList_.CalculateSize(_repeated_customGeoInfoList_codec);
		if (HasCurMapSpriteId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurMapSpriteId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BPC_GeoInfoData other)
	{
		if (other != null)
		{
			areaPointGeoInfoList_.Add(other.areaPointGeoInfoList_);
			customGeoInfoList_.Add(other.customGeoInfoList_);
			if (other.HasCurMapSpriteId)
			{
				CurMapSpriteId = other.CurMapSpriteId;
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
				areaPointGeoInfoList_.AddEntriesFrom(input, _repeated_areaPointGeoInfoList_codec);
				break;
			case 18u:
				customGeoInfoList_.AddEntriesFrom(input, _repeated_customGeoInfoList_codec);
				break;
			case 24u:
				CurMapSpriteId = input.ReadInt32();
				break;
			}
		}
	}
}
