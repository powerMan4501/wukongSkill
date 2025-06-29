using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.AutoMovePerfEditorVisualizer", "b1", UnrealModuleType.Game)]
public class AAutoMovePerfEditorVisualizer : AActor
{
	private static bool BaseImageBrush_IsValid;

	private static int BaseImageBrush_Offset;

	private static bool DisplayVisualizedPerfInfo_IsValid;

	private static IntPtr DisplayVisualizedPerfInfo_FunctionAddress;

	private static int DisplayVisualizedPerfInfo_ParamsSize;

	private static bool DisplayVisualizedPerfInfo_InTileSourceInfoArray_IsValid;

	private static FFieldAddress DisplayVisualizedPerfInfo_InTileSourceInfoArray_PropertyAddress;

	private static int DisplayVisualizedPerfInfo_InTileSourceInfoArray_Offset;

	private static bool DisplayVisualizedPerfInfo_InResolution_IsValid;

	private static FFieldAddress DisplayVisualizedPerfInfo_InResolution_PropertyAddress;

	private static int DisplayVisualizedPerfInfo_InResolution_Offset;

	private static bool DisplayVisualizedPerfInfo_InTileCount_IsValid;

	private static FFieldAddress DisplayVisualizedPerfInfo_InTileCount_PropertyAddress;

	private static int DisplayVisualizedPerfInfo_InTileCount_Offset;

	private static bool DisplayVisualizedPerfInfo_InIntensityScaleFactor_IsValid;

	private static FFieldAddress DisplayVisualizedPerfInfo_InIntensityScaleFactor_PropertyAddress;

	private static int DisplayVisualizedPerfInfo_InIntensityScaleFactor_Offset;

	private static bool DisplayVisualizedPerfInfo_InBaseImagePath_IsValid;

	private static FFieldAddress DisplayVisualizedPerfInfo_InBaseImagePath_PropertyAddress;

	private static int DisplayVisualizedPerfInfo_InBaseImagePath_Offset;

	private static bool ClearVisualizedPerfInfo_IsValid;

	private static IntPtr ClearVisualizedPerfInfo_FunctionAddress;

