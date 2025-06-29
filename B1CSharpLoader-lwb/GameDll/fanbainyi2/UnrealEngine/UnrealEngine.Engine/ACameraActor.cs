using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.CameraActor", "Engine", UnrealModuleType.Engine)]
public class ACameraActor : AActor
{
	private static bool CameraComponent_IsValid;

	private static int CameraComponent_Offset;

	private static bool SceneComponent_IsValid;

	private static int SceneComponent_Offset;

	private static bool GetAutoActivatePlayerIndex_IsValid;

	private static IntPtr GetAutoActivatePlayerIndex_FunctionAddress;

	private static int GetAutoActivatePlayerIndex_ParamsSize;

	private static bool GetAutoActivatePlayerIndex_ReturnValue_IsValid;

	private static FFieldAddress GetAutoActivatePlayerIndex_ReturnValue_PropertyAddress;

	private static int GetAutoActivatePlayerIndex_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.CameraActor:CameraComponent")]
	public UCameraComponent CameraComponent
	{
		get
		{
			CheckDestroyed();
			if (!CameraComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraActor:CameraComponent");
				return null;
			}
			return UObjectMarshaler<UCameraComponent>.FromNative(IntPtr.Add(base.Address, CameraComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraActor:CameraComponent");
			}
			else
			{
				UObjectMarshaler<UCameraComponent>.ToNative(IntPtr.Add(base.Address, CameraComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.CameraActor:SceneComponent")]
	public USceneComponent SceneComponent
	{
		get
		{
			CheckDestroyed();
			if (!SceneComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraActor:SceneComponent");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, SceneComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraActor:SceneComponent");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, SceneComponent_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CameraActor:GetAutoActivatePlayerIndex")]
	public unsafe int GetAutoActivatePlayerIndex()
	{
		CheckDestroyed();
		if (!GetAutoActivatePlayerIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraActor:GetAutoActivatePlayerIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAutoActivatePlayerIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAutoActivatePlayerIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAutoActivatePlayerIndex_FunctionAddress, intPtr, GetAutoActivatePlayerIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAutoActivatePlayerIndex_ReturnValue_Offset), 0, GetAutoActivatePlayerIndex_ReturnValue_PropertyAddress.Address);
	}

	static ACameraActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACameraActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACameraActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.CameraActor");
		CameraComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraComponent");
		CameraComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraComponent", Classes.FObjectProperty);
		SceneComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SceneComponent");
		SceneComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SceneComponent", Classes.FObjectProperty);
		GetAutoActivatePlayerIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAutoActivatePlayerIndex");
		GetAutoActivatePlayerIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAutoActivatePlayerIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAutoActivatePlayerIndex_ReturnValue_PropertyAddress, GetAutoActivatePlayerIndex_FunctionAddress, "ReturnValue");
		GetAutoActivatePlayerIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAutoActivatePlayerIndex_FunctionAddress, "ReturnValue");
		GetAutoActivatePlayerIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAutoActivatePlayerIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetAutoActivatePlayerIndex_IsValid = GetAutoActivatePlayerIndex_FunctionAddress != IntPtr.Zero && GetAutoActivatePlayerIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraActor:GetAutoActivatePlayerIndex", GetAutoActivatePlayerIndex_IsValid);
	}
}
