using System;
using UnrealEngine.Runtime;

namespace b1;

[Serializable]
[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BehaviorNodeGroupBuffList")]
public struct FBehaviorNodeGroupBuffList
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BehaviorNodeGroupBuffList:BuffID")]
	public int BuffID;

	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "1")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BehaviorNodeGroupBuffList:BuffLayer")]
	public int BuffLayer;

	[EditAnywhere]
	[UProperty]
	[DisplayName("Buff持续时间(毫秒)")]
	[Tooltip("-1:不移除 ； 0：读Buff表中配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BehaviorNodeGroupBuffList:BuffDuration")]
	public int BuffDuration;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("添加数量")]
	[USharpPath("/Script/b1-Managed.BehaviorNodeGroupBuffList:AddNum")]
	public int AddNum;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("条件BuffID")]
	[USharpPath("/Script/b1-Managed.BehaviorNodeGroupBuffList:CheckBuffId")]
	public int CheckBuffId;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("条件Buff反转")]
	[USharpPath("/Script/b1-Managed.BehaviorNodeGroupBuffList:CheckReverse")]
	public bool CheckReverse;

	private static int BehaviorNodeGroupBuffList_StructSize;

	private static int BehaviorNodeGroupBuffList_IsValid;

	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool BuffDuration_IsValid;

	private static int BuffDuration_Offset;

	private static bool AddNum_IsValid;

	private static int AddNum_Offset;

	private static bool CheckBuffId_IsValid;

	private static int CheckBuffId_Offset;

	private static bool CheckReverse_IsValid;

	private static int CheckReverse_Offset;

	private static FFieldAddress CheckReverse_PropertyAddress;

	public FBehaviorNodeGroupBuffList Copy()
	{
		return this;
	}

	public static FBehaviorNodeGroupBuffList FromNative(IntPtr nativeBuffer)
	{
		return new FBehaviorNodeGroupBuffList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBehaviorNodeGroupBuffList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBehaviorNodeGroupBuffList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBehaviorNodeGroupBuffList(IntPtr.Add(nativeBuffer, arrayIndex * BehaviorNodeGroupBuffList_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBehaviorNodeGroupBuffList value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BehaviorNodeGroupBuffList_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BehaviorNodeGroupBuffList_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BehaviorNodeGroupBuffList");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffID_Offset), BuffID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffLayer_Offset), BuffLayer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffDuration_Offset), BuffDuration);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AddNum_Offset), AddNum);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CheckBuffId_Offset), CheckBuffId);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckReverse_Offset), 0, CheckReverse_PropertyAddress.Address, CheckReverse);
	}

	public FBehaviorNodeGroupBuffList(IntPtr nativeStruct)
	{
		if (BehaviorNodeGroupBuffList_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BehaviorNodeGroupBuffList");
			BuffID = 0;
			BuffLayer = 0;
			BuffDuration = 0;
			AddNum = 0;
			CheckBuffId = 0;
			CheckReverse = false;
		}
		else
		{
			BuffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffID_Offset));
			BuffLayer = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffLayer_Offset));
			BuffDuration = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffDuration_Offset));
			AddNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AddNum_Offset));
			CheckBuffId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CheckBuffId_Offset));
			CheckReverse = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckReverse_Offset), 0, CheckReverse_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BehaviorNodeGroupBuffList");
		BehaviorNodeGroupBuffList_StructSize = NativeReflection.GetStructSize(intPtr);
		BuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		BuffDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffDuration");
		BuffDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffDuration", Classes.FIntProperty);
		AddNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddNum");
		AddNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddNum", Classes.FIntProperty);
		CheckBuffId_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckBuffId");
		CheckBuffId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckBuffId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CheckReverse_PropertyAddress, intPtr, "CheckReverse");
		CheckReverse_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckReverse");
		CheckReverse_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckReverse", Classes.FBoolProperty);
		BehaviorNodeGroupBuffList_IsValid = ((intPtr != IntPtr.Zero && BuffID_IsValid && BuffLayer_IsValid && BuffDuration_IsValid && AddNum_IsValid && CheckBuffId_IsValid && CheckReverse_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BehaviorNodeGroupBuffList", (byte)BehaviorNodeGroupBuffList_IsValid != 0);
	}

	static FBehaviorNodeGroupBuffList()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBehaviorNodeGroupBuffList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBehaviorNodeGroupBuffList));
	}
}
