using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGGetLandscapeSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGGetLandscapeSettings : UPCGDataFromActorSettings
{
	private static bool GetHeightOnly_IsValid;

	private static FFieldAddress GetHeightOnly_PropertyAddress;

	private static int GetHeightOnly_Offset;

	private static bool GetLayerWeights_IsValid;

	private static FFieldAddress GetLayerWeights_PropertyAddress;

	private static int GetLayerWeights_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGGetLandscapeSettings:bGetHeightOnly")]
	public bool GetHeightOnly
	{
		get
		{
			CheckDestroyed();
			if (!GetHeightOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGetLandscapeSettings:bGetHeightOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GetHeightOnly_Offset), 0, GetHeightOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GetHeightOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGetLandscapeSettings:bGetHeightOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GetHeightOnly_Offset), 0, GetHeightOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGGetLandscapeSettings:bGetLayerWeights")]
	public bool GetLayerWeights
	{
		get
		{
			CheckDestroyed();
			if (!GetLayerWeights_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGetLandscapeSettings:bGetLayerWeights");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GetLayerWeights_Offset), 0, GetLayerWeights_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GetLayerWeights_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGetLandscapeSettings:bGetLayerWeights");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GetLayerWeights_Offset), 0, GetLayerWeights_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGGetLandscapeSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGGetLandscapeSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGGetLandscapeSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGGetLandscapeSettings");
		NativeReflectionCached.GetPropertyRef(ref GetHeightOnly_PropertyAddress, unrealStruct, "bGetHeightOnly");
		GetHeightOnly_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bGetHeightOnly");
		GetHeightOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bGetHeightOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLayerWeights_PropertyAddress, unrealStruct, "bGetLayerWeights");
		GetLayerWeights_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bGetLayerWeights");
		GetLayerWeights_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bGetLayerWeights", Classes.FBoolProperty);
	}
}
