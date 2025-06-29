using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSTagData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSTagData
{
	private static bool LightManagerID_IsValid;

	private static int LightManagerID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSTagData:LightManagerID")]
	public int LightManagerID;

	private static bool Index_IsValid;

	private static int Index_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSTagData:Index")]
	public int Index;

	private static bool CLSComponentType_IsValid;

	private static int CLSComponentType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSTagData:CLSComponentType")]
	public int CLSComponentType;

	private static bool FCLSTagData_IsValid;

	private static int FCLSTagData_StructSize;

	public FCLSTagData Copy()
	{
		return this;
	}

	public static FCLSTagData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSTagData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSTagData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSTagData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSTagData(nativeBuffer + arrayIndex * FCLSTagData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSTagData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSTagData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSTagData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSTagData");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LightManagerID_Offset), LightManagerID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CLSComponentType_Offset), CLSComponentType);
	}

	public FCLSTagData(IntPtr nativeStruct)
	{
		if (!FCLSTagData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSTagData");
			LightManagerID = 0;
			Index = 0;
			CLSComponentType = 0;
		}
		else
		{
			LightManagerID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LightManagerID_Offset));
			Index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Index_Offset));
			CLSComponentType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CLSComponentType_Offset));
		}
	}

	static FCLSTagData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSTagData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSTagData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSTagData");
		FCLSTagData_StructSize = NativeReflection.GetStructSize(intPtr);
		LightManagerID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightManagerID");
		LightManagerID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightManagerID", Classes.FIntProperty);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Index", Classes.FIntProperty);
		CLSComponentType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CLSComponentType");
		CLSComponentType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CLSComponentType", Classes.FIntProperty);
		FCLSTagData_IsValid = intPtr != IntPtr.Zero && LightManagerID_IsValid && Index_IsValid && CLSComponentType_IsValid;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSTagData", FCLSTagData_IsValid);
	}
}
