using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class RoleDataClient : IMessage<RoleDataClient>, IMessage, IEquatable<RoleDataClient>, IDeepCloneable<RoleDataClient>
{
	private static readonly MessageParser<RoleDataClient> _parser = new MessageParser<RoleDataClient>(() => new RoleDataClient());

	private UnknownFieldSet _unknownFields;

	private RoleStaticsData staticsData_;

	public static MessageParser<RoleDataClient> Parser => _parser;

	public RoleStaticsData StaticsData
	{
		get
		{
			return staticsData_;
		}
		set
		{
			staticsData_ = value;
		}
	}

	public RoleDataClient()
	{
	}

	public RoleDataClient(RoleDataClient other)
		: this()
	{
		staticsData_ = ((other.staticsData_ != null) ? other.staticsData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleDataClient Clone()
	{
		return new RoleDataClient(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDataClient);
	}

	public bool Equals(RoleDataClient other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(StaticsData, other.StaticsData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (staticsData_ != null)
		{
			num ^= StaticsData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (staticsData_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(StaticsData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (staticsData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StaticsData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleDataClient other)
	{
		if (other == null)
		{
			return;
		}
		if (other.staticsData_ != null)
		{
			if (staticsData_ == null)
			{
				StaticsData = new RoleStaticsData();
			}
			StaticsData.MergeFrom(other.StaticsData);
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
			if (staticsData_ == null)
			{
				StaticsData = new RoleStaticsData();
			}
			input.ReadMessage(StaticsData);
		}
	}
}
