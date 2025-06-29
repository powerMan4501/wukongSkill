using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SceneCaptureCube", "Engine", UnrealModuleType.Engine)]
public class ASceneCaptureCube : ASceneCapture
{
	private static bool CaptureComponentCube_IsValid;

	private static int CaptureComponentCube_Offset;

	private static bool OnInterpToggle_IsValid;

	private static IntPtr OnInterpToggle_FunctionAddress;

	private static int OnInterpToggle_ParamsSize;

	private static bool OnInterpToggle_bEnable_IsValid;

	private static FFieldAddress OnInterpToggle_bEnable_PropertyAddress;

	private static int OnInterpToggle_bEnable_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.SceneCaptureCube:CaptureComponentCube")]
	public USceneCaptureComponentCube CaptureComponentCube
	{
		get
		{
			CheckDestroyed();
			if (!CaptureComponentCube_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureCube:CaptureComponentCube");
				return null;
			}
			return UObjectMarshaler<USceneCaptureComponentCube>.FromNative(IntPtr.Add(base.Address, CaptureComponentCube_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CaptureComponentCube_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureCube:CaptureComponentCube");
			}
			else
			{
				UObjectMarshaler<USceneCaptureComponentCube>.ToNative(IntPtr.Add(base.Address, CaptureComponentCube_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureCube:OnInterpToggle")]
	public unsafe void OnInterpToggle(bool bEnable)
	{
		CheckDestroyed();
		if (!OnInterpToggle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureCube:OnInterpToggle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInterpToggle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInterpToggle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnInterpToggle_bEnable_Offset), 0, OnInterpToggle_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInterpToggle_FunctionAddress, intPtr, OnInterpToggle_ParamsSize);
	}

	static ASceneCaptureCube()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ASceneCaptureCube)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ASceneCaptureCube));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SceneCaptureCube");
		CaptureComponentCube_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CaptureComponentCube");
		CaptureComponentCube_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CaptureComponentCube", Classes.FObjectProperty);
		OnInterpToggle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInterpToggle");
		OnInterpToggle_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInterpToggle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInterpToggle_bEnable_PropertyAddress, OnInterpToggle_FunctionAddress, "bEnable");
		OnInterpToggle_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(OnInterpToggle_FunctionAddress, "bEnable");
		OnInterpToggle_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInterpToggle_FunctionAddress, "bEnable", Classes.FBoolProperty);
		OnInterpToggle_IsValid = OnInterpToggle_FunctionAddress != IntPtr.Zero && OnInterpToggle_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureCube:OnInterpToggle", OnInterpToggle_IsValid);
	}
}
