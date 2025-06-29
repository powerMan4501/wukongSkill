using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/TressFX.TressFXStrandStyleParameter", "TressFX", UnrealModuleType.GamePlugin)]
public struct FTressFXStrandStyleParameter
{
	private static bool StrandLength_IsValid;

	private static int StrandLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXStrandStyleParameter:StrandLength")]
	public float StrandLength;

	private static bool StrandClumpScale_IsValid;

	private static int StrandClumpScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXStrandStyleParameter:StrandClumpScale")]
	public float StrandClumpScale;

	private static bool StrandClumpRoughness_IsValid;

	private static int StrandClumpRoughness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXStrandStyleParameter:StrandClumpRoughness")]
	public float StrandClumpRoughness;

	private static bool StrandClumpNoise_IsValid;

	private static int StrandClumpNoise_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXStrandStyleParameter:StrandClumpNoise")]
	public float StrandClumpNoise;

	private static bool StrandStiffnessTip_IsValid;

	private static int StrandStiffnessTip_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXStrandStyleParameter:StrandStiffnessTip")]
	public float StrandStiffnessTip;

	private static bool StrandStiffnessRoot_IsValid;

	private static int StrandStiffnessRoot_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXStrandStyleParameter:StrandStiffnessRoot")]
	public float StrandStiffnessRoot;

	private static bool FTressFXStrandStyleParameter_IsValid;

	private static int FTressFXStrandStyleParameter_StructSize;

	public FTressFXStrandStyleParameter Copy()
	{
		return this;
	}

	public static FTressFXStrandStyleParameter FromNative(IntPtr nativeBuffer)
	{
		return new FTressFXStrandStyleParameter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTressFXStrandStyleParameter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTressFXStrandStyleParameter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTressFXStrandStyleParameter(nativeBuffer + arrayIndex * FTressFXStrandStyleParameter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTressFXStrandStyleParameter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTressFXStrandStyleParameter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTressFXStrandStyleParameter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TressFX.TressFXStrandStyleParameter");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StrandLength_Offset), StrandLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StrandClumpScale_Offset), StrandClumpScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StrandClumpRoughness_Offset), StrandClumpRoughness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StrandClumpNoise_Offset), StrandClumpNoise);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StrandStiffnessTip_Offset), StrandStiffnessTip);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StrandStiffnessRoot_Offset), StrandStiffnessRoot);
	}

	public FTressFXStrandStyleParameter(IntPtr nativeStruct)
	{
		if (!FTressFXStrandStyleParameter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TressFX.TressFXStrandStyleParameter");
			StrandLength = 0f;
			StrandClumpScale = 0f;
			StrandClumpRoughness = 0f;
			StrandClumpNoise = 0f;
			StrandStiffnessTip = 0f;
			StrandStiffnessRoot = 0f;
		}
		else
		{
			StrandLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StrandLength_Offset));
			StrandClumpScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StrandClumpScale_Offset));
			StrandClumpRoughness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StrandClumpRoughness_Offset));
			StrandClumpNoise = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StrandClumpNoise_Offset));
			StrandStiffnessTip = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StrandStiffnessTip_Offset));
			StrandStiffnessRoot = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StrandStiffnessRoot_Offset));
		}
	}

	static FTressFXStrandStyleParameter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTressFXStrandStyleParameter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTressFXStrandStyleParameter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TressFX.TressFXStrandStyleParameter");
		FTressFXStrandStyleParameter_StructSize = NativeReflection.GetStructSize(intPtr);
		StrandLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StrandLength");
		StrandLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StrandLength", Classes.FFloatProperty);
		StrandClumpScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StrandClumpScale");
		StrandClumpScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StrandClumpScale", Classes.FFloatProperty);
		StrandClumpRoughness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StrandClumpRoughness");
		StrandClumpRoughness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StrandClumpRoughness", Classes.FFloatProperty);
		StrandClumpNoise_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StrandClumpNoise");
		StrandClumpNoise_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StrandClumpNoise", Classes.FFloatProperty);
		StrandStiffnessTip_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StrandStiffnessTip");
		StrandStiffnessTip_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StrandStiffnessTip", Classes.FFloatProperty);
		StrandStiffnessRoot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StrandStiffnessRoot");
		StrandStiffnessRoot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StrandStiffnessRoot", Classes.FFloatProperty);
		FTressFXStrandStyleParameter_IsValid = intPtr != IntPtr.Zero && StrandLength_IsValid && StrandClumpScale_IsValid && StrandClumpRoughness_IsValid && StrandClumpNoise_IsValid && StrandStiffnessTip_IsValid && StrandStiffnessRoot_IsValid;
		NativeReflection.LogStructIsValid("/Script/TressFX.TressFXStrandStyleParameter", FTressFXStrandStyleParameter_IsValid);
	}
}
