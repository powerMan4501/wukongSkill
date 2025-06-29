using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioExtensions;

public sealed class IAudioParameterControllerInterfaceImpl : IInterfaceImpl, IAudioParameterControllerInterface, IInterface
{
	private static bool SetTriggerParameter_IsValid;

	private IntPtr SetTriggerParameter_InstanceFunctionAddress;

	private static IntPtr SetTriggerParameter_FunctionAddress;

	private static int SetTriggerParameter_ParamsSize;

	private static bool SetTriggerParameter_InName_IsValid;

	private static FFieldAddress SetTriggerParameter_InName_PropertyAddress;

	private static int SetTriggerParameter_InName_Offset;

	private static bool SetStringParameter_IsValid;

	private IntPtr SetStringParameter_InstanceFunctionAddress;

	private static IntPtr SetStringParameter_FunctionAddress;

	private static int SetStringParameter_ParamsSize;

	private static bool SetStringParameter_InName_IsValid;

	private static FFieldAddress SetStringParameter_InName_PropertyAddress;

	private static int SetStringParameter_InName_Offset;

	private static bool SetStringParameter_InValue_IsValid;

	private static FFieldAddress SetStringParameter_InValue_PropertyAddress;

	private static int SetStringParameter_InValue_Offset;

	private static bool SetStringArrayParameter_IsValid;

	private IntPtr SetStringArrayParameter_InstanceFunctionAddress;

	private static IntPtr SetStringArrayParameter_FunctionAddress;

	private static int SetStringArrayParameter_ParamsSize;

	private static bool SetStringArrayParameter_InName_IsValid;

	private static FFieldAddress SetStringArrayParameter_InName_PropertyAddress;

	private static int SetStringArrayParameter_InName_Offset;

	private static bool SetStringArrayParameter_InValue_IsValid;

	private static FFieldAddress SetStringArrayParameter_InValue_PropertyAddress;

	private static int SetStringArrayParameter_InValue_Offset;

	private static bool SetParameters_Blueprint_IsValid;

	private IntPtr SetParameters_Blueprint_InstanceFunctionAddress;

	private static IntPtr SetParameters_Blueprint_FunctionAddress;

	private static int SetParameters_Blueprint_ParamsSize;

	private static bool SetParameters_Blueprint_InParameters_IsValid;

	private static FFieldAddress SetParameters_Blueprint_InParameters_PropertyAddress;

	private static int SetParameters_Blueprint_InParameters_Offset;

	private static bool SetObjectParameter_IsValid;

	private IntPtr SetObjectParameter_InstanceFunctionAddress;

	private static IntPtr SetObjectParameter_FunctionAddress;

	private static int SetObjectParameter_ParamsSize;

	private static bool SetObjectParameter_InName_IsValid;

	private static FFieldAddress SetObjectParameter_InName_PropertyAddress;

	private static int SetObjectParameter_InName_Offset;

	private static bool SetObjectParameter_InValue_IsValid;

	private static FFieldAddress SetObjectParameter_InValue_PropertyAddress;

	private static int SetObjectParameter_InValue_Offset;

	private static bool SetObjectArrayParameter_IsValid;

	private IntPtr SetObjectArrayParameter_InstanceFunctionAddress;

	private static IntPtr SetObjectArrayParameter_FunctionAddress;

	private static int SetObjectArrayParameter_ParamsSize;

	private static bool SetObjectArrayParameter_InName_IsValid;

	private static FFieldAddress SetObjectArrayParameter_InName_PropertyAddress;

	private static int SetObjectArrayParameter_InName_Offset;

	private static bool SetObjectArrayParameter_InValue_IsValid;

	private static FFieldAddress SetObjectArrayParameter_InValue_PropertyAddress;

	private static int SetObjectArrayParameter_InValue_Offset;

	private static bool SetIntParameter_IsValid;

	private IntPtr SetIntParameter_InstanceFunctionAddress;

	private static IntPtr SetIntParameter_FunctionAddress;

	private static int SetIntParameter_ParamsSize;

	private static bool SetIntParameter_InName_IsValid;

