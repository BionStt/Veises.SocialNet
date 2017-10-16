// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veises.SocialNet.Identity.Contracts.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// User identity
    /// </summary>
    public partial class UpdateUserIdentity
    {
        /// <summary>
        /// Initializes a new instance of the UpdateUserIdentity class.
        /// </summary>
        public UpdateUserIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateUserIdentity class.
        /// </summary>
        /// <param name="userName">User display name</param>
        public UpdateUserIdentity(string userName)
        {
            UserName = userName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user display name
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UserName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserName");
            }
            if (UserName != null)
            {
                if (UserName.Length > 25)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "UserName", 25);
                }
                if (UserName.Length < 25)
                {
                    throw new ValidationException(ValidationRules.MinLength, "UserName", 25);
                }
            }
        }
    }
}
