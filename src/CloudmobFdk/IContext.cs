using Microsoft.AspNetCore.Http;

namespace CloudmobFdk
{
   /// <summary>
	/// Represents the context that a function is executing in
	/// </summary>
	public interface IContext
	{
		/// <summary>
		/// Gets the unique ID assigned to this request.
		/// </summary>
		string CallId { get; }

		/// <summary>
		/// Gets the system configuration.
		/// </summary>
		IConfig Config { get; }

		/// <summary>
		/// Get the date/time after which the request will be aborted.
		/// </summary>
		DateTime? Deadline { get; }

		/// <summary>
		/// Get all HTTP headers for the request
		/// </summary>
		IHeaderDictionary Headers { get; }

		/// <summary>
		/// Gets the method for this event
		/// </summary>
		string Method { get; }

		/// <summary>
		/// Gets the HTTP request URL for this event
		/// </summary>
		string RequestUrl { get; }

		/// <summary>
		/// Gets the cancellation token to handle aborting the request if it takes too long.
		/// </summary>
		CancellationToken TimedOut { get; set; }
	}
}