using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BGC_OnlineAssistData : IMessage<BGC_OnlineAssistData>, IMessage, IEquatable<BGC_OnlineAssistData>, IDeepCloneable<BGC_OnlineAssistData>
{
	private static readonly MessageParser<BGC_OnlineAssistData> _parser = new MessageParser<BGC_OnlineAssistData>(() => new BGC_OnlineAssistData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<DictDeltaMsgString_FCrusadeUnitInfo> _repeated_crusadeMonsterInfos_codec = FieldCodec.ForMessage(10u, DictDeltaMsgString_FCrusadeUnitInfo.Parser);

	private readonly RepeatedField<DictDeltaMsgString_FCrusadeUnitInfo> crusadeMonsterInfos_ = new RepeatedField<DictDeltaMsgString_FCrusadeUnitInfo>();

	public static MessageParser<BGC_OnlineAssistData> Parser => _parser;

	public RepeatedField<DictDeltaMsgString_FCrusadeUnitInfo> CrusadeMonsterInfos => crusadeMonsterInfos_;

	public BGC_OnlineAssistData()
	{
	}

	public BGC_OnlineAssistData(BGC_OnlineAssistData other)
		: this()
	{
		crusadeMonsterInfos_ = other.crusadeMonsterInfos_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BGC_OnlineAssistData Clone()
	{
		return new BGC_OnlineAssistData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BGC_OnlineAssistData);
	}

	public bool Equals(BGC_OnlineAssistData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!crusadeMonsterInfos_.Equals(other.crusadeMonsterInfos_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= crusadeMonsterInfos_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		crusadeMonsterInfos_.WriteTo(output, _repeated_crusadeMonsterInfos_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += crusadeMonsterInfos_.CalculateSize(_repeated_crusadeMonsterInfos_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BGC_OnlineAssistData other)
	{
		if (other != null)
		{
			crusadeMonsterInfos_.Add(other.crusadeMonsterInfos_);
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
				crusadeMonsterInfos_.AddEntriesFrom(input, _repeated_crusadeMonsterInfos_codec);
			}
		}
	}
}
