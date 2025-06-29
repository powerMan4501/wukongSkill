using System.Collections.Generic;
using System.IO;

namespace UnrealEngine.Runtime;

public class ManagedUnrealPropertyInfo : ManagedUnrealReflectionBase
{
	public ManagedUnrealTypeInfoReference Type { get; set; }

	public List<ManagedUnrealTypeInfoReference> GenericArgs { get; set; }

	public int FixedSizeArrayDim { get; set; }

	public string RepNotifyName { get; set; }

	public EPropertyFlags Flags { get; set; }

	public ManagedUnrealPropertyFlags AdditionalFlags { get; set; }

	[ManagedUnrealReflectIgnore]
	public bool IsPublic
	{
		get
		{
			return Flags.HasFlag(EPropertyFlags.NativeAccessSpecifierPublic);
		}
		set
		{
			SetFlag(EPropertyFlags.NativeAccessSpecifierPublic, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsPrivate
	{
		get
		{
			return Flags.HasFlag(EPropertyFlags.NativeAccessSpecifierPrivate);
		}
		set
		{
			SetFlag(EPropertyFlags.NativeAccessSpecifierPrivate, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsProtected
	{
		get
		{
			return Flags.HasFlag(EPropertyFlags.NativeAccessSpecifierProtected);
		}
		set
		{
			SetFlag(EPropertyFlags.NativeAccessSpecifierProtected, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsField
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealPropertyFlags.Field);
		}
		set
		{
			SetFlag(ManagedUnrealPropertyFlags.Field, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsBackingFieldPreStripped
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealPropertyFlags.BackingFieldPreStripped);
		}
		set
		{
			SetFlag(ManagedUnrealPropertyFlags.BackingFieldPreStripped, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsFunctionParam
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealPropertyFlags.FunctionParam);
		}
		set
		{
			if (value)
			{
				Flags |= EPropertyFlags.Parm;
			}
			else
			{
				Flags &= ~EPropertyFlags.Parm;
			}
			SetFlag(ManagedUnrealPropertyFlags.FunctionParam, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsFunctionReturnValue
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealPropertyFlags.FunctionReturnValue);
		}
		set
		{
			if (value)
			{
				Flags |= EPropertyFlags.Parm | EPropertyFlags.OutParm | EPropertyFlags.ReturnParm;
			}
			else
			{
				Flags &= ~(EPropertyFlags.Parm | EPropertyFlags.OutParm | EPropertyFlags.ReturnParm);
			}
			SetFlag(ManagedUnrealPropertyFlags.FunctionReturnValue, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsByRef
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealPropertyFlags.ByRefParam);
		}
		set
		{
			if (value)
			{
				Flags |= EPropertyFlags.OutParm | EPropertyFlags.ReferenceParm;
			}
			else
			{
				Flags &= ~(EPropertyFlags.OutParm | EPropertyFlags.ReferenceParm);
			}
			SetFlag(ManagedUnrealPropertyFlags.ByRefParam, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsOut
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealPropertyFlags.OutParam);
		}
		set
		{
			if (value)
			{
				Flags |= EPropertyFlags.OutParm;
				Flags &= ~EPropertyFlags.ReferenceParm;
			}
			else
			{
				Flags &= ~EPropertyFlags.OutParm;
			}
			SetFlag(ManagedUnrealPropertyFlags.OutParam, value);
		}
	}

	public bool IsFixedSizeArray
	{
		get
		{
			if (Type != null)
			{
				if (Type.TypeCode != EPropertyType.InternalNativeFixedSizeArray)
				{
					return Type.TypeCode == EPropertyType.InternalManagedFixedSizeArray;
				}
				return true;
			}
			return false;
		}
	}

	public bool IsCollection
	{
		get
		{
			if (Type != null)
			{
				return ManagedUnrealTypeInfo.IsCollectionType(Type.TypeCode);
			}
			return false;
		}
	}

	public bool IsDelegate
	{
		get
		{
			if (Type != null)
			{
				return ManagedUnrealTypeInfo.IsDelegateType(Type.TypeCode);
			}
			return false;
		}
	}

	public ManagedUnrealPropertyInfo()
	{
		GenericArgs = new List<ManagedUnrealTypeInfoReference>();
	}

	private void SetFlag(EPropertyFlags flag, bool set)
	{
		if (Flags.HasFlag(flag) != set)
		{
			Flags ^= flag;
		}
	}

	private void SetFlag(ManagedUnrealPropertyFlags flag, bool set)
	{
		if (AdditionalFlags.HasFlag(flag) != set)
		{
			AdditionalFlags ^= flag;
		}
	}

	public override void Serialize(BinaryWriter writer)
	{
		base.Serialize(writer);
		WriteEnum(writer, AdditionalFlags);
		writer.Write(FixedSizeArrayDim);
		WriteEnum(writer, Flags);
		WriteTypeReferences(writer, GenericArgs);
		WriteString(writer, RepNotifyName);
		WriteTypeReference(writer, Type);
	}

	public override void Deserialize(BinaryReader reader)
	{
		base.Deserialize(reader);
		AdditionalFlags = ReadEnum<ManagedUnrealPropertyFlags>(reader);
		FixedSizeArrayDim = reader.ReadInt32();
		Flags = ReadEnum<EPropertyFlags>(reader);
		GenericArgs = ReadTypeReferences(reader);
		RepNotifyName = ReadString(reader);
		Type = ReadTypeReference(reader);
	}
}
