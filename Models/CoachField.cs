using System.ComponentModel.DataAnnotations;

namespace exampleapp.Models
{
    public class CoachField
    {
        public int Id { get; set; } // Primary Key (usually auto-incrementing)
      
        [Required(ErrorMessage = "Field cannot be empty")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string WorkingDepartment { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int Experience { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int YearsEnrolled { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string AcademicBackground { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string LastTwoYearsExperience { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string[] Abilities { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string Reason { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string InternalCoachEffect { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string PossibleDevelopment { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int SelfEducation { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int BeliefDevelopment { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int LeadershipFeature { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int EmotionalOpenness { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int EmotionalShare { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int TimetoSpareforCoaching { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int LikeCoaching { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int MotivationReasoning { get; set; }

        [Required(ErrorMessage = "Field cannot be empty")]
        public int Supporting { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int HaveTimetoListen { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int KnowListening { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int AcceptanceDefeat { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int KnowingEmpathy { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int Positiveness { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int CoachingAbility { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int WillingToBeCoached { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int ToleranceToAnything { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int PeopleWellness { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int SupportingPeople { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public int FeatureOriented { get; set; }
        public bool Status { get; set; }

    }
}
