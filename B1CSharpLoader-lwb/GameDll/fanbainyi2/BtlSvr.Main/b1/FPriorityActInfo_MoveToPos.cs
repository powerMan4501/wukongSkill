using System;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.PriorityActInfo_MoveToPos")]
public struct FPriorityActInfo_MoveToPos
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("EQS模板")]
	[UProperty]
	[Category("MoveToPosAction")]
	[USharpPath("/Script/b1-Managed.PriorityActInfo_MoveToPos:MoveActionEnvQueryTemplate")]
	public UEnvQuery MoveActionEnvQueryTemplate;

	[UProperty]
	[EditAnywhere]
	[DisplayName("等待时间")]
	[Category("MoveToPosAction")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PriorityActInfo_MoveToPos:WaitTime")]
	public float WaitTime;

	[BlueprintReadWrite]
	[DisplayName("抵达半径")]
	[UProperty]
	[EditAnywhere]
	[Category("MoveToPosAction")]
	[USharpPath("/Script/b1-Managed.PriorityActInfo_MoveToPos:AcceptableRadius")]
	public float AcceptableRadius;

	[DisplayName("移动速度类型")]
	[Category("MoveToPosAction")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PriorityActInfo_MoveToPos:SpeedType")]
	public EAIMoveSpeedType SpeedType;

	[DisplayName("AI移动类型")]
	[Category("MoveToPosAction")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PriorityActInfo_MoveToPos:MoveAIType")]
	public EBGUMoveAIType MoveAIType;

	private static int PriorityActInfo_MoveToPos_StructSize;

	private static int PriorityActInfo_MoveToPos_IsValid;

	private static bool MoveActionEnvQueryTemplate_IsValid;

	private static int MoveActionEnvQueryTemplate_Offset;

	private static bool WaitTime_IsValid;

	private static int WaitTime_Offset;

	private static bool AcceptableRadius_IsValid;

	private static int AcceptableRadius_Offset;

	private static bool SpeedType_IsValid;

	private static int SpeedType_Offset;

	private static FFieldAddress SpeedType_PropertyAddress;

	private static bool MoveAIType_IsValid;

	private static int MoveAIType_Offset;

	private static FFieldAddress MoveAIType_PropertyAddress;

	public FPriorityActInfo_MoveToPos Copy()
	{
		return this;
	}

	public static FPriorityActInfo_MoveToPos FromNative(IntPtr nativeBuffer)
	{
		return new FPriorityActInfo_MoveToPos(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPriorityActInfo_MoveToPos value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPriorityActInfo_MoveToPos FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPriorityActInfo_MoveToPos(IntPtr.Add(nativeBuffer, arrayIndex * PriorityActInfo_MoveToPos_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPriorityActInfo_MoveToPos value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PriorityActInfo_MoveToPos_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PriorityActInfo_MoveToPos_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PriorityActInfo_MoveToPos");
			return;
		}
		UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(nativeStruct, MoveActionEnvQueryTemplate_Offset), MoveActionEnvQueryTemplate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WaitTime_Offset), WaitTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AcceptableRadius_Offset), AcceptableRadius);
		EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(nativeStruct, SpeedType_Offset), 0, SpeedType_PropertyAddress.Address, SpeedType);
		EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(nativeStruct, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address, MoveAIType);
	}

	public FPriorityActInfo_MoveToPos(IntPtr nativeStruct)
	{
		if (PriorityActInfo_MoveToPos_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PriorityActInfo_MoveToPos");
			MoveActionEnvQueryTemplate = null;
			WaitTime = 0f;
			AcceptableRadius = 0f;
			SpeedType = EAIMoveSpeedType.JOG;
			MoveAIType = EBGUMoveAIType.None;
		}
		else
		{
			MoveActionEnvQueryTemplate = UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(nativeStruct, MoveActionEnvQueryTemplate_Offset));
			WaitTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WaitTime_Offset));
			AcceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AcceptableRadius_Offset));
			SpeedType = EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(nativeStruct, SpeedType_Offset), 0, SpeedType_PropertyAddress.Address);
			MoveAIType = EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(nativeStruct, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PriorityActInfo_MoveToPos");
		PriorityActInfo_MoveToPos_StructSize = NativeReflection.GetStructSize(intPtr);
		MoveActionEnvQueryTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveActionEnvQueryTemplate");
		MoveActionEnvQueryTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveActionEnvQueryTemplate", Classes.FObjectProperty);
		WaitTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitTime");
		WaitTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitTime", Classes.FFloatProperty);
		AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "AcceptableRadius");
		AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SpeedType_PropertyAddress, intPtr, "SpeedType");
		SpeedType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpeedType");
		SpeedType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpeedType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MoveAIType_PropertyAddress, intPtr, "MoveAIType");
		MoveAIType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveAIType");
		MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveAIType", Classes.FEnumProperty);
		PriorityActInfo_MoveToPos_IsValid = ((intPtr != IntPtr.Zero && MoveActionEnvQueryTemplate_IsValid && WaitTime_IsValid && AcceptableRadius_IsValid && SpeedType_IsValid && MoveAIType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PriorityActInfo_MoveToPos", (byte)PriorityActInfo_MoveToPos_IsValid != 0);
	}

	static FPriorityActInfo_MoveToPos()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPriorityActInfo_MoveToPos)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPriorityActInfo_MoveToPos));
	}
}
