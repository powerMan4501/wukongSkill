using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FNPCLeisureAnimInfo")]
public struct FNPCLeisureAnimInfo
{
	[DisplayName("Leisure动画")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FNPCLeisureAnimInfo:LeisureAnim")]
	public UAnimMontage LeisureAnim;

	[EditAnywhere]
	[UProperty]
	[DisplayName("OnFight技能ID")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FNPCLeisureAnimInfo:OnFightSkillID")]
	public int OnFightSkillID;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("后侧OnFight技能ID")]
	[USharpPath("/Script/b1-Managed.FNPCLeisureAnimInfo:OnFightSkillIDBack")]
	public int OnFightSkillIDBack;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("左侧OnFight技能ID")]
	[USharpPath("/Script/b1-Managed.FNPCLeisureAnimInfo:OnFightSkillIDLeft")]
	public int OnFightSkillIDLeft;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("右侧OnFight技能ID")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FNPCLeisureAnimInfo:OnFightSkillIDRight")]
	public int OnFightSkillIDRight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("备注描述")]
	[Tooltip("供策划用备忘")]
	[USharpPath("/Script/b1-Managed.FNPCLeisureAnimInfo:Comment")]
	public string Comment;

	private static int FNPCLeisureAnimInfo_StructSize;

	private static int FNPCLeisureAnimInfo_IsValid;

	private static bool LeisureAnim_IsValid;

	private static int LeisureAnim_Offset;

	private static bool OnFightSkillID_IsValid;

	private static int OnFightSkillID_Offset;

	private static bool OnFightSkillIDBack_IsValid;

	private static int OnFightSkillIDBack_Offset;

	private static bool OnFightSkillIDLeft_IsValid;

	private static int OnFightSkillIDLeft_Offset;

	private static bool OnFightSkillIDRight_IsValid;

	private static int OnFightSkillIDRight_Offset;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	public FNPCLeisureAnimInfo Copy()
	{
		return this;
	}

	public static FNPCLeisureAnimInfo FromNative(IntPtr nativeBuffer)
	{
		return new FNPCLeisureAnimInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNPCLeisureAnimInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNPCLeisureAnimInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNPCLeisureAnimInfo(IntPtr.Add(nativeBuffer, arrayIndex * FNPCLeisureAnimInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNPCLeisureAnimInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FNPCLeisureAnimInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FNPCLeisureAnimInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FNPCLeisureAnimInfo");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, LeisureAnim_Offset), LeisureAnim);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OnFightSkillID_Offset), OnFightSkillID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OnFightSkillIDBack_Offset), OnFightSkillIDBack);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OnFightSkillIDLeft_Offset), OnFightSkillIDLeft);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OnFightSkillIDRight_Offset), OnFightSkillIDRight);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FNPCLeisureAnimInfo(IntPtr nativeStruct)
	{
		if (FNPCLeisureAnimInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FNPCLeisureAnimInfo");
			LeisureAnim = null;
			OnFightSkillID = 0;
			OnFightSkillIDBack = 0;
			OnFightSkillIDLeft = 0;
			OnFightSkillIDRight = 0;
			Comment = null;
		}
		else
		{
			LeisureAnim = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, LeisureAnim_Offset));
			OnFightSkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OnFightSkillID_Offset));
			OnFightSkillIDBack = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OnFightSkillIDBack_Offset));
			OnFightSkillIDLeft = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OnFightSkillIDLeft_Offset));
			OnFightSkillIDRight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OnFightSkillIDRight_Offset));
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FNPCLeisureAnimInfo");
		FNPCLeisureAnimInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		LeisureAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeisureAnim");
		LeisureAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeisureAnim", Classes.FObjectProperty);
		OnFightSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnFightSkillID");
		OnFightSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnFightSkillID", Classes.FIntProperty);
		OnFightSkillIDBack_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnFightSkillIDBack");
		OnFightSkillIDBack_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnFightSkillIDBack", Classes.FIntProperty);
		OnFightSkillIDLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnFightSkillIDLeft");
		OnFightSkillIDLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnFightSkillIDLeft", Classes.FIntProperty);
		OnFightSkillIDRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnFightSkillIDRight");
		OnFightSkillIDRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnFightSkillIDRight", Classes.FIntProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		FNPCLeisureAnimInfo_IsValid = ((intPtr != IntPtr.Zero && LeisureAnim_IsValid && OnFightSkillID_IsValid && OnFightSkillIDBack_IsValid && OnFightSkillIDLeft_IsValid && OnFightSkillIDRight_IsValid && Comment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FNPCLeisureAnimInfo", (byte)FNPCLeisureAnimInfo_IsValid != 0);
	}

	static FNPCLeisureAnimInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FNPCLeisureAnimInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNPCLeisureAnimInfo));
	}
}
