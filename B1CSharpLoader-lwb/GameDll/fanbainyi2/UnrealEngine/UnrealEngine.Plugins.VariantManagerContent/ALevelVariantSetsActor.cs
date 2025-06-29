using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VariantManagerContent;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/VariantManagerContent.LevelVariantSetsActor", "VariantManagerContent", UnrealModuleType.EnginePlugin)]
public class ALevelVariantSetsActor : AActor
{
	private static bool LevelVariantSets_IsValid;

	private static int LevelVariantSets_Offset;

	private static bool SwitchOnVariantByName_IsValid;

	private static IntPtr SwitchOnVariantByName_FunctionAddress;

	private static int SwitchOnVariantByName_ParamsSize;

	private static bool SwitchOnVariantByName_VariantSetName_IsValid;

	private static FFieldAddress SwitchOnVariantByName_VariantSetName_PropertyAddress;

	private static int SwitchOnVariantByName_VariantSetName_Offset;

	private static bool SwitchOnVariantByName_VariantName_IsValid;

	private static FFieldAddress SwitchOnVariantByName_VariantName_PropertyAddress;

	private static int SwitchOnVariantByName_VariantName_Offset;

	private static bool SwitchOnVariantByName_ReturnValue_IsValid;

	private static FFieldAddress SwitchOnVariantByName_ReturnValue_PropertyAddress;

	private static int SwitchOnVariantByName_ReturnValue_Offset;

	private static bool SwitchOnVariantByIndex_IsValid;

	private static IntPtr SwitchOnVariantByIndex_FunctionAddress;

	private static int SwitchOnVariantByIndex_ParamsSize;

	private static bool SwitchOnVariantByIndex_VariantSetIndex_IsValid;

	private static FFieldAddress SwitchOnVariantByIndex_VariantSetIndex_PropertyAddress;

	private static int SwitchOnVariantByIndex_VariantSetIndex_Offset;

	private static bool SwitchOnVariantByIndex_VariantIndex_IsValid;

	private static FFieldAddress SwitchOnVariantByIndex_VariantIndex_PropertyAddress;

	private static int SwitchOnVariantByIndex_VariantIndex_Offset;

	private static bool SwitchOnVariantByIndex_ReturnValue_IsValid;

	private static FFieldAddress SwitchOnVariantByIndex_ReturnValue_PropertyAddress;

	private static int SwitchOnVariantByIndex_ReturnValue_Offset;

	private static bool SetLevelVariantSets_IsValid;

	private static IntPtr SetLevelVariantSets_FunctionAddress;

	private static int SetLevelVariantSets_ParamsSize;

	private static bool SetLevelVariantSets_InVariantSets_IsValid;

	private static FFieldAddress SetLevelVariantSets_InVariantSets_PropertyAddress;

	private static int SetLevelVariantSets_InVariantSets_Offset;

	private static bool GetLevelVariantSets_IsValid;

	private static IntPtr GetLevelVariantSets_FunctionAddress;

	private static int GetLevelVariantSets_ParamsSize;

	private static bool GetLevelVariantSets_bLoad_IsValid;

	private static FFieldAddress GetLevelVariantSets_bLoad_PropertyAddress;

	private static int GetLevelVariantSets_bLoad_Offset;

	private static bool GetLevelVariantSets_ReturnValue_IsValid;

	private static FFieldAddress GetLevelVariantSets_ReturnValue_PropertyAddress;

