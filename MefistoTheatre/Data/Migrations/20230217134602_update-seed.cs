using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MefistoTheatre.Data.Migrations
{
    public partial class updateseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33d6329f-cd13-4929-90d2-0a3c8015e78e", "39738235-8493-453a-abea-2573efe727c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9216d8dc-d1cb-4768-946b-a6aae076b053", "634824c3-1db4-4c59-af21-80267fa7ae00" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6df28832-7c96-4e04-96a0-0cda4e2bba0b", "77e8fe47-ad47-44b9-8fe7-d7398f98c80e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11954cc1-242b-46be-a16c-0c8a1db982ea", "bfd81596-d4c7-4236-9112-1dab11048210" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "264cc9f6-718e-422b-9233-c011ca3f12b0");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "42b7c00a-47e7-406e-9842-5b85abc26f75");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "a7df97b7-2a7a-4a42-99ea-ff8221ee2eb3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "de0256b1-9592-49f9-a33e-87b10fd5da20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11954cc1-242b-46be-a16c-0c8a1db982ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33d6329f-cd13-4929-90d2-0a3c8015e78e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6df28832-7c96-4e04-96a0-0cda4e2bba0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9216d8dc-d1cb-4768-946b-a6aae076b053");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39738235-8493-453a-abea-2573efe727c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634824c3-1db4-4c59-af21-80267fa7ae00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77e8fe47-ad47-44b9-8fe7-d7398f98c80e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfd81596-d4c7-4236-9112-1dab11048210");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0081cd3f-a779-439c-bfe5-e0275a6bbf66", "4431d9be-af06-4f85-9c68-dda45edc2576", "Staff", "STAFF" },
                    { "84ac499f-c2dc-42cc-b555-61f757baa661", "2b28c36d-9eb1-4c2c-8d63-11b84a556091", "Basic", "BASIC" },
                    { "ae8d2b70-31f0-4ac9-9bc6-42e2596657ad", "9232ae71-e0a7-4161-b5ad-0815e5ef6ed3", "Editor", "EDITOR" },
                    { "f67a397f-85b9-4f58-a61e-98f8128e489c", "0b9cb408-3d83-4eb6-a777-05eb9997b4de", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "IsSuspended", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "69794e18-dd2e-4e63-a10f-205161b6b741", 0, "190 Cathedral St", "Glasgow", "bccc801f-353e-4aa1-8ba0-d0df287597ec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "editor@mefisto.com", true, "Yvonne", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ho", false, null, "EDITOR@MEFISTO.COM", "EDITOR@MEFISTO.COM", "AQAAAAEAACcQAAAAEDmx2KdfyhWT651CjbuxI97N0mpFEWq2ImvMRUYA6Q45HoDb3M3FgZUWOaX5HM/zBw==", null, false, "G4 0RF", "9e29d876-4c7b-442d-b7ad-583c910dd2aa", false, "editor@mefisto.com" },
                    { "75a961fa-a979-48fb-8a89-bc43dda32e5d", 0, "190 Cathedral St", "Glasgow", "24f2ef13-5fda-4115-bd7b-5b0db6e8b783", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@mefisto.com", true, "Nick", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Light", false, null, "STAFF@MEFISTO.COM", "STAFF@MEFISTO.COM", "AQAAAAEAACcQAAAAEKDtqNIuOwiEZ1dNioNvXZETHpWRBgkwFKQNw4dEn1+0gneNJd4EydtjUKp+oaUYUQ==", null, false, "G4 0RF", "c43cbbde-69ea-4ad9-aa22-9030fa99cd35", false, "staff@mefisto.com" },
                    { "dec84dbb-8177-4dff-b954-27505625ba38", 0, "190 Cathedral St", "Glasgow", "50572e85-684c-4b1d-925c-65fbecb4d3d4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mefisto.com", true, "Linus", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sebastian", false, null, "ADMIN@MEFISTO.COM", "ADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAELc9GxTqOVw9WL2zUxRoq3lI9lvX+fw8gk30e2198Q1qS6cVp73A6CVP4sbF7lyQ7A==", null, false, "G4 0RF", "7db1db1b-8e36-4c8e-9fef-3d67e7bc16c6", false, "admin@mefisto.com" },
                    { "f56e194b-c288-45b0-9de2-5f0b75c128ee", 0, "190 Cathedral St", "Glasgow", "0dc70060-71ee-4eb9-8dc0-d42603461042", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@basic.com", true, "Colton", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potter", false, null, "BASIC@BASIC.COM", "BASIC@BASIC.COM", "AQAAAAEAACcQAAAAEDpf3e3X52Og/dLsuaxCK8hJSpNA+VQHTObssY97ONaGhSEMZDvItZIXXEKxCMdXvg==", null, false, "G4 0RF", "6496a526-d2a8-4a6e-b9b8-d106a73a173a", false, "basic@basic.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "22f1587d-f948-4efb-abd4-b9a7f950b36d", "Review" },
                    { "77b33672-dedb-4fdd-9f83-69a225759a4b", "Features" },
                    { "a0c33779-343c-4964-ad3d-06cd43a8146a", "Interview" },
                    { "dcd5ba10-e5fa-4e8d-b57d-609eacf4bd44", "Announcements" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ae8d2b70-31f0-4ac9-9bc6-42e2596657ad", "69794e18-dd2e-4e63-a10f-205161b6b741" },
                    { "0081cd3f-a779-439c-bfe5-e0275a6bbf66", "75a961fa-a979-48fb-8a89-bc43dda32e5d" },
                    { "f67a397f-85b9-4f58-a61e-98f8128e489c", "dec84dbb-8177-4dff-b954-27505625ba38" },
                    { "84ac499f-c2dc-42cc-b555-61f757baa661", "f56e194b-c288-45b0-9de2-5f0b75c128ee" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AuthorId", "CategoryId", "Content", "CreatedDate", "PublishedAt", "Status", "Summary", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { "42d203c7-fdb5-4042-8c8c-3ee7282094cf", "69794e18-dd2e-4e63-a10f-205161b6b741", "22f1587d-f948-4efb-abd4-b9a7f950b36d", "Trey Parker and Matt Stone’s musical satire on the Church of Jesus Christ of Latter-Day Saints, The Book of Mormon, is finally in Glasgow after a postponement due to a little thing called COVID.\r\n\r\nPremiering on Broadway in 2011, winning nine Tony Awards and after running in the West End for nearly a decade, its reputation precedes it, but you’d be wrong to judge without seeing for yourself. On the surface crude, cruel and pushing the envelope, it is certainly not for the easily offended, but dig a little deeper and it is so much more than that.\r\n\r\nTwo hapless, polar opposite LDS missionaries, the wide-eyed, idealistic Elder Price and the pathological liar Elder Cunningham, are sent on their two-year Mormon mission to a remote Ugandan village. Suffice it to say, the locals aren’t exactly welcoming them with open arms. Added to that there’s the AIDS crisis, famine, poverty and a despotic warlord for good measure. Of course, there are the inevitable ‘journeys’ everyone embarks on to find one’s true self, all done with a tongue planted firmly in the cheek.\r\n\r\nIt is a musical that heavily relies on shock and surprise, and it would be churlish to give away the funniest scenes. There are laughs on laughs and foot tapping tune after tune, all delivered by a knockout cast. Principal among them are Conner Peirson as Elder Cunningham, who steals every scene he’s in; the beautiful-voiced Aviva Tulley as Nabulungi and Jordan Lee Davies wrestling gloriously with his homosexual urges as Elder McKinley.\r\n\r\nIt’s clear that the whole thing has been written with affection by Parker and Stone and of course, musical theatre royalty Robert Lopez (Avenue Q, Frozen, Coco) there is no way that it could get away with what it does, if it were purely cruel rather than impressively clever.\r\n\r\nIt is a giant juggernaut of a show and serves up a slice of unashamed satire that’s much needed in our easily offended world. If you needed any other reason to see it, ask yourself where else will you see Genghis Khan playing guitar with the Devil onstage in Glasgow on a weekday night?", new DateTime(2023, 2, 17, 13, 46, 1, 595, DateTimeKind.Local).AddTicks(3165), new DateTime(2023, 2, 17, 13, 46, 1, 595, DateTimeKind.Local).AddTicks(3169), 2, "Trey Parker and Matt Stone’s musical satire on the Church of Jesus Christ of Latter-Day Saints, The Book of Mormon, is finally in Glasgow after a postponement due to a little thing called COVID.", "REVIEW: The Book of Mormon – Theatre Royal, Glasgow", new DateTime(2023, 2, 17, 13, 46, 1, 595, DateTimeKind.Local).AddTicks(3167) },
                    { "578e47de-399d-4e6d-875e-5b7ad7d5573a", "69794e18-dd2e-4e63-a10f-205161b6b741", "dcd5ba10-e5fa-4e8d-b57d-609eacf4bd44", "With Spring just around the corner, the UK tour of comedy The Birds and the Bees,  starring Helen Lederer and Michael Starke has announced it will visit Glasgow.\r\n\r\nOn Sarah’s East Anglian farm, the honeybees are dropping like flies – just like her love life. She hasn’t slept with anyone since her husband bolted years ago. Her daughter’s marriage is going bust just like her turkey farm. Neighbour Earl is fighting a losing battle with his sugar beet yield and his ‘no strings’ relationships. Can bio-student Ben perk up the pollinators and give the turkeys a helping hand? Perhaps all they need is some local mead and the annual Turkey Day’s Dance to help them discover that the best way out of a crisis is to commit to those closest to you. Just don’t get stung!\r\n\r\nThe comedy written by Mark Crawford has been reimagined for a UK audience, relocating the play from modern-day Canada to Norfolk with additional material by James McDermott .\r\n\r\nHelen Lederer is best known for her role as the dippy Catriona in ‘Absolutely Fabulous’. Helen was part of a group of early 1980’s comedians, including Dawn French, Jennifer Saunders, the late Rik Mayall and Ben Elton who made their names at London’s Comedy Store and continues to perform her on stand up to this day.\r\n\r\nHer vast appearances on TV include ‘The Young Ones’, ‘French and Saunders’, ‘Happy Families’, ‘One Foot in the Grave’, ‘Bottom’, ‘Love Soup’ and ‘Miss Marple’ among many more.  A comedy writer with an extensive portfolio, Helen is a regular panellist on radio on shows such as ‘The News Quiz’, ‘Just a Minute’, ‘Quote…Unquote’, ‘A Good Read’, ‘Open Book’ and ‘Woman’s Hour’ as well as a prolific columnist.  Theatre work includes ‘Educating Rita’, and Alan Bleasdale’s ‘Having a Ball’. She has been in ‘The Vagina Monologues’, ‘Calendar Girls’, and ‘The Killing of Sister George’, in London’s West End.\r\n\r\nMichael Starke remains universally known and loved for creating the role of Thomas ‘Sinbad’ Sweeney in Channel 4’s Brookside, a loveable rogue role he was to play for sixteen years. Michael’s countless further TV appearances include ITV’s ‘The Royal’ and ‘Coronation Street’ and on the BBC ‘Stig of the Dump’, ‘Casualty’,  ‘Benidorm’, ‘Holby City’, ‘Moving On’ and ‘The Responder‘. He also appeared in ‘The Virtues’ on Channel 4 and ‘Tin Star ‘ on Sky Atlantic.\r\n\r\nMichael has also become well known as a leading actor in musical and plays, both in the West End and in theatres across the country. His theatre credits include White Christmas, Waitress, Sister Act, Hairspray, The Rocky Horror Show, Bouncers, The Play What I Wrote and Hamlet.", new DateTime(2023, 2, 17, 13, 46, 1, 595, DateTimeKind.Local).AddTicks(3177), new DateTime(2023, 2, 17, 13, 46, 1, 595, DateTimeKind.Local).AddTicks(3181), 2, "With Spring just around the corner, the UK tour of comedy The Birds and the Bees,  starring Helen Lederer and Michael Starke has announced it will visit Glasgow.", "The Birds and The Bees starring Helen Lederer & Michael Starke visits Glasgow", new DateTime(2023, 2, 17, 13, 46, 1, 595, DateTimeKind.Local).AddTicks(3179) },
                    { "8e3257ab-bdc7-4a48-bae2-2ab275541105", "dec84dbb-8177-4dff-b954-27505625ba38", "22f1587d-f948-4efb-abd4-b9a7f950b36d", "Playwright Lewis Hetherington presents a refreshing new take on the traditional tale of Sleeping Beauty at Platform this Christmas. Addressing the fact that in the regular re-telling poor beauty is either off stage or in her bed sleeping throughout most of the production. This time our “B” (Yolanda Mitchell) is a feisty teenager with an independent spirit, confined by her loving dad Jimmy (Irene Allan) (who loves to dress up and impersonate Elvis) to the family mattress shop, but B longs for bigger things and a world outside the four walls. She sneaks out every night to the local woods with her trusty dog Rocket (Itxaso Moreno) looking for adventure. There is, of course, a curse, but there’s a twist in the tale that you’ll have to go along and find out.\r\n\r\nThis is an atmospheric, engaging fairy tale where gripping storytelling is at the front and centre of the production. There are moments of real darkness and light throughout. There are also plenty of the usual panto tropes to satisfy the traditionalists: an evil queen (Jo Freer) and her sidekick (Julia Nsimba); a spooky forest; magical creatures; puns a-plenty.  It’s chock-full of familiar hits with cleverly re-written lyrics all sung by the hugely talented, fine-voiced cast. The cast are strong and cohesive and drive the action along. The fantastic set by Claire Halleran is relatively simplistic but fills the stage perfectly and looks gorgeously creepy. The set is also complemented by creative lighting by Michaella Fee. Lewis Heatherington’s Sleeping Beauty delivers throughout and serves us up the much-wanted happy ending.\r\n\r\nThe economical running time (just over an hour) is perfect to keep the tiniest audience members fully engaged and the ticket prices are affordably priced for many. This is (slightly non-) traditional storytelling at its best. Platform in Easterhouse is a true gem in the East End and the constant, consistently highly quality of their productions deserve to be seen by as wide an audience as possible, Sleeping Beauty is no exception.", new DateTime(2023, 2, 17, 13, 46, 1, 595, DateTimeKind.Local).AddTicks(3105), new DateTime(2023, 2, 17, 13, 46, 1, 595, DateTimeKind.Local).AddTicks(3151), 2, "Playwright Lewis Hetherington presents a refreshing new take on the traditional tale of Sleeping Beauty at Platform this Christmas.", "REVIEW: Sleeping Beauty", new DateTime(2023, 2, 17, 13, 46, 1, 595, DateTimeKind.Local).AddTicks(3149) },
                    { "e507bcf8-b545-47fe-b6aa-f968e2cdea5e", "75a961fa-a979-48fb-8a89-bc43dda32e5d", "77b33672-dedb-4fdd-9f83-69a225759a4b", "Movies to Musicals is coming to the Theatre Royal, Glasgow this Sunday 19th Feb at 7.30pm.\r\nIt features West End stars Laura Pick, Louise Dearman and Alistair Brammer as guest artists, a live orchestra, and young cast of 40 from all over Scotland\r\nFeaturing your favourite Musicals soundtracks such as Wicked, The Prom, Jersey Boys, Funny Girl, Six, Miss Saigon and many many more it is a must see for fans of musical theatre.", new DateTime(2023, 2, 17, 13, 46, 1, 595, DateTimeKind.Local).AddTicks(3187), new DateTime(2023, 2, 17, 13, 46, 1, 595, DateTimeKind.Local).AddTicks(3191), 2, "Movies to Musicals is coming to the Theatre Royal, Glasgow this Sunday 19th Feb at 7.30pm.", "WHAT’S ON – Movies to Musicals at the Theatre Royal this Sunday", new DateTime(2023, 2, 17, 13, 46, 1, 595, DateTimeKind.Local).AddTicks(3189) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ae8d2b70-31f0-4ac9-9bc6-42e2596657ad", "69794e18-dd2e-4e63-a10f-205161b6b741" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0081cd3f-a779-439c-bfe5-e0275a6bbf66", "75a961fa-a979-48fb-8a89-bc43dda32e5d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f67a397f-85b9-4f58-a61e-98f8128e489c", "dec84dbb-8177-4dff-b954-27505625ba38" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84ac499f-c2dc-42cc-b555-61f757baa661", "f56e194b-c288-45b0-9de2-5f0b75c128ee" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "a0c33779-343c-4964-ad3d-06cd43a8146a");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "42d203c7-fdb5-4042-8c8c-3ee7282094cf");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "578e47de-399d-4e6d-875e-5b7ad7d5573a");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "8e3257ab-bdc7-4a48-bae2-2ab275541105");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "e507bcf8-b545-47fe-b6aa-f968e2cdea5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0081cd3f-a779-439c-bfe5-e0275a6bbf66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84ac499f-c2dc-42cc-b555-61f757baa661");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae8d2b70-31f0-4ac9-9bc6-42e2596657ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67a397f-85b9-4f58-a61e-98f8128e489c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69794e18-dd2e-4e63-a10f-205161b6b741");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75a961fa-a979-48fb-8a89-bc43dda32e5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dec84dbb-8177-4dff-b954-27505625ba38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f56e194b-c288-45b0-9de2-5f0b75c128ee");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "22f1587d-f948-4efb-abd4-b9a7f950b36d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "77b33672-dedb-4fdd-9f83-69a225759a4b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "dcd5ba10-e5fa-4e8d-b57d-609eacf4bd44");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11954cc1-242b-46be-a16c-0c8a1db982ea", "cc424228-edb2-43f5-b1c6-62cd39f7cfdd", "Admin", "ADMIN" },
                    { "33d6329f-cd13-4929-90d2-0a3c8015e78e", "97488b4e-387b-40e6-9976-c3d6dff9909b", "Staff", "STAFF" },
                    { "6df28832-7c96-4e04-96a0-0cda4e2bba0b", "9314d068-4a43-4244-8381-6b6b45e20576", "Editor", "EDITOR" },
                    { "9216d8dc-d1cb-4768-946b-a6aae076b053", "74478cd8-8451-434e-8cfe-54b630b465c3", "Basic", "BASIC" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "IsSuspended", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "39738235-8493-453a-abea-2573efe727c4", 0, null, null, "6dc48fd0-cb43-4247-935d-448ececf6ffc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "STAFF@MEFISTO.COM", "STAFF@MEFISTO.COM", "AQAAAAEAACcQAAAAEPmoCw/KrkQHB5MW2623ybwN1iuOeQrku2JlqfrLAsx2vwQovXbb8eHSMgeqAyvJpA==", null, false, null, "281b6051-f9f1-49f3-9e43-4d6d5f8e00a9", false, "staff@mefisto.com" },
                    { "634824c3-1db4-4c59-af21-80267fa7ae00", 0, null, null, "d546ed70-5df3-45ae-a008-1445848975f2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@basic.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "BASIC@BASIC.COM", "BASIC@BASIC.COM", "AQAAAAEAACcQAAAAEOTdtgxZdhxLB9tSnZF3B8Yo+nPEiPfDIxgpN1lQQbcEzbEczy0jnnAVSo+3DqSG2w==", null, false, null, "3f700215-bf2b-4422-90d9-71305dbdc84d", false, "basic@basic.com" },
                    { "77e8fe47-ad47-44b9-8fe7-d7398f98c80e", 0, null, null, "9a5b9e3e-c3a6-4795-853f-145a20aaeab6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "editor@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "EDITOR@MEFISTO.COM", "EDITOR@MEFISTO.COM", "AQAAAAEAACcQAAAAEMc2GKulKYn6wR6h0/LGvuXQvj9mJIpunZTA0Oe6TxjUM3v+qtDzqUlZjNCJfOrXyA==", null, false, null, "e55257ba-ba42-445c-8d99-bed3a4c59fa2", false, "editor@mefisto.com" },
                    { "bfd81596-d4c7-4236-9112-1dab11048210", 0, null, null, "b40e8b99-7c8c-47e8-9e3e-8834e8ddcf88", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "ADMIN@MEFISTO.COM", "ADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAEKhVUn8xw2Dy+MfACGjSviN3r7mQOn9YXSL6JW1wx9G1+g3bHpeGYiJG1NPQxU8K4g==", null, false, null, "1c0ff3a1-80d4-4282-baab-f6613644997e", false, "admin@mefisto.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "264cc9f6-718e-422b-9233-c011ca3f12b0", "Announcements" },
                    { "42b7c00a-47e7-406e-9842-5b85abc26f75", "Review" },
                    { "a7df97b7-2a7a-4a42-99ea-ff8221ee2eb3", "Features" },
                    { "de0256b1-9592-49f9-a33e-87b10fd5da20", "Interview" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "33d6329f-cd13-4929-90d2-0a3c8015e78e", "39738235-8493-453a-abea-2573efe727c4" },
                    { "9216d8dc-d1cb-4768-946b-a6aae076b053", "634824c3-1db4-4c59-af21-80267fa7ae00" },
                    { "6df28832-7c96-4e04-96a0-0cda4e2bba0b", "77e8fe47-ad47-44b9-8fe7-d7398f98c80e" },
                    { "11954cc1-242b-46be-a16c-0c8a1db982ea", "bfd81596-d4c7-4236-9112-1dab11048210" }
                });
        }
    }
}
