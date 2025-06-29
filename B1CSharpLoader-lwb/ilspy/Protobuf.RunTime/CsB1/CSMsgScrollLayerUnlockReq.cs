using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgScrollLayerUnlockReq : IMessage<CSMsgScrollLayerUnlockReq>, IMessage, IEquatable<CSMsgScrollLayerUnlockReq>, IDeepCloneable<CSMsgScrollLayerUnlockReq>
{
	private static readonly MessageParser<CSMsgScrollLayerUnlockReq> _parser = new MessageParser<CSMsgScrollLayerUnlockReq>(() => new CSMsgScrollLayerUnlockReq());

	private UnknownFieldSet _unknownFields;

	private int chapterId_;

	private int layerId_;

	public static MessageParser<CSMsgScrollLayerUnlockReq> Parser => _parser;

	public int ChapterId
	{
		get
		{
			return chapterId_;
		}
		set
		{
			chapterId_ = value;
		}
	}

	public int LayerId
	{
		get
		{
			return layerId_;
		}
		set
		{
			layerId_ = value;
		}
	}

	public CSMsgScrollLayerUnlockReq()
	{
	}

	public CSMsgScrollLayerUnlockReq(CSMsgScrollLayerUnlockReq other)
		: this()
	{
		chapterId_ = other.chapterId_;
		layerId_ = other.layerId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgScrollLayerUnlockReq Clone()
	{
		return new CSMsgScrollLayerUnlockReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgScrollLayerUnlockReq);
	}

	public bool Equals(CSMsgScrollLayerUnlockReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ChapterId != other.ChapterId)
		{
			return false;
		}
		if (LayerId != other.LayerId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ChapterId != 0)
		{
			num ^= ChapterId.GetHashCode();
		}
		if (LayerId != 0)
		{
			num ^= LayerId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ChapterId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ChapterId);
		}
		if (LayerId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LayerId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ChapterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterId);
		}
		if (LayerId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LayerId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgScrollLayerUnlockReq other)
	{
		if (other != null)
		{
			if (other.ChapterId != 0)
			{
				ChapterId = other.ChapterId;
			}
			if (other.LayerId != 0)
			{
				LayerId = other.LayerId;
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
				ChapterId = input.ReadInt32();
				break;
			case 16u:
				LayerId = input.ReadInt32();
				break;
			}
		}
	}
}
