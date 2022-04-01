namespace CloudmobFdk.Exceptions
{
    /// <summary>
	/// Thrown when system configuration is invalid
	/// </summary>
	public class InvalidConfigException : Exception
	{
		public InvalidConfigException(string message) : base(message) { }
	}
}