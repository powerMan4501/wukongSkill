using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class PersistentBUCDataWithLevel : IMessage<PersistentBUCDataWithLevel>, IMessage, IEquatable<PersistentBUCDataWithLevel>, IDeepCloneable<PersistentBUCDataWithLevel>
{
	private static readonly MessageParser<PersistentBUCDataWithLevel> _parser = new MessageParser<PersistentBUCDataWithLevel>(() => new PersistentBUCDataWithLevel());

	private UnknownFieldSet _unknownFields;

	private int levelIDRemoved_;

	private static readonly FieldCodec<PersistentBUCData> _repeated_bUCData_codec = FieldCodec.ForMessage(18u, PersistentBUCData.Parser);

	private readonly RepeatedField<PersistentBUCData> bUCData_ = new RepeatedField<PersistentBUCData>();

	public static MessageParser<PersistentBUCDataWithLevel> Parser => _parser;

	public int LevelIDRemoved
	{
		get
		{
			return levelIDRemoved_;
		}
		set
		{
			levelIDRemoved_ = value;
		}
	}

	public RepeatedField<PersistentBUCData> BUCData => bUCData_;

	public PersistentBUCDataWithLevel()
	{
	}

	public PersistentBUCDataWithLevel(PersistentBUCDataWithLevel other)
		: this()
	{
		levelIDRemoved_ = other.levelIDRemoved_;
		bUCData_ = other.bUCData_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PersistentBUCDataWithLevel Clone()
	{
		return new PersistentBUCDataWithLevel(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PersistentBUCDataWithLevel);
	}

	public bool Equals(PersistentBUCDataWithLevel other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelIDRemoved != other.LevelIDRemoved)
		{
			return false;
		}
		if (!bUCData_.Equals(other.bUCData_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LevelIDRemoved != 0)
		{
			num ^= LevelIDRemoved.GetHashCode();
		}
		num ^= bUCData_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LevelIDRemoved != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LevelIDRemoved);
		}
		bUCData_.WriteTo(output, _repeated_bUCData_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LevelIDRemoved != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelIDRemoved);
		}
		num += bUCData_.CalculateSize(_repeated_bUCData_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PersistentBUCDataWithLevel other)
	{
		if (other != null)
		{
			if (other.LevelIDRemoved != 0)
			{
				LevelIDRemoved = other.LevelIDRemoved;
			}
			bUCData_.Add(other.bUCData_);
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
				LevelIDRemoved = input.ReadInt32();
				break;
			case 18u:
				bUCData_.AddEntriesFrom(input, _repeated_bUCData_codec);
				break;
			}
		}
	}
}
