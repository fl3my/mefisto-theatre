using MefistoTheatre.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MefistoTheatre.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Create roles.
            List<IdentityRole> roles = new()
            {
                new IdentityRole {Name = "Admin", NormalizedName = "ADMIN"},
                new IdentityRole {Name = "Editor", NormalizedName = "EDITOR"},
                new IdentityRole {Name = "Staff", NormalizedName = "STAFF"},
                new IdentityRole {Name = "Basic", NormalizedName = "BASIC"}
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);

            // Create users.
            List<ApplicationUser> users = new()
            {
                new ApplicationUser
                {
                    UserName = "admin@mefisto.com",
                    NormalizedUserName = "ADMIN@MEFISTO.COM",
                    Email = "admin@mefisto.com",
                    NormalizedEmail = "ADMIN@MEFISTO.COM",
                    EmailConfirmed = true,
                    FirstName = "Linus",
                    LastName = "Sebastian",
                    Address = "190 Cathedral St",
                    City = "Glasgow",
                    PostCode = "G4 0RF"


                },
                new ApplicationUser
                {
                    UserName = "editor@mefisto.com",
                    NormalizedUserName = "EDITOR@MEFISTO.COM",
                    Email = "editor@mefisto.com",
                    NormalizedEmail = "EDITOR@MEFISTO.COM",
                    EmailConfirmed = true,
                    FirstName = "Yvonne",
                    LastName = "Ho",
                    Address = "190 Cathedral St",
                    City = "Glasgow",
                    PostCode = "G4 0RF"
                },
                new ApplicationUser
                {
                    UserName = "staff@mefisto.com",
                    NormalizedUserName = "STAFF@MEFISTO.COM",
                    Email = "staff@mefisto.com",
                    NormalizedEmail = "STAFF@MEFISTO.COM",
                    EmailConfirmed = true,
                    FirstName = "Nick",
                    LastName = "Light",
                    Address = "190 Cathedral St",
                    City = "Glasgow",
                    PostCode = "G4 0RF"
                },
                new ApplicationUser
                {
                    UserName = "basic@basic.com",
                    NormalizedUserName = "BASIC@BASIC.COM",
                    Email = "basic@basic.com",
                    NormalizedEmail = "BASIC@BASIC.COM",
                    EmailConfirmed = true,
                    FirstName = "Colton",
                    LastName = "Potter",
                    Address = "190 Cathedral St",
                    City = "Glasgow",
                    PostCode = "G4 0RF"
                }
            };

            modelBuilder.Entity<ApplicationUser>().HasData(users);

            // Add hashed passwords to the users.
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Admin123!");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Editor123!");
            users[2].PasswordHash = passwordHasher.HashPassword(users[2], "Staff123!");
            users[3].PasswordHash = passwordHasher.HashPassword(users[3], "Basic123!");

            // Add the user to their role.
            List<IdentityUserRole<string>> userRoles = new()
            {
                new IdentityUserRole<string>
                {
                    UserId = users[0].Id,
                    RoleId = roles.First(r => r.Name == "Admin").Id
                },
                new IdentityUserRole<string>
                {
                    UserId = users[1].Id,
                    RoleId = roles.First(r => r.Name == "Editor").Id
                },
                new IdentityUserRole<string>
                {
                    UserId = users[2].Id,
                    RoleId = roles.First(r => r.Name == "Staff").Id
                },
                new IdentityUserRole<string>
                {
                    UserId = users[3].Id,
                    RoleId = roles.First(r => r.Name == "Basic").Id
                }
            };

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

            List<Category> categories = new()
            {
                new Category
                {
                    CategoryId = Guid.NewGuid().ToString(),
                    CategoryName = "Review"
                },
                new Category
                {
                    CategoryId = Guid.NewGuid().ToString(),
                    CategoryName = "Interview"
                },
                new Category
                {
                    CategoryId = Guid.NewGuid().ToString(),
                    CategoryName = "Announcements"
                },
                new Category
                {
                    CategoryId = Guid.NewGuid().ToString(),
                    CategoryName = "Features"
                }
            };

            modelBuilder.Entity<Category>().HasData(categories);

            List<Post> posts = new()
            {
                new Post
                {
                    PostId = Guid.NewGuid().ToString(),
                    Title = "REVIEW: Sleeping Beauty",
                    Summary = "Playwright Lewis Hetherington presents a refreshing new take on the traditional tale of Sleeping Beauty at Platform this Christmas.",
                    Content = "Playwright Lewis Hetherington presents a refreshing new take on the traditional tale of Sleeping Beauty at Platform this Christmas. Addressing the fact that in the regular re-telling poor beauty is either off stage or in her bed sleeping throughout most of the production. This time our “B” (Yolanda Mitchell) is a feisty teenager with an independent spirit, confined by her loving dad Jimmy (Irene Allan) (who loves to dress up and impersonate Elvis) to the family mattress shop, but B longs for bigger things and a world outside the four walls. She sneaks out every night to the local woods with her trusty dog Rocket (Itxaso Moreno) looking for adventure. There is, of course, a curse, but there’s a twist in the tale that you’ll have to go along and find out.\r\n\r\nThis is an atmospheric, engaging fairy tale where gripping storytelling is at the front and centre of the production. There are moments of real darkness and light throughout. There are also plenty of the usual panto tropes to satisfy the traditionalists: an evil queen (Jo Freer) and her sidekick (Julia Nsimba); a spooky forest; magical creatures; puns a-plenty.  It’s chock-full of familiar hits with cleverly re-written lyrics all sung by the hugely talented, fine-voiced cast. The cast are strong and cohesive and drive the action along. The fantastic set by Claire Halleran is relatively simplistic but fills the stage perfectly and looks gorgeously creepy. The set is also complemented by creative lighting by Michaella Fee. Lewis Heatherington’s Sleeping Beauty delivers throughout and serves us up the much-wanted happy ending.\r\n\r\nThe economical running time (just over an hour) is perfect to keep the tiniest audience members fully engaged and the ticket prices are affordably priced for many. This is (slightly non-) traditional storytelling at its best. Platform in Easterhouse is a true gem in the East End and the constant, consistently highly quality of their productions deserve to be seen by as wide an audience as possible, Sleeping Beauty is no exception.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    PublishedAt = DateTime.Now,
                    Status = Enums.PostStatus.Published,
                    CategoryId = categories[0].CategoryId,
                    AuthorId = users[0].Id
                },
                new Post
                {
                    PostId = Guid.NewGuid().ToString(),
                    Title = "REVIEW: The Book of Mormon – Theatre Royal, Glasgow",
                    Summary = "Trey Parker and Matt Stone’s musical satire on the Church of Jesus Christ of Latter-Day Saints, The Book of Mormon, is finally in Glasgow after a postponement due to a little thing called COVID.",
                    Content = "Trey Parker and Matt Stone’s musical satire on the Church of Jesus Christ of Latter-Day Saints, The Book of Mormon, is finally in Glasgow after a postponement due to a little thing called COVID.\r\n\r\nPremiering on Broadway in 2011, winning nine Tony Awards and after running in the West End for nearly a decade, its reputation precedes it, but you’d be wrong to judge without seeing for yourself. On the surface crude, cruel and pushing the envelope, it is certainly not for the easily offended, but dig a little deeper and it is so much more than that.\r\n\r\nTwo hapless, polar opposite LDS missionaries, the wide-eyed, idealistic Elder Price and the pathological liar Elder Cunningham, are sent on their two-year Mormon mission to a remote Ugandan village. Suffice it to say, the locals aren’t exactly welcoming them with open arms. Added to that there’s the AIDS crisis, famine, poverty and a despotic warlord for good measure. Of course, there are the inevitable ‘journeys’ everyone embarks on to find one’s true self, all done with a tongue planted firmly in the cheek.\r\n\r\nIt is a musical that heavily relies on shock and surprise, and it would be churlish to give away the funniest scenes. There are laughs on laughs and foot tapping tune after tune, all delivered by a knockout cast. Principal among them are Conner Peirson as Elder Cunningham, who steals every scene he’s in; the beautiful-voiced Aviva Tulley as Nabulungi and Jordan Lee Davies wrestling gloriously with his homosexual urges as Elder McKinley.\r\n\r\nIt’s clear that the whole thing has been written with affection by Parker and Stone and of course, musical theatre royalty Robert Lopez (Avenue Q, Frozen, Coco) there is no way that it could get away with what it does, if it were purely cruel rather than impressively clever.\r\n\r\nIt is a giant juggernaut of a show and serves up a slice of unashamed satire that’s much needed in our easily offended world. If you needed any other reason to see it, ask yourself where else will you see Genghis Khan playing guitar with the Devil onstage in Glasgow on a weekday night?",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    PublishedAt = DateTime.Now,
                    Status = Enums.PostStatus.Published,
                    CategoryId = categories[0].CategoryId,
                    AuthorId = users[1].Id
                },
                new Post
                {
                    PostId = Guid.NewGuid().ToString(),
                    Title = "The Birds and The Bees starring Helen Lederer & Michael Starke visits Glasgow",
                    Summary = "With Spring just around the corner, the UK tour of comedy The Birds and the Bees,  starring Helen Lederer and Michael Starke has announced it will visit Glasgow.",
                    Content = "With Spring just around the corner, the UK tour of comedy The Birds and the Bees,  starring Helen Lederer and Michael Starke has announced it will visit Glasgow.\r\n\r\nOn Sarah’s East Anglian farm, the honeybees are dropping like flies – just like her love life. She hasn’t slept with anyone since her husband bolted years ago. Her daughter’s marriage is going bust just like her turkey farm. Neighbour Earl is fighting a losing battle with his sugar beet yield and his ‘no strings’ relationships. Can bio-student Ben perk up the pollinators and give the turkeys a helping hand? Perhaps all they need is some local mead and the annual Turkey Day’s Dance to help them discover that the best way out of a crisis is to commit to those closest to you. Just don’t get stung!\r\n\r\nThe comedy written by Mark Crawford has been reimagined for a UK audience, relocating the play from modern-day Canada to Norfolk with additional material by James McDermott .\r\n\r\nHelen Lederer is best known for her role as the dippy Catriona in ‘Absolutely Fabulous’. Helen was part of a group of early 1980’s comedians, including Dawn French, Jennifer Saunders, the late Rik Mayall and Ben Elton who made their names at London’s Comedy Store and continues to perform her on stand up to this day.\r\n\r\nHer vast appearances on TV include ‘The Young Ones’, ‘French and Saunders’, ‘Happy Families’, ‘One Foot in the Grave’, ‘Bottom’, ‘Love Soup’ and ‘Miss Marple’ among many more.  A comedy writer with an extensive portfolio, Helen is a regular panellist on radio on shows such as ‘The News Quiz’, ‘Just a Minute’, ‘Quote…Unquote’, ‘A Good Read’, ‘Open Book’ and ‘Woman’s Hour’ as well as a prolific columnist.  Theatre work includes ‘Educating Rita’, and Alan Bleasdale’s ‘Having a Ball’. She has been in ‘The Vagina Monologues’, ‘Calendar Girls’, and ‘The Killing of Sister George’, in London’s West End.\r\n\r\nMichael Starke remains universally known and loved for creating the role of Thomas ‘Sinbad’ Sweeney in Channel 4’s Brookside, a loveable rogue role he was to play for sixteen years. Michael’s countless further TV appearances include ITV’s ‘The Royal’ and ‘Coronation Street’ and on the BBC ‘Stig of the Dump’, ‘Casualty’,  ‘Benidorm’, ‘Holby City’, ‘Moving On’ and ‘The Responder‘. He also appeared in ‘The Virtues’ on Channel 4 and ‘Tin Star ‘ on Sky Atlantic.\r\n\r\nMichael has also become well known as a leading actor in musical and plays, both in the West End and in theatres across the country. His theatre credits include White Christmas, Waitress, Sister Act, Hairspray, The Rocky Horror Show, Bouncers, The Play What I Wrote and Hamlet.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    PublishedAt = DateTime.Now,
                    Status = Enums.PostStatus.Published,
                    CategoryId = categories[2].CategoryId,
                    AuthorId = users[1].Id
                },
                new Post
                {
                    PostId = Guid.NewGuid().ToString(),
                    Title = "WHAT’S ON – Movies to Musicals at the Theatre Royal this Sunday",
                    Summary = "Movies to Musicals is coming to the Theatre Royal, Glasgow this Sunday 19th Feb at 7.30pm.",
                    Content = "Movies to Musicals is coming to the Theatre Royal, Glasgow this Sunday 19th Feb at 7.30pm.\r\nIt features West End stars Laura Pick, Louise Dearman and Alistair Brammer as guest artists, a live orchestra, and young cast of 40 from all over Scotland\r\nFeaturing your favourite Musicals soundtracks such as Wicked, The Prom, Jersey Boys, Funny Girl, Six, Miss Saigon and many many more it is a must see for fans of musical theatre.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    PublishedAt = DateTime.Now,
                    Status = Enums.PostStatus.Published,
                    CategoryId = categories[3].CategoryId,
                    AuthorId = users[2].Id
                }
            };

            modelBuilder.Entity<Post>().HasData(posts);
        }
    }
}
