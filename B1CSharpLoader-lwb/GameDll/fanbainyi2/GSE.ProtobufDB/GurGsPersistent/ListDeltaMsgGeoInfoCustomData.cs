using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class ListDeltaMsgGeoInfoCustomData : IMessage<ListDeltaMsgGeoInfoCustomData>, IMessage, IEquatable<ListDeltaMsgGeoInfoCustomData>, IDeepCloneable<ListDeltaMsgGeoInfoCustomData>
{
	private static readonly MessageParser<ListDeltaMsgGeoInfoCustomData> _parser = new MessageParser<ListDeltaMsgGeoInfoCustomData>(() => new ListDeltaMsgGeoInfoCustomData());

	private UnknownFieldSet _unknownFields;

	private GeoInfoCustomData value_;

	public static MessageParser<ListDeltaMsgGeoInfoCustomData> Parser => _parser;

	public GeoInfoCustomData Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	public ListDeltaMsgGeoInfoCustomData()
	{
	}

	public ListDeltaMsgGeoInfoCustomData(ListDeltaMsgGeoInfoCustomData other)
		: this()
	{
		value_ = ((other.value_ != null) ? other.value_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListDeltaMsgGeoInfoCustomData Clone()
	{
		return new ListDeltaMsgGeoInfoCustomData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListDeltaMsgGeoInfoCustomData);
	}

	public bool Equals(ListDeltaMsgGeoInfoCustomData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Value, other.Value))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (value_ != null)
		{
			num ^= Value.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (value_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (value_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ListDeltaMsgGeoInfoCustomData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.value_ != null)
		{
			if (value_ == null)
			{
				Value = new GeoInfoCustomData();
			}
			Value.MergeFrom(other.Value);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (value_ == null)
			{
				Value = new GeoInfoCustomData();
			}
			input.ReadMessage(Value);
		}
	}
}