	private static int GetLevelVariantSets_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/VariantManagerContent.LevelVariantSetsActor:LevelVariantSets")]
	public FSoftObjectPath LevelVariantSets
	{
		get
		{
			CheckDestroyed();
			if (!LevelVariantSets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContent.LevelVariantSetsActor:LevelVariantSets");
				return default(FSoftObjectPath);
			}
			return FSoftObjectPath.FromNative(IntPtr.Add(base.Address, LevelVariantSets_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelVariantSets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VariantManagerContent.LevelVariantSetsActor:LevelVariantSets");
			}
			else
			{
				FSoftObjectPath.ToNative(IntPtr.Add(base.Address, LevelVariantSets_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.LevelVariantSetsActor:SwitchOnVariantByName")]
	public unsafe bool SwitchOnVariantByName(string VariantSetName, string VariantName)
	{
		CheckDestroyed();
		if (!SwitchOnVariantByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.LevelVariantSetsActor:SwitchOnVariantByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchOnVariantByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchOnVariantByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SwitchOnVariantByName_VariantSetName_Offset), 0, SwitchOnVariantByName_VariantSetName_PropertyAddress.Address, VariantSetName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SwitchOnVariantByName_VariantName_Offset), 0, SwitchOnVariantByName_VariantName_PropertyAddress.Address, VariantName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchOnVariantByName_FunctionAddress, intPtr, SwitchOnVariantByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SwitchOnVariantByName_VariantSetName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SwitchOnVariantByName_VariantName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SwitchOnVariantByName_ReturnValue_Offset), 0, SwitchOnVariantByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.LevelVariantSetsActor:SwitchOnVariantByIndex")]
	public unsafe bool SwitchOnVariantByIndex(int VariantSetIndex, int VariantIndex)
	{
		CheckDestroyed();
		if (!SwitchOnVariantByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.LevelVariantSetsActor:SwitchOnVariantByIndex");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchOnVariantByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchOnVariantByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SwitchOnVariantByIndex_VariantSetIndex_Offset), 0, SwitchOnVariantByIndex_VariantSetIndex_PropertyAddress.Address, VariantSetIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SwitchOnVariantByIndex_VariantIndex_Offset), 0, SwitchOnVariantByIndex_VariantIndex_PropertyAddress.Address, VariantIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchOnVariantByIndex_FunctionAddress, intPtr, SwitchOnVariantByIndex_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SwitchOnVariantByIndex_ReturnValue_Offset), 0, SwitchOnVariantByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.LevelVariantSetsActor:SetLevelVariantSets")]
	public unsafe void SetLevelVariantSets(ULevelVariantSets InVariantSets)
	{
		CheckDestroyed();
		if (!SetLevelVariantSets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.LevelVariantSetsActor:SetLevelVariantSets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLevelVariantSets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLevelVariantSets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelVariantSets>.ToNative(IntPtr.Add(intPtr, SetLevelVariantSets_InVariantSets_Offset), 0, SetLevelVariantSets_InVariantSets_PropertyAddress.Address, InVariantSets);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLevelVariantSets_FunctionAddress, intPtr, SetLevelVariantSets_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.LevelVariantSetsActor:GetLevelVariantSets")]
	public unsafe ULevelVariantSets GetLevelVariantSets(bool bLoad = false)
	{
		CheckDestroyed();
		if (!GetLevelVariantSets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.LevelVariantSetsActor:GetLevelVariantSets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelVariantSets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelVariantSets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLevelVariantSets_bLoad_Offset), 0, GetLevelVariantSets_bLoad_PropertyAddress.Address, bLoad);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLevelVariantSets_FunctionAddress, intPtr, GetLevelVariantSets_ParamsSize);
		return UObjectMarshaler<ULevelVariantSets>.FromNative(IntPtr.Add(intPtr, GetLevelVariantSets_ReturnValue_Offset), 0, GetLevelVariantSets_ReturnValue_PropertyAddress.Address);
	}

	static ALevelVariantSetsActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALevelVariantSetsActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALevelVariantSetsActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/VariantManagerContent.LevelVariantSetsActor");
		LevelVariantSets_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LevelVariantSets");
		LevelVariantSets_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LevelVariantSets", Classes.FStructProperty);
		SwitchOnVariantByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchOnVariantByName");
		SwitchOnVariantByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchOnVariantByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchOnVariantByName_VariantSetName_PropertyAddress, SwitchOnVariantByName_FunctionAddress, "VariantSetName");
		SwitchOnVariantByName_VariantSetName_Offset = NativeReflectionCached.GetPropertyOffset(SwitchOnVariantByName_FunctionAddress, "VariantSetName");
		SwitchOnVariantByName_VariantSetName_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchOnVariantByName_FunctionAddress, "VariantSetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchOnVariantByName_VariantName_PropertyAddress, SwitchOnVariantByName_FunctionAddress, "VariantName");
		SwitchOnVariantByName_VariantName_Offset = NativeReflectionCached.GetPropertyOffset(SwitchOnVariantByName_FunctionAddress, "VariantName");
		SwitchOnVariantByName_VariantName_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchOnVariantByName_FunctionAddress, "VariantName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchOnVariantByName_ReturnValue_PropertyAddress, SwitchOnVariantByName_FunctionAddress, "ReturnValue");
		SwitchOnVariantByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SwitchOnVariantByName_FunctionAddress, "ReturnValue");
		SwitchOnVariantByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchOnVariantByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SwitchOnVariantByName_IsValid = SwitchOnVariantByName_FunctionAddress != IntPtr.Zero && SwitchOnVariantByName_VariantSetName_IsValid && SwitchOnVariantByName_VariantName_IsValid && SwitchOnVariantByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.LevelVariantSetsActor:SwitchOnVariantByName", SwitchOnVariantByName_IsValid);
		SwitchOnVariantByIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchOnVariantByIndex");
		SwitchOnVariantByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchOnVariantByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchOnVariantByIndex_VariantSetIndex_PropertyAddress, SwitchOnVariantByIndex_FunctionAddress, "VariantSetIndex");
		SwitchOnVariantByIndex_VariantSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(SwitchOnVariantByIndex_FunctionAddress, "VariantSetIndex");
		SwitchOnVariantByIndex_VariantSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchOnVariantByIndex_FunctionAddress, "VariantSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchOnVariantByIndex_VariantIndex_PropertyAddress, SwitchOnVariantByIndex_FunctionAddress, "VariantIndex");
		SwitchOnVariantByIndex_VariantIndex_Offset = NativeReflectionCached.GetPropertyOffset(SwitchOnVariantByIndex_FunctionAddress, "VariantIndex");
		SwitchOnVariantByIndex_VariantIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchOnVariantByIndex_FunctionAddress, "VariantIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchOnVariantByIndex_ReturnValue_PropertyAddress, SwitchOnVariantByIndex_FunctionAddress, "ReturnValue");
		SwitchOnVariantByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SwitchOnVariantByIndex_FunctionAddress, "ReturnValue");
		SwitchOnVariantByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchOnVariantByIndex_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SwitchOnVariantByIndex_IsValid = SwitchOnVariantByIndex_FunctionAddress != IntPtr.Zero && SwitchOnVariantByIndex_VariantSetIndex_IsValid && SwitchOnVariantByIndex_VariantIndex_IsValid && SwitchOnVariantByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.LevelVariantSetsActor:SwitchOnVariantByIndex", SwitchOnVariantByIndex_IsValid);
		SetLevelVariantSets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLevelVariantSets");
		SetLevelVariantSets_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLevelVariantSets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLevelVariantSets_InVariantSets_PropertyAddress, SetLevelVariantSets_FunctionAddress, "InVariantSets");
		SetLevelVariantSets_InVariantSets_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelVariantSets_FunctionAddress, "InVariantSets");
		SetLevelVariantSets_InVariantSets_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelVariantSets_FunctionAddress, "InVariantSets", Classes.FObjectProperty);
		SetLevelVariantSets_IsValid = SetLevelVariantSets_FunctionAddress != IntPtr.Zero && SetLevelVariantSets_InVariantSets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.LevelVariantSetsActor:SetLevelVariantSets", SetLevelVariantSets_IsValid);
		GetLevelVariantSets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLevelVariantSets");
		GetLevelVariantSets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelVariantSets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelVariantSets_bLoad_PropertyAddress, GetLevelVariantSets_FunctionAddress, "bLoad");
		GetLevelVariantSets_bLoad_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelVariantSets_FunctionAddress, "bLoad");
		GetLevelVariantSets_bLoad_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelVariantSets_FunctionAddress, "bLoad", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelVariantSets_ReturnValue_PropertyAddress, GetLevelVariantSets_FunctionAddress, "ReturnValue");
		GetLevelVariantSets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelVariantSets_FunctionAddress, "ReturnValue");
		GetLevelVariantSets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelVariantSets_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLevelVariantSets_IsValid = GetLevelVariantSets_FunctionAddress != IntPtr.Zero && GetLevelVariantSets_bLoad_IsValid && GetLevelVariantSets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.LevelVariantSetsActor:GetLevelVariantSets", GetLevelVariantSets_IsValid);
	}
}
