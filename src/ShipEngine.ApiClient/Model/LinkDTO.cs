/* 
 * ShipEngine
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    ///     Basic Link class for passing back links with api results.
    /// </summary>
    [DataContract]
    public class LinkDTO : IEquatable<LinkDTO>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LinkDTO" /> class.
        /// </summary>
        /// <param name="href">The url for the link..</param>
        /// <param name="type">The object type that can be found at the url..</param>
        public LinkDTO(string href = default(string), string type = default(string))
        {
            Href = href;
            Type = type;
        }

        /// <summary>
        ///     The url for the link.
        /// </summary>
        /// <value>The url for the link.</value>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public string Href { get; set; }

        /// <summary>
        ///     The object type that can be found at the url.
        /// </summary>
        /// <value>The object type that can be found at the url.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        ///     Returns true if LinkDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of LinkDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
            {
                return false;
            }

            return
                (
                    Href == other.Href ||
                    Href != null &&
                    Href.Equals(other.Href)
                ) &&
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                );
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkDTO {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as LinkDTO);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                var hash = 41;
                // Suitable nullity checks etc, of course :)
                if (Href != null)
                {
                    hash = hash * 59 + Href.GetHashCode();
                }
                if (Type != null)
                {
                    hash = hash * 59 + Type.GetHashCode();
                }
                return hash;
            }
        }
    }
}