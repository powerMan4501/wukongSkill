using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.VATAnimClipInfo", "UnrealExtent", UnrealModuleType.Game)]
public struct FVATAnimClipInfo
{
	private static bool State_IsValid;

	private static int State_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimClipInfo:State")]
	public int State;

	private static bool StartFrame_IsValid;

	private static int StartFrame_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimClipInfo:StartFrame")]
	public int StartFrame;

	private static bool EndFrame_IsValid;

	private static int EndFrame_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimClipInfo:EndFrame")]
	public int EndFrame;

	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimClipInfo:Name")]
	public string Name;

	private static bool FVATAnimClipInfo_IsValid;

	private static int FVATAnimClipInfo_StructSize;

	public FVATAnimClipInfo Copy()
	{
		return this;
	}

	public static FVATAnimClipInfo FromNative(IntPtr nativeBuffer)
	{
		return new FVATAnimClipInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVATAnimClipInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVATAnimClipInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVATAnimClipInfo(nativeBuffer + arrayIndex * FVATAnimClipInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVATAnimClipInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVATAnimClipInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVATAnimClipInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.VATAnimClipInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, State_Offset), State);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, StartFrame_Offset), StartFrame);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EndFrame_Offset), EndFrame);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
	}

	public FVATAnimClipInfo(IntPtr nativeStruct)
	{
		if (!FVATAnimClipInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.VATAnimClipInfo");
			State = 0;
			StartFrame = 0;
			EndFrame = 0;
			Name = FStringMarshaler.DefaultString;
		}
		else
		{
			State = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, State_Offset));
			StartFrame = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, StartFrame_Offset));
			EndFrame = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EndFrame_Offset));
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FVATAnimClipInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVATAnimClipInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVATAnimClipInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.VATAnimClipInfo");
		FVATAnimClipInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		State_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "State");
		State_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "State", Classes.FIntProperty);
		StartFrame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartFrame");
		StartFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartFrame", Classes.FIntProperty);
		EndFrame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EndFrame");
		EndFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EndFrame", Classes.FIntProperty);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		FVATAnimClipInfo_IsValid = intPtr != IntPtr.Zero && State_IsValid && StartFrame_IsValid && EndFrame_IsValid && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.VATAnimClipInfo", FVATAnimClipInfo_IsValid);
	}
}
