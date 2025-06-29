using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Niagara.NiagaraSpawnInfo", "Niagara", UnrealModuleType.EnginePlugin)]
public struct FNiagaraSpawnInfo
{
	private static bool Count_IsValid;

	private static int Count_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Niagara.NiagaraSpawnInfo:Count")]
	public int Count;

	private static bool InterpStartDt_IsValid;

	private static int InterpStartDt_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Niagara.NiagaraSpawnInfo:InterpStartDt")]
	public float InterpStartDt;

	private static bool IntervalDt_IsValid;

	private static int IntervalDt_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Niagara.NiagaraSpawnInfo:IntervalDt")]
	public float IntervalDt;

	private static bool SpawnGroup_IsValid;

	private static int SpawnGroup_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Niagara.NiagaraSpawnInfo:SpawnGroup")]
	public int SpawnGroup;

	private static bool FNiagaraSpawnInfo_IsValid;

	private static int FNiagaraSpawnInfo_StructSize;

	public FNiagaraSpawnInfo Copy()
	{
		return this;
	}

	public static FNiagaraSpawnInfo FromNative(IntPtr nativeBuffer)
	{
		return new FNiagaraSpawnInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNiagaraSpawnInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNiagaraSpawnInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNiagaraSpawnInfo(nativeBuffer + arrayIndex * FNiagaraSpawnInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNiagaraSpawnInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNiagaraSpawnInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNiagaraSpawnInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Niagara.NiagaraSpawnInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Count_Offset), Count);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InterpStartDt_Offset), InterpStartDt);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, IntervalDt_Offset), IntervalDt);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SpawnGroup_Offset), SpawnGroup);
	}

	public FNiagaraSpawnInfo(IntPtr nativeStruct)
	{
		if (!FNiagaraSpawnInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Niagara.NiagaraSpawnInfo");
			Count = 0;
			InterpStartDt = 0f;
			IntervalDt = 0f;
			SpawnGroup = 0;
		}
		else
		{
			Count = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Count_Offset));
			InterpStartDt = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InterpStartDt_Offset));
			IntervalDt = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, IntervalDt_Offset));
			SpawnGroup = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SpawnGroup_Offset));
		}
	}

	static FNiagaraSpawnInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNiagaraSpawnInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNiagaraSpawnInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Niagara.NiagaraSpawnInfo");
		FNiagaraSpawnInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Count_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Count");
		Count_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Count", Classes.FIntProperty);
		InterpStartDt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpStartDt");
		InterpStartDt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpStartDt", Classes.FFloatProperty);
		IntervalDt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IntervalDt");
		IntervalDt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IntervalDt", Classes.FFloatProperty);
		SpawnGroup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnGroup");
		SpawnGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnGroup", Classes.FIntProperty);
		FNiagaraSpawnInfo_IsValid = intPtr != IntPtr.Zero && Count_IsValid && InterpStartDt_IsValid && IntervalDt_IsValid && SpawnGroup_IsValid;
		NativeReflection.LogStructIsValid("/Script/Niagara.NiagaraSpawnInfo", FNiagaraSpawnInfo_IsValid);
	}
}
