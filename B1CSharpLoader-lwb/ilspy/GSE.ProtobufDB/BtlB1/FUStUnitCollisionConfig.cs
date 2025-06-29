using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStUnitCollisionConfig : IMessage<FUStUnitCollisionConfig>, IMessage, IEquatable<FUStUnitCollisionConfig>, IDeepCloneable<FUStUnitCollisionConfig>
{
	private static readonly MessageParser<FUStUnitCollisionConfig> _parser = new MessageParser<FUStUnitCollisionConfig>(() => new FUStUnitCollisionConfig());

	private UnknownFieldSet _unknownFields;

	private string collisionName_ = "";

	public static MessageParser<FUStUnitCollisionConfig> Parser => _parser;

	public string CollisionName
	{
		get
		{
			return collisionName_;
		}
		set
		{
			collisionName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStUnitCollisionConfig()
	{
	}

	public FUStUnitCollisionConfig(FUStUnitCollisionConfig other)
		: this()
	{
		collisionName_ = other.collisionName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitCollisionConfig Clone()
	{
		return new FUStUnitCollisionConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitCollisionConfig);
	}

	public bool Equals(FUStUnitCollisionConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CollisionName != other.CollisionName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CollisionName.Length != 0)
		{
			num ^= CollisionName.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CollisionName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(CollisionName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CollisionName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CollisionName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitCollisionConfig other)
	{
		if (other != null)
		{
			if (other.CollisionName.Length != 0)
			{
				CollisionName = other.CollisionName;
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
				CollisionName = input.ReadString();
			}
		}
	}
}
