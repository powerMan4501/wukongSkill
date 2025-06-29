namespace System.Threading.Tasks;

internal class Shared<T>
{
	internal T Value;

	internal Shared(T value)
	{
		Value = value;
	}
}
