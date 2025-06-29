using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AIModule.EnvQueryResult", "AIModule", UnrealModuleType.Engine)]
public struct FEnvQueryResult
{
	private static bool ItemType_IsValid;

	private static int ItemType_Offset;

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/AIModule.EnvQueryResult:ItemType")]
	public TSubclassOf<UEnvQueryItemType> ItemType;

	private static bool OptionIndex_IsValid;

	private static int OptionIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/AIModule.EnvQueryResult:OptionIndex")]
	public int OptionIndex;

	private static bool QueryID_IsValid;

	private static int QueryID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/AIModule.EnvQueryResult:QueryID")]
	public int QueryID;

	private static bool FEnvQueryResult_IsValid;

	private static int FEnvQueryResult_StructSize;

	public FEnvQueryResult Copy()
	{
		return this;
	}

	public static FEnvQueryResult FromNative(IntPtr nativeBuffer)
	{
		return new FEnvQueryResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEnvQueryResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEnvQueryResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEnvQueryResult(nativeBuffer + arrayIndex * FEnvQueryResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEnvQueryResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEnvQueryResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEnvQueryResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.EnvQueryResult");
			return;
		}
		TSubclassOfMarshaler<UEnvQueryItemType>.ToNative(IntPtr.Add(nativeStruct, ItemType_Offset), ItemType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OptionIndex_Offset), OptionIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, QueryID_Offset), QueryID);
	}

	public FEnvQueryResult(IntPtr nativeStruct)
	{
		if (!FEnvQueryResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.EnvQueryResult");
			ItemType = default(TSubclassOf<UEnvQueryItemType>);
			OptionIndex = 0;
			QueryID = 0;
		}
		else
		{
			ItemType = TSubclassOfMarshaler<UEnvQueryItemType>.FromNative(IntPtr.Add(nativeStruct, ItemType_Offset));
			OptionIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OptionIndex_Offset));
			QueryID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, QueryID_Offset));
		}
	}

	static FEnvQueryResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEnvQueryResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEnvQueryResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AIModule.EnvQueryResult");
		FEnvQueryResult_StructSize = NativeReflection.GetStructSize(intPtr);
		ItemType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemType");
		ItemType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemType", Classes.FClassProperty);
		OptionIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OptionIndex");
		OptionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OptionIndex", Classes.FIntProperty);
		QueryID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "QueryID");
		QueryID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "QueryID", Classes.FIntProperty);
		FEnvQueryResult_IsValid = intPtr != IntPtr.Zero && ItemType_IsValid && OptionIndex_IsValid && QueryID_IsValid;
		NativeReflection.LogStructIsValid("/Script/AIModule.EnvQueryResult", FEnvQueryResult_IsValid);
	}
}
