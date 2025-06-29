using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.TileView", "UMG", UnrealModuleType.Engine)]
public class UTileView : UListView
{
	private static bool SetEntryWidth_IsValid;

	private static IntPtr SetEntryWidth_FunctionAddress;

	private static int SetEntryWidth_ParamsSize;

	private static bool SetEntryWidth_NewWidth_IsValid;

	private static FFieldAddress SetEntryWidth_NewWidth_PropertyAddress;

	private static int SetEntryWidth_NewWidth_Offset;

	private static bool SetEntryHeight_IsValid;

	private static IntPtr SetEntryHeight_FunctionAddress;

	private static int SetEntryHeight_ParamsSize;

	private static bool SetEntryHeight_NewHeight_IsValid;

	private static FFieldAddress SetEntryHeight_NewHeight_PropertyAddress;

	private static int SetEntryHeight_NewHeight_Offset;

	private static bool GetEntryWidth_IsValid;

	private static IntPtr GetEntryWidth_FunctionAddress;

	private static int GetEntryWidth_ParamsSize;

	private static bool GetEntryWidth_ReturnValue_IsValid;

	private static FFieldAddress GetEntryWidth_ReturnValue_PropertyAddress;

	private static int GetEntryWidth_ReturnValue_Offset;

	private static bool GetEntryHeight_IsValid;

	private static IntPtr GetEntryHeight_FunctionAddress;

	private static int GetEntryHeight_ParamsSize;

	private static bool GetEntryHeight_ReturnValue_IsValid;

	private static FFieldAddress GetEntryHeight_ReturnValue_PropertyAddress;

	private static int GetEntryHeight_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.TileView:SetEntryWidth")]
	public unsafe void SetEntryWidth(float NewWidth)
	{
		CheckDestroyed();
		if (!SetEntryWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TileView:SetEntryWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEntryWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEntryWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetEntryWidth_NewWidth_Offset), 0, SetEntryWidth_NewWidth_PropertyAddress.Address, NewWidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEntryWidth_FunctionAddress, intPtr, SetEntryWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.TileView:SetEntryHeight")]
	public unsafe void SetEntryHeight(float NewHeight)
	{
		CheckDestroyed();
		if (!SetEntryHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TileView:SetEntryHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEntryHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEntryHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetEntryHeight_NewHeight_Offset), 0, SetEntryHeight_NewHeight_PropertyAddress.Address, NewHeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEntryHeight_FunctionAddress, intPtr, SetEntryHeight_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.TileView:GetEntryWidth")]
	public unsafe float GetEntryWidth()
	{
		CheckDestroyed();
		if (!GetEntryWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TileView:GetEntryWidth");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEntryWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEntryWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEntryWidth_FunctionAddress, intPtr, GetEntryWidth_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetEntryWidth_ReturnValue_Offset), 0, GetEntryWidth_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.TileView:GetEntryHeight")]
	public unsafe float GetEntryHeight()
	{
		CheckDestroyed();
		if (!GetEntryHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.TileView:GetEntryHeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEntryHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEntryHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEntryHeight_FunctionAddress, intPtr, GetEntryHeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetEntryHeight_ReturnValue_Offset), 0, GetEntryHeight_ReturnValue_PropertyAddress.Address);
	}

	static UTileView()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTileView)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTileView));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMG.TileView");
		SetEntryWidth_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEntryWidth");
		SetEntryWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEntryWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEntryWidth_NewWidth_PropertyAddress, SetEntryWidth_FunctionAddress, "NewWidth");
		SetEntryWidth_NewWidth_Offset = NativeReflectionCached.GetPropertyOffset(SetEntryWidth_FunctionAddress, "NewWidth");
		SetEntryWidth_NewWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEntryWidth_FunctionAddress, "NewWidth", Classes.FFloatProperty);
		SetEntryWidth_IsValid = SetEntryWidth_FunctionAddress != IntPtr.Zero && SetEntryWidth_NewWidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TileView:SetEntryWidth", SetEntryWidth_IsValid);
		SetEntryHeight_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEntryHeight");
		SetEntryHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEntryHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEntryHeight_NewHeight_PropertyAddress, SetEntryHeight_FunctionAddress, "NewHeight");
		SetEntryHeight_NewHeight_Offset = NativeReflectionCached.GetPropertyOffset(SetEntryHeight_FunctionAddress, "NewHeight");
		SetEntryHeight_NewHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEntryHeight_FunctionAddress, "NewHeight", Classes.FFloatProperty);
		SetEntryHeight_IsValid = SetEntryHeight_FunctionAddress != IntPtr.Zero && SetEntryHeight_NewHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TileView:SetEntryHeight", SetEntryHeight_IsValid);
		GetEntryWidth_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEntryWidth");
		GetEntryWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEntryWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEntryWidth_ReturnValue_PropertyAddress, GetEntryWidth_FunctionAddress, "ReturnValue");
		GetEntryWidth_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEntryWidth_FunctionAddress, "ReturnValue");
		GetEntryWidth_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEntryWidth_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetEntryWidth_IsValid = GetEntryWidth_FunctionAddress != IntPtr.Zero && GetEntryWidth_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TileView:GetEntryWidth", GetEntryWidth_IsValid);
		GetEntryHeight_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEntryHeight");
		GetEntryHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEntryHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEntryHeight_ReturnValue_PropertyAddress, GetEntryHeight_FunctionAddress, "ReturnValue");
		GetEntryHeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEntryHeight_FunctionAddress, "ReturnValue");
		GetEntryHeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEntryHeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetEntryHeight_IsValid = GetEntryHeight_FunctionAddress != IntPtr.Zero && GetEntryHeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.TileView:GetEntryHeight", GetEntryHeight_IsValid);
	}
}
