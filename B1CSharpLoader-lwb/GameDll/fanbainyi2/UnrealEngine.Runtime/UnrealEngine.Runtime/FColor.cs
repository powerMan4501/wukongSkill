using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 59448)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Color", "CoreUObject", UnrealModuleType.Engine)]
public struct FColor : IEquatable<FColor>
{
	private uint packedValue;

	private static bool B_IsValid;

	private static int B_Offset;

	private static bool G_IsValid;

	private static int G_Offset;

	private static bool R_IsValid;

	private static int R_Offset;

	private static bool A_IsValid;

	private static int A_Offset;

	private static int FColor_StructSize;

	public static readonly FColor White;

	public static readonly FColor Black;

	public static readonly FColor Transparent;

	public static readonly FColor Red;

	public static readonly FColor Green;

	public static readonly FColor Blue;

	public static readonly FColor Yellow;

	public static readonly FColor Cyan;

	public static readonly FColor Magenta;

	public static readonly FColor Orange;

	public static readonly FColor Purple;

	public static readonly FColor Turquoise;

	public static readonly FColor Silver;

	public static readonly FColor Emerald;

	public static readonly FColor TransparentBlack;

	public static readonly FColor AliceBlue;

	public static readonly FColor AntiqueWhite;

	public static readonly FColor Aqua;

	public static readonly FColor Aquamarine;

	public static readonly FColor Azure;

	public static readonly FColor Beige;

	public static readonly FColor Bisque;

	public static readonly FColor BlanchedAlmond;

	public static readonly FColor BlueViolet;

	public static readonly FColor Brown;

	public static readonly FColor BurlyWood;

	public static readonly FColor CadetBlue;

	public static readonly FColor Chartreuse;

	public static readonly FColor Chocolate;

	public static readonly FColor Coral;

	public static readonly FColor CornflowerBlue;

	public static readonly FColor Cornsilk;

	public static readonly FColor Crimson;

	public static readonly FColor DarkBlue;

	public static readonly FColor DarkCyan;

	public static readonly FColor DarkGoldenrod;

	public static readonly FColor DarkGray;

	public static readonly FColor DarkGreen;

	public static readonly FColor DarkKhaki;

	public static readonly FColor DarkMagenta;

	public static readonly FColor DarkOliveGreen;

	public static readonly FColor DarkOrange;

	public static readonly FColor DarkOrchid;

	public static readonly FColor DarkRed;

	public static readonly FColor DarkSalmon;

	public static readonly FColor DarkSeaGreen;

	public static readonly FColor DarkSlateBlue;

	public static readonly FColor DarkSlateGray;

	public static readonly FColor DarkTurquoise;

	public static readonly FColor DarkViolet;

	public static readonly FColor DeepPink;

	public static readonly FColor DeepSkyBlue;

	public static readonly FColor DimGray;

	public static readonly FColor DodgerBlue;

	public static readonly FColor Firebrick;

	public static readonly FColor FloralWhite;

	public static readonly FColor ForestGreen;

	public static readonly FColor Fuchsia;

	public static readonly FColor Gainsboro;

	public static readonly FColor GhostWhite;

	public static readonly FColor Gold;

	public static readonly FColor Goldenrod;

	public static readonly FColor Gray;

	public static readonly FColor GreenYellow;

	public static readonly FColor Honeydew;

	public static readonly FColor HotPink;

	public static readonly FColor IndianRed;

	public static readonly FColor Indigo;

	public static readonly FColor Ivory;

	public static readonly FColor Khaki;

	public static readonly FColor Lavender;

	public static readonly FColor LavenderBlush;

	public static readonly FColor LawnGreen;

	public static readonly FColor LemonChiffon;

	public static readonly FColor LightBlue;

	public static readonly FColor LightCoral;

	public static readonly FColor LightCyan;

	public static readonly FColor LightGoldenrodYellow;

	public static readonly FColor LightGray;

	public static readonly FColor LightGreen;

	public static readonly FColor LightPink;

	public static readonly FColor LightSalmon;

	public static readonly FColor LightSeaGreen;

	public static readonly FColor LightSkyBlue;

	public static readonly FColor LightSlateGray;

	public static readonly FColor LightSteelBlue;

	public static readonly FColor LightYellow;

	public static readonly FColor Lime;

	public static readonly FColor LimeGreen;

	public static readonly FColor Linen;

	public static readonly FColor Maroon;

	public static readonly FColor MediumAquamarine;

	public static readonly FColor MediumBlue;

	public static readonly FColor MediumOrchid;

	public static readonly FColor MediumPurple;

