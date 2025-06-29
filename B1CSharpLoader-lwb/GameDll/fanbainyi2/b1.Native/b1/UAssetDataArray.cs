using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.AssetDataArray", "UnrealExtent", UnrealModuleType.Game)]
public class UAssetDataArray : UObject
{
	private static bool AssetDataArr_IsValid;

	private static FFieldAddress AssetDataArr_PropertyAddress;

	private static int AssetDataArr_Offset;

	private TArrayReadWriteMarshaler<FAssetData> AssetDataArr_MarshalerCached;

	private static bool ActiveIdx_IsValid;

	private static int ActiveIdx_Offset;

	private static bool SetActiveIdx_IsValid;

	private static IntPtr SetActiveIdx_FunctionAddress;

	private static int SetActiveIdx_ParamsSize;

	private static bool SetActiveIdx_Idx_IsValid;

	private static FFieldAddress SetActiveIdx_Idx_PropertyAddress;

	private static int SetActiveIdx_Idx_Offset;

	private static bool GetAssetDataCount_IsValid;

	private static IntPtr GetAssetDataCount_FunctionAddress;

	private static int GetAssetDataCount_ParamsSize;

	private static bool GetAssetDataCount_ReturnValue_IsValid;

	private static FFieldAddress GetAssetDataCount_ReturnValue_PropertyAddress;

	private static int GetAssetDataCount_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/UnrealExtent.AssetDataArray:AssetDataArr")]
	public TArrayReadWrite<FAssetData> AssetDataArr
	{
		get
		{
			CheckDestroyed();
			if (!AssetDataArr_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AssetDataArray:AssetDataArr");
				return null;
			}
			if (AssetDataArr_MarshalerCached == null)
			{
				AssetDataArr_MarshalerCached = new TArrayReadWriteMarshaler<FAssetData>(1, AssetDataArr_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative);
			}
			return AssetDataArr_MarshalerCached.FromNative(IntPtr.Add(base.Address, AssetDataArr_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.AssetDataArray:ActiveIdx")]
	public int ActiveIdx
	{
		get
		{
			CheckDestroyed();
			if (!ActiveIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AssetDataArray:ActiveIdx");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ActiveIdx_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActiveIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AssetDataArray:ActiveIdx");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ActiveIdx_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AssetDataArray:SetActiveIdx")]
	public unsafe void SetActiveIdx(int Idx)
	{
		CheckDestroyed();
		if (!SetActiveIdx_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AssetDataArray:SetActiveIdx");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActiveIdx_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActiveIdx_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetActiveIdx_Idx_Offset), 0, SetActiveIdx_Idx_PropertyAddress.Address, Idx);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActiveIdx_FunctionAddress, intPtr, SetActiveIdx_ParamsSize);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/UnrealExtent.AssetDataArray:GetAssetDataCount")]
	public unsafe int GetAssetDataCount()
	{
		CheckDestroyed();
		if (!GetAssetDataCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AssetDataArray:GetAssetDataCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetDataCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetDataCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetDataCount_FunctionAddress, intPtr, GetAssetDataCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAssetDataCount_ReturnValue_Offset), 0, GetAssetDataCount_ReturnValue_PropertyAddress.Address);
	}

	static UAssetDataArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAssetDataArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAssetDataArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.AssetDataArray");
		NativeReflectionCached.GetPropertyRef(ref AssetDataArr_PropertyAddress, intPtr, "AssetDataArr");
		AssetDataArr_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AssetDataArr");
		AssetDataArr_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AssetDataArr", Classes.FArrayProperty);
		ActiveIdx_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActiveIdx");
		ActiveIdx_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActiveIdx", Classes.FIntProperty);
		SetActiveIdx_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActiveIdx");
		SetActiveIdx_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActiveIdx_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActiveIdx_Idx_PropertyAddress, SetActiveIdx_FunctionAddress, "Idx");
		SetActiveIdx_Idx_Offset = NativeReflectionCached.GetPropertyOffset(SetActiveIdx_FunctionAddress, "Idx");
		SetActiveIdx_Idx_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActiveIdx_FunctionAddress, "Idx", Classes.FIntProperty);
		SetActiveIdx_IsValid = SetActiveIdx_FunctionAddress != IntPtr.Zero && SetActiveIdx_Idx_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AssetDataArray:SetActiveIdx", SetActiveIdx_IsValid);
		GetAssetDataCount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAssetDataCount");
		GetAssetDataCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetDataCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataCount_ReturnValue_PropertyAddress, GetAssetDataCount_FunctionAddress, "ReturnValue");
		GetAssetDataCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataCount_FunctionAddress, "ReturnValue");
		GetAssetDataCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetAssetDataCount_IsValid = GetAssetDataCount_FunctionAddress != IntPtr.Zero && GetAssetDataCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AssetDataArray:GetAssetDataCount", GetAssetDataCount_IsValid);
	}
}
