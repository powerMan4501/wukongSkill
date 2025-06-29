using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class GeoInfoAreaData : IMessage<GeoInfoAreaData>, IMessage, IEquatable<GeoInfoAreaData>, IDeepCloneable<GeoInfoAreaData>
{
	private static readonly MessageParser<GeoInfoAreaData> _parser = new MessageParser<GeoInfoAreaData>(() => new GeoInfoAreaData());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<GeoInfoAreaData> Parser => _parser;

	public GeoInfoAreaData()
	{
	}

	public GeoInfoAreaData(GeoInfoAreaData other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GeoInfoAreaData Clone()
	{
		return new GeoInfoAreaData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GeoInfoAreaData);
	}

	public bool Equals(GeoInfoAreaData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GeoInfoAreaData other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
