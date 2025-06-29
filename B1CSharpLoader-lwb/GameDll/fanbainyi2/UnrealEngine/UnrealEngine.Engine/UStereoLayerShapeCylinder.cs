using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810561696uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.StereoLayerShapeCylinder", "Engine", UnrealModuleType.Engine)]
public class UStereoLayerShapeCylinder : UStereoLayerShape
{
	private static bool Radius_IsValid;

	private static int Radius_Offset;

	private static bool OverlayArc_IsValid;

	private static int OverlayArc_Offset;

	private static bool Height_IsValid;

	private static int Height_Offset;

	private static bool SetRadius_IsValid;

	private static IntPtr SetRadius_FunctionAddress;

	private static int SetRadius_ParamsSize;

	private static bool SetRadius_InRadius_IsValid;

	private static FFieldAddress SetRadius_InRadius_PropertyAddress;

	private static int SetRadius_InRadius_Offset;

	private static bool SetOverlayArc_IsValid;

	private static IntPtr SetOverlayArc_FunctionAddress;

	private static int SetOverlayArc_ParamsSize;

	private static bool SetOverlayArc_InOverlayArc_IsValid;

	private static FFieldAddress SetOverlayArc_InOverlayArc_PropertyAddress;

	private static int SetOverlayArc_InOverlayArc_Offset;

	private static bool SetHeight_IsValid;

	private static IntPtr SetHeight_FunctionAddress;

	private static int SetHeight_ParamsSize;

	private static bool SetHeight_InHeight_IsValid;

	private static FFieldAddress SetHeight_InHeight_PropertyAddress;

	private static int SetHeight_InHeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274845uL)]
	[UMetaPath("/Script/Engine.StereoLayerShapeCylinder:Radius")]
	public float Radius
	{
		get
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeCylinder:Radius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Radius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeCylinder:Radius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Radius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274845uL)]
	[UMetaPath("/Script/Engine.StereoLayerShapeCylinder:OverlayArc")]
	public float OverlayArc
	{
		get
		{
			CheckDestroyed();
			if (!OverlayArc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeCylinder:OverlayArc");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverlayArc_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverlayArc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeCylinder:OverlayArc");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverlayArc_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274845uL)]
	[UMetaPath("/Script/Engine.StereoLayerShapeCylinder:Height")]
	public int Height
	{
		get
		{
			CheckDestroyed();
			if (!Height_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeCylinder:Height");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Height_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Height_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeCylinder:Height");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Height_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StereoLayerShapeCylinder:SetRadius")]
	public unsafe void SetRadius(float InRadius)
	{
		CheckDestroyed();
		if (!SetRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerShapeCylinder:SetRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRadius_InRadius_Offset), 0, SetRadius_InRadius_PropertyAddress.Address, InRadius);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRadius_FunctionAddress, intPtr, SetRadius_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StereoLayerShapeCylinder:SetOverlayArc")]
	public unsafe void SetOverlayArc(float InOverlayArc)
	{
		CheckDestroyed();
		if (!SetOverlayArc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerShapeCylinder:SetOverlayArc");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOverlayArc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOverlayArc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOverlayArc_InOverlayArc_Offset), 0, SetOverlayArc_InOverlayArc_PropertyAddress.Address, InOverlayArc);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOverlayArc_FunctionAddress, intPtr, SetOverlayArc_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StereoLayerShapeCylinder:SetHeight")]
	public unsafe void SetHeight(int InHeight)
	{
		CheckDestroyed();
		if (!SetHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerShapeCylinder:SetHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetHeight_InHeight_Offset), 0, SetHeight_InHeight_PropertyAddress.Address, InHeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHeight_FunctionAddress, intPtr, SetHeight_ParamsSize);
	}

	static UStereoLayerShapeCylinder()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStereoLayerShapeCylinder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStereoLayerShapeCylinder));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.StereoLayerShapeCylinder");
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		OverlayArc_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverlayArc");
		OverlayArc_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverlayArc", Classes.FFloatProperty);
		Height_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Height");
		Height_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Height", Classes.FIntProperty);
		SetRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRadius");
		SetRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRadius_InRadius_PropertyAddress, SetRadius_FunctionAddress, "InRadius");
		SetRadius_InRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetRadius_FunctionAddress, "InRadius");
		SetRadius_InRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadius_FunctionAddress, "InRadius", Classes.FFloatProperty);
		SetRadius_IsValid = SetRadius_FunctionAddress != IntPtr.Zero && SetRadius_InRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerShapeCylinder:SetRadius", SetRadius_IsValid);
		SetOverlayArc_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOverlayArc");
		SetOverlayArc_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOverlayArc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOverlayArc_InOverlayArc_PropertyAddress, SetOverlayArc_FunctionAddress, "InOverlayArc");
		SetOverlayArc_InOverlayArc_Offset = NativeReflectionCached.GetPropertyOffset(SetOverlayArc_FunctionAddress, "InOverlayArc");
		SetOverlayArc_InOverlayArc_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOverlayArc_FunctionAddress, "InOverlayArc", Classes.FFloatProperty);
		SetOverlayArc_IsValid = SetOverlayArc_FunctionAddress != IntPtr.Zero && SetOverlayArc_InOverlayArc_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerShapeCylinder:SetOverlayArc", SetOverlayArc_IsValid);
		SetHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHeight");
		SetHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHeight_InHeight_PropertyAddress, SetHeight_FunctionAddress, "InHeight");
		SetHeight_InHeight_Offset = NativeReflectionCached.GetPropertyOffset(SetHeight_FunctionAddress, "InHeight");
		SetHeight_InHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHeight_FunctionAddress, "InHeight", Classes.FIntProperty);
		SetHeight_IsValid = SetHeight_FunctionAddress != IntPtr.Zero && SetHeight_InHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerShapeCylinder:SetHeight", SetHeight_IsValid);
	}
}
