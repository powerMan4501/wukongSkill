using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ArmorEnhanceDesc : IMessage<ArmorEnhanceDesc>, IMessage, IEquatable<ArmorEnhanceDesc>, IDeepCloneable<ArmorEnhanceDesc>
{
	private static readonly MessageParser<ArmorEnhanceDesc> _parser = new MessageParser<ArmorEnhanceDesc>(() => new ArmorEnhanceDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int seriesId_;

	private int nextArmorId_;

	public static MessageParser<ArmorEnhanceDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int SeriesId
	{
		get
		{
			return seriesId_;
		}
		set
		{
			seriesId_ = value;
		}
	}

	public int NextArmorId
	{
		get
		{
			return nextArmorId_;
		}
		set
		{
			nextArmorId_ = value;
		}
	}

	public ArmorEnhanceDesc()
	{
	}

	public ArmorEnhanceDesc(ArmorEnhanceDesc other)
		: this()
	{
		id_ = other.id_;
		seriesId_ = other.seriesId_;
		nextArmorId_ = other.nextArmorId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ArmorEnhanceDesc Clone()
	{
		return new ArmorEnhanceDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ArmorEnhanceDesc);
	}

	public bool Equals(ArmorEnhanceDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (SeriesId != other.SeriesId)
		{
			return false;
		}
		if (NextArmorId != other.NextArmorId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (SeriesId != 0)
		{
			num ^= SeriesId.GetHashCode();
		}
		if (NextArmorId != 0)
		{
			num ^= NextArmorId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (SeriesId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SeriesId);
		}
		if (NextArmorId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(NextArmorId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (SeriesId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SeriesId);
		}
		if (NextArmorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NextArmorId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ArmorEnhanceDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.SeriesId != 0)
			{
				SeriesId = other.SeriesId;
			}
			if (other.NextArmorId != 0)
			{
				NextArmorId = other.NextArmorId;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				SeriesId = input.ReadInt32();
				break;
			case 24u:
				NextArmorId = input.ReadInt32();
				break;
			}
		}
	}
}
