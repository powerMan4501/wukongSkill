using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.BG_DetailCustomizationManager", "FuncLibEditor", UnrealModuleType.Game)]
public class UBG_DetailCustomizationManager : UObject
{
	private static bool Unregister_IsValid;

	private static IntPtr Unregister_FunctionAddress;

	private static int Unregister_ParamsSize;

	private static bool AddClassDetailCustomization_IsValid;

	private static IntPtr AddClassDetailCustomization_FunctionAddress;

	private static int AddClassDetailCustomization_ParamsSize;

	private static bool AddClassDetailCustomization_ClassName_IsValid;

	private static FFieldAddress AddClassDetailCustomization_ClassName_PropertyAddress;

	private static int AddClassDetailCustomization_ClassName_Offset;

	private static bool AddClassDetailCustomization_DetailCustomization_IsValid;

	private static FFieldAddress AddClassDetailCustomization_DetailCustomization_PropertyAddress;

	private static int AddClassDetailCustomization_DetailCustomization_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.BG_DetailCustomizationManager:Unregister")]
	public unsafe void Unregister()
	{
		CheckDestroyed();
		if (!Unregister_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.BG_DetailCustomizationManager:Unregister");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Unregister_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Unregister_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Unregister_FunctionAddress, argsSize: Unregister_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.BG_DetailCustomizationManager:AddClassDetailCustomization")]
	public unsafe void AddClassDetailCustomization(FName ClassName, UDetailCustomizationBaseForCs DetailCustomization)
	{
		CheckDestroyed();
		if (!AddClassDetailCustomization_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.BG_DetailCustomizationManager:AddClassDetailCustomization");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddClassDetailCustomization_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddClassDetailCustomization_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddClassDetailCustomization_ClassName_Offset), 0, AddClassDetailCustomization_ClassName_PropertyAddress.Address, ClassName);
		UObjectMarshaler<UDetailCustomizationBaseForCs>.ToNative(IntPtr.Add(intPtr, AddClassDetailCustomization_DetailCustomization_Offset), 0, AddClassDetailCustomization_DetailCustomization_PropertyAddress.Address, DetailCustomization);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddClassDetailCustomization_FunctionAddress, intPtr, AddClassDetailCustomization_ParamsSize);
	}

	static UBG_DetailCustomizationManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBG_DetailCustomizationManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBG_DetailCustomizationManager));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/FuncLibEditor.BG_DetailCustomizationManager");
		Unregister_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Unregister");
		Unregister_ParamsSize = NativeReflection.GetFunctionParamsSize(Unregister_FunctionAddress);
		Unregister_IsValid = Unregister_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.BG_DetailCustomizationManager:Unregister", Unregister_IsValid);
		AddClassDetailCustomization_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddClassDetailCustomization");
		AddClassDetailCustomization_ParamsSize = NativeReflection.GetFunctionParamsSize(AddClassDetailCustomization_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddClassDetailCustomization_ClassName_PropertyAddress, AddClassDetailCustomization_FunctionAddress, "ClassName");
		AddClassDetailCustomization_ClassName_Offset = NativeReflectionCached.GetPropertyOffset(AddClassDetailCustomization_FunctionAddress, "ClassName");
		AddClassDetailCustomization_ClassName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddClassDetailCustomization_FunctionAddress, "ClassName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddClassDetailCustomization_DetailCustomization_PropertyAddress, AddClassDetailCustomization_FunctionAddress, "DetailCustomization");
		AddClassDetailCustomization_DetailCustomization_Offset = NativeReflectionCached.GetPropertyOffset(AddClassDetailCustomization_FunctionAddress, "DetailCustomization");
		AddClassDetailCustomization_DetailCustomization_IsValid = NativeReflectionCached.ValidatePropertyClass(AddClassDetailCustomization_FunctionAddress, "DetailCustomization", Classes.FObjectProperty);
		AddClassDetailCustomization_IsValid = AddClassDetailCustomization_FunctionAddress != IntPtr.Zero && AddClassDetailCustomization_ClassName_IsValid && AddClassDetailCustomization_DetailCustomization_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.BG_DetailCustomizationManager:AddClassDetailCustomization", AddClassDetailCustomization_IsValid);
	}
}
