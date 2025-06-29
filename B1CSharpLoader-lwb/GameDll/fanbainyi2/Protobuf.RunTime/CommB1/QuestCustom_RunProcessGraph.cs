using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_RunProcessGraph : IMessage<QuestCustom_RunProcessGraph>, IMessage, IEquatable<QuestCustom_RunProcessGraph>, IDeepCloneable<QuestCustom_RunProcessGraph>
{
	private static readonly MessageParser<QuestCustom_RunProcessGraph> _parser = new MessageParser<QuestCustom_RunProcessGraph>(() => new QuestCustom_RunProcessGraph());

	private UnknownFieldSet _unknownFields;

	private string assetPath_ = "";

	public static MessageParser<QuestCustom_RunProcessGraph> Parser => _parser;

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

	public QuestCustom_RunProcessGraph()
	{
	}

	public QuestCustom_RunProcessGraph(QuestCustom_RunProcessGraph other)
		: this()
	{
		assetPath_ = other.assetPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_RunProcessGraph Clone()
	{
		return new QuestCustom_RunProcessGraph(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_RunProcessGraph);
	}

	public bool Equals(QuestCustom_RunProcessGraph other)
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

	public void MergeFrom(QuestCustom_RunProcessGraph other)
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
