using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Arteries;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Arteries.ArteriesGroupRange", "Arteries", UnrealModuleType.GamePlugin)]
public struct FArteriesGroupRange
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Arteries.ArteriesGroupRange:Name")]
	public FName Name;

	private static bool Start_IsValid;

	private static int Start_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Arteries.ArteriesGroupRange:Start")]
	public int Start;

	private static bool End_IsValid;

	private static int End_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Arteries.ArteriesGroupRange:End")]
	public int End;

	private static bool Select_IsValid;

	private static int Select_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Arteries.ArteriesGroupRange:Select")]
	public int Select;

	private static bool Of_IsValid;

	private static int Of_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Arteries.ArteriesGroupRange:Of")]
	public int Of;

	private static bool Offset_IsValid;

	private static int Offset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Arteries.ArteriesGroupRange:Offset")]
	public int Offset;

	private static bool FArteriesGroupRange_IsValid;

	private static int FArteriesGroupRange_StructSize;

	public FArteriesGroupRange Copy()
	{
		return this;
	}

	public static FArteriesGroupRange FromNative(IntPtr nativeBuffer)
	{
		return new FArteriesGroupRange(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FArteriesGroupRange value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FArteriesGroupRange FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FArteriesGroupRange(nativeBuffer + arrayIndex * FArteriesGroupRange_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FArteriesGroupRange value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FArteriesGroupRange_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FArteriesGroupRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Arteries.ArteriesGroupRange");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Start_Offset), Start);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, End_Offset), End);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Select_Offset), Select);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Of_Offset), Of);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Offset_Offset), Offset);
	}

	public FArteriesGroupRange(IntPtr nativeStruct)
	{
		if (!FArteriesGroupRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Arteries.ArteriesGroupRange");
			Name = default(FName);
			Start = 0;
			End = 0;
			Select = 0;
			Of = 0;
			Offset = 0;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Start = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Start_Offset));
			End = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, End_Offset));
			Select = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Select_Offset));
			Of = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Of_Offset));
			Offset = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Offset_Offset));
		}
	}

	static FArteriesGroupRange()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FArteriesGroupRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FArteriesGroupRange));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Arteries.ArteriesGroupRange");
		FArteriesGroupRange_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		Start_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Start");
		Start_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Start", Classes.FIntProperty);
		End_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "End");
		End_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "End", Classes.FIntProperty);
		Select_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Select");
		Select_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Select", Classes.FIntProperty);
		Of_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Of");
		Of_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Of", Classes.FIntProperty);
		Offset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Offset");
		Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Offset", Classes.FIntProperty);
		FArteriesGroupRange_IsValid = intPtr != IntPtr.Zero && Name_IsValid && Start_IsValid && End_IsValid && Select_IsValid && Of_IsValid && Offset_IsValid;
		NativeReflection.LogStructIsValid("/Script/Arteries.ArteriesGroupRange", FArteriesGroupRange_IsValid);
	}
}
