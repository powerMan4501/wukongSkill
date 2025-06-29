using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ProceduralSpawnSceneItemConfig")]
public struct ProceduralSpawnSceneItemConfig
{
	[Category("Spawn Item Config")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnSceneItemConfig:ProceduralSpawnList")]
	public List<ProceduralSpawnSceneItemInfo> ProceduralSpawnList;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Spawn Item Config")]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnSceneItemConfig:EnablePreviewing")]
	public bool EnablePreviewing;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Spawn Item Info")]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnSceneItemConfig:SpawnRadius")]
	public float SpawnRadius;

	private static int ProceduralSpawnSceneItemConfig_StructSize;

	private static int ProceduralSpawnSceneItemConfig_IsValid;

	private static bool ProceduralSpawnList_IsValid;

	private static int ProceduralSpawnList_Offset;

	private static FFieldAddress ProceduralSpawnList_PropertyAddress;

	private static bool EnablePreviewing_IsValid;

	private static int EnablePreviewing_Offset;

	private static FFieldAddress EnablePreviewing_PropertyAddress;

	private static bool SpawnRadius_IsValid;

	private static int SpawnRadius_Offset;

	public ProceduralSpawnSceneItemConfig Copy()
	{
		ProceduralSpawnSceneItemConfig result = this;
		if (ProceduralSpawnList != null)
		{
			result.ProceduralSpawnList = new List<ProceduralSpawnSceneItemInfo>(ProceduralSpawnList);
		}
		return result;
	}

	public static ProceduralSpawnSceneItemConfig FromNative(IntPtr nativeBuffer)
	{
		return new ProceduralSpawnSceneItemConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, ProceduralSpawnSceneItemConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static ProceduralSpawnSceneItemConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new ProceduralSpawnSceneItemConfig(IntPtr.Add(nativeBuffer, arrayIndex * ProceduralSpawnSceneItemConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ProceduralSpawnSceneItemConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ProceduralSpawnSceneItemConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ProceduralSpawnSceneItemConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProceduralSpawnSceneItemConfig");
			return;
		}
		new TArrayCopyMarshaler<ProceduralSpawnSceneItemInfo>(1, ProceduralSpawnList_PropertyAddress, CachedMarshalingDelegates<ProceduralSpawnSceneItemInfo, ProceduralSpawnSceneItemInfo>.FromNative, CachedMarshalingDelegates<ProceduralSpawnSceneItemInfo, ProceduralSpawnSceneItemInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, ProceduralSpawnList_Offset), ProceduralSpawnList);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnablePreviewing_Offset), 0, EnablePreviewing_PropertyAddress.Address, EnablePreviewing);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpawnRadius_Offset), SpawnRadius);
	}

	public ProceduralSpawnSceneItemConfig(IntPtr nativeStruct)
	{
		if (ProceduralSpawnSceneItemConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProceduralSpawnSceneItemConfig");
			ProceduralSpawnList = null;
			EnablePreviewing = false;
			SpawnRadius = 0f;
		}
		else
		{
			ProceduralSpawnList = new TArrayCopyMarshaler<ProceduralSpawnSceneItemInfo>(1, ProceduralSpawnList_PropertyAddress, CachedMarshalingDelegates<ProceduralSpawnSceneItemInfo, ProceduralSpawnSceneItemInfo>.FromNative, CachedMarshalingDelegates<ProceduralSpawnSceneItemInfo, ProceduralSpawnSceneItemInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, ProceduralSpawnList_Offset));
			EnablePreviewing = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnablePreviewing_Offset), 0, EnablePreviewing_PropertyAddress.Address);
			SpawnRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpawnRadius_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ProceduralSpawnSceneItemConfig");
		ProceduralSpawnSceneItemConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ProceduralSpawnList_PropertyAddress, intPtr, "ProceduralSpawnList");
		ProceduralSpawnList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProceduralSpawnList");
		ProceduralSpawnList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProceduralSpawnList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EnablePreviewing_PropertyAddress, intPtr, "EnablePreviewing");
		EnablePreviewing_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnablePreviewing");
		EnablePreviewing_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnablePreviewing", Classes.FBoolProperty);
		SpawnRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnRadius");
		SpawnRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnRadius", Classes.FFloatProperty);
		ProceduralSpawnSceneItemConfig_IsValid = ((intPtr != IntPtr.Zero && ProceduralSpawnList_IsValid && EnablePreviewing_IsValid && SpawnRadius_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ProceduralSpawnSceneItemConfig", (byte)ProceduralSpawnSceneItemConfig_IsValid != 0);
	}

	static ProceduralSpawnSceneItemConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ProceduralSpawnSceneItemConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ProceduralSpawnSceneItemConfig));
	}
}