	public static readonly FColor MediumSeaGreen;

	public static readonly FColor MediumSlateBlue;

	public static readonly FColor MediumSpringGreen;

	public static readonly FColor MediumTurquoise;

	public static readonly FColor MediumVioletRed;

	public static readonly FColor MidnightBlue;

	public static readonly FColor MintCream;

	public static readonly FColor MistyRose;

	public static readonly FColor Moccasin;

	public static readonly FColor MonoGameOrange;

	public static readonly FColor NavajoWhite;

	public static readonly FColor Navy;

	public static readonly FColor OldLace;

	public static readonly FColor Olive;

	public static readonly FColor OliveDrab;

	public static readonly FColor OrangeRed;

	public static readonly FColor Orchid;

	public static readonly FColor PaleGoldenrod;

	public static readonly FColor PaleGreen;

	public static readonly FColor PaleTurquoise;

	public static readonly FColor PaleVioletRed;

	public static readonly FColor PapayaWhip;

	public static readonly FColor PeachPuff;

	public static readonly FColor Peru;

	public static readonly FColor Pink;

	public static readonly FColor Plum;

	public static readonly FColor PowderBlue;

	public static readonly FColor RosyBrown;

	public static readonly FColor RoyalBlue;

	public static readonly FColor SaddleBrown;

	public static readonly FColor Salmon;

	public static readonly FColor SandyBrown;

	public static readonly FColor SeaGreen;

	public static readonly FColor SeaShell;

	public static readonly FColor Sienna;

	public static readonly FColor SkyBlue;

	public static readonly FColor SlateBlue;

	public static readonly FColor SlateGray;

	public static readonly FColor Snow;

	public static readonly FColor SpringGreen;

	public static readonly FColor SteelBlue;

	public static readonly FColor Tan;

	public static readonly FColor Teal;

	public static readonly FColor Thistle;

	public static readonly FColor Tomato;

	public static readonly FColor Violet;

	public static readonly FColor Wheat;

	public static readonly FColor WhiteSmoke;

	public static readonly FColor YellowGreen;

	public byte B
	{
		get
		{
			if (BitConverter.IsLittleEndian)
			{
				return (byte)packedValue;
			}
			return (byte)(packedValue >> 24);
		}
		set
		{
			if (BitConverter.IsLittleEndian)
			{
				packedValue = (packedValue & 0xFFFFFF00u) | value;
			}
			else
			{
				packedValue = (packedValue & 0xFFFFFF) | (uint)(value << 24);
			}
		}
	}

	public byte G
	{
		get
		{
			if (BitConverter.IsLittleEndian)
			{
				return (byte)(packedValue >> 8);
			}
			return (byte)(packedValue >> 16);
		}
		set
		{
			if (BitConverter.IsLittleEndian)
			{
				packedValue = (packedValue & 0xFFFF00FFu) | (uint)(value << 8);
			}
			else
			{
				packedValue = (packedValue & 0xFF00FFFFu) | (uint)(value << 16);
			}
		}
	}

	public byte R
	{
		get
		{
			if (BitConverter.IsLittleEndian)
			{
				return (byte)(packedValue >> 16);
			}
			return (byte)(packedValue >> 8);
		}
		set
		{
			if (BitConverter.IsLittleEndian)
			{
				packedValue = (packedValue & 0xFF00FFFFu) | (uint)(value << 16);
			}
			else
			{
				packedValue = (packedValue & 0xFFFF00FFu) | (uint)(value << 8);
			}
		}
	}

	public byte A
	{
		get
		{
			if (BitConverter.IsLittleEndian)
			{
				return (byte)(packedValue >> 24);
			}
			return (byte)packedValue;
		}
		set
		{
			if (BitConverter.IsLittleEndian)
			{
				packedValue = (packedValue & 0xFFFFFF) | (uint)(value << 24);
			}
			else
			{
				packedValue = (packedValue & 0xFFFFFF00u) | value;
			}
		}
	}

	public uint PackedValue
	{
		get
		{
			return packedValue;
		}
		set
		{
			packedValue = value;
		}
	}

	public FColor Copy()
	{
		return this;
	}

