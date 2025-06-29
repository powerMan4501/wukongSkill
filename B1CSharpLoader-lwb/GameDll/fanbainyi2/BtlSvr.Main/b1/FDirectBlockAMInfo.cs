using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DirectBlockAMInfo")]
public struct FDirectBlockAMInfo
{
	[Tooltip("攻击者在受击者的前方发起攻击")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("前向格挡动画信息")]
	[USharpPath("/Script/b1-Managed.DirectBlockAMInfo:ForwardBlockAMInfo")]
	public FOneDirectBlockAMInfo ForwardBlockAMInfo;

	[Tooltip("攻击者在受击者的后方发起攻击")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("后向格挡动画信息")]
	[USharpPath("/Script/b1-Managed.DirectBlockAMInfo:BackwardBlockAMInfo")]
	public FOneDirectBlockAMInfo BackwardBlockAMInfo;

	[UProperty]
	[Tooltip("攻击者在受击者的左侧发起攻击")]
	[DisplayName("左侧格挡动画信息")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DirectBlockAMInfo:LeftSideBlockAMInfo")]
	public FOneDirectBlockAMInfo LeftSideBlockAMInfo;

	[Tooltip("攻击者在受击者的右侧发起攻击")]
	[DisplayName("右侧格挡动画信息")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DirectBlockAMInfo:RightSideBlockAMInfo")]
	public FOneDirectBlockAMInfo RightSideBlockAMInfo;

	private static int DirectBlockAMInfo_StructSize;

	private static int DirectBlockAMInfo_IsValid;

	private static bool ForwardBlockAMInfo_IsValid;

	private static int ForwardBlockAMInfo_Offset;

	private static bool BackwardBlockAMInfo_IsValid;

	private static int BackwardBlockAMInfo_Offset;

	private static bool LeftSideBlockAMInfo_IsValid;

	private static int LeftSideBlockAMInfo_Offset;

	private static bool RightSideBlockAMInfo_IsValid;

	private static int RightSideBlockAMInfo_Offset;

	public FDirectBlockAMInfo Copy()
	{
		return this;
	}

	public static FDirectBlockAMInfo FromNative(IntPtr nativeBuffer)
	{
		return new FDirectBlockAMInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDirectBlockAMInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDirectBlockAMInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDirectBlockAMInfo(IntPtr.Add(nativeBuffer, arrayIndex * DirectBlockAMInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDirectBlockAMInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DirectBlockAMInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DirectBlockAMInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DirectBlockAMInfo");
			return;
		}
		FOneDirectBlockAMInfo.ToNative(IntPtr.Add(nativeStruct, ForwardBlockAMInfo_Offset), ForwardBlockAMInfo);
		FOneDirectBlockAMInfo.ToNative(IntPtr.Add(nativeStruct, BackwardBlockAMInfo_Offset), BackwardBlockAMInfo);
		FOneDirectBlockAMInfo.ToNative(IntPtr.Add(nativeStruct, LeftSideBlockAMInfo_Offset), LeftSideBlockAMInfo);
		FOneDirectBlockAMInfo.ToNative(IntPtr.Add(nativeStruct, RightSideBlockAMInfo_Offset), RightSideBlockAMInfo);
	}

	public FDirectBlockAMInfo(IntPtr nativeStruct)
	{
		if (DirectBlockAMInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DirectBlockAMInfo");
			ForwardBlockAMInfo = default(FOneDirectBlockAMInfo);
			BackwardBlockAMInfo = default(FOneDirectBlockAMInfo);
			LeftSideBlockAMInfo = default(FOneDirectBlockAMInfo);
			RightSideBlockAMInfo = default(FOneDirectBlockAMInfo);
		}
		else
		{
			ForwardBlockAMInfo = FOneDirectBlockAMInfo.FromNative(IntPtr.Add(nativeStruct, ForwardBlockAMInfo_Offset));
			BackwardBlockAMInfo = FOneDirectBlockAMInfo.FromNative(IntPtr.Add(nativeStruct, BackwardBlockAMInfo_Offset));
			LeftSideBlockAMInfo = FOneDirectBlockAMInfo.FromNative(IntPtr.Add(nativeStruct, LeftSideBlockAMInfo_Offset));
			RightSideBlockAMInfo = FOneDirectBlockAMInfo.FromNative(IntPtr.Add(nativeStruct, RightSideBlockAMInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DirectBlockAMInfo");
		DirectBlockAMInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ForwardBlockAMInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForwardBlockAMInfo");
		ForwardBlockAMInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForwardBlockAMInfo", Classes.FStructProperty);
		BackwardBlockAMInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "BackwardBlockAMInfo");
		BackwardBlockAMInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BackwardBlockAMInfo", Classes.FStructProperty);
		LeftSideBlockAMInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftSideBlockAMInfo");
		LeftSideBlockAMInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftSideBlockAMInfo", Classes.FStructProperty);
		RightSideBlockAMInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightSideBlockAMInfo");
		RightSideBlockAMInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightSideBlockAMInfo", Classes.FStructProperty);
		DirectBlockAMInfo_IsValid = ((intPtr != IntPtr.Zero && ForwardBlockAMInfo_IsValid && BackwardBlockAMInfo_IsValid && LeftSideBlockAMInfo_IsValid && RightSideBlockAMInfo_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DirectBlockAMInfo", (byte)DirectBlockAMInfo_IsValid != 0);
	}

	static FDirectBlockAMInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDirectBlockAMInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDirectBlockAMInfo));
	}
}
