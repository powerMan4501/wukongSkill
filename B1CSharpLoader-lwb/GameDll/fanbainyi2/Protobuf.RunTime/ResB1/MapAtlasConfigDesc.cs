using System;
using Google.Protobuf;

namespace ResB1;

public sealed class MapAtlasConfigDesc : IMessage<MapAtlasConfigDesc>, IMessage, IEquatable<MapAtlasConfigDesc>, IDeepCloneable<MapAtlasConfigDesc>
{
	private static readonly MessageParser<MapAtlasConfigDesc> _parser = new MessageParser<MapAtlasConfigDesc>(() => new MapAtlasConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string atlasName_ = "";

	private int localizationTag_;

	public static MessageParser<MapAtlasConfigDesc> Parser => _parser;

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

	public string AtlasName
	{
		get
		{
			return atlasName_;
		}
		set
		{
			atlasName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public MapAtlasConfigDesc()
	{
	}

	public MapAtlasConfigDesc(MapAtlasConfigDesc other)
		: this()
	{
		id_ = other.id_;
		atlasName_ = other.atlasName_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MapAtlasConfigDesc Clone()
	{
		return new MapAtlasConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MapAtlasConfigDesc);
	}

	public bool Equals(MapAtlasConfigDesc other)
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
		if (AtlasName != other.AtlasName)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
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
		if (AtlasName.Length != 0)
		{
			num ^= AtlasName.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
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
		if (AtlasName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AtlasName);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LocalizationTag);
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
		if (AtlasName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AtlasName);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MapAtlasConfigDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.AtlasName.Length != 0)
			{
				AtlasName = other.AtlasName;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
			case 18u:
				AtlasName = input.ReadString();
				break;
			case 24u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
