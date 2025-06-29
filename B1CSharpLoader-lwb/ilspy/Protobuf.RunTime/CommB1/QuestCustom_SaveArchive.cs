using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_SaveArchive : IMessage<QuestCustom_SaveArchive>, IMessage, IEquatable<QuestCustom_SaveArchive>, IDeepCloneable<QuestCustom_SaveArchive>
{
	private static readonly MessageParser<QuestCustom_SaveArchive> _parser = new MessageParser<QuestCustom_SaveArchive>(() => new QuestCustom_SaveArchive());

	private UnknownFieldSet _unknownFields;

	private string archiveLabel_ = "";

	public static MessageParser<QuestCustom_SaveArchive> Parser => _parser;

	public string ArchiveLabel
	{
		get
		{
			return archiveLabel_;
		}
		set
		{
			archiveLabel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public QuestCustom_SaveArchive()
	{
	}

	public QuestCustom_SaveArchive(QuestCustom_SaveArchive other)
		: this()
	{
		archiveLabel_ = other.archiveLabel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_SaveArchive Clone()
	{
		return new QuestCustom_SaveArchive(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_SaveArchive);
	}

	public bool Equals(QuestCustom_SaveArchive other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ArchiveLabel != other.ArchiveLabel)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ArchiveLabel.Length != 0)
		{
			num ^= ArchiveLabel.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ArchiveLabel.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ArchiveLabel);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ArchiveLabel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArchiveLabel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_SaveArchive other)
	{
		if (other != null)
		{
			if (other.ArchiveLabel.Length != 0)
			{
				ArchiveLabel = other.ArchiveLabel;
			}
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
				ArchiveLabel = input.ReadString();
			}
		}
	}
}
