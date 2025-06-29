using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SceneCapture2D", "Engine", UnrealModuleType.Engine)]
public class ASceneCapture2D : ASceneCapture
{
	private static bool CaptureComponent2D_IsValid;

	private static int CaptureComponent2D_Offset;

	private static bool OnInterpToggle_IsValid;

	private static IntPtr OnInterpToggle_FunctionAddress;

	private static int OnInterpToggle_ParamsSize;

	private static bool OnInterpToggle_bEnable_IsValid;

	private static FFieldAddress OnInterpToggle_bEnable_PropertyAddress;

	private static int OnInterpToggle_bEnable_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.SceneCapture2D:CaptureComponent2D")]
	public USceneCaptureComponent2D CaptureComponent2D
	{
		get
		{
			CheckDestroyed();
			if (!CaptureComponent2D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCapture2D:CaptureComponent2D");
				return null;
			}
			return UObjectMarshaler<USceneCaptureComponent2D>.FromNative(IntPtr.Add(base.Address, CaptureComponent2D_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CaptureComponent2D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCapture2D:CaptureComponent2D");
			}
			else
			{
				UObjectMarshaler<USceneCaptureComponent2D>.ToNative(IntPtr.Add(base.Address, CaptureComponent2D_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCapture2D:OnInterpToggle")]
	public unsafe void OnInterpToggle(bool bEnable)
	{
		CheckDestroyed();
		if (!OnInterpToggle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCapture2D:OnInterpToggle");
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

	static ASceneCapture2D()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ASceneCapture2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ASceneCapture2D));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SceneCapture2D");
		CaptureComponent2D_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CaptureComponent2D");
		CaptureComponent2D_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CaptureComponent2D", Classes.FObjectProperty);
		OnInterpToggle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInterpToggle");
		OnInterpToggle_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInterpToggle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInterpToggle_bEnable_PropertyAddress, OnInterpToggle_FunctionAddress, "bEnable");
		OnInterpToggle_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(OnInterpToggle_FunctionAddress, "bEnable");
		OnInterpToggle_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInterpToggle_FunctionAddress, "bEnable", Classes.FBoolProperty);
		OnInterpToggle_IsValid = OnInterpToggle_FunctionAddress != IntPtr.Zero && OnInterpToggle_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCapture2D:OnInterpToggle", OnInterpToggle_IsValid);
	}
}
