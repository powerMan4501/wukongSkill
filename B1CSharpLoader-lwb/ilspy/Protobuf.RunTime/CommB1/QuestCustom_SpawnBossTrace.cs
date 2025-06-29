using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_SpawnBossTrace : IMessage<QuestCustom_SpawnBossTrace>, IMessage, IEquatable<QuestCustom_SpawnBossTrace>, IDeepCloneable<QuestCustom_SpawnBossTrace>
{
	private static readonly MessageParser<QuestCustom_SpawnBossTrace> _parser = new MessageParser<QuestCustom_SpawnBossTrace>(() => new QuestCustom_SpawnBossTrace());

	private UnknownFieldSet _unknownFields;

	private int spawnType_;

	private string traceEfxPath_ = "";

	public static MessageParser<QuestCustom_SpawnBossTrace> Parser => _parser;

	public int SpawnType
	{
		get
		{
			return spawnType_;
		}
		set
		{
			spawnType_ = value;
		}
	}

	public string TraceEfxPath
	{
		get
		{
			return traceEfxPath_;
		}
		set
		{
			traceEfxPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public QuestCustom_SpawnBossTrace()
	{
	}

	public QuestCustom_SpawnBossTrace(QuestCustom_SpawnBossTrace other)
		: this()
	{
		spawnType_ = other.spawnType_;
		traceEfxPath_ = other.traceEfxPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_SpawnBossTrace Clone()
	{
		return new QuestCustom_SpawnBossTrace(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_SpawnBossTrace);
	}

	public bool Equals(QuestCustom_SpawnBossTrace other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SpawnType != other.SpawnType)
		{
			return false;
		}
		if (TraceEfxPath != other.TraceEfxPath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SpawnType != 0)
		{
			num ^= SpawnType.GetHashCode();
		}
		if (TraceEfxPath.Length != 0)
		{
			num ^= TraceEfxPath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SpawnType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SpawnType);
		}
		if (TraceEfxPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(TraceEfxPath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SpawnType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpawnType);
		}
		if (TraceEfxPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TraceEfxPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_SpawnBossTrace other)
	{
		if (other != null)
		{
			if (other.SpawnType != 0)
			{
				SpawnType = other.SpawnType;
			}
			if (other.TraceEfxPath.Length != 0)
			{
				TraceEfxPath = other.TraceEfxPath;
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
				SpawnType = input.ReadInt32();
				break;
			case 18u:
				TraceEfxPath = input.ReadString();
				break;
			}
		}
	}
}
