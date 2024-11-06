using Microsoft.AspNetCore.Identity;
using PetsSocial.Data;
using PetsSocial.Data.ENum;
using PetsSocial.Models;
using System.Diagnostics;

namespace RunGroopWebApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Pets.Any())
                {
                    context.Pets.AddRange(new List<Pet>()
                    {
                        new Pet()
                        {
                            Name = "Sophie",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first cat",
                            PetType = PetType.Cat,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                PostCode = "NC"
                            }
                         },
                        new Pet()
                        {
                            Name = "Milly",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the second cat",
                            PetType = PetType.Cat,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                PostCode = "NC"
                            }
                         },
                        new Pet()
                        {
                            Name = "Keanu",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the third cat",
                            PetType = PetType.Cat,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                PostCode = "NC"
                            }
                         },
                        new Pet()
                        {
                            Name = "Paul",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the forth cat",
                            PetType = PetType.Cat,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                PostCode = "NC"
                            }
                         }
                    });
                    context.SaveChanges();
                }
                //Races
                if (!context.Meetups.Any())
                {
                    context.Meetups.AddRange(new List<Meetup>()
                    {
                        new Meetup()
                        {
                            Place = "My House",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first meetup point",
                            MeetupType = MeetupType.Casual,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                PostCode = "NC"
                            }
                        },
                        new Meetup()
                        {
                            Place = "My House",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first meetup point",
                            MeetupType = MeetupType.Casual,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                PostCode = "NC"
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        //public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {
        //        //Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //        //Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
        //        string adminUserEmail = "atticuskidc@gmail.com";

        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if (adminUser == null)
        //        {
        //            var newAdminUser = new AppUser()
        //            {
        //                UserName = "teddysmithdev",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }

        //        string appUserEmail = "user@etickets.com";

        //        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new AppUser()
        //            {
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }
        //    }
        //}
    }
}