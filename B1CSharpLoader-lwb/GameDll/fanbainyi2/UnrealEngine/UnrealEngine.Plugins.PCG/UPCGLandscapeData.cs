using System;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGLandscapeData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGLandscapeData : UPCGSurfaceData
{
	private static bool Landscapes_IsValid;

	private static FFieldAddress Landscapes_PropertyAddress;

	private static int Landscapes_Offset;

	private TArrayReadWriteMarshaler<TSoftObject<ALandscapeProxy>> Landscapes_MarshalerCached;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/PCG.PCGLandscapeData:Landscapes")]
	public TArrayReadWrite<TSoftObject<ALandscapeProxy>> Landscapes
	{
		get
		{
			CheckDestroyed();
			if (!Landscapes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGLandscapeData:Landscapes");
				return null;
			}
			if (Landscapes_MarshalerCached == null)
			{
				Landscapes_MarshalerCached = new TArrayReadWriteMarshaler<TSoftObject<ALandscapeProxy>>(1, Landscapes_PropertyAddress, CachedMarshalingDelegates<TSoftObject<ALandscapeProxy>, TSoftObjectMarshaler<ALandscapeProxy>>.FromNative, CachedMarshalingDelegates<TSoftObject<ALandscapeProxy>, TSoftObjectMarshaler<ALandscapeProxy>>.ToNative);
			}
			return Landscapes_MarshalerCached.FromNative(IntPtr.Add(base.Address, Landscapes_Offset));
		}
	}

	static UPCGLandscapeData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGLandscapeData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGLandscapeData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGLandscapeData");
		NativeReflectionCached.GetPropertyRef(ref Landscapes_PropertyAddress, unrealStruct, "Landscapes");
		Landscapes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Landscapes");
		Landscapes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Landscapes", Classes.FArrayProperty);
	}
}
