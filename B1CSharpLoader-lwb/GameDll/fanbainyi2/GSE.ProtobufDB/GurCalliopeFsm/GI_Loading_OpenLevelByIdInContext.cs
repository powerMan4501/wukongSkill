using System;
using Google.Protobuf;

namespace GurCalliopeFsm;

public sealed class GI_Loading_OpenLevelByIdInContext : IMessage<GI_Loading_OpenLevelByIdInContext>, IMessage, IEquatable<GI_Loading_OpenLevelByIdInContext>, IDeepCloneable<GI_Loading_OpenLevelByIdInContext>
{
	private static readonly MessageParser<GI_Loading_OpenLevelByIdInContext> _parser = new MessageParser<GI_Loading_OpenLevelByIdInContext>(() => new GI_Loading_OpenLevelByIdInContext());

	private UnknownFieldSet _unknownFields;

	private string contextOptions_ = "";

	public static MessageParser<GI_Loading_OpenLevelByIdInContext> Parser => _parser;

	public string ContextOptions
	{
		get
		{
			return contextOptions_;
		}
		set
		{
			contextOptions_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GI_Loading_OpenLevelByIdInContext()
	{
	}

	public GI_Loading_OpenLevelByIdInContext(GI_Loading_OpenLevelByIdInContext other)
		: this()
	{
		contextOptions_ = other.contextOptions_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GI_Loading_OpenLevelByIdInContext Clone()
	{
		return new GI_Loading_OpenLevelByIdInContext(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GI_Loading_OpenLevelByIdInContext);
	}

	public bool Equals(GI_Loading_OpenLevelByIdInContext other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ContextOptions != other.ContextOptions)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ContextOptions.Length != 0)
		{
			num ^= ContextOptions.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ContextOptions.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ContextOptions);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ContextOptions.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ContextOptions);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GI_Loading_OpenLevelByIdInContext other)
	{
		if (other != null)
		{
			if (other.ContextOptions.Length != 0)
			{
				ContextOptions = other.ContextOptions;
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
				ContextOptions = input.ReadString();
			}
		}
	}
}
