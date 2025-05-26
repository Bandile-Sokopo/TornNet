using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Core.Models.User
{
    public class User
    {
        [JsonProperty("rank")]
        string Rank;
        [JsonProperty("level")]
        int Level;
        [JsonProperty("honor")]
        int Honor;
        [JsonProperty("gender")]
        string Gender;
        [JsonProperty("property")]
        string Property;
        [JsonProperty("signup")]
        string Signup;
        [JsonProperty("awards")]
        int Awards;
        [JsonProperty("friends")]
        int Friends;
        [JsonProperty("enemies")]
        int Enemies;
        [JsonProperty("forum_posts")]
        int ForumPosts;
        [JsonProperty("karma")]
        int Karma;
        [JsonProperty("age")]
        int Age;
        [JsonProperty("role")]
        string Role;
        [JsonProperty("donator")]
        int Donator;
        [JsonProperty("player_id")]
        int PlayerId;
        [JsonProperty("name")]
        string name;
        [JsonProperty("revivable")]
        int Revivable;
        [JsonProperty("profile_image")]
        string ProfileImage;
        [JsonProperty("life")]
        Life Life;
        [JsonProperty("status")]
        Status Status;
        [JsonProperty("job")]
        Job Job;
        [JsonProperty("faction")]
        Faction Faction;
        [JsonProperty("married")]
        Married Married;
        [JsonProperty("states")]
        States States;
        [JsonProperty("last_action")]
        LastAction LastAction;
        [JsonProperty("competition")]
        Competition Competition;

    }
    public class Life
    {
        [JsonProperty("current")]
        int Current;
        [JsonProperty("maximum")]
        int Maximum;
        [JsonProperty("increment")]
        int Increment;
        [JsonProperty("interval")]
        int Interval;
        [JsonProperty("ticktime")]
        int TickTime;
        [JsonProperty("fulltime")]
        int FullTime;
    }
    public class Status
    {
        [JsonProperty("description")]
        string Description;
        [JsonProperty("details")]
        string Details;
        [JsonProperty("state")]
        string State;
        [JsonProperty("color")]
        string Color;
        [JsonProperty("until")]
        string Until;
    }
    public class Job
    {
        [JsonProperty("job")]
        string JobTitle;
        [JsonProperty("position")]
        string Position;
        [JsonProperty("company_id")]
        int CompanyId;
        [JsonProperty("company_name")]
        string CompanyName;
        [JsonProperty("company_type")]
        int CompanyType;
    }
    public class Faction
    {
        [JsonProperty("position")]
        string Position;
        [JsonProperty("faction_id")]
        int FactionId;
        [JsonProperty("days_in_faction")]
        int DaysInFaction;
        [JsonProperty("faction_name")]
        string FactionName;
        [JsonProperty("faction_tag")]
        string FactionTag;
        [JsonProperty("faction_tag_image")]
        string FactionTagImage;
    }
    public class Married
    {
        [JsonProperty("spouse_id")]
        int SpouseId;
        [JsonProperty("spouse_name")]
        string SpouseName;
        [JsonProperty("duration")]
        int Duration;
    }
    public class States
    {
        [JsonProperty("hospital_timestamp")]
        string HospitalTimestamp;
        [JsonProperty("jail_timestamp")]
        string JailTimestamp;
    }
    public class LastAction
    {
        [JsonProperty("status")]
        string Status;
        [JsonProperty("timestamp")]
        string Timestamp;
        [JsonProperty("relative")]
        string Relative;
    }
    public class Competition
    {
        [JsonProperty("name")]
        string Name;
        [JsonProperty("status")]
        string Status;
        [JsonProperty("current_hp")]
        string CurrentHp;
        [JsonProperty("max_hp")]
        string MaxHp;
    }
}