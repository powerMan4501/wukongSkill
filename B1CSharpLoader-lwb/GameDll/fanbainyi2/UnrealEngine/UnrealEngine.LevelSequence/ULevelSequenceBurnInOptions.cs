using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.LevelSequence;

[UClass(Flags = (ClassFlags)821036196uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/LevelSequence.LevelSequenceBurnInOptions", "LevelSequence", UnrealModuleType.Engine)]
public class ULevelSequenceBurnInOptions : UObject
{
	private static bool UseBurnIn_IsValid;

	private static FFieldAddress UseBurnIn_PropertyAddress;

	private static int UseBurnIn_Offset;

	private static bool BurnInClass_IsValid;

	private static int BurnInClass_Offset;

	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool SetBurnIn_IsValid;

	private static IntPtr SetBurnIn_FunctionAddress;

	private static int SetBurnIn_ParamsSize;

	private static bool SetBurnIn_InBurnInClass_IsValid;

	private static FFieldAddress SetBurnIn_InBurnInClass_PropertyAddress;

	private static int SetBurnIn_InBurnInClass_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceBurnInOptions:bUseBurnIn")]
	public bool UseBurnIn
	{
		get
		{
			CheckDestroyed();
			if (!UseBurnIn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceBurnInOptions:bUseBurnIn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseBurnIn_Offset), 0, UseBurnIn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseBurnIn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceBurnInOptions:bUseBurnIn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseBurnIn_Offset), 0, UseBurnIn_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceBurnInOptions:BurnInClass")]
	public FSoftClassPath BurnInClass
	{
		get
		{
			CheckDestroyed();
			if (!BurnInClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceBurnInOptions:BurnInClass");
				return default(FSoftClassPath);
			}
			return FSoftClassPath.FromNative(IntPtr.Add(base.Address, BurnInClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BurnInClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceBurnInOptions:BurnInClass");
			}
			else
			{
				FSoftClassPath.ToNative(IntPtr.Add(base.Address, BurnInClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095063053uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceBurnInOptions:Settings")]
	public ULevelSequenceBurnInInitSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceBurnInOptions:Settings");
				return null;
			}
			return UObjectMarshaler<ULevelSequenceBurnInInitSettings>.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceBurnInOptions:Settings");
			}
			else
			{
				UObjectMarshaler<ULevelSequenceBurnInInitSettings>.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceBurnInOptions:SetBurnIn")]
	public unsafe void SetBurnIn(FSoftClassPath InBurnInClass)
	{
		CheckDestroyed();
		if (!SetBurnIn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceBurnInOptions:SetBurnIn");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBurnIn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBurnIn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FSoftClassPath.ToNative(IntPtr.Add(intPtr, SetBurnIn_InBurnInClass_Offset), 0, SetBurnIn_InBurnInClass_PropertyAddress.Address, InBurnInClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBurnIn_FunctionAddress, intPtr, SetBurnIn_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBurnIn_InBurnInClass_PropertyAddress.Address, intPtr);
	}

	static ULevelSequenceBurnInOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULevelSequenceBurnInOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULevelSequenceBurnInOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/LevelSequence.LevelSequenceBurnInOptions");
		NativeReflectionCached.GetPropertyRef(ref UseBurnIn_PropertyAddress, intPtr, "bUseBurnIn");
		UseBurnIn_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseBurnIn");
		UseBurnIn_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseBurnIn", Classes.FBoolProperty);
		BurnInClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BurnInClass");
		BurnInClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BurnInClass", Classes.FStructProperty);
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FObjectProperty);
		SetBurnIn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBurnIn");
		SetBurnIn_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBurnIn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBurnIn_InBurnInClass_PropertyAddress, SetBurnIn_FunctionAddress, "InBurnInClass");
		SetBurnIn_InBurnInClass_Offset = NativeReflectionCached.GetPropertyOffset(SetBurnIn_FunctionAddress, "InBurnInClass");
		SetBurnIn_InBurnInClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBurnIn_FunctionAddress, "InBurnInClass", Classes.FStructProperty);
		SetBurnIn_IsValid = SetBurnIn_FunctionAddress != IntPtr.Zero && SetBurnIn_InBurnInClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceBurnInOptions:SetBurnIn", SetBurnIn_IsValid);
	}
}