	private static FFieldAddress SetIntParameter_InName_PropertyAddress;

	private static int SetIntParameter_InName_Offset;

	private static bool SetIntParameter_InInt_IsValid;

	private static FFieldAddress SetIntParameter_InInt_PropertyAddress;

	private static int SetIntParameter_InInt_Offset;

	private static bool SetIntArrayParameter_IsValid;

	private IntPtr SetIntArrayParameter_InstanceFunctionAddress;

	private static IntPtr SetIntArrayParameter_FunctionAddress;

	private static int SetIntArrayParameter_ParamsSize;

	private static bool SetIntArrayParameter_InName_IsValid;

	private static FFieldAddress SetIntArrayParameter_InName_PropertyAddress;

	private static int SetIntArrayParameter_InName_Offset;

	private static bool SetIntArrayParameter_InValue_IsValid;

	private static FFieldAddress SetIntArrayParameter_InValue_PropertyAddress;

	private static int SetIntArrayParameter_InValue_Offset;

	private static bool SetFloatParameter_IsValid;

	private IntPtr SetFloatParameter_InstanceFunctionAddress;

	private static IntPtr SetFloatParameter_FunctionAddress;

	private static int SetFloatParameter_ParamsSize;

	private static bool SetFloatParameter_InName_IsValid;

	private static FFieldAddress SetFloatParameter_InName_PropertyAddress;

	private static int SetFloatParameter_InName_Offset;

	private static bool SetFloatParameter_InFloat_IsValid;

	private static FFieldAddress SetFloatParameter_InFloat_PropertyAddress;

	private static int SetFloatParameter_InFloat_Offset;

	private static bool SetFloatArrayParameter_IsValid;

	private IntPtr SetFloatArrayParameter_InstanceFunctionAddress;

	private static IntPtr SetFloatArrayParameter_FunctionAddress;

	private static int SetFloatArrayParameter_ParamsSize;

	private static bool SetFloatArrayParameter_InName_IsValid;

	private static FFieldAddress SetFloatArrayParameter_InName_PropertyAddress;

	private static int SetFloatArrayParameter_InName_Offset;

	private static bool SetFloatArrayParameter_InValue_IsValid;

	private static FFieldAddress SetFloatArrayParameter_InValue_PropertyAddress;

	private static int SetFloatArrayParameter_InValue_Offset;

	private static bool SetBoolParameter_IsValid;

	private IntPtr SetBoolParameter_InstanceFunctionAddress;

	private static IntPtr SetBoolParameter_FunctionAddress;

	private static int SetBoolParameter_ParamsSize;

	private static bool SetBoolParameter_InName_IsValid;

	private static FFieldAddress SetBoolParameter_InName_PropertyAddress;

	private static int SetBoolParameter_InName_Offset;

	private static bool SetBoolParameter_InBool_IsValid;

	private static FFieldAddress SetBoolParameter_InBool_PropertyAddress;

	private static int SetBoolParameter_InBool_Offset;

	private static bool SetBoolArrayParameter_IsValid;

	private IntPtr SetBoolArrayParameter_InstanceFunctionAddress;

	private static IntPtr SetBoolArrayParameter_FunctionAddress;

	private static int SetBoolArrayParameter_ParamsSize;

	private static bool SetBoolArrayParameter_InName_IsValid;

	private static FFieldAddress SetBoolArrayParameter_InName_PropertyAddress;

	private static int SetBoolArrayParameter_InName_Offset;

	private static bool SetBoolArrayParameter_InValue_IsValid;

	private static FFieldAddress SetBoolArrayParameter_InValue_PropertyAddress;

	private static int SetBoolArrayParameter_InValue_Offset;

	private static bool ResetParameters_IsValid;

	private IntPtr ResetParameters_InstanceFunctionAddress;

	private static IntPtr ResetParameters_FunctionAddress;

