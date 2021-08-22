/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself and is **not** officially supported by VRChat. The documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility.  The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please read tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee or support for external applications using the API. Access to API endpoints may break **at any time, without notice**. Therefore, please **do not ping** VRChat Staff in the VRChat Discord if you are having API problems, as they do not provide API support. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programmatically retrieve or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintains API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open-source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using io.github.vrchatapi.Client;
using io.github.vrchatapi.Model;

namespace io.github.vrchatapi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INotificationsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Accept Friend Request
        /// </summary>
        /// <remarks>
        /// Accept a friend request by notification &#x60;frq_&#x60; ID. Friend requests can be found using the NotificationsAPI &#x60;getNotifications&#x60; by filtering of type &#x60;friendRequest&#x60;.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>Success</returns>
        Success AcceptFriendRequest (string notificationId);

        /// <summary>
        /// Accept Friend Request
        /// </summary>
        /// <remarks>
        /// Accept a friend request by notification &#x60;frq_&#x60; ID. Friend requests can be found using the NotificationsAPI &#x60;getNotifications&#x60; by filtering of type &#x60;friendRequest&#x60;.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>ApiResponse of Success</returns>
        ApiResponse<Success> AcceptFriendRequestWithHttpInfo (string notificationId);
        /// <summary>
        /// Clear All Notifications
        /// </summary>
        /// <remarks>
        /// Clear **all** notifications.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Success</returns>
        Success ClearNotifications ();

        /// <summary>
        /// Clear All Notifications
        /// </summary>
        /// <remarks>
        /// Clear **all** notifications.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Success</returns>
        ApiResponse<Success> ClearNotificationsWithHttpInfo ();
        /// <summary>
        /// Delete Notification
        /// </summary>
        /// <remarks>
        /// Delete a notification.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>Notification</returns>
        Notification DeleteNotification (string notificationId);

        /// <summary>
        /// Delete Notification
        /// </summary>
        /// <remarks>
        /// Delete a notification.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>ApiResponse of Notification</returns>
        ApiResponse<Notification> DeleteNotificationWithHttpInfo (string notificationId);
        /// <summary>
        /// List Notifications
        /// </summary>
        /// <remarks>
        /// Retrieve all of the current user&#39;s notifications.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only send notifications of this type (can use &#x60;all&#x60; for all). (optional)</param>
        /// <param name="sent">Return notifications sent by the user. Must be false or omitted. (optional)</param>
        /// <param name="hidden">Whether to return hidden or non-hidden notifications. True only allowed on type &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="after">Only return notifications sent after this Date. Ignored if type is &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <returns>List&lt;Notification&gt;</returns>
        List<Notification> GetNotifications (string type = default(string), bool? sent = default(bool?), bool? hidden = default(bool?), string after = default(string), int? n = default(int?), int? offset = default(int?));

        /// <summary>
        /// List Notifications
        /// </summary>
        /// <remarks>
        /// Retrieve all of the current user&#39;s notifications.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only send notifications of this type (can use &#x60;all&#x60; for all). (optional)</param>
        /// <param name="sent">Return notifications sent by the user. Must be false or omitted. (optional)</param>
        /// <param name="hidden">Whether to return hidden or non-hidden notifications. True only allowed on type &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="after">Only return notifications sent after this Date. Ignored if type is &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <returns>ApiResponse of List&lt;Notification&gt;</returns>
        ApiResponse<List<Notification>> GetNotificationsWithHttpInfo (string type = default(string), bool? sent = default(bool?), bool? hidden = default(bool?), string after = default(string), int? n = default(int?), int? offset = default(int?));
        /// <summary>
        /// Mark As Read
        /// </summary>
        /// <remarks>
        /// Mark a notification as seen.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>Notification</returns>
        Notification MarkNotificationAsRead (string notificationId);

        /// <summary>
        /// Mark As Read
        /// </summary>
        /// <remarks>
        /// Mark a notification as seen.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>ApiResponse of Notification</returns>
        ApiResponse<Notification> MarkNotificationAsReadWithHttpInfo (string notificationId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Accept Friend Request
        /// </summary>
        /// <remarks>
        /// Accept a friend request by notification &#x60;frq_&#x60; ID. Friend requests can be found using the NotificationsAPI &#x60;getNotifications&#x60; by filtering of type &#x60;friendRequest&#x60;.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Success</returns>
        System.Threading.Tasks.Task<Success> AcceptFriendRequestAsync (string notificationId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Accept Friend Request
        /// </summary>
        /// <remarks>
        /// Accept a friend request by notification &#x60;frq_&#x60; ID. Friend requests can be found using the NotificationsAPI &#x60;getNotifications&#x60; by filtering of type &#x60;friendRequest&#x60;.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Success)</returns>
        System.Threading.Tasks.Task<ApiResponse<Success>> AcceptFriendRequestWithHttpInfoAsync (string notificationId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Clear All Notifications
        /// </summary>
        /// <remarks>
        /// Clear **all** notifications.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Success</returns>
        System.Threading.Tasks.Task<Success> ClearNotificationsAsync (CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Clear All Notifications
        /// </summary>
        /// <remarks>
        /// Clear **all** notifications.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Success)</returns>
        System.Threading.Tasks.Task<ApiResponse<Success>> ClearNotificationsWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete Notification
        /// </summary>
        /// <remarks>
        /// Delete a notification.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Notification</returns>
        System.Threading.Tasks.Task<Notification> DeleteNotificationAsync (string notificationId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete Notification
        /// </summary>
        /// <remarks>
        /// Delete a notification.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Notification)</returns>
        System.Threading.Tasks.Task<ApiResponse<Notification>> DeleteNotificationWithHttpInfoAsync (string notificationId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Notifications
        /// </summary>
        /// <remarks>
        /// Retrieve all of the current user&#39;s notifications.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only send notifications of this type (can use &#x60;all&#x60; for all). (optional)</param>
        /// <param name="sent">Return notifications sent by the user. Must be false or omitted. (optional)</param>
        /// <param name="hidden">Whether to return hidden or non-hidden notifications. True only allowed on type &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="after">Only return notifications sent after this Date. Ignored if type is &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;Notification&gt;</returns>
        System.Threading.Tasks.Task<List<Notification>> GetNotificationsAsync (string type = default(string), bool? sent = default(bool?), bool? hidden = default(bool?), string after = default(string), int? n = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List Notifications
        /// </summary>
        /// <remarks>
        /// Retrieve all of the current user&#39;s notifications.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only send notifications of this type (can use &#x60;all&#x60; for all). (optional)</param>
        /// <param name="sent">Return notifications sent by the user. Must be false or omitted. (optional)</param>
        /// <param name="hidden">Whether to return hidden or non-hidden notifications. True only allowed on type &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="after">Only return notifications sent after this Date. Ignored if type is &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;Notification&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Notification>>> GetNotificationsWithHttpInfoAsync (string type = default(string), bool? sent = default(bool?), bool? hidden = default(bool?), string after = default(string), int? n = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Mark As Read
        /// </summary>
        /// <remarks>
        /// Mark a notification as seen.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Notification</returns>
        System.Threading.Tasks.Task<Notification> MarkNotificationAsReadAsync (string notificationId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Mark As Read
        /// </summary>
        /// <remarks>
        /// Mark a notification as seen.
        /// </remarks>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Notification)</returns>
        System.Threading.Tasks.Task<ApiResponse<Notification>> MarkNotificationAsReadWithHttpInfoAsync (string notificationId, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NotificationsApi : INotificationsApi
    {
        private io.github.vrchatapi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationsApi(String basePath)
        {
            this.Configuration = new io.github.vrchatapi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class
        /// </summary>
        /// <returns></returns>
        public NotificationsApi()
        {
            this.Configuration = io.github.vrchatapi.Client.Configuration.Default;

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NotificationsApi(io.github.vrchatapi.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = io.github.vrchatapi.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = io.github.vrchatapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public io.github.vrchatapi.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public io.github.vrchatapi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Accept Friend Request Accept a friend request by notification &#x60;frq_&#x60; ID. Friend requests can be found using the NotificationsAPI &#x60;getNotifications&#x60; by filtering of type &#x60;friendRequest&#x60;.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>Success</returns>
        public Success AcceptFriendRequest (string notificationId)
        {
             ApiResponse<Success> localVarResponse = AcceptFriendRequestWithHttpInfo(notificationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Accept Friend Request Accept a friend request by notification &#x60;frq_&#x60; ID. Friend requests can be found using the NotificationsAPI &#x60;getNotifications&#x60; by filtering of type &#x60;friendRequest&#x60;.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>ApiResponse of Success</returns>
        public ApiResponse<Success> AcceptFriendRequestWithHttpInfo (string notificationId)
        {
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling NotificationsApi->AcceptFriendRequest");

            var localVarPath = "/auth/user/notifications/{notificationId}/accept";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AcceptFriendRequest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Success>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Success) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Success)));
        }

        /// <summary>
        /// Accept Friend Request Accept a friend request by notification &#x60;frq_&#x60; ID. Friend requests can be found using the NotificationsAPI &#x60;getNotifications&#x60; by filtering of type &#x60;friendRequest&#x60;.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Success</returns>
        public async System.Threading.Tasks.Task<Success> AcceptFriendRequestAsync (string notificationId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Success> localVarResponse = await AcceptFriendRequestWithHttpInfoAsync(notificationId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Accept Friend Request Accept a friend request by notification &#x60;frq_&#x60; ID. Friend requests can be found using the NotificationsAPI &#x60;getNotifications&#x60; by filtering of type &#x60;friendRequest&#x60;.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Success)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Success>> AcceptFriendRequestWithHttpInfoAsync (string notificationId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling NotificationsApi->AcceptFriendRequest");

            var localVarPath = "/auth/user/notifications/{notificationId}/accept";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AcceptFriendRequest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Success>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Success) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Success)));
        }

        /// <summary>
        /// Clear All Notifications Clear **all** notifications.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Success</returns>
        public Success ClearNotifications ()
        {
             ApiResponse<Success> localVarResponse = ClearNotificationsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Clear All Notifications Clear **all** notifications.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Success</returns>
        public ApiResponse<Success> ClearNotificationsWithHttpInfo ()
        {

            var localVarPath = "/auth/user/notifications/clear";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ClearNotifications", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Success>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Success) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Success)));
        }

        /// <summary>
        /// Clear All Notifications Clear **all** notifications.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Success</returns>
        public async System.Threading.Tasks.Task<Success> ClearNotificationsAsync (CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Success> localVarResponse = await ClearNotificationsWithHttpInfoAsync(cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Clear All Notifications Clear **all** notifications.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Success)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Success>> ClearNotificationsWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/auth/user/notifications/clear";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ClearNotifications", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Success>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Success) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Success)));
        }

        /// <summary>
        /// Delete Notification Delete a notification.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>Notification</returns>
        public Notification DeleteNotification (string notificationId)
        {
             ApiResponse<Notification> localVarResponse = DeleteNotificationWithHttpInfo(notificationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Notification Delete a notification.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>ApiResponse of Notification</returns>
        public ApiResponse<Notification> DeleteNotificationWithHttpInfo (string notificationId)
        {
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling NotificationsApi->DeleteNotification");

            var localVarPath = "/auth/user/notifications/{notificationId}/hide";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteNotification", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Notification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Notification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Notification)));
        }

        /// <summary>
        /// Delete Notification Delete a notification.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Notification</returns>
        public async System.Threading.Tasks.Task<Notification> DeleteNotificationAsync (string notificationId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Notification> localVarResponse = await DeleteNotificationWithHttpInfoAsync(notificationId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Notification Delete a notification.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Notification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Notification>> DeleteNotificationWithHttpInfoAsync (string notificationId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling NotificationsApi->DeleteNotification");

            var localVarPath = "/auth/user/notifications/{notificationId}/hide";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteNotification", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Notification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Notification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Notification)));
        }

        /// <summary>
        /// List Notifications Retrieve all of the current user&#39;s notifications.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only send notifications of this type (can use &#x60;all&#x60; for all). (optional)</param>
        /// <param name="sent">Return notifications sent by the user. Must be false or omitted. (optional)</param>
        /// <param name="hidden">Whether to return hidden or non-hidden notifications. True only allowed on type &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="after">Only return notifications sent after this Date. Ignored if type is &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <returns>List&lt;Notification&gt;</returns>
        public List<Notification> GetNotifications (string type = default(string), bool? sent = default(bool?), bool? hidden = default(bool?), string after = default(string), int? n = default(int?), int? offset = default(int?))
        {
             ApiResponse<List<Notification>> localVarResponse = GetNotificationsWithHttpInfo(type, sent, hidden, after, n, offset);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Notifications Retrieve all of the current user&#39;s notifications.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only send notifications of this type (can use &#x60;all&#x60; for all). (optional)</param>
        /// <param name="sent">Return notifications sent by the user. Must be false or omitted. (optional)</param>
        /// <param name="hidden">Whether to return hidden or non-hidden notifications. True only allowed on type &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="after">Only return notifications sent after this Date. Ignored if type is &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <returns>ApiResponse of List&lt;Notification&gt;</returns>
        public ApiResponse<List<Notification>> GetNotificationsWithHttpInfo (string type = default(string), bool? sent = default(bool?), bool? hidden = default(bool?), string after = default(string), int? n = default(int?), int? offset = default(int?))
        {

            var localVarPath = "/auth/user/notifications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (sent != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sent", sent)); // query parameter
            if (hidden != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "hidden", hidden)); // query parameter
            if (after != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "after", after)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetNotifications", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Notification>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Notification>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Notification>)));
        }

        /// <summary>
        /// List Notifications Retrieve all of the current user&#39;s notifications.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only send notifications of this type (can use &#x60;all&#x60; for all). (optional)</param>
        /// <param name="sent">Return notifications sent by the user. Must be false or omitted. (optional)</param>
        /// <param name="hidden">Whether to return hidden or non-hidden notifications. True only allowed on type &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="after">Only return notifications sent after this Date. Ignored if type is &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;Notification&gt;</returns>
        public async System.Threading.Tasks.Task<List<Notification>> GetNotificationsAsync (string type = default(string), bool? sent = default(bool?), bool? hidden = default(bool?), string after = default(string), int? n = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<Notification>> localVarResponse = await GetNotificationsWithHttpInfoAsync(type, sent, hidden, after, n, offset, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Notifications Retrieve all of the current user&#39;s notifications.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Only send notifications of this type (can use &#x60;all&#x60; for all). (optional)</param>
        /// <param name="sent">Return notifications sent by the user. Must be false or omitted. (optional)</param>
        /// <param name="hidden">Whether to return hidden or non-hidden notifications. True only allowed on type &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="after">Only return notifications sent after this Date. Ignored if type is &#x60;friendRequest&#x60;. (optional)</param>
        /// <param name="n">The number of objects to return. (optional, default to 60)</param>
        /// <param name="offset">A zero-based offset from the default object sorting from where search results start. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;Notification&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Notification>>> GetNotificationsWithHttpInfoAsync (string type = default(string), bool? sent = default(bool?), bool? hidden = default(bool?), string after = default(string), int? n = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/auth/user/notifications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (sent != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sent", sent)); // query parameter
            if (hidden != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "hidden", hidden)); // query parameter
            if (after != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "after", after)); // query parameter
            if (n != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "n", n)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetNotifications", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Notification>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Notification>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Notification>)));
        }

        /// <summary>
        /// Mark As Read Mark a notification as seen.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>Notification</returns>
        public Notification MarkNotificationAsRead (string notificationId)
        {
             ApiResponse<Notification> localVarResponse = MarkNotificationAsReadWithHttpInfo(notificationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark As Read Mark a notification as seen.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>ApiResponse of Notification</returns>
        public ApiResponse<Notification> MarkNotificationAsReadWithHttpInfo (string notificationId)
        {
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling NotificationsApi->MarkNotificationAsRead");

            var localVarPath = "/auth/user/notifications/{notificationId}/see";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkNotificationAsRead", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Notification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Notification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Notification)));
        }

        /// <summary>
        /// Mark As Read Mark a notification as seen.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Notification</returns>
        public async System.Threading.Tasks.Task<Notification> MarkNotificationAsReadAsync (string notificationId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Notification> localVarResponse = await MarkNotificationAsReadWithHttpInfoAsync(notificationId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Mark As Read Mark a notification as seen.
        /// </summary>
        /// <exception cref="io.github.vrchatapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Notification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Notification>> MarkNotificationAsReadWithHttpInfoAsync (string notificationId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling NotificationsApi->MarkNotificationAsRead");

            var localVarPath = "/auth/user/notifications/{notificationId}/see";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId)); // path parameter

            // authentication (apiKeyCookie) required
            // authentication (authCookie) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkNotificationAsRead", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Notification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Notification) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Notification)));
        }

    }
}