using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class ChapterData : IMessage<ChapterData>, IMessage, IEquatable<ChapterData>, IDeepCloneable<ChapterData>
{
	private static readonly MessageParser<ChapterData> _parser = new MessageParser<ChapterData>(() => new ChapterData());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private ChapterStage stage_;

	private static readonly FieldCodec<int> _repeated_surpriseList_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> surpriseList_ = new RepeatedField<int>();

	public static MessageParser<ChapterData> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public ChapterStage Stage
	{
		get
		{
			return stage_;
		}
		set
		{
			stage_ = value;
		}
	}

	public RepeatedField<int> SurpriseList => surpriseList_;

	public ChapterData()
	{
	}

	public ChapterData(ChapterData other)
		: this()
	{
		id_ = other.id_;
		stage_ = other.stage_;
		surpriseList_ = other.surpriseList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ChapterData Clone()
	{
		return new ChapterData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ChapterData);
	}

	public bool Equals(ChapterData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Stage != other.Stage)
		{
			return false;
		}
		if (!surpriseList_.Equals(other.surpriseList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Stage != ChapterStage.None)
		{
			num ^= Stage.GetHashCode();
		}
		num ^= surpriseList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Stage != ChapterStage.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Stage);
		}
		surpriseList_.WriteTo(output, _repeated_surpriseList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Stage != ChapterStage.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Stage);
		}
		num += surpriseList_.CalculateSize(_repeated_surpriseList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ChapterData other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Stage != ChapterStage.None)
			{
				Stage = other.Stage;
			}
			surpriseList_.Add(other.surpriseList_);
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
				Id = input.ReadInt32();
				break;
			case 16u:
				Stage = (ChapterStage)input.ReadEnum();
				break;
			case 32u:
			case 34u:
				surpriseList_.AddEntriesFrom(input, _repeated_surpriseList_codec);
				break;
			}
		}
	}
}
