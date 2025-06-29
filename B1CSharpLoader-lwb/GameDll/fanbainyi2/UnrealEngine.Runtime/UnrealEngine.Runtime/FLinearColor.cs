using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 4254776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.LinearColor", "CoreUObject", UnrealModuleType.Engine)]
public struct FLinearColor : IEquatable<FLinearColor>
{
	private class Tables
	{
		public static readonly float[] Pow22OneOver255Table = new float[256]
		{
			0f,
			5.077052E-06f,
			2.3328004E-05f,
			5.6921766E-05f,
			0.00010718736f,
			0.00017512398f,
			0.00026154376f,
			0.00036713626f,
			0.0004925038f,
			0.00063818286f,
			0.0008046585f,
			0.0009923743f,
			0.0012017395f,
			0.0014331345f,
			0.0016869153f,
			0.001963416f,
			0.0022629532f,
			0.0025858255f,
			0.0029323183f,
			0.0033027031f,
			0.0036972396f,
			0.004116177f,
			0.004559755f,
			0.0050282036f,
			0.005521745f,
			0.0060405936f,
			0.0065849572f,
			0.007155037f,
			0.0077510276f,
			0.008373118f,
			0.009021492f,
			0.009696329f,
			0.010397802f,
			0.011126082f,
			0.011881335f,
			0.01266372f,
			0.013473397f,
			0.014310519f,
			0.015175238f,
			0.0160677f,
			0.016988052f,
			0.017936433f,
			0.018912984f,
			0.019917838f,
			0.020951131f,
			0.022012996f,
			0.023103556f,
			0.024222942f,
			0.025371278f,
			0.026548684f,
			0.02775528f,
			0.028991187f,
			0.03025652f,
			0.03155139f,
			0.032875918f,
			0.034230206f,
			0.03561437f,
			0.037028514f,
			0.038472746f,
			0.03994717f,
			0.04145189f,
			0.04298701f,
			0.044552628f,
			0.046148844f,
			0.047775753f,
			0.04943346f,
			0.05112205f,
			0.052841626f,
			0.054592278f,
			0.0563741f,
			0.05818718f,
			0.060031608f,
			0.061907474f,
			0.06381487f,
			0.06575388f,
			0.06772459f,
			0.069727086f,
			0.07176145f,
			0.073827766f,
			0.07592612f,
			0.07805659f,
			0.08021926f,
			0.0824142f,
			0.08464151f,
			0.086901255f,
			0.08919351f,
			0.09151835f,
			0.09387587f,
			0.09626612f,
			0.0986892f,
			0.10114516f,
			0.1036341f,
			0.106156066f,
			0.10871115f,
			0.11129942f,
			0.113920934f,
			0.11657578f,
			0.119264014f,
			0.12198571f,
			0.12474094f,
			0.12752979f,
			0.13035227f,
			0.13320851f,
			0.13609855f,
			0.13902245f,
			0.14198029f,
			0.14497213f,
			0.14799802f,
			0.15105805f,
			0.15415226f,
			0.15728073f,
			0.16044351f,
			0.16364068f,
			0.16687228f,
			0.17013837f,
			0.17343904f,
			0.17677432f,
			0.1801443f,
			0.183549f,
			0.1869885f,
			0.19046287f,
			0.19397217f,
			0.19751643f,
			0.20109573f,
			0.20471013f,
			0.20835966f,
			0.2120444f,
			0.2157644f,
			0.21951972f,
			181f / (258f * (float)Math.PI),
			0.22713652f,
			0.23099813f,
			0.23489526f,
			0.23882799f,
			0.24279635f,
			0.24680042f,
			0.25084025f,
			0.25491586f,
			0.25902733f,
			0.2631747f,
			0.26735806f,
			0.27157742f,
			0.27583283f,
			0.28012437f,
			0.28445205f,
			0.28881598f,
			0.29321614f,
			0.29765263f,
			0.30212548f,
			0.30663475f,
			0.3111805f,
			0.31576276f,
			0.32038155f,
			0.32503697f,
			0.32972902f,
			0.3344578f,
			0.33922333f,
			0.34402567f,
			0.34886482f,
			0.3537409f,
			0.3586539f,
			0.3636039f,
			0.36859092f,
			0.37361503f,
			0.37867627f,
			0.38377464f,
			0.38891026f,
			0.3940831f,
			0.3992933f,
			0.40454084f,
			0.40982574f,
			0.41514808f,
			0.42050794f,
			0.4259053f,
			0.43134022f,
			0.43681276f,
			0.44232294f,
			0.44787085f,
			0.45345646f,
			0.4590799f,
			0.46474114f,
			0.47044024f,
			0.47617728f,
			0.48195225f,
			0.4877652f,
			0.4936162f,
			0.49950528f,
			0.5054325f,
			0.51139784f,
			0.5174014f,
			0.52344316f,
			0.5295232f,
			0.5356416f,
			0.54179835f,
			0.5479935f,
			0.5542271f,
			0.56049913f,
			0.5668097f,
			0.57315886f,
			0.57954663f,
			0.58597296f,
			0.59243804f,
			0.5989418f,
			0.6054843f,
			0.6120656f,
			0.6186857f,
			0.6253447f,
			0.63204265f,
			0.63877946f,
			0.64555526f,
			0.6523701f,
			(float)Math.E * 81f / 334f,
			0.66611695f,
			0.6730491f,
			0.68002033f,
			0.6870308f,
			0.69408053f,
			0.7011695f,
			0.7082978f,
			0.7154654f,
			0.72267246f,
			0.7299189f,
			0.7372048f,
			0.7445302f,
			0.75189507f,
			0.7592996f,
			0.7667436f,
			0.7742273f,
			0.7817507f,
			0.78931373f,
			0.79691654f,
			0.8045591f,
			0.8122415f,
			0.8199637f,
			0.82772577f,
			0.8355278f,
			0.8433697f,
			0.85125166f,
			0.8591736f,
			0.8671355f,
			0.87513757f,
			0.8831797f,
			0.89126205f,
			0.8993845f,
			0.9075472f,
			0.91575015f,
			0.92399335f,
			0.93227684f,
			0.9406007f,
			0.94896495f,
			0.95736957f,
			0.96581465f,
			0.9743002f,
			0.98282623f,
			0.99139285f,
			1f
		};

