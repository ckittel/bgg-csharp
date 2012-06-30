using System;

namespace BoardGameGeek.Api.ClientModels
{
    /// <summary>
    /// Represents public information about a user profile.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        public Account()
        {
            ExternalGamingAccounts = new ExternalGamingAccounts();
            YearRegistered = null;
        }

        /// <summary>
        /// Gets or sets the unique ID of the user.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the user's first name.  If it's not known, this returns null.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the user's last name.  If it's not known, this returns null.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the user's avatar link.  If there isn't one, this returns null.
        /// </summary>
        public Uri AvatarUrl { get; set; }

        /// <summary>
        /// Gets or sets the year in which the account was created.  If it's not known, this returns null.
        /// </summary>
        public short? YearRegistered { get; set; }

        /// <summary>
        /// Gets or sets the user's state or province.  If it's not known, this returns null.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the user's country.  If it's not known, this returns null.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the user's personal website (not their profile address).  If there isn't one, this returns null.
        /// </summary>
        public Uri WebsiteUrl { get; set; }

        /// <summary>
        /// Gets or sets the user's trader rating.
        /// </summary>
        public short TraderRating { get; set; }

        /// <summary>
        /// Gets information about external, 3rd-party gaming accounts the user as associated with their account.
        /// </summary>
        public ExternalGamingAccounts ExternalGamingAccounts { get; private set; }

    }
}
