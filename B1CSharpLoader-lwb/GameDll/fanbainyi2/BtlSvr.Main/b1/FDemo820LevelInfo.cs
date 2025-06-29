using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.Demo820LevelInfo")]
public struct FDemo820LevelInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("排序ID")]
	[USharpPath("/Script/b1-Managed.Demo820LevelInfo:LevelIndex")]
	public int LevelIndex;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("关卡ID")]
	[USharpPath("/Script/b1-Managed.Demo820LevelInfo:LevelID")]
	public int LevelID;

	[EditAnywhere]
	[DisplayName("BossID")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.Demo820LevelInfo:BossID")]
	public int BossID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("关卡名")]
	[USharpPath("/Script/b1-Managed.Demo820LevelInfo:Name")]
	public FText Name;

	[UProperty]
	[UMeta(MDProp.MultiLine, true)]
	[Category("Localization")]
	[BlueprintReadWrite]
	[DisplayName("关卡描述")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.Demo820LevelInfo:Desc")]
	public FText Desc;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("游玩时间描述")]
	[USharpPath("/Script/b1-Managed.Demo820LevelInfo:VictoryDesc")]
	public FText VictoryDesc;

	[EditAnywhere]
	[DisplayName("关卡ImageID")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.Demo820LevelInfo:LevelImageIndex")]
	public int LevelImageIndex;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("角色初始化配置")]
	[USharpPath("/Script/b1-Managed.Demo820LevelInfo:RoleDataConfId")]
	public int RoleDataConfId;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("玩家血量期望值")]
	[USharpPath("/Script/b1-Managed.Demo820LevelInfo:PlayerDesiredHp")]
	public int PlayerDesiredHp;

	[DisplayName("默认出生坐标")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.Demo820LevelInfo:DefaultPos")]
	public FVector DefaultPos;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("默认朝向")]
	[USharpPath("/Script/b1-Managed.Demo820LevelInfo:DefaultRot")]
	public FRotator DefaultRot;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("进入关卡后激活复活点id")]
	[USharpPath("/Script/b1-Managed.Demo820LevelInfo:RebrithPoint")]
	public int RebrithPoint;

	private static int Demo820LevelInfo_StructSize;

	private static int Demo820LevelInfo_IsValid;

	private static bool LevelIndex_IsValid;

	private static int LevelIndex_Offset;

	private static bool LevelID_IsValid;

	private static int LevelID_Offset;

	private static bool BossID_IsValid;

	private static int BossID_Offset;

	private static bool Name_IsValid;

	private static int Name_Offset;

	private static bool Desc_IsValid;

	private static int Desc_Offset;

	private static bool VictoryDesc_IsValid;

	private static int VictoryDesc_Offset;

	private static bool LevelImageIndex_IsValid;

	private static int LevelImageIndex_Offset;

	private static bool RoleDataConfId_IsValid;

	private static int RoleDataConfId_Offset;

	private static bool PlayerDesiredHp_IsValid;

	private static int PlayerDesiredHp_Offset;

	private static bool DefaultPos_IsValid;

	private static int DefaultPos_Offset;

	private static bool DefaultRot_IsValid;

	private static int DefaultRot_Offset;

	private static bool RebrithPoint_IsValid;

	private static int RebrithPoint_Offset;

	public FDemo820LevelInfo Copy()
	{
		return this;
	}

	public static FDemo820LevelInfo FromNative(IntPtr nativeBuffer)
	{
		return new FDemo820LevelInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDemo820LevelInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDemo820LevelInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDemo820LevelInfo(IntPtr.Add(nativeBuffer, arrayIndex * Demo820LevelInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDemo820LevelInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * Demo820LevelInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (Demo820LevelInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.Demo820LevelInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LevelIndex_Offset), LevelIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LevelID_Offset), LevelID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BossID_Offset), BossID);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, Desc_Offset), Desc);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, VictoryDesc_Offset), VictoryDesc);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LevelImageIndex_Offset), LevelImageIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RoleDataConfId_Offset), RoleDataConfId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PlayerDesiredHp_Offset), PlayerDesiredHp);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, DefaultPos_Offset), DefaultPos);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, DefaultRot_Offset), DefaultRot);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RebrithPoint_Offset), RebrithPoint);
	}

	public FDemo820LevelInfo(IntPtr nativeStruct)
	{
		if (Demo820LevelInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.Demo820LevelInfo");
			LevelIndex = 0;
			LevelID = 0;
			BossID = 0;
			Name = null;
			Desc = null;
			VictoryDesc = null;
			LevelImageIndex = 0;
			RoleDataConfId = 0;
			PlayerDesiredHp = 0;
			DefaultPos = default(FVector);
			DefaultRot = default(FRotator);
			RebrithPoint = 0;
		}
		else
		{
			LevelIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LevelIndex_Offset));
			LevelID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LevelID_Offset));
			BossID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BossID_Offset));
			Name = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Desc = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, Desc_Offset));
			VictoryDesc = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, VictoryDesc_Offset));
			LevelImageIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LevelImageIndex_Offset));
			RoleDataConfId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RoleDataConfId_Offset));
			PlayerDesiredHp = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PlayerDesiredHp_Offset));
			DefaultPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, DefaultPos_Offset));
			DefaultRot = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, DefaultRot_Offset));
			RebrithPoint = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RebrithPoint_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.Demo820LevelInfo");
		Demo820LevelInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		LevelIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelIndex");
		LevelIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelIndex", Classes.FIntProperty);
		LevelID_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelID");
		LevelID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelID", Classes.FIntProperty);
		BossID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BossID");
		BossID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BossID", Classes.FIntProperty);
		Name_Offset = NativeReflection.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Name", Classes.FTextProperty);
		Desc_Offset = NativeReflection.GetPropertyOffset(intPtr, "Desc");
		Desc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Desc", Classes.FTextProperty);
		VictoryDesc_Offset = NativeReflection.GetPropertyOffset(intPtr, "VictoryDesc");
		VictoryDesc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VictoryDesc", Classes.FTextProperty);
		LevelImageIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelImageIndex");
		LevelImageIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelImageIndex", Classes.FIntProperty);
		RoleDataConfId_Offset = NativeReflection.GetPropertyOffset(intPtr, "RoleDataConfId");
		RoleDataConfId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RoleDataConfId", Classes.FIntProperty);
		PlayerDesiredHp_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerDesiredHp");
		PlayerDesiredHp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerDesiredHp", Classes.FIntProperty);
		DefaultPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultPos");
		DefaultPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultPos", Classes.FStructProperty);
		DefaultRot_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultRot");
		DefaultRot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultRot", Classes.FStructProperty);
		RebrithPoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "RebrithPoint");
		RebrithPoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RebrithPoint", Classes.FIntProperty);
		Demo820LevelInfo_IsValid = ((intPtr != IntPtr.Zero && LevelIndex_IsValid && LevelID_IsValid && BossID_IsValid && Name_IsValid && Desc_IsValid && VictoryDesc_IsValid && LevelImageIndex_IsValid && RoleDataConfId_IsValid && PlayerDesiredHp_IsValid && DefaultPos_IsValid && DefaultRot_IsValid && RebrithPoint_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.Demo820LevelInfo", (byte)Demo820LevelInfo_IsValid != 0);
	}

	static FDemo820LevelInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDemo820LevelInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDemo820LevelInfo));
	}
}
