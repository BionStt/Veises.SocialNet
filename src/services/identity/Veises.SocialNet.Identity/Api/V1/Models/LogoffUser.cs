﻿using System.ComponentModel.DataAnnotations;

namespace Veises.SocialNet.Identity.Api.V1.Models
{
    /// <summary>
    /// Logoff user model
    /// </summary>
    public sealed class LogoffUser
    {
        /// <summary>
        /// User unique identifier
        /// </summary>
        [Required]
        public UserUidInfo UserUidInfo { get; set; }
    }
}