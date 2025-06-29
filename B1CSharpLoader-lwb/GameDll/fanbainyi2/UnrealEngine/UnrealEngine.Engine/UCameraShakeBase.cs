using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818942113uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.CameraShakeBase", "Engine", UnrealModuleType.Engine)]
public class UCameraShakeBase : UObject
{
	private static bool ShakeScale_IsValid;

	private static int ShakeScale_Offset;

	private static bool SetRootShakePattern_IsValid;

	private static IntPtr SetRootShakePattern_FunctionAddress;

	private static int SetRootShakePattern_ParamsSize;

	private static bool SetRootShakePattern_InPattern_IsValid;

	private static FFieldAddress SetRootShakePattern_InPattern_PropertyAddress;

	private static int SetRootShakePattern_InPattern_Offset;

	private static bool GetRootShakePattern_IsValid;

	private static IntPtr GetRootShakePattern_FunctionAddress;

	private static int GetRootShakePattern_ParamsSize;

	private static bool GetRootShakePattern_ReturnValue_IsValid;

	private static FFieldAddress GetRootShakePattern_ReturnValue_PropertyAddress;

	private static int GetRootShakePattern_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234283012uL)]
	[UMetaPath("/Script/Engine.CameraShakeBase:ShakeScale")]
	public float ShakeScale
	{
		get
		{
			CheckDestroyed();
			if (!ShakeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeBase:ShakeScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShakeScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShakeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeBase:ShakeScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShakeScale_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraShakeBase:SetRootShakePattern")]
	public unsafe void SetRootShakePattern(UCameraShakePattern InPattern)
	{
		CheckDestroyed();
		if (!SetRootShakePattern_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraShakeBase:SetRootShakePattern");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRootShakePattern_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRootShakePattern_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraShakePattern>.ToNative(IntPtr.Add(intPtr, SetRootShakePattern_InPattern_Offset), 0, SetRootShakePattern_InPattern_PropertyAddress.Address, InPattern);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRootShakePattern_FunctionAddress, intPtr, SetRootShakePattern_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CameraShakeBase:GetRootShakePattern")]
	public unsafe UCameraShakePattern GetRootShakePattern()
	{
		CheckDestroyed();
		if (!GetRootShakePattern_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraShakeBase:GetRootShakePattern");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRootShakePattern_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRootShakePattern_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRootShakePattern_FunctionAddress, intPtr, GetRootShakePattern_ParamsSize);
		return UObjectMarshaler<UCameraShakePattern>.FromNative(IntPtr.Add(intPtr, GetRootShakePattern_ReturnValue_Offset), 0, GetRootShakePattern_ReturnValue_PropertyAddress.Address);
	}

	static UCameraShakeBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCameraShakeBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCameraShakeBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.CameraShakeBase");
		ShakeScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShakeScale");
		ShakeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShakeScale", Classes.FFloatProperty);
		SetRootShakePattern_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRootShakePattern");
		SetRootShakePattern_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRootShakePattern_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRootShakePattern_InPattern_PropertyAddress, SetRootShakePattern_FunctionAddress, "InPattern");
		SetRootShakePattern_InPattern_Offset = NativeReflectionCached.GetPropertyOffset(SetRootShakePattern_FunctionAddress, "InPattern");
		SetRootShakePattern_InPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRootShakePattern_FunctionAddress, "InPattern", Classes.FObjectProperty);
		SetRootShakePattern_IsValid = SetRootShakePattern_FunctionAddress != IntPtr.Zero && SetRootShakePattern_InPattern_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraShakeBase:SetRootShakePattern", SetRootShakePattern_IsValid);
		GetRootShakePattern_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRootShakePattern");
		GetRootShakePattern_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRootShakePattern_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRootShakePattern_ReturnValue_PropertyAddress, GetRootShakePattern_FunctionAddress, "ReturnValue");
		GetRootShakePattern_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRootShakePattern_FunctionAddress, "ReturnValue");
		GetRootShakePattern_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRootShakePattern_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRootShakePattern_IsValid = GetRootShakePattern_FunctionAddress != IntPtr.Zero && GetRootShakePattern_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraShakeBase:GetRootShakePattern", GetRootShakePattern_IsValid);
	}
}
