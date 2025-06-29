using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.AlphaScanButton", "UnrealExtent", UnrealModuleType.Game)]
public class UAlphaScanButton : UButton
{
	private static bool AdvancedHitTexture_IsValid;

	private static int AdvancedHitTexture_Offset;

	private static bool AdvancedHitAlpha_IsValid;

	private static int AdvancedHitAlpha_Offset;

	private static bool SetAdvancedHitTexture_IsValid;

	private static IntPtr SetAdvancedHitTexture_FunctionAddress;

	private static int SetAdvancedHitTexture_ParamsSize;

	private static bool SetAdvancedHitTexture_InTexture_IsValid;

	private static FFieldAddress SetAdvancedHitTexture_InTexture_PropertyAddress;

	private static int SetAdvancedHitTexture_InTexture_Offset;

	private static bool SetAdvancedHitAlpha_IsValid;

	private static IntPtr SetAdvancedHitAlpha_FunctionAddress;

	private static int SetAdvancedHitAlpha_ParamsSize;

	private static bool SetAdvancedHitAlpha_InAlpha_IsValid;

	private static FFieldAddress SetAdvancedHitAlpha_InAlpha_PropertyAddress;

	private static int SetAdvancedHitAlpha_InAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.AlphaScanButton:AdvancedHitTexture")]
	public UTexture2D AdvancedHitTexture
	{
		get
		{
			CheckDestroyed();
			if (!AdvancedHitTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AlphaScanButton:AdvancedHitTexture");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, AdvancedHitTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdvancedHitTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AlphaScanButton:AdvancedHitTexture");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, AdvancedHitTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.AlphaScanButton:AdvancedHitAlpha")]
	public int AdvancedHitAlpha
	{
		get
		{
			CheckDestroyed();
			if (!AdvancedHitAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AlphaScanButton:AdvancedHitAlpha");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AdvancedHitAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdvancedHitAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AlphaScanButton:AdvancedHitAlpha");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AdvancedHitAlpha_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AlphaScanButton:SetAdvancedHitTexture")]
	public unsafe void SetAdvancedHitTexture(UTexture2D InTexture)
	{
		CheckDestroyed();
		if (!SetAdvancedHitTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AlphaScanButton:SetAdvancedHitTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAdvancedHitTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAdvancedHitTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SetAdvancedHitTexture_InTexture_Offset), 0, SetAdvancedHitTexture_InTexture_PropertyAddress.Address, InTexture);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAdvancedHitTexture_FunctionAddress, intPtr, SetAdvancedHitTexture_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AlphaScanButton:SetAdvancedHitAlpha")]
	public unsafe void SetAdvancedHitAlpha(int InAlpha)
	{
		CheckDestroyed();
		if (!SetAdvancedHitAlpha_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AlphaScanButton:SetAdvancedHitAlpha");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAdvancedHitAlpha_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAdvancedHitAlpha_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAdvancedHitAlpha_InAlpha_Offset), 0, SetAdvancedHitAlpha_InAlpha_PropertyAddress.Address, InAlpha);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAdvancedHitAlpha_FunctionAddress, intPtr, SetAdvancedHitAlpha_ParamsSize);
	}

	static UAlphaScanButton()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAlphaScanButton)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAlphaScanButton));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.AlphaScanButton");
		AdvancedHitTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AdvancedHitTexture");
		AdvancedHitTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AdvancedHitTexture", Classes.FObjectProperty);
		AdvancedHitAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AdvancedHitAlpha");
		AdvancedHitAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AdvancedHitAlpha", Classes.FIntProperty);
		SetAdvancedHitTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAdvancedHitTexture");
		SetAdvancedHitTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAdvancedHitTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAdvancedHitTexture_InTexture_PropertyAddress, SetAdvancedHitTexture_FunctionAddress, "InTexture");
		SetAdvancedHitTexture_InTexture_Offset = NativeReflectionCached.GetPropertyOffset(SetAdvancedHitTexture_FunctionAddress, "InTexture");
		SetAdvancedHitTexture_InTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAdvancedHitTexture_FunctionAddress, "InTexture", Classes.FObjectProperty);
		SetAdvancedHitTexture_IsValid = SetAdvancedHitTexture_FunctionAddress != IntPtr.Zero && SetAdvancedHitTexture_InTexture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AlphaScanButton:SetAdvancedHitTexture", SetAdvancedHitTexture_IsValid);
		SetAdvancedHitAlpha_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAdvancedHitAlpha");
		SetAdvancedHitAlpha_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAdvancedHitAlpha_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAdvancedHitAlpha_InAlpha_PropertyAddress, SetAdvancedHitAlpha_FunctionAddress, "InAlpha");
		SetAdvancedHitAlpha_InAlpha_Offset = NativeReflectionCached.GetPropertyOffset(SetAdvancedHitAlpha_FunctionAddress, "InAlpha");
		SetAdvancedHitAlpha_InAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAdvancedHitAlpha_FunctionAddress, "InAlpha", Classes.FIntProperty);
		SetAdvancedHitAlpha_IsValid = SetAdvancedHitAlpha_FunctionAddress != IntPtr.Zero && SetAdvancedHitAlpha_InAlpha_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AlphaScanButton:SetAdvancedHitAlpha", SetAdvancedHitAlpha_IsValid);
	}
}