		public static readonly float[] sRGBToLinearTable = new float[256]
		{
			0f, 0.000303527f, 0.000607054f, 0.000910581f, 0.001214108f, 0.001517635f, 0.001821162f, 0.0021246888f, 0.002428216f, 0.0027317428f,
			0.00303527f, 0.0033465356f, 0.0036765072f, 0.004024717f, 0.004391442f, 0.0047769533f, 0.0051815165f, 0.005605391f, 0.006048833f, 0.0065120906f,
			0.00699541f, 0.0074990317f, 0.008023193f, 0.008568126f, 0.009134059f, 0.009721217f, 0.010329823f, 0.010960094f, 0.011612245f, 0.012286488f,
			0.0129830325f, 0.013702082f, 0.014443844f, 0.015208514f, 0.015996292f, 0.016807375f, 0.017641954f, 0.01850022f, 0.019382361f, 0.020288562f,
			0.02121901f, 0.022173885f, 0.023153367f, 0.024157632f, 0.02518686f, 0.026241222f, 0.027320892f, 0.02842604f, 0.029556833f, 0.030713443f,
			0.031896032f, 0.033104766f, 0.034339808f, 0.035601314f, 0.03688945f, 0.038204372f, 0.039546236f, 0.040915195f, 0.04231141f, 0.043735027f,
			0.045186203f, 0.046665087f, 0.048171822f, 0.049706567f, 0.051269457f, 0.052860647f, 0.054480277f, 0.05612849f, 0.05780543f, 0.059511237f,
			0.061246052f, 0.063010015f, 0.064803265f, 0.06662594f, 0.06847817f, 0.070360094f, 0.072271846f, 0.074213564f, 0.07618538f, 0.07818742f,
			0.08021982f, 0.08228271f, 0.08437621f, 0.08650046f, 0.08865558f, 0.09084171f, 0.09305896f, 0.09530747f, 0.09758735f, 0.099898726f,
			0.10224173f, 0.104616486f, 0.107023105f, 0.10946171f, 0.11193243f, 0.114435375f, 0.116970666f, 0.11953843f, 0.12213877f, 0.12477182f,
			0.12743768f, 0.13013647f, 0.13286832f, 0.13563333f, 0.13843161f, 0.14126329f, 0.14412847f, 0.14702727f, 0.14995979f, 0.15292615f,
			0.15592647f, 0.15896083f, 0.16202937f, 0.1651322f, 0.1682694f, 0.1714411f, 0.1746474f, 0.17788841f, 0.18116425f, 0.18447499f,
			0.18782078f, 0.19120169f, 0.19461782f, 0.19806932f, 0.20155625f, 0.20507874f, 0.20863687f, 0.21223076f, 0.2158605f, 0.2195262f,
			0.22322796f, 0.22696587f, 0.23074004f, 0.23455058f, 0.23839757f, 0.24228112f, 0.24620132f, 0.25015828f, 0.2541521f, 0.25818285f,
			0.26225066f, 0.2663556f, 0.2704978f, 0.2746773f, 0.27889428f, 0.28314874f, 0.28744084f, 0.29177064f, 0.29613826f, 0.30054379f,
			0.3049873f, 0.30946892f, 0.31398872f, 0.31854677f, 0.3231432f, 0.3277781f, 0.33245152f, 0.33716363f, 0.34191442f, 0.34670407f,
			0.3515326f, 0.35640013f, 0.3613068f, 0.3662526f, 0.37123767f, 0.37626213f, 0.38132602f, 0.38642943f, 0.39157248f, 0.39675522f,
			0.40197778f, 0.4072402f, 0.4125426f, 0.41788507f, 0.42326766f, 0.4286905f, 0.43415365f, 0.43965718f, 0.4452012f, 0.4507858f,
			0.45641103f, 0.462077f, 0.4677838f, 0.47353148f, 0.47932017f, 0.48514995f, 0.49102086f, 0.49693298f, 0.5028865f, 0.50888133f,
			0.5149177f, 0.52099556f, 0.5271151f, 0.5332764f, 0.5394795f, 0.54572445f, 0.5520114f, 0.5583404f, 0.5647115f, 0.57112485f,
			0.57758045f, 0.58407843f, 0.59061885f, 0.59720176f, 0.60382736f, 0.61049557f, 0.6172066f, 0.6239604f, 0.63075715f, 0.63759685f,
			0.6444797f, 0.65140563f, 0.6583748f, 0.6653873f, 0.67244315f, 0.6795425f, 0.6866853f, 0.69387174f, 0.7011019f, 0.70837575f,
			0.7156935f, 0.7230551f, 0.73046076f, 0.7379104f, 0.7454042f, 0.7529422f, 0.7605245f, 0.76815116f, 0.7758222f, 0.7835378f,
			0.7912979f, 0.7991027f, 0.80695224f, 0.8148466f, 0.82278574f, 0.8307699f, 0.838799f, 0.8468732f, 0.8549926f, 0.8631572f,
			0.8713671f, 0.8796224f, 0.8879231f, 0.8962693f, 0.9046612f, 0.91309863f, 0.92158186f, 0.9301109f, 0.9386857f, 0.9473065f,
			0.9559733f, 0.9646862f, 0.9734453f, 0.9822506f, 0.9911021f, 1f
		};
	}

