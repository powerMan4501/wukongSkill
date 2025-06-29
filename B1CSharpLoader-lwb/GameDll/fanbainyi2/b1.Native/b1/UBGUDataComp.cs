using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUDataComp", "b1", UnrealModuleType.Game)]
public class UBGUDataComp : UActorDataContainer
{
	private static bool mUBUC_AIComponent_IsValid;

	private static int mUBUC_AIComponent_Offset;

	private static bool mUBUC_ACharacterComponent_IsValid;

	private static int mUBUC_ACharacterComponent_Offset;

	private static bool InitWithCharacter_IsValid;

	private static IntPtr InitWithCharacter_FunctionAddress;

	private static int InitWithCharacter_ParamsSize;

	private static bool InitWithCharacter_Character_IsValid;

	private static FFieldAddress InitWithCharacter_Character_PropertyAddress;

	private static int InitWithCharacter_Character_Offset;

	private static bool InitWithAIController_IsValid;

	private static IntPtr InitWithAIController_FunctionAddress;

	private static int InitWithAIController_ParamsSize;

	private static bool InitWithAIController_AIController_IsValid;

	private static FFieldAddress InitWithAIController_AIController_PropertyAddress;

	private static int InitWithAIController_AIController_Offset;

	[UProperty(Flags = (PropFlags)11267864954675716uL)]
	[UMetaPath("/Script/b1.BGUDataComp:mUBUC_AIComponent")]
	protected UBUC_AIComponent mUBUC_AIComponent
	{
		get
		{
			CheckDestroyed();
			if (!mUBUC_AIComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDataComp:mUBUC_AIComponent");
				return null;
			}
			return UObjectMarshaler<UBUC_AIComponent>.FromNative(IntPtr.Add(base.Address, mUBUC_AIComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!mUBUC_AIComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDataComp:mUBUC_AIComponent");
			}
			else
			{
				UObjectMarshaler<UBUC_AIComponent>.ToNative(IntPtr.Add(base.Address, mUBUC_AIComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954675716uL)]
	[UMetaPath("/Script/b1.BGUDataComp:mUBUC_ACharacterComponent")]
	protected UBUC_ACharacterComponent mUBUC_ACharacterComponent
	{
		get
		{
			CheckDestroyed();
			if (!mUBUC_ACharacterComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDataComp:mUBUC_ACharacterComponent");
				return null;
			}
			return UObjectMarshaler<UBUC_ACharacterComponent>.FromNative(IntPtr.Add(base.Address, mUBUC_ACharacterComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!mUBUC_ACharacterComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUDataComp:mUBUC_ACharacterComponent");
			}
			else
			{
				UObjectMarshaler<UBUC_ACharacterComponent>.ToNative(IntPtr.Add(base.Address, mUBUC_ACharacterComponent_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUDataComp:InitWithCharacter")]
	public unsafe void InitWithCharacter(ABGUCharacter Character)
	{
		CheckDestroyed();
		if (!InitWithCharacter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUDataComp:InitWithCharacter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitWithCharacter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitWithCharacter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(intPtr, InitWithCharacter_Character_Offset), 0, InitWithCharacter_Character_PropertyAddress.Address, Character);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitWithCharacter_FunctionAddress, intPtr, InitWithCharacter_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUDataComp:InitWithAIController")]
	public unsafe void InitWithAIController(ABGUAIController AIController)
	{
		CheckDestroyed();
		if (!InitWithAIController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUDataComp:InitWithAIController");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitWithAIController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitWithAIController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUAIController>.ToNative(IntPtr.Add(intPtr, InitWithAIController_AIController_Offset), 0, InitWithAIController_AIController_PropertyAddress.Address, AIController);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitWithAIController_FunctionAddress, intPtr, InitWithAIController_ParamsSize);
	}

	static UBGUDataComp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUDataComp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUDataComp");
		mUBUC_AIComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "mUBUC_AIComponent");
		mUBUC_AIComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "mUBUC_AIComponent", Classes.FObjectProperty);
		mUBUC_ACharacterComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "mUBUC_ACharacterComponent");
		mUBUC_ACharacterComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "mUBUC_ACharacterComponent", Classes.FObjectProperty);
		InitWithCharacter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitWithCharacter");
		InitWithCharacter_ParamsSize = NativeReflection.GetFunctionParamsSize(InitWithCharacter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitWithCharacter_Character_PropertyAddress, InitWithCharacter_FunctionAddress, "Character");
		InitWithCharacter_Character_Offset = NativeReflectionCached.GetPropertyOffset(InitWithCharacter_FunctionAddress, "Character");
		InitWithCharacter_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(InitWithCharacter_FunctionAddress, "Character", Classes.FObjectProperty);
		InitWithCharacter_IsValid = InitWithCharacter_FunctionAddress != IntPtr.Zero && InitWithCharacter_Character_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUDataComp:InitWithCharacter", InitWithCharacter_IsValid);
		InitWithAIController_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitWithAIController");
		InitWithAIController_ParamsSize = NativeReflection.GetFunctionParamsSize(InitWithAIController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitWithAIController_AIController_PropertyAddress, InitWithAIController_FunctionAddress, "AIController");
		InitWithAIController_AIController_Offset = NativeReflectionCached.GetPropertyOffset(InitWithAIController_FunctionAddress, "AIController");
		InitWithAIController_AIController_IsValid = NativeReflectionCached.ValidatePropertyClass(InitWithAIController_FunctionAddress, "AIController", Classes.FObjectProperty);
		InitWithAIController_IsValid = InitWithAIController_FunctionAddress != IntPtr.Zero && InitWithAIController_AIController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUDataComp:InitWithAIController", InitWithAIController_IsValid);
	}
}
