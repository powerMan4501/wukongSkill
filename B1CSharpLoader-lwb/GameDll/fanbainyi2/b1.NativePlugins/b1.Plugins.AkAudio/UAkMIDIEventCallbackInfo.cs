using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)817889440uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkMIDIEventCallbackInfo", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkMIDIEventCallbackInfo : UAkEventCallbackInfo
{
	private static bool GetType_IsValid;

	private static IntPtr GetType_FunctionAddress;

	private static int GetType_ParamsSize;

	private static bool GetType_ReturnValue_IsValid;

	private static FFieldAddress GetType_ReturnValue_PropertyAddress;

	private static int GetType_ReturnValue_Offset;

	private static bool GetProgramChange_IsValid;

	private static IntPtr GetProgramChange_FunctionAddress;

	private static int GetProgramChange_ParamsSize;

	private static bool GetProgramChange_AsProgramChange_IsValid;

	private static FFieldAddress GetProgramChange_AsProgramChange_PropertyAddress;

	private static int GetProgramChange_AsProgramChange_Offset;

	private static bool GetProgramChange_ReturnValue_IsValid;

	private static FFieldAddress GetProgramChange_ReturnValue_PropertyAddress;

	private static int GetProgramChange_ReturnValue_Offset;

	private static bool GetPitchBend_IsValid;

	private static IntPtr GetPitchBend_FunctionAddress;

	private static int GetPitchBend_ParamsSize;

	private static bool GetPitchBend_AsPitchBend_IsValid;

	private static FFieldAddress GetPitchBend_AsPitchBend_PropertyAddress;

	private static int GetPitchBend_AsPitchBend_Offset;

	private static bool GetPitchBend_ReturnValue_IsValid;

	private static FFieldAddress GetPitchBend_ReturnValue_PropertyAddress;

	private static int GetPitchBend_ReturnValue_Offset;

	private static bool GetNoteOn_IsValid;

	private static IntPtr GetNoteOn_FunctionAddress;

	private static int GetNoteOn_ParamsSize;

	private static bool GetNoteOn_AsNoteOn_IsValid;

	private static FFieldAddress GetNoteOn_AsNoteOn_PropertyAddress;

	private static int GetNoteOn_AsNoteOn_Offset;

	private static bool GetNoteOn_ReturnValue_IsValid;

	private static FFieldAddress GetNoteOn_ReturnValue_PropertyAddress;

	private static int GetNoteOn_ReturnValue_Offset;

	private static bool GetNoteOff_IsValid;

	private static IntPtr GetNoteOff_FunctionAddress;

	private static int GetNoteOff_ParamsSize;

	private static bool GetNoteOff_AsNoteOff_IsValid;

	private static FFieldAddress GetNoteOff_AsNoteOff_PropertyAddress;

	private static int GetNoteOff_AsNoteOff_Offset;

	private static bool GetNoteOff_ReturnValue_IsValid;

	private static FFieldAddress GetNoteOff_ReturnValue_PropertyAddress;

	private static int GetNoteOff_ReturnValue_Offset;

	private static bool GetNoteAftertouch_IsValid;

	private static IntPtr GetNoteAftertouch_FunctionAddress;

	private static int GetNoteAftertouch_ParamsSize;

	private static bool GetNoteAftertouch_AsNoteAftertouch_IsValid;

	private static FFieldAddress GetNoteAftertouch_AsNoteAftertouch_PropertyAddress;

	private static int GetNoteAftertouch_AsNoteAftertouch_Offset;

	private static bool GetNoteAftertouch_ReturnValue_IsValid;

	private static FFieldAddress GetNoteAftertouch_ReturnValue_PropertyAddress;

	private static int GetNoteAftertouch_ReturnValue_Offset;

	private static bool GetGeneric_IsValid;

	private static IntPtr GetGeneric_FunctionAddress;

	private static int GetGeneric_ParamsSize;

	private static bool GetGeneric_AsGeneric_IsValid;

	private static FFieldAddress GetGeneric_AsGeneric_PropertyAddress;

	private static int GetGeneric_AsGeneric_Offset;

	private static bool GetGeneric_ReturnValue_IsValid;

	private static FFieldAddress GetGeneric_ReturnValue_PropertyAddress;

	private static int GetGeneric_ReturnValue_Offset;

	private static bool GetChannelAftertouch_IsValid;

	private static IntPtr GetChannelAftertouch_FunctionAddress;

	private static int GetChannelAftertouch_ParamsSize;

	private static bool GetChannelAftertouch_AsChannelAftertouch_IsValid;

	private static FFieldAddress GetChannelAftertouch_AsChannelAftertouch_PropertyAddress;

	private static int GetChannelAftertouch_AsChannelAftertouch_Offset;

	private static bool GetChannelAftertouch_ReturnValue_IsValid;

	private static FFieldAddress GetChannelAftertouch_ReturnValue_PropertyAddress;

	private static int GetChannelAftertouch_ReturnValue_Offset;

	private static bool GetChannel_IsValid;

	private static IntPtr GetChannel_FunctionAddress;

	private static int GetChannel_ParamsSize;

	private static bool GetChannel_ReturnValue_IsValid;

	private static FFieldAddress GetChannel_ReturnValue_PropertyAddress;

	private static int GetChannel_ReturnValue_Offset;

	private static bool GetCc_IsValid;

	private static IntPtr GetCc_FunctionAddress;

	private static int GetCc_ParamsSize;

	private static bool GetCc_AsCc_IsValid;

	private static FFieldAddress GetCc_AsCc_PropertyAddress;

	private static int GetCc_AsCc_Offset;

	private static bool GetCc_ReturnValue_IsValid;

	private static FFieldAddress GetCc_ReturnValue_PropertyAddress;

	private static int GetCc_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkMIDIEventCallbackInfo:GetType")]
	public new unsafe EAkMidiEventType GetType()
	{
		CheckDestroyed();
		if (!GetType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkMIDIEventCallbackInfo:GetType");
			return EAkMidiEventType.AkMidiEventTypeInvalid;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetType_FunctionAddress, intPtr, GetType_ParamsSize);
		return EnumMarshaler<EAkMidiEventType>.FromNative(IntPtr.Add(intPtr, GetType_ReturnValue_Offset), 0, GetType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AkAudio.AkMIDIEventCallbackInfo:GetProgramChange")]
	public unsafe bool GetProgramChange(out FAkMidiProgramChange AsProgramChange)
	{
		CheckDestroyed();
		if (!GetProgramChange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkMIDIEventCallbackInfo:GetProgramChange");
			AsProgramChange = default(FAkMidiProgramChange);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProgramChange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProgramChange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetProgramChange_AsProgramChange_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetProgramChange_FunctionAddress, intPtr, GetProgramChange_ParamsSize);
		AsProgramChange = FAkMidiProgramChange.FromNative(IntPtr.Add(intPtr, GetProgramChange_AsProgramChange_Offset), 0, GetProgramChange_AsProgramChange_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetProgramChange_ReturnValue_Offset), 0, GetProgramChange_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AkAudio.AkMIDIEventCallbackInfo:GetPitchBend")]
	public unsafe bool GetPitchBend(out FAkMidiPitchBend AsPitchBend)
	{
		CheckDestroyed();
		if (!GetPitchBend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkMIDIEventCallbackInfo:GetPitchBend");
			AsPitchBend = default(FAkMidiPitchBend);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPitchBend_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPitchBend_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPitchBend_AsPitchBend_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPitchBend_FunctionAddress, intPtr, GetPitchBend_ParamsSize);
		AsPitchBend = FAkMidiPitchBend.FromNative(IntPtr.Add(intPtr, GetPitchBend_AsPitchBend_Offset), 0, GetPitchBend_AsPitchBend_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetPitchBend_ReturnValue_Offset), 0, GetPitchBend_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AkAudio.AkMIDIEventCallbackInfo:GetNoteOn")]
	public unsafe bool GetNoteOn(out FAkMidiNoteOnOff AsNoteOn)
	{
		CheckDestroyed();
		if (!GetNoteOn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkMIDIEventCallbackInfo:GetNoteOn");
			AsNoteOn = default(FAkMidiNoteOnOff);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNoteOn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNoteOn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNoteOn_AsNoteOn_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNoteOn_FunctionAddress, intPtr, GetNoteOn_ParamsSize);
		AsNoteOn = FAkMidiNoteOnOff.FromNative(IntPtr.Add(intPtr, GetNoteOn_AsNoteOn_Offset), 0, GetNoteOn_AsNoteOn_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetNoteOn_ReturnValue_Offset), 0, GetNoteOn_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AkAudio.AkMIDIEventCallbackInfo:GetNoteOff")]
	public unsafe bool GetNoteOff(out FAkMidiNoteOnOff AsNoteOff)
	{
		CheckDestroyed();
		if (!GetNoteOff_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkMIDIEventCallbackInfo:GetNoteOff");
			AsNoteOff = default(FAkMidiNoteOnOff);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNoteOff_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNoteOff_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNoteOff_AsNoteOff_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNoteOff_FunctionAddress, intPtr, GetNoteOff_ParamsSize);
		AsNoteOff = FAkMidiNoteOnOff.FromNative(IntPtr.Add(intPtr, GetNoteOff_AsNoteOff_Offset), 0, GetNoteOff_AsNoteOff_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetNoteOff_ReturnValue_Offset), 0, GetNoteOff_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AkAudio.AkMIDIEventCallbackInfo:GetNoteAftertouch")]
	public unsafe bool GetNoteAftertouch(out FAkMidiNoteAftertouch AsNoteAftertouch)
	{
		CheckDestroyed();
		if (!GetNoteAftertouch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkMIDIEventCallbackInfo:GetNoteAftertouch");
			AsNoteAftertouch = default(FAkMidiNoteAftertouch);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNoteAftertouch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNoteAftertouch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNoteAftertouch_AsNoteAftertouch_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNoteAftertouch_FunctionAddress, intPtr, GetNoteAftertouch_ParamsSize);
		AsNoteAftertouch = FAkMidiNoteAftertouch.FromNative(IntPtr.Add(intPtr, GetNoteAftertouch_AsNoteAftertouch_Offset), 0, GetNoteAftertouch_AsNoteAftertouch_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetNoteAftertouch_ReturnValue_Offset), 0, GetNoteAftertouch_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AkAudio.AkMIDIEventCallbackInfo:GetGeneric")]
	public unsafe bool GetGeneric(out FAkMidiGeneric AsGeneric)
	{
		CheckDestroyed();
		if (!GetGeneric_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkMIDIEventCallbackInfo:GetGeneric");
			AsGeneric = default(FAkMidiGeneric);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGeneric_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGeneric_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetGeneric_AsGeneric_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGeneric_FunctionAddress, intPtr, GetGeneric_ParamsSize);
		AsGeneric = FAkMidiGeneric.FromNative(IntPtr.Add(intPtr, GetGeneric_AsGeneric_Offset), 0, GetGeneric_AsGeneric_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetGeneric_ReturnValue_Offset), 0, GetGeneric_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AkAudio.AkMIDIEventCallbackInfo:GetChannelAftertouch")]
	public unsafe bool GetChannelAftertouch(out FAkMidiChannelAftertouch AsChannelAftertouch)
	{
		CheckDestroyed();
		if (!GetChannelAftertouch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkMIDIEventCallbackInfo:GetChannelAftertouch");
			AsChannelAftertouch = default(FAkMidiChannelAftertouch);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChannelAftertouch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChannelAftertouch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetChannelAftertouch_AsChannelAftertouch_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetChannelAftertouch_FunctionAddress, intPtr, GetChannelAftertouch_ParamsSize);
		AsChannelAftertouch = FAkMidiChannelAftertouch.FromNative(IntPtr.Add(intPtr, GetChannelAftertouch_AsChannelAftertouch_Offset), 0, GetChannelAftertouch_AsChannelAftertouch_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetChannelAftertouch_ReturnValue_Offset), 0, GetChannelAftertouch_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkMIDIEventCallbackInfo:GetChannel")]
	public unsafe byte GetChannel()
	{
		CheckDestroyed();
		if (!GetChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkMIDIEventCallbackInfo:GetChannel");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetChannel_FunctionAddress, intPtr, GetChannel_ParamsSize);
		return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, GetChannel_ReturnValue_Offset), 0, GetChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AkAudio.AkMIDIEventCallbackInfo:GetCc")]
	public unsafe bool GetCc(out FAkMidiCc AsCc)
	{
		CheckDestroyed();
		if (!GetCc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkMIDIEventCallbackInfo:GetCc");
			AsCc = default(FAkMidiCc);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetCc_AsCc_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCc_FunctionAddress, intPtr, GetCc_ParamsSize);
		AsCc = FAkMidiCc.FromNative(IntPtr.Add(intPtr, GetCc_AsCc_Offset), 0, GetCc_AsCc_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCc_ReturnValue_Offset), 0, GetCc_ReturnValue_PropertyAddress.Address);
	}

	static UAkMIDIEventCallbackInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkMIDIEventCallbackInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkMIDIEventCallbackInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AkAudio.AkMIDIEventCallbackInfo");
		GetType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetType");
		GetType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetType_ReturnValue_PropertyAddress, GetType_FunctionAddress, "ReturnValue");
		GetType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetType_FunctionAddress, "ReturnValue");
		GetType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetType_IsValid = GetType_FunctionAddress != IntPtr.Zero && GetType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkMIDIEventCallbackInfo:GetType", GetType_IsValid);
		GetProgramChange_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetProgramChange");
		GetProgramChange_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProgramChange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProgramChange_AsProgramChange_PropertyAddress, GetProgramChange_FunctionAddress, "AsProgramChange");
		GetProgramChange_AsProgramChange_Offset = NativeReflectionCached.GetPropertyOffset(GetProgramChange_FunctionAddress, "AsProgramChange");
		GetProgramChange_AsProgramChange_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProgramChange_FunctionAddress, "AsProgramChange", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetProgramChange_ReturnValue_PropertyAddress, GetProgramChange_FunctionAddress, "ReturnValue");
		GetProgramChange_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetProgramChange_FunctionAddress, "ReturnValue");
		GetProgramChange_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProgramChange_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetProgramChange_IsValid = GetProgramChange_FunctionAddress != IntPtr.Zero && GetProgramChange_AsProgramChange_IsValid && GetProgramChange_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkMIDIEventCallbackInfo:GetProgramChange", GetProgramChange_IsValid);
		GetPitchBend_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPitchBend");
		GetPitchBend_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPitchBend_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPitchBend_AsPitchBend_PropertyAddress, GetPitchBend_FunctionAddress, "AsPitchBend");
		GetPitchBend_AsPitchBend_Offset = NativeReflectionCached.GetPropertyOffset(GetPitchBend_FunctionAddress, "AsPitchBend");
		GetPitchBend_AsPitchBend_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPitchBend_FunctionAddress, "AsPitchBend", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPitchBend_ReturnValue_PropertyAddress, GetPitchBend_FunctionAddress, "ReturnValue");
		GetPitchBend_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPitchBend_FunctionAddress, "ReturnValue");
		GetPitchBend_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPitchBend_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetPitchBend_IsValid = GetPitchBend_FunctionAddress != IntPtr.Zero && GetPitchBend_AsPitchBend_IsValid && GetPitchBend_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkMIDIEventCallbackInfo:GetPitchBend", GetPitchBend_IsValid);
		GetNoteOn_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNoteOn");
		GetNoteOn_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNoteOn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNoteOn_AsNoteOn_PropertyAddress, GetNoteOn_FunctionAddress, "AsNoteOn");
		GetNoteOn_AsNoteOn_Offset = NativeReflectionCached.GetPropertyOffset(GetNoteOn_FunctionAddress, "AsNoteOn");
		GetNoteOn_AsNoteOn_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNoteOn_FunctionAddress, "AsNoteOn", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNoteOn_ReturnValue_PropertyAddress, GetNoteOn_FunctionAddress, "ReturnValue");
		GetNoteOn_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNoteOn_FunctionAddress, "ReturnValue");
		GetNoteOn_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNoteOn_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetNoteOn_IsValid = GetNoteOn_FunctionAddress != IntPtr.Zero && GetNoteOn_AsNoteOn_IsValid && GetNoteOn_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkMIDIEventCallbackInfo:GetNoteOn", GetNoteOn_IsValid);
		GetNoteOff_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNoteOff");
		GetNoteOff_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNoteOff_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNoteOff_AsNoteOff_PropertyAddress, GetNoteOff_FunctionAddress, "AsNoteOff");
		GetNoteOff_AsNoteOff_Offset = NativeReflectionCached.GetPropertyOffset(GetNoteOff_FunctionAddress, "AsNoteOff");
		GetNoteOff_AsNoteOff_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNoteOff_FunctionAddress, "AsNoteOff", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNoteOff_ReturnValue_PropertyAddress, GetNoteOff_FunctionAddress, "ReturnValue");
		GetNoteOff_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNoteOff_FunctionAddress, "ReturnValue");
		GetNoteOff_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNoteOff_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetNoteOff_IsValid = GetNoteOff_FunctionAddress != IntPtr.Zero && GetNoteOff_AsNoteOff_IsValid && GetNoteOff_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkMIDIEventCallbackInfo:GetNoteOff", GetNoteOff_IsValid);
		GetNoteAftertouch_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNoteAftertouch");
		GetNoteAftertouch_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNoteAftertouch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNoteAftertouch_AsNoteAftertouch_PropertyAddress, GetNoteAftertouch_FunctionAddress, "AsNoteAftertouch");
		GetNoteAftertouch_AsNoteAftertouch_Offset = NativeReflectionCached.GetPropertyOffset(GetNoteAftertouch_FunctionAddress, "AsNoteAftertouch");
		GetNoteAftertouch_AsNoteAftertouch_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNoteAftertouch_FunctionAddress, "AsNoteAftertouch", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNoteAftertouch_ReturnValue_PropertyAddress, GetNoteAftertouch_FunctionAddress, "ReturnValue");
		GetNoteAftertouch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNoteAftertouch_FunctionAddress, "ReturnValue");
		GetNoteAftertouch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNoteAftertouch_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetNoteAftertouch_IsValid = GetNoteAftertouch_FunctionAddress != IntPtr.Zero && GetNoteAftertouch_AsNoteAftertouch_IsValid && GetNoteAftertouch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkMIDIEventCallbackInfo:GetNoteAftertouch", GetNoteAftertouch_IsValid);
		GetGeneric_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGeneric");
		GetGeneric_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGeneric_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGeneric_AsGeneric_PropertyAddress, GetGeneric_FunctionAddress, "AsGeneric");
		GetGeneric_AsGeneric_Offset = NativeReflectionCached.GetPropertyOffset(GetGeneric_FunctionAddress, "AsGeneric");
		GetGeneric_AsGeneric_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGeneric_FunctionAddress, "AsGeneric", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGeneric_ReturnValue_PropertyAddress, GetGeneric_FunctionAddress, "ReturnValue");
		GetGeneric_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGeneric_FunctionAddress, "ReturnValue");
		GetGeneric_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGeneric_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetGeneric_IsValid = GetGeneric_FunctionAddress != IntPtr.Zero && GetGeneric_AsGeneric_IsValid && GetGeneric_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkMIDIEventCallbackInfo:GetGeneric", GetGeneric_IsValid);
		GetChannelAftertouch_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetChannelAftertouch");
		GetChannelAftertouch_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChannelAftertouch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChannelAftertouch_AsChannelAftertouch_PropertyAddress, GetChannelAftertouch_FunctionAddress, "AsChannelAftertouch");
		GetChannelAftertouch_AsChannelAftertouch_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelAftertouch_FunctionAddress, "AsChannelAftertouch");
		GetChannelAftertouch_AsChannelAftertouch_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelAftertouch_FunctionAddress, "AsChannelAftertouch", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChannelAftertouch_ReturnValue_PropertyAddress, GetChannelAftertouch_FunctionAddress, "ReturnValue");
		GetChannelAftertouch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelAftertouch_FunctionAddress, "ReturnValue");
		GetChannelAftertouch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelAftertouch_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetChannelAftertouch_IsValid = GetChannelAftertouch_FunctionAddress != IntPtr.Zero && GetChannelAftertouch_AsChannelAftertouch_IsValid && GetChannelAftertouch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkMIDIEventCallbackInfo:GetChannelAftertouch", GetChannelAftertouch_IsValid);
		GetChannel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetChannel");
		GetChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChannel_ReturnValue_PropertyAddress, GetChannel_FunctionAddress, "ReturnValue");
		GetChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChannel_FunctionAddress, "ReturnValue");
		GetChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannel_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetChannel_IsValid = GetChannel_FunctionAddress != IntPtr.Zero && GetChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkMIDIEventCallbackInfo:GetChannel", GetChannel_IsValid);
		GetCc_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCc");
		GetCc_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCc_AsCc_PropertyAddress, GetCc_FunctionAddress, "AsCc");
		GetCc_AsCc_Offset = NativeReflectionCached.GetPropertyOffset(GetCc_FunctionAddress, "AsCc");
		GetCc_AsCc_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCc_FunctionAddress, "AsCc", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCc_ReturnValue_PropertyAddress, GetCc_FunctionAddress, "ReturnValue");
		GetCc_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCc_FunctionAddress, "ReturnValue");
		GetCc_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCc_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCc_IsValid = GetCc_FunctionAddress != IntPtr.Zero && GetCc_AsCc_IsValid && GetCc_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkMIDIEventCallbackInfo:GetCc", GetCc_IsValid);
	}
}
