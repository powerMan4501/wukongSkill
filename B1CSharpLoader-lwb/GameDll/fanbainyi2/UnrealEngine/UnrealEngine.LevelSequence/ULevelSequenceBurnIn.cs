using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace UnrealEngine.LevelSequence;

[UClass(Flags = (ClassFlags)821039264uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/LevelSequence.LevelSequenceBurnIn", "LevelSequence", UnrealModuleType.Engine)]
public class ULevelSequenceBurnIn : UUserWidget
{
	private static bool FrameInformation_IsValid;

	private static int FrameInformation_Offset;

	private static bool LevelSequenceActor_IsValid;

	private static int LevelSequenceActor_Offset;

	private static bool SetSettings_IsValid;

	private IntPtr SetSettings_InstanceFunctionAddress;

	private static IntPtr SetSettings_FunctionAddress;

	private static int SetSettings_ParamsSize;

	private static bool SetSettings_InSettings_IsValid;

	private static FFieldAddress SetSettings_InSettings_PropertyAddress;

	private static int SetSettings_InSettings_Offset;

	private static bool GetSettingsClass_IsValid;

	private IntPtr GetSettingsClass_InstanceFunctionAddress;

	private static IntPtr GetSettingsClass_FunctionAddress;

	private static int GetSettingsClass_ParamsSize;

	private static bool GetSettingsClass_ReturnValue_IsValid;

	private static FFieldAddress GetSettingsClass_ReturnValue_PropertyAddress;

	private static int GetSettingsClass_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)9016545103577108uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceBurnIn:FrameInformation")]
	protected FLevelSequencePlayerSnapshot FrameInformation
	{
		get
		{
			CheckDestroyed();
			if (!FrameInformation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceBurnIn:FrameInformation");
				return default(FLevelSequencePlayerSnapshot);
			}
			return FLevelSequencePlayerSnapshot.FromNative(IntPtr.Add(base.Address, FrameInformation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrameInformation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceBurnIn:FrameInformation");
			}
			else
			{
				FLevelSequencePlayerSnapshot.ToNative(IntPtr.Add(base.Address, FrameInformation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510164uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceBurnIn:LevelSequenceActor")]
	protected ALevelSequenceActor LevelSequenceActor
	{
		get
		{
			CheckDestroyed();
			if (!LevelSequenceActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceBurnIn:LevelSequenceActor");
				return null;
			}
			return UObjectMarshaler<ALevelSequenceActor>.FromNative(IntPtr.Add(base.Address, LevelSequenceActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelSequenceActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceBurnIn:LevelSequenceActor");
			}
			else
			{
				UObjectMarshaler<ALevelSequenceActor>.ToNative(IntPtr.Add(base.Address, LevelSequenceActor_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceBurnIn:SetSettings")]
	public unsafe void SetSettings(UObject InSettings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceBurnIn:SetSettings");
			return;
		}
		if (SetSettings_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetSettings_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetSettings");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetSettings_InSettings_Offset), 0, SetSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_InstanceFunctionAddress, intPtr, SetSettings_ParamsSize);
	}

	protected unsafe virtual void SetSettings_Implementation(UObject InSettings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceBurnIn:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetSettings_InSettings_Offset), 0, SetSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceBurnIn:GetSettingsClass")]
	public unsafe TSubclassOf<ULevelSequenceBurnInInitSettings> GetSettingsClass()
	{
		CheckDestroyed();
		if (!GetSettingsClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceBurnIn:GetSettingsClass");
			return default(TSubclassOf<ULevelSequenceBurnInInitSettings>);
		}
		if (GetSettingsClass_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetSettingsClass_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetSettingsClass");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSettingsClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSettingsClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSettingsClass_InstanceFunctionAddress, intPtr, GetSettingsClass_ParamsSize);
		return TSubclassOfMarshaler<ULevelSequenceBurnInInitSettings>.FromNative(IntPtr.Add(intPtr, GetSettingsClass_ReturnValue_Offset), 0, GetSettingsClass_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual TSubclassOf<ULevelSequenceBurnInInitSettings> GetSettingsClass_Implementation()
	{
		CheckDestroyed();
		if (!GetSettingsClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceBurnIn:GetSettingsClass");
			return default(TSubclassOf<ULevelSequenceBurnInInitSettings>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSettingsClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSettingsClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSettingsClass_FunctionAddress, intPtr, GetSettingsClass_ParamsSize);
		return TSubclassOfMarshaler<ULevelSequenceBurnInInitSettings>.FromNative(IntPtr.Add(intPtr, GetSettingsClass_ReturnValue_Offset), 0, GetSettingsClass_ReturnValue_PropertyAddress.Address);
	}

	static ULevelSequenceBurnIn()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULevelSequenceBurnIn)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULevelSequenceBurnIn));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/LevelSequence.LevelSequenceBurnIn");
		FrameInformation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameInformation");
		FrameInformation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameInformation", Classes.FStructProperty);
		LevelSequenceActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LevelSequenceActor");
		LevelSequenceActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LevelSequenceActor", Classes.FObjectProperty);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_InSettings_PropertyAddress, SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "InSettings", Classes.FObjectProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceBurnIn:SetSettings", SetSettings_IsValid);
		GetSettingsClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSettingsClass");
		GetSettingsClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSettingsClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSettingsClass_ReturnValue_PropertyAddress, GetSettingsClass_FunctionAddress, "ReturnValue");
		GetSettingsClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSettingsClass_FunctionAddress, "ReturnValue");
		GetSettingsClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSettingsClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetSettingsClass_IsValid = GetSettingsClass_FunctionAddress != IntPtr.Zero && GetSettingsClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceBurnIn:GetSettingsClass", GetSettingsClass_IsValid);
	}
}
