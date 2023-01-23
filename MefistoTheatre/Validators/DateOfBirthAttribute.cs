using System.ComponentModel.DataAnnotations;

namespace MefistoTheatre.Validators
{
    public class DateOfBirthAttribute : ValidationAttribute
    {
        public int MinAge { get; set; }
        public int MaxAge { get; set; }

        public override bool IsValid(object? value)
        {
            // Check if value is null.
            if (value == null)
                return true;

            // Cast the object to a datetime object.
            var val = (DateTime)value;

            if (val.AddYears(MinAge) > DateTime.Now)
                return false;

            return (val.AddYears(MaxAge) > DateTime.Now);
        }
    }
}
