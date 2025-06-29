using System;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSMsgGardenCollectCropOutputReq : IMessage<CSMsgGardenCollectCropOutputReq>, IMessage, IEquatable<CSMsgGardenCollectCropOutputReq>, IDeepCloneable<CSMsgGardenCollectCropOutputReq>
{
	private static readonly MessageParser<CSMsgGardenCollectCropOutputReq> _parser = new MessageParser<CSMsgGardenCollectCropOutputReq>(() => new CSMsgGardenCollectCropOutputReq());

	private UnknownFieldSet _unknownFields;

	private bool collectAll_;

	private static readonly FieldCodec<CollectCropOne> _repeated_collectItem_codec = FieldCodec.ForMessage(18u, CollectCropOne.Parser);

	private readonly RepeatedField<CollectCropOne> collectItem_ = new RepeatedField<CollectCropOne>();

	public static MessageParser<CSMsgGardenCollectCropOutputReq> Parser => _parser;

	public bool CollectAll
	{
		get
		{
			return collectAll_;
		}
		set
		{
			collectAll_ = value;
		}
	}

	public RepeatedField<CollectCropOne> CollectItem => collectItem_;

	public CSMsgGardenCollectCropOutputReq()
	{
	}

	public CSMsgGardenCollectCropOutputReq(CSMsgGardenCollectCropOutputReq other)
		: this()
	{
		collectAll_ = other.collectAll_;
		collectItem_ = other.collectItem_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgGardenCollectCropOutputReq Clone()
	{
		return new CSMsgGardenCollectCropOutputReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgGardenCollectCropOutputReq);
	}

	public bool Equals(CSMsgGardenCollectCropOutputReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CollectAll != other.CollectAll)
		{
			return false;
		}
		if (!collectItem_.Equals(other.collectItem_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CollectAll)
		{
			num ^= CollectAll.GetHashCode();
		}
		num ^= collectItem_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CollectAll)
		{
			output.WriteRawTag(8);
			output.WriteBool(CollectAll);
		}
		collectItem_.WriteTo(output, _repeated_collectItem_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CollectAll)
		{
			num += 2;
		}
		num += collectItem_.CalculateSize(_repeated_collectItem_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgGardenCollectCropOutputReq other)
	{
		if (other != null)
		{
			if (other.CollectAll)
			{
				CollectAll = other.CollectAll;
			}
			collectItem_.Add(other.collectItem_);
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
				CollectAll = input.ReadBool();
				break;
			case 18u:
				collectItem_.AddEntriesFrom(input, _repeated_collectItem_codec);
				break;
			}
		}
	}
}
