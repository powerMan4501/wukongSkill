using System;
using UnrealEngine.Runtime;

namespace b1;

[Serializable]
[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BehaviorNodeGroupSkillList")]
public struct FBehaviorNodeGroupSkillList
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BehaviorNodeGroupSkillList:SkillID")]
	public int SkillID;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("条件BuffID")]
	[USharpPath("/Script/b1-Managed.BehaviorNodeGroupSkillList:CheckBuffId")]
	public int CheckBuffId;

	[UProperty]
	[DisplayName("条件Buff反转")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BehaviorNodeGroupSkillList:CheckReverse")]
	public bool CheckReverse;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("强制执行技能")]
	[USharpPath("/Script/b1-Managed.BehaviorNodeGroupSkillList:ForceCast")]
	public bool ForceCast;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Monatge路径")]
	[USharpPath("/Script/b1-Managed.BehaviorNodeGroupSkillList:MontagePath")]
	public string MontagePath;

	private static int BehaviorNodeGroupSkillList_StructSize;

	private static int BehaviorNodeGroupSkillList_IsValid;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static bool CheckBuffId_IsValid;

	private static int CheckBuffId_Offset;

	private static bool CheckReverse_IsValid;

	private static int CheckReverse_Offset;

	private static FFieldAddress CheckReverse_PropertyAddress;

	private static bool ForceCast_IsValid;

	private static int ForceCast_Offset;

	private static FFieldAddress ForceCast_PropertyAddress;

	private static bool MontagePath_IsValid;

	private static int MontagePath_Offset;

	public FBehaviorNodeGroupSkillList Copy()
	{
		return this;
	}

	public static FBehaviorNodeGroupSkillList FromNative(IntPtr nativeBuffer)
	{
		return new FBehaviorNodeGroupSkillList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBehaviorNodeGroupSkillList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBehaviorNodeGroupSkillList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBehaviorNodeGroupSkillList(IntPtr.Add(nativeBuffer, arrayIndex * BehaviorNodeGroupSkillList_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBehaviorNodeGroupSkillList value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BehaviorNodeGroupSkillList_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BehaviorNodeGroupSkillList_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BehaviorNodeGroupSkillList");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SkillID_Offset), SkillID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CheckBuffId_Offset), CheckBuffId);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckReverse_Offset), 0, CheckReverse_PropertyAddress.Address, CheckReverse);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ForceCast_Offset), 0, ForceCast_PropertyAddress.Address, ForceCast);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, MontagePath_Offset), MontagePath);
	}

	public FBehaviorNodeGroupSkillList(IntPtr nativeStruct)
	{
		if (BehaviorNodeGroupSkillList_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BehaviorNodeGroupSkillList");
			SkillID = 0;
			CheckBuffId = 0;
			CheckReverse = false;
			ForceCast = false;
			MontagePath = null;
		}
		else
		{
			SkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SkillID_Offset));
			CheckBuffId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CheckBuffId_Offset));
			CheckReverse = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckReverse_Offset), 0, CheckReverse_PropertyAddress.Address);
			ForceCast = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ForceCast_Offset), 0, ForceCast_PropertyAddress.Address);
			MontagePath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, MontagePath_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BehaviorNodeGroupSkillList");
		BehaviorNodeGroupSkillList_StructSize = NativeReflection.GetStructSize(intPtr);
		SkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillID", Classes.FIntProperty);
		CheckBuffId_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckBuffId");
		CheckBuffId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckBuffId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CheckReverse_PropertyAddress, intPtr, "CheckReverse");
		CheckReverse_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckReverse");
		CheckReverse_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckReverse", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ForceCast_PropertyAddress, intPtr, "ForceCast");
		ForceCast_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceCast");
		ForceCast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceCast", Classes.FBoolProperty);
		MontagePath_Offset = NativeReflection.GetPropertyOffset(intPtr, "MontagePath");
		MontagePath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MontagePath", Classes.FStrProperty);
		BehaviorNodeGroupSkillList_IsValid = ((intPtr != IntPtr.Zero && SkillID_IsValid && CheckBuffId_IsValid && CheckReverse_IsValid && ForceCast_IsValid && MontagePath_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BehaviorNodeGroupSkillList", (byte)BehaviorNodeGroupSkillList_IsValid != 0);
	}

	static FBehaviorNodeGroupSkillList()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBehaviorNodeGroupSkillList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBehaviorNodeGroupSkillList));
	}
}