	static FColor()
	{
		White = new FColor(byte.MaxValue, byte.MaxValue, byte.MaxValue);
		Black = new FColor(0, 0, 0);
		Transparent = new FColor(0, 0, 0, 0);
		Red = new FColor(byte.MaxValue, 0, 0);
		Green = new FColor(0, byte.MaxValue, 0);
		Blue = new FColor(0, 0, byte.MaxValue);
		Yellow = new FColor(byte.MaxValue, byte.MaxValue, 0);
		Cyan = new FColor(0, byte.MaxValue, byte.MaxValue);
		Magenta = new FColor(byte.MaxValue, 0, byte.MaxValue);
		Orange = new FColor(243, 156, 18);
		Purple = new FColor(169, 7, 228);
		Turquoise = new FColor(26, 188, 156);
		Silver = new FColor(189, 195, 199);
		Emerald = new FColor(46, 204, 113);
		TransparentBlack = new FColor(0u);
		AliceBlue = FromABGR(4294965488u);
		AntiqueWhite = FromABGR(4292340730u);
		Aqua = FromABGR(4294967040u);
		Aquamarine = FromABGR(4292149119u);
		Azure = FromABGR(4294967280u);
		Beige = FromABGR(4292670965u);
		Bisque = FromABGR(4291093759u);
		BlanchedAlmond = FromABGR(4291685375u);
		BlueViolet = FromABGR(4293012362u);
		Brown = FromABGR(4280953509u);
		BurlyWood = FromABGR(4287084766u);
		CadetBlue = FromABGR(4288716383u);
		Chartreuse = FromABGR(4278255487u);
		Chocolate = FromABGR(4280183250u);
		Coral = FromABGR(4283465727u);
		CornflowerBlue = FromABGR(4293760356u);
		Cornsilk = FromABGR(4292671743u);
		Crimson = FromABGR(4282127580u);
		DarkBlue = FromABGR(4287299584u);
		DarkCyan = FromABGR(4287335168u);
		DarkGoldenrod = FromABGR(4278945464u);
		DarkGray = FromABGR(4289309097u);
		DarkGreen = FromABGR(4278215680u);
		DarkKhaki = FromABGR(4285249469u);
		DarkMagenta = FromABGR(4287299723u);
		DarkOliveGreen = FromABGR(4281297749u);
		DarkOrange = FromABGR(4278226175u);
		DarkOrchid = FromABGR(4291572377u);
		DarkRed = FromABGR(4278190219u);
		DarkSalmon = FromABGR(4286224105u);
		DarkSeaGreen = FromABGR(4287347855u);
		DarkSlateBlue = FromABGR(4287315272u);
		DarkSlateGray = FromABGR(4283387695u);
		DarkTurquoise = FromABGR(4291939840u);
		DarkViolet = FromABGR(4292018324u);
		DeepPink = FromABGR(4287829247u);
		DeepSkyBlue = FromABGR(4294950656u);
		DimGray = FromABGR(4285098345u);
		DodgerBlue = FromABGR(4294938654u);
		Firebrick = FromABGR(4280427186u);
		FloralWhite = FromABGR(4293982975u);
		ForestGreen = FromABGR(4280453922u);
		Fuchsia = FromABGR(4294902015u);
		Gainsboro = FromABGR(4292664540u);
		GhostWhite = FromABGR(4294965496u);
		Gold = FromABGR(4278245375u);
		Goldenrod = FromABGR(4280329690u);
		Gray = FromABGR(4286611584u);
		GreenYellow = FromABGR(4281335725u);
		Honeydew = FromABGR(4293984240u);
		HotPink = FromABGR(4290013695u);
		IndianRed = FromABGR(4284243149u);
		Indigo = FromABGR(4286709835u);
		Ivory = FromABGR(4293984255u);
		Khaki = FromABGR(4287424240u);
		Lavender = FromABGR(4294633190u);
		LavenderBlush = FromABGR(4294308095u);
		LawnGreen = FromABGR(4278254716u);
		LemonChiffon = FromABGR(4291689215u);
		LightBlue = FromABGR(4293318829u);
		LightCoral = FromABGR(4286611696u);
		LightCyan = FromABGR(4294967264u);
		LightGoldenrodYellow = FromABGR(4292016890u);
		LightGray = FromABGR(4292072403u);
		LightGreen = FromABGR(4287688336u);
		LightPink = FromABGR(4290885375u);
		LightSalmon = FromABGR(4286226687u);
		LightSeaGreen = FromABGR(4289376800u);
		LightSkyBlue = FromABGR(4294626951u);
		LightSlateGray = FromABGR(4288252023u);
		LightSteelBlue = FromABGR(4292789424u);
		LightYellow = FromABGR(4292935679u);
		Lime = FromABGR(4278255360u);
		LimeGreen = FromABGR(4281519410u);
		Linen = FromABGR(4293325050u);
		Maroon = FromABGR(4278190208u);
		MediumAquamarine = FromABGR(4289383782u);
		MediumBlue = FromABGR(4291624960u);
		MediumOrchid = FromABGR(4292040122u);
		MediumPurple = FromABGR(4292571283u);
		MediumSeaGreen = FromABGR(4285641532u);
		MediumSlateBlue = FromABGR(4293814395u);
		MediumSpringGreen = FromABGR(4288346624u);
		MediumTurquoise = FromABGR(4291613000u);
		MediumVioletRed = FromABGR(4286911943u);
		MidnightBlue = FromABGR(4285536537u);
		MintCream = FromABGR(4294639605u);
		MistyRose = FromABGR(4292994303u);
		Moccasin = FromABGR(4290110719u);
		MonoGameOrange = FromABGR(4278205671u);
		NavajoWhite = FromABGR(4289584895u);
		Navy = FromABGR(4286578688u);
		OldLace = FromABGR(4293326333u);
		Olive = FromABGR(4278222976u);
		OliveDrab = FromABGR(4280520299u);
		OrangeRed = FromABGR(4278207999u);
		Orchid = FromABGR(4292243674u);
		PaleGoldenrod = FromABGR(4289390830u);
		PaleGreen = FromABGR(4288215960u);
		PaleTurquoise = FromABGR(4293848751u);
		PaleVioletRed = FromABGR(4287852763u);
		PapayaWhip = FromABGR(4292210687u);
		PeachPuff = FromABGR(4290370303u);
		Peru = FromABGR(4282353101u);
		Pink = FromABGR(4291543295u);
		Plum = FromABGR(4292714717u);
		PowderBlue = FromABGR(4293320880u);
		RosyBrown = FromABGR(4287598524u);
		RoyalBlue = FromABGR(4292962625u);
		SaddleBrown = FromABGR(4279453067u);
		Salmon = FromABGR(4285694202u);
		SandyBrown = FromABGR(4284523764u);
		SeaGreen = FromABGR(4283927342u);
		SeaShell = FromABGR(4293850623u);
		Sienna = FromABGR(4281160352u);
		SkyBlue = FromABGR(4293643911u);
		SlateBlue = FromABGR(4291648106u);
		SlateGray = FromABGR(4287660144u);
		Snow = FromABGR(4294638335u);
		SpringGreen = FromABGR(4286578432u);
		SteelBlue = FromABGR(4290019910u);
		Tan = FromABGR(4287411410u);
		Teal = FromABGR(4286611456u);
		Thistle = FromABGR(4292394968u);
		Tomato = FromABGR(4282868735u);
		Violet = FromABGR(4293821166u);
		Wheat = FromABGR(4289978101u);
		WhiteSmoke = FromABGR(4294309365u);
		YellowGreen = FromABGR(4281519514u);
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FColor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.Color");
		FColor_StructSize = NativeReflection.GetStructSize(unrealStruct);
		B_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "B");
		B_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "B", Classes.FByteProperty);
		G_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "G");
		G_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "G", Classes.FByteProperty);
		R_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "R");
		R_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "R", Classes.FByteProperty);
		A_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "A");
		A_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "A", Classes.FByteProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FColor));
	}

	public FColor(byte r, byte g, byte b, byte a = byte.MaxValue)
	{
		if (BitConverter.IsLittleEndian)
		{
			packedValue = (uint)((a << 24) | (r << 16) | (g << 8) | b);
		}
		else
		{
			packedValue = (uint)((b << 24) | (g << 16) | (r << 8) | a);
		}
	}

	public FColor(uint color)
	{
		packedValue = color;
	}

	internal static FColor FromABGR(uint color)
	{
		FColor fColor = new FColor(color);
		return new FColor(fColor.B, fColor.G, fColor.R, fColor.A);
	}

	public static bool operator ==(FColor a, FColor b)
	{
		return a.packedValue == b.packedValue;
	}

	public static bool operator !=(FColor a, FColor b)
	{
		return a.packedValue != b.packedValue;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FColor))
		{
			return false;
		}
		return Equals((FColor)obj);
	}

	public bool Equals(FColor other)
	{
		return packedValue == other.packedValue;
	}

	public override int GetHashCode()
	{
		return packedValue.GetHashCode();
	}

	public static FColor operator +(FColor a, FColor b)
	{
		return new FColor((byte)Math.Min(a.R + b.R, 255), (byte)Math.Min(a.G + b.G, 255), (byte)Math.Min(a.B + b.B, 255), (byte)Math.Min(a.A + b.A, 255));
	}

	public FLinearColor FromRGBE()
	{
		if (A == 0)
		{
			return FLinearColor.Black;
		}
		float num = (float)FMath.lpexp(1.0 / 255.0, A - 128);
		return new FLinearColor((float)(int)R * num, (float)(int)G * num, (float)(int)B * num);
	}

	public static FColor FromHex(string hexString)
	{
		if (string.IsNullOrEmpty(hexString))
		{
			return default(FColor);
		}
		int num = ((hexString[0] == '#') ? 1 : 0);
		if (hexString.Length == 3 + num)
		{
			int num2 = FParse.HexDigit(hexString[num++]);
			int num3 = FParse.HexDigit(hexString[num++]);
			int num4 = FParse.HexDigit(hexString[num]);
			return new FColor((byte)((num2 << 4) + num2), (byte)((num3 << 4) + num3), (byte)((num4 << 4) + num4));
		}
		if (hexString.Length == 6 + num)
		{
			return new FColor
			{
				R = (byte)((FParse.HexDigit(hexString[num]) << 4) + FParse.HexDigit(hexString[num + 1])),
				G = (byte)((FParse.HexDigit(hexString[num + 2]) << 4) + FParse.HexDigit(hexString[num + 3])),
				B = (byte)((FParse.HexDigit(hexString[num + 4]) << 4) + FParse.HexDigit(hexString[num + 5])),
				A = byte.MaxValue
			};
		}
		if (hexString.Length == 8 + num)
		{
			return new FColor
			{
				R = (byte)((FParse.HexDigit(hexString[num]) << 4) + FParse.HexDigit(hexString[num + 1])),
				G = (byte)((FParse.HexDigit(hexString[num + 2]) << 4) + FParse.HexDigit(hexString[num + 3])),
				B = (byte)((FParse.HexDigit(hexString[num + 4]) << 4) + FParse.HexDigit(hexString[num + 5])),
				A = (byte)((FParse.HexDigit(hexString[num + 6]) << 4) + FParse.HexDigit(hexString[num + 7]))
			};
		}
		return default(FColor);
	}

	public static FColor MakeRandomColor()
	{
		return FLinearColor.MakeRandomColor().ToFColor(srgb: true);
	}

	public static FColor MakeRedToGreenColorFromScalar(float scalar)
	{
		float num = FMath.Clamp((1f - scalar) / 0.5f, 0f, 1f);
		float num2 = FMath.Clamp(scalar / 0.5f, 0f, 1f);
		int num3 = FMath.TruncToInt(255f * num);
		int num4 = FMath.TruncToInt(255f * num2);
		int num5 = 0;
		return new FColor((byte)num3, (byte)num4, (byte)num5);
	}

	public static FColor MakeFromColorTemperature(float temp)
	{
		return FLinearColor.MakeFromColorTemperature(temp).ToFColor(srgb: true);
	}

	public FColor WithAlpha(byte alpha)
	{
		return new FColor(R, G, B, alpha);
	}

	public FLinearColor ReinterpretAsLinear()
	{
		return new FLinearColor((float)(int)R / 255f, (float)(int)G / 255f, (float)(int)B / 255f, (float)(int)A / 255f);
	}

	public string ToHex()
	{
		return R.ToString("X2") + G.ToString("X2") + B.ToString("X2") + A.ToString("X2");
	}

	public override string ToString()
	{
		return "(R=" + R + ",G=" + G + ",B=" + B + ",A=" + A + ")";
	}

	public bool InitFromString(string sourceString)
	{
		packedValue = 0u;
		A = byte.MaxValue;
		byte value = R;
		byte value2 = G;
		byte value3 = B;
		byte value4 = A;
		bool result = FParse.Value(sourceString, "R=", ref value) && FParse.Value(sourceString, "G=", ref value2) && FParse.Value(sourceString, "B=", ref value3);
		R = value;
		G = value2;
		B = value3;
		FParse.Value(sourceString, "A=", ref value4);
		A = value4;
		return result;
	}

	public uint ToPackedARGB()
	{
		return (uint)((A << 24) | (R << 16) | (G << 8) | B);
	}

	public uint ToPackedABGR()
	{
		return (uint)((A << 24) | (B << 16) | (G << 8) | R);
	}

	public uint ToPackedRGBA()
	{
		return (uint)((R << 24) | (G << 16) | (B << 8) | A);
	}

	public uint ToPackedBGRA()
	{
		return (uint)((B << 24) | (G << 16) | (R << 8) | A);
	}

	public static FColor Lerp(FColor a, FColor b, float alpha)
	{
		return FMath.Lerp(a, b, alpha);
	}

	public static FColor LerpStable(FColor a, FColor b, float alpha)
	{
		return FMath.LerpStable(a, b, alpha);
	}
}