	private static bool R_IsValid;

	private static int R_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.LinearColor:R")]
	public float R;

	private static bool G_IsValid;

	private static int G_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.LinearColor:G")]
	public float G;

	private static bool B_IsValid;

	private static int B_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.LinearColor:B")]
	public float B;

	private static bool A_IsValid;

	private static int A_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.LinearColor:A")]
	public float A;

	private static int FLinearColor_StructSize;

	private const float OneOver255 = 0.003921569f;

	public static readonly FLinearColor White;

	public static readonly FLinearColor Gray;

	public static readonly FLinearColor Black;

	public static readonly FLinearColor Transparent;

	public static readonly FLinearColor Red;

	public static readonly FLinearColor Green;

	public static readonly FLinearColor Blue;

	public static readonly FLinearColor Yellow;

	public static readonly FLinearColor TransparentBlack;

	public static readonly FLinearColor AliceBlue;

	public static readonly FLinearColor AntiqueWhite;

	public static readonly FLinearColor Aqua;

	public static readonly FLinearColor Aquamarine;

	public static readonly FLinearColor Azure;

	public static readonly FLinearColor Beige;

	public static readonly FLinearColor Bisque;

	public static readonly FLinearColor BlanchedAlmond;

	public static readonly FLinearColor BlueViolet;

	public static readonly FLinearColor Brown;

	public static readonly FLinearColor BurlyWood;

	public static readonly FLinearColor CadetBlue;

	public static readonly FLinearColor Chartreuse;

	public static readonly FLinearColor Chocolate;

	public static readonly FLinearColor Coral;

	public static readonly FLinearColor CornflowerBlue;

	public static readonly FLinearColor Cornsilk;

	public static readonly FLinearColor Crimson;

	public static readonly FLinearColor Cyan;

	public static readonly FLinearColor DarkBlue;

	public static readonly FLinearColor DarkCyan;

	public static readonly FLinearColor DarkGoldenrod;

	public static readonly FLinearColor DarkGray;

	public static readonly FLinearColor DarkGreen;

	public static readonly FLinearColor DarkKhaki;

	public static readonly FLinearColor DarkMagenta;

	public static readonly FLinearColor DarkOliveGreen;

	public static readonly FLinearColor DarkOrange;

	public static readonly FLinearColor DarkOrchid;

	public static readonly FLinearColor DarkRed;

	public static readonly FLinearColor DarkSalmon;

	public static readonly FLinearColor DarkSeaGreen;

	public static readonly FLinearColor DarkSlateBlue;

	public static readonly FLinearColor DarkSlateGray;

	public static readonly FLinearColor DarkTurquoise;

	public static readonly FLinearColor DarkViolet;

	public static readonly FLinearColor DeepPink;

	public static readonly FLinearColor DeepSkyBlue;

	public static readonly FLinearColor DimGray;

	public static readonly FLinearColor DodgerBlue;

	public static readonly FLinearColor Firebrick;

	public static readonly FLinearColor FloralWhite;

	public static readonly FLinearColor ForestGreen;

	public static readonly FLinearColor Fuchsia;

	public static readonly FLinearColor Gainsboro;

	public static readonly FLinearColor GhostWhite;

	public static readonly FLinearColor Gold;

	public static readonly FLinearColor Goldenrod;

	public static readonly FLinearColor GreenYellow;

	public static readonly FLinearColor Honeydew;

	public static readonly FLinearColor HotPink;

	public static readonly FLinearColor IndianRed;

	public static readonly FLinearColor Indigo;

	public static readonly FLinearColor Ivory;

	public static readonly FLinearColor Khaki;

	public static readonly FLinearColor Lavender;

	public static readonly FLinearColor LavenderBlush;

	public static readonly FLinearColor LawnGreen;

	public static readonly FLinearColor LemonChiffon;

	public static readonly FLinearColor LightBlue;

	public static readonly FLinearColor LightCoral;

	public static readonly FLinearColor LightCyan;

	public static readonly FLinearColor LightGoldenrodYellow;

	public static readonly FLinearColor LightGray;

	public static readonly FLinearColor LightGreen;

	public static readonly FLinearColor LightPink;

	public static readonly FLinearColor LightSalmon;

	public static readonly FLinearColor LightSeaGreen;

	public static readonly FLinearColor LightSkyBlue;

	public static readonly FLinearColor LightSlateGray;

	public static readonly FLinearColor LightSteelBlue;

	public static readonly FLinearColor LightYellow;

	public static readonly FLinearColor Lime;

	public static readonly FLinearColor LimeGreen;

	public static readonly FLinearColor Linen;

	public static readonly FLinearColor Magenta;

	public static readonly FLinearColor Maroon;

	public static readonly FLinearColor MediumAquamarine;

	public static readonly FLinearColor MediumBlue;

	public static readonly FLinearColor MediumOrchid;

	public static readonly FLinearColor MediumPurple;

	public static readonly FLinearColor MediumSeaGreen;

	public static readonly FLinearColor MediumSlateBlue;

	public static readonly FLinearColor MediumSpringGreen;

	public static readonly FLinearColor MediumTurquoise;

	public static readonly FLinearColor MediumVioletRed;

	public static readonly FLinearColor MidnightBlue;

	public static readonly FLinearColor MintCream;

	public static readonly FLinearColor MistyRose;

	public static readonly FLinearColor Moccasin;

	public static readonly FLinearColor MonoGameOrange;

	public static readonly FLinearColor NavajoWhite;

	public static readonly FLinearColor Navy;

	public static readonly FLinearColor OldLace;

	public static readonly FLinearColor Olive;

	public static readonly FLinearColor OliveDrab;

	public static readonly FLinearColor Orange;

	public static readonly FLinearColor OrangeRed;