	private static int ClearVisualizedPerfInfo_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/b1.AutoMovePerfEditorVisualizer:BaseImageBrush")]
	public FSlateBrush BaseImageBrush
	{
		get
		{
			CheckDestroyed();
			if (!BaseImageBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AutoMovePerfEditorVisualizer:BaseImageBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, BaseImageBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseImageBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AutoMovePerfEditorVisualizer:BaseImageBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, BaseImageBrush_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/b1.AutoMovePerfEditorVisualizer:DisplayVisualizedPerfInfo")]
	public unsafe void DisplayVisualizedPerfInfo(List<float> InTileSourceInfoArray, FVector2D InResolution, FIntPoint InTileCount, float InIntensityScaleFactor, string InBaseImagePath)
	{
		CheckDestroyed();
		if (!DisplayVisualizedPerfInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AutoMovePerfEditorVisualizer:DisplayVisualizedPerfInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisplayVisualizedPerfInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisplayVisualizedPerfInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<float>(1, DisplayVisualizedPerfInfo_InTileSourceInfoArray_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, DisplayVisualizedPerfInfo_InTileSourceInfoArray_Offset), InTileSourceInfoArray);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DisplayVisualizedPerfInfo_InResolution_Offset), 0, DisplayVisualizedPerfInfo_InResolution_PropertyAddress.Address, InResolution);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(intPtr, DisplayVisualizedPerfInfo_InTileCount_Offset), 0, DisplayVisualizedPerfInfo_InTileCount_PropertyAddress.Address, InTileCount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DisplayVisualizedPerfInfo_InIntensityScaleFactor_Offset), 0, DisplayVisualizedPerfInfo_InIntensityScaleFactor_PropertyAddress.Address, InIntensityScaleFactor);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DisplayVisualizedPerfInfo_InBaseImagePath_Offset), 0, DisplayVisualizedPerfInfo_InBaseImagePath_PropertyAddress.Address, InBaseImagePath);
		NativeReflection.InvokeFunctionOptimized(base.Address, DisplayVisualizedPerfInfo_FunctionAddress, intPtr, DisplayVisualizedPerfInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DisplayVisualizedPerfInfo_InTileSourceInfoArray_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DisplayVisualizedPerfInfo_InBaseImagePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.AutoMovePerfEditorVisualizer:ClearVisualizedPerfInfo")]
	public unsafe void ClearVisualizedPerfInfo()
	{
		CheckDestroyed();
		if (!ClearVisualizedPerfInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AutoMovePerfEditorVisualizer:ClearVisualizedPerfInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearVisualizedPerfInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearVisualizedPerfInfo_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearVisualizedPerfInfo_FunctionAddress, argsSize: ClearVisualizedPerfInfo_ParamsSize);
	}

	static AAutoMovePerfEditorVisualizer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AAutoMovePerfEditorVisualizer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AAutoMovePerfEditorVisualizer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.AutoMovePerfEditorVisualizer");
		BaseImageBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BaseImageBrush");
		BaseImageBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BaseImageBrush", Classes.FStructProperty);
		DisplayVisualizedPerfInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisplayVisualizedPerfInfo");
		DisplayVisualizedPerfInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(DisplayVisualizedPerfInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisplayVisualizedPerfInfo_InTileSourceInfoArray_PropertyAddress, DisplayVisualizedPerfInfo_FunctionAddress, "InTileSourceInfoArray");
		DisplayVisualizedPerfInfo_InTileSourceInfoArray_Offset = NativeReflectionCached.GetPropertyOffset(DisplayVisualizedPerfInfo_FunctionAddress, "InTileSourceInfoArray");
		DisplayVisualizedPerfInfo_InTileSourceInfoArray_IsValid = NativeReflectionCached.ValidatePropertyClass(DisplayVisualizedPerfInfo_FunctionAddress, "InTileSourceInfoArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DisplayVisualizedPerfInfo_InResolution_PropertyAddress, DisplayVisualizedPerfInfo_FunctionAddress, "InResolution");
		DisplayVisualizedPerfInfo_InResolution_Offset = NativeReflectionCached.GetPropertyOffset(DisplayVisualizedPerfInfo_FunctionAddress, "InResolution");
		DisplayVisualizedPerfInfo_InResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(DisplayVisualizedPerfInfo_FunctionAddress, "InResolution", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DisplayVisualizedPerfInfo_InTileCount_PropertyAddress, DisplayVisualizedPerfInfo_FunctionAddress, "InTileCount");
		DisplayVisualizedPerfInfo_InTileCount_Offset = NativeReflectionCached.GetPropertyOffset(DisplayVisualizedPerfInfo_FunctionAddress, "InTileCount");
		DisplayVisualizedPerfInfo_InTileCount_IsValid = NativeReflectionCached.ValidatePropertyClass(DisplayVisualizedPerfInfo_FunctionAddress, "InTileCount", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DisplayVisualizedPerfInfo_InIntensityScaleFactor_PropertyAddress, DisplayVisualizedPerfInfo_FunctionAddress, "InIntensityScaleFactor");
		DisplayVisualizedPerfInfo_InIntensityScaleFactor_Offset = NativeReflectionCached.GetPropertyOffset(DisplayVisualizedPerfInfo_FunctionAddress, "InIntensityScaleFactor");
		DisplayVisualizedPerfInfo_InIntensityScaleFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(DisplayVisualizedPerfInfo_FunctionAddress, "InIntensityScaleFactor", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DisplayVisualizedPerfInfo_InBaseImagePath_PropertyAddress, DisplayVisualizedPerfInfo_FunctionAddress, "InBaseImagePath");
		DisplayVisualizedPerfInfo_InBaseImagePath_Offset = NativeReflectionCached.GetPropertyOffset(DisplayVisualizedPerfInfo_FunctionAddress, "InBaseImagePath");
		DisplayVisualizedPerfInfo_InBaseImagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(DisplayVisualizedPerfInfo_FunctionAddress, "InBaseImagePath", Classes.FStrProperty);
		DisplayVisualizedPerfInfo_IsValid = DisplayVisualizedPerfInfo_FunctionAddress != IntPtr.Zero && DisplayVisualizedPerfInfo_InTileSourceInfoArray_IsValid && DisplayVisualizedPerfInfo_InResolution_IsValid && DisplayVisualizedPerfInfo_InTileCount_IsValid && DisplayVisualizedPerfInfo_InIntensityScaleFactor_IsValid && DisplayVisualizedPerfInfo_InBaseImagePath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AutoMovePerfEditorVisualizer:DisplayVisualizedPerfInfo", DisplayVisualizedPerfInfo_IsValid);
		ClearVisualizedPerfInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearVisualizedPerfInfo");
		ClearVisualizedPerfInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearVisualizedPerfInfo_FunctionAddress);
		ClearVisualizedPerfInfo_IsValid = ClearVisualizedPerfInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.AutoMovePerfEditorVisualizer:ClearVisualizedPerfInfo", ClearVisualizedPerfInfo_IsValid);
	}
}
