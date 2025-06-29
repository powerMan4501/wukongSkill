using System.Collections.Generic;
using System.IO;

namespace UnrealEngine.Runtime;

public class ManagedUnrealFunctionInfo : ManagedUnrealReflectionBase
{
	public ManagedUnrealPropertyInfo ReturnProp { get; set; }

	public List<ManagedUnrealPropertyInfo> Params { get; set; }

	public ManagedUnrealFunctionFlags AdditionalFlags { get; set; }

	[ManagedUnrealReflectIgnore]
	public bool IsVirtual
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealFunctionFlags.Virtual);
		}
		set
		{
			SetFlag(ManagedUnrealFunctionFlags.Virtual, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsOverride
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealFunctionFlags.Override);
		}
		set
		{
			SetFlag(ManagedUnrealFunctionFlags.Override, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsBlueprintImplemented
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealFunctionFlags.BlueprintImplemented);
		}
		set
		{
			SetFlag(ManagedUnrealFunctionFlags.BlueprintImplemented, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsImplementation
	{
		get
		{
			return AdditionalFlags.HasFlag(ManagedUnrealFunctionFlags.Implementation);
		}
		set
		{
			SetFlag(ManagedUnrealFunctionFlags.Implementation, value);
		}
	}

	public EFunctionFlags Flags { get; set; }

	[ManagedUnrealReflectIgnore]
	public bool IsStatic
	{
		get
		{
			return Flags.HasFlag(EFunctionFlags.Static);
		}
		set
		{
			SetFlag(EFunctionFlags.Static, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsBlueprintEvent
	{
		get
		{
			return Flags.HasFlag(EFunctionFlags.BlueprintEvent);
		}
		set
		{
			SetFlag(EFunctionFlags.BlueprintEvent, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool IsRPC
	{
		get
		{
			return Flags.HasFlag(EFunctionFlags.Net);
		}
		set
		{
			SetFlag(EFunctionFlags.Net, value);
		}
	}

	[ManagedUnrealReflectIgnore]
	public bool WithValidation
	{
		get
		{
			return Flags.HasFlag(EFunctionFlags.NetValidate);
		}
		set
		{
			SetFlag(EFunctionFlags.NetValidate, value);
		}
	}

	public string OriginalName { get; set; }

	public string GetName()
	{
		if (!string.IsNullOrEmpty(OriginalName))
		{
			return OriginalName;
		}
		return base.Name;
	}

	private void SetFlag(EFunctionFlags flag, bool set)
	{
		if (Flags.HasFlag(flag) != set)
		{
			Flags ^= flag;
		}
	}

	private void SetFlag(ManagedUnrealFunctionFlags flag, bool set)
	{
		if (AdditionalFlags.HasFlag(flag) != set)
		{
			AdditionalFlags ^= flag;
		}
	}

	public ManagedUnrealFunctionInfo()
	{
		Params = new List<ManagedUnrealPropertyInfo>();
	}

	public override void Serialize(BinaryWriter writer)
	{
		base.Serialize(writer);
		WriteEnum(writer, AdditionalFlags);
		WriteEnum(writer, Flags);
		WriteString(writer, OriginalName);
		WriteObjects(writer, Params);
		WriteObject(writer, ReturnProp);
	}

	public override void Deserialize(BinaryReader reader)
	{
		base.Deserialize(reader);
		AdditionalFlags = ReadEnum<ManagedUnrealFunctionFlags>(reader);
		Flags = ReadEnum<EFunctionFlags>(reader);
		OriginalName = ReadString(reader);
		Params = ReadObjects<ManagedUnrealPropertyInfo>(reader);
		ReturnProp = ReadObject<ManagedUnrealPropertyInfo>(reader);
	}
}
