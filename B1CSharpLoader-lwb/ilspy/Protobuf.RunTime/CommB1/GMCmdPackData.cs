using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class GMCmdPackData : IMessage<GMCmdPackData>, IMessage, IEquatable<GMCmdPackData>, IDeepCloneable<GMCmdPackData>
{
	private static readonly MessageParser<GMCmdPackData> _parser = new MessageParser<GMCmdPackData>(() => new GMCmdPackData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<GMCmdPackOne> _repeated_cmdPackList_codec = FieldCodec.ForMessage(10u, GMCmdPackOne.Parser);

	private readonly RepeatedField<GMCmdPackOne> cmdPackList_ = new RepeatedField<GMCmdPackOne>();

	public static MessageParser<GMCmdPackData> Parser => _parser;

	public RepeatedField<GMCmdPackOne> CmdPackList => cmdPackList_;

	public GMCmdPackData()
	{
	}

	public GMCmdPackData(GMCmdPackData other)
		: this()
	{
		cmdPackList_ = other.cmdPackList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GMCmdPackData Clone()
	{
		return new GMCmdPackData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GMCmdPackData);
	}

	public bool Equals(GMCmdPackData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cmdPackList_.Equals(other.cmdPackList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= cmdPackList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		cmdPackList_.WriteTo(output, _repeated_cmdPackList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += cmdPackList_.CalculateSize(_repeated_cmdPackList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GMCmdPackData other)
	{
		if (other != null)
		{
			cmdPackList_.Add(other.cmdPackList_);
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
				cmdPackList_.AddEntriesFrom(input, _repeated_cmdPackList_codec);
			}
		}
	}
}
