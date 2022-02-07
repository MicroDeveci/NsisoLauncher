﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NsisoLauncherCore.Net.Apis.Modules.Yggdrasil.Requests
{
    public class AuthenticateRequest : UsernamePasswordPair
    {
        [JsonProperty("agent")]
        public Agent Agent { get; set; } = new Agent();

        [JsonProperty("clientToken")]
        public string ClientToken { get; set; }

        [JsonProperty("requestUser")]
        public bool RequestUser { get; set; }

        public AuthenticateRequest(string username, string password, string clientToken)
        {
            this.Username = username;
            this.Password = password;
            this.ClientToken = clientToken;
            this.RequestUser = true;
        }
        public AuthenticateRequest(string username, string password, string clientToken, bool requestUser)
        {
            this.Username = username;
            this.Password = password;
            this.ClientToken = clientToken;
            this.RequestUser = requestUser;
        }

        public AuthenticateRequest()
        {
            this.RequestUser = true;
        }
    }

    public class Agent
    {
        [JsonProperty("name")]
        public string Name { get; set; } = "Minecraft";

        [JsonProperty("version")]
        public int Version { get; set; } = 1;
    }
}
