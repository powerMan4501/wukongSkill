using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/MM.FilmstormFunctionLibrary", "MM", UnrealModuleType.GamePlugin)]
public class UFilmstormFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool CreatePlayerInputDirection_IsValid;

	private static IntPtr CreatePlayerInputDirection_FunctionAddress;

	private static int CreatePlayerInputDirection_ParamsSize;

	private static bool CreatePlayerInputDirection_OutConstructTargetDirection_IsValid;

	private static FFieldAddress CreatePlayerInputDirection_OutConstructTargetDirection_PropertyAddress;

	private static int CreatePlayerInputDirection_OutConstructTargetDirection_Offset;

	private static bool CreatePlayerInputDirection_DesiredTransform_IsValid;

	private static FFieldAddress CreatePlayerInputDirection_DesiredTransform_PropertyAddress;

	private static int CreatePlayerInputDirection_DesiredTransform_Offset;

	private static bool CreatePlayerInputDirection_RootWorldTransform_IsValid;

	private static FFieldAddress CreatePlayerInputDirection_RootWorldTransform_PropertyAddress;

	private static int CreatePlayerInputDirection_RootWorldTransform_Offset;

	private static bool CreatePlayerInputDirection_TargetDirectionInputStrength_IsValid;

	private static FFieldAddress CreatePlayerInputDirection_TargetDirectionInputStrength_PropertyAddress;

	private static int CreatePlayerInputDirection_TargetDirectionInputStrength_Offset;

	[UFunction(Flags = 79963137u)]
	[UMetaPath("/Script/MM.FilmstormFunctionLibrary:CreatePlayerInputDirection")]
	public unsafe static void CreatePlayerInputDirection(out FInputPlayerDirectionData OutConstructTargetDirection, FTransform DesiredTransform, FTransform RootWorldTransform, float TargetDirectionInputStrength)
	{
		if (!CreatePlayerInputDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.FilmstormFunctionLibrary:CreatePlayerInputDirection");
			OutConstructTargetDirection = default(FInputPlayerDirectionData);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePlayerInputDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePlayerInputDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreatePlayerInputDirection_OutConstructTargetDirection_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(CreatePlayerInputDirection_DesiredTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, CreatePlayerInputDirection_DesiredTransform_Offset), 0, CreatePlayerInputDirection_DesiredTransform_PropertyAddress.Address, DesiredTransform);
		NativeReflection.InitializeValue_InContainer(CreatePlayerInputDirection_RootWorldTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, CreatePlayerInputDirection_RootWorldTransform_Offset), 0, CreatePlayerInputDirection_RootWorldTransform_PropertyAddress.Address, RootWorldTransform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CreatePlayerInputDirection_TargetDirectionInputStrength_Offset), 0, CreatePlayerInputDirection_TargetDirectionInputStrength_PropertyAddress.Address, TargetDirectionInputStrength);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreatePlayerInputDirection_FunctionAddress, intPtr, CreatePlayerInputDirection_ParamsSize);
		OutConstructTargetDirection = FInputPlayerDirectionData.FromNative(IntPtr.Add(intPtr, CreatePlayerInputDirection_OutConstructTargetDirection_Offset), 0, CreatePlayerInputDirection_OutConstructTargetDirection_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreatePlayerInputDirection_OutConstructTargetDirection_PropertyAddress.Address, intPtr);
	}

	static UFilmstormFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFilmstormFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFilmstormFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/MM.FilmstormFunctionLibrary");
		CreatePlayerInputDirection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreatePlayerInputDirection");
		CreatePlayerInputDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatePlayerInputDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreatePlayerInputDirection_OutConstructTargetDirection_PropertyAddress, CreatePlayerInputDirection_FunctionAddress, "OutConstructTargetDirection");
		CreatePlayerInputDirection_OutConstructTargetDirection_Offset = NativeReflectionCached.GetPropertyOffset(CreatePlayerInputDirection_FunctionAddress, "OutConstructTargetDirection");
		CreatePlayerInputDirection_OutConstructTargetDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePlayerInputDirection_FunctionAddress, "OutConstructTargetDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePlayerInputDirection_DesiredTransform_PropertyAddress, CreatePlayerInputDirection_FunctionAddress, "DesiredTransform");
		CreatePlayerInputDirection_DesiredTransform_Offset = NativeReflectionCached.GetPropertyOffset(CreatePlayerInputDirection_FunctionAddress, "DesiredTransform");
		CreatePlayerInputDirection_DesiredTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePlayerInputDirection_FunctionAddress, "DesiredTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePlayerInputDirection_RootWorldTransform_PropertyAddress, CreatePlayerInputDirection_FunctionAddress, "RootWorldTransform");
		CreatePlayerInputDirection_RootWorldTransform_Offset = NativeReflectionCached.GetPropertyOffset(CreatePlayerInputDirection_FunctionAddress, "RootWorldTransform");
		CreatePlayerInputDirection_RootWorldTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePlayerInputDirection_FunctionAddress, "RootWorldTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePlayerInputDirection_TargetDirectionInputStrength_PropertyAddress, CreatePlayerInputDirection_FunctionAddress, "TargetDirectionInputStrength");
		CreatePlayerInputDirection_TargetDirectionInputStrength_Offset = NativeReflectionCached.GetPropertyOffset(CreatePlayerInputDirection_FunctionAddress, "TargetDirectionInputStrength");
		CreatePlayerInputDirection_TargetDirectionInputStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePlayerInputDirection_FunctionAddress, "TargetDirectionInputStrength", Classes.FFloatProperty);
		CreatePlayerInputDirection_IsValid = CreatePlayerInputDirection_FunctionAddress != IntPtr.Zero && CreatePlayerInputDirection_OutConstructTargetDirection_IsValid && CreatePlayerInputDirection_DesiredTransform_IsValid && CreatePlayerInputDirection_RootWorldTransform_IsValid && CreatePlayerInputDirection_TargetDirectionInputStrength_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.FilmstormFunctionLibrary:CreatePlayerInputDirection", CreatePlayerInputDirection_IsValid);
	}
}
