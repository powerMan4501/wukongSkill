using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EndingCreditsData : IMessage<EndingCreditsData>, IMessage, IEquatable<EndingCreditsData>, IDeepCloneable<EndingCreditsData>
{
	private static readonly MessageParser<EndingCreditsData> _parser = new MessageParser<EndingCreditsData>(() => new EndingCreditsData());

	private UnknownFieldSet _unknownFields;

	private string jsonData_ = "";

	public static MessageParser<EndingCreditsData> Parser => _parser;

	public string JsonData
	{
		get
		{
			return jsonData_;
		}
		set
		{
			jsonData_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EndingCreditsData()
	{
	}

	public EndingCreditsData(EndingCreditsData other)
		: this()
	{
		jsonData_ = other.jsonData_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EndingCreditsData Clone()
	{
		return new EndingCreditsData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EndingCreditsData);
	}

	public bool Equals(EndingCreditsData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JsonData != other.JsonData)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (JsonData.Length != 0)
		{
			num ^= JsonData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (JsonData.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(JsonData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (JsonData.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(JsonData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EndingCreditsData other)
	{
		if (other != null)
		{
			if (other.JsonData.Length != 0)
			{
				JsonData = other.JsonData;
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
				JsonData = input.ReadString();
			}
		}
	}
}
