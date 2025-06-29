using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CustomDepthStencilInfo")]
public struct FCustomDepthStencilInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.CustomDepthStencilInfo:ComponentTag")]
	public FName ComponentTag;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.CustomDepthStencilInfo:bRenderCustomDepth")]
	public bool bRenderCustomDepth;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CustomDepthStencilInfo:CustomDepthStencilValue")]
	public int CustomDepthStencilValue;

	private static int CustomDepthStencilInfo_StructSize;

	private static int CustomDepthStencilInfo_IsValid;

	private static bool ComponentTag_IsValid;

	private static int ComponentTag_Offset;

	private static bool bRenderCustomDepth_IsValid;

	private static int bRenderCustomDepth_Offset;

	private static FFieldAddress bRenderCustomDepth_PropertyAddress;

	private static bool CustomDepthStencilValue_IsValid;

	private static int CustomDepthStencilValue_Offset;

	public FCustomDepthStencilInfo Copy()
	{
		return this;
	}

	public static FCustomDepthStencilInfo FromNative(IntPtr nativeBuffer)
	{
		return new FCustomDepthStencilInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCustomDepthStencilInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCustomDepthStencilInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCustomDepthStencilInfo(IntPtr.Add(nativeBuffer, arrayIndex * CustomDepthStencilInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCustomDepthStencilInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CustomDepthStencilInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CustomDepthStencilInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CustomDepthStencilInfo");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ComponentTag_Offset), ComponentTag);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bRenderCustomDepth_Offset), 0, bRenderCustomDepth_PropertyAddress.Address, bRenderCustomDepth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CustomDepthStencilValue_Offset), CustomDepthStencilValue);
	}

	public FCustomDepthStencilInfo(IntPtr nativeStruct)
	{
		if (CustomDepthStencilInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CustomDepthStencilInfo");
			ComponentTag = default(FName);
			bRenderCustomDepth = false;
			CustomDepthStencilValue = 0;
		}
		else
		{
			ComponentTag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ComponentTag_Offset));
			bRenderCustomDepth = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bRenderCustomDepth_Offset), 0, bRenderCustomDepth_PropertyAddress.Address);
			CustomDepthStencilValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CustomDepthStencilValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CustomDepthStencilInfo");
		CustomDepthStencilInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ComponentTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "ComponentTag");
		ComponentTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ComponentTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bRenderCustomDepth_PropertyAddress, intPtr, "bRenderCustomDepth");
		bRenderCustomDepth_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRenderCustomDepth");
		bRenderCustomDepth_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRenderCustomDepth", Classes.FBoolProperty);
		CustomDepthStencilValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomDepthStencilValue");
		CustomDepthStencilValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomDepthStencilValue", Classes.FIntProperty);
		CustomDepthStencilInfo_IsValid = ((intPtr != IntPtr.Zero && ComponentTag_IsValid && bRenderCustomDepth_IsValid && CustomDepthStencilValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CustomDepthStencilInfo", (byte)CustomDepthStencilInfo_IsValid != 0);
	}

	static FCustomDepthStencilInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCustomDepthStencilInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCustomDepthStencilInfo));
	}
}
