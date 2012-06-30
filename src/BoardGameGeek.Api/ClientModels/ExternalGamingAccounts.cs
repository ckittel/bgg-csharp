namespace BoardGameGeek.Api.ClientModels
{

    /// <summary>
    /// Represents the account names of the BGG Account on other, 3rd-party services.
    /// </summary>
    public class ExternalGamingAccounts
    {
        /// <summary>
        /// Gets or sets the user's XBox account name.  If there isn't one, this returns null.
        /// </summary>
        public string XBoxAccount { get; set; }

        /// <summary>
        /// Gets or sets the user's Wii account name.  If there isn't one, this returns null.
        /// </summary>
        public string WiiAccount { get; set; }

        /// <summary>
        /// Gets or sets the user's PlayStation Network (psn) account name.  If there isn't one, this returns null.
        /// </summary>
        public string PlayStationNetworkAccount { get; set; }

        /// <summary>
        /// Gets or sets the user's Battle.NET account name.  If there isn't one, this returns null.
        /// </summary>
        public string BattlenetAccount { get; set; }

        /// <summary>
        /// Gets or sets the user's Steam account name.  If there isn't one, this returns null.
        /// </summary>
        public string SteamAccount { get; set; }
    }
}
