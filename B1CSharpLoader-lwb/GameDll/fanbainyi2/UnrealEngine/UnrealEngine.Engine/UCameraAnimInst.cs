using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938024uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.CameraAnimInst", "Engine", UnrealModuleType.Engine)]
public class UCameraAnimInst : UObject
{
	private static bool PlayRate_IsValid;

	private static int PlayRate_Offset;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool Stop_bImmediate_IsValid;

	private static FFieldAddress Stop_bImmediate_PropertyAddress;

	private static int Stop_bImmediate_Offset;

	private static bool SetScale_IsValid;

	private static IntPtr SetScale_FunctionAddress;

	private static int SetScale_ParamsSize;

	private static bool SetScale_NewDuration_IsValid;

	private static FFieldAddress SetScale_NewDuration_PropertyAddress;

	private static int SetScale_NewDuration_Offset;

	private static bool SetDuration_IsValid;

	private static IntPtr SetDuration_FunctionAddress;

	private static int SetDuration_ParamsSize;

	private static bool SetDuration_NewDuration_IsValid;

	private static FFieldAddress SetDuration_NewDuration_PropertyAddress;

	private static int SetDuration_NewDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.CameraAnimInst:PlayRate")]
	public float PlayRate
	{
		get
		{
			CheckDestroyed();
			if (!PlayRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraAnimInst:PlayRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PlayRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraAnimInst:PlayRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PlayRate_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraAnimInst:Stop")]
	public unsafe void Stop(bool bImmediate = false)
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraAnimInst:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Stop_bImmediate_Offset), 0, Stop_bImmediate_PropertyAddress.Address, bImmediate);
		NativeReflection.InvokeFunctionOptimized(base.Address, Stop_FunctionAddress, intPtr, Stop_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraAnimInst:SetScale")]
	public unsafe void SetScale(float NewDuration)
	{
		CheckDestroyed();
		if (!SetScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraAnimInst:SetScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetScale_NewDuration_Offset), 0, SetScale_NewDuration_PropertyAddress.Address, NewDuration);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScale_FunctionAddress, intPtr, SetScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraAnimInst:SetDuration")]
	public unsafe void SetDuration(float NewDuration)
	{
		CheckDestroyed();
		if (!SetDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraAnimInst:SetDuration");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDuration_NewDuration_Offset), 0, SetDuration_NewDuration_PropertyAddress.Address, NewDuration);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDuration_FunctionAddress, intPtr, SetDuration_ParamsSize);
	}

	static UCameraAnimInst()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCameraAnimInst)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCameraAnimInst));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.CameraAnimInst");
		PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayRate");
		PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayRate", Classes.FFloatProperty);
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Stop_bImmediate_PropertyAddress, Stop_FunctionAddress, "bImmediate");
		Stop_bImmediate_Offset = NativeReflectionCached.GetPropertyOffset(Stop_FunctionAddress, "bImmediate");
		Stop_bImmediate_IsValid = NativeReflectionCached.ValidatePropertyClass(Stop_FunctionAddress, "bImmediate", Classes.FBoolProperty);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero && Stop_bImmediate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraAnimInst:Stop", Stop_IsValid);
		SetScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScale");
		SetScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScale_NewDuration_PropertyAddress, SetScale_FunctionAddress, "NewDuration");
		SetScale_NewDuration_Offset = NativeReflectionCached.GetPropertyOffset(SetScale_FunctionAddress, "NewDuration");
		SetScale_NewDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScale_FunctionAddress, "NewDuration", Classes.FFloatProperty);
		SetScale_IsValid = SetScale_FunctionAddress != IntPtr.Zero && SetScale_NewDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraAnimInst:SetScale", SetScale_IsValid);
		SetDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDuration");
		SetDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDuration_NewDuration_PropertyAddress, SetDuration_FunctionAddress, "NewDuration");
		SetDuration_NewDuration_Offset = NativeReflectionCached.GetPropertyOffset(SetDuration_FunctionAddress, "NewDuration");
		SetDuration_NewDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDuration_FunctionAddress, "NewDuration", Classes.FFloatProperty);
		SetDuration_IsValid = SetDuration_FunctionAddress != IntPtr.Zero && SetDuration_NewDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraAnimInst:SetDuration", SetDuration_IsValid);
	}
}
