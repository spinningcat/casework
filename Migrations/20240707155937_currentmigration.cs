using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exampleapp.Migrations
{
    /// <inheritdoc />
    public partial class currentmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoachField",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkingDepartment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    YearsEnrolled = table.Column<int>(type: "int", nullable: false),
                    AcademicBackground = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastTwoYearsExperience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalCoachEffect = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PossibleDevelopment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelfEducation = table.Column<int>(type: "int", nullable: false),
                    BeliefDevelopment = table.Column<int>(type: "int", nullable: false),
                    LeadershipFeature = table.Column<int>(type: "int", nullable: false),
                    EmotionalOpenness = table.Column<int>(type: "int", nullable: false),
                    EmotionalShare = table.Column<int>(type: "int", nullable: false),
                    TimetoSpareforCoaching = table.Column<int>(type: "int", nullable: false),
                    LikeCoaching = table.Column<int>(type: "int", nullable: false),
                    MotivationReasoning = table.Column<int>(type: "int", nullable: false),
                    Supporting = table.Column<int>(type: "int", nullable: false),
                    HaveTimetoListen = table.Column<int>(type: "int", nullable: false),
                    KnowListening = table.Column<int>(type: "int", nullable: false),
                    AcceptanceDefeat = table.Column<int>(type: "int", nullable: false),
                    KnowingEmpathy = table.Column<int>(type: "int", nullable: false),
                    Positiveness = table.Column<int>(type: "int", nullable: false),
                    CoachingAbility = table.Column<int>(type: "int", nullable: false),
                    WillingToBeCoached = table.Column<int>(type: "int", nullable: false),
                    ToleranceToAnything = table.Column<int>(type: "int", nullable: false),
                    PeopleWellness = table.Column<int>(type: "int", nullable: false),
                    SupportingPeople = table.Column<int>(type: "int", nullable: false),
                    FeatureOriented = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoachField", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoachField");
        }
    }
}
