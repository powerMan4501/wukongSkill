using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ProceduralSpawnSceneItemInfo")]
public struct ProceduralSpawnSceneItemInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Spawn Item Info")]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnSceneItemInfo:SpawnClass")]
	public TSubclassOf<AActor> SpawnClass;

	private static int ProceduralSpawnSceneItemInfo_StructSize;

	private static int ProceduralSpawnSceneItemInfo_IsValid;

	private static bool SpawnClass_IsValid;

	private static int SpawnClass_Offset;

	public ProceduralSpawnSceneItemInfo Copy()
	{
		return this;
	}

	public static ProceduralSpawnSceneItemInfo FromNative(IntPtr nativeBuffer)
	{
		return new ProceduralSpawnSceneItemInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, ProceduralSpawnSceneItemInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static ProceduralSpawnSceneItemInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new ProceduralSpawnSceneItemInfo(IntPtr.Add(nativeBuffer, arrayIndex * ProceduralSpawnSceneItemInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ProceduralSpawnSceneItemInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ProceduralSpawnSceneItemInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ProceduralSpawnSceneItemInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProceduralSpawnSceneItemInfo");
		}
		else
		{
			TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, SpawnClass_Offset), SpawnClass);
		}
	}

	public ProceduralSpawnSceneItemInfo(IntPtr nativeStruct)
	{
		if (ProceduralSpawnSceneItemInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProceduralSpawnSceneItemInfo");
			SpawnClass = default(TSubclassOf<AActor>);
		}
		else
		{
			SpawnClass = TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, SpawnClass_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ProceduralSpawnSceneItemInfo");
		ProceduralSpawnSceneItemInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		SpawnClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnClass");
		SpawnClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnClass", Classes.FClassProperty);
		ProceduralSpawnSceneItemInfo_IsValid = ((intPtr != IntPtr.Zero && SpawnClass_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ProceduralSpawnSceneItemInfo", (byte)ProceduralSpawnSceneItemInfo_IsValid != 0);
	}

	static ProceduralSpawnSceneItemInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ProceduralSpawnSceneItemInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ProceduralSpawnSceneItemInfo));
	}
}
