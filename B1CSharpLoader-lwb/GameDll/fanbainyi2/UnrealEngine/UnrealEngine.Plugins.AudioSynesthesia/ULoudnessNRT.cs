using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioSynesthesia.LoudnessNRT", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public class ULoudnessNRT : UAudioSynesthesiaNRT
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool GetNormalizedLoudnessAtTime_IsValid;

	private static IntPtr GetNormalizedLoudnessAtTime_FunctionAddress;

	private static int GetNormalizedLoudnessAtTime_ParamsSize;

	private static bool GetNormalizedLoudnessAtTime_InSeconds_IsValid;

	private static FFieldAddress GetNormalizedLoudnessAtTime_InSeconds_PropertyAddress;

	private static int GetNormalizedLoudnessAtTime_InSeconds_Offset;

	private static bool GetNormalizedLoudnessAtTime_OutLoudness_IsValid;

	private static FFieldAddress GetNormalizedLoudnessAtTime_OutLoudness_PropertyAddress;

	private static int GetNormalizedLoudnessAtTime_OutLoudness_Offset;

	private static bool GetNormalizedChannelLoudnessAtTime_IsValid;

	private static IntPtr GetNormalizedChannelLoudnessAtTime_FunctionAddress;

	private static int GetNormalizedChannelLoudnessAtTime_ParamsSize;

	private static bool GetNormalizedChannelLoudnessAtTime_InSeconds_IsValid;

	private static FFieldAddress GetNormalizedChannelLoudnessAtTime_InSeconds_PropertyAddress;

	private static int GetNormalizedChannelLoudnessAtTime_InSeconds_Offset;

	private static bool GetNormalizedChannelLoudnessAtTime_InChannel_IsValid;

	private static FFieldAddress GetNormalizedChannelLoudnessAtTime_InChannel_PropertyAddress;

	private static int GetNormalizedChannelLoudnessAtTime_InChannel_Offset;

	private static bool GetNormalizedChannelLoudnessAtTime_OutLoudness_IsValid;

	private static FFieldAddress GetNormalizedChannelLoudnessAtTime_OutLoudness_PropertyAddress;

	private static int GetNormalizedChannelLoudnessAtTime_OutLoudness_Offset;

	private static bool GetLoudnessAtTime_IsValid;

	private static IntPtr GetLoudnessAtTime_FunctionAddress;

	private static int GetLoudnessAtTime_ParamsSize;

	private static bool GetLoudnessAtTime_InSeconds_IsValid;

	private static FFieldAddress GetLoudnessAtTime_InSeconds_PropertyAddress;

	private static int GetLoudnessAtTime_InSeconds_Offset;

	private static bool GetLoudnessAtTime_OutLoudness_IsValid;

	private static FFieldAddress GetLoudnessAtTime_OutLoudness_PropertyAddress;

	private static int GetLoudnessAtTime_OutLoudness_Offset;

	private static bool GetChannelLoudnessAtTime_IsValid;

	private static IntPtr GetChannelLoudnessAtTime_FunctionAddress;

	private static int GetChannelLoudnessAtTime_ParamsSize;

	private static bool GetChannelLoudnessAtTime_InSeconds_IsValid;

	private static FFieldAddress GetChannelLoudnessAtTime_InSeconds_PropertyAddress;

	private static int GetChannelLoudnessAtTime_InSeconds_Offset;

	private static bool GetChannelLoudnessAtTime_InChannel_IsValid;

	private static FFieldAddress GetChannelLoudnessAtTime_InChannel_PropertyAddress;

	private static int GetChannelLoudnessAtTime_InChannel_Offset;

	private static bool GetChannelLoudnessAtTime_OutLoudness_IsValid;

	private static FFieldAddress GetChannelLoudnessAtTime_OutLoudness_PropertyAddress;

	private static int GetChannelLoudnessAtTime_OutLoudness_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessNRT:Settings")]
	public ULoudnessNRTSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessNRT:Settings");
				return null;
			}
			return UObjectMarshaler<ULoudnessNRTSettings>.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessNRT:Settings");
			}
			else
			{
				UObjectMarshaler<ULoudnessNRTSettings>.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessNRT:GetNormalizedLoudnessAtTime")]
	public unsafe void GetNormalizedLoudnessAtTime(float InSeconds, out float OutLoudness)
	{
		CheckDestroyed();
		if (!GetNormalizedLoudnessAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.LoudnessNRT:GetNormalizedLoudnessAtTime");
			OutLoudness = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNormalizedLoudnessAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNormalizedLoudnessAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetNormalizedLoudnessAtTime_InSeconds_Offset), 0, GetNormalizedLoudnessAtTime_InSeconds_PropertyAddress.Address, InSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNormalizedLoudnessAtTime_FunctionAddress, intPtr, GetNormalizedLoudnessAtTime_ParamsSize);
		OutLoudness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetNormalizedLoudnessAtTime_OutLoudness_Offset), 0, GetNormalizedLoudnessAtTime_OutLoudness_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessNRT:GetNormalizedChannelLoudnessAtTime")]
	public unsafe void GetNormalizedChannelLoudnessAtTime(float InSeconds, int InChannel, out float OutLoudness)
	{
		CheckDestroyed();
		if (!GetNormalizedChannelLoudnessAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.LoudnessNRT:GetNormalizedChannelLoudnessAtTime");
			OutLoudness = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNormalizedChannelLoudnessAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNormalizedChannelLoudnessAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetNormalizedChannelLoudnessAtTime_InSeconds_Offset), 0, GetNormalizedChannelLoudnessAtTime_InSeconds_PropertyAddress.Address, InSeconds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNormalizedChannelLoudnessAtTime_InChannel_Offset), 0, GetNormalizedChannelLoudnessAtTime_InChannel_PropertyAddress.Address, InChannel);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNormalizedChannelLoudnessAtTime_FunctionAddress, intPtr, GetNormalizedChannelLoudnessAtTime_ParamsSize);
		OutLoudness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetNormalizedChannelLoudnessAtTime_OutLoudness_Offset), 0, GetNormalizedChannelLoudnessAtTime_OutLoudness_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessNRT:GetLoudnessAtTime")]
	public unsafe void GetLoudnessAtTime(float InSeconds, out float OutLoudness)
	{
		CheckDestroyed();
		if (!GetLoudnessAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.LoudnessNRT:GetLoudnessAtTime");
			OutLoudness = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLoudnessAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLoudnessAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLoudnessAtTime_InSeconds_Offset), 0, GetLoudnessAtTime_InSeconds_PropertyAddress.Address, InSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLoudnessAtTime_FunctionAddress, intPtr, GetLoudnessAtTime_ParamsSize);
		OutLoudness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLoudnessAtTime_OutLoudness_Offset), 0, GetLoudnessAtTime_OutLoudness_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessNRT:GetChannelLoudnessAtTime")]
	public unsafe void GetChannelLoudnessAtTime(float InSeconds, int InChannel, out float OutLoudness)
	{
		CheckDestroyed();
		if (!GetChannelLoudnessAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioSynesthesia.LoudnessNRT:GetChannelLoudnessAtTime");
			OutLoudness = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChannelLoudnessAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChannelLoudnessAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetChannelLoudnessAtTime_InSeconds_Offset), 0, GetChannelLoudnessAtTime_InSeconds_PropertyAddress.Address, InSeconds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetChannelLoudnessAtTime_InChannel_Offset), 0, GetChannelLoudnessAtTime_InChannel_PropertyAddress.Address, InChannel);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetChannelLoudnessAtTime_FunctionAddress, intPtr, GetChannelLoudnessAtTime_ParamsSize);
		OutLoudness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetChannelLoudnessAtTime_OutLoudness_Offset), 0, GetChannelLoudnessAtTime_OutLoudness_PropertyAddress.Address);
	}

	static ULoudnessNRT()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULoudnessNRT)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULoudnessNRT));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AudioSynesthesia.LoudnessNRT");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FObjectProperty);
		GetNormalizedLoudnessAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNormalizedLoudnessAtTime");
		GetNormalizedLoudnessAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNormalizedLoudnessAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedLoudnessAtTime_InSeconds_PropertyAddress, GetNormalizedLoudnessAtTime_FunctionAddress, "InSeconds");
		GetNormalizedLoudnessAtTime_InSeconds_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedLoudnessAtTime_FunctionAddress, "InSeconds");
		GetNormalizedLoudnessAtTime_InSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedLoudnessAtTime_FunctionAddress, "InSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedLoudnessAtTime_OutLoudness_PropertyAddress, GetNormalizedLoudnessAtTime_FunctionAddress, "OutLoudness");
		GetNormalizedLoudnessAtTime_OutLoudness_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedLoudnessAtTime_FunctionAddress, "OutLoudness");
		GetNormalizedLoudnessAtTime_OutLoudness_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedLoudnessAtTime_FunctionAddress, "OutLoudness", Classes.FFloatProperty);
		GetNormalizedLoudnessAtTime_IsValid = GetNormalizedLoudnessAtTime_FunctionAddress != IntPtr.Zero && GetNormalizedLoudnessAtTime_InSeconds_IsValid && GetNormalizedLoudnessAtTime_OutLoudness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.LoudnessNRT:GetNormalizedLoudnessAtTime", GetNormalizedLoudnessAtTime_IsValid);
		GetNormalizedChannelLoudnessAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNormalizedChannelLoudnessAtTime");
		GetNormalizedChannelLoudnessAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNormalizedChannelLoudnessAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedChannelLoudnessAtTime_InSeconds_PropertyAddress, GetNormalizedChannelLoudnessAtTime_FunctionAddress, "InSeconds");
		GetNormalizedChannelLoudnessAtTime_InSeconds_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedChannelLoudnessAtTime_FunctionAddress, "InSeconds");
		GetNormalizedChannelLoudnessAtTime_InSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedChannelLoudnessAtTime_FunctionAddress, "InSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedChannelLoudnessAtTime_InChannel_PropertyAddress, GetNormalizedChannelLoudnessAtTime_FunctionAddress, "InChannel");
		GetNormalizedChannelLoudnessAtTime_InChannel_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedChannelLoudnessAtTime_FunctionAddress, "InChannel");
		GetNormalizedChannelLoudnessAtTime_InChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedChannelLoudnessAtTime_FunctionAddress, "InChannel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedChannelLoudnessAtTime_OutLoudness_PropertyAddress, GetNormalizedChannelLoudnessAtTime_FunctionAddress, "OutLoudness");
		GetNormalizedChannelLoudnessAtTime_OutLoudness_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedChannelLoudnessAtTime_FunctionAddress, "OutLoudness");
		GetNormalizedChannelLoudnessAtTime_OutLoudness_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedChannelLoudnessAtTime_FunctionAddress, "OutLoudness", Classes.FFloatProperty);
		GetNormalizedChannelLoudnessAtTime_IsValid = GetNormalizedChannelLoudnessAtTime_FunctionAddress != IntPtr.Zero && GetNormalizedChannelLoudnessAtTime_InSeconds_IsValid && GetNormalizedChannelLoudnessAtTime_InChannel_IsValid && GetNormalizedChannelLoudnessAtTime_OutLoudness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.LoudnessNRT:GetNormalizedChannelLoudnessAtTime", GetNormalizedChannelLoudnessAtTime_IsValid);
		GetLoudnessAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLoudnessAtTime");
		GetLoudnessAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLoudnessAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLoudnessAtTime_InSeconds_PropertyAddress, GetLoudnessAtTime_FunctionAddress, "InSeconds");
		GetLoudnessAtTime_InSeconds_Offset = NativeReflectionCached.GetPropertyOffset(GetLoudnessAtTime_FunctionAddress, "InSeconds");
		GetLoudnessAtTime_InSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLoudnessAtTime_FunctionAddress, "InSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLoudnessAtTime_OutLoudness_PropertyAddress, GetLoudnessAtTime_FunctionAddress, "OutLoudness");
		GetLoudnessAtTime_OutLoudness_Offset = NativeReflectionCached.GetPropertyOffset(GetLoudnessAtTime_FunctionAddress, "OutLoudness");
		GetLoudnessAtTime_OutLoudness_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLoudnessAtTime_FunctionAddress, "OutLoudness", Classes.FFloatProperty);
		GetLoudnessAtTime_IsValid = GetLoudnessAtTime_FunctionAddress != IntPtr.Zero && GetLoudnessAtTime_InSeconds_IsValid && GetLoudnessAtTime_OutLoudness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.LoudnessNRT:GetLoudnessAtTime", GetLoudnessAtTime_IsValid);
		GetChannelLoudnessAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetChannelLoudnessAtTime");
		GetChannelLoudnessAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChannelLoudnessAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChannelLoudnessAtTime_InSeconds_PropertyAddress, GetChannelLoudnessAtTime_FunctionAddress, "InSeconds");
		GetChannelLoudnessAtTime_InSeconds_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelLoudnessAtTime_FunctionAddress, "InSeconds");
		GetChannelLoudnessAtTime_InSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelLoudnessAtTime_FunctionAddress, "InSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChannelLoudnessAtTime_InChannel_PropertyAddress, GetChannelLoudnessAtTime_FunctionAddress, "InChannel");
		GetChannelLoudnessAtTime_InChannel_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelLoudnessAtTime_FunctionAddress, "InChannel");
		GetChannelLoudnessAtTime_InChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelLoudnessAtTime_FunctionAddress, "InChannel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChannelLoudnessAtTime_OutLoudness_PropertyAddress, GetChannelLoudnessAtTime_FunctionAddress, "OutLoudness");
		GetChannelLoudnessAtTime_OutLoudness_Offset = NativeReflectionCached.GetPropertyOffset(GetChannelLoudnessAtTime_FunctionAddress, "OutLoudness");
		GetChannelLoudnessAtTime_OutLoudness_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChannelLoudnessAtTime_FunctionAddress, "OutLoudness", Classes.FFloatProperty);
		GetChannelLoudnessAtTime_IsValid = GetChannelLoudnessAtTime_FunctionAddress != IntPtr.Zero && GetChannelLoudnessAtTime_InSeconds_IsValid && GetChannelLoudnessAtTime_InChannel_IsValid && GetChannelLoudnessAtTime_OutLoudness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioSynesthesia.LoudnessNRT:GetChannelLoudnessAtTime", GetChannelLoudnessAtTime_IsValid);
	}
}
