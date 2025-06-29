using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSpawnActorSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSpawnActorSettings : UPCGBaseSubgraphSettings
{
	private static bool TemplateActorClass_IsValid;

	private static int TemplateActorClass_Offset;

	private static bool PostSpawnFunctionNames_IsValid;

	private static FFieldAddress PostSpawnFunctionNames_PropertyAddress;

	private static int PostSpawnFunctionNames_Offset;

	private TArrayReadWriteMarshaler<FName> PostSpawnFunctionNames_MarshalerCached;

	private static bool Option_IsValid;

	private static FFieldAddress Option_PropertyAddress;

	private static int Option_Offset;

	private static bool ForceDisableActorParsing_IsValid;

	private static FFieldAddress ForceDisableActorParsing_PropertyAddress;

	private static int ForceDisableActorParsing_Offset;

	private static bool GenerationTrigger_IsValid;

	private static FFieldAddress GenerationTrigger_PropertyAddress;

	private static int GenerationTrigger_Offset;

	private static bool InheritActorTags_IsValid;

	private static FFieldAddress InheritActorTags_PropertyAddress;

	private static int InheritActorTags_Offset;

	private static bool TagsToAddOnActors_IsValid;

	private static FFieldAddress TagsToAddOnActors_PropertyAddress;

	private static int TagsToAddOnActors_Offset;

	private TArrayReadWriteMarshaler<FName> TagsToAddOnActors_MarshalerCached;

	private static bool AllowTemplateActorEditing_IsValid;

	private static FFieldAddress AllowTemplateActorEditing_PropertyAddress;

	private static int AllowTemplateActorEditing_Offset;

	private static bool TemplateActor_IsValid;

	private static int TemplateActor_Offset;

	private static bool ActorOverrides_IsValid;

	private static FFieldAddress ActorOverrides_PropertyAddress;

	private static int ActorOverrides_Offset;

	private TArrayReadWriteMarshaler<FPCGActorPropertyOverride> ActorOverrides_MarshalerCached;

	private static bool AttachOptions_IsValid;

	private static FFieldAddress AttachOptions_PropertyAddress;

	private static int AttachOptions_Offset;

	private static bool SpawnByAttribute_IsValid;

	private static FFieldAddress SpawnByAttribute_PropertyAddress;

	private static int SpawnByAttribute_Offset;

	private static bool SpawnAttribute_IsValid;

	private static int SpawnAttribute_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:TemplateActorClass")]
	public TSubclassOf<AActor> TemplateActorClass
	{
		get
		{
			CheckDestroyed();
			if (!TemplateActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:TemplateActorClass");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, TemplateActorClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TemplateActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:TemplateActorClass");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, TemplateActorClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:PostSpawnFunctionNames")]
	public TArrayReadWrite<FName> PostSpawnFunctionNames
	{
		get
		{
			CheckDestroyed();
			if (!PostSpawnFunctionNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:PostSpawnFunctionNames");
				return null;
			}
			if (PostSpawnFunctionNames_MarshalerCached == null)
			{
				PostSpawnFunctionNames_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, PostSpawnFunctionNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return PostSpawnFunctionNames_MarshalerCached.FromNative(IntPtr.Add(base.Address, PostSpawnFunctionNames_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:Option")]
	public EPCGSpawnActorOption Option
	{
		get
		{
			CheckDestroyed();
			if (!Option_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:Option");
				return EPCGSpawnActorOption.CollapseActors;
			}
			return EnumMarshaler<EPCGSpawnActorOption>.FromNative(IntPtr.Add(base.Address, Option_Offset), 0, Option_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Option_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:Option");
			}
			else
			{
				EnumMarshaler<EPCGSpawnActorOption>.ToNative(IntPtr.Add(base.Address, Option_Offset), 0, Option_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:bForceDisableActorParsing")]
	public bool ForceDisableActorParsing
	{
		get
		{
			CheckDestroyed();
			if (!ForceDisableActorParsing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:bForceDisableActorParsing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceDisableActorParsing_Offset), 0, ForceDisableActorParsing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceDisableActorParsing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:bForceDisableActorParsing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceDisableActorParsing_Offset), 0, ForceDisableActorParsing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:GenerationTrigger")]
	public EPCGSpawnActorGenerationTrigger GenerationTrigger
	{
		get
		{
			CheckDestroyed();
			if (!GenerationTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:GenerationTrigger");
				return EPCGSpawnActorGenerationTrigger.Default;
			}
			return EnumMarshaler<EPCGSpawnActorGenerationTrigger>.FromNative(IntPtr.Add(base.Address, GenerationTrigger_Offset), 0, GenerationTrigger_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GenerationTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:GenerationTrigger");
			}
			else
			{
				EnumMarshaler<EPCGSpawnActorGenerationTrigger>.ToNative(IntPtr.Add(base.Address, GenerationTrigger_Offset), 0, GenerationTrigger_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:bInheritActorTags")]
	public bool InheritActorTags
	{
		get
		{
			CheckDestroyed();
			if (!InheritActorTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:bInheritActorTags");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InheritActorTags_Offset), 0, InheritActorTags_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InheritActorTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:bInheritActorTags");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InheritActorTags_Offset), 0, InheritActorTags_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:TagsToAddOnActors")]
	public TArrayReadWrite<FName> TagsToAddOnActors
	{
		get
		{
			CheckDestroyed();
			if (!TagsToAddOnActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:TagsToAddOnActors");
				return null;
			}
			if (TagsToAddOnActors_MarshalerCached == null)
			{
				TagsToAddOnActors_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, TagsToAddOnActors_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return TagsToAddOnActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, TagsToAddOnActors_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:bAllowTemplateActorEditing")]
	public bool AllowTemplateActorEditing
	{
		get
		{
			CheckDestroyed();
			if (!AllowTemplateActorEditing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:bAllowTemplateActorEditing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowTemplateActorEditing_Offset), 0, AllowTemplateActorEditing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowTemplateActorEditing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:bAllowTemplateActorEditing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowTemplateActorEditing_Offset), 0, AllowTemplateActorEditing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095063053uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:TemplateActor")]
	public AActor TemplateActor
	{
		get
		{
			CheckDestroyed();
			if (!TemplateActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:TemplateActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, TemplateActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TemplateActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:TemplateActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, TemplateActor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:ActorOverrides")]
	public TArrayReadWrite<FPCGActorPropertyOverride> ActorOverrides
	{
		get
		{
			CheckDestroyed();
			if (!ActorOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:ActorOverrides");
				return null;
			}
			if (ActorOverrides_MarshalerCached == null)
			{
				ActorOverrides_MarshalerCached = new TArrayReadWriteMarshaler<FPCGActorPropertyOverride>(1, ActorOverrides_PropertyAddress, CachedMarshalingDelegates<FPCGActorPropertyOverride, FPCGActorPropertyOverride>.FromNative, CachedMarshalingDelegates<FPCGActorPropertyOverride, FPCGActorPropertyOverride>.ToNative);
			}
			return ActorOverrides_MarshalerCached.FromNative(IntPtr.Add(base.Address, ActorOverrides_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:AttachOptions")]
	public EPCGAttachOptions AttachOptions
	{
		get
		{
			CheckDestroyed();
			if (!AttachOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:AttachOptions");
				return EPCGAttachOptions.NotAttached;
			}
			return EnumMarshaler<EPCGAttachOptions>.FromNative(IntPtr.Add(base.Address, AttachOptions_Offset), 0, AttachOptions_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:AttachOptions");
			}
			else
			{
				EnumMarshaler<EPCGAttachOptions>.ToNative(IntPtr.Add(base.Address, AttachOptions_Offset), 0, AttachOptions_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:bSpawnByAttribute")]
	public bool SpawnByAttribute
	{
		get
		{
			CheckDestroyed();
			if (!SpawnByAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:bSpawnByAttribute");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SpawnByAttribute_Offset), 0, SpawnByAttribute_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpawnByAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:bSpawnByAttribute");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SpawnByAttribute_Offset), 0, SpawnByAttribute_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSpawnActorSettings:SpawnAttribute")]
	public FName SpawnAttribute
	{
		get
		{
			CheckDestroyed();
			if (!SpawnAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:SpawnAttribute");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SpawnAttribute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpawnActorSettings:SpawnAttribute");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SpawnAttribute_Offset), value);
			}
		}
	}

	static UPCGSpawnActorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSpawnActorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSpawnActorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGSpawnActorSettings");
		TemplateActorClass_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TemplateActorClass");
		TemplateActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TemplateActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref PostSpawnFunctionNames_PropertyAddress, unrealStruct, "PostSpawnFunctionNames");
		PostSpawnFunctionNames_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PostSpawnFunctionNames");
		PostSpawnFunctionNames_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PostSpawnFunctionNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Option_PropertyAddress, unrealStruct, "Option");
		Option_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Option");
		Option_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Option", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceDisableActorParsing_PropertyAddress, unrealStruct, "bForceDisableActorParsing");
		ForceDisableActorParsing_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bForceDisableActorParsing");
		ForceDisableActorParsing_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bForceDisableActorParsing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerationTrigger_PropertyAddress, unrealStruct, "GenerationTrigger");
		GenerationTrigger_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GenerationTrigger");
		GenerationTrigger_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GenerationTrigger", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref InheritActorTags_PropertyAddress, unrealStruct, "bInheritActorTags");
		InheritActorTags_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bInheritActorTags");
		InheritActorTags_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bInheritActorTags", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TagsToAddOnActors_PropertyAddress, unrealStruct, "TagsToAddOnActors");
		TagsToAddOnActors_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TagsToAddOnActors");
		TagsToAddOnActors_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TagsToAddOnActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowTemplateActorEditing_PropertyAddress, unrealStruct, "bAllowTemplateActorEditing");
		AllowTemplateActorEditing_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAllowTemplateActorEditing");
		AllowTemplateActorEditing_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAllowTemplateActorEditing", Classes.FBoolProperty);
		TemplateActor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TemplateActor");
		TemplateActor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TemplateActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorOverrides_PropertyAddress, unrealStruct, "ActorOverrides");
		ActorOverrides_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ActorOverrides");
		ActorOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ActorOverrides", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachOptions_PropertyAddress, unrealStruct, "AttachOptions");
		AttachOptions_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttachOptions");
		AttachOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttachOptions", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnByAttribute_PropertyAddress, unrealStruct, "bSpawnByAttribute");
		SpawnByAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bSpawnByAttribute");
		SpawnByAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bSpawnByAttribute", Classes.FBoolProperty);
		SpawnAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpawnAttribute");
		SpawnAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpawnAttribute", Classes.FNameProperty);
	}
}
