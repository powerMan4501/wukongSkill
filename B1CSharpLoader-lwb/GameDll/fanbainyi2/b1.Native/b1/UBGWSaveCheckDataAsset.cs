using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGWSaveCheckDataAsset", "b1", UnrealModuleType.Game)]
public class UBGWSaveCheckDataAsset : UBGWDataAsset
{
	private static bool SaveCheckCS_IsValid;

	private IntPtr SaveCheckCS_InstanceFunctionAddress;

	private static IntPtr SaveCheckCS_FunctionAddress;

	private static int SaveCheckCS_ParamsSize;

	private static bool SaveCheckCS_OutTitle_IsValid;

	private static FFieldAddress SaveCheckCS_OutTitle_PropertyAddress;

	private static int SaveCheckCS_OutTitle_Offset;

	private static bool SaveCheckCS_OutMessage_IsValid;

	private static FFieldAddress SaveCheckCS_OutMessage_PropertyAddress;

	private static int SaveCheckCS_OutMessage_Offset;

	private static bool SaveCheckCS_ReturnValue_IsValid;

	private static FFieldAddress SaveCheckCS_ReturnValue_PropertyAddress;

	private static int SaveCheckCS_ReturnValue_Offset;

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/b1.BGWSaveCheckDataAsset:SaveCheckCS")]
	public unsafe bool SaveCheckCS(out string OutTitle, out string OutMessage)
	{
		CheckDestroyed();
		if (!SaveCheckCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWSaveCheckDataAsset:SaveCheckCS");
			OutTitle = FStringMarshaler.DefaultString;
			OutMessage = FStringMarshaler.DefaultString;
			return false;
		}
		if (SaveCheckCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			SaveCheckCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SaveCheckCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveCheckCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveCheckCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SaveCheckCS_InstanceFunctionAddress, intPtr, SaveCheckCS_ParamsSize);
		OutTitle = FStringMarshaler.FromNative(IntPtr.Add(intPtr, SaveCheckCS_OutTitle_Offset), 0, SaveCheckCS_OutTitle_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SaveCheckCS_OutTitle_PropertyAddress.Address, intPtr);
		OutMessage = FStringMarshaler.FromNative(IntPtr.Add(intPtr, SaveCheckCS_OutMessage_Offset), 0, SaveCheckCS_OutMessage_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SaveCheckCS_OutMessage_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SaveCheckCS_ReturnValue_Offset), 0, SaveCheckCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool SaveCheckCS_Implementation(out string OutTitle, out string OutMessage)
	{
		CheckDestroyed();
		if (!SaveCheckCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWSaveCheckDataAsset:SaveCheckCS");
			OutTitle = FStringMarshaler.DefaultString;
			OutMessage = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveCheckCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveCheckCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SaveCheckCS_FunctionAddress, intPtr, SaveCheckCS_ParamsSize);
		OutTitle = FStringMarshaler.FromNative(IntPtr.Add(intPtr, SaveCheckCS_OutTitle_Offset), 0, SaveCheckCS_OutTitle_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SaveCheckCS_OutTitle_PropertyAddress.Address, intPtr);
		OutMessage = FStringMarshaler.FromNative(IntPtr.Add(intPtr, SaveCheckCS_OutMessage_Offset), 0, SaveCheckCS_OutMessage_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SaveCheckCS_OutMessage_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SaveCheckCS_ReturnValue_Offset), 0, SaveCheckCS_ReturnValue_PropertyAddress.Address);
	}

	static UBGWSaveCheckDataAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWSaveCheckDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWSaveCheckDataAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWSaveCheckDataAsset");
		SaveCheckCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SaveCheckCS");
		SaveCheckCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveCheckCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveCheckCS_OutTitle_PropertyAddress, SaveCheckCS_FunctionAddress, "OutTitle");
		SaveCheckCS_OutTitle_Offset = NativeReflectionCached.GetPropertyOffset(SaveCheckCS_FunctionAddress, "OutTitle");
		SaveCheckCS_OutTitle_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveCheckCS_FunctionAddress, "OutTitle", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveCheckCS_OutMessage_PropertyAddress, SaveCheckCS_FunctionAddress, "OutMessage");
		SaveCheckCS_OutMessage_Offset = NativeReflectionCached.GetPropertyOffset(SaveCheckCS_FunctionAddress, "OutMessage");
		SaveCheckCS_OutMessage_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveCheckCS_FunctionAddress, "OutMessage", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveCheckCS_ReturnValue_PropertyAddress, SaveCheckCS_FunctionAddress, "ReturnValue");
		SaveCheckCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SaveCheckCS_FunctionAddress, "ReturnValue");
		SaveCheckCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveCheckCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SaveCheckCS_IsValid = SaveCheckCS_FunctionAddress != IntPtr.Zero && SaveCheckCS_OutTitle_IsValid && SaveCheckCS_OutMessage_IsValid && SaveCheckCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWSaveCheckDataAsset:SaveCheckCS", SaveCheckCS_IsValid);
	}
}
