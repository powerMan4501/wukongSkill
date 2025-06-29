using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DynamicTamerSpawnReq")]
public struct FDynamicTamerSpawnReq
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.DynamicTamerSpawnReq:TamerGuidOverride")]
	public string TamerGuidOverride;

	[UProperty]
	[USharpPath("/Script/b1-Managed.DynamicTamerSpawnReq:TamerClass")]
	public TSubclassOf<BUTamerActor> TamerClass;

	[UProperty]
	[USharpPath("/Script/b1-Managed.DynamicTamerSpawnReq:SpawnWorldTransform")]
	public FTransform SpawnWorldTransform;

	[UProperty]
	[USharpPath("/Script/b1-Managed.DynamicTamerSpawnReq:TriggerSpawnActor")]
	public AActor TriggerSpawnActor;

	private static int DynamicTamerSpawnReq_StructSize;

	private static int DynamicTamerSpawnReq_IsValid;

	private static bool TamerGuidOverride_IsValid;

	private static int TamerGuidOverride_Offset;

	private static bool TamerClass_IsValid;

	private static int TamerClass_Offset;

	private static bool SpawnWorldTransform_IsValid;

	private static int SpawnWorldTransform_Offset;

	private static bool TriggerSpawnActor_IsValid;

	private static int TriggerSpawnActor_Offset;

	public FDynamicTamerSpawnReq Copy()
	{
		return this;
	}

	public static FDynamicTamerSpawnReq FromNative(IntPtr nativeBuffer)
	{
		return new FDynamicTamerSpawnReq(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDynamicTamerSpawnReq value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDynamicTamerSpawnReq FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDynamicTamerSpawnReq(IntPtr.Add(nativeBuffer, arrayIndex * DynamicTamerSpawnReq_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDynamicTamerSpawnReq value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DynamicTamerSpawnReq_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DynamicTamerSpawnReq_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DynamicTamerSpawnReq");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, TamerGuidOverride_Offset), TamerGuidOverride);
		TSubclassOfMarshaler<BUTamerActor>.ToNative(IntPtr.Add(nativeStruct, TamerClass_Offset), TamerClass);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, SpawnWorldTransform_Offset), SpawnWorldTransform);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, TriggerSpawnActor_Offset), TriggerSpawnActor);
	}

	public FDynamicTamerSpawnReq(IntPtr nativeStruct)
	{
		if (DynamicTamerSpawnReq_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DynamicTamerSpawnReq");
			TamerGuidOverride = null;
			TamerClass = default(TSubclassOf<BUTamerActor>);
			SpawnWorldTransform = default(FTransform);
			TriggerSpawnActor = null;
		}
		else
		{
			TamerGuidOverride = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, TamerGuidOverride_Offset));
			TamerClass = TSubclassOfMarshaler<BUTamerActor>.FromNative(IntPtr.Add(nativeStruct, TamerClass_Offset));
			SpawnWorldTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, SpawnWorldTransform_Offset));
			TriggerSpawnActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, TriggerSpawnActor_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DynamicTamerSpawnReq");
		DynamicTamerSpawnReq_StructSize = NativeReflection.GetStructSize(intPtr);
		TamerGuidOverride_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerGuidOverride");
		TamerGuidOverride_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerGuidOverride", Classes.FStrProperty);
		TamerClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerClass");
		TamerClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerClass", Classes.FClassProperty);
		SpawnWorldTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnWorldTransform");
		SpawnWorldTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnWorldTransform", Classes.FStructProperty);
		TriggerSpawnActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerSpawnActor");
		TriggerSpawnActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerSpawnActor", Classes.FObjectProperty);
		DynamicTamerSpawnReq_IsValid = ((intPtr != IntPtr.Zero && TamerGuidOverride_IsValid && TamerClass_IsValid && SpawnWorldTransform_IsValid && TriggerSpawnActor_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DynamicTamerSpawnReq", (byte)DynamicTamerSpawnReq_IsValid != 0);
	}

	static FDynamicTamerSpawnReq()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDynamicTamerSpawnReq)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDynamicTamerSpawnReq));
	}
}
