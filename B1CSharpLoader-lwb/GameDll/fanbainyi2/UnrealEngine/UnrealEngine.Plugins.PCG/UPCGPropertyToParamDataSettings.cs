using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPropertyToParamDataSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGPropertyToParamDataSettings : UPCGSettings
{
	private static bool ActorSelector_IsValid;

	private static int ActorSelector_Offset;

	private static bool SelectComponent_IsValid;

	private static FFieldAddress SelectComponent_PropertyAddress;

	private static int SelectComponent_Offset;

	private static bool ComponentClass_IsValid;

	private static int ComponentClass_Offset;

	private static bool PropertyName_IsValid;

	private static int PropertyName_Offset;

	private static bool ExtractObjectAndStruct_IsValid;

	private static FFieldAddress ExtractObjectAndStruct_PropertyAddress;

	private static int ExtractObjectAndStruct_Offset;

	private static bool OutputAttributeName_IsValid;

	private static int OutputAttributeName_Offset;

	private static bool AlwaysRequeryActors_IsValid;

	private static FFieldAddress AlwaysRequeryActors_PropertyAddress;

	private static int AlwaysRequeryActors_Offset;

	private static bool TrackActorsOnlyWithinBounds_IsValid;

	private static FFieldAddress TrackActorsOnlyWithinBounds_PropertyAddress;

	private static int TrackActorsOnlyWithinBounds_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/PCG.PCGPropertyToParamDataSettings:ActorSelector")]
	public FPCGActorSelectorSettings ActorSelector
	{
		get
		{
			CheckDestroyed();
			if (!ActorSelector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:ActorSelector");
				return default(FPCGActorSelectorSettings);
			}
			return FPCGActorSelectorSettings.FromNative(IntPtr.Add(base.Address, ActorSelector_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorSelector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:ActorSelector");
			}
			else
			{
				FPCGActorSelectorSettings.ToNative(IntPtr.Add(base.Address, ActorSelector_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPropertyToParamDataSettings:bSelectComponent")]
	public bool SelectComponent
	{
		get
		{
			CheckDestroyed();
			if (!SelectComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:bSelectComponent");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SelectComponent_Offset), 0, SelectComponent_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SelectComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:bSelectComponent");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SelectComponent_Offset), 0, SelectComponent_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/PCG.PCGPropertyToParamDataSettings:ComponentClass")]
	public TSubclassOf<UActorComponent> ComponentClass
	{
		get
		{
			CheckDestroyed();
			if (!ComponentClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:ComponentClass");
				return default(TSubclassOf<UActorComponent>);
			}
			return TSubclassOfMarshaler<UActorComponent>.FromNative(IntPtr.Add(base.Address, ComponentClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ComponentClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:ComponentClass");
			}
			else
			{
				TSubclassOfMarshaler<UActorComponent>.ToNative(IntPtr.Add(base.Address, ComponentClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPropertyToParamDataSettings:PropertyName")]
	public FName PropertyName
	{
		get
		{
			CheckDestroyed();
			if (!PropertyName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:PropertyName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, PropertyName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PropertyName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:PropertyName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, PropertyName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPropertyToParamDataSettings:bExtractObjectAndStruct")]
	public bool ExtractObjectAndStruct
	{
		get
		{
			CheckDestroyed();
			if (!ExtractObjectAndStruct_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:bExtractObjectAndStruct");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExtractObjectAndStruct_Offset), 0, ExtractObjectAndStruct_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExtractObjectAndStruct_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:bExtractObjectAndStruct");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExtractObjectAndStruct_Offset), 0, ExtractObjectAndStruct_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPropertyToParamDataSettings:OutputAttributeName")]
	public FName OutputAttributeName
	{
		get
		{
			CheckDestroyed();
			if (!OutputAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:OutputAttributeName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OutputAttributeName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:OutputAttributeName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OutputAttributeName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPropertyToParamDataSettings:bAlwaysRequeryActors")]
	public bool AlwaysRequeryActors
	{
		get
		{
			CheckDestroyed();
			if (!AlwaysRequeryActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:bAlwaysRequeryActors");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwaysRequeryActors_Offset), 0, AlwaysRequeryActors_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwaysRequeryActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:bAlwaysRequeryActors");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwaysRequeryActors_Offset), 0, AlwaysRequeryActors_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013205uL)]
	[UMetaPath("/Script/PCG.PCGPropertyToParamDataSettings:bTrackActorsOnlyWithinBounds")]
	public bool TrackActorsOnlyWithinBounds
	{
		get
		{
			CheckDestroyed();
			if (!TrackActorsOnlyWithinBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:bTrackActorsOnlyWithinBounds");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TrackActorsOnlyWithinBounds_Offset), 0, TrackActorsOnlyWithinBounds_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TrackActorsOnlyWithinBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPropertyToParamDataSettings:bTrackActorsOnlyWithinBounds");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TrackActorsOnlyWithinBounds_Offset), 0, TrackActorsOnlyWithinBounds_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGPropertyToParamDataSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGPropertyToParamDataSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGPropertyToParamDataSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGPropertyToParamDataSettings");
		ActorSelector_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ActorSelector");
		ActorSelector_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ActorSelector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectComponent_PropertyAddress, unrealStruct, "bSelectComponent");
		SelectComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bSelectComponent");
		SelectComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bSelectComponent", Classes.FBoolProperty);
		ComponentClass_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ComponentClass");
		ComponentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ComponentClass", Classes.FClassProperty);
		PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PropertyName");
		PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractObjectAndStruct_PropertyAddress, unrealStruct, "bExtractObjectAndStruct");
		ExtractObjectAndStruct_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bExtractObjectAndStruct");
		ExtractObjectAndStruct_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bExtractObjectAndStruct", Classes.FBoolProperty);
		OutputAttributeName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutputAttributeName");
		OutputAttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutputAttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AlwaysRequeryActors_PropertyAddress, unrealStruct, "bAlwaysRequeryActors");
		AlwaysRequeryActors_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAlwaysRequeryActors");
		AlwaysRequeryActors_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAlwaysRequeryActors", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TrackActorsOnlyWithinBounds_PropertyAddress, unrealStruct, "bTrackActorsOnlyWithinBounds");
		TrackActorsOnlyWithinBounds_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bTrackActorsOnlyWithinBounds");
		TrackActorsOnlyWithinBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bTrackActorsOnlyWithinBounds", Classes.FBoolProperty);
	}
}
