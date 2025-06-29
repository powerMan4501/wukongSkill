using System;
using Google.Protobuf;

namespace GurGsReplicate;

public sealed class ProjectileBasicData : IMessage<ProjectileBasicData>, IMessage, IEquatable<ProjectileBasicData>, IDeepCloneable<ProjectileBasicData>
{
	private static readonly MessageParser<ProjectileBasicData> _parser = new MessageParser<ProjectileBasicData>(() => new ProjectileBasicData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int projectileID_;

	public static MessageParser<ProjectileBasicData> Parser => _parser;

	public int ProjectileID
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return projectileID_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			projectileID_ = value;
		}
	}

	public bool HasProjectileID => (_hasBits0 & 1) != 0;

	public ProjectileBasicData()
	{
	}

	public ProjectileBasicData(ProjectileBasicData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		projectileID_ = other.projectileID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProjectileBasicData Clone()
	{
		return new ProjectileBasicData(this);
	}

	public void ClearProjectileID()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProjectileBasicData);
	}

	public bool Equals(ProjectileBasicData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ProjectileID != other.ProjectileID)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasProjectileID)
		{
			num ^= ProjectileID.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasProjectileID)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ProjectileID);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasProjectileID)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ProjectileID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProjectileBasicData other)
	{
		if (other != null)
		{
			if (other.HasProjectileID)
			{
				ProjectileID = other.ProjectileID;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				ProjectileID = input.ReadInt32();
			}
		}
	}
}
