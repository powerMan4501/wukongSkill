using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUFuncLibAI", "b1", UnrealModuleType.Game)]
public class UBGUFuncLibAI : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool BGURequestAITurnTo_IsValid;

	private static IntPtr BGURequestAITurnTo_FunctionAddress;

	private static int BGURequestAITurnTo_ParamsSize;

	private static bool BGURequestAITurnTo_Unit_IsValid;

	private static FFieldAddress BGURequestAITurnTo_Unit_PropertyAddress;

	private static int BGURequestAITurnTo_Unit_Offset;

	private static bool BGURequestAITurnTo_Position_IsValid;

	private static FFieldAddress BGURequestAITurnTo_Position_PropertyAddress;

	private static int BGURequestAITurnTo_Position_Offset;

	private static bool BGURequestAITurnTo_ReturnValue_IsValid;

	private static FFieldAddress BGURequestAITurnTo_ReturnValue_PropertyAddress;

	private static int BGURequestAITurnTo_ReturnValue_Offset;

	private static bool BGUIsAIRequestActive_IsValid;

	private static IntPtr BGUIsAIRequestActive_FunctionAddress;

	private static int BGUIsAIRequestActive_ParamsSize;

	private static bool BGUIsAIRequestActive_Unit_IsValid;

	private static FFieldAddress BGUIsAIRequestActive_Unit_PropertyAddress;

	private static int BGUIsAIRequestActive_Unit_Offset;

	private static bool BGUIsAIRequestActive_RequestID_IsValid;

	private static FFieldAddress BGUIsAIRequestActive_RequestID_PropertyAddress;

	private static int BGUIsAIRequestActive_RequestID_Offset;

	private static bool BGUIsAIRequestActive_ReturnValue_IsValid;

	private static FFieldAddress BGUIsAIRequestActive_ReturnValue_PropertyAddress;

	private static int BGUIsAIRequestActive_ReturnValue_Offset;

	private static bool BGUAICaculateTargetAngle_IsValid;

	private static IntPtr BGUAICaculateTargetAngle_FunctionAddress;

	private static int BGUAICaculateTargetAngle_ParamsSize;

	private static bool BGUAICaculateTargetAngle_Target_IsValid;

	private static FFieldAddress BGUAICaculateTargetAngle_Target_PropertyAddress;

	private static int BGUAICaculateTargetAngle_Target_Offset;

	private static bool BGUAICaculateTargetAngle_MySelf_IsValid;

	private static FFieldAddress BGUAICaculateTargetAngle_MySelf_PropertyAddress;

	private static int BGUAICaculateTargetAngle_MySelf_Offset;

	private static bool BGUAICaculateTargetAngle_ReturnValue_IsValid;

	private static FFieldAddress BGUAICaculateTargetAngle_ReturnValue_PropertyAddress;

	private static int BGUAICaculateTargetAngle_ReturnValue_Offset;

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUFuncLibAI:BGURequestAITurnTo")]
	public unsafe static int BGURequestAITurnTo(AActor Unit, FVector Position)
	{
		if (!BGURequestAITurnTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibAI:BGURequestAITurnTo");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGURequestAITurnTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGURequestAITurnTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGURequestAITurnTo_Unit_Offset), 0, BGURequestAITurnTo_Unit_PropertyAddress.Address, Unit);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGURequestAITurnTo_Position_Offset), 0, BGURequestAITurnTo_Position_PropertyAddress.Address, Position);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGURequestAITurnTo_FunctionAddress, intPtr, BGURequestAITurnTo_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGURequestAITurnTo_ReturnValue_Offset), 0, BGURequestAITurnTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFuncLibAI:BGUIsAIRequestActive")]
	public unsafe static bool BGUIsAIRequestActive(AActor Unit, int RequestID)
	{
		if (!BGUIsAIRequestActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibAI:BGUIsAIRequestActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUIsAIRequestActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUIsAIRequestActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUIsAIRequestActive_Unit_Offset), 0, BGUIsAIRequestActive_Unit_PropertyAddress.Address, Unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUIsAIRequestActive_RequestID_Offset), 0, BGUIsAIRequestActive_RequestID_PropertyAddress.Address, RequestID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUIsAIRequestActive_FunctionAddress, intPtr, BGUIsAIRequestActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUIsAIRequestActive_ReturnValue_Offset), 0, BGUIsAIRequestActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFuncLibAI:BGUAICaculateTargetAngle")]
	public unsafe static float BGUAICaculateTargetAngle(AActor Target, AActor MySelf)
	{
		if (!BGUAICaculateTargetAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibAI:BGUAICaculateTargetAngle");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUAICaculateTargetAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUAICaculateTargetAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUAICaculateTargetAngle_Target_Offset), 0, BGUAICaculateTargetAngle_Target_PropertyAddress.Address, Target);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUAICaculateTargetAngle_MySelf_Offset), 0, BGUAICaculateTargetAngle_MySelf_PropertyAddress.Address, MySelf);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUAICaculateTargetAngle_FunctionAddress, intPtr, BGUAICaculateTargetAngle_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUAICaculateTargetAngle_ReturnValue_Offset), 0, BGUAICaculateTargetAngle_ReturnValue_PropertyAddress.Address);
	}

	static UBGUFuncLibAI()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUFuncLibAI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUFuncLibAI));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUFuncLibAI");
		BGURequestAITurnTo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGURequestAITurnTo");
		BGURequestAITurnTo_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURequestAITurnTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGURequestAITurnTo_Unit_PropertyAddress, BGURequestAITurnTo_FunctionAddress, "Unit");
		BGURequestAITurnTo_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGURequestAITurnTo_FunctionAddress, "Unit");
		BGURequestAITurnTo_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURequestAITurnTo_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURequestAITurnTo_Position_PropertyAddress, BGURequestAITurnTo_FunctionAddress, "Position");
		BGURequestAITurnTo_Position_Offset = NativeReflectionCached.GetPropertyOffset(BGURequestAITurnTo_FunctionAddress, "Position");
		BGURequestAITurnTo_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURequestAITurnTo_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURequestAITurnTo_ReturnValue_PropertyAddress, BGURequestAITurnTo_FunctionAddress, "ReturnValue");
		BGURequestAITurnTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGURequestAITurnTo_FunctionAddress, "ReturnValue");
		BGURequestAITurnTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURequestAITurnTo_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGURequestAITurnTo_IsValid = BGURequestAITurnTo_FunctionAddress != IntPtr.Zero && BGURequestAITurnTo_Unit_IsValid && BGURequestAITurnTo_Position_IsValid && BGURequestAITurnTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibAI:BGURequestAITurnTo", BGURequestAITurnTo_IsValid);
		BGUIsAIRequestActive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUIsAIRequestActive");
		BGUIsAIRequestActive_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUIsAIRequestActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUIsAIRequestActive_Unit_PropertyAddress, BGUIsAIRequestActive_FunctionAddress, "Unit");
		BGUIsAIRequestActive_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUIsAIRequestActive_FunctionAddress, "Unit");
		BGUIsAIRequestActive_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUIsAIRequestActive_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUIsAIRequestActive_RequestID_PropertyAddress, BGUIsAIRequestActive_FunctionAddress, "RequestID");
		BGUIsAIRequestActive_RequestID_Offset = NativeReflectionCached.GetPropertyOffset(BGUIsAIRequestActive_FunctionAddress, "RequestID");
		BGUIsAIRequestActive_RequestID_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUIsAIRequestActive_FunctionAddress, "RequestID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUIsAIRequestActive_ReturnValue_PropertyAddress, BGUIsAIRequestActive_FunctionAddress, "ReturnValue");
		BGUIsAIRequestActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUIsAIRequestActive_FunctionAddress, "ReturnValue");
		BGUIsAIRequestActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUIsAIRequestActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUIsAIRequestActive_IsValid = BGUIsAIRequestActive_FunctionAddress != IntPtr.Zero && BGUIsAIRequestActive_Unit_IsValid && BGUIsAIRequestActive_RequestID_IsValid && BGUIsAIRequestActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibAI:BGUIsAIRequestActive", BGUIsAIRequestActive_IsValid);
		BGUAICaculateTargetAngle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUAICaculateTargetAngle");
		BGUAICaculateTargetAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAICaculateTargetAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUAICaculateTargetAngle_Target_PropertyAddress, BGUAICaculateTargetAngle_FunctionAddress, "Target");
		BGUAICaculateTargetAngle_Target_Offset = NativeReflectionCached.GetPropertyOffset(BGUAICaculateTargetAngle_FunctionAddress, "Target");
		BGUAICaculateTargetAngle_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUAICaculateTargetAngle_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUAICaculateTargetAngle_MySelf_PropertyAddress, BGUAICaculateTargetAngle_FunctionAddress, "MySelf");
		BGUAICaculateTargetAngle_MySelf_Offset = NativeReflectionCached.GetPropertyOffset(BGUAICaculateTargetAngle_FunctionAddress, "MySelf");
		BGUAICaculateTargetAngle_MySelf_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUAICaculateTargetAngle_FunctionAddress, "MySelf", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUAICaculateTargetAngle_ReturnValue_PropertyAddress, BGUAICaculateTargetAngle_FunctionAddress, "ReturnValue");
		BGUAICaculateTargetAngle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUAICaculateTargetAngle_FunctionAddress, "ReturnValue");
		BGUAICaculateTargetAngle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUAICaculateTargetAngle_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUAICaculateTargetAngle_IsValid = BGUAICaculateTargetAngle_FunctionAddress != IntPtr.Zero && BGUAICaculateTargetAngle_Target_IsValid && BGUAICaculateTargetAngle_MySelf_IsValid && BGUAICaculateTargetAngle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibAI:BGUAICaculateTargetAngle", BGUAICaculateTargetAngle_IsValid);
	}
}
