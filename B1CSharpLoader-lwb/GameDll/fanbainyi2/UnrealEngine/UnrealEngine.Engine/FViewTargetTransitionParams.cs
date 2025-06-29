using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.ViewTargetTransitionParams", "Engine", UnrealModuleType.Engine)]
public struct FViewTargetTransitionParams
{
	private static bool BlendTime_IsValid;

	private static int BlendTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ViewTargetTransitionParams:BlendTime")]
	public float BlendTime;

	private static bool BlendFunction_IsValid;

	private static FFieldAddress BlendFunction_PropertyAddress;

	private static int BlendFunction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ViewTargetTransitionParams:BlendFunction")]
	public EViewTargetBlendFunction BlendFunction;

	private static bool BlendExp_IsValid;

	private static int BlendExp_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ViewTargetTransitionParams:BlendExp")]
	public float BlendExp;

	private static bool LockOutgoing_IsValid;

	private static FFieldAddress LockOutgoing_PropertyAddress;

	private static int LockOutgoing_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ViewTargetTransitionParams:bLockOutgoing")]
	public bool LockOutgoing;

	private static bool FViewTargetTransitionParams_IsValid;

	private static int FViewTargetTransitionParams_StructSize;

	public FViewTargetTransitionParams Copy()
	{
		return this;
	}

	public static FViewTargetTransitionParams FromNative(IntPtr nativeBuffer)
	{
		return new FViewTargetTransitionParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FViewTargetTransitionParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FViewTargetTransitionParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FViewTargetTransitionParams(nativeBuffer + arrayIndex * FViewTargetTransitionParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FViewTargetTransitionParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FViewTargetTransitionParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FViewTargetTransitionParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ViewTargetTransitionParams");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendTime_Offset), BlendTime);
		EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(nativeStruct, BlendFunction_Offset), 0, BlendFunction_PropertyAddress.Address, BlendFunction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendExp_Offset), BlendExp);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, LockOutgoing_Offset), 0, LockOutgoing_PropertyAddress.Address, LockOutgoing);
	}

	public FViewTargetTransitionParams(IntPtr nativeStruct)
	{
		if (!FViewTargetTransitionParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ViewTargetTransitionParams");
			BlendTime = 0f;
			BlendFunction = EViewTargetBlendFunction.VTBlend_Linear;
			BlendExp = 0f;
			LockOutgoing = false;
		}
		else
		{
			BlendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendTime_Offset));
			BlendFunction = EnumMarshaler<EViewTargetBlendFunction>.FromNative(IntPtr.Add(nativeStruct, BlendFunction_Offset), 0, BlendFunction_PropertyAddress.Address);
			BlendExp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendExp_Offset));
			LockOutgoing = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, LockOutgoing_Offset), 0, LockOutgoing_PropertyAddress.Address);
		}
	}

	static FViewTargetTransitionParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FViewTargetTransitionParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FViewTargetTransitionParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ViewTargetTransitionParams");
		FViewTargetTransitionParams_StructSize = NativeReflection.GetStructSize(intPtr);
		BlendTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendTime");
		BlendTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendFunction_PropertyAddress, intPtr, "BlendFunction");
		BlendFunction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendFunction");
		BlendFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendFunction", Classes.FByteProperty);
		BlendExp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendExp");
		BlendExp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendExp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LockOutgoing_PropertyAddress, intPtr, "bLockOutgoing");
		LockOutgoing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLockOutgoing");
		LockOutgoing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLockOutgoing", Classes.FBoolProperty);
		FViewTargetTransitionParams_IsValid = intPtr != IntPtr.Zero && BlendTime_IsValid && BlendFunction_IsValid && BlendExp_IsValid && LockOutgoing_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ViewTargetTransitionParams", FViewTargetTransitionParams_IsValid);
	}
}
