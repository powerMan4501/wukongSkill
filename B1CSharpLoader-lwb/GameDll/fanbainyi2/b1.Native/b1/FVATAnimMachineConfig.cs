using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.VATAnimMachineConfig", "UnrealExtent", UnrealModuleType.Game)]
public struct FVATAnimMachineConfig
{
	private static bool PlaySpeed_IsValid;

	private static int PlaySpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineConfig:PlaySpeed")]
	public float PlaySpeed;

	private static bool FrameRate_IsValid;

	private static int FrameRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineConfig:FrameRate")]
	public float FrameRate;

	private static bool BlendRatio_IsValid;

	private static int BlendRatio_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineConfig:BlendRatio")]
	public float BlendRatio;

	private static bool Loop_IsValid;

	private static FFieldAddress Loop_PropertyAddress;

	private static int Loop_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineConfig:Loop")]
	public bool Loop;

	private static bool ClipTexture_IsValid;

	private static int ClipTexture_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineConfig:ClipTexture")]
	public UTexture2D ClipTexture;

	private static bool WindDirectionX_IsValid;

	private static int WindDirectionX_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineConfig:WindDirectionX")]
	public float WindDirectionX;

	private static bool WindDirectionY_IsValid;

	private static int WindDirectionY_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineConfig:WindDirectionY")]
	public float WindDirectionY;

	private static bool WindIntensity_IsValid;

	private static int WindIntensity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineConfig:WindIntensity")]
	public float WindIntensity;

	private static bool IdleClip_IsValid;

	private static int IdleClip_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineConfig:IdleClip")]
	public int IdleClip;

	private static bool FVATAnimMachineConfig_IsValid;

	private static int FVATAnimMachineConfig_StructSize;

	public FVATAnimMachineConfig Copy()
	{
		return this;
	}

	public static FVATAnimMachineConfig FromNative(IntPtr nativeBuffer)
	{
		return new FVATAnimMachineConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVATAnimMachineConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVATAnimMachineConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVATAnimMachineConfig(nativeBuffer + arrayIndex * FVATAnimMachineConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVATAnimMachineConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVATAnimMachineConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVATAnimMachineConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.VATAnimMachineConfig");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PlaySpeed_Offset), PlaySpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FrameRate_Offset), FrameRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendRatio_Offset), BlendRatio);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address, Loop);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, ClipTexture_Offset), ClipTexture);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WindDirectionX_Offset), WindDirectionX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WindDirectionY_Offset), WindDirectionY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WindIntensity_Offset), WindIntensity);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IdleClip_Offset), IdleClip);
	}

	public FVATAnimMachineConfig(IntPtr nativeStruct)
	{
		if (!FVATAnimMachineConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.VATAnimMachineConfig");
			PlaySpeed = 0f;
			FrameRate = 0f;
			BlendRatio = 0f;
			Loop = false;
			ClipTexture = null;
			WindDirectionX = 0f;
			WindDirectionY = 0f;
			WindIntensity = 0f;
			IdleClip = 0;
		}
		else
		{
			PlaySpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PlaySpeed_Offset));
			FrameRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FrameRate_Offset));
			BlendRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendRatio_Offset));
			Loop = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address);
			ClipTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, ClipTexture_Offset));
			WindDirectionX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WindDirectionX_Offset));
			WindDirectionY = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WindDirectionY_Offset));
			WindIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WindIntensity_Offset));
			IdleClip = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IdleClip_Offset));
		}
	}

	static FVATAnimMachineConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVATAnimMachineConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVATAnimMachineConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.VATAnimMachineConfig");
		FVATAnimMachineConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		PlaySpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlaySpeed");
		PlaySpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlaySpeed", Classes.FFloatProperty);
		FrameRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameRate");
		FrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameRate", Classes.FFloatProperty);
		BlendRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendRatio");
		BlendRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Loop_PropertyAddress, intPtr, "Loop");
		Loop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Loop");
		Loop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Loop", Classes.FBoolProperty);
		ClipTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClipTexture");
		ClipTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClipTexture", Classes.FObjectProperty);
		WindDirectionX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindDirectionX");
		WindDirectionX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindDirectionX", Classes.FFloatProperty);
		WindDirectionY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindDirectionY");
		WindDirectionY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindDirectionY", Classes.FFloatProperty);
		WindIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindIntensity");
		WindIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindIntensity", Classes.FFloatProperty);
		IdleClip_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IdleClip");
		IdleClip_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IdleClip", Classes.FIntProperty);
		FVATAnimMachineConfig_IsValid = intPtr != IntPtr.Zero && PlaySpeed_IsValid && FrameRate_IsValid && BlendRatio_IsValid && Loop_IsValid && ClipTexture_IsValid && WindDirectionX_IsValid && WindDirectionY_IsValid && WindIntensity_IsValid && IdleClip_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.VATAnimMachineConfig", FVATAnimMachineConfig_IsValid);
	}
}
