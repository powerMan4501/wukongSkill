using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Util.PerfTest;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructInnerInner")]
public struct IL2CPPUnitTestStructInnerInner
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructInnerInner:FloatVal")]
	public float FloatVal;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructInnerInner:YesNo")]
	public EGSYesNo YesNo;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructInnerInner:GameTag")]
	public FGameplayTag GameTag;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructInnerInner:AnimSub")]
	public UAnimSequence AnimSub;

	private static int IL2CPPUnitTestStructInnerInner_StructSize;

	private static int IL2CPPUnitTestStructInnerInner_IsValid;

	private static bool FloatVal_IsValid;

	private static int FloatVal_Offset;

	private static bool YesNo_IsValid;

	private static int YesNo_Offset;

	private static FFieldAddress YesNo_PropertyAddress;

	private static bool GameTag_IsValid;

	private static int GameTag_Offset;

	private static bool AnimSub_IsValid;

	private static int AnimSub_Offset;

	public IL2CPPUnitTestStructInnerInner Copy()
	{
		return this;
	}

	public static IL2CPPUnitTestStructInnerInner FromNative(IntPtr nativeBuffer)
	{
		return new IL2CPPUnitTestStructInnerInner(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, IL2CPPUnitTestStructInnerInner value)
	{
		value.ToNative(nativeBuffer);
	}

	public static IL2CPPUnitTestStructInnerInner FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new IL2CPPUnitTestStructInnerInner(IntPtr.Add(nativeBuffer, arrayIndex * IL2CPPUnitTestStructInnerInner_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IL2CPPUnitTestStructInnerInner value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * IL2CPPUnitTestStructInnerInner_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (IL2CPPUnitTestStructInnerInner_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.IL2CPPUnitTestStructInnerInner");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FloatVal_Offset), FloatVal);
		EnumMarshaler<EGSYesNo>.ToNative(IntPtr.Add(nativeStruct, YesNo_Offset), 0, YesNo_PropertyAddress.Address, YesNo);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(nativeStruct, GameTag_Offset), GameTag);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimSub_Offset), AnimSub);
	}

	public IL2CPPUnitTestStructInnerInner(IntPtr nativeStruct)
	{
		if (IL2CPPUnitTestStructInnerInner_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.IL2CPPUnitTestStructInnerInner");
			FloatVal = 0f;
			YesNo = EGSYesNo.No;
			GameTag = default(FGameplayTag);
			AnimSub = null;
		}
		else
		{
			FloatVal = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FloatVal_Offset));
			YesNo = EnumMarshaler<EGSYesNo>.FromNative(IntPtr.Add(nativeStruct, YesNo_Offset), 0, YesNo_PropertyAddress.Address);
			GameTag = BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(nativeStruct, GameTag_Offset));
			AnimSub = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimSub_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.IL2CPPUnitTestStructInnerInner");
		IL2CPPUnitTestStructInnerInner_StructSize = NativeReflection.GetStructSize(intPtr);
		FloatVal_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatVal");
		FloatVal_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatVal", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref YesNo_PropertyAddress, intPtr, "YesNo");
		YesNo_Offset = NativeReflection.GetPropertyOffset(intPtr, "YesNo");
		YesNo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "YesNo", Classes.FEnumProperty);
		GameTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "GameTag");
		GameTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GameTag", Classes.FStructProperty);
		AnimSub_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimSub");
		AnimSub_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimSub", Classes.FObjectProperty);
		IL2CPPUnitTestStructInnerInner_IsValid = ((intPtr != IntPtr.Zero && FloatVal_IsValid && YesNo_IsValid && GameTag_IsValid && AnimSub_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.IL2CPPUnitTestStructInnerInner", (byte)IL2CPPUnitTestStructInnerInner_IsValid != 0);
	}

	static IL2CPPUnitTestStructInnerInner()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(IL2CPPUnitTestStructInnerInner)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IL2CPPUnitTestStructInnerInner));
	}
}
