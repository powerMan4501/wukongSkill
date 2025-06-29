using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810561696uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.StereoLayerShapeEquirect", "Engine", UnrealModuleType.Engine)]
public class UStereoLayerShapeEquirect : UStereoLayerShape
{
	private static bool LeftUVRect_IsValid;

	private static int LeftUVRect_Offset;

	private static bool RightUVRect_IsValid;

	private static int RightUVRect_Offset;

	private static bool LeftScale_IsValid;

	private static int LeftScale_Offset;

	private static bool RightScale_IsValid;

	private static int RightScale_Offset;

	private static bool LeftBias_IsValid;

	private static int LeftBias_Offset;

	private static bool RightBias_IsValid;

	private static int RightBias_Offset;

	private static bool SetEquirectProps_IsValid;

	private static IntPtr SetEquirectProps_FunctionAddress;

	private static int SetEquirectProps_ParamsSize;

	private static bool SetEquirectProps_InScaleBiases_IsValid;

	private static FFieldAddress SetEquirectProps_InScaleBiases_PropertyAddress;

	private static int SetEquirectProps_InScaleBiases_Offset;

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/Engine.StereoLayerShapeEquirect:LeftUVRect")]
	public FBox2D LeftUVRect
	{
		get
		{
			CheckDestroyed();
			if (!LeftUVRect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeEquirect:LeftUVRect");
				return default(FBox2D);
			}
			return BlittableTypeMarshaler<FBox2D>.FromNative(IntPtr.Add(base.Address, LeftUVRect_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftUVRect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeEquirect:LeftUVRect");
			}
			else
			{
				BlittableTypeMarshaler<FBox2D>.ToNative(IntPtr.Add(base.Address, LeftUVRect_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/Engine.StereoLayerShapeEquirect:RightUVRect")]
	public FBox2D RightUVRect
	{
		get
		{
			CheckDestroyed();
			if (!RightUVRect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeEquirect:RightUVRect");
				return default(FBox2D);
			}
			return BlittableTypeMarshaler<FBox2D>.FromNative(IntPtr.Add(base.Address, RightUVRect_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightUVRect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeEquirect:RightUVRect");
			}
			else
			{
				BlittableTypeMarshaler<FBox2D>.ToNative(IntPtr.Add(base.Address, RightUVRect_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.StereoLayerShapeEquirect:LeftScale")]
	public FVector2D LeftScale
	{
		get
		{
			CheckDestroyed();
			if (!LeftScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeEquirect:LeftScale");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, LeftScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeEquirect:LeftScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, LeftScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.StereoLayerShapeEquirect:RightScale")]
	public FVector2D RightScale
	{
		get
		{
			CheckDestroyed();
			if (!RightScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeEquirect:RightScale");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, RightScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeEquirect:RightScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, RightScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.StereoLayerShapeEquirect:LeftBias")]
	public FVector2D LeftBias
	{
		get
		{
			CheckDestroyed();
			if (!LeftBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeEquirect:LeftBias");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, LeftBias_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeEquirect:LeftBias");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, LeftBias_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.StereoLayerShapeEquirect:RightBias")]
	public FVector2D RightBias
	{
		get
		{
			CheckDestroyed();
			if (!RightBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeEquirect:RightBias");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, RightBias_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerShapeEquirect:RightBias");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, RightBias_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StereoLayerShapeEquirect:SetEquirectProps")]
	public unsafe void SetEquirectProps(FEquirectProps InScaleBiases)
	{
		CheckDestroyed();
		if (!SetEquirectProps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerShapeEquirect:SetEquirectProps");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEquirectProps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEquirectProps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetEquirectProps_InScaleBiases_PropertyAddress.Address, intPtr);
		FEquirectProps.ToNative(IntPtr.Add(intPtr, SetEquirectProps_InScaleBiases_Offset), 0, SetEquirectProps_InScaleBiases_PropertyAddress.Address, InScaleBiases);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEquirectProps_FunctionAddress, intPtr, SetEquirectProps_ParamsSize);
	}

	static UStereoLayerShapeEquirect()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStereoLayerShapeEquirect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStereoLayerShapeEquirect));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.StereoLayerShapeEquirect");
		LeftUVRect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeftUVRect");
		LeftUVRect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeftUVRect", Classes.FStructProperty);
		RightUVRect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RightUVRect");
		RightUVRect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RightUVRect", Classes.FStructProperty);
		LeftScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeftScale");
		LeftScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeftScale", Classes.FStructProperty);
		RightScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RightScale");
		RightScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RightScale", Classes.FStructProperty);
		LeftBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeftBias");
		LeftBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeftBias", Classes.FStructProperty);
		RightBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RightBias");
		RightBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RightBias", Classes.FStructProperty);
		SetEquirectProps_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEquirectProps");
		SetEquirectProps_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEquirectProps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEquirectProps_InScaleBiases_PropertyAddress, SetEquirectProps_FunctionAddress, "InScaleBiases");
		SetEquirectProps_InScaleBiases_Offset = NativeReflectionCached.GetPropertyOffset(SetEquirectProps_FunctionAddress, "InScaleBiases");
		SetEquirectProps_InScaleBiases_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEquirectProps_FunctionAddress, "InScaleBiases", Classes.FStructProperty);
		SetEquirectProps_IsValid = SetEquirectProps_FunctionAddress != IntPtr.Zero && SetEquirectProps_InScaleBiases_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerShapeEquirect:SetEquirectProps", SetEquirectProps_IsValid);
	}
}
