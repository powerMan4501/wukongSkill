using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class AttrItemDesc : IMessage<AttrItemDesc>, IMessage, IEquatable<AttrItemDesc>, IDeepCloneable<AttrItemDesc>
{
	private static readonly MessageParser<AttrItemDesc> _parser = new MessageParser<AttrItemDesc>(() => new AttrItemDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private EffectAttrCfg attrRemove_;

	private EffectAttrCfg attr1Remove_;

	private static readonly FieldCodec<EffectAttrCfg> _repeated_attrs_codec = FieldCodec.ForMessage(34u, EffectAttrCfg.Parser);

	private readonly RepeatedField<EffectAttrCfg> attrs_ = new RepeatedField<EffectAttrCfg>();

	public static MessageParser<AttrItemDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public EffectAttrCfg AttrRemove
	{
		get
		{
			return attrRemove_;
		}
		set
		{
			attrRemove_ = value;
		}
	}

	public EffectAttrCfg Attr1Remove
	{
		get
		{
			return attr1Remove_;
		}
		set
		{
			attr1Remove_ = value;
		}
	}

	public RepeatedField<EffectAttrCfg> Attrs => attrs_;

	public AttrItemDesc()
	{
	}

	public AttrItemDesc(AttrItemDesc other)
		: this()
	{
		id_ = other.id_;
		attrRemove_ = ((other.attrRemove_ != null) ? other.attrRemove_.Clone() : null);
		attr1Remove_ = ((other.attr1Remove_ != null) ? other.attr1Remove_.Clone() : null);
		attrs_ = other.attrs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AttrItemDesc Clone()
	{
		return new AttrItemDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AttrItemDesc);
	}

	public bool Equals(AttrItemDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (!object.Equals(AttrRemove, other.AttrRemove))
		{
			return false;
		}
		if (!object.Equals(Attr1Remove, other.Attr1Remove))
		{
			return false;
		}
		if (!attrs_.Equals(other.attrs_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (attrRemove_ != null)
		{
			num ^= AttrRemove.GetHashCode();
		}
		if (attr1Remove_ != null)
		{
			num ^= Attr1Remove.GetHashCode();
		}
		num ^= attrs_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (attrRemove_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(AttrRemove);
		}
		if (attr1Remove_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Attr1Remove);
		}
		attrs_.WriteTo(output, _repeated_attrs_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (attrRemove_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AttrRemove);
		}
		if (attr1Remove_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Attr1Remove);
		}
		num += attrs_.CalculateSize(_repeated_attrs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AttrItemDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.attrRemove_ != null)
		{
			if (attrRemove_ == null)
			{
				AttrRemove = new EffectAttrCfg();
			}
			AttrRemove.MergeFrom(other.AttrRemove);
		}
		if (other.attr1Remove_ != null)
		{
			if (attr1Remove_ == null)
			{
				Attr1Remove = new EffectAttrCfg();
			}
			Attr1Remove.MergeFrom(other.Attr1Remove);
		}
		attrs_.Add(other.attrs_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				Id = input.ReadInt32();
				break;
			case 18u:
				if (attrRemove_ == null)
				{
					AttrRemove = new EffectAttrCfg();
				}
				input.ReadMessage(AttrRemove);
				break;
			case 26u:
				if (attr1Remove_ == null)
				{
					Attr1Remove = new EffectAttrCfg();
				}
				input.ReadMessage(Attr1Remove);
				break;
			case 34u:
				attrs_.AddEntriesFrom(input, _repeated_attrs_codec);
				break;
			}
		}
	}
}
