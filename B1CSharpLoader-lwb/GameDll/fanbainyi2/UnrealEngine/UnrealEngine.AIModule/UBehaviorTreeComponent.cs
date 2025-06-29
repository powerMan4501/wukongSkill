using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AIModule.BehaviorTreeComponent", "AIModule", UnrealModuleType.Engine)]
public class UBehaviorTreeComponent : UBrainComponent
{
	private static bool DefaultBehaviorTreeAsset_IsValid;

	private static int DefaultBehaviorTreeAsset_Offset;

	private static bool SetDynamicSubtree_IsValid;

	private static IntPtr SetDynamicSubtree_FunctionAddress;

	private static int SetDynamicSubtree_ParamsSize;

	private static bool SetDynamicSubtree_InjectTag_IsValid;

	private static FFieldAddress SetDynamicSubtree_InjectTag_PropertyAddress;

	private static int SetDynamicSubtree_InjectTag_Offset;

	private static bool SetDynamicSubtree_BehaviorAsset_IsValid;

	private static FFieldAddress SetDynamicSubtree_BehaviorAsset_PropertyAddress;

	private static int SetDynamicSubtree_BehaviorAsset_Offset;

	private static bool GetTagCooldownEndTime_IsValid;

	private static IntPtr GetTagCooldownEndTime_FunctionAddress;

	private static int GetTagCooldownEndTime_ParamsSize;

	private static bool GetTagCooldownEndTime_CooldownTag_IsValid;

	private static FFieldAddress GetTagCooldownEndTime_CooldownTag_PropertyAddress;

	private static int GetTagCooldownEndTime_CooldownTag_Offset;

	private static bool GetTagCooldownEndTime_ReturnValue_IsValid;

	private static FFieldAddress GetTagCooldownEndTime_ReturnValue_PropertyAddress;

	private static int GetTagCooldownEndTime_ReturnValue_Offset;

	private static bool AddCooldownTagDuration_IsValid;

	private static IntPtr AddCooldownTagDuration_FunctionAddress;

	private static int AddCooldownTagDuration_ParamsSize;

	private static bool AddCooldownTagDuration_CooldownTag_IsValid;

	private static FFieldAddress AddCooldownTagDuration_CooldownTag_PropertyAddress;

	private static int AddCooldownTagDuration_CooldownTag_Offset;

	private static bool AddCooldownTagDuration_CooldownDuration_IsValid;

	private static FFieldAddress AddCooldownTagDuration_CooldownDuration_PropertyAddress;

	private static int AddCooldownTagDuration_CooldownDuration_Offset;

	private static bool AddCooldownTagDuration_bAddToExistingDuration_IsValid;

	private static FFieldAddress AddCooldownTagDuration_bAddToExistingDuration_PropertyAddress;

	private static int AddCooldownTagDuration_bAddToExistingDuration_Offset;

