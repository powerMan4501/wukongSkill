using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class LevelArchiveSceneObjStateData : IMessage<LevelArchiveSceneObjStateData>, IMessage, IEquatable<LevelArchiveSceneObjStateData>, IDeepCloneable<LevelArchiveSceneObjStateData>
{
	private static readonly MessageParser<LevelArchiveSceneObjStateData> _parser = new MessageParser<LevelArchiveSceneObjStateData>(() => new LevelArchiveSceneObjStateData());

	private UnknownFieldSet _unknownFields;

	private string objGuid_ = "";

	private static readonly FieldCodec<string> _repeated_objState_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> objState_ = new RepeatedField<string>();

	public static MessageParser<LevelArchiveSceneObjStateData> Parser => _parser;

	public string ObjGuid
	{
		get
		{
			return objGuid_;
		}
		set
		{
			objGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> ObjState => objState_;

	public LevelArchiveSceneObjStateData()
	{
	}

	public LevelArchiveSceneObjStateData(LevelArchiveSceneObjStateData other)
		: this()
	{
		objGuid_ = other.objGuid_;
		objState_ = other.objState_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelArchiveSceneObjStateData Clone()
	{
		return new LevelArchiveSceneObjStateData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelArchiveSceneObjStateData);
	}

	public bool Equals(LevelArchiveSceneObjStateData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ObjGuid != other.ObjGuid)
		{
			return false;
		}
		if (!objState_.Equals(other.objState_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ObjGuid.Length != 0)
		{
			num ^= ObjGuid.GetHashCode();
		}
		num ^= objState_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ObjGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ObjGuid);
		}
		objState_.WriteTo(output, _repeated_objState_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ObjGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ObjGuid);
		}
		num += objState_.CalculateSize(_repeated_objState_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelArchiveSceneObjStateData other)
	{
		if (other != null)
		{
			if (other.ObjGuid.Length != 0)
			{
				ObjGuid = other.ObjGuid;
			}
			objState_.Add(other.objState_);
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
				ObjGuid = input.ReadString();
				break;
			case 18u:
				objState_.AddEntriesFrom(input, _repeated_objState_codec);
				break;
			}
		}
	}
}
