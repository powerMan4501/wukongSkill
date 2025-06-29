using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGCreateTargetActor", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGCreateTargetActor : UPCGSettings
{
	private static bool TemplateActorClass_IsValid;

	private static int TemplateActorClass_Offset;

	private static bool TemplateActor_IsValid;

	private static int TemplateActor_Offset;

	private static bool AllowTemplateActorEditing_IsValid;

	private static FFieldAddress AllowTemplateActorEditing_PropertyAddress;

	private static int AllowTemplateActorEditing_Offset;

	private static bool AttachOptions_IsValid;

	private static FFieldAddress AttachOptions_PropertyAddress;

	private static int AttachOptions_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/PCG.PCGCreateTargetActor:TemplateActorClass")]
	public TSubclassOf<AActor> TemplateActorClass
	{
		get
		{
			CheckDestroyed();
			if (!TemplateActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateTargetActor:TemplateActorClass");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, TemplateActorClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TemplateActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateTargetActor:TemplateActorClass");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, TemplateActorClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095063053uL)]
	[UMetaPath("/Script/PCG.PCGCreateTargetActor:TemplateActor")]
	public AActor TemplateActor
	{
		get
		{
			CheckDestroyed();
			if (!TemplateActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateTargetActor:TemplateActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, TemplateActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TemplateActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateTargetActor:TemplateActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, TemplateActor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCreateTargetActor:bAllowTemplateActorEditing")]
	public bool AllowTemplateActorEditing
	{
		get
		{
			CheckDestroyed();
			if (!AllowTemplateActorEditing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateTargetActor:bAllowTemplateActorEditing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowTemplateActorEditing_Offset), 0, AllowTemplateActorEditing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowTemplateActorEditing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateTargetActor:bAllowTemplateActorEditing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowTemplateActorEditing_Offset), 0, AllowTemplateActorEditing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCreateTargetActor:AttachOptions")]
	public EPCGAttachOptions AttachOptions
	{
		get
		{
			CheckDestroyed();
			if (!AttachOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateTargetActor:AttachOptions");
				return EPCGAttachOptions.NotAttached;
			}
			return EnumMarshaler<EPCGAttachOptions>.FromNative(IntPtr.Add(base.Address, AttachOptions_Offset), 0, AttachOptions_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateTargetActor:AttachOptions");
			}
			else
			{
				EnumMarshaler<EPCGAttachOptions>.ToNative(IntPtr.Add(base.Address, AttachOptions_Offset), 0, AttachOptions_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGCreateTargetActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGCreateTargetActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGCreateTargetActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGCreateTargetActor");
		TemplateActorClass_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TemplateActorClass");
		TemplateActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TemplateActorClass", Classes.FClassProperty);
		TemplateActor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TemplateActor");
		TemplateActor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TemplateActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowTemplateActorEditing_PropertyAddress, unrealStruct, "bAllowTemplateActorEditing");
		AllowTemplateActorEditing_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAllowTemplateActorEditing");
		AllowTemplateActorEditing_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAllowTemplateActorEditing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachOptions_PropertyAddress, unrealStruct, "AttachOptions");
		AttachOptions_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttachOptions");
		AttachOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttachOptions", Classes.FEnumProperty);
	}
}
