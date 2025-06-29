using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGLandscapeLayerWeight", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGLandscapeLayerWeight
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGLandscapeLayerWeight:Name")]
	public FName Name;

	private static bool Weight_IsValid;

	private static int Weight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGLandscapeLayerWeight:Weight")]
	public float Weight;

	private static bool FPCGLandscapeLayerWeight_IsValid;

	private static int FPCGLandscapeLayerWeight_StructSize;

	public FPCGLandscapeLayerWeight Copy()
	{
		return this;
	}

	public static FPCGLandscapeLayerWeight FromNative(IntPtr nativeBuffer)
	{
		return new FPCGLandscapeLayerWeight(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGLandscapeLayerWeight value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGLandscapeLayerWeight FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGLandscapeLayerWeight(nativeBuffer + arrayIndex * FPCGLandscapeLayerWeight_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGLandscapeLayerWeight value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGLandscapeLayerWeight_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGLandscapeLayerWeight_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGLandscapeLayerWeight");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Weight_Offset), Weight);
	}

	public FPCGLandscapeLayerWeight(IntPtr nativeStruct)
	{
		if (!FPCGLandscapeLayerWeight_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGLandscapeLayerWeight");
			Name = default(FName);
			Weight = 0f;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Weight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Weight_Offset));
		}
	}

	static FPCGLandscapeLayerWeight()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGLandscapeLayerWeight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGLandscapeLayerWeight));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGLandscapeLayerWeight");
		FPCGLandscapeLayerWeight_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		Weight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Weight");
		Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Weight", Classes.FFloatProperty);
		FPCGLandscapeLayerWeight_IsValid = intPtr != IntPtr.Zero && Name_IsValid && Weight_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGLandscapeLayerWeight", FPCGLandscapeLayerWeight_IsValid);
	}
}
