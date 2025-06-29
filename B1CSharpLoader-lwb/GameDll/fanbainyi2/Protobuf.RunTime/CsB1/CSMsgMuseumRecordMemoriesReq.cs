using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgMuseumRecordMemoriesReq : IMessage<CSMsgMuseumRecordMemoriesReq>, IMessage, IEquatable<CSMsgMuseumRecordMemoriesReq>, IDeepCloneable<CSMsgMuseumRecordMemoriesReq>
{
	private static readonly MessageParser<CSMsgMuseumRecordMemoriesReq> _parser = new MessageParser<CSMsgMuseumRecordMemoriesReq>(() => new CSMsgMuseumRecordMemoriesReq());

	private UnknownFieldSet _unknownFields;

	private int mvId_;

	public static MessageParser<CSMsgMuseumRecordMemoriesReq> Parser => _parser;

	public int MvId
	{
		get
		{
			return mvId_;
		}
		set
		{
			mvId_ = value;
		}
	}

	public CSMsgMuseumRecordMemoriesReq()
	{
	}

	public CSMsgMuseumRecordMemoriesReq(CSMsgMuseumRecordMemoriesReq other)
		: this()
	{
		mvId_ = other.mvId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMuseumRecordMemoriesReq Clone()
	{
		return new CSMsgMuseumRecordMemoriesReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMuseumRecordMemoriesReq);
	}

	public bool Equals(CSMsgMuseumRecordMemoriesReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MvId != other.MvId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MvId != 0)
		{
			num ^= MvId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MvId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MvId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MvId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MvId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgMuseumRecordMemoriesReq other)
	{
		if (other != null)
		{
			if (other.MvId != 0)
			{
				MvId = other.MvId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				MvId = input.ReadInt32();
			}
		}
	}
}
