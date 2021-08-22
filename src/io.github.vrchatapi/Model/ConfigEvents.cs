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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = io.github.vrchatapi.Client.OpenAPIDateConverter;

namespace io.github.vrchatapi.Model
{
    /// <summary>
    /// ConfigEvents
    /// </summary>
    [DataContract]
    public partial class ConfigEvents :  IEquatable<ConfigEvents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigEvents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ConfigEvents()
        {
        }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="distanceClose", EmitDefaultValue=true)]
        public decimal DistanceClose { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="distanceFactor", EmitDefaultValue=true)]
        public decimal DistanceFactor { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="distanceFar", EmitDefaultValue=true)]
        public decimal DistanceFar { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="groupDistance", EmitDefaultValue=true)]
        public decimal GroupDistance { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="maximumBunchSize", EmitDefaultValue=true)]
        public decimal MaximumBunchSize { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="notVisibleFactor", EmitDefaultValue=true)]
        public decimal NotVisibleFactor { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="playerOrderBucketSize", EmitDefaultValue=true)]
        public decimal PlayerOrderBucketSize { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="playerOrderFactor", EmitDefaultValue=true)]
        public decimal PlayerOrderFactor { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="slowUpdateFactorThreshold", EmitDefaultValue=true)]
        public decimal SlowUpdateFactorThreshold { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="viewSegmentLength", EmitDefaultValue=true)]
        public decimal ViewSegmentLength { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigEvents {\n");
            sb.Append("  DistanceClose: ").Append(DistanceClose).Append("\n");
            sb.Append("  DistanceFactor: ").Append(DistanceFactor).Append("\n");
            sb.Append("  DistanceFar: ").Append(DistanceFar).Append("\n");
            sb.Append("  GroupDistance: ").Append(GroupDistance).Append("\n");
            sb.Append("  MaximumBunchSize: ").Append(MaximumBunchSize).Append("\n");
            sb.Append("  NotVisibleFactor: ").Append(NotVisibleFactor).Append("\n");
            sb.Append("  PlayerOrderBucketSize: ").Append(PlayerOrderBucketSize).Append("\n");
            sb.Append("  PlayerOrderFactor: ").Append(PlayerOrderFactor).Append("\n");
            sb.Append("  SlowUpdateFactorThreshold: ").Append(SlowUpdateFactorThreshold).Append("\n");
            sb.Append("  ViewSegmentLength: ").Append(ViewSegmentLength).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigEvents);
        }

        /// <summary>
        /// Returns true if ConfigEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigEvents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DistanceClose == input.DistanceClose ||
                    (this.DistanceClose != null &&
                    this.DistanceClose.Equals(input.DistanceClose))
                ) && 
                (
                    this.DistanceFactor == input.DistanceFactor ||
                    (this.DistanceFactor != null &&
                    this.DistanceFactor.Equals(input.DistanceFactor))
                ) && 
                (
                    this.DistanceFar == input.DistanceFar ||
                    (this.DistanceFar != null &&
                    this.DistanceFar.Equals(input.DistanceFar))
                ) && 
                (
                    this.GroupDistance == input.GroupDistance ||
                    (this.GroupDistance != null &&
                    this.GroupDistance.Equals(input.GroupDistance))
                ) && 
                (
                    this.MaximumBunchSize == input.MaximumBunchSize ||
                    (this.MaximumBunchSize != null &&
                    this.MaximumBunchSize.Equals(input.MaximumBunchSize))
                ) && 
                (
                    this.NotVisibleFactor == input.NotVisibleFactor ||
                    (this.NotVisibleFactor != null &&
                    this.NotVisibleFactor.Equals(input.NotVisibleFactor))
                ) && 
                (
                    this.PlayerOrderBucketSize == input.PlayerOrderBucketSize ||
                    (this.PlayerOrderBucketSize != null &&
                    this.PlayerOrderBucketSize.Equals(input.PlayerOrderBucketSize))
                ) && 
                (
                    this.PlayerOrderFactor == input.PlayerOrderFactor ||
                    (this.PlayerOrderFactor != null &&
                    this.PlayerOrderFactor.Equals(input.PlayerOrderFactor))
                ) && 
                (
                    this.SlowUpdateFactorThreshold == input.SlowUpdateFactorThreshold ||
                    (this.SlowUpdateFactorThreshold != null &&
                    this.SlowUpdateFactorThreshold.Equals(input.SlowUpdateFactorThreshold))
                ) && 
                (
                    this.ViewSegmentLength == input.ViewSegmentLength ||
                    (this.ViewSegmentLength != null &&
                    this.ViewSegmentLength.Equals(input.ViewSegmentLength))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DistanceClose != null)
                    hashCode = hashCode * 59 + this.DistanceClose.GetHashCode();
                if (this.DistanceFactor != null)
                    hashCode = hashCode * 59 + this.DistanceFactor.GetHashCode();
                if (this.DistanceFar != null)
                    hashCode = hashCode * 59 + this.DistanceFar.GetHashCode();
                if (this.GroupDistance != null)
                    hashCode = hashCode * 59 + this.GroupDistance.GetHashCode();
                if (this.MaximumBunchSize != null)
                    hashCode = hashCode * 59 + this.MaximumBunchSize.GetHashCode();
                if (this.NotVisibleFactor != null)
                    hashCode = hashCode * 59 + this.NotVisibleFactor.GetHashCode();
                if (this.PlayerOrderBucketSize != null)
                    hashCode = hashCode * 59 + this.PlayerOrderBucketSize.GetHashCode();
                if (this.PlayerOrderFactor != null)
                    hashCode = hashCode * 59 + this.PlayerOrderFactor.GetHashCode();
                if (this.SlowUpdateFactorThreshold != null)
                    hashCode = hashCode * 59 + this.SlowUpdateFactorThreshold.GetHashCode();
                if (this.ViewSegmentLength != null)
                    hashCode = hashCode * 59 + this.ViewSegmentLength.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}