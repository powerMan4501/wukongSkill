using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_ExecutionMultiGate : IMessage<QuestCustom_ExecutionMultiGate>, IMessage, IEquatable<QuestCustom_ExecutionMultiGate>, IDeepCloneable<QuestCustom_ExecutionMultiGate>
{
	private static readonly MessageParser<QuestCustom_ExecutionMultiGate> _parser = new MessageParser<QuestCustom_ExecutionMultiGate>(() => new QuestCustom_ExecutionMultiGate());

	private UnknownFieldSet _unknownFields;

	private bool isRandom_;

	private bool isLoop_;

	private int startIndex_;

	public static MessageParser<QuestCustom_ExecutionMultiGate> Parser => _parser;

	public bool IsRandom
	{
		get
		{
			return isRandom_;
		}
		set
		{
			isRandom_ = value;
		}
	}

	public bool IsLoop
	{
		get
		{
			return isLoop_;
		}
		set
		{
			isLoop_ = value;
		}
	}

	public int StartIndex
	{
		get
		{
			return startIndex_;
		}
		set
		{
			startIndex_ = value;
		}
	}

	public QuestCustom_ExecutionMultiGate()
	{
	}

	public QuestCustom_ExecutionMultiGate(QuestCustom_ExecutionMultiGate other)
		: this()
	{
		isRandom_ = other.isRandom_;
		isLoop_ = other.isLoop_;
		startIndex_ = other.startIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_ExecutionMultiGate Clone()
	{
		return new QuestCustom_ExecutionMultiGate(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_ExecutionMultiGate);
	}

	public bool Equals(QuestCustom_ExecutionMultiGate other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsRandom != other.IsRandom)
		{
			return false;
		}
		if (IsLoop != other.IsLoop)
		{
			return false;
		}
		if (StartIndex != other.StartIndex)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsRandom)
		{
			num ^= IsRandom.GetHashCode();
		}
		if (IsLoop)
		{
			num ^= IsLoop.GetHashCode();
		}
		if (StartIndex != 0)
		{
			num ^= StartIndex.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsRandom)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsRandom);
		}
		if (IsLoop)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsLoop);
		}
		if (StartIndex != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(StartIndex);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsRandom)
		{
			num += 2;
		}
		if (IsLoop)
		{
			num += 2;
		}
		if (StartIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StartIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_ExecutionMultiGate other)
	{
		if (other != null)
		{
			if (other.IsRandom)
			{
				IsRandom = other.IsRandom;
			}
			if (other.IsLoop)
			{
				IsLoop = other.IsLoop;
			}
			if (other.StartIndex != 0)
			{
				StartIndex = other.StartIndex;
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
				IsRandom = input.ReadBool();
				break;
			case 16u:
				IsLoop = input.ReadBool();
				break;
			case 24u:
				StartIndex = input.ReadInt32();
				break;
			}
		}
	}
}
