namespace CloudmobFassUtils
{
   /// <summary>
	/// Represents the input to a function
	/// </summary>
	public interface IInput
	{
		/// <summary>
		/// Gets the input as a string.
		/// </summary>
		string AsString();

		/// <summary>
		/// Gets the input as a dynamic JSON object.
		/// </summary>
		/// <returns></returns>
		dynamic AsJson();

		/// <summary>
		/// Gets the input as a dynamic JSON object.
		/// </summary>
		/// <returns></returns>
		T AsJson<T>();

		/// <summary>
		/// Gets the input as a stream.
		/// </summary>
		Stream AsStream();
	}
}