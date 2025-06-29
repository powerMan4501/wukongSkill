using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/Water.BuoyancyData", "Water", UnrealModuleType.EnginePlugin)]
public struct FBuoyancyData
{
	private static bool Pontoons_IsValid;

	private static FFieldAddress Pontoons_PropertyAddress;

	private static int Pontoons_Offset;

	[UProperty(Flags = (PropFlags)4504149383250453uL)]
	[UMetaPath("/Script/Water.BuoyancyData:Pontoons")]
	public List<FSphericalPontoon> Pontoons;

	private static bool FBuoyancyData_IsValid;

	private static int FBuoyancyData_StructSize;

	public FBuoyancyData Copy()
	{
		FBuoyancyData result = this;
		if (Pontoons != null)
		{
			result.Pontoons = new List<FSphericalPontoon>(Pontoons);
		}
		return result;
	}

	public static FBuoyancyData FromNative(IntPtr nativeBuffer)
	{
		return new FBuoyancyData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBuoyancyData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBuoyancyData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBuoyancyData(nativeBuffer + arrayIndex * FBuoyancyData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBuoyancyData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBuoyancyData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBuoyancyData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.BuoyancyData");
		}
		else
		{
			new TArrayCopyMarshaler<FSphericalPontoon>(1, Pontoons_PropertyAddress, CachedMarshalingDelegates<FSphericalPontoon, FSphericalPontoon>.FromNative, CachedMarshalingDelegates<FSphericalPontoon, FSphericalPontoon>.ToNative).ToNative(IntPtr.Add(nativeStruct, Pontoons_Offset), Pontoons);
		}
	}

	public FBuoyancyData(IntPtr nativeStruct)
	{
		if (!FBuoyancyData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.BuoyancyData");
			Pontoons = null;
		}
		else
		{
			Pontoons = new TArrayCopyMarshaler<FSphericalPontoon>(1, Pontoons_PropertyAddress, CachedMarshalingDelegates<FSphericalPontoon, FSphericalPontoon>.FromNative, CachedMarshalingDelegates<FSphericalPontoon, FSphericalPontoon>.ToNative).FromNative(IntPtr.Add(nativeStruct, Pontoons_Offset));
		}
	}

	static FBuoyancyData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBuoyancyData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBuoyancyData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.BuoyancyData");
		FBuoyancyData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Pontoons_PropertyAddress, intPtr, "Pontoons");
		Pontoons_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pontoons");
		Pontoons_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pontoons", Classes.FArrayProperty);
		FBuoyancyData_IsValid = intPtr != IntPtr.Zero && Pontoons_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.BuoyancyData", FBuoyancyData_IsValid);
	}
}
