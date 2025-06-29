using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CsB1;

public sealed class CSMsgChapterPreviewAwardRes : IMessage<CSMsgChapterPreviewAwardRes>, IMessage, IEquatable<CSMsgChapterPreviewAwardRes>, IDeepCloneable<CSMsgChapterPreviewAwardRes>
{
	private static readonly MessageParser<CSMsgChapterPreviewAwardRes> _parser = new MessageParser<CSMsgChapterPreviewAwardRes>(() => new CSMsgChapterPreviewAwardRes());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ItemOne> _repeated_preAwardList_codec = FieldCodec.ForMessage(10u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> preAwardList_ = new RepeatedField<ItemOne>();

	public static MessageParser<CSMsgChapterPreviewAwardRes> Parser => _parser;

	public RepeatedField<ItemOne> PreAwardList => preAwardList_;

	public CSMsgChapterPreviewAwardRes()
	{
	}

	public CSMsgChapterPreviewAwardRes(CSMsgChapterPreviewAwardRes other)
		: this()
	{
		preAwardList_ = other.preAwardList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgChapterPreviewAwardRes Clone()
	{
		return new CSMsgChapterPreviewAwardRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgChapterPreviewAwardRes);
	}

	public bool Equals(CSMsgChapterPreviewAwardRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!preAwardList_.Equals(other.preAwardList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= preAwardList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		preAwardList_.WriteTo(output, _repeated_preAwardList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += preAwardList_.CalculateSize(_repeated_preAwardList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgChapterPreviewAwardRes other)
	{
		if (other != null)
		{
			preAwardList_.Add(other.preAwardList_);
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
				preAwardList_.AddEntriesFrom(input, _repeated_preAwardList_codec);
			}
		}
	}
}
