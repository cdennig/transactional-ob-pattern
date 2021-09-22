namespace Contacts.Tests.TestInfra
{
    public class ContactsTestFixture
    {
        public string JsonObject { get; }

        public ContactsTestFixture()
        {
            JsonObject = @"
                {
                    ""name"": {
                        ""firstName"": ""Bertram"",
                        ""lastName"": ""Gilfoyle""
                    },
                    ""description"": ""This is a description"",
                    ""email"": ""bg@piedpiper.com"",
                    ""company"": {
                        ""companyName"": ""Pied Piper"",
                        ""street"": ""Street"",
                        ""houseNumber"": ""1a"",
                        ""postalCode"": ""092821"",
                        ""city"": ""Palo Alto"",
                        ""country"": ""US""
                    },
                    ""id"": ""0001f5bb-d4a9-48ba-af80-3db52bfd7411""
                }";
        }
    }
}