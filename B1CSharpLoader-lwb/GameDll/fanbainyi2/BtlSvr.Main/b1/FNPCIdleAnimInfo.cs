using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FNPCIdleAnimInfo")]
public struct FNPCIdleAnimInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Idle动画")]
	[USharpPath("/Script/b1-Managed.FNPCIdleAnimInfo:IdleAnim")]
	public UAnimSequence IdleAnim;

	[DisplayName("备注描述")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("供策划用备忘")]
	[USharpPath("/Script/b1-Managed.FNPCIdleAnimInfo:Comment")]
	public string Comment;

	private static int FNPCIdleAnimInfo_StructSize;

	private static int FNPCIdleAnimInfo_IsValid;

	private static bool IdleAnim_IsValid;

	private static int IdleAnim_Offset;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	public FNPCIdleAnimInfo Copy()
	{
		return this;
	}

	public static FNPCIdleAnimInfo FromNative(IntPtr nativeBuffer)
	{
		return new FNPCIdleAnimInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNPCIdleAnimInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNPCIdleAnimInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNPCIdleAnimInfo(IntPtr.Add(nativeBuffer, arrayIndex * FNPCIdleAnimInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNPCIdleAnimInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FNPCIdleAnimInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FNPCIdleAnimInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FNPCIdleAnimInfo");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, IdleAnim_Offset), IdleAnim);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FNPCIdleAnimInfo(IntPtr nativeStruct)
	{
		if (FNPCIdleAnimInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FNPCIdleAnimInfo");
			IdleAnim = null;
			Comment = null;
		}
		else
		{
			IdleAnim = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, IdleAnim_Offset));
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FNPCIdleAnimInfo");
		FNPCIdleAnimInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		IdleAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "IdleAnim");
		IdleAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IdleAnim", Classes.FObjectProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		FNPCIdleAnimInfo_IsValid = ((intPtr != IntPtr.Zero && IdleAnim_IsValid && Comment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FNPCIdleAnimInfo", (byte)FNPCIdleAnimInfo_IsValid != 0);
	}

	static FNPCIdleAnimInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FNPCIdleAnimInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNPCIdleAnimInfo));
	}
}
