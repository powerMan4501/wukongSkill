using System;
using Google.Protobuf;

namespace GurCalliopeFsm;

public sealed class GI_Loading_IsInMap : IMessage<GI_Loading_IsInMap>, IMessage, IEquatable<GI_Loading_IsInMap>, IDeepCloneable<GI_Loading_IsInMap>
{
	private static readonly MessageParser<GI_Loading_IsInMap> _parser = new MessageParser<GI_Loading_IsInMap>(() => new GI_Loading_IsInMap());

	private UnknownFieldSet _unknownFields;

	private string levelName_ = "";

	public static MessageParser<GI_Loading_IsInMap> Parser => _parser;

	public string LevelName
	{
		get
		{
			return levelName_;
		}
		set
		{
			levelName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GI_Loading_IsInMap()
	{
	}

	public GI_Loading_IsInMap(GI_Loading_IsInMap other)
		: this()
	{
		levelName_ = other.levelName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GI_Loading_IsInMap Clone()
	{
		return new GI_Loading_IsInMap(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GI_Loading_IsInMap);
	}

	public bool Equals(GI_Loading_IsInMap other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelName != other.LevelName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LevelName.Length != 0)
		{
			num ^= LevelName.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LevelName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(LevelName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LevelName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LevelName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GI_Loading_IsInMap other)
	{
		if (other != null)
		{
			if (other.LevelName.Length != 0)
			{
				LevelName = other.LevelName;
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
				LevelName = input.ReadString();
			}
		}
	}
}
