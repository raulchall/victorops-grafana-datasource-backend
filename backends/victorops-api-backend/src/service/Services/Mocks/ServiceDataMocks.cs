using System;
using System.Collections.Generic;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi.Services
{
    public interface IServiceDataMocks
    {
        List<TeamDetail> Teams { get; }
        List<SimpleTeamDetail> SimpleTeams { get; }
        List<V1User> Users { get; }
        List<TeamMember> Members { get; }
        List<OnCallTeamsResource> OnCallTeams { get; }
    }
    
    public class ServiceDataMocks : IServiceDataMocks
    {
        public List<TeamDetail> Teams { get; }
        public List<SimpleTeamDetail> SimpleTeams { get; }
        public List<V1User> Users { get; }
        public List<TeamMember> Members { get; }
        public List<OnCallTeamsResource> OnCallTeams { get; }

        public ServiceDataMocks()
        {
            Teams = new List<TeamDetail>();
            SimpleTeams = new List<SimpleTeamDetail>();
            Users = new List<V1User>();
            Members = new List<TeamMember>();
            OnCallTeams = new List<OnCallTeamsResource>();

            InitializeTeams();
            InitializeSimpleTeams();
            InitializeUsers();
            InitializeMembers();
            InitializeOnCall();
        }

        private void InitializeOnCall()
        {
            var team1Users = new List<OnCallUsersResource>()
            {
                new OnCallUsersResource(new OnCallUsersResourceOnCallUser{
                    Username = "sdonald"
                }),
                new OnCallUsersResource(new OnCallUsersResourceOnCallUser{
                    Username = "kriddle"
                }),
                new OnCallUsersResource(new OnCallUsersResourceOnCallUser{
                    Username = "rchadwick"
                })
            };

            var teamAOnCall1 = new OnCallNowResource
            {
                EscalationPolicy = new OnCallEscalationPolicyResource
                {
                    Slug = "team-a-escalation-policy1",
                    Name = "team-a-escalation-policy1"
                },
                Users = team1Users
            };

            var teamAOnCall2 = new OnCallNowResource
            {
                EscalationPolicy = new OnCallEscalationPolicyResource
                {
                    Slug = "team-a-escalation-policy2",
                    Name = "team-a-escalation-policy2"
                },
                Users = team1Users
            };

            OnCallTeams.Add(new OnCallTeamsResource{
                Team = new OnCallTeamResource{
                    Slug = "team-a",
                    Name = "TeamA"
                },
                OnCallNow = new List<OnCallNowResource>()
                {
                    teamAOnCall1,
                    teamAOnCall2
                }
            });

            var team2Users = new List<OnCallUsersResource>()
            {
                new OnCallUsersResource(new OnCallUsersResourceOnCallUser{
                    Username = "sdonald"
                }),
                new OnCallUsersResource(new OnCallUsersResourceOnCallUser{
                    Username = "kriddle"
                })
            };

            var teamBOnCall = new OnCallNowResource
            {
                EscalationPolicy = new OnCallEscalationPolicyResource
                {
                    Slug = "team-b-escalation-policy1",
                    Name = "team-b-escalation-policy1"
                },
                Users = team2Users
            };

            OnCallTeams.Add(new OnCallTeamsResource{
                Team = new OnCallTeamResource{
                    Slug = "team-b",
                    Name = "TeamB"
                },
                OnCallNow = new List<OnCallNowResource>()
                {
                    teamBOnCall
                }
            });
        }

        private void InitializeSimpleTeams()
        {
            SimpleTeams.Add(new SimpleTeamDetail(){
                Slug = "team-a",
                Name = "TeamA"
            });

            SimpleTeams.Add(new SimpleTeamDetail(){
                Slug = "team-b",
                Name = "TeamB"
            });

            SimpleTeams.Add(new SimpleTeamDetail(){
                Slug = "team-c",
                Name = "TeamC"
            });
        }

        private void InitializeMembers()
        {
            Members.Add(new TeamMember(){
                Username = "sdonald",
                FirstName = "Subhan",
                LastName = "Donald",
                Verified = "true",
                Version = 1
            });

            Members.Add(new TeamMember(){
                Username = "kriddle",
                FirstName = "Katya",
                LastName = "Riddle",
                Verified = "true",
                Version = 1
            });

            Members.Add(new TeamMember(){
                Username = "rchadwick",
                FirstName = "Roan",
                LastName = "Chadwick",
                Verified = "true",
                Version = 1
            });
        }

        private void InitializeUsers()
        {
            Users.Add(new V1User(){
                Username = "sdonald",
                FirstName = "Subhan",
                LastName = "Donald",
                Email = "sdonald@domain.com",
                CreatedAt = DateTime.Now.ToString(),
                PasswordLastUpdated = DateTime.Now.ToString(),
                Verified = true
            });

            Users.Add(new V1User(){
                Username = "kriddle",
                FirstName = "Katya",
                LastName = "Riddle",
                Email = "kriddle@domain.com",
                CreatedAt = DateTime.Now.ToString(),
                PasswordLastUpdated = DateTime.Now.ToString(),
                Verified = true
            });

            Users.Add(new V1User(){
                Username = "rchadwick",
                FirstName = "Roan",
                LastName = "Chadwick",
                Email = "rchadwick@domain.com",
                CreatedAt = DateTime.Now.ToString(),
                PasswordLastUpdated = DateTime.Now.ToString(),
                Verified = true
            });
        }

        private void InitializeTeams()
        {
            Teams.Add(new TeamDetail(){
                Slug = "team-a",
                Name = "TeamA",
                MemberCount = 3,
                Version = 1,
                IsDefaultTeam = true
            });

            Teams.Add(new TeamDetail(){
                Slug = "team-b",
                Name = "TeamB",
                MemberCount = 2,
                Version = 1,
                IsDefaultTeam = true
            });

            Teams.Add(new TeamDetail(){
                Slug = "team-c",
                Name = "TeamC",
                MemberCount = 1,
                Version = 2,
                IsDefaultTeam = false
            });
        }
    }
}