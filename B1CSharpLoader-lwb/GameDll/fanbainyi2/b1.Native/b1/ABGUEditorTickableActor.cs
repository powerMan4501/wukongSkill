using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGUEditorTickableActor", "b1", UnrealModuleType.Game)]
public class ABGUEditorTickableActor : AActor
{
	private static bool GetViewportCameraLocation_IsValid;

	private static IntPtr GetViewportCameraLocation_FunctionAddress;

	private static int GetViewportCameraLocation_ParamsSize;

	private static bool GetViewportCameraLocation_ReturnValue_IsValid;

	private static FFieldAddress GetViewportCameraLocation_ReturnValue_PropertyAddress;

	private static int GetViewportCameraLocation_ReturnValue_Offset;

	[UFunction(Flags = 76022785u)]
	[UMetaPath("/Script/b1.BGUEditorTickableActor:GetViewportCameraLocation")]
	protected unsafe FVector GetViewportCameraLocation()
	{
		CheckDestroyed();
		if (!GetViewportCameraLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUEditorTickableActor:GetViewportCameraLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewportCameraLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewportCameraLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewportCameraLocation_FunctionAddress, intPtr, GetViewportCameraLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetViewportCameraLocation_ReturnValue_Offset), 0, GetViewportCameraLocation_ReturnValue_PropertyAddress.Address);
	}

	static ABGUEditorTickableActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGUEditorTickableActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGUEditorTickableActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGUEditorTickableActor");
		GetViewportCameraLocation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetViewportCameraLocation");
		GetViewportCameraLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewportCameraLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewportCameraLocation_ReturnValue_PropertyAddress, GetViewportCameraLocation_FunctionAddress, "ReturnValue");
		GetViewportCameraLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportCameraLocation_FunctionAddress, "ReturnValue");
		GetViewportCameraLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportCameraLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewportCameraLocation_IsValid = GetViewportCameraLocation_FunctionAddress != IntPtr.Zero && GetViewportCameraLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUEditorTickableActor:GetViewportCameraLocation", GetViewportCameraLocation_IsValid);
	}
}
