using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_SubGraph : IMessage<QuestCustom_SubGraph>, IMessage, IEquatable<QuestCustom_SubGraph>, IDeepCloneable<QuestCustom_SubGraph>
{
	private static readonly MessageParser<QuestCustom_SubGraph> _parser = new MessageParser<QuestCustom_SubGraph>(() => new QuestCustom_SubGraph());

	private UnknownFieldSet _unknownFields;

	private string assetPath_ = "";

	public static MessageParser<QuestCustom_SubGraph> Parser => _parser;

	public string AssetPath
	{
		get
		{
			return assetPath_;
		}
		set
		{
			assetPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public QuestCustom_SubGraph()
	{
	}

	public QuestCustom_SubGraph(QuestCustom_SubGraph other)
		: this()
	{
		assetPath_ = other.assetPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_SubGraph Clone()
	{
		return new QuestCustom_SubGraph(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_SubGraph);
	}

	public bool Equals(QuestCustom_SubGraph other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AssetPath != other.AssetPath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AssetPath.Length != 0)
		{
			num ^= AssetPath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AssetPath.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AssetPath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AssetPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AssetPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_SubGraph other)
	{
		if (other != null)
		{
			if (other.AssetPath.Length != 0)
			{
				AssetPath = other.AssetPath;
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
				AssetPath = input.ReadString();
			}
		}
	}
}
