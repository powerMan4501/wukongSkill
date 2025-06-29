using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGDataFromActorSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGDataFromActorSettings : UPCGSettings
{
	private static bool ActorSelector_IsValid;

	private static int ActorSelector_Offset;

	private static bool Mode_IsValid;

	private static FFieldAddress Mode_PropertyAddress;

	private static int Mode_Offset;

	private static bool MergeSinglePointData_IsValid;

	private static FFieldAddress MergeSinglePointData_PropertyAddress;

	private static int MergeSinglePointData_Offset;

	private static bool ExpectedPins_IsValid;

	private static FFieldAddress ExpectedPins_PropertyAddress;

	private static int ExpectedPins_Offset;

	private TArrayReadWriteMarshaler<FName> ExpectedPins_MarshalerCached;

	private static bool PropertyName_IsValid;

	private static int PropertyName_Offset;

	private static bool TrackActorsOnlyWithinBounds_IsValid;

	private static FFieldAddress TrackActorsOnlyWithinBounds_PropertyAddress;

	private static int TrackActorsOnlyWithinBounds_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/PCG.PCGDataFromActorSettings:ActorSelector")]
	public FPCGActorSelectorSettings ActorSelector
	{
		get
		{
			CheckDestroyed();
			if (!ActorSelector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataFromActorSettings:ActorSelector");
				return default(FPCGActorSelectorSettings);
			}
			return FPCGActorSelectorSettings.FromNative(IntPtr.Add(base.Address, ActorSelector_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorSelector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataFromActorSettings:ActorSelector");
			}
			else
			{
				FPCGActorSelectorSettings.ToNative(IntPtr.Add(base.Address, ActorSelector_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDataFromActorSettings:Mode")]
	public EPCGGetDataFromActorMode Mode
	{
		get
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataFromActorSettings:Mode");
				return EPCGGetDataFromActorMode.ParseActorComponents;
			}
			return EnumMarshaler<EPCGGetDataFromActorMode>.FromNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataFromActorSettings:Mode");
			}
			else
			{
				EnumMarshaler<EPCGGetDataFromActorMode>.ToNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDataFromActorSettings:bMergeSinglePointData")]
	public bool MergeSinglePointData
	{
		get
		{
			CheckDestroyed();
			if (!MergeSinglePointData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataFromActorSettings:bMergeSinglePointData");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MergeSinglePointData_Offset), 0, MergeSinglePointData_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MergeSinglePointData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataFromActorSettings:bMergeSinglePointData");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MergeSinglePointData_Offset), 0, MergeSinglePointData_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGDataFromActorSettings:ExpectedPins")]
	public TArrayReadWrite<FName> ExpectedPins
	{
		get
		{
			CheckDestroyed();
			if (!ExpectedPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataFromActorSettings:ExpectedPins");
				return null;
			}
			if (ExpectedPins_MarshalerCached == null)
			{
				ExpectedPins_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, ExpectedPins_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return ExpectedPins_MarshalerCached.FromNative(IntPtr.Add(base.Address, ExpectedPins_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDataFromActorSettings:PropertyName")]
	public FName PropertyName
	{
		get
		{
			CheckDestroyed();
			if (!PropertyName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataFromActorSettings:PropertyName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, PropertyName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PropertyName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataFromActorSettings:PropertyName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, PropertyName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013205uL)]
	[UMetaPath("/Script/PCG.PCGDataFromActorSettings:bTrackActorsOnlyWithinBounds")]
	public bool TrackActorsOnlyWithinBounds
	{
		get
		{
			CheckDestroyed();
			if (!TrackActorsOnlyWithinBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataFromActorSettings:bTrackActorsOnlyWithinBounds");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TrackActorsOnlyWithinBounds_Offset), 0, TrackActorsOnlyWithinBounds_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TrackActorsOnlyWithinBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDataFromActorSettings:bTrackActorsOnlyWithinBounds");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TrackActorsOnlyWithinBounds_Offset), 0, TrackActorsOnlyWithinBounds_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGDataFromActorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGDataFromActorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGDataFromActorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGDataFromActorSettings");
		ActorSelector_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ActorSelector");
		ActorSelector_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ActorSelector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Mode_PropertyAddress, unrealStruct, "Mode");
		Mode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Mode");
		Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Mode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeSinglePointData_PropertyAddress, unrealStruct, "bMergeSinglePointData");
		MergeSinglePointData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bMergeSinglePointData");
		MergeSinglePointData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bMergeSinglePointData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExpectedPins_PropertyAddress, unrealStruct, "ExpectedPins");
		ExpectedPins_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExpectedPins");
		ExpectedPins_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExpectedPins", Classes.FArrayProperty);
		PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PropertyName");
		PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref TrackActorsOnlyWithinBounds_PropertyAddress, unrealStruct, "bTrackActorsOnlyWithinBounds");
		TrackActorsOnlyWithinBounds_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bTrackActorsOnlyWithinBounds");
		TrackActorsOnlyWithinBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bTrackActorsOnlyWithinBounds", Classes.FBoolProperty);
	}
}
