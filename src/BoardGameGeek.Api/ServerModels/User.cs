namespace BoardGameGeek.Api.ServerModels
{
    public class User
    {
        public string id { get; set; }
        public string name { get; set; }
        public ValueAttribute firstname { get; set; }
        public ValueAttribute lastname { get; set; }
        public ValueAttribute avatarlink { get; set; }
        public ValueAttribute yearregistered { get; set; }
        public ValueAttribute lastlogin { get; set; }
        public ValueAttribute stateorprovince { get; set; }
        public ValueAttribute country { get; set; }
        public ValueAttribute webaddress { get; set; }
        public ValueAttribute xboxaccount { get; set; }
        public ValueAttribute wiiaccount { get; set; }
        public ValueAttribute psnaccount { get; set; }
        public ValueAttribute battlenetaccount { get; set; }
        public ValueAttribute steamaccount { get; set; }
        public ValueAttribute traderating { get; set; }
    }
}
