using Spordiklubi_haldus.Models;

namespace Spordiklubi_haldus.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SpordiklubiHaldusContext context)
        {
           
            context.Database.EnsureCreated();

            
            if (context.Members.Any())
            {
                return;
            }

            var sports = new Sport[]
            {
                new Sport
                {
                    Name = "Basketball",
                    Description = "Basketball training"
                },

                new Sport
                {
                    Name = "Football",
                    Description = "Football training"
                },

                new Sport
                {
                    Name = "Gym",
                    Description = "Strength training"
                },

                new Sport
                {
                    Name = "Volleyball",
                    Description = "Volleyball training"
                }
            };

            foreach (Sport sport in sports)
            {
                context.Sports.Add(sport);
            }

            context.SaveChanges();

            var members = new Member[]
            {
                new Member
                {
                    FirstName = "Toomas",
                    LastName = "Loss",
                    JoinDate = new DateTime(2026, 1, 10)
                },

                new Member
                {
                    FirstName = "Martin",
                    LastName = "Kask",
                    JoinDate = new DateTime(2026, 2, 15)
                },

                new Member
                {
                    FirstName = "Kevin",
                    LastName = "Saar",
                    JoinDate = new DateTime(2026, 3, 1)
                },

                new Member
                {
                    FirstName = "Laura",
                    LastName = "Tamm",
                    JoinDate = new DateTime(2026, 3, 20)
                }
            };

            foreach (Member member in members)
            {
                context.Members.Add(member);
            }

            context.SaveChanges();

            var memberships = new Membership[]
            {
                new Membership
                {
                    MembershipType = "Monthly",
                    StartDate = new DateTime(2026, 6, 1),
                    ExpiryDate = new DateTime(2026, 7, 1),
                    MemberId = members[0].Id
                },

                new Membership
                {
                    MembershipType = "Yearly",
                    StartDate = new DateTime(2026, 1, 10),
                    ExpiryDate = new DateTime(2027, 1, 10),
                    MemberId = members[1].Id
                },

                new Membership
                {
                    MembershipType = "Three months",
                    StartDate = new DateTime(2026, 5, 1),
                    ExpiryDate = new DateTime(2026, 8, 1),
                    MemberId = members[2].Id
                },

                new Membership
                {
                    MembershipType = "Monthly",
                    StartDate = new DateTime(2026, 6, 5),
                    ExpiryDate = new DateTime(2026, 7, 5),
                    MemberId = members[3].Id
                }
            };

            foreach (Membership membership in memberships)
            {
                context.Memberships.Add(membership);
            }

            context.SaveChanges();

            var trainings = new Training[]
            {
                new Training
                {
                    Name = "Basketball Beginners",
                    TrainingDate = new DateTime(2026, 6, 10, 16, 0, 0),
                    MaximumMembers = 20,
                    SportId = sports[0].Id
                },

                new Training
                {
                    Name = "Football Training",
                    TrainingDate = new DateTime(2026, 6, 11, 17, 0, 0),
                    MaximumMembers = 22,
                    SportId = sports[1].Id
                },

                new Training
                {
                    Name = "Strength Training",
                    TrainingDate = new DateTime(2026, 6, 12, 18, 0, 0),
                    MaximumMembers = 15,
                    SportId = sports[2].Id
                },

                new Training
                {
                    Name = "Volleyball Training",
                    TrainingDate = new DateTime(2026, 6, 13, 16, 30, 0),
                    MaximumMembers = 18,
                    SportId = sports[3].Id
                }
            };

            foreach (Training training in trainings)
            {
                context.Trainings.Add(training);
            }

            context.SaveChanges();

            var registrations = new Registration[]
            {
                new Registration
                {
                    MemberId = members[0].Id,
                    TrainingId = trainings[0].Id,
                    RegistrationDate = new DateTime(2026, 6, 1)
                },

                new Registration
                {
                    MemberId = members[0].Id,
                    TrainingId = trainings[2].Id,
                    RegistrationDate = new DateTime(2026, 6, 1)
                },

                new Registration
                {
                    MemberId = members[1].Id,
                    TrainingId = trainings[1].Id,
                    RegistrationDate = new DateTime(2026, 6, 2)
                },

                new Registration
                {
                    MemberId = members[2].Id,
                    TrainingId = trainings[2].Id,
                    RegistrationDate = new DateTime(2026, 6, 3)
                },

                new Registration
                {
                    MemberId = members[3].Id,
                    TrainingId = trainings[3].Id,
                    RegistrationDate = new DateTime(2026, 6, 4)
                }
            };

            foreach (Registration registration in registrations)
            {
                context.Registrations.Add(registration);
            }

            context.SaveChanges();
        }
    }
}