	public static readonly FLinearColor Orchid;

	public static readonly FLinearColor PaleGoldenrod;

	public static readonly FLinearColor PaleGreen;

	public static readonly FLinearColor PaleTurquoise;

	public static readonly FLinearColor PaleVioletRed;

	public static readonly FLinearColor PapayaWhip;

	public static readonly FLinearColor PeachPuff;

	public static readonly FLinearColor Peru;

	public static readonly FLinearColor Pink;

	public static readonly FLinearColor Plum;

	public static readonly FLinearColor PowderBlue;

	public static readonly FLinearColor Purple;

	public static readonly FLinearColor RosyBrown;

	public static readonly FLinearColor RoyalBlue;

	public static readonly FLinearColor SaddleBrown;

	public static readonly FLinearColor Salmon;

	public static readonly FLinearColor SandyBrown;

	public static readonly FLinearColor SeaGreen;

	public static readonly FLinearColor SeaShell;

	public static readonly FLinearColor Sienna;

	public static readonly FLinearColor Silver;

	public static readonly FLinearColor SkyBlue;

	public static readonly FLinearColor SlateBlue;

	public static readonly FLinearColor SlateGray;

	public static readonly FLinearColor Snow;

	public static readonly FLinearColor SpringGreen;

	public static readonly FLinearColor SteelBlue;

	public static readonly FLinearColor Tan;

	public static readonly FLinearColor Teal;

	public static readonly FLinearColor Thistle;

	public static readonly FLinearColor Tomato;

	public static readonly FLinearColor Turquoise;

	public static readonly FLinearColor Violet;

	public static readonly FLinearColor Wheat;

	public static readonly FLinearColor WhiteSmoke;

	public static readonly FLinearColor YellowGreen;

	public float this[int index]
	{
		get
		{
			return index switch
			{
				0 => R, 
				1 => G, 
				2 => B, 
				3 => A, 
				_ => throw new IndexOutOfRangeException("Invalid FLinearColor index (" + index + ")"), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				R = value;
				break;
			case 1:
				G = value;
				break;
			case 2:
				B = value;
				break;
			case 3:
				A = value;
				break;
			default:
				throw new IndexOutOfRangeException("Invalid FLinearColor index (" + index + ")");
			}
		}
	}

	public FLinearColor Copy()
	{
		return this;
	}