	[UProperty(Flags = (PropFlags)12393764861575685uL)]
	[UMetaPath("/Script/AIModule.BehaviorTreeComponent:DefaultBehaviorTreeAsset")]
	protected UBehaviorTree DefaultBehaviorTreeAsset
	{
		get
		{
			CheckDestroyed();
			if (!DefaultBehaviorTreeAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.BehaviorTreeComponent:DefaultBehaviorTreeAsset");
				return null;
			}
			return UObjectMarshaler<UBehaviorTree>.FromNative(IntPtr.Add(base.Address, DefaultBehaviorTreeAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultBehaviorTreeAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.BehaviorTreeComponent:DefaultBehaviorTreeAsset");
			}
			else
			{
				UObjectMarshaler<UBehaviorTree>.ToNative(IntPtr.Add(base.Address, DefaultBehaviorTreeAsset_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AIModule.BehaviorTreeComponent:SetDynamicSubtree")]
	public unsafe void SetDynamicSubtree(FGameplayTag InjectTag, UBehaviorTree BehaviorAsset)
	{
		CheckDestroyed();
		if (!SetDynamicSubtree_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BehaviorTreeComponent:SetDynamicSubtree");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDynamicSubtree_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDynamicSubtree_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDynamicSubtree_InjectTag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, SetDynamicSubtree_InjectTag_Offset), 0, SetDynamicSubtree_InjectTag_PropertyAddress.Address, InjectTag);
		UObjectMarshaler<UBehaviorTree>.ToNative(IntPtr.Add(intPtr, SetDynamicSubtree_BehaviorAsset_Offset), 0, SetDynamicSubtree_BehaviorAsset_PropertyAddress.Address, BehaviorAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDynamicSubtree_FunctionAddress, intPtr, SetDynamicSubtree_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AIModule.BehaviorTreeComponent:GetTagCooldownEndTime")]
	public unsafe float GetTagCooldownEndTime(FGameplayTag CooldownTag)
	{
		CheckDestroyed();
		if (!GetTagCooldownEndTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BehaviorTreeComponent:GetTagCooldownEndTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTagCooldownEndTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTagCooldownEndTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTagCooldownEndTime_CooldownTag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, GetTagCooldownEndTime_CooldownTag_Offset), 0, GetTagCooldownEndTime_CooldownTag_PropertyAddress.Address, CooldownTag);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTagCooldownEndTime_FunctionAddress, intPtr, GetTagCooldownEndTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTagCooldownEndTime_ReturnValue_Offset), 0, GetTagCooldownEndTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.BehaviorTreeComponent:AddCooldownTagDuration")]
	public unsafe void AddCooldownTagDuration(FGameplayTag CooldownTag, float CooldownDuration, bool bAddToExistingDuration)
	{
		CheckDestroyed();
		if (!AddCooldownTagDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BehaviorTreeComponent:AddCooldownTagDuration");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCooldownTagDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCooldownTagDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddCooldownTagDuration_CooldownTag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, AddCooldownTagDuration_CooldownTag_Offset), 0, AddCooldownTagDuration_CooldownTag_PropertyAddress.Address, CooldownTag);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddCooldownTagDuration_CooldownDuration_Offset), 0, AddCooldownTagDuration_CooldownDuration_PropertyAddress.Address, CooldownDuration);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddCooldownTagDuration_bAddToExistingDuration_Offset), 0, AddCooldownTagDuration_bAddToExistingDuration_PropertyAddress.Address, bAddToExistingDuration);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddCooldownTagDuration_FunctionAddress, intPtr, AddCooldownTagDuration_ParamsSize);
	}

	static UBehaviorTreeComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBehaviorTreeComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBehaviorTreeComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.BehaviorTreeComponent");
		DefaultBehaviorTreeAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultBehaviorTreeAsset");
		DefaultBehaviorTreeAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultBehaviorTreeAsset", Classes.FObjectProperty);
		SetDynamicSubtree_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDynamicSubtree");
		SetDynamicSubtree_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamicSubtree_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicSubtree_InjectTag_PropertyAddress, SetDynamicSubtree_FunctionAddress, "InjectTag");
		SetDynamicSubtree_InjectTag_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicSubtree_FunctionAddress, "InjectTag");
		SetDynamicSubtree_InjectTag_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicSubtree_FunctionAddress, "InjectTag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicSubtree_BehaviorAsset_PropertyAddress, SetDynamicSubtree_FunctionAddress, "BehaviorAsset");
		SetDynamicSubtree_BehaviorAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicSubtree_FunctionAddress, "BehaviorAsset");
		SetDynamicSubtree_BehaviorAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicSubtree_FunctionAddress, "BehaviorAsset", Classes.FObjectProperty);
		SetDynamicSubtree_IsValid = SetDynamicSubtree_FunctionAddress != IntPtr.Zero && SetDynamicSubtree_InjectTag_IsValid && SetDynamicSubtree_BehaviorAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BehaviorTreeComponent:SetDynamicSubtree", SetDynamicSubtree_IsValid);
		GetTagCooldownEndTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTagCooldownEndTime");
		GetTagCooldownEndTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTagCooldownEndTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTagCooldownEndTime_CooldownTag_PropertyAddress, GetTagCooldownEndTime_FunctionAddress, "CooldownTag");
		GetTagCooldownEndTime_CooldownTag_Offset = NativeReflectionCached.GetPropertyOffset(GetTagCooldownEndTime_FunctionAddress, "CooldownTag");
		GetTagCooldownEndTime_CooldownTag_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagCooldownEndTime_FunctionAddress, "CooldownTag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTagCooldownEndTime_ReturnValue_PropertyAddress, GetTagCooldownEndTime_FunctionAddress, "ReturnValue");
		GetTagCooldownEndTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTagCooldownEndTime_FunctionAddress, "ReturnValue");
		GetTagCooldownEndTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagCooldownEndTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetTagCooldownEndTime_IsValid = GetTagCooldownEndTime_FunctionAddress != IntPtr.Zero && GetTagCooldownEndTime_CooldownTag_IsValid && GetTagCooldownEndTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BehaviorTreeComponent:GetTagCooldownEndTime", GetTagCooldownEndTime_IsValid);
		AddCooldownTagDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddCooldownTagDuration");
		AddCooldownTagDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCooldownTagDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCooldownTagDuration_CooldownTag_PropertyAddress, AddCooldownTagDuration_FunctionAddress, "CooldownTag");
		AddCooldownTagDuration_CooldownTag_Offset = NativeReflectionCached.GetPropertyOffset(AddCooldownTagDuration_FunctionAddress, "CooldownTag");
		AddCooldownTagDuration_CooldownTag_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCooldownTagDuration_FunctionAddress, "CooldownTag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCooldownTagDuration_CooldownDuration_PropertyAddress, AddCooldownTagDuration_FunctionAddress, "CooldownDuration");
		AddCooldownTagDuration_CooldownDuration_Offset = NativeReflectionCached.GetPropertyOffset(AddCooldownTagDuration_FunctionAddress, "CooldownDuration");
		AddCooldownTagDuration_CooldownDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCooldownTagDuration_FunctionAddress, "CooldownDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCooldownTagDuration_bAddToExistingDuration_PropertyAddress, AddCooldownTagDuration_FunctionAddress, "bAddToExistingDuration");
		AddCooldownTagDuration_bAddToExistingDuration_Offset = NativeReflectionCached.GetPropertyOffset(AddCooldownTagDuration_FunctionAddress, "bAddToExistingDuration");
		AddCooldownTagDuration_bAddToExistingDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCooldownTagDuration_FunctionAddress, "bAddToExistingDuration", Classes.FBoolProperty);
		AddCooldownTagDuration_IsValid = AddCooldownTagDuration_FunctionAddress != IntPtr.Zero && AddCooldownTagDuration_CooldownTag_IsValid && AddCooldownTagDuration_CooldownDuration_IsValid && AddCooldownTagDuration_bAddToExistingDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BehaviorTreeComponent:AddCooldownTagDuration", AddCooldownTagDuration_IsValid);
	}
}