	private static int ResetParameters_ParamsSize;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetTriggerParameter")]
	public unsafe void SetTriggerParameter(FName InName)
	{
		CheckDestroyed();
		if (!SetTriggerParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:SetTriggerParameter");
			return;
		}
		if (SetTriggerParameter_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetTriggerParameter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetTriggerParameter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTriggerParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTriggerParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetTriggerParameter_InName_Offset), 0, SetTriggerParameter_InName_PropertyAddress.Address, InName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTriggerParameter_InstanceFunctionAddress, intPtr, SetTriggerParameter_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetStringParameter")]
	public unsafe void SetStringParameter(FName InName, string InValue)
	{
		CheckDestroyed();
		if (!SetStringParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:SetStringParameter");
			return;
		}
		if (SetStringParameter_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetStringParameter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetStringParameter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStringParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStringParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetStringParameter_InName_Offset), 0, SetStringParameter_InName_PropertyAddress.Address, InName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetStringParameter_InValue_Offset), 0, SetStringParameter_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStringParameter_InstanceFunctionAddress, intPtr, SetStringParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStringParameter_InValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetStringArrayParameter")]
	public unsafe void SetStringArrayParameter(FName InName, List<string> InValue)
	{
		CheckDestroyed();
		if (!SetStringArrayParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:SetStringArrayParameter");
			return;
		}
		if (SetStringArrayParameter_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetStringArrayParameter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetStringArrayParameter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStringArrayParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStringArrayParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetStringArrayParameter_InName_Offset), 0, SetStringArrayParameter_InName_PropertyAddress.Address, InName);
		new TArrayCopyMarshaler<string>(1, SetStringArrayParameter_InValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetStringArrayParameter_InValue_Offset), InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStringArrayParameter_InstanceFunctionAddress, intPtr, SetStringArrayParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStringArrayParameter_InValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetParameters_Blueprint")]
	public unsafe void SetParameters_Blueprint(List<FAudioParameter> InParameters)
	{
		CheckDestroyed();
		if (!SetParameters_Blueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:SetParameters_Blueprint");
			return;
		}
		if (SetParameters_Blueprint_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetParameters_Blueprint_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetParameters_Blueprint");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParameters_Blueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParameters_Blueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAudioParameter>(1, SetParameters_Blueprint_InParameters_PropertyAddress, CachedMarshalingDelegates<FAudioParameter, FAudioParameter>.FromNative, CachedMarshalingDelegates<FAudioParameter, FAudioParameter>.ToNative).ToNative(IntPtr.Add(intPtr, SetParameters_Blueprint_InParameters_Offset), InParameters);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParameters_Blueprint_InstanceFunctionAddress, intPtr, SetParameters_Blueprint_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetParameters_Blueprint_InParameters_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetObjectParameter")]
	public unsafe void SetObjectParameter(FName InName, UObject InValue)
	{
		CheckDestroyed();
		if (!SetObjectParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:SetObjectParameter");
			return;
		}
		if (SetObjectParameter_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetObjectParameter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetObjectParameter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetObjectParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetObjectParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetObjectParameter_InName_Offset), 0, SetObjectParameter_InName_PropertyAddress.Address, InName);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetObjectParameter_InValue_Offset), 0, SetObjectParameter_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetObjectParameter_InstanceFunctionAddress, intPtr, SetObjectParameter_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetObjectArrayParameter")]
	public unsafe void SetObjectArrayParameter(FName InName, List<UObject> InValue)
	{
		CheckDestroyed();
		if (!SetObjectArrayParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:SetObjectArrayParameter");
			return;
		}
		if (SetObjectArrayParameter_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetObjectArrayParameter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetObjectArrayParameter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetObjectArrayParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetObjectArrayParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetObjectArrayParameter_InName_Offset), 0, SetObjectArrayParameter_InName_PropertyAddress.Address, InName);
		new TArrayCopyMarshaler<UObject>(1, SetObjectArrayParameter_InValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetObjectArrayParameter_InValue_Offset), InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetObjectArrayParameter_InstanceFunctionAddress, intPtr, SetObjectArrayParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetObjectArrayParameter_InValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetIntParameter")]
	public unsafe void SetIntParameter(FName InName, int InInt)
	{
		CheckDestroyed();
		if (!SetIntParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:SetIntParameter");
			return;
		}
		if (SetIntParameter_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetIntParameter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetIntParameter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIntParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIntParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetIntParameter_InName_Offset), 0, SetIntParameter_InName_PropertyAddress.Address, InName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetIntParameter_InInt_Offset), 0, SetIntParameter_InInt_PropertyAddress.Address, InInt);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIntParameter_InstanceFunctionAddress, intPtr, SetIntParameter_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetIntArrayParameter")]
	public unsafe void SetIntArrayParameter(FName InName, List<int> InValue)
	{
		CheckDestroyed();
		if (!SetIntArrayParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:SetIntArrayParameter");
			return;
		}
		if (SetIntArrayParameter_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetIntArrayParameter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetIntArrayParameter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIntArrayParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIntArrayParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetIntArrayParameter_InName_Offset), 0, SetIntArrayParameter_InName_PropertyAddress.Address, InName);
		new TArrayCopyMarshaler<int>(1, SetIntArrayParameter_InValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, SetIntArrayParameter_InValue_Offset), InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIntArrayParameter_InstanceFunctionAddress, intPtr, SetIntArrayParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetIntArrayParameter_InValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetFloatParameter")]
	public unsafe void SetFloatParameter(FName InName, float InFloat)
	{
		CheckDestroyed();
		if (!SetFloatParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:SetFloatParameter");
			return;
		}
		if (SetFloatParameter_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetFloatParameter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetFloatParameter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFloatParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFloatParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFloatParameter_InName_Offset), 0, SetFloatParameter_InName_PropertyAddress.Address, InName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFloatParameter_InFloat_Offset), 0, SetFloatParameter_InFloat_PropertyAddress.Address, InFloat);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFloatParameter_InstanceFunctionAddress, intPtr, SetFloatParameter_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetFloatArrayParameter")]
	public unsafe void SetFloatArrayParameter(FName InName, List<float> InValue)
	{
		CheckDestroyed();
		if (!SetFloatArrayParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:SetFloatArrayParameter");
			return;
		}
		if (SetFloatArrayParameter_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetFloatArrayParameter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetFloatArrayParameter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFloatArrayParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFloatArrayParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFloatArrayParameter_InName_Offset), 0, SetFloatArrayParameter_InName_PropertyAddress.Address, InName);
		new TArrayCopyMarshaler<float>(1, SetFloatArrayParameter_InValue_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, SetFloatArrayParameter_InValue_Offset), InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFloatArrayParameter_InstanceFunctionAddress, intPtr, SetFloatArrayParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetFloatArrayParameter_InValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetBoolParameter")]
	public unsafe void SetBoolParameter(FName InName, bool InBool)
	{
		CheckDestroyed();
		if (!SetBoolParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:SetBoolParameter");
			return;
		}
		if (SetBoolParameter_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetBoolParameter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetBoolParameter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoolParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoolParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoolParameter_InName_Offset), 0, SetBoolParameter_InName_PropertyAddress.Address, InName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoolParameter_InBool_Offset), 0, SetBoolParameter_InBool_PropertyAddress.Address, InBool);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoolParameter_InstanceFunctionAddress, intPtr, SetBoolParameter_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:SetBoolArrayParameter")]
	public unsafe void SetBoolArrayParameter(FName InName, List<bool> InValue)
	{
		CheckDestroyed();
		if (!SetBoolArrayParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:SetBoolArrayParameter");
			return;
		}
		if (SetBoolArrayParameter_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetBoolArrayParameter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetBoolArrayParameter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoolArrayParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoolArrayParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoolArrayParameter_InName_Offset), 0, SetBoolArrayParameter_InName_PropertyAddress.Address, InName);
		new TArrayCopyMarshaler<bool>(1, SetBoolArrayParameter_InValue_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetBoolArrayParameter_InValue_Offset), InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoolArrayParameter_InstanceFunctionAddress, intPtr, SetBoolArrayParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBoolArrayParameter_InValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioExtensions.AudioParameterControllerInterface:ResetParameters")]
	public unsafe void ResetParameters()
	{
		CheckDestroyed();
		if (!ResetParameters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioExtensions.AudioParameterControllerInterface:ResetParameters");
			return;
		}
		if (ResetParameters_InstanceFunctionAddress == IntPtr.Zero)
		{
			ResetParameters_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ResetParameters");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetParameters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetParameters_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetParameters_InstanceFunctionAddress, argsSize: ResetParameters_ParamsSize);
	}

	public override void ResetInterface()
	{
		SetTriggerParameter_InstanceFunctionAddress = IntPtr.Zero;
		SetStringParameter_InstanceFunctionAddress = IntPtr.Zero;
		SetStringArrayParameter_InstanceFunctionAddress = IntPtr.Zero;
		SetParameters_Blueprint_InstanceFunctionAddress = IntPtr.Zero;
		SetObjectParameter_InstanceFunctionAddress = IntPtr.Zero;
		SetObjectArrayParameter_InstanceFunctionAddress = IntPtr.Zero;
		SetIntParameter_InstanceFunctionAddress = IntPtr.Zero;
		SetIntArrayParameter_InstanceFunctionAddress = IntPtr.Zero;
		SetFloatParameter_InstanceFunctionAddress = IntPtr.Zero;
		SetFloatArrayParameter_InstanceFunctionAddress = IntPtr.Zero;
		SetBoolParameter_InstanceFunctionAddress = IntPtr.Zero;
		SetBoolArrayParameter_InstanceFunctionAddress = IntPtr.Zero;
		ResetParameters_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IAudioParameterControllerInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IAudioParameterControllerInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IAudioParameterControllerInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AudioExtensions.AudioParameterControllerInterface");
		SetTriggerParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTriggerParameter");
		SetTriggerParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTriggerParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTriggerParameter_InName_PropertyAddress, SetTriggerParameter_FunctionAddress, "InName");
		SetTriggerParameter_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetTriggerParameter_FunctionAddress, "InName");
		SetTriggerParameter_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTriggerParameter_FunctionAddress, "InName", Classes.FNameProperty);
		SetTriggerParameter_IsValid = SetTriggerParameter_FunctionAddress != IntPtr.Zero && SetTriggerParameter_InName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:SetTriggerParameter", SetTriggerParameter_IsValid);
		SetStringParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetStringParameter");
		SetStringParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStringParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStringParameter_InName_PropertyAddress, SetStringParameter_FunctionAddress, "InName");
		SetStringParameter_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetStringParameter_FunctionAddress, "InName");
		SetStringParameter_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringParameter_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStringParameter_InValue_PropertyAddress, SetStringParameter_FunctionAddress, "InValue");
		SetStringParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStringParameter_FunctionAddress, "InValue");
		SetStringParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringParameter_FunctionAddress, "InValue", Classes.FStrProperty);
		SetStringParameter_IsValid = SetStringParameter_FunctionAddress != IntPtr.Zero && SetStringParameter_InName_IsValid && SetStringParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:SetStringParameter", SetStringParameter_IsValid);
		SetStringArrayParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetStringArrayParameter");
		SetStringArrayParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStringArrayParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStringArrayParameter_InName_PropertyAddress, SetStringArrayParameter_FunctionAddress, "InName");
		SetStringArrayParameter_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetStringArrayParameter_FunctionAddress, "InName");
		SetStringArrayParameter_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringArrayParameter_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStringArrayParameter_InValue_PropertyAddress, SetStringArrayParameter_FunctionAddress, "InValue");
		SetStringArrayParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStringArrayParameter_FunctionAddress, "InValue");
		SetStringArrayParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStringArrayParameter_FunctionAddress, "InValue", Classes.FArrayProperty);
		SetStringArrayParameter_IsValid = SetStringArrayParameter_FunctionAddress != IntPtr.Zero && SetStringArrayParameter_InName_IsValid && SetStringArrayParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:SetStringArrayParameter", SetStringArrayParameter_IsValid);
		SetParameters_Blueprint_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParameters_Blueprint");
		SetParameters_Blueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParameters_Blueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParameters_Blueprint_InParameters_PropertyAddress, SetParameters_Blueprint_FunctionAddress, "InParameters");
		SetParameters_Blueprint_InParameters_Offset = NativeReflectionCached.GetPropertyOffset(SetParameters_Blueprint_FunctionAddress, "InParameters");
		SetParameters_Blueprint_InParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParameters_Blueprint_FunctionAddress, "InParameters", Classes.FArrayProperty);
		SetParameters_Blueprint_IsValid = SetParameters_Blueprint_FunctionAddress != IntPtr.Zero && SetParameters_Blueprint_InParameters_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:SetParameters_Blueprint", SetParameters_Blueprint_IsValid);
		SetObjectParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetObjectParameter");
		SetObjectParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetObjectParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetObjectParameter_InName_PropertyAddress, SetObjectParameter_FunctionAddress, "InName");
		SetObjectParameter_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetObjectParameter_FunctionAddress, "InName");
		SetObjectParameter_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjectParameter_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetObjectParameter_InValue_PropertyAddress, SetObjectParameter_FunctionAddress, "InValue");
		SetObjectParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetObjectParameter_FunctionAddress, "InValue");
		SetObjectParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjectParameter_FunctionAddress, "InValue", Classes.FObjectProperty);
		SetObjectParameter_IsValid = SetObjectParameter_FunctionAddress != IntPtr.Zero && SetObjectParameter_InName_IsValid && SetObjectParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:SetObjectParameter", SetObjectParameter_IsValid);
		SetObjectArrayParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetObjectArrayParameter");
		SetObjectArrayParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetObjectArrayParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetObjectArrayParameter_InName_PropertyAddress, SetObjectArrayParameter_FunctionAddress, "InName");
		SetObjectArrayParameter_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetObjectArrayParameter_FunctionAddress, "InName");
		SetObjectArrayParameter_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjectArrayParameter_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetObjectArrayParameter_InValue_PropertyAddress, SetObjectArrayParameter_FunctionAddress, "InValue");
		SetObjectArrayParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetObjectArrayParameter_FunctionAddress, "InValue");
		SetObjectArrayParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjectArrayParameter_FunctionAddress, "InValue", Classes.FArrayProperty);
		SetObjectArrayParameter_IsValid = SetObjectArrayParameter_FunctionAddress != IntPtr.Zero && SetObjectArrayParameter_InName_IsValid && SetObjectArrayParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:SetObjectArrayParameter", SetObjectArrayParameter_IsValid);
		SetIntParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetIntParameter");
		SetIntParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIntParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIntParameter_InName_PropertyAddress, SetIntParameter_FunctionAddress, "InName");
		SetIntParameter_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetIntParameter_FunctionAddress, "InName");
		SetIntParameter_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntParameter_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIntParameter_InInt_PropertyAddress, SetIntParameter_FunctionAddress, "InInt");
		SetIntParameter_InInt_Offset = NativeReflectionCached.GetPropertyOffset(SetIntParameter_FunctionAddress, "InInt");
		SetIntParameter_InInt_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntParameter_FunctionAddress, "InInt", Classes.FIntProperty);
		SetIntParameter_IsValid = SetIntParameter_FunctionAddress != IntPtr.Zero && SetIntParameter_InName_IsValid && SetIntParameter_InInt_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:SetIntParameter", SetIntParameter_IsValid);
		SetIntArrayParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetIntArrayParameter");
		SetIntArrayParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIntArrayParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIntArrayParameter_InName_PropertyAddress, SetIntArrayParameter_FunctionAddress, "InName");
		SetIntArrayParameter_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetIntArrayParameter_FunctionAddress, "InName");
		SetIntArrayParameter_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntArrayParameter_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIntArrayParameter_InValue_PropertyAddress, SetIntArrayParameter_FunctionAddress, "InValue");
		SetIntArrayParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetIntArrayParameter_FunctionAddress, "InValue");
		SetIntArrayParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntArrayParameter_FunctionAddress, "InValue", Classes.FArrayProperty);
		SetIntArrayParameter_IsValid = SetIntArrayParameter_FunctionAddress != IntPtr.Zero && SetIntArrayParameter_InName_IsValid && SetIntArrayParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:SetIntArrayParameter", SetIntArrayParameter_IsValid);
		SetFloatParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetFloatParameter");
		SetFloatParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloatParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFloatParameter_InName_PropertyAddress, SetFloatParameter_FunctionAddress, "InName");
		SetFloatParameter_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatParameter_FunctionAddress, "InName");
		SetFloatParameter_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatParameter_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatParameter_InFloat_PropertyAddress, SetFloatParameter_FunctionAddress, "InFloat");
		SetFloatParameter_InFloat_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatParameter_FunctionAddress, "InFloat");
		SetFloatParameter_InFloat_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatParameter_FunctionAddress, "InFloat", Classes.FFloatProperty);
		SetFloatParameter_IsValid = SetFloatParameter_FunctionAddress != IntPtr.Zero && SetFloatParameter_InName_IsValid && SetFloatParameter_InFloat_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:SetFloatParameter", SetFloatParameter_IsValid);
		SetFloatArrayParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetFloatArrayParameter");
		SetFloatArrayParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloatArrayParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFloatArrayParameter_InName_PropertyAddress, SetFloatArrayParameter_FunctionAddress, "InName");
		SetFloatArrayParameter_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatArrayParameter_FunctionAddress, "InName");
		SetFloatArrayParameter_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatArrayParameter_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatArrayParameter_InValue_PropertyAddress, SetFloatArrayParameter_FunctionAddress, "InValue");
		SetFloatArrayParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatArrayParameter_FunctionAddress, "InValue");
		SetFloatArrayParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatArrayParameter_FunctionAddress, "InValue", Classes.FArrayProperty);
		SetFloatArrayParameter_IsValid = SetFloatArrayParameter_FunctionAddress != IntPtr.Zero && SetFloatArrayParameter_InName_IsValid && SetFloatArrayParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:SetFloatArrayParameter", SetFloatArrayParameter_IsValid);
		SetBoolParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBoolParameter");
		SetBoolParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoolParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoolParameter_InName_PropertyAddress, SetBoolParameter_FunctionAddress, "InName");
		SetBoolParameter_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolParameter_FunctionAddress, "InName");
		SetBoolParameter_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolParameter_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolParameter_InBool_PropertyAddress, SetBoolParameter_FunctionAddress, "InBool");
		SetBoolParameter_InBool_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolParameter_FunctionAddress, "InBool");
		SetBoolParameter_InBool_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolParameter_FunctionAddress, "InBool", Classes.FBoolProperty);
		SetBoolParameter_IsValid = SetBoolParameter_FunctionAddress != IntPtr.Zero && SetBoolParameter_InName_IsValid && SetBoolParameter_InBool_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:SetBoolParameter", SetBoolParameter_IsValid);
		SetBoolArrayParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBoolArrayParameter");
		SetBoolArrayParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoolArrayParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoolArrayParameter_InName_PropertyAddress, SetBoolArrayParameter_FunctionAddress, "InName");
		SetBoolArrayParameter_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolArrayParameter_FunctionAddress, "InName");
		SetBoolArrayParameter_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolArrayParameter_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolArrayParameter_InValue_PropertyAddress, SetBoolArrayParameter_FunctionAddress, "InValue");
		SetBoolArrayParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolArrayParameter_FunctionAddress, "InValue");
		SetBoolArrayParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolArrayParameter_FunctionAddress, "InValue", Classes.FArrayProperty);
		SetBoolArrayParameter_IsValid = SetBoolArrayParameter_FunctionAddress != IntPtr.Zero && SetBoolArrayParameter_InName_IsValid && SetBoolArrayParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:SetBoolArrayParameter", SetBoolArrayParameter_IsValid);
		ResetParameters_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetParameters");
		ResetParameters_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetParameters_FunctionAddress);
		ResetParameters_IsValid = ResetParameters_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AudioExtensions.AudioParameterControllerInterface:ResetParameters", ResetParameters_IsValid);
	}
}
