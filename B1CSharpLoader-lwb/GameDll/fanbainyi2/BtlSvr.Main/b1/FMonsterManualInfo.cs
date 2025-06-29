using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.MonsterManualInfo")]
public struct FMonsterManualInfo
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MonsterManualInfo:ScalarParameterMap")]
	public Dictionary<FName, float> ScalarParameterMap;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MonsterManualInfo:VectorParameterMap")]
	public Dictionary<FName, FLinearColor> VectorParameterMap;

	private static int MonsterManualInfo_StructSize;

	private static int MonsterManualInfo_IsValid;

	private static bool ScalarParameterMap_IsValid;

	private static int ScalarParameterMap_Offset;

	private static FFieldAddress ScalarParameterMap_PropertyAddress;

	private static bool VectorParameterMap_IsValid;

	private static int VectorParameterMap_Offset;

	private static FFieldAddress VectorParameterMap_PropertyAddress;

	public FMonsterManualInfo Copy()
	{
		FMonsterManualInfo result = this;
		if (ScalarParameterMap != null)
		{
			result.ScalarParameterMap = new Dictionary<FName, float>(ScalarParameterMap);
		}
		if (VectorParameterMap != null)
		{
			result.VectorParameterMap = new Dictionary<FName, FLinearColor>(VectorParameterMap);
		}
		return result;
	}

	public static FMonsterManualInfo FromNative(IntPtr nativeBuffer)
	{
		return new FMonsterManualInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMonsterManualInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMonsterManualInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMonsterManualInfo(IntPtr.Add(nativeBuffer, arrayIndex * MonsterManualInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMonsterManualInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MonsterManualInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MonsterManualInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MonsterManualInfo");
			return;
		}
		new TMapCopyMarshaler<FName, float>(1, ScalarParameterMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ScalarParameterMap_Offset), ScalarParameterMap);
		new TMapCopyMarshaler<FName, FLinearColor>(1, VectorParameterMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, VectorParameterMap_Offset), VectorParameterMap);
	}

	public FMonsterManualInfo(IntPtr nativeStruct)
	{
		if (MonsterManualInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MonsterManualInfo");
			ScalarParameterMap = null;
			VectorParameterMap = null;
		}
		else
		{
			ScalarParameterMap = new TMapCopyMarshaler<FName, float>(1, ScalarParameterMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ScalarParameterMap_Offset));
			VectorParameterMap = new TMapCopyMarshaler<FName, FLinearColor>(1, VectorParameterMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, VectorParameterMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MonsterManualInfo");
		MonsterManualInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ScalarParameterMap_PropertyAddress, intPtr, "ScalarParameterMap");
		ScalarParameterMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScalarParameterMap");
		ScalarParameterMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScalarParameterMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref VectorParameterMap_PropertyAddress, intPtr, "VectorParameterMap");
		VectorParameterMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "VectorParameterMap");
		VectorParameterMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VectorParameterMap", Classes.FMapProperty);
		MonsterManualInfo_IsValid = ((intPtr != IntPtr.Zero && ScalarParameterMap_IsValid && VectorParameterMap_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MonsterManualInfo", (byte)MonsterManualInfo_IsValid != 0);
	}

	static FMonsterManualInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMonsterManualInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMonsterManualInfo));
	}
}
