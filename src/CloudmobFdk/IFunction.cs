using CloudmobFassUtils;

namespace CloudmobFdk
{
   /// <summary>
	/// Represents a Fn function that can be invoked
	/// </summary>
	public interface IFunction
	{
		/// <summary>
		/// Invokes the specified function
		/// </summary>
		/// <param name="ctx">Execution context for the function</param>
		/// <param name="input">Input to the function</param>
		/// <param name="services">Service provider for dependency injection</param>
		/// <returns>Data to return from the request</returns>
		Task<object> InvokeAsync(IContext ctx, IInput input, IServiceProvider services);
	}
}