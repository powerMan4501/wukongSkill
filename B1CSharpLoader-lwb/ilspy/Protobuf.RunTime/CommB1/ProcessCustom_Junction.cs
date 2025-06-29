using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessCustom_Junction : IMessage<ProcessCustom_Junction>, IMessage, IEquatable<ProcessCustom_Junction>, IDeepCloneable<ProcessCustom_Junction>
{
	private static readonly MessageParser<ProcessCustom_Junction> _parser = new MessageParser<ProcessCustom_Junction>(() => new ProcessCustom_Junction());

	private UnknownFieldSet _unknownFields;

	private string junctionState_ = "";

	public static MessageParser<ProcessCustom_Junction> Parser => _parser;

	public string JunctionState
	{
		get
		{
			return junctionState_;
		}
		set
		{
			junctionState_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ProcessCustom_Junction()
	{
	}

	public ProcessCustom_Junction(ProcessCustom_Junction other)
		: this()
	{
		junctionState_ = other.junctionState_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessCustom_Junction Clone()
	{
		return new ProcessCustom_Junction(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessCustom_Junction);
	}

	public bool Equals(ProcessCustom_Junction other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JunctionState != other.JunctionState)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (JunctionState.Length != 0)
		{
			num ^= JunctionState.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (JunctionState.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(JunctionState);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (JunctionState.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(JunctionState);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessCustom_Junction other)
	{
		if (other != null)
		{
			if (other.JunctionState.Length != 0)
			{
				JunctionState = other.JunctionState;
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
				JunctionState = input.ReadString();
			}
		}
	}
}
