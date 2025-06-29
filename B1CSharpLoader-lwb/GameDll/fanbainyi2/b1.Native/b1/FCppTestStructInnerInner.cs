using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.CppTestStructInnerInner", "b1", UnrealModuleType.Game)]
public struct FCppTestStructInnerInner
{
	private static bool FloatVal_IsValid;

	private static int FloatVal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.CppTestStructInnerInner:FloatVal")]
	public float FloatVal;

	private static bool GameTag_IsValid;

	private static int GameTag_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.CppTestStructInnerInner:GameTag")]
	public FGameplayTag GameTag;

	private static bool FCppTestStructInnerInner_IsValid;

	private static int FCppTestStructInnerInner_StructSize;

	public FCppTestStructInnerInner Copy()
	{
		return this;
	}

	public static FCppTestStructInnerInner FromNative(IntPtr nativeBuffer)
	{
		return new FCppTestStructInnerInner(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCppTestStructInnerInner value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCppTestStructInnerInner FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCppTestStructInnerInner(nativeBuffer + arrayIndex * FCppTestStructInnerInner_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCppTestStructInnerInner value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCppTestStructInnerInner_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCppTestStructInnerInner_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.CppTestStructInnerInner");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FloatVal_Offset), FloatVal);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(nativeStruct, GameTag_Offset), GameTag);
	}

	public FCppTestStructInnerInner(IntPtr nativeStruct)
	{
		if (!FCppTestStructInnerInner_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.CppTestStructInnerInner");
			FloatVal = 0f;
			GameTag = default(FGameplayTag);
		}
		else
		{
			FloatVal = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FloatVal_Offset));
			GameTag = BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(nativeStruct, GameTag_Offset));
		}
	}

	static FCppTestStructInnerInner()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCppTestStructInnerInner)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCppTestStructInnerInner));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.CppTestStructInnerInner");
		FCppTestStructInnerInner_StructSize = NativeReflection.GetStructSize(intPtr);
		FloatVal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloatVal");
		FloatVal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloatVal", Classes.FFloatProperty);
		GameTag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GameTag");
		GameTag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GameTag", Classes.FStructProperty);
		FCppTestStructInnerInner_IsValid = intPtr != IntPtr.Zero && FloatVal_IsValid && GameTag_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.CppTestStructInnerInner", FCppTestStructInnerInner_IsValid);
	}
}
