using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeGraphData : IMessage<CalliopeGraphData>, IMessage, IEquatable<CalliopeGraphData>, IDeepCloneable<CalliopeGraphData>
{
	private static readonly MessageParser<CalliopeGraphData> _parser = new MessageParser<CalliopeGraphData>(() => new CalliopeGraphData());

	private UnknownFieldSet _unknownFields;

	private string graphClass_ = "";

	private static readonly FieldCodec<CalliopeNodeData> _repeated_nodeCollection_codec = FieldCodec.ForMessage(18u, CalliopeNodeData.Parser);

	private readonly RepeatedField<CalliopeNodeData> nodeCollection_ = new RepeatedField<CalliopeNodeData>();

	private static readonly FieldCodec<CalliopeEdgeData> _repeated_edgeCollection_codec = FieldCodec.ForMessage(26u, CalliopeEdgeData.Parser);

	private readonly RepeatedField<CalliopeEdgeData> edgeCollection_ = new RepeatedField<CalliopeEdgeData>();

	public static MessageParser<CalliopeGraphData> Parser => _parser;

	public string GraphClass
	{
		get
		{
			return graphClass_;
		}
		set
		{
			graphClass_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<CalliopeNodeData> NodeCollection => nodeCollection_;

	public RepeatedField<CalliopeEdgeData> EdgeCollection => edgeCollection_;

	public CalliopeGraphData()
	{
	}

	public CalliopeGraphData(CalliopeGraphData other)
		: this()
	{
		graphClass_ = other.graphClass_;
		nodeCollection_ = other.nodeCollection_.Clone();
		edgeCollection_ = other.edgeCollection_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeGraphData Clone()
	{
		return new CalliopeGraphData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeGraphData);
	}

	public bool Equals(CalliopeGraphData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GraphClass != other.GraphClass)
		{
			return false;
		}
		if (!nodeCollection_.Equals(other.nodeCollection_))
		{
			return false;
		}
		if (!edgeCollection_.Equals(other.edgeCollection_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GraphClass.Length != 0)
		{
			num ^= GraphClass.GetHashCode();
		}
		num ^= nodeCollection_.GetHashCode();
		num ^= edgeCollection_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GraphClass.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(GraphClass);
		}
		nodeCollection_.WriteTo(output, _repeated_nodeCollection_codec);
		edgeCollection_.WriteTo(output, _repeated_edgeCollection_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GraphClass.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GraphClass);
		}
		num += nodeCollection_.CalculateSize(_repeated_nodeCollection_codec);
		num += edgeCollection_.CalculateSize(_repeated_edgeCollection_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeGraphData other)
	{
		if (other != null)
		{
			if (other.GraphClass.Length != 0)
			{
				GraphClass = other.GraphClass;
			}
			nodeCollection_.Add(other.nodeCollection_);
			edgeCollection_.Add(other.edgeCollection_);
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
			case 10u:
				GraphClass = input.ReadString();
				break;
			case 18u:
				nodeCollection_.AddEntriesFrom(input, _repeated_nodeCollection_codec);
				break;
			case 26u:
				edgeCollection_.AddEntriesFrom(input, _repeated_edgeCollection_codec);
				break;
			}
		}
	}
}