	static FLinearColor()
	{
		White = new FLinearColor(1f, 1f, 1f);
		Gray = new FLinearColor(0.5f, 0.5f, 0.5f);
		Black = new FLinearColor(0f, 0f, 0f);
		Transparent = new FLinearColor(0f, 0f, 0f, 0f);
		Red = new FLinearColor(1f, 0f, 0f);
		Green = new FLinearColor(0f, 1f, 0f);
		Blue = new FLinearColor(0f, 0f, 1f);
		Yellow = new FLinearColor(1f, 1f, 0f);
		TransparentBlack = new FLinearColor(FColor.TransparentBlack);
		AliceBlue = new FLinearColor(FColor.AliceBlue);
		AntiqueWhite = new FLinearColor(FColor.AntiqueWhite);
		Aqua = new FLinearColor(FColor.Aqua);
		Aquamarine = new FLinearColor(FColor.Aquamarine);
		Azure = new FLinearColor(FColor.Azure);
		Beige = new FLinearColor(FColor.Beige);
		Bisque = new FLinearColor(FColor.Bisque);
		BlanchedAlmond = new FLinearColor(FColor.BlanchedAlmond);
		BlueViolet = new FLinearColor(FColor.BlueViolet);
		Brown = new FLinearColor(FColor.Brown);
		BurlyWood = new FLinearColor(FColor.BurlyWood);
		CadetBlue = new FLinearColor(FColor.CadetBlue);
		Chartreuse = new FLinearColor(FColor.Chartreuse);
		Chocolate = new FLinearColor(FColor.Chocolate);
		Coral = new FLinearColor(FColor.Coral);
		CornflowerBlue = new FLinearColor(FColor.CornflowerBlue);
		Cornsilk = new FLinearColor(FColor.Cornsilk);
		Crimson = new FLinearColor(FColor.Crimson);
		Cyan = new FLinearColor(FColor.Cyan);
		DarkBlue = new FLinearColor(FColor.DarkBlue);
		DarkCyan = new FLinearColor(FColor.DarkCyan);
		DarkGoldenrod = new FLinearColor(FColor.DarkGoldenrod);
		DarkGray = new FLinearColor(FColor.DarkGray);
		DarkGreen = new FLinearColor(FColor.DarkGreen);
		DarkKhaki = new FLinearColor(FColor.DarkKhaki);
		DarkMagenta = new FLinearColor(FColor.DarkMagenta);
		DarkOliveGreen = new FLinearColor(FColor.DarkOliveGreen);
		DarkOrange = new FLinearColor(FColor.DarkOrange);
		DarkOrchid = new FLinearColor(FColor.DarkOrchid);
		DarkRed = new FLinearColor(FColor.DarkRed);
		DarkSalmon = new FLinearColor(FColor.DarkSalmon);
		DarkSeaGreen = new FLinearColor(FColor.DarkSeaGreen);
		DarkSlateBlue = new FLinearColor(FColor.DarkSlateBlue);
		DarkSlateGray = new FLinearColor(FColor.DarkSlateGray);
		DarkTurquoise = new FLinearColor(FColor.DarkTurquoise);
		DarkViolet = new FLinearColor(FColor.DarkViolet);
		DeepPink = new FLinearColor(FColor.DeepPink);
		DeepSkyBlue = new FLinearColor(FColor.DeepSkyBlue);
		DimGray = new FLinearColor(FColor.DimGray);
		DodgerBlue = new FLinearColor(FColor.DodgerBlue);
		Firebrick = new FLinearColor(FColor.Firebrick);
		FloralWhite = new FLinearColor(FColor.FloralWhite);
		ForestGreen = new FLinearColor(FColor.ForestGreen);
		Fuchsia = new FLinearColor(FColor.Fuchsia);
		Gainsboro = new FLinearColor(FColor.Gainsboro);
		GhostWhite = new FLinearColor(FColor.GhostWhite);
		Gold = new FLinearColor(FColor.Gold);
		Goldenrod = new FLinearColor(FColor.Goldenrod);
		GreenYellow = new FLinearColor(FColor.GreenYellow);
		Honeydew = new FLinearColor(FColor.Honeydew);
		HotPink = new FLinearColor(FColor.HotPink);
		IndianRed = new FLinearColor(FColor.IndianRed);
		Indigo = new FLinearColor(FColor.Indigo);
		Ivory = new FLinearColor(FColor.Ivory);
		Khaki = new FLinearColor(FColor.Khaki);
		Lavender = new FLinearColor(FColor.Lavender);
		LavenderBlush = new FLinearColor(FColor.LavenderBlush);
		LawnGreen = new FLinearColor(FColor.LawnGreen);
		LemonChiffon = new FLinearColor(FColor.LemonChiffon);
		LightBlue = new FLinearColor(FColor.LightBlue);
		LightCoral = new FLinearColor(FColor.LightCoral);
		LightCyan = new FLinearColor(FColor.LightCyan);
		LightGoldenrodYellow = new FLinearColor(FColor.LightGoldenrodYellow);
		LightGray = new FLinearColor(FColor.LightGray);
		LightGreen = new FLinearColor(FColor.LightGreen);
		LightPink = new FLinearColor(FColor.LightPink);
		LightSalmon = new FLinearColor(FColor.LightSalmon);
		LightSeaGreen = new FLinearColor(FColor.LightSeaGreen);
		LightSkyBlue = new FLinearColor(FColor.LightSkyBlue);
		LightSlateGray = new FLinearColor(FColor.LightSlateGray);
		LightSteelBlue = new FLinearColor(FColor.LightSteelBlue);
		LightYellow = new FLinearColor(FColor.LightYellow);
		Lime = new FLinearColor(FColor.Lime);
		LimeGreen = new FLinearColor(FColor.LimeGreen);
		Linen = new FLinearColor(FColor.Linen);
		Magenta = new FLinearColor(FColor.Magenta);
		Maroon = new FLinearColor(FColor.Maroon);
		MediumAquamarine = new FLinearColor(FColor.MediumAquamarine);
		MediumBlue = new FLinearColor(FColor.MediumBlue);
		MediumOrchid = new FLinearColor(FColor.MediumOrchid);
		MediumPurple = new FLinearColor(FColor.MediumPurple);
		MediumSeaGreen = new FLinearColor(FColor.MediumSeaGreen);
		MediumSlateBlue = new FLinearColor(FColor.MediumSlateBlue);
		MediumSpringGreen = new FLinearColor(FColor.MediumSpringGreen);
		MediumTurquoise = new FLinearColor(FColor.MediumTurquoise);
		MediumVioletRed = new FLinearColor(FColor.MediumVioletRed);
		MidnightBlue = new FLinearColor(FColor.MidnightBlue);
		MintCream = new FLinearColor(FColor.MintCream);
		MistyRose = new FLinearColor(FColor.MistyRose);
		Moccasin = new FLinearColor(FColor.Moccasin);
		MonoGameOrange = new FLinearColor(FColor.MonoGameOrange);
		NavajoWhite = new FLinearColor(FColor.NavajoWhite);
		Navy = new FLinearColor(FColor.Navy);
		OldLace = new FLinearColor(FColor.OldLace);
		Olive = new FLinearColor(FColor.Olive);
		OliveDrab = new FLinearColor(FColor.OliveDrab);
		Orange = new FLinearColor(FColor.Orange);
		OrangeRed = new FLinearColor(FColor.OrangeRed);
		Orchid = new FLinearColor(FColor.Orchid);
		PaleGoldenrod = new FLinearColor(FColor.PaleGoldenrod);
		PaleGreen = new FLinearColor(FColor.PaleGreen);
		PaleTurquoise = new FLinearColor(FColor.PaleTurquoise);
		PaleVioletRed = new FLinearColor(FColor.PaleVioletRed);
		PapayaWhip = new FLinearColor(FColor.PapayaWhip);
		PeachPuff = new FLinearColor(FColor.PeachPuff);
		Peru = new FLinearColor(FColor.Peru);
		Pink = new FLinearColor(FColor.Pink);
		Plum = new FLinearColor(FColor.Plum);
		PowderBlue = new FLinearColor(FColor.PowderBlue);
		Purple = new FLinearColor(FColor.Purple);
		RosyBrown = new FLinearColor(FColor.RosyBrown);
		RoyalBlue = new FLinearColor(FColor.RoyalBlue);
		SaddleBrown = new FLinearColor(FColor.SaddleBrown);
		Salmon = new FLinearColor(FColor.Salmon);
		SandyBrown = new FLinearColor(FColor.SandyBrown);
		SeaGreen = new FLinearColor(FColor.SeaGreen);
		SeaShell = new FLinearColor(FColor.SeaShell);
		Sienna = new FLinearColor(FColor.Sienna);
		Silver = new FLinearColor(FColor.Silver);
		SkyBlue = new FLinearColor(FColor.SkyBlue);
		SlateBlue = new FLinearColor(FColor.SlateBlue);
		SlateGray = new FLinearColor(FColor.SlateGray);
		Snow = new FLinearColor(FColor.Snow);
		SpringGreen = new FLinearColor(FColor.SpringGreen);
		SteelBlue = new FLinearColor(FColor.SteelBlue);
		Tan = new FLinearColor(FColor.Tan);
		Teal = new FLinearColor(FColor.Teal);
		Thistle = new FLinearColor(FColor.Thistle);
		Tomato = new FLinearColor(FColor.Tomato);
		Turquoise = new FLinearColor(FColor.Turquoise);
		Violet = new FLinearColor(FColor.Violet);
		Wheat = new FLinearColor(FColor.Wheat);
		WhiteSmoke = new FLinearColor(FColor.WhiteSmoke);
		YellowGreen = new FLinearColor(FColor.YellowGreen);
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLinearColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLinearColor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.LinearColor");
		FLinearColor_StructSize = NativeReflection.GetStructSize(unrealStruct);
		R_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "R");
		R_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "R", Classes.FFloatProperty);
		G_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "G");
		G_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "G", Classes.FFloatProperty);
		B_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "B");
		B_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "B", Classes.FFloatProperty);
		A_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "A");
		A_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "A", Classes.FFloatProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FLinearColor));
	}

	public FLinearColor(float r, float g, float b, float a = 1f)
	{
		R = r;
		G = g;
		B = b;
		A = a;
	}

	public FLinearColor(double r, double g, double b, double a = 1.0)
	{
		R = (float)r;
		G = (float)g;
		B = (float)b;
		A = (float)a;
	}

	public FLinearColor(FColor color)
	{
		R = Tables.sRGBToLinearTable[color.R];
		G = Tables.sRGBToLinearTable[color.G];
		B = Tables.sRGBToLinearTable[color.B];
		A = (float)(int)color.A * 0.003921569f;
	}

	public FLinearColor(FVector vector)
	{
		R = vector.X;
		G = vector.Y;
		B = vector.Z;
		A = 1f;
	}

	public FLinearColor(FVector4 vector)
	{
		R = vector.X;
		G = vector.Y;
		B = vector.Z;
		A = vector.W;
	}

	public FColor ToRGBE()
	{
		float num = FMath.Max3(R, G, B);
		FColor result = default(FColor);
		if ((double)num < 1E-32)
		{
			result = default(FColor);
		}
		else
		{
			int exp;
			float num2 = (float)FMath.frexp(num, out exp) / num * 255f;
			result.R = (byte)FMath.Clamp(FMath.TruncToInt(R * num2), 0, 255);
			result.G = (byte)FMath.Clamp(FMath.TruncToInt(G * num2), 0, 255);
			result.B = (byte)FMath.Clamp(FMath.TruncToInt(B * num2), 0, 255);
			result.A = (byte)(FMath.Clamp(FMath.TruncToInt(exp), -128, 127) + 128);
		}
		return result;
	}

	public static FLinearColor FromSRGBColor(FColor color)
	{
		FLinearColor result = default(FLinearColor);
		result.R = Tables.sRGBToLinearTable[color.R];
		result.G = Tables.sRGBToLinearTable[color.G];
		result.B = Tables.sRGBToLinearTable[color.B];
		result.A = (float)(int)color.A * 0.003921569f;
		return result;
	}

	public static FLinearColor FromPow22Color(FColor color)
	{
		FLinearColor result = default(FLinearColor);
		result.R = Tables.Pow22OneOver255Table[color.R];
		result.G = Tables.Pow22OneOver255Table[color.G];
		result.B = Tables.Pow22OneOver255Table[color.B];
		result.A = (float)(int)color.A * 0.003921569f;
		return result;
	}

	public float Component(int index)
	{
		return this[index];
	}

	public static FLinearColor operator +(FLinearColor a, FLinearColor b)
	{
		return new FLinearColor(a.R + b.R, a.G + b.G, a.B + b.B, a.A + b.A);
	}

	public static FLinearColor operator -(FLinearColor a, FLinearColor b)
	{
		return new FLinearColor(a.R - b.R, a.G - b.G, a.B - b.B, a.A - b.A);
	}

	public static FLinearColor operator *(FLinearColor a, FLinearColor b)
	{
		return new FLinearColor(a.R * b.R, a.G * b.G, a.B * b.B, a.A * b.A);
	}

	public static FLinearColor operator *(float scale, FLinearColor a)
	{
		return new FLinearColor(a.R * scale, a.G * scale, a.B * scale, a.A * scale);
	}

	public static FLinearColor operator *(FLinearColor a, float scale)
	{
		return new FLinearColor(a.R * scale, a.G * scale, a.B * scale, a.A * scale);
	}

	public static FLinearColor operator /(FLinearColor a, FLinearColor b)
	{
		return new FLinearColor(a.R / b.R, a.G / b.G, a.B / b.B, a.A / b.A);
	}

	public static FLinearColor operator /(FLinearColor a, float scalar)
	{
		float num = 1f / scalar;
		return new FLinearColor(a.R * num, a.G * num, a.B * num, a.A * num);
	}

	public FLinearColor GetClamped(float min = 0f, float max = 1f)
	{
		FLinearColor result = default(FLinearColor);
		result.R = FMath.Clamp(R, min, max);
		result.G = FMath.Clamp(G, min, max);
		result.B = FMath.Clamp(B, min, max);
		result.A = FMath.Clamp(A, min, max);
		return result;
	}

	public static bool operator ==(FLinearColor a, FLinearColor b)
	{
		if (a.R == b.R && a.G == b.G && a.B == b.B)
		{
			return a.A == b.A;
		}
		return false;
	}

	public static bool operator !=(FLinearColor a, FLinearColor b)
	{
		if (a.R == b.R && a.G == b.G && a.B != b.B)
		{
			return a.A != b.A;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FLinearColor))
		{
			return false;
		}
		return Equals((FLinearColor)obj);
	}

	public bool Equals(FLinearColor other)
	{
		if (R == other.R && G == other.G && B == other.B)
		{
			return A == other.A;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((((R.GetHashCode() * 397) ^ G.GetHashCode()) * 397) ^ B.GetHashCode()) * 397) ^ A.GetHashCode();
	}

	public bool Equals(FLinearColor other, float tolerance = 0.0001f)
	{
		if (FMath.Abs(R - other.R) < tolerance && FMath.Abs(G - other.G) < tolerance && FMath.Abs(B - other.B) < tolerance)
		{
			return FMath.Abs(A - other.A) < tolerance;
		}
		return false;
	}

	public FLinearColor CopyWithNewOpacity(float newOpacicty)
	{
		FLinearColor result = this;
		result.A = newOpacicty;
		return result;
	}

	public static FLinearColor FGetHSV(byte h, byte s, byte v)
	{
		float num = (float)(int)v * 1.4f / 255f;
		num *= 0.7f / (0.01f + FMath.Sqrt(num));
		num = FMath.Clamp(num, 0f, 1f);
		FVector fVector = ((h < 86) ? new FVector((float)(85 - h) / 85f, (float)(int)h / 85f, 0.0) : ((h < 171) ? new FVector(0.0, (float)(170 - h) / 85f, (float)(h - 85) / 85f) : new FVector((float)(h - 170) / 85f, 0.0, (float)(255 - h) / 84f)));
		FVector fVector2 = (fVector + (float)(int)s / 255f * (new FVector(1.0, 1.0, 1.0) - fVector)) * num;
		return new FLinearColor(fVector2.X, fVector2.Y, fVector2.Z);
	}

	public static FLinearColor MakeRandomColor()
	{
		return FGetHSV((byte)(FMath.FRand() * 255f), 0, byte.MaxValue);
	}

	public static FLinearColor MakeFromColorTemperature(float temp)
	{
		temp = FMath.Clamp(temp, 1000f, 15000f);
		float num = (0.86011773f + 0.00015411826f * temp + 1.2864122E-07f * temp * temp) / (1f + 0.0008424202f * temp + 7.0814514E-07f * temp * temp);
		float num2 = (0.31739873f + 4.2280626E-05f * temp + 4.2048168E-08f * temp * temp) / (1f - 2.8974182E-05f * temp + 1.6145606E-07f * temp * temp);
		float num3 = 3f * num / (2f * num - 8f * num2 + 4f);
		float num4 = 2f * num2 / (2f * num - 8f * num2 + 4f);
		float num5 = 1f - num3 - num4;
		float num6 = 1f;
		float num7 = num6 / num4 * num3;
		float num8 = num6 / num4 * num5;
		float r = 3.2404542f * num7 + -1.5371385f * num6 + -0.4985314f * num8;
		float g = -0.969266f * num7 + 1.8760108f * num6 + 0.041556f * num8;
		float b = 0.0556434f * num7 + -0.2040259f * num6 + 1.0572252f * num8;
		return new FLinearColor(r, g, b);
	}

	public static float Dist(FLinearColor v1, FLinearColor v2)
	{
		return FMath.Sqrt(FMath.Square(v2.R - v1.R) + FMath.Square(v2.G - v1.G) + FMath.Square(v2.B - v1.B) + FMath.Square(v2.A - v1.A));
	}

	public static float EvaluateBezier(FLinearColor[] controlPoints, int numPoints, out FLinearColor[] points)
	{
		points = new FLinearColor[numPoints];
		float num = 1f / (float)(numPoints - 1);
		FLinearColor fLinearColor = controlPoints[0];
		FLinearColor fLinearColor2 = controlPoints[1];
		FLinearColor fLinearColor3 = controlPoints[2];
		FLinearColor fLinearColor4 = controlPoints[3];
		FLinearColor fLinearColor5 = fLinearColor;
		FLinearColor fLinearColor6 = 3f * (fLinearColor2 - fLinearColor);
		FLinearColor fLinearColor7 = 3f * (fLinearColor3 - 2f * fLinearColor2 + fLinearColor);
		FLinearColor fLinearColor8 = fLinearColor4 - 3f * fLinearColor3 + 3f * fLinearColor2 - fLinearColor;
		FLinearColor fLinearColor9 = fLinearColor5;
		FLinearColor fLinearColor10 = fLinearColor6 * num + fLinearColor7 * num * num + fLinearColor8 * num * num * num;
		FLinearColor fLinearColor11 = 2f * fLinearColor7 * num * num + 6f * fLinearColor8 * num * num * num;
		FLinearColor fLinearColor12 = 6f * fLinearColor8 * num * num * num;
		float num2 = 0f;
		FLinearColor v = fLinearColor;
		points[0] = fLinearColor;
		for (int i = 1; i < numPoints; i++)
		{
			fLinearColor9 += fLinearColor10;
			fLinearColor10 += fLinearColor11;
			fLinearColor11 += fLinearColor12;
			num2 += Dist(fLinearColor9, v);
			v = fLinearColor9;
			points[i] = fLinearColor9;
		}
		return num2;
	}

	public FLinearColor LinearRGBToHSV()
	{
		float num = FMath.Min3(R, G, B);
		float num2 = FMath.Max3(R, G, B);
		float num3 = num2 - num;
		float r = ((num2 == num) ? 0f : ((num2 == R) ? FMath.Fmod((G - B) / num3 * 60f + 360f, 360f) : ((num2 == G) ? ((B - R) / num3 * 60f + 120f) : ((num2 == B) ? ((R - G) / num3 * 60f + 240f) : 0f))));
		float g = ((num2 == 0f) ? 0f : (num3 / num2));
		float b = num2;
		return new FLinearColor(r, g, b, A);
	}

	public FLinearColor HSVToLinearRGB()
	{
		float r = R;
		float g = G;
		float b = B;
		float num = r / 60f;
		float num2 = FMath.FloorToFloat(num);
		float num3 = num - num2;
		float[] array = new float[4]
		{
			b,
			b * (1f - g),
			b * (1f - num3 * g),
			b * (1f - (1f - num3) * g)
		};
		uint[,] array2 = new uint[6, 3]
		{
			{ 0u, 3u, 1u },
			{ 2u, 0u, 1u },
			{ 1u, 0u, 3u },
			{ 1u, 2u, 0u },
			{ 3u, 1u, 0u },
			{ 0u, 1u, 2u }
		};
		uint num4 = (uint)num2 % 6;
		return new FLinearColor(array[array2[num4, 0]], array[array2[num4, 1]], array[array2[num4, 2]], A);
	}

	public static FLinearColor LerpUsingHSV(FLinearColor from, FLinearColor to, float progress)
	{
		FLinearColor fLinearColor = from.LinearRGBToHSV();
		FLinearColor fLinearColor2 = to.LinearRGBToHSV();
		float num = fLinearColor.R;
		float num2 = fLinearColor2.R;
		if (FMath.Abs(num - num2) > 180f)
		{
			if (num2 > num)
			{
				num += 360f;
			}
			else
			{
				num2 += 360f;
			}
		}
		float x = FMath.Lerp(num, num2, progress);
		x = FMath.Fmod(x, 360f);
		if (x < 0f)
		{
			x += 360f;
		}
		float g = FMath.Lerp(fLinearColor.G, fLinearColor2.G, progress);
		float b = FMath.Lerp(fLinearColor.B, fLinearColor2.B, progress);
		FLinearColor result = new FLinearColor(x, g, b).HSVToLinearRGB();
		float a = FMath.Lerp(from.A, to.A, progress);
		result.A = a;
		return result;
	}

	public FColor Quantize()
	{
		return new FColor((byte)FMath.Clamp(FMath.TruncToInt(R * 255f), 0, 255), (byte)FMath.Clamp(FMath.TruncToInt(G * 255f), 0, 255), (byte)FMath.Clamp(FMath.TruncToInt(B * 255f), 0, 255), (byte)FMath.Clamp(FMath.TruncToInt(A * 255f), 0, 255));
	}

	public FColor QuantizeRound()
	{
		return new FColor((byte)FMath.Clamp(FMath.RoundToInt(R * 255f), 0, 255), (byte)FMath.Clamp(FMath.RoundToInt(G * 255f), 0, 255), (byte)FMath.Clamp(FMath.RoundToInt(B * 255f), 0, 255), (byte)FMath.Clamp(FMath.RoundToInt(A * 255f), 0, 255));
	}

	public FColor ToFColor(bool srgb)
	{
		float num = FMath.Clamp(R, 0f, 1f);
		float num2 = FMath.Clamp(G, 0f, 1f);
		float num3 = FMath.Clamp(B, 0f, 1f);
		float num4 = FMath.Clamp(A, 0f, 1f);
		if (srgb)
		{
			num = ((num <= 0.0031308f) ? (num * 12.92f) : (FMath.Pow(num, 5f / 12f) * 1.055f - 0.055f));
			num2 = ((num2 <= 0.0031308f) ? (num2 * 12.92f) : (FMath.Pow(num2, 5f / 12f) * 1.055f - 0.055f));
			num3 = ((num3 <= 0.0031308f) ? (num3 * 12.92f) : (FMath.Pow(num3, 5f / 12f) * 1.055f - 0.055f));
		}
		return new FColor
		{
			A = (byte)FMath.FloorToInt(num4 * 255.999f),
			R = (byte)FMath.FloorToInt(num * 255.999f),
			G = (byte)FMath.FloorToInt(num2 * 255.999f),
			B = (byte)FMath.FloorToInt(num3 * 255.999f)
		};
	}

	public FLinearColor Desaturate(float desaturation)
	{
		float num = ComputeLuminance();
		return FMath.Lerp(this, new FLinearColor(num, num, num, 0f), desaturation);
	}

	public float ComputeLuminance()
	{
		return R * 0.3f + G * 0.59f + B * 0.11f;
	}

	public float GetMax()
	{
		return FMath.Max(FMath.Max(FMath.Max(R, G), B), A);
	}

	public bool IsAlmostBlack()
	{
		if (FMath.Square(R) < 1E-05f && FMath.Square(G) < 1E-05f)
		{
			return FMath.Square(B) < 1E-05f;
		}
		return false;
	}

	public float GetMin()
	{
		return FMath.Min(FMath.Min(FMath.Min(R, G), B), A);
	}

	public float GetLuminance()
	{
		return R * 0.3f + G * 0.59f + B * 0.11f;
	}

	public override string ToString()
	{
		return "(R=" + R + ",G=" + G + ",B=" + B + ",A=" + A + ")";
	}

	public bool InitFromString(string sourceString)
	{
		R = (G = (B = 0f));
		A = 1f;
		bool result = FParse.Value(sourceString, "R=", ref R) && FParse.Value(sourceString, "G=", ref G) && FParse.Value(sourceString, "B=", ref B);
		FParse.Value(sourceString, "A=", ref A);
		return result;
	}

	public static FLinearColor Lerp(FLinearColor a, FLinearColor b, float alpha)
	{
		return FMath.Lerp(a, b, alpha);
	}

	public static FLinearColor LerpStable(FLinearColor a, FLinearColor b, float alpha)
	{
		return FMath.Lerp(a, b, alpha);
	}

	public static void ComputeAndFixedColorAndIntensity(FLinearColor linearColor, out FColor color, out float intensity)
	{
		float num = FMath.Max(1E-05f, FMath.Max(linearColor.R, FMath.Max(linearColor.G, linearColor.B)));
		color = (linearColor / num).ToFColor(srgb: true);
		intensity = num;
	}
}
