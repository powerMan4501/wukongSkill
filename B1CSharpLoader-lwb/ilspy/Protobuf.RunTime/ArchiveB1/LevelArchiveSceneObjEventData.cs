using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class LevelArchiveSceneObjEventData : IMessage<LevelArchiveSceneObjEventData>, IMessage, IEquatable<LevelArchiveSceneObjEventData>, IDeepCloneable<LevelArchiveSceneObjEventData>
{
	private static readonly MessageParser<LevelArchiveSceneObjEventData> _parser = new MessageParser<LevelArchiveSceneObjEventData>(() => new LevelArchiveSceneObjEventData());

	private UnknownFieldSet _unknownFields;

	private string objGuid_ = "";

	private static readonly FieldCodec<string> _repeated_objEvent_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> objEvent_ = new RepeatedField<string>();

	public static MessageParser<LevelArchiveSceneObjEventData> Parser => _parser;

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

	public RepeatedField<string> ObjEvent => objEvent_;

	public LevelArchiveSceneObjEventData()
	{
	}

	public LevelArchiveSceneObjEventData(LevelArchiveSceneObjEventData other)
		: this()
	{
		objGuid_ = other.objGuid_;
		objEvent_ = other.objEvent_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelArchiveSceneObjEventData Clone()
	{
		return new LevelArchiveSceneObjEventData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelArchiveSceneObjEventData);
	}

	public bool Equals(LevelArchiveSceneObjEventData other)
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
		if (!objEvent_.Equals(other.objEvent_))
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
		num ^= objEvent_.GetHashCode();
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
		objEvent_.WriteTo(output, _repeated_objEvent_codec);
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
		num += objEvent_.CalculateSize(_repeated_objEvent_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelArchiveSceneObjEventData other)
	{
		if (other != null)
		{
			if (other.ObjGuid.Length != 0)
			{
				ObjGuid = other.ObjGuid;
			}
			objEvent_.Add(other.objEvent_);
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
				objEvent_.AddEntriesFrom(input, _repeated_objEvent_codec);
				break;
			}
		}
	}
}